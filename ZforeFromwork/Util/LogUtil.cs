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
        private static string filePath = @"D:\MyServiceLog.txt";

        /// <summary>
        /// 错误日志
        /// </summary>
        /// <param name="error">错误信息</param>
        public static void ErrorLog(string error)
        {
            using (FileStream stream = new FileStream(filePath, FileMode.Append))
            using (StreamWriter writer = new StreamWriter(stream))
            {
                writer.WriteLine($"{DateTime.Now}，【ERROR】:" + error);
            }

            // 遇到错误则发到邮箱
            List<string> address = new List<string> { "1135574399@qq.com" };
            EmailUtil.sendTo(address,"同步崩溃啦！", $"{DateTime.Now}，【ERROR】:" + error);
        }

        /// <summary>
        /// 运行日志
        /// </summary>
        /// <param name="msg">运行信息</param>
        public static void MsgLog(string msg)
        {
            using (FileStream stream = new FileStream(filePath, FileMode.Append))
            using (StreamWriter writer = new StreamWriter(stream))
            {
                writer.WriteLine($"{DateTime.Now}，【INFO】:" + msg);
            }
        }

        /// <summary>
        /// 警告日志
        /// </summary>
        /// <param name="msg">系统运行警告</param>
        public static void WaringLog(string waring)
        {
            using (FileStream stream = new FileStream(filePath, FileMode.Append))
            using (StreamWriter writer = new StreamWriter(stream))
            {
                writer.WriteLine($"{DateTime.Now}，【WARING】:" + waring);
            }
        }
    }
}
