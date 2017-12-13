using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZforeFromwork.Database.Entity
{
    [Table("TVideo")]
    public class Video:BaseEntity
    {
        [Key]
        public int VideoID { get; set; }

        public string IP { get; set; }

        public int Port { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public string VideoName { get; set; }

        public bool Enable { get; set; }
    }
}
