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
    public class HttpRequestUtil
    {
        public static void HttpRequest()
        {
            Thread thread1 = new Thread(new ThreadStart(ReadDataBase));
            //调用Start方法执行线程
            thread1.Start();
        }

        static void ReadDataBase()
        {
            LogUtil.MsgLog("线程启动！");
            while (true)
            {
                // 根据网络状况同步信息
                if (!NetStateUtil.LocalConnectionStatus())
                {
                    LogUtil.MsgLog("网络无连接！");
                    Thread.Sleep(30000);
                    continue;
                }
              
                // 从数据库读取数据并转换未Xml字符串
                ReadDatabase read = new ReadDatabase();
                List<Human> data = read.ReadHumanInfo();
                if (data == null || data.Count() == 0) continue;

                string ListHuman = XmlUtil.CreateHumanXml(data);

                // 调用webservice上传人员读卡信息
                try
                {
                    UploadWebservice.UploadWebservice webservice = new UploadWebservice.UploadWebservice();
                    webservice.Timeout = 10;
                    // 执行WebService并返回结果
                    ResultHandle(webservice.UpHumanInfo(ListHuman));
                }
                catch (Exception err)
                {
                    Console.WriteLine(err.StackTrace);
                    LogUtil.ErrorLog("服务器停止运行！");
                }
                Thread.Sleep(5000);
            }
        }

        /// <summary>
        /// 人员上传结果处理
        /// </summary>
        private static void ResultHandle(string result = null)
        {
            if (String.IsNullOrEmpty(result) || result == "false")
            {
                LogUtil.ErrorLog("上传失败...");
                return;
            }
           
            /// 解析上报的结果
            List <HumanResult> results = XmlUtil.ReadHumanResultXml(result);

            LogUtil.MsgLog("=====================================");
            foreach (var item in results)
            {
                LogUtil.MsgLog(item.Result + "," + item.IdCard);
            }
            LogUtil.MsgLog("=====================================");

            ReadDatabase Sql = new ReadDatabase();
            Sql.HumanResultSql(results);
        }
    }
}
