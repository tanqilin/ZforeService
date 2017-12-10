namespace ZforeServiceClient
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.projectId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.projectName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.serviceLog = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.onloadUrl = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.add_people = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.rightConfig = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.add_people);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(397, 112);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "服务管理";
            // 
            // projectId
            // 
            this.projectId.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.projectId.Location = new System.Drawing.Point(78, 14);
            this.projectId.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.projectId.Name = "projectId";
            this.projectId.Size = new System.Drawing.Size(288, 21);
            this.projectId.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "项目编号：";
            // 
            // projectName
            // 
            this.projectName.Location = new System.Drawing.Point(78, 43);
            this.projectName.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.projectName.Name = "projectName";
            this.projectName.Size = new System.Drawing.Size(288, 21);
            this.projectName.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "项目名称：";
            // 
            // serviceLog
            // 
            this.serviceLog.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.serviceLog.FormattingEnabled = true;
            this.serviceLog.ItemHeight = 12;
            this.serviceLog.Location = new System.Drawing.Point(0, 231);
            this.serviceLog.Name = "serviceLog";
            this.serviceLog.Size = new System.Drawing.Size(397, 160);
            this.serviceLog.TabIndex = 8;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.projectId);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.onloadUrl);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.projectName);
            this.groupBox2.Controls.Add(this.rightConfig);
            this.groupBox2.Location = new System.Drawing.Point(3, 121);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 8, 3, 3);
            this.groupBox2.Size = new System.Drawing.Size(391, 103);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "同步配置";
            // 
            // onloadUrl
            // 
            this.onloadUrl.Location = new System.Drawing.Point(78, 72);
            this.onloadUrl.Name = "onloadUrl";
            this.onloadUrl.Size = new System.Drawing.Size(200, 21);
            this.onloadUrl.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "同步地址：";
            // 
            // add_people
            // 
            this.add_people.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add_people.Image = global::ZforeServiceClient.Properties.Resources.people_64;
            this.add_people.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.add_people.Location = new System.Drawing.Point(241, 18);
            this.add_people.Name = "add_people";
            this.add_people.Size = new System.Drawing.Size(114, 86);
            this.add_people.TabIndex = 4;
            this.add_people.Text = "人员管理";
            this.add_people.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.add_people.UseVisualStyleBackColor = true;
            this.add_people.Click += new System.EventHandler(this.add_people_Click);
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Image = global::ZforeServiceClient.Properties.Resources.stop;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(106, 29);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(80, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "关闭同步";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Image = global::ZforeServiceClient.Properties.Resources.uninstall;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(106, 69);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(80, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "卸载同步";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Image = global::ZforeServiceClient.Properties.Resources.install;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(11, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "安装服务";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Image = global::ZforeServiceClient.Properties.Resources.reset;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(11, 69);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "开启同步";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // rightConfig
            // 
            this.rightConfig.Image = global::ZforeServiceClient.Properties.Resources.save;
            this.rightConfig.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rightConfig.Location = new System.Drawing.Point(286, 70);
            this.rightConfig.Name = "rightConfig";
            this.rightConfig.Size = new System.Drawing.Size(80, 23);
            this.rightConfig.TabIndex = 7;
            this.rightConfig.Text = "确认配置";
            this.rightConfig.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rightConfig.UseVisualStyleBackColor = true;
            this.rightConfig.Click += new System.EventHandler(this.rightConfig_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 391);
            this.Controls.Add(this.serviceLog);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "中孚实名制系统同步程序";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox projectId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox projectName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox serviceLog;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox onloadUrl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button rightConfig;
        private System.Windows.Forms.Button add_people;
    }
}

