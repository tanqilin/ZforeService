using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration.Install;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZforeFromwork.Util;

namespace Installer
{
    [RunInstaller(true)]
    public partial class InstallerSetup : System.Configuration.Install.Installer
    {
        /// <summary>
        /// 是否安装成功
        /// </summary>
        private bool isInstall = false;

        public InstallerSetup()
        {
            InitializeComponent();
            this.BeforeInstall += new InstallEventHandler(InstallerTest_BeforeInstall);
            this.AfterInstall += new InstallEventHandler(InstallerTest_AfterInstall);
        }

        public override void Install(System.Collections.IDictionary stateSaver)
        {
            base.Install(stateSaver);
        }

        public override void Rollback(IDictionary savedState)
        {
            base.Rollback(savedState);
        }

        /// <summary>
        /// 安装前执行
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void InstallerTest_BeforeInstall(object sender, InstallEventArgs e)
        {
            string myInput = Context.Parameters["dbuser"];
            this.isInstall = true;
        }

        /// <summary>
        /// 安装后执行
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void InstallerTest_AfterInstall(object sender, InstallEventArgs e)
        {           
            string path = this.Context.Parameters["targetdir"];
            string command = path + "\\ZforeServiceClient.exe";

            /// 如果安装成功则启动程序
            if (this.isInstall)
            {
                /// 安装后启动程序
                System.Diagnostics.ProcessStartInfo psiConfig = new System.Diagnostics.ProcessStartInfo(command);
                System.Diagnostics.Process pConfig = System.Diagnostics.Process.Start(psiConfig);
            }

            #region 启动CMD-已注释
            /// 启动CMD可以执行一些bat文件
            //Process p = new Process();
            //p.StartInfo.FileName = "cmd.exe";
            //p.StartInfo = new System.Diagnostics.ProcessStartInfo(command);
            //p.StartInfo.UseShellExecute = false;
            //p.StartInfo.RedirectStandardInput = true;
            //p.StartInfo.RedirectStandardOutput = true;
            //p.StartInfo.CreateNoWindow = false;
            //p.StartInfo.Arguments = path;
            //p.Start();
            //p.StandardInput.WriteLine("exit");
            //p.Close();
            #endregion
        }
    }
}
