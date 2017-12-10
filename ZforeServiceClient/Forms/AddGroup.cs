using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZforeFromwork.AotuMapper;
using ZforeFromwork.Database.Entity;
using ZforeFromwork.Database.Model;

namespace ZforeServiceClient.Forms
{
    /// <summary>
    /// 增加/编辑班组信息
    /// </summary>
    public partial class AddGroup : Form
    {
        public AddGroup()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 添加班组
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rightAdd_Click(object sender, EventArgs e)
        {
            string groupName = this.groupName.Text;
            if (String.IsNullOrEmpty(groupName)) return;

            DeptA group = new DeptA();
            group.DeptName = groupName;
            group.UpDeptID = 0;


            this.DialogResult = DialogResult.OK;
            this.Close();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
