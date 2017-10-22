using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZforeFromwork.Model;
using ZforeFromwork.Util;

namespace ZforeFromwork.SqlService
{
    /// <summary>
    /// 从数据库中读取需要同步的数据
    /// </summary>
    public class ReadDatabase : BaseContext
    {
        #region 读取农民工刷卡信息

        public List<Human> ReadHumanInfo()
        {
            // 从配置文件读取sql语句
            var config = XmlUtil.ReadConfig();
            string sql = String.Format(config.humanSql);

            // 数据容器
            List<Human> humans = new List<Human>();
            try
            {
                context.OpenConnection();
                SqlCommand command = new SqlCommand(sql, context.Connection);
                SqlDataReader dr = command.ExecuteReader();

                // 遍历获取到的数据
                while (dr.Read())
                {
                    Human human = new Human
                    {
                        Id = dr.GetInt32(dr.GetOrdinal("EmployeeID")),
                        Name = dr.GetString(dr.GetOrdinal("EmployeeName")),
                        Gender = dr.GetBoolean(dr.GetOrdinal("Sex")) == true?"女":"男",
                        Birthday = dr.GetDateTime(dr.GetOrdinal("Birthday")).ToString("yyyy-MM-dd"),
                        Number = dr.GetString(dr.GetOrdinal("PersonCode")),
                        Address = dr.GetString(dr.GetOrdinal("Home")),
                        Picture = (byte[])dr["Photo"],
                    };
                    humans.Add(human);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                LogUtil.WaringLog("数据库连接失败...");
            }
            return humans;
        }

        #endregion
    }
}
