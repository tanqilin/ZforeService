using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZforeFromwork.Database.Entity
{
    /// <summary>
    /// 班组信息表
    /// </summary>
    [Table("TDeptA")]
    public partial class DeptA:BaseEntity
    {
        [Key]
        public int DeptID { get; set; }

        public int UpDeptID { get; set; }

        public int DeptLevel { get; set; }

        public string DeptName { get; set; }

        public string DeptNote { get; set; }
    }
}
