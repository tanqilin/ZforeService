namespace ZforeServiceClient.Forms
{
    partial class DHVideoForm
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
            this.dataGridVideo = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.videoIP = new System.Windows.Forms.TextBox();
            this.videoPort = new System.Windows.Forms.TextBox();
            this.userN = new System.Windows.Forms.TextBox();
            this.videoPsw = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.closeWin = new System.Windows.Forms.Button();
            this.rightAdd = new System.Windows.Forms.Button();
            this.testCon = new System.Windows.Forms.Button();
            this.videoWin = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.vidoeLabe = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.videoEnable = new System.Windows.Forms.CheckBox();
            this.VideoID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VideoName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Enable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Port = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVideo)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.videoWin)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridVideo
            // 
            this.dataGridVideo.AllowUserToAddRows = false;
            this.dataGridVideo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridVideo.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridVideo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridVideo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.VideoID,
            this.VideoName,
            this.Enable,
            this.IP,
            this.Port,
            this.UserName,
            this.Password});
            this.dataGridVideo.Location = new System.Drawing.Point(2, 3);
            this.dataGridVideo.Name = "dataGridVideo";
            this.dataGridVideo.RowHeadersVisible = false;
            this.dataGridVideo.RowTemplate.Height = 23;
            this.dataGridVideo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridVideo.Size = new System.Drawing.Size(503, 421);
            this.dataGridVideo.TabIndex = 0;
            this.dataGridVideo.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridVideo_CellDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.videoWin);
            this.groupBox1.Location = new System.Drawing.Point(512, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(271, 167);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "测试图像";
            // 
            // videoIP
            // 
            this.videoIP.Location = new System.Drawing.Point(68, 47);
            this.videoIP.Name = "videoIP";
            this.videoIP.Size = new System.Drawing.Size(191, 21);
            this.videoIP.TabIndex = 3;
            this.videoIP.Text = "192.168.1.108";
            // 
            // videoPort
            // 
            this.videoPort.Location = new System.Drawing.Point(68, 77);
            this.videoPort.Name = "videoPort";
            this.videoPort.Size = new System.Drawing.Size(191, 21);
            this.videoPort.TabIndex = 3;
            this.videoPort.Text = "37777";
            // 
            // userN
            // 
            this.userN.Location = new System.Drawing.Point(68, 104);
            this.userN.Name = "userN";
            this.userN.Size = new System.Drawing.Size(191, 21);
            this.userN.TabIndex = 3;
            this.userN.Text = "admin";
            // 
            // videoPsw
            // 
            this.videoPsw.Location = new System.Drawing.Point(68, 131);
            this.videoPsw.Name = "videoPsw";
            this.videoPsw.PasswordChar = '*';
            this.videoPsw.Size = new System.Drawing.Size(191, 21);
            this.videoPsw.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "目标IP:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "端  口:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "用户名:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "密  码:";
            // 
            // closeWin
            // 
            this.closeWin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeWin.Image = global::ZforeServiceClient.Properties.Resources.close;
            this.closeWin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.closeWin.Location = new System.Drawing.Point(175, 22);
            this.closeWin.Name = "closeWin";
            this.closeWin.Size = new System.Drawing.Size(75, 23);
            this.closeWin.TabIndex = 5;
            this.closeWin.Text = "取  消";
            this.closeWin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.closeWin.UseVisualStyleBackColor = true;
            this.closeWin.Click += new System.EventHandler(this.closeWin_Click);
            // 
            // rightAdd
            // 
            this.rightAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rightAdd.Enabled = false;
            this.rightAdd.Image = global::ZforeServiceClient.Properties.Resources.add;
            this.rightAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rightAdd.Location = new System.Drawing.Point(92, 22);
            this.rightAdd.Name = "rightAdd";
            this.rightAdd.Size = new System.Drawing.Size(75, 23);
            this.rightAdd.TabIndex = 5;
            this.rightAdd.Text = "确  认";
            this.rightAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rightAdd.UseVisualStyleBackColor = true;
            this.rightAdd.Click += new System.EventHandler(this.rightAdd_Click);
            // 
            // testCon
            // 
            this.testCon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.testCon.Image = global::ZforeServiceClient.Properties.Resources.connect;
            this.testCon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.testCon.Location = new System.Drawing.Point(6, 22);
            this.testCon.Name = "testCon";
            this.testCon.Size = new System.Drawing.Size(75, 23);
            this.testCon.TabIndex = 5;
            this.testCon.Text = "测  试";
            this.testCon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.testCon.UseVisualStyleBackColor = true;
            this.testCon.Click += new System.EventHandler(this.testCon_Click);
            // 
            // videoWin
            // 
            this.videoWin.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.videoWin.Location = new System.Drawing.Point(6, 20);
            this.videoWin.Name = "videoWin";
            this.videoWin.Size = new System.Drawing.Size(259, 140);
            this.videoWin.TabIndex = 0;
            this.videoWin.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.videoEnable);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.vidoeLabe);
            this.groupBox2.Controls.Add(this.videoIP);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.videoPort);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.userN);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.videoPsw);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(512, 176);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(265, 185);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "配置";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.closeWin);
            this.groupBox3.Controls.Add(this.rightAdd);
            this.groupBox3.Controls.Add(this.testCon);
            this.groupBox3.Location = new System.Drawing.Point(512, 362);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.groupBox3.Size = new System.Drawing.Size(265, 63);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "标  识:";
            // 
            // vidoeLabe
            // 
            this.vidoeLabe.Location = new System.Drawing.Point(68, 20);
            this.vidoeLabe.Name = "vidoeLabe";
            this.vidoeLabe.Size = new System.Drawing.Size(191, 21);
            this.vidoeLabe.TabIndex = 3;
            this.vidoeLabe.Text = "实名制抓拍";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "状  态:";
            // 
            // videoEnable
            // 
            this.videoEnable.AutoSize = true;
            this.videoEnable.Location = new System.Drawing.Point(69, 159);
            this.videoEnable.Name = "videoEnable";
            this.videoEnable.Size = new System.Drawing.Size(48, 16);
            this.videoEnable.TabIndex = 6;
            this.videoEnable.Text = "禁用";
            this.videoEnable.UseVisualStyleBackColor = true;
            // 
            // VideoID
            // 
            this.VideoID.DataPropertyName = "VideoID";
            this.VideoID.HeaderText = "编号";
            this.VideoID.Name = "VideoID";
            this.VideoID.ReadOnly = true;
            this.VideoID.Width = 60;
            // 
            // VideoName
            // 
            this.VideoName.DataPropertyName = "VideoName";
            this.VideoName.HeaderText = "名字";
            this.VideoName.Name = "VideoName";
            this.VideoName.ReadOnly = true;
            // 
            // Enable
            // 
            this.Enable.DataPropertyName = "Enable";
            this.Enable.HeaderText = "是否启用";
            this.Enable.Name = "Enable";
            this.Enable.ReadOnly = true;
            this.Enable.Width = 90;
            // 
            // IP
            // 
            this.IP.DataPropertyName = "IP";
            this.IP.HeaderText = "IP";
            this.IP.Name = "IP";
            this.IP.ReadOnly = true;
            // 
            // Port
            // 
            this.Port.DataPropertyName = "Port";
            this.Port.HeaderText = "端口";
            this.Port.Name = "Port";
            this.Port.ReadOnly = true;
            this.Port.Width = 60;
            // 
            // UserName
            // 
            this.UserName.DataPropertyName = "UserName";
            this.UserName.HeaderText = "用户名";
            this.UserName.Name = "UserName";
            this.UserName.ReadOnly = true;
            // 
            // Password
            // 
            this.Password.DataPropertyName = "Password";
            this.Password.HeaderText = "密码";
            this.Password.Name = "Password";
            this.Password.ReadOnly = true;
            // 
            // DHVideoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 430);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridVideo);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DHVideoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "我的摄像头";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVideo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.videoWin)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridVideo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox videoWin;
        private System.Windows.Forms.TextBox videoIP;
        private System.Windows.Forms.TextBox videoPort;
        private System.Windows.Forms.TextBox userN;
        private System.Windows.Forms.TextBox videoPsw;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button testCon;
        private System.Windows.Forms.Button rightAdd;
        private System.Windows.Forms.Button closeWin;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox vidoeLabe;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox videoEnable;
        private System.Windows.Forms.DataGridViewTextBoxColumn VideoID;
        private System.Windows.Forms.DataGridViewTextBoxColumn VideoName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Enable;
        private System.Windows.Forms.DataGridViewTextBoxColumn IP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Port;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
    }
}