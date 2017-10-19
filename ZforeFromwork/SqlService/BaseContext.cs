using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZforeFromwork.SqlService
{
    public partial class BaseContext
    {
        protected  SqlContext context = new SqlContext();

        public BaseContext()
        {
            
        }
    }
}
