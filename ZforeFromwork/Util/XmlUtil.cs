using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZforeFromwork.Model;

namespace ZforeFromwork.Util
{
    /// <summary>
    /// xml 操作类
    /// </summary>
    public class XmlUtil
    {
        public static Config ReadConfig()
        {
            Config config = new Config();

            config.projectNum = "5201314";
            config.projectName = "未来方舟D1组团";
            config.onloadUrl = "http://127.0.0.1/";

            return config;
        }
    }
}
