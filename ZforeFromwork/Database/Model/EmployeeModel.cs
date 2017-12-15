using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZforeFromwork.Database.Model
{
    public class EmployeeModel : BaseModel
    {
        public int EmployeeID { get; set; }

        //public string EmployeeCode { get; set; }

        public string EmployeeName { get; set; }

        [Display(Name = "门禁卡")]
        public string CardNo { get; set; }

        [Display(Name = "性别")]
        public string SexStr { get; set; }

        public DateTime Birthday { get; set; }

        public string PersonCode { get; set; }

        [Display(Name = "家庭地址")]
        //public string Home { get; set; }

        public byte[] Photo { get; set; }

        /// <summary>
        /// 是否离职(ture:否，false:在)
        /// </summary>
        public string Leave { get; set; }

        public string ProjectName { get; set; }
    }
}
