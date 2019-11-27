namespace kadai0618
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnJudge = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxAge1 = new System.Windows.Forms.TextBox();
            this.tbxAge2 = new System.Windows.Forms.TextBox();
            this.tbxAge3 = new System.Windows.Forms.TextBox();
            this.lblResult1 = new System.Windows.Forms.Label();
            this.lblResult2 = new System.Windows.Forms.Label();
            this.lblResult3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(256, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "B";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(393, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "C";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(129, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "MAX";
            // 
            // btnJudge
            // 
            this.btnJudge.Location = new System.Drawing.Point(395, 167);
            this.btnJudge.Name = "btnJudge";
            this.btnJudge.Size = new System.Drawing.Size(75, 23);
            this.btnJudge.TabIndex = 4;
            this.btnJudge.Text = "判定";
            this.btnJudge.UseVisualStyleBackColor = true;
            this.btnJudge.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(256, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 12);
            this.label5.TabIndex = 5;
            this.label5.Text = "MID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(395, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 12);
            this.label6.TabIndex = 6;
            this.label6.Text = "MIN";
            // 
            // tbxAge1
            // 
            this.tbxAge1.Location = new System.Drawing.Point(121, 89);
            this.tbxAge1.Name = "tbxAge1";
            this.tbxAge1.Size = new System.Drawing.Size(43, 19);
            this.tbxAge1.TabIndex = 7;
            this.tbxAge1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // tbxAge2
            // 
            this.tbxAge2.Location = new System.Drawing.Point(258, 88);
            this.tbxAge2.Name = "tbxAge2";
            this.tbxAge2.Size = new System.Drawing.Size(43, 19);
            this.tbxAge2.TabIndex = 8;
            // 
            // tbxAge3
            // 
            this.tbxAge3.Location = new System.Drawing.Point(395, 88);
            this.tbxAge3.Name = "tbxAge3";
            this.tbxAge3.Size = new System.Drawing.Size(43, 19);
            this.tbxAge3.TabIndex = 9;
            // 
            // lblResult1
            // 
            this.lblResult1.AutoSize = true;
            this.lblResult1.Location = new System.Drawing.Point(123, 279);
            this.lblResult1.Name = "lblResult1";
            this.lblResult1.Size = new System.Drawing.Size(35, 12);
            this.lblResult1.TabIndex = 13;
            this.lblResult1.Text = "label7";
            // 
            // lblResult2
            // 
            this.lblResult2.AutoSize = true;
            this.lblResult2.Location = new System.Drawing.Point(258, 278);
            this.lblResult2.Name = "lblResult2";
            this.lblResult2.Size = new System.Drawing.Size(35, 12);
            this.lblResult2.TabIndex = 14;
            this.lblResult2.Text = "label7";
            // 
            // lblResult3
            // 
            this.lblResult3.AutoSize = true;
            this.lblResult3.Location = new System.Drawing.Point(395, 278);
            this.lblResult3.Name = "lblResult3";
            this.lblResult3.Size = new System.Drawing.Size(35, 12);
            this.lblResult3.TabIndex = 15;
            this.lblResult3.Text = "label7";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblResult3);
            this.Controls.Add(this.lblResult2);
            this.Controls.Add(this.lblResult1);
            this.Controls.Add(this.tbxAge3);
            this.Controls.Add(this.tbxAge2);
            this.Controls.Add(this.tbxAge1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnJudge);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnJudge;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbxAge1;
        private System.Windows.Forms.TextBox tbxAge2;
        private System.Windows.Forms.TextBox tbxAge3;
        private System.Windows.Forms.Label lblResult1;
        private System.Windows.Forms.Label lblResult2;
        private System.Windows.Forms.Label lblResult3;
    }
}

