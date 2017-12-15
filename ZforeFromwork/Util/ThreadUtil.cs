using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using ZforeFromwork.Database;
using ZforeFromwork.Database.Entity;
using ZforeFromwork.Database.Service.Interface;
using ZforeFromwork.Database.Service.Realization;
using ZforeFromwork.Model;
using ZforeFromwork.SqlService;

namespace ZforeFromwork.Util
{
    /// <summary>
    /// 发送数据线程，定时向服务器发送更新的数据
    /// </summary>
    public class ThreadUtil
    {
        #region 属性和构造函数
        private static Thread humanThread;
        private static Thread attendThread;
        private static Thread managerThread;
        private static IEmployeeService _employeeService = new EmployeeService();
        #endregion

        #region 启动线程
        /// <summary>
        /// 人员信息上传线程
        /// </summary>
        public static void HttpSendHuman()
        {
            LogUtil.ClearLog("humanLog");
            /// 创建线程并执行
            humanThread = new Thread(new ThreadStart(ReadHumanData));
            humanThread.Start();
        }

        /// <summary>
        /// 考勤信息上传线程
        /// </summary>
        public static void HttpSendAttend()
        {
            LogUtil.ClearLog("attendLog");
            attendThread = new Thread(new ThreadStart(ReadAttendData));
            attendThread.Start();
        }

        /// <summary>
        /// 管理两个线程，当任意一个意外奔溃时，马上唤醒它
        /// </summary>
        public static void ThreadManage()
        {
            LogUtil.ClearLog("manageLog");
            managerThread = new Thread(new ThreadStart(ManageThread));
            managerThread.Start();
        }
        #endregion

        #region 线程体
        /// <summary>
        /// 读取人员信息并发送
        /// </summary>
        static void ReadHumanData()
        {
            LogUtil.MsgLog("human up start！", "humanLog");
            while (true)
            {
                // 根据网络状况同步信息
                if (!NetStateUtil.LocalConnectionStatus())
                {
                    LogUtil.MsgLog("Network connectionless! Try again in 5 minutes", "humanLog");
                    Thread.Sleep(5*60000);
                    continue;
                }

                // 从数据库读取数据并转换未Xml字符串
                Employee employee = _employeeService.GetNewData();
                if (employee == null)
                {
                    LogUtil.MsgLog("There is no new data! Try again in 15 minutes", "humanLog");
                    Thread.Sleep(15 * 60000);
                    continue;
                }

                string ListHuman = XmlUtil.CreateHumanXml(employee);
                try
                {
                    Thread.Sleep(1000);
                    /// 格式化URL并发送上传请求
                    Config config = XmlUtil.ReadConfig();
                    string url = String.Format(Config.up_human_url, config.onloadUrl);
                    string result = HttpRequest.SendPostHttpRequest(url,ListHuman, Encoding.UTF8);
                    HumanResultHandle(result);
                }
                catch
                {
                    /// 如果调用Http接口出错则调用WebService接口
                    try
                    {
                        UploadWebservice.UploadWebservice webservice = new UploadWebservice.UploadWebservice();
                        webservice.Timeout = 15000;
                        LogUtil.MsgLog("调用WebService", "humanLog");
                        string result = webservice.UpHumanInfo(ListHuman);
                    }
                    catch { }
                    Thread.Sleep(60000);
                    LogUtil.MsgLog("WebService not runing! Try again in 5 minutes", "humanLog");
                }
                Thread.Sleep(60000);
            }
        }

        /// <summary>
        /// 读取考勤信息并发送(目前是定时备份数据库)
        /// </summary>
        static void ReadAttendData()
        {
            LogUtil.MsgLog("attend start！","attendLog");
            while (true)
            {
                DBManage.CopyDatabase(true);
                Thread.Sleep(60*60000);
            }
        }

        /// <summary>
        /// 管理线程(发送心跳)
        /// </summary>
        static void ManageThread()
        {
            LogUtil.MsgLog("heart start ...！", "manageLog");
            while (true)
            {
                // 根据网络状况同步信息
                if (!NetStateUtil.LocalConnectionStatus())
                {
                    LogUtil.MsgLog("Network connectionless! Try again in 5 minutes", "manageLog");
                    Thread.Sleep(5 * 60000);
                    continue;
                }

                try
                {
                    /// 封装心跳包请求信息
                    string projectInfo = XmlUtil.CreateHeart();

                    /// 格式化URL并发送上传请求
                    Config config = XmlUtil.ReadConfig();
                    string url = String.Format(Config.up_heart_url, config.onloadUrl);
                    string result = HttpRequest.SendPostHttpRequest(url, projectInfo, Encoding.UTF8);
                    LogUtil.MsgLog("I'm Life.. " + result, "manageLog");
                }
                catch
                {
                    Thread.Sleep(60000);
                    LogUtil.MsgLog("WebService not runing! Try again in 10 minutes", "manageLog");
                }

                Thread.Sleep(10*60000);
            }
        }
        #endregion

        #region 上传结果处理
        /// <summary>
        /// 人员上传结果处理
        /// </summary>
        private static void HumanResultHandle(string result = null)
        {
            if (String.IsNullOrEmpty(result) || result == "false")
            {
                LogUtil.WaringLog("上传失败（验证不通过）...");
                return;
            }

            /// 解析上报的结果
            List <HumanResult> results = XmlUtil.ReadHumanResultXml(result);
            if (results == null || results.Count == 0) throw new Exception();
            LogUtil.MsgLog(result, "humanLog");

            /// 更新已上传的记录
            Employee employee = _employeeService.GetEmployeeByIDCard(results[0].IdCard);
            employee.Car = "1";
            _employeeService.UpdateEmployee(employee);

            ReadDatabase command = new ReadDatabase();
            command.HumanResultSql(results);
        }
        #endregion
    }
}
