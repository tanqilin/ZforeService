using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZforeServiceClient.Forms
{
    public partial class LoadingForm : Form
    {
        public LoadingForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 供外部调用的接口
        /// </summary>
        /// <param name="length"></param>
        /// <param name="msg"></param>
        public void SetLoadingLength(int length,string msg)
        {
            this.loadingBar.Value = length;
            this.barMessage.Text = msg;
        }
    }
}
