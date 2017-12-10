namespace ZforeServiceClient.Forms
{
    partial class LoadingForm
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
            this.loadingBar = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.barMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // loadingBar
            // 
            this.loadingBar.Location = new System.Drawing.Point(12, 24);
            this.loadingBar.Maximum = 10;
            this.loadingBar.Name = "loadingBar";
            this.loadingBar.Size = new System.Drawing.Size(307, 35);
            this.loadingBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.loadingBar.TabIndex = 0;
            this.loadingBar.Value = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "提示信息：";
            // 
            // barMessage
            // 
            this.barMessage.AutoSize = true;
            this.barMessage.ForeColor = System.Drawing.Color.Red;
            this.barMessage.Location = new System.Drawing.Point(72, 87);
            this.barMessage.Name = "barMessage";
            this.barMessage.Size = new System.Drawing.Size(53, 12);
            this.barMessage.TabIndex = 1;
            this.barMessage.Text = "提示信息";
            // 
            // LoadingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 111);
            this.Controls.Add(this.barMessage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loadingBar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoadingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "加载中";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar loadingBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label barMessage;
    }
}