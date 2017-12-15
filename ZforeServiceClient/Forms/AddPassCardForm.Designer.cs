namespace ZforeServiceClient.Forms
{
    partial class AddPassCardForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.cardNum = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.endDateTime = new System.Windows.Forms.DateTimePicker();
            this.submitCard = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "姓  名：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "卡  号：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "密  码：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "有效期：";
            // 
            // name
            // 
            this.name.Enabled = false;
            this.name.Location = new System.Drawing.Point(95, 12);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(220, 21);
            this.name.TabIndex = 1;
            // 
            // cardNum
            // 
            this.cardNum.Location = new System.Drawing.Point(95, 41);
            this.cardNum.Name = "cardNum";
            this.cardNum.Size = new System.Drawing.Size(220, 21);
            this.cardNum.TabIndex = 2;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(95, 70);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(220, 21);
            this.password.TabIndex = 3;
            this.password.Text = "1234";
            // 
            // endDateTime
            // 
            this.endDateTime.Location = new System.Drawing.Point(95, 99);
            this.endDateTime.MaxDate = new System.DateTime(2025, 12, 31, 0, 0, 0, 0);
            this.endDateTime.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.endDateTime.Name = "endDateTime";
            this.endDateTime.Size = new System.Drawing.Size(220, 21);
            this.endDateTime.TabIndex = 4;
            // 
            // submitCard
            // 
            this.submitCard.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.submitCard.Image = global::ZforeServiceClient.Properties.Resources.save;
            this.submitCard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.submitCard.Location = new System.Drawing.Point(169, 132);
            this.submitCard.Name = "submitCard";
            this.submitCard.Size = new System.Drawing.Size(65, 23);
            this.submitCard.TabIndex = 5;
            this.submitCard.Text = "发 卡";
            this.submitCard.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.submitCard.UseVisualStyleBackColor = true;
            this.submitCard.Click += new System.EventHandler(this.submitCard_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Image = global::ZforeServiceClient.Properties.Resources.close;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(250, 132);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(65, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "取 消";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AddPassCardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 165);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.submitCard);
            this.Controls.Add(this.endDateTime);
            this.Controls.Add(this.password);
            this.Controls.Add(this.cardNum);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddPassCardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "发卡";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox cardNum;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.DateTimePicker endDateTime;
        private System.Windows.Forms.Button submitCard;
        private System.Windows.Forms.Button button2;
    }
}