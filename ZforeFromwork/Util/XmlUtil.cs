using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Linq;
using ZforeFromwork.Model;

namespace ZforeFromwork.Util
{
    /// <summary>
    /// xml 操作类
    /// </summary>
    public class XmlUtil
    {
        /// 配置文件config.xml路径
        public static string datePath = AppDomain.CurrentDomain.BaseDirectory + "\\data\\";
        public static string configPath = AppDomain.CurrentDomain.BaseDirectory + "\\conf\\";

        #region 写入配置文件
        /// <summary>
        /// 写入配置信息
        /// </summary>
        /// <param name="config">配置信息</param>
        public static void WriteConfig(Config config)
        {
            if (!Directory.Exists(configPath))
                Directory.CreateDirectory(configPath);

            //创建一个config.xml程序，写入同步配置文件
            System.Data.DataSet ds = new System.Data.DataSet("Config");
            System.Data.DataTable table = new System.Data.DataTable("System");
            ds.Tables.Add(table);
            table.Columns.Add("ProjectNum", typeof(string));
            table.Columns.Add("ProjectName", typeof(string));
            table.Columns.Add("OnloadUrl", typeof(string));
            table.Columns.Add("HumanSql", typeof(string));
            table.Columns.Add("AttendSql", typeof(string));

            System.Data.DataRow row = table.NewRow();
            row[0] = config.projectNum;
            row[1] = config.projectName;
            row[2] = config.onloadUrl;
            try
            {
                FileInfo file = new FileInfo(datePath+ "QueryHuman.sql");
                string script = file.OpenText().ReadToEnd();
                row[3] = script.Replace("dbo.", "");
            }
            catch
            {
                row[3] = "select top(1) * from TEmployee where Car != 1";
            }
            row[4] = "select * from TEmployee";

            ds.Tables["System"].Rows.Add(row);
            ds.WriteXml(configPath+ "config.xml");
        }
        #endregion

        #region 读取配置文件
        /// <summary>
        /// 读取配置信息
        /// </summary>
        /// <returns>Xml中的配置信息</returns>
        public static Config ReadConfig()
        {
            string cinfigFile = configPath + "config.xml";
            Config config = new Config();
            
            // 文件存在
            if (File.Exists(cinfigFile))
            {
                XDocument doc = XDocument.Load(cinfigFile);
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
                                case "HumanSql": config.humanSql = item1.Value; break;
                                case "AttendSql": config.attendSql = item1.Value; break;
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

        #region 创建人员信息Xml
        /// <summary>
        /// 生成人员信息Xml字符串
        /// </summary>
        /// <param name="data">人员信息</param>
        /// <returns>Xml字符串</returns>
        public static string CreateHumanXml(List<Human> data)
        {
            // 读取配置信息
            var config = ReadConfig();

            XmlDocument doc = new XmlDocument();
            XmlDeclaration dec = doc.CreateXmlDeclaration("1.0", "GB2312", null);
            doc.AppendChild(dec);

            XmlElement root = doc.CreateElement("Message");
            doc.AppendChild(root);

            // Xml配置标签
            XmlElement nodeProject = doc.CreateElement("Project");
            nodeProject.SetAttribute("name", config.projectName);
            nodeProject.SetAttribute("num", config.projectNum);
            nodeProject.SetAttribute("url", config.onloadUrl);
            root.AppendChild(nodeProject);

            // Xml内容List
            XmlNode node = doc.CreateElement("List");
            foreach (Human item in data)
            {
                // 节点身份证号不能为空
                if (String.IsNullOrEmpty(item.Number)) continue;

                XmlElement nodeHuman = doc.CreateElement("Human");
                nodeHuman.SetAttribute("name", item.Name);
                nodeHuman.SetAttribute("birthday", item.Birthday);
                nodeHuman.SetAttribute("gender", item.Gender == "男"?"1":"0");
                nodeHuman.SetAttribute("idcard", item.Number);
                nodeHuman.SetAttribute("address", item.Address);
                nodeHuman.SetAttribute("leave", item.Leave);
                nodeHuman.SetAttribute("leavedate", item.LeaveDate);
                nodeHuman.SetAttribute("group", item.GroupName);
                nodeHuman.SetAttribute("workcode", item.WorkCode);
                nodeHuman.SetAttribute("photo", System.Convert.ToBase64String(item.Picture));
                node.AppendChild(nodeHuman);
            }
            root.AppendChild(node);

            // 创建一个文件夹存储上传的数据
            if (!Directory.Exists(datePath))
                Directory.CreateDirectory(datePath);
            doc.Save(datePath + "Human.xml");
            // 把xml转换为xml字符串
            return doc.OuterXml;
        }
        #endregion

        #region 创建心跳请求Xml
        public static string CreateHeart()
        {
            // 读取配置信息
            var config = ReadConfig();

            XmlDocument doc = new XmlDocument();
            XmlDeclaration dec = doc.CreateXmlDeclaration("1.0", "GB2312", null);
            doc.AppendChild(dec);

            XmlElement root = doc.CreateElement("Message");
            doc.AppendChild(root);

            // Xml配置标签
            XmlElement nodeProject = doc.CreateElement("Project");
            nodeProject.SetAttribute("name", config.projectName);
            nodeProject.SetAttribute("num", config.projectNum);
            nodeProject.SetAttribute("url", config.onloadUrl);
            root.AppendChild(nodeProject);

            // 把xml转换为xml字符串
            return doc.OuterXml;
        }
        #endregion

        #region 解析人员上报结果
        /// <summary>
        /// 接续人员上报WebService返回的结果
        /// </summary>
        /// <param name="resultXml">Xml结果字符串</param>
        /// <returns>结果集合</returns>
        public static List<HumanResult> ReadHumanResultXml(string resultXml)
        {
            List<HumanResult> results = new List<HumanResult>();
            XmlDocument document = new XmlDocument();
            document.LoadXml(resultXml);

            if (document != null)
            {
                XmlNodeList HumanList = document.GetElementsByTagName("List");

                // 找到List节点
                foreach (XmlElement item in HumanList)
                {
                    // 遍历 List 下得所有Human节点 
                    foreach (XmlElement item1 in item.GetElementsByTagName("Result"))
                    {
                        HumanResult result = new HumanResult();
                        result.Result = item1.GetAttribute("result").ToString();
                        result.IdCard = item1.GetAttribute("idcard").ToString();
                        results.Add(result);
                    }
                }
            }
            else
            {
                results = null;
            }
            return results;
        }
        #endregion
    }
}
