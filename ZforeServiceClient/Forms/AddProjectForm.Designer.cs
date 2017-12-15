namespace ZforeServiceClient.Forms
{
    partial class AddProjectForm
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
            this.ProjectNum = new System.Windows.Forms.TextBox();
            this.rightSubmit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ProjectName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.closeDialog = new System.Windows.Forms.Button();
            this.text_verify = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ProjectNum
            // 
            this.ProjectNum.Location = new System.Drawing.Point(103, 24);
            this.ProjectNum.MaxLength = 13;
            this.ProjectNum.Name = "ProjectNum";
            this.ProjectNum.Size = new System.Drawing.Size(230, 21);
            this.ProjectNum.TabIndex = 0;
            this.ProjectNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ProjectNum_KeyPress);
            // 
            // rightSubmit
            // 
            this.rightSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.rightSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rightSubmit.Image = global::ZforeServiceClient.Properties.Resources.add;
            this.rightSubmit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rightSubmit.Location = new System.Drawing.Point(177, 132);
            this.rightSubmit.Name = "rightSubmit";
            this.rightSubmit.Size = new System.Drawing.Size(75, 23);
            this.rightSubmit.TabIndex = 2;
            this.rightSubmit.Text = "确  认";
            this.rightSubmit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rightSubmit.UseVisualStyleBackColor = true;
            this.rightSubmit.Click += new System.EventHandler(this.rightSubmit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "项目编号：";
            // 
            // ProjectName
            // 
            this.ProjectName.Location = new System.Drawing.Point(103, 57);
            this.ProjectName.Name = "ProjectName";
            this.ProjectName.Size = new System.Drawing.Size(230, 21);
            this.ProjectName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "项目名称：";
            // 
            // closeDialog
            // 
            this.closeDialog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.closeDialog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeDialog.Image = global::ZforeServiceClient.Properties.Resources.close;
            this.closeDialog.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.closeDialog.Location = new System.Drawing.Point(258, 132);
            this.closeDialog.Name = "closeDialog";
            this.closeDialog.Size = new System.Drawing.Size(75, 23);
            this.closeDialog.TabIndex = 3;
            this.closeDialog.Text = "取  消";
            this.closeDialog.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.closeDialog.UseVisualStyleBackColor = true;
            this.closeDialog.Click += new System.EventHandler(this.closeDialog_Click);
            // 
            // text_verify
            // 
            this.text_verify.Location = new System.Drawing.Point(103, 90);
            this.text_verify.Name = "text_verify";
            this.text_verify.PasswordChar = '*';
            this.text_verify.Size = new System.Drawing.Size(230, 21);
            this.text_verify.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "验证秘钥：";
            // 
            // AddProjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 167);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.closeDialog);
            this.Controls.Add(this.rightSubmit);
            this.Controls.Add(this.text_verify);
            this.Controls.Add(this.ProjectName);
            this.Controls.Add(this.ProjectNum);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddProjectForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "添加项目";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ProjectNum;
        private System.Windows.Forms.Button rightSubmit;
        private System.Windows.Forms.Button closeDialog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ProjectName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox text_verify;
        private System.Windows.Forms.Label label3;
    }
}