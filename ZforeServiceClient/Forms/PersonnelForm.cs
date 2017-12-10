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
        private IDeptAService _deptAService = null;
        private IEmployeeService _employeeService;
        IntPtr m_hDevice = IntPtr.Zero;
        IntPtr FormHandle = IntPtr.Zero;

        public PersonnelForm()
        {
            InitializeComponent();
            _employeeService = new EmployeeService();
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
            loading.SetLoadingLength(6, "正在加载人员信息...");
            this.loadEmployee();
            loading.SetLoadingLength(7, "正在加载班组信息...");
            this.InitTreeGroup();
            loading.SetLoadingLength(10, "初始化完毕...");
            loading.Close();
        }
        #endregion

        #region 加载人员信息

        /// <summary>
        /// 加载人员信息
        /// </summary>
        private void loadEmployee(List<Employee> data = null)
        {
            List<Employee> employees = null;
            if (data != null)
                employees = data;
            else
                employees = _employeeService.GetAllEmployee();
            /// 筛选数据
            var models = employees.Select(
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
            /// 默认不选中任何行
            this.dataGrid_people.ClearSelection();
        }
        #endregion

        #region 加载项目信息
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
            this.treeProject.Nodes.Add(root);
            this.treeProject.ExpandAll();
        }
        #endregion

        #region 加载班组信息
        public void InitTreeGroup()
        {
            this.treeGroup.Nodes.Clear();

            /// 渲染数据
            _deptAService = new DeptAService();
            List<DeptA> data = _deptAService.GetAllGroup();
            TreeNode root = new TreeNode();
            root.Text = "班组列表";

            foreach (DeptA item in data)
            {
                TreeNode node = new TreeNode();
                node.Tag = item;
                node.Text = item.DeptName;
                root.Nodes.Add(node);
                node = null;
            }
            this.treeGroup.Nodes.Add(root);
            /// 展开所有
            this.treeGroup.ExpandAll();
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

        #region 班组列表控件交互
        private void allGroup_Click(object sender, EventArgs e)
        {
            this.loadEmployee();
        }

        private void treeGroup_MouseDown(object sender, MouseEventArgs e)
        {
            if ((sender as TreeView) != null)
            {
                int menus = this.contextMenuStrip3.Items.Count;
                this.treeGroup.SelectedNode = treeGroup.GetNodeAt(e.X, e.Y);
                /// 当没有数据时只让右键添加按钮可用
                if(this.treeGroup.SelectedNode == null)
                {
                    for (int i = 1; i < menus; i++)
                    {
                        this.contextMenuStrip3.Items[i].Enabled = false;
                    }
                }
                else
                {
                    DeptA group = (DeptA)this.treeGroup.SelectedNode.Tag;
                    if (group == null) return;

                    List<Employee> data = _employeeService.GetEmployeeByDeptID(group.DeptID);
                    this.loadEmployee(data);

                    for (int i = 1; i < menus; i++)
                    {
                        this.contextMenuStrip3.Items[i].Enabled = true;
                    }
                }
            }
        }
        #endregion

        #region 工种列表控件交互
        private void jobList_MouseDown(object sender, MouseEventArgs e)
        {
            if ((sender as ListBox) != null)
            {
                string jobID = this.jobList.SelectedValue.ToString();
                if (String.IsNullOrEmpty(jobID)) return;
                List<Employee> data = _employeeService.GetEmployeeByJobID(Convert.ToInt32(jobID));
                this.loadEmployee(data);
            }
        }
        #endregion

        #region 顶部菜单管理
        /// <summary>
        /// 搜索人员信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SearchEmployee(object sender, EventArgs e)
        {
            string search = this.searchEmployee.Text;
            List<Employee> data = _employeeService.FindEmployee(search);
            this.loadEmployee(data);
        }
        #endregion

        #region 班组右键菜单管理
        /// <summary>
        /// 班组右键菜单按下时执行
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void contextMenuStrip3_Opening(object sender, CancelEventArgs e)
        {
            int menus = this.contextMenuStrip3.Items.Count;
            if (this.treeGroup.SelectedNode == null || this.treeGroup.SelectedNode.Tag == null)
            {
                for (int i = 1; i < menus; i++)
                {
                    if (i == 3) continue;
                    this.contextMenuStrip3.Items[i].Enabled = false;
                }
            }
            else
            {
                for (int i = 1; i < menus; i++)
                {
                    this.contextMenuStrip3.Items[i].Enabled = true;
                }
            }
        }

        /// <summary>
        /// 相应班组右键菜单
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addGroup_Click(object sender, EventArgs e)
        {
            Form addGroup = null;
            string clickType = sender.ToString();
            if (clickType == "编辑")
            {
                DeptA tree = (DeptA)this.treeGroup.SelectedNode.Tag;
                addGroup = new AddGroup(tree);
                addGroup.ShowDialog();
            }
            else if (clickType == "删除")
            {
                DeptA tree = (DeptA)this.treeGroup.SelectedNode.Tag;
                DialogResult result = MessageBox.Show("是否删除班组：\"" +tree.DeptName+"\"?","删除班组", MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
                if(result == DialogResult.OK)
                    _deptAService.DeleteDeptA(tree);
            }
            else if (clickType == "新增")
            {
                addGroup = new AddGroup();
                addGroup.ShowDialog();
            }

            /// 结果处理
            if (addGroup != null && addGroup.DialogResult == DialogResult.OK)
            {
                this.logList.Items.Insert(0,DateTime.Now.ToString()+":操作成功");
            }
            InitTreeGroup();
        }
        #endregion

        #region 人员数据列表右键菜单管理
        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            int menus = this.contextMenuStrip1.Items.Count;
            if (this.dataGrid_people.Rows.Count != 0)
            {
                /// 选中行索引->选中行数据
                int index = this.dataGrid_people.CurrentRow.Index;
                var data = this.dataGrid_people.Rows[index];
                for (int i = 1; i < menus; i++)
                {
                    this.contextMenuStrip1.Items[i].Enabled = true;
                }
            }
            else
            {
                for (int i = 1;i < menus;i++)
                {
                    this.contextMenuStrip1.Items[i].Enabled = false;
                }
            }
        }

        /// <summary>
        /// 人员右键菜单响应
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void employeeRight_Click(object sender, EventArgs e)
        {
            string clickType = sender.ToString();
            if (clickType == "刷新")
            {
                this.loadEmployee();
            }
            else if (clickType == "编辑")
            {
                int index = this.dataGrid_people.CurrentRow.Index;
                int employeeId = Convert.ToInt32(this.dataGrid_people.Rows[index].Cells["EmployeeID"].Value);
                Employee employee = _employeeService.GetEmployeeByID(employeeId);
                Form addEmpolyee = new AddEmployee(employee);
                addEmpolyee.ShowDialog();
            }
        }
        #endregion
    }
}
