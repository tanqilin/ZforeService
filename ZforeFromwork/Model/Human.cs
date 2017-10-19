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

        public string Number { get; set; }

        public string Address { get; set; }

        public string Picture { get; set; }

        public string Remark { get; set; }

        #region 通用属性

        public bool IsSaved { get; set; }

        public bool IsDelete { get; set; }

        public DateTime UpdateTime { get; set; }

        public DateTime CreateTime { get; set; }
        #endregion
    }
}
