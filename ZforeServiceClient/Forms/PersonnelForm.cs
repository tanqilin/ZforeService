using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using ZforeFromwork.Database.Service.Interface;
using ZforeFromwork.Database.Service.Realization;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZforeFromwork.ReadCard;
using ZforeFromwork.Database.Entity;
using ZforeFromwork.Database.Model;
using ZforeFromwork.AotuMapper;

namespace ZforeServiceClient.Forms
{
    public partial class PersonnelForm : Form
    {
        #region 属性和构造函数
        /// <summary>
        /// 读取信息存储容器
        /// </summary>
        private CardInfo card = new CardInfo();

        IntPtr m_hDevice = IntPtr.Zero;
        IntPtr FormHandle = IntPtr.Zero;

        public PersonnelForm()
        {
            InitializeComponent();
            AutoMapperConfiguration.Init();
        }

        /// 程序加载时执行
        protected override void OnLoad(EventArgs e)
        {
            /// 显示进度框
            LoadingForm loading = new LoadingForm();
            loading.Show();
            loading.SetLoadingLength(2, "正在初始化工种信息...");
            IJobService _jobService = new JobService();
            var jobs = _jobService.GetAllJobs();
            this.jobList.DataSource = jobs;
            loading.SetLoadingLength(5, "正在加载项目信息...");
            this.InitTreeProject();
            loading.SetLoadingLength(7, "正在加载人员信息...");
            this.loadEmployee(null,null);
            loading.SetLoadingLength(10, "初始化完毕...");
            loading.Close();
        }
        #endregion

        #region 加载人员信息

        /// <summary>
        /// 加载人员信息
        /// </summary>
        private void loadEmployee(object sender, EventArgs e)
        {
            IEmployeeService _employeeService = new EmployeeService();
            List<Employee> data = _employeeService.GetAllEmployee();
            var models = data.Select(
                x => new EmployeeModel
                {
                    EmployeeID = x.EmployeeID,
                    EmployeeName = x.EmployeeName,
                    CardNo = x.CardNo,
                    SexStr = x.Sex == false ? "男" : "女",
                    Birthday = x.Birthday,
                    PersonCode = x.PersonCode,
                    Photo = x.Photo
                }).ToList();
            this.dataGrid_people.DataSource = models;
        }
        #endregion

        #region 初始化项目列表
        /// <summary>
        /// 初始化项目列表
        /// </summary>
        private void InitTreeProject()
        {
            TreeNode root = new TreeNode();
            root.Text = "项目列表";
            TreeNode first = new TreeNode();
            first.Text = "稻田汇项目";
            root.Nodes.Add(first);
            treeProject.Nodes.Add(root);
        }
        #endregion

        #region 添加或编辑人员信息

        /// <summary>
        /// 添加或编辑人员信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addEmployee_Click(object sender, EventArgs e)
        {
            Form addEmployee = new AddEmployee();
            addEmployee.ShowDialog();
        }
        #endregion

        #region 添加或编辑班组信息
        private void addGroup_Click(object sender, EventArgs e)
        {
            Form addGroup = new AddGroup();
            addGroup.ShowDialog();

            if (addGroup.DialogResult == DialogResult.OK)
            {
                this.logList.Items.Insert(0,DateTime.Now.ToString()+":班组添加成功");
            }
        }
        #endregion
    }
}
