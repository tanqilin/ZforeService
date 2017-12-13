using System;
using System.Data.Entity;
using System.Data.SqlClient;

namespace ZforeFromwork.SqlService
{
    /// <summary>
    /// 数据库连接管理类
    /// </summary>
    public partial class SqlContext
    {
        private static string connsql = "Password=root;Persist Security Info=True;User ID=sa;Initial Catalog={0};Data Source=."; // 数据库连接字符

        /// <summary>
        /// 指定链接的数据库名
        /// </summary>
        /// <param name="dbName"></param>
        public SqlContext(string dbName = null)
        {
            if(String.IsNullOrEmpty(dbName))
                connsql = String.Format(connsql, "AXData");
            else
                connsql = String.Format(connsql, dbName);
        }

        private SqlConnection connection;

        /// <summary>
        /// 获取数据库连接
        /// </summary>
        public SqlConnection Connection
        {
            get
            {
                if (connection == null)
                    connection = new SqlConnection(connsql);

                return connection;
            }
        }

        /// <summary>
        /// 打开数据库连接
        /// </summary>
        public void OpenConnection()
        {
            if (Connection.State == System.Data.ConnectionState.Closed)
            {
                Connection.Open();
            }
            else if(Connection.State == System.Data.ConnectionState.Broken)
            {
                Connection.Close();
                Connection.Open();
            }
        }

        public void CloseConnection()
        {
            Connection.Close();
        }
    }
}
