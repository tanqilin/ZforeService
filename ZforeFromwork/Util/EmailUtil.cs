using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace ZforeFromwork.Util
{
    /// <summary>
    /// 邮件发送服务
    /// </summary>
    public class EmailUtil
    {
        private static readonly string SEND_EMAIL_ADDRESS = "18302644278@163.com";
        private static readonly string EMEIL_PASSWORD = "0510email";
        private static readonly string SMTP_ADDRESS = "smtp.163.com";

        /// <summary>
        /// 发送邮件到指定的邮箱
        /// </summary>
        /// <param name="toEmails">接受方邮箱列表</param>
        /// <param name="subject">邮件标题</param>
        /// <param name="mailbody">邮件内容</param>
        /// <returns></returns>
        public static bool sendTo(List<string> toEmails, string subject, string mailbody)
        {
            MailMessage mailObj = new MailMessage();

            // 添加多个收件人邮箱地址
            foreach (string toEmail in toEmails)
            {
                mailObj.To.Add(toEmail);
            }

            try
            {
                // 配置发送邮箱及发送内容
                mailObj.From = new MailAddress(SEND_EMAIL_ADDRESS); //发送人邮箱地址   
                mailObj.Subject = subject;  //主题
                mailObj.Body = mailbody;  //正文,
                mailObj.IsBodyHtml = true; //表示正文内容是HTML

                SmtpClient smtp = new SmtpClient();
                smtp.Host = SMTP_ADDRESS;     //smtp服务器名称
                smtp.UseDefaultCredentials = true;
                smtp.Credentials = new NetworkCredential(SEND_EMAIL_ADDRESS, EMEIL_PASSWORD); //发送人的登录名和密码
                smtp.Send(mailObj);
                return true;
            }
            catch (Exception err)
            {
                LogUtil.ErrorLog("========= 邮件发送失败 =========！");
                LogUtil.ErrorLog(err.StackTrace);
                return false;
            }
        }
    }
}
