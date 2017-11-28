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

        /// <summary>
        /// 上传人员信息URL (HTTP:POST)
        /// </summary>
        public static string up_human_url = "http://{0}/SysnUpload/UpHumanInfo";

        /// <summary>
        /// 终端节点发送心跳请求 (HTTP:POST)
        /// </summary>
        public static string up_heart_url = "http://{0}/SysnUpload/InMyHeart";
    }
}
