using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int check1, check2, check3, total;
            check1 = 0;
            check2 = 0;
            check3 = 0;
            total = 0;
               if (radioButton1.Checked)
                   check1 = 500;
               if (radioButton2.Checked)
                   check2 = 600;
               if (radioButton3.Checked)
                   check3 = 700;
               total = check1 + check2 + check3;
               MessageBox.Show("合計金額は" + total + "円です");

            /*   if (radioButton1.Checked)
                  total += check1;
              if (radioButton2.Checked)
                  total += check2;
              if (radioButton3.Checked)
                  total += check3;
              MessageBox.Show("合計金額は" + total + "円です"); */






























        }
    }
}
