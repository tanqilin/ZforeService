using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ZforeFromwork.Util
{
    /// <summary>
    /// 发送网络请求
    /// </summary>
    public class HttpRequest
    {
        #region 属性和构造函数

        private static readonly string DefaultUserAgent = "Mozilla/4.0 (compatible; MSIE 5.0; Windows NT; DigExt)";
        private static readonly string DefaultContentType = "application/x-www-form-urlencoded";

        private static bool CheckValidationResult(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors errors)
        {
            return true; //总是接受     
        }

        #endregion

        /// <summary>
        /// 发送HTTP/HTTPS,POST网络请求
        /// </summary>
        /// <param name="url">请求路径</param>
        /// <param name="parameters">请求参数</param>
        /// <param name="charset">请求字符集</param>
        /// <param name="issl">是否为https请求</param>
        /// <returns>返回请求结果</returns>
        public static string SendPostHttpRequest(string url, string parameters, Encoding charset, bool issl = true)
        {
            HttpWebRequest request = null;
            //HTTPSQ请求  
            ServicePointManager.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback(CheckValidationResult);
            request = WebRequest.Create(url) as HttpWebRequest;
            request.ProtocolVersion = HttpVersion.Version10;
            request.Method = "POST";
            request.ContentType = DefaultContentType;
            request.UserAgent = DefaultUserAgent;
            //如果需要POST数据     
            if (!String.IsNullOrEmpty(parameters))
            {
                byte[] data = charset.GetBytes(parameters);
                using (Stream stream = request.GetRequestStream())
                {
                    stream.Write(data, 0, data.Length);
                }
            }
            HttpWebResponse response = request.GetResponse() as HttpWebResponse;

            Stream result_stream = response.GetResponseStream();
            /// 按指定字符集创建一个读取流
            StreamReader sr = new StreamReader(result_stream, charset);
            string result = sr.ReadToEnd();

            return result;
        }

        /// <summary>
        /// 发送HTTP/HTTPS GET请求
        /// </summary>
        /// <param name="url">请求路径</param>
        /// <param name="charset">结果读取字符节</param>
        /// <param name="issl">是否为HTTPS请求</param>
        /// <returns>请求结果字符串</returns>
        public static string SendGetRequest(string url, Encoding charset, bool issl = true)
        {
            HttpWebRequest request = null;
            //HTTPSQ请求  
            ServicePointManager.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback(CheckValidationResult);
            request = WebRequest.Create(url) as HttpWebRequest;
            request.ProtocolVersion = HttpVersion.Version10;
            request.Method = "GET";
            request.ContentType = DefaultContentType;
            request.UserAgent = DefaultUserAgent;

            /// 获取响应
            HttpWebResponse response = request.GetResponse() as HttpWebResponse;
            Stream result_stream = response.GetResponseStream();
            /// 按指定字符集创建一个读取流
            StreamReader sr = new StreamReader(result_stream, charset);

            return sr.ReadToEnd();
        }
    }
}
