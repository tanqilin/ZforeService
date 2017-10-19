﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration.Install;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;
using ZforeFromwork.Util;

namespace ZforeServiceClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            iniConfigFile();
        }

        #region 读取配置文件
        private void iniConfigFile()
        {
            // 读取出xml信息
            var config = XmlUtil.ReadConfig();

            this.projectId.Text = config.projectNum;
            this.projectName.Text = config.projectName;
            this.onloadUrl.Text = config.onloadUrl;
        }
        #endregion

        string serviceFilePath = $"{Application.StartupPath}\\ZforeService.exe";
        string serviceName = "ZforeService";

        #region 操作

        //事件：安装服务
        private void button1_Click(object sender, EventArgs e)
        {
            if (this.IsServiceExisted(serviceName)) this.UninstallService(serviceName);
            this.InstallService(serviceFilePath);
        }

        //事件：启动服务
        private void button2_Click(object sender, EventArgs e)
        {
            if (this.IsServiceExisted(serviceName)) this.ServiceStart(serviceName);
        }

        //事件：停止服务
        private void button3_Click(object sender, EventArgs e)
        {
            if (this.IsServiceExisted(serviceName)) this.ServiceStop(serviceName);
        }

        //事件：卸载服务
        private void button4_Click(object sender, EventArgs e)
        {
            if (this.IsServiceExisted(serviceName))
            {
                this.ServiceStop(serviceName);
                this.UninstallService(serviceFilePath);
            }
        }

        #endregion

        #region 方法

        //判断服务是否存在
        private bool IsServiceExisted(string serviceName)
        {
            ServiceController[] services = ServiceController.GetServices();
            foreach (ServiceController sc in services)
            {
                if (sc.ServiceName.ToLower() == serviceName.ToLower())
                {
                    return true;
                }
            }
            return false;
        }

        //安装服务
        private void InstallService(string serviceFilePath)
        {
            using (AssemblyInstaller installer = new AssemblyInstaller())
            {
                installer.UseNewContext = true;
                installer.Path = serviceFilePath;
                IDictionary savedState = new Hashtable();
                installer.Install(savedState);
                installer.Commit(savedState);
            }
            this.serviceLog.Items.Clear();
            this.serviceLog.Items.Add($"{DateTime.Now}:安装成功！");
        }

        //卸载服务
        private void UninstallService(string serviceFilePath)
        {
            using (AssemblyInstaller installer = new AssemblyInstaller())
            {
                installer.UseNewContext = true;
                installer.Path = serviceFilePath;
                installer.Uninstall(null);
            }
            this.serviceLog.Items.Clear();
        }
        //启动服务
        private void ServiceStart(string serviceName)
        {
            using (ServiceController control = new ServiceController(serviceName))
            {
                if (control.Status == ServiceControllerStatus.Stopped)
                {
                    control.Start();
                }
            }
            this.serviceLog.Items.Add($"{DateTime.Now}:服务已启动！");
        }

        //停止服务
        private void ServiceStop(string serviceName)
        {
            using (ServiceController control = new ServiceController(serviceName))
            {
                if (control.Status == ServiceControllerStatus.Running)
                {
                    control.Stop();
                }
            }
            this.serviceLog.Items.Add($"{DateTime.Now}:服务已停止！");
        }

        #endregion

        // 确认(保存)配置信息
        private void rightConfig_Click(object sender, EventArgs e)
        {
            string ProjectNum = this.projectId.Text;
            string ProjectName = this.projectName.Text;
            string OnloadUrl = this.onloadUrl.Text;

            // 检查配置信息
            if (String.IsNullOrEmpty(ProjectNum)||
                String.IsNullOrEmpty(ProjectName) ||
                String.IsNullOrEmpty(OnloadUrl))
            {
                MessageBox.Show("三项都不能为空！","提示",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //创建一个config.xml程序，写入同步配置文件
            string optime = "config.xml";
            System.Data.DataSet ds = new System.Data.DataSet("Config");
            System.Data.DataTable table = new System.Data.DataTable("System");
            ds.Tables.Add(table);
            table.Columns.Add("ProjectNum", typeof(string));
            table.Columns.Add("ProjectName", typeof(string));
            table.Columns.Add("OnloadUrl", typeof(string));
           
            System.Data.DataRow row = table.NewRow();
            row[0] = ProjectNum;
            row[1] = ProjectName;
            row[2] = OnloadUrl;
            ds.Tables["System"].Rows.Add(row);

            ds.WriteXml($"{Application.StartupPath}\\"+ optime);
        }
    }
}