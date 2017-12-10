using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZforeFromwork.Database.Entity;

namespace ZforeFromwork.Database
{
    public class SqlContext : DbContext
    {
        /// <summary>
        /// 使用EF框架操作已有数据库
        /// </summary>
        private static string connsql = "Password=root;Persist Security Info=True;User ID=sa;Initial Catalog=AXData;Data Source=."; // 数据库连接字符
        public SqlContext() : base(connsql) { }

        public DbSet<Employee> TEmployee { get; set; }
        public DbSet<Log> TLog { get; set; }
        public DbSet<Job> TJob { get; set; }
        public DbSet<DeptA> TDeptA { get; set; }
    }
}
