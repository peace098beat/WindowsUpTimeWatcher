namespace WindowsUpTimeWatcher
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label_WindowsUptime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label_AppUptime = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "起動からの時間：";
            // 
            // label_WindowsUptime
            // 
            this.label_WindowsUptime.AutoSize = true;
            this.label_WindowsUptime.Location = new System.Drawing.Point(99, 9);
            this.label_WindowsUptime.Name = "label_WindowsUptime";
            this.label_WindowsUptime.Size = new System.Drawing.Size(45, 12);
            this.label_WindowsUptime.TabIndex = 1;
            this.label_WindowsUptime.Text = "00:00:00";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label_AppUptime
            // 
            this.label_AppUptime.AutoSize = true;
            this.label_AppUptime.Location = new System.Drawing.Point(99, 30);
            this.label_AppUptime.Name = "label_AppUptime";
            this.label_AppUptime.Size = new System.Drawing.Size(45, 12);
            this.label_AppUptime.TabIndex = 3;
            this.label_AppUptime.Text = "00:00:00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "アプリ起動時間：";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(170, 58);
            this.Controls.Add(this.label_AppUptime);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label_WindowsUptime);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "WinUpTime";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_WindowsUptime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label_AppUptime;
        private System.Windows.Forms.Label label4;
    }
}

