using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZforeFromwork.Model
{
    public partial class Config
    {
        public string projectNum { get; set; }

        public string projectName { get; set; }

        public string onloadUrl { get; set; }

        public string humanSql { get; set; }

        public string attendSql { get; set; }

        public static string up_human_url = "http://{0}/SysnUpload/UpHumanInfo";
    }
}
