using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kadai0618
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            if( A < B)
                else(A < C)
                        MessageBox1( A = MAX);
                else(B < C)
                    MessageBox2(B = MID);
                else
                    MessageBox3(C = MIN);

            if (B < A)
                else (B < C)
                        MessageBox1(B = MAX);
                else (A < C)
                    MessageBox2(A = MID);
                else
                    MessageBox3(C = MIN);

            if (C < A)
                else (C < B)
                        MessageBox1(C = MAX);
                else (A < C)
                     MessageBox2(A = MID);
                else
                     MessageBox3(C = MIN);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int A = int.Parse(tbxAge1.Text);
            int B = int.Parse(tbxAge2.Text);
            int C = int.Parse(tbxAge3.Text);
            if (A < B)
                else(A < C)
                lblResult1.Text = 

        }
    }
}
