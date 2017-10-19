using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using ZforeFromwork.Model;

namespace ZforeFromwork.Util
{
    /// <summary>
    /// xml 操作类
    /// </summary>
    public class XmlUtil
    {
        #region 读取配置文件

        public static Config ReadConfig(string path)
        {
            Config config = new Config();
            
            // 文件存在
            if (File.Exists(path))
            {
                XDocument doc = XDocument.Load(path);
                if (doc != null)
                {
                    IEnumerable<XElement> elementlist = doc.Root.Elements("System");

                    // 找到System节点
                    foreach (XElement item in elementlist)
                    {
                        // 遍历 System下得节点
                        foreach (XElement item1 in item.Elements())
                        {
                            switch (item1.Name.ToString())
                            {
                                case "ProjectNum": config.projectNum = item1.Value;break;
                                case "ProjectName": config.projectName = item1.Value; break;
                                case "OnloadUrl": config.onloadUrl = item1.Value; break;
                            }       
                        }
                    }
                }
                else
                {
                    config = null;
                }
            }
            else
            {
                config = null;
            }
            return config;
        }
        #endregion
    }
}
