using System;
using System.Collections;
using System.Configuration.Install;
using System.ServiceProcess;
using System.Web.Services.Description;
using System.Windows.Forms;
using ZforeFromwork.Util;

namespace ZforeServiceClient
{
    public partial class Form1 : Form
    {
        #region 属性和构造函数
        private readonly string configPath = $"{Application.StartupPath}\\config.xml";
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
            var config = XmlUtil.ReadConfig(configPath);

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

        #region 确认(保存)配置信息

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

            ds.WriteXml(configPath);

            this.serviceLog.Items.Clear();
            this.serviceLog.Items.Add($"{DateTime.Now}:配置成功！");
            iniEnabledAllButton(false);
        }

        #endregion
    }
}
