using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZforeFromwork.Database.Entity
{
    [Table("TProjects")]
    public partial class Project : BaseEntity
    {
        [Key]
        public int ProjectID { get; set; }

        public string ProjectNum { get; set; }

        public string ProjectName { get; set; }

        public string ProjectDeleted { get; set; }

        public string ProjectNote { get; set; }
    }
}
