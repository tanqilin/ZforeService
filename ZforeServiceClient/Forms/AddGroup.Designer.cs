namespace ZforeServiceClient.Forms
{
    partial class AddGroup
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupName = new System.Windows.Forms.TextBox();
            this.rightAdd = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新宋体", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(30, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "班组名：";
            // 
            // groupName
            // 
            this.groupName.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupName.Location = new System.Drawing.Point(110, 43);
            this.groupName.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.groupName.Name = "groupName";
            this.groupName.Size = new System.Drawing.Size(220, 23);
            this.groupName.TabIndex = 1;
            // 
            // rightAdd
            // 
            this.rightAdd.Image = global::ZforeServiceClient.Properties.Resources.add;
            this.rightAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rightAdd.Location = new System.Drawing.Point(174, 109);
            this.rightAdd.Name = "rightAdd";
            this.rightAdd.Size = new System.Drawing.Size(75, 23);
            this.rightAdd.TabIndex = 2;
            this.rightAdd.Text = "确  认";
            this.rightAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rightAdd.UseVisualStyleBackColor = true;
            this.rightAdd.Click += new System.EventHandler(this.rightAdd_Click);
            // 
            // button2
            // 
            this.button2.Image = global::ZforeServiceClient.Properties.Resources.close;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(255, 109);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "取  消";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AddGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 145);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.rightAdd);
            this.Controls.Add(this.groupName);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddGroup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "编辑班组";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox groupName;
        private System.Windows.Forms.Button rightAdd;
        private System.Windows.Forms.Button button2;
    }
}