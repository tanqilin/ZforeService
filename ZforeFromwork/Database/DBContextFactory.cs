using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ZforeFromwork.Database
{
    public partial class DBContextFactory
    {
        /// <summary>
        /// 获取线程内唯一的AppBoxMvcContext对象
        /// </summary>
        /// <returns></returns>
        public static SqlContext GetDbContext()
        {
            // 首先先线程上下文中查看是否有已存在的DBContext
            // 如果有那么直接返回这个，如果没有就新建 
            SqlContext DB = CallContext.GetData("SqlContext") as SqlContext;
            if (DB == null)
            {
                DB = new SqlContext();
                CallContext.SetData("SqlContext", DB);
            }
            return DB;
        }
    }
}
