﻿namespace ZforeServiceClient.Forms
{
    partial class PersonnelForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonnelForm));
            this.dataGrid_people = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.添加ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.编辑ToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.发卡ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.离职ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除ToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.添加人员ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.videoMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.搜索ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchEmployee = new System.Windows.Forms.ToolStripTextBox();
            this.jobList = new System.Windows.Forms.ListBox();
            this.logList = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.allJob = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.allProject = new System.Windows.Forms.Button();
            this.treeProject = new System.Windows.Forms.TreeView();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.增加项目ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.编辑ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.刷新ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel3 = new System.Windows.Forms.Panel();
            this.allGroup = new System.Windows.Forms.Button();
            this.treeGroup = new System.Windows.Forms.TreeView();
            this.contextMenuStrip3 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.新增ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.编辑ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.删除ToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.刷新ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.EmployeeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.image = new System.Windows.Forms.DataGridViewImageColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CardNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Leave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_people)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.contextMenuStrip3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGrid_people
            // 
            this.dataGrid_people.AllowUserToAddRows = false;
            this.dataGrid_people.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGrid_people.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGrid_people.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGrid_people.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid_people.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGrid_people.ColumnHeadersHeight = 25;
            this.dataGrid_people.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGrid_people.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EmployeeID,
            this.image,
            this.name,
            this.sex,
            this.ProjectName,
            this.CardNo,
            this.Leave,
            this.number,
            this.age});
            this.dataGrid_people.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGrid_people.Location = new System.Drawing.Point(180, 30);
            this.dataGrid_people.MultiSelect = false;
            this.dataGrid_people.Name = "dataGrid_people";
            this.dataGrid_people.RowHeadersVisible = false;
            this.dataGrid_people.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGrid_people.RowsDefaultCellStyle = dataGridViewCellStyle11;
            this.dataGrid_people.RowTemplate.Height = 55;
            this.dataGrid_people.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid_people.Size = new System.Drawing.Size(792, 461);
            this.dataGrid_people.TabIndex = 0;
            this.dataGrid_people.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridEmployee_CellDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.添加ToolStripMenuItem,
            this.编辑ToolStripMenuItem2,
            this.发卡ToolStripMenuItem,
            this.删除ToolStripMenuItem,
            this.离职ToolStripMenuItem,
            this.删除ToolStripMenuItem3});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(146, 136);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // 添加ToolStripMenuItem
            // 
            this.添加ToolStripMenuItem.Image = global::ZforeServiceClient.Properties.Resources.add;
            this.添加ToolStripMenuItem.Name = "添加ToolStripMenuItem";
            this.添加ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.添加ToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.添加ToolStripMenuItem.Text = "增加";
            this.添加ToolStripMenuItem.Click += new System.EventHandler(this.addEmployee_Click);
            // 
            // 编辑ToolStripMenuItem2
            // 
            this.编辑ToolStripMenuItem2.Name = "编辑ToolStripMenuItem2";
            this.编辑ToolStripMenuItem2.Size = new System.Drawing.Size(145, 22);
            this.编辑ToolStripMenuItem2.Text = "编辑";
            this.编辑ToolStripMenuItem2.Click += new System.EventHandler(this.addEmployee_Click);
            // 
            // 发卡ToolStripMenuItem
            // 
            this.发卡ToolStripMenuItem.Name = "发卡ToolStripMenuItem";
            this.发卡ToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.发卡ToolStripMenuItem.Text = "发卡";
            this.发卡ToolStripMenuItem.Click += new System.EventHandler(this.employeeRight_Click);
            // 
            // 删除ToolStripMenuItem
            // 
            this.删除ToolStripMenuItem.Image = global::ZforeServiceClient.Properties.Resources.reset;
            this.删除ToolStripMenuItem.Name = "删除ToolStripMenuItem";
            this.删除ToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.删除ToolStripMenuItem.Text = "刷新";
            this.删除ToolStripMenuItem.Click += new System.EventHandler(this.employeeRight_Click);
            // 
            // 离职ToolStripMenuItem
            // 
            this.离职ToolStripMenuItem.Name = "离职ToolStripMenuItem";
            this.离职ToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.离职ToolStripMenuItem.Text = "离职";
            this.离职ToolStripMenuItem.Click += new System.EventHandler(this.employeeRight_Click);
            // 
            // 删除ToolStripMenuItem3
            // 
            this.删除ToolStripMenuItem3.Image = global::ZforeServiceClient.Properties.Resources.delete;
            this.删除ToolStripMenuItem3.Name = "删除ToolStripMenuItem3";
            this.删除ToolStripMenuItem3.Size = new System.Drawing.Size(145, 22);
            this.删除ToolStripMenuItem3.Text = "删除";
            this.删除ToolStripMenuItem3.Click += new System.EventHandler(this.employeeRight_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightGray;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.添加人员ToolStripMenuItem1,
            this.videoMenu,
            this.搜索ToolStripMenuItem,
            this.searchEmployee});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(984, 27);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 添加人员ToolStripMenuItem1
            // 
            this.添加人员ToolStripMenuItem1.Image = global::ZforeServiceClient.Properties.Resources.employee;
            this.添加人员ToolStripMenuItem1.Name = "添加人员ToolStripMenuItem1";
            this.添加人员ToolStripMenuItem1.Size = new System.Drawing.Size(84, 23);
            this.添加人员ToolStripMenuItem1.Text = "添加人员";
            this.添加人员ToolStripMenuItem1.Click += new System.EventHandler(this.addEmployee_Click);
            // 
            // videoMenu
            // 
            this.videoMenu.Image = global::ZforeServiceClient.Properties.Resources.video_32;
            this.videoMenu.Name = "videoMenu";
            this.videoMenu.Size = new System.Drawing.Size(60, 23);
            this.videoMenu.Text = "监控";
            this.videoMenu.Click += new System.EventHandler(this.videoMenu_Click);
            // 
            // 搜索ToolStripMenuItem
            // 
            this.搜索ToolStripMenuItem.Image = global::ZforeServiceClient.Properties.Resources.search_red1;
            this.搜索ToolStripMenuItem.Name = "搜索ToolStripMenuItem";
            this.搜索ToolStripMenuItem.Size = new System.Drawing.Size(63, 23);
            this.搜索ToolStripMenuItem.Text = "搜索:";
            // 
            // searchEmployee
            // 
            this.searchEmployee.BackColor = System.Drawing.SystemColors.Window;
            this.searchEmployee.Name = "searchEmployee";
            this.searchEmployee.Size = new System.Drawing.Size(200, 23);
            this.searchEmployee.Click += new System.EventHandler(this.SearchEmployee);
            this.searchEmployee.TextChanged += new System.EventHandler(this.SearchEmployee);
            // 
            // jobList
            // 
            this.jobList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.jobList.DisplayMember = "JobName";
            this.jobList.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.jobList.FormattingEnabled = true;
            this.jobList.Location = new System.Drawing.Point(3, 28);
            this.jobList.Name = "jobList";
            this.jobList.Size = new System.Drawing.Size(165, 160);
            this.jobList.TabIndex = 2;
            this.jobList.ValueMember = "JobCode";
            this.jobList.MouseDown += new System.Windows.Forms.MouseEventHandler(this.jobList_MouseDown);
            // 
            // logList
            // 
            this.logList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logList.FormattingEnabled = true;
            this.logList.ItemHeight = 12;
            this.logList.Location = new System.Drawing.Point(5, 498);
            this.logList.Name = "logList";
            this.logList.Size = new System.Drawing.Size(967, 88);
            this.logList.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.Controls.Add(this.allJob);
            this.panel1.Controls.Add(this.jobList);
            this.panel1.Location = new System.Drawing.Point(5, 300);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(171, 191);
            this.panel1.TabIndex = 4;
            // 
            // allJob
            // 
            this.allJob.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.allJob.Cursor = System.Windows.Forms.Cursors.Hand;
            this.allJob.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.allJob.FlatAppearance.BorderSize = 0;
            this.allJob.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.allJob.Location = new System.Drawing.Point(3, 3);
            this.allJob.Name = "allJob";
            this.allJob.Size = new System.Drawing.Size(165, 23);
            this.allJob.TabIndex = 3;
            this.allJob.Text = "工种";
            this.allJob.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.allJob.UseVisualStyleBackColor = false;
            this.allJob.Click += new System.EventHandler(this.allJob_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.allProject);
            this.panel2.Controls.Add(this.treeProject);
            this.panel2.Location = new System.Drawing.Point(5, 31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(171, 105);
            this.panel2.TabIndex = 5;
            // 
            // allProject
            // 
            this.allProject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.allProject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.allProject.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.allProject.FlatAppearance.BorderSize = 0;
            this.allProject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.allProject.Location = new System.Drawing.Point(5, 3);
            this.allProject.Name = "allProject";
            this.allProject.Size = new System.Drawing.Size(162, 23);
            this.allProject.TabIndex = 3;
            this.allProject.Text = "项目列表";
            this.allProject.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.allProject.UseVisualStyleBackColor = false;
            this.allProject.Click += new System.EventHandler(this.allProject_Click);
            // 
            // treeProject
            // 
            this.treeProject.CheckBoxes = true;
            this.treeProject.ContextMenuStrip = this.contextMenuStrip2;
            this.treeProject.Location = new System.Drawing.Point(5, 29);
            this.treeProject.Name = "treeProject";
            this.treeProject.Size = new System.Drawing.Size(163, 73);
            this.treeProject.TabIndex = 1;
            this.treeProject.MouseDown += new System.Windows.Forms.MouseEventHandler(this.treeProject_MouseDown);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.增加项目ToolStripMenuItem,
            this.编辑ToolStripMenuItem,
            this.删除ToolStripMenuItem1,
            this.刷新ToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(101, 92);
            this.contextMenuStrip2.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip2_Opening);
            // 
            // 增加项目ToolStripMenuItem
            // 
            this.增加项目ToolStripMenuItem.Image = global::ZforeServiceClient.Properties.Resources.add;
            this.增加项目ToolStripMenuItem.Name = "增加项目ToolStripMenuItem";
            this.增加项目ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.增加项目ToolStripMenuItem.Text = "增加";
            this.增加项目ToolStripMenuItem.Click += new System.EventHandler(this.addProject_Click);
            // 
            // 编辑ToolStripMenuItem
            // 
            this.编辑ToolStripMenuItem.Name = "编辑ToolStripMenuItem";
            this.编辑ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.编辑ToolStripMenuItem.Text = "编辑";
            this.编辑ToolStripMenuItem.Click += new System.EventHandler(this.addProject_Click);
            // 
            // 删除ToolStripMenuItem1
            // 
            this.删除ToolStripMenuItem1.Image = global::ZforeServiceClient.Properties.Resources.delete;
            this.删除ToolStripMenuItem1.Name = "删除ToolStripMenuItem1";
            this.删除ToolStripMenuItem1.Size = new System.Drawing.Size(100, 22);
            this.删除ToolStripMenuItem1.Text = "删除";
            this.删除ToolStripMenuItem1.Click += new System.EventHandler(this.addProject_Click);
            // 
            // 刷新ToolStripMenuItem
            // 
            this.刷新ToolStripMenuItem.Image = global::ZforeServiceClient.Properties.Resources.reset;
            this.刷新ToolStripMenuItem.Name = "刷新ToolStripMenuItem";
            this.刷新ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.刷新ToolStripMenuItem.Text = "刷新";
            this.刷新ToolStripMenuItem.Click += new System.EventHandler(this.addProject_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel3.Controls.Add(this.allGroup);
            this.panel3.Controls.Add(this.treeGroup);
            this.panel3.Location = new System.Drawing.Point(5, 138);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(171, 156);
            this.panel3.TabIndex = 5;
            // 
            // allGroup
            // 
            this.allGroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.allGroup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.allGroup.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.allGroup.FlatAppearance.BorderSize = 0;
            this.allGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.allGroup.Location = new System.Drawing.Point(5, 3);
            this.allGroup.Name = "allGroup";
            this.allGroup.Size = new System.Drawing.Size(162, 23);
            this.allGroup.TabIndex = 3;
            this.allGroup.Text = "班组";
            this.allGroup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.allGroup.UseVisualStyleBackColor = false;
            this.allGroup.Click += new System.EventHandler(this.allGroup_Click);
            // 
            // treeGroup
            // 
            this.treeGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeGroup.ContextMenuStrip = this.contextMenuStrip3;
            this.treeGroup.Location = new System.Drawing.Point(5, 29);
            this.treeGroup.Name = "treeGroup";
            this.treeGroup.Size = new System.Drawing.Size(163, 124);
            this.treeGroup.TabIndex = 1;
            this.treeGroup.MouseDown += new System.Windows.Forms.MouseEventHandler(this.treeGroup_MouseDown);
            // 
            // contextMenuStrip3
            // 
            this.contextMenuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新增ToolStripMenuItem,
            this.编辑ToolStripMenuItem1,
            this.删除ToolStripMenuItem2,
            this.刷新ToolStripMenuItem1});
            this.contextMenuStrip3.Name = "contextMenuStrip3";
            this.contextMenuStrip3.Size = new System.Drawing.Size(101, 92);
            this.contextMenuStrip3.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip3_Opening);
            // 
            // 新增ToolStripMenuItem
            // 
            this.新增ToolStripMenuItem.Image = global::ZforeServiceClient.Properties.Resources.add;
            this.新增ToolStripMenuItem.Name = "新增ToolStripMenuItem";
            this.新增ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.新增ToolStripMenuItem.Text = "新增";
            this.新增ToolStripMenuItem.Click += new System.EventHandler(this.addGroup_Click);
            // 
            // 编辑ToolStripMenuItem1
            // 
            this.编辑ToolStripMenuItem1.Name = "编辑ToolStripMenuItem1";
            this.编辑ToolStripMenuItem1.Size = new System.Drawing.Size(100, 22);
            this.编辑ToolStripMenuItem1.Text = "编辑";
            this.编辑ToolStripMenuItem1.Click += new System.EventHandler(this.addGroup_Click);
            // 
            // 删除ToolStripMenuItem2
            // 
            this.删除ToolStripMenuItem2.Image = global::ZforeServiceClient.Properties.Resources.delete;
            this.删除ToolStripMenuItem2.Name = "删除ToolStripMenuItem2";
            this.删除ToolStripMenuItem2.Size = new System.Drawing.Size(100, 22);
            this.删除ToolStripMenuItem2.Text = "删除";
            this.删除ToolStripMenuItem2.Click += new System.EventHandler(this.addGroup_Click);
            // 
            // 刷新ToolStripMenuItem1
            // 
            this.刷新ToolStripMenuItem1.Image = global::ZforeServiceClient.Properties.Resources.reset;
            this.刷新ToolStripMenuItem1.Name = "刷新ToolStripMenuItem1";
            this.刷新ToolStripMenuItem1.Size = new System.Drawing.Size(100, 22);
            this.刷新ToolStripMenuItem1.Text = "刷新";
            this.刷新ToolStripMenuItem1.Click += new System.EventHandler(this.addGroup_Click);
            // 
            // EmployeeID
            // 
            this.EmployeeID.DataPropertyName = "EmployeeID";
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.EmployeeID.DefaultCellStyle = dataGridViewCellStyle2;
            this.EmployeeID.Frozen = true;
            this.EmployeeID.HeaderText = "人员编号";
            this.EmployeeID.Name = "EmployeeID";
            this.EmployeeID.Width = 75;
            // 
            // image
            // 
            this.image.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.image.DataPropertyName = "Photo";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.NullValue = null;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.image.DefaultCellStyle = dataGridViewCellStyle3;
            this.image.HeaderText = "头像";
            this.image.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.image.Name = "image";
            this.image.ReadOnly = true;
            this.image.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.image.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.image.Width = 95;
            // 
            // name
            // 
            this.name.DataPropertyName = "EmployeeName";
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.name.DefaultCellStyle = dataGridViewCellStyle4;
            this.name.HeaderText = "姓名";
            this.name.Name = "name";
            this.name.Width = 80;
            // 
            // sex
            // 
            this.sex.DataPropertyName = "SexStr";
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.sex.DefaultCellStyle = dataGridViewCellStyle5;
            this.sex.HeaderText = "性别";
            this.sex.Name = "sex";
            this.sex.ReadOnly = true;
            this.sex.Width = 50;
            // 
            // ProjectName
            // 
            this.ProjectName.DataPropertyName = "ProjectName";
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ProjectName.DefaultCellStyle = dataGridViewCellStyle6;
            this.ProjectName.HeaderText = "所属项目";
            this.ProjectName.Name = "ProjectName";
            this.ProjectName.ReadOnly = true;
            // 
            // CardNo
            // 
            this.CardNo.DataPropertyName = "CardNo";
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.CardNo.DefaultCellStyle = dataGridViewCellStyle7;
            this.CardNo.HeaderText = "门禁卡号";
            this.CardNo.Name = "CardNo";
            this.CardNo.ReadOnly = true;
            this.CardNo.Width = 75;
            // 
            // Leave
            // 
            this.Leave.DataPropertyName = "Leave";
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Leave.DefaultCellStyle = dataGridViewCellStyle8;
            this.Leave.HeaderText = "是否在职";
            this.Leave.Name = "Leave";
            this.Leave.ReadOnly = true;
            // 
            // number
            // 
            this.number.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.number.DataPropertyName = "PersonCode";
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.number.DefaultCellStyle = dataGridViewCellStyle9;
            this.number.HeaderText = "身份证号";
            this.number.MinimumWidth = 150;
            this.number.Name = "number";
            this.number.ReadOnly = true;
            // 
            // age
            // 
            this.age.DataPropertyName = "Birthday";
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.age.DefaultCellStyle = dataGridViewCellStyle10;
            this.age.HeaderText = "出生日期";
            this.age.Name = "age";
            this.age.ReadOnly = true;
            // 
            // PersonnelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 597);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.logList);
            this.Controls.Add(this.dataGrid_people);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PersonnelForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "人员管理";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_people)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.contextMenuStrip3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrid_people;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripTextBox searchEmployee;
        private System.Windows.Forms.ToolStripMenuItem 添加人员ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 搜索ToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 添加ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除ToolStripMenuItem;
        private System.Windows.Forms.ListBox jobList;
        public System.Windows.Forms.ListBox logList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button allJob;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TreeView treeProject;
        private System.Windows.Forms.Button allProject;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button allGroup;
        private System.Windows.Forms.TreeView treeGroup;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem 增加项目ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 编辑ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 刷新ToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip3;
        private System.Windows.Forms.ToolStripMenuItem 新增ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 编辑ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 删除ToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem 刷新ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 删除ToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem 离职ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 编辑ToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem videoMenu;
        private System.Windows.Forms.ToolStripMenuItem 发卡ToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeID;
        private System.Windows.Forms.DataGridViewImageColumn image;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn sex;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CardNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Leave;
        private System.Windows.Forms.DataGridViewTextBoxColumn number;
        private System.Windows.Forms.DataGridViewTextBoxColumn age;
    }
}