using System.Data.SqlClient;

namespace ZforeFromwork.SqlService
{
    /// <summary>
    /// 数据库连接管理类
    /// </summary>
    public partial class SqlContext
    {
        private static string connsql = "Password=root;Persist Security Info=True;User ID=sa;Initial Catalog=AXData;Data Source=."; // 数据库连接字符

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
    }
}
