using System;
using System.Windows.Forms;
using ZforeFromwork.Database.Entity;
using ZforeFromwork.Database.Service.Interface;
using ZforeFromwork.Database.Service.Realization;

namespace ZforeServiceClient.Forms
{
    public partial class AddProjectForm : Form
    {
        #region 属性和方法
        private IProjectService _projectService;
        public AddProjectForm()
        {
            InitializeComponent();
            _projectService = new ProjectService();
        }
        #endregion

        #region 提交项目信息
        /// <summary>
        /// 提交项目信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rightSubmit_Click(object sender, EventArgs e)
        {
            Project project = new Project();

            string projectNum = this.ProjectNum.Text.Trim();
            string projectName = this.ProjectName.Text.Trim();
            /// 项目信息不能为空
            if (String.IsNullOrEmpty(projectNum) || String.IsNullOrEmpty(projectName)) return;
            try
            {
                project.ProjectNum = projectNum;
                project.ProjectName = projectName;
                project.ProjectDeleted = "false";
                _projectService.InsertProject(project);
                this.DialogResult = DialogResult.OK;
            }
            catch
            {
                this.DialogResult = DialogResult.No;
            }
            finally
            {
                this.Close();
            }
        }
        #endregion

        #region 关闭窗口
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void closeDialog_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region 私有方法
        /// <summary>
        /// 限制只能输入数字方法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProjectNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }
        #endregion
    }
}
