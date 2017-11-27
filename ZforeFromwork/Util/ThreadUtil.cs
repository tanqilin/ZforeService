using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
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
                    LogUtil.MsgLog("Net connectionless！ Try again in 5 minutes", "humanLog");
                    Thread.Sleep(5*60000);
                    continue;
                }

                // 从数据库读取数据并转换未Xml字符串
                ReadDatabase read = new ReadDatabase();
                List<Human> data = read.ReadHumanInfo();
                if (data == null || data.Count() == 0)
                {
                    Thread.Sleep(15 * 60000);
                    continue;
                }

                string ListHuman = XmlUtil.CreateHumanXml(data);
                try
                {
                    Config config = XmlUtil.ReadConfig();
                    /// 格式化请求URL并发送请求
                    string url = String.Format(Config.up_human_url, config.onloadUrl);
                    string result = HttpRequest.SendPostHttpRequest(url, ListHuman, Encoding.UTF8);
                    LogUtil.MsgLog(result, "humanLog");

                    //HumanResultHandle(result);
                }
                catch (Exception err)
                {
                    Thread.Sleep(5*60000);
                    Console.WriteLine(err.StackTrace);
                    LogUtil.WaringLog("WebService not runing! Try again in 5 minutes");
                }
                Thread.Sleep(60000);
            }
        }

        /// <summary>
        /// 读取考勤信息并发送
        /// </summary>
        static void ReadAttendData()
        {
            LogUtil.MsgLog("attend start！","attendLog");
            while (true)
            {
                Thread.Sleep(60000);
            }
        }

        /// <summary>
        /// 管理线程
        /// </summary>
        static void ManageThread()
        {
            LogUtil.MsgLog("heart start！", "manageLog");
            while (true)
            {
                try
                {
                    UploadWebservice.UploadWebservice webservice = new UploadWebservice.UploadWebservice();
                    webservice.Timeout = 10000;
                    string projectInfo = XmlUtil.CreateHeart();
                    string result = webservice.InMyHeart(projectInfo);
                    // 在这里做线程维护，先空着
                    LogUtil.MsgLog("I'm Life - " + result, "manageLog");
                }
                catch(Exception err)
                {
                    Thread.Sleep(60000);
                    LogUtil.MsgLog(err.StackTrace, "manageLog");
                }

                Thread.Sleep(30*60000);
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
            LogUtil.MsgLog(result, "humanLog");
            //LogUtil.MsgLog("=====================================", "humanLog");
            //foreach (var item in results)
            //{
            //    LogUtil.MsgLog(item.Result + "," + item.IdCard, "humanLog");
            //}
            //LogUtil.MsgLog("=====================================", "humanLog");

            ReadDatabase Sql = new ReadDatabase();
            Sql.HumanResultSql(results);
        }
        #endregion
    }
}
