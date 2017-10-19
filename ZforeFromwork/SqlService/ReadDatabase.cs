using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZforeFromwork.Model;

namespace ZforeFromwork.SqlService
{
    /// <summary>
    /// 从数据库中读取需要同步的数据
    /// </summary>
    public class ReadDatabase : BaseContext
    {
        #region 读取农民工刷卡信息

        public List<Human> ReadHumanInfo(string state)
        {
            string sql = String.Format("select * from Users where Gender = '{0}'", state);

            // 数据容器
            List<Human> humans = new List<Human>();
            try
            {
                context.OpenConnection();
                SqlCommand command = new SqlCommand(sql, context.Connection);
                SqlDataReader dr = command.ExecuteReader();

                while (dr.Read())
                {
                    Human human = new Human
                    {
                        Id = dr.GetInt32(dr.GetOrdinal("id")),
                        Name = dr.GetString(dr.GetOrdinal("Name")),
                        Gender = dr.GetString(dr.GetOrdinal("Gender")),
                        Number = dr.GetString(dr.GetOrdinal("Email")),
                        CreateTime = dr.GetDateTime(dr.GetOrdinal("CreateTime")),
                    };
                    humans.Add(human);
                }
            }
            catch (Exception ex)
            {

            }
            return humans;
        }

        #endregion
    }
}
