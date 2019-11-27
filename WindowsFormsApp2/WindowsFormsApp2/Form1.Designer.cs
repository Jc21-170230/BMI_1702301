namespace WindowsFormsApp2
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
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.process1 = new System.Diagnostics.Process();
            this.process2 = new System.Diagnostics.Process();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.process3 = new System.Diagnostics.Process();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(85, 54);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 54);
            this.button1.TabIndex = 0;
            this.button1.Text = "メモ帳を起動";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(85, 157);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(142, 47);
            this.button2.TabIndex = 1;
            this.button2.Text = "ペイントを起動";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // process1
            // 
            this.process1.StartInfo.Domain = "";
            this.process1.StartInfo.FileName = "notepad.exe";
            this.process1.StartInfo.LoadUserProfile = false;
            this.process1.StartInfo.Password = null;
            this.process1.StartInfo.StandardErrorEncoding = null;
            this.process1.StartInfo.StandardOutputEncoding = null;
            this.process1.StartInfo.UserName = "";
            this.process1.SynchronizingObject = this;
            // 
            // process2
            // 
            this.process2.StartInfo.Domain = "";
            this.process2.StartInfo.FileName = "nspaint.exe";
            this.process2.StartInfo.LoadUserProfile = false;
            this.process2.StartInfo.Password = null;
            this.process2.StartInfo.StandardErrorEncoding = null;
            this.process2.StartInfo.StandardOutputEncoding = null;
            this.process2.StartInfo.UserName = "";
            this.process2.SynchronizingObject = this;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(306, 53);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(124, 55);
            this.button3.TabIndex = 2;
            this.button3.Text = "メモ帳停止";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(306, 157);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(124, 47);
            this.button4.TabIndex = 3;
            this.button4.Text = "ペイント停止";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // process3
            // 
            this.process3.StartInfo.Domain = "";
            this.process3.StartInfo.FileName = "www.yahoo.co.jp";
            this.process3.StartInfo.LoadUserProfile = false;
            this.process3.StartInfo.Password = null;
            this.process3.StartInfo.StandardErrorEncoding = null;
            this.process3.StartInfo.StandardOutputEncoding = null;
            this.process3.StartInfo.UserName = "";
            this.process3.SynchronizingObject = this;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(85, 254);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(142, 51);
            this.button5.TabIndex = 4;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 388);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Diagnostics.Process process1;
        private System.Diagnostics.Process process2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Diagnostics.Process process3;
    }
}

