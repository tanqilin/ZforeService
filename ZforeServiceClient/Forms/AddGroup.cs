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
using ZforeFromwork.Database.Service.Interface;
using ZforeFromwork.Database.Service.Realization;

namespace ZforeServiceClient.Forms
{
    /// <summary>
    /// 增加/编辑班组信息
    /// </summary>
    public partial class AddGroup : Form
    {
        /// <summary>
        /// 编辑时的节点
        /// </summary>
        private DeptA selectedGroup = null;
        private DeptA group = null;
        public AddGroup()
        {
            InitializeComponent();
        }

        public AddGroup(DeptA group)
        {
            this.selectedGroup = group;
            InitializeComponent();
            this.groupName.Text = selectedGroup.DeptName;
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

            /// 插入加班组信息
            if (selectedGroup == null)
                group = new DeptA();
            else
                group = selectedGroup;

            group.DeptName = groupName;
            group.DeptLevel = 1;
            group.UpDeptID = 0;

            /// 插入或更新
            IDeptAService _deptAService = new DeptAService();
            if (selectedGroup == null)
                _deptAService.InsertDeptA(group);
            else
                _deptAService.UpdateDeptA(group);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
