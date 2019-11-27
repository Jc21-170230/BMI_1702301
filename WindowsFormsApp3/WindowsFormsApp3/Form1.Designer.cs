namespace WindowsFormsApp3
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
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.process1 = new System.Diagnostics.Process();
            this.process2 = new System.Diagnostics.Process();
            this.process3 = new System.Diagnostics.Process();
            this.process4 = new System.Diagnostics.Process();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(286, 177);
            this.button1.TabIndex = 0;
            this.button1.Text = "eclipse";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(490, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(310, 111);
            this.button2.TabIndex = 1;
            this.button2.Text = "グーグル";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(0, 330);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(243, 119);
            this.button3.TabIndex = 2;
            this.button3.Text = "キャンパスコミュニケーションサイト";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(680, 201);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(120, 248);
            this.button4.TabIndex = 3;
            this.button4.Text = "ようつべ";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // process1
            // 
            this.process1.StartInfo.Domain = "";
            this.process1.StartInfo.FileName = "C:\\Users\\170230\\Desktop\\eclipse\\eclipse.exe";
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
            this.process2.StartInfo.FileName = "www.google.com";
            this.process2.StartInfo.LoadUserProfile = false;
            this.process2.StartInfo.Password = null;
            this.process2.StartInfo.StandardErrorEncoding = null;
            this.process2.StartInfo.StandardOutputEncoding = null;
            this.process2.StartInfo.UserName = "";
            this.process2.SynchronizingObject = this;
            // 
            // process3
            // 
            this.process3.StartInfo.Domain = "";
            this.process3.StartInfo.FileName = "http://ccs.jc-21.jp/";
            this.process3.StartInfo.LoadUserProfile = false;
            this.process3.StartInfo.Password = null;
            this.process3.StartInfo.StandardErrorEncoding = null;
            this.process3.StartInfo.StandardOutputEncoding = null;
            this.process3.StartInfo.UserName = "";
            this.process3.SynchronizingObject = this;
            // 
            // process4
            // 
            this.process4.StartInfo.Domain = "";
            this.process4.StartInfo.FileName = "https://youtu.be/ed0wcZXdtTg";
            this.process4.StartInfo.LoadUserProfile = false;
            this.process4.StartInfo.Password = null;
            this.process4.StartInfo.StandardErrorEncoding = null;
            this.process4.StartInfo.StandardOutputEncoding = null;
            this.process4.StartInfo.UserName = "";
            this.process4.SynchronizingObject = this;
            this.process4.Exited += new System.EventHandler(this.Process4_Exited);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp3.Properties.Resources.画像;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Diagnostics.Process process1;
        private System.Diagnostics.Process process2;
        private System.Diagnostics.Process process3;
        private System.Diagnostics.Process process4;
    }
}

