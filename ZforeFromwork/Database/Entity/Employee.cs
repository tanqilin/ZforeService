using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZforeFromwork.Database.Entity
{
    [Table("TEmployee")]
    public partial class Employee : BaseEntity
    {
        [Key]
        public int EmployeeID { get; set; }

        public string EmployeeCode { get; set; }

        public string EmployeeName { get; set; }

        public string EnglishName { get; set; }

        public string CardNo { get; set; }

        public string pin { get; set; }

        public bool EmpEnable { get; set; }

        public bool? Sex { get; set; }

        public DateTime Birthday { get; set; }

        public string PersonCode { get; set; }

        public string Home { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public string Car { get; set; }

        public int? JobID { get; set; }

        public int? DeptID { get; set; }

        /// <summary>
        /// 身份证图片和抓拍图片
        /// </summary>
        public byte[] Photo { get; set; }
        public byte[] Dahua { get; set; }
        /// <summary>
        /// 身份证有效起始日期
        /// </summary>
        public string EffectedDate { get; set; }
        /// <summary>
        /// 身份证有效截止日期
        /// </summary>
        public string ExpiredDate { get; set; }
        public DateTime? RegDate { get; set; }

        public DateTime? EndDate { get; set; }

        public int? ACCESSID { get; set; }

        public bool? Deleted { get; set; }

        public bool Leave { get; set; }

        public DateTime? LeaveDate { get; set; }

        public bool BeKQ { get; set; }

        public string Password { get; set; }

        public int? MapID { get; set; }

        public int? XPoint { get; set; }

        public int? YPoint { get; set; }

        public bool MapVisible { get; set; }

        public int? OwnerDoor { get; set; }

        public int? LastEventID { get; set; }

        public int? Event2EmpID { get; set; }

        public int? Status { get; set; }

        public DateTime? TimeStampx { get; set; }

        public bool ShowCardNo { get; set; }

        public string Note1 { get; set; }

        public string Note2 { get; set; }

        public string Note3 { get; set; }

        public string Note4 { get; set; }

        public string Note5 { get; set; }

        public DateTime? TimeStamp { get; set; }

        public bool isBlackCard { get; set; }

        public string AcsString { get; set; }

        public string EmployeeProNum { get; set; }
    }
}
