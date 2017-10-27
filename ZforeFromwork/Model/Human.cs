using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZforeFromwork.Model
{
    public partial  class Human
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Gender { get; set; }

        public string Age { get; set; }

        public string Birthday { get; set; }

        public string Number { get; set; }

        public string Address { get; set; }

        public byte[] Picture { get; set; }

        /// <summary>
        /// 是否离职
        /// </summary>
        public string Leave { get; set; }

        /// <summary>
        /// 离职日期
        /// </summary>
        public string LeaveDate { get; set; }

        /// <summary>
        /// 所属班组名
        /// </summary>
        public string GroupName { get; set; }

        /// <summary>
        /// 工种编号
        /// </summary>
        public string WorkCode { get; set; }

        public DateTime Remark { get; set; }

        #region 通用属性

        public bool IsSaved { get; set; }

        public bool IsDelete { get; set; }

        public DateTime UpdateTime { get; set; }

        public DateTime CreateTime { get; set; }
        #endregion
    }
}
