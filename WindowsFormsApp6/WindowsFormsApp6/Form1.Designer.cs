namespace WindowsFormsApp6
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
            this.tbxNum1 = new System.Windows.Forms.TextBox();
            this.tbxNum2 = new System.Windows.Forms.TextBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.lblAns = new System.Windows.Forms.Label();
            this.msgbox1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "温度";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(124, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "湿度";
            // 
            // tbxNum1
            // 
            this.tbxNum1.Location = new System.Drawing.Point(194, 86);
            this.tbxNum1.Name = "tbxNum1";
            this.tbxNum1.Size = new System.Drawing.Size(162, 19);
            this.tbxNum1.TabIndex = 2;
            this.tbxNum1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // tbxNum2
            // 
            this.tbxNum2.Location = new System.Drawing.Point(194, 144);
            this.tbxNum2.Name = "tbxNum2";
            this.tbxNum2.Size = new System.Drawing.Size(162, 19);
            this.tbxNum2.TabIndex = 3;
            this.tbxNum2.TextChanged += new System.EventHandler(this.TextBox2_TextChanged);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(535, 109);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(136, 89);
            this.btn1.TabIndex = 4;
            this.btn1.Text = "判定";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // lblAns
            // 
            this.lblAns.AutoSize = true;
            this.lblAns.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblAns.Location = new System.Drawing.Point(0, 438);
            this.lblAns.Name = "lblAns";
            this.lblAns.Size = new System.Drawing.Size(0, 12);
            this.lblAns.TabIndex = 5;
            // 
            // msgbox1
            // 
            this.msgbox1.AutoSize = true;
            this.msgbox1.Location = new System.Drawing.Point(356, 283);
            this.msgbox1.Name = "msgbox1";
            this.msgbox1.Size = new System.Drawing.Size(0, 12);
            this.msgbox1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.msgbox1);
            this.Controls.Add(this.lblAns);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.tbxNum2);
            this.Controls.Add(this.tbxNum1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxNum1;
        private System.Windows.Forms.TextBox tbxNum2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Label lblAns;
        private System.Windows.Forms.Label msgbox1;
    }
}

