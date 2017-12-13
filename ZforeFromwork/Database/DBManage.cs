using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using ZforeFromwork.Util;

namespace ZforeFromwork.Database
{
    /// <summary>
    /// 数据库备份及恢复
    /// </summary>
    public class DBManage
    {
        /// <summary>
        /// 备份文件存放路径
        /// </summary>
        public static string DbFile = AppDomain.CurrentDomain.BaseDirectory + "data\\backup\\";
        
        /// <summary>
        /// 数据库备份/还原
        /// </summary>
        /// <param name="type">ture:备份，false:还原</param>
        public static void CopyDatabase(bool type,string restore = null)
        {
            /// 数据库被人文件存放路径
            if (!Directory.Exists(DbFile)) Directory.CreateDirectory(DbFile);

            SqlConnection context = new SqlConnection("Data Source=.;Initial Catalog=master;uid=sa;pwd=root;");
            SqlCommand command = new SqlCommand();
            try
            {
                context.Open();
                command.Connection = context;
                command.CommandType = CommandType.Text;
                /// 备份 
                if (type) {
                    command.CommandText = @"BACKUP DATABASE AXData TO disk='"+ DbFile + DateTime.Now.ToString("yyyyMMdd")+ ".dat'";
                }
                else /// 还原
                {
                    command.CommandText = @"RESTORE DATABASE AXData FROM disk='" + DbFile + restore + ".dat'";
                }
                command.ExecuteNonQuery();
                if (type)
                    LogUtil.MsgLog("恭喜，数据库备份成功！");
                else
                    LogUtil.MsgLog("恭喜，数据库还原成功！");
            }
            catch (SqlException sexc)
            {
                if(type)
                    LogUtil.MsgLog("数据库备份失败，原因：" + sexc);
                else
                    LogUtil.MsgLog("数据库还原失败，原因：" + sexc);
            }
            finally
            {
                command.Dispose();
                context.Close();
                context.Dispose();
            }
        }
    }
}
