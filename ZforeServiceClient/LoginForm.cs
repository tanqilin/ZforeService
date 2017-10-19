using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZforeServiceClient
{
    /// <summary>
    /// 卸载服务登录窗口
    /// </summary>
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void rightLogin_Click(object sender, EventArgs e)
        {
            string name = this.loginName.Text;
            string password = this.loginPsw.Text;
            if (String.IsNullOrEmpty(name) || String.IsNullOrEmpty(password)) return;

            // 确认登录信息
            if (name == "zfore-tanqilin" && password == "tanqilin")
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("账户名或密码错误！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
