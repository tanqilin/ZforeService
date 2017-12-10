using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZforeFromwork.Database.Entity
{
    [Table("TLog")]
    public class Log
    {
        [Key]
        public int LogID { get; set; }

        public DateTime LogDateTime { get; set; }

        public string UserCode { get; set; }

        public string Event { get; set; }

        public string msg { get; set; }

        public bool Result { get; set; }

        public string Computer { get; set; }
    }
}
