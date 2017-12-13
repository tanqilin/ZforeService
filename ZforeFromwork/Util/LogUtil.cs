using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZforeFromwork.Util
{
    /// <summary>
    /// 系统日志处理文件
    /// </summary>
    public class LogUtil
    {
        /// 日志文件存放路径
        private static string filePath = AppDomain.CurrentDomain.BaseDirectory + "\\log\\";

        /// <summary>
        /// 错误日志
        /// </summary>
        /// <param name="error">错误信息</param>
        public static void ErrorLog(string error)
        {
            if (!Directory.Exists(filePath)) Directory.CreateDirectory(filePath);

            using (StreamWriter writer = File.AppendText(filePath + "ServiceLog.txt"))
            {
                writer.WriteLine($"{DateTime.Now}，【ERROR】:" + error);
                writer.Close();
            }

            // 遇到错误则发到邮箱
            var config = XmlUtil.ReadConfig();
            string errorMsg = $"{DateTime.Now}，【ERROR】:" + "<" +config.projectName + ">的" + error;
            EmailUtil.sendTo("1135574399@qq.com", "同步崩溃啦！", errorMsg);
        }

        /// <summary>
        /// 运行日志
        /// </summary>
        /// <param name="msg">运行信息</param>
        public static void MsgLog(string msg, string logName = null)
        {
            if (!Directory.Exists(filePath)) Directory.CreateDirectory(filePath);

            if (String.IsNullOrEmpty(logName)) logName = "ServiceLog";
            using (StreamWriter writer = File.AppendText(filePath + logName + ".txt"))
            {
                writer.WriteLine($"{DateTime.Now}，【WARING】:" + msg);
                writer.Close();
            }
        }

        /// <summary>
        /// 警告日志
        /// </summary>
        /// <param name="msg">系统运行警告</param>
        public static void WaringLog(string waring)
        {
            if (!Directory.Exists(filePath)) Directory.CreateDirectory(filePath);

            using (StreamWriter writer = File.AppendText(filePath + "ServiceLog.txt"))
            {
                writer.WriteLine($"{DateTime.Now}，【WARING】:" + waring);
                writer.Close();
            }
        }

        /// <summary>
        /// 清空日志
        /// </summary>
        public static void ClearLog(string logName)
        {
            if (!Directory.Exists(filePath)) Directory.CreateDirectory(filePath);

            if (String.IsNullOrEmpty(logName)) logName = "ServiceLog";

            FileStream stream = new FileStream(filePath + logName + ".txt", FileMode.Create);
            using (StreamWriter writer = new StreamWriter(stream))
            {
                writer.Write("");
                writer.Close();
                stream.Close();
            }
        }
    }
}
