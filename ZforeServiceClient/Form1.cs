using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration.Install;
using System.IO;
using System.ServiceProcess;
using System.Text;
using System.Web.Services.Description;
using System.Windows.Forms;
using ZforeFromwork.Model;
using ZforeFromwork.SqlService;
using ZforeFromwork.Util;

namespace ZforeServiceClient
{
    public partial class Form1 : Form
    {
        #region 属性和构造函数
        private string serviceFilePath = $"{Application.StartupPath}\\ZforeService.exe";
        private string serviceName = "ZforeService";

        public Form1()
        {
            InitializeComponent();

            iniConfigFile();
        }
        #endregion

        #region 读取配置文件
        private void iniConfigFile()
        {
            // 读取出xml信息
            var config = XmlUtil.ReadConfig();
           
            //// 使用xml传输图片，byte[] -> string -> byte[]
            //string ret = System.Convert.ToBase64String(data[0].Picture); 
            //byte[] buff = Convert.FromBase64String(ret);

            if (config != null)
            {
                this.projectId.Text = config.projectNum;
                this.projectName.Text = config.projectName;
                this.onloadUrl.Text = config.onloadUrl;

                iniEnabledAllButton(false);
            }
            else
            {
                iniEnabledAllButton(true);
            }
        }

        private void iniEnabledAllButton(bool start)
        {
            this.projectId.Enabled = start;
            this.projectName.Enabled = start;
            this.onloadUrl.Enabled = start;
            this.rightConfig.Enabled = start;
        }
        #endregion

        #region 操作

        //事件：安装服务
        private void button1_Click(object sender, EventArgs e)
        {
            if (!this.IsServiceExisted(serviceName))
                this.InstallService(serviceFilePath);
            else
            {
                this.serviceLog.Items.Add($"{DateTime.Now}:服务已存在！");
            }
        }

        //事件：启动服务
        private void button2_Click(object sender, EventArgs e)
        {
            if(XmlUtil.ReadConfig() == null)
            {
                MessageBox.Show("请先填写配置信息！","警告！",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            if (this.IsServiceExisted(serviceName))
            {
                this.ServiceStart(serviceName);
                this.button2.Text = "重启同步";
            }
            else this.serviceLog.Items.Add($"{DateTime.Now}:请先安装服务！");
        }

        //事件：停止服务
        private void button3_Click(object sender, EventArgs e)
        {
            Form dialog = new LoginForm();
            dialog.ShowDialog();
            // 登录成功则卸载服务
            if (dialog.DialogResult == DialogResult.OK)
            {
                if (this.IsServiceExisted(serviceName))
                    this.ServiceStop(serviceName);
            }
        }

        //事件：卸载服务
        private void button4_Click(object sender, EventArgs e)
        {
            Form dialog = new LoginForm();
            dialog.ShowDialog();
            // 登录成功则卸载服务
            if(dialog.DialogResult == DialogResult.OK)
            {
                if (this.IsServiceExisted(serviceName))
                {
                    this.ServiceStop(serviceName);
                    this.UninstallService(serviceFilePath);
                }
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
            this.serviceLog.Items.Add($"{DateTime.Now}:卸载成功！");
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
                else
                {
                    /// 重启服务
                    if (control.Status == ServiceControllerStatus.Running)
                    {
                        control.Stop();
                        this.serviceLog.Items.Add($"{DateTime.Now}:服务停止中...！");
                        control.WaitForStatus(ServiceControllerStatus.Stopped);
                    }
                    control.Start();
                    this.serviceLog.Items.Add($"{DateTime.Now}:服务启动中...！");
                    control.WaitForStatus(ServiceControllerStatus.Running);
                }
                this.serviceLog.Items.Add($"{DateTime.Now}:服务已启动！");
            }
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

        #region 确认(保存)配置信息

        private void rightConfig_Click(object sender, EventArgs e)
        {
            this.serviceLog.Items.Clear();
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
            // 向Xml写入配置文件
            Config config = new Config();
            config.projectNum = ProjectNum;
            config.projectName = ProjectName;
            config.onloadUrl = OnloadUrl;
            XmlUtil.WriteConfig(config);

            // 初始化数据库种子数据
            ReadDatabase database = new ReadDatabase();
            if(database.InitDatabase())
                this.serviceLog.Items.Add($"{DateTime.Now}:数据插入成功！");
            else
                this.serviceLog.Items.Add($"{DateTime.Now}:数据插入失败！");

            this.serviceLog.Items.Add($"{DateTime.Now}:配置成功！");
            iniEnabledAllButton(false);
        }

        #endregion
    }
}
