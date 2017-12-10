using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZforeFromwork.Database.Model
{
    /// <summary>
    /// 班组模型
    /// </summary>
    public class DeptAModel:BaseModel
    {
        public int DeptID { get; set; }

        public int UpDeptID { get; set; }

        public int DeptLevel { get; set; }

        public string DeptName { get; set; }

        public string DeptNote { get; set; }
    }
}
