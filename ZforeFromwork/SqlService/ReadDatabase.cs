using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Text;
using ZforeFromwork.Model;
using ZforeFromwork.Util;

namespace ZforeFromwork.SqlService
{
    /// <summary>
    /// 从数据库中读取需要同步的数据
    /// </summary>
    public class ReadDatabase : BaseContext
    {
        #region 初始化数据库数据
        public bool InitDatabase()
        {
            /// 如果已经配置过一次了则不再插入数据
            string cinfig = XmlUtil.configPath + "config.xml";
            if (File.Exists(cinfig)) return true;

            string insertWork, createPro;
            try
            {
                // 从配置文件读取sql语句
                if (!File.Exists(XmlUtil.datePath + "WorkType.sql")) return false;
                // 下边的方法读取txt不会出现乱码
                FileStream fs = new FileStream(XmlUtil.datePath + "WorkType.sql", FileMode.Open);
                StreamReader sr = new StreamReader(fs, Encoding.Default);
                string script = sr.ReadToEnd();
                insertWork = String.Format(script.Replace("dbo.", ""));
                sr.Close();
                fs.Close();

                // 读取创建项目信息表脚本
                FileStream proFs = new FileStream(XmlUtil.datePath + "TProjects.sql", FileMode.Open);
                StreamReader proSr = new StreamReader(proFs, Encoding.Default);
                createPro = proSr.ReadToEnd();
                proSr.Close();
                proFs.Close();
            }
            catch {
                return false;
            }
            // 开启数据库事务
            context.OpenConnection();
            SqlTransaction sqlTransaction = context.Connection.BeginTransaction();
            SqlCommand sqlCommand = new SqlCommand(insertWork, context.Connection);
            sqlCommand.Connection = context.Connection;
            sqlCommand.Transaction = sqlTransaction;
            try
            {
                // 修改表结构和插入基础数据 
                sqlCommand.ExecuteNonQuery();
                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.CommandText = "ALTER TABLE TEmployee ADD Dahua IMAGE DEFAULT NULL";
                sqlCommand.ExecuteNonQuery();
                sqlCommand.CommandText = "ALTER TABLE TEmployee ADD EmployeeProNum nvarchar DEFAULT NULL";
                sqlCommand.ExecuteNonQuery();
                sqlCommand.CommandText = createPro;
                sqlCommand.ExecuteNonQuery();
                sqlTransaction.Commit();
            }
            catch
            {
                // 事务回滚
                sqlTransaction.Rollback();
                LogUtil.WaringLog("数据库初始化失败。。。请删除原有数据库！再重新附加data文件夹下的备份数据库！");
                return false;
            }
            finally
            {
                context.CloseConnection();
            }
            return true;
        }
        #endregion

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

                    try
                    {
                        Human human = new Human
                        {
                            Id = dr.GetInt32(dr.GetOrdinal("EmployeeID")),
                            Name = dr.GetString(dr.GetOrdinal("EmployeeName")),
                            Gender = dr.GetBoolean(dr.GetOrdinal("Sex")) == true ? "女" : "男",
                            Birthday = dr.GetDateTime(dr.GetOrdinal("Birthday")).ToString("yyyy-MM-dd"),
                            Number = dr.GetString(dr.GetOrdinal("PersonCode")),
                            Address = dr.GetString(dr.GetOrdinal("Home")),
                            Leave = dr.GetBoolean(dr.GetOrdinal("Leave")).ToString().ToLower(),
                            LeaveDate = dr.IsDBNull(dr.GetOrdinal("LeaveDate")) ? "" : dr.GetDateTime(dr.GetOrdinal("LeaveDate")).ToString("yyyy-MM-dd"),
                            GroupName = dr.IsDBNull(dr.GetOrdinal("DeptName")) ? "" : dr.GetString(dr.GetOrdinal("DeptName")),
                            WorkCode = dr.IsDBNull(dr.GetOrdinal("JobCode")) ? "" : dr.GetString(dr.GetOrdinal("JobCode")),
                            Picture = (byte[])dr["Photo"],
                        };
                        humans.Add(human);
                    }
                    catch
                    {
                        LogUtil.WaringLog("database to entity error！");
                        humans = null;
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                LogUtil.WaringLog("database read error...");
                return humans = null;
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
