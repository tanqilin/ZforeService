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
            
            while (true)
            {
                LogUtil.MsgLog("线程启动！");
                Thread.Sleep(5000);

                // 根据网络状况同步信息
                if (!NetStateUtil.LocalConnectionStatus())
                {
                    LogUtil.MsgLog("网络无连接！");
                    continue;
                }
                LogUtil.MsgLog("网络已连接！");

                // 从数据库读取数据
                ReadDatabase read = new ReadDatabase();
                var data = read.ReadHumanInfo("男");

                // 调用webservice例子
                UploadWebservice.UploadWebservice webservice = new UploadWebservice.UploadWebservice();
                string result = webservice.HelloWorld("---- web-service ------");

                foreach (Human item in data)
                {
                    LogUtil.MsgLog(item.Name + "," + item.Number);
                }
                Thread.Sleep(2000);
            }
        }
    }
}
