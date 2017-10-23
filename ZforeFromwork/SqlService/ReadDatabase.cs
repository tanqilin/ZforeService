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
                    // 读取身份证号不能为空
                    if (String.IsNullOrEmpty(dr.GetString(dr.GetOrdinal("PersonCode")))) continue;

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
                LogUtil.WaringLog(ex.StackTrace);
                LogUtil.WaringLog("数据库连接失败...");
            }
            finally
            {
                context.CloseConnection();
            }
            return humans;
        }

        #endregion

        #region 导入人员信息后执行Sql语句
        /// <summary>
        /// 导入成功后需要执行的sql语句
        /// </summary>
        /// <param name="results"></param>
        public void HumanResultSql(List<HumanResult> results)
        {
            // 从配置文件读取sql语句
            var config = XmlUtil.ReadConfig();

            // 数据容器 ExecuteReader
            List<Human> humans = new List<Human>();
            try
            {
                context.OpenConnection();
               
                foreach (var item in results)
                {
                    if (item.Result == "false") continue;
                 
                    // 上传成功则更新Car字段
                    string sql = String.Format("update TEmployee set Car = 1 where PersonCode = '{0}'", item.IdCard);
                    SqlCommand command = new SqlCommand(sql, context.Connection);
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception err)
            {
                Console.WriteLine(err.StackTrace);
            }
        }

        #endregion
    }
}
