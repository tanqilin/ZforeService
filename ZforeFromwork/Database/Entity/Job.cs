using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZforeFromwork.Database.Entity
{
    [Table("TJob")]
    public partial class Job:BaseEntity
    {
        [Key]
        public int JobID { get; set; }

        public string JobCode { get; set; }

        public string JobName { get; set; }

        public string JobNote { get; set; }
    }
}
