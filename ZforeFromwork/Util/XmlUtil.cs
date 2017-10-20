﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        // 配置文件config.xml路径
        private static string datePath = AppDomain.CurrentDomain.BaseDirectory + "\\date\\";
        private static string configPath = AppDomain.CurrentDomain.BaseDirectory + "\\conf\\";

        #region 写入配置文件
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

            System.Data.DataRow row = table.NewRow();
            row[0] = config.projectNum;
            row[1] = config.projectName;
            row[2] = config.onloadUrl;
            ds.Tables["System"].Rows.Add(row);

            ds.WriteXml(configPath+ "config.xml");
        }
        #endregion

        #region 读取配置文件

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
                XmlElement nodeHuman = doc.CreateElement("Human");
                nodeHuman.SetAttribute("name", item.Name);
                nodeHuman.SetAttribute("age", "23");
                nodeHuman.SetAttribute("gender", item.Gender);
                nodeHuman.SetAttribute("idcard", item.Number);
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
    }
}
