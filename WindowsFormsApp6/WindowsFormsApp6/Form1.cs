using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {

            int tbxNum1;
            int tbxNum2;

            //整数値の文字列を数値化して返す
            tbxNum1 = int.Parse(lblAns.Text);
            tbxNum2 = int.Parse(lblAns.Text);
            lblAns.Text = String.Format("{0}", 0.81 * tbxNum1 + tbxNum2 * (0.99 * tbxNum1 - 14.3) + 46.3);



            if (0.81 * tbxNum1 + tbxNum2 * (0.99 * tbxNum1 - 14.3) + 46.3 <= 55)
                msgbox1.Text = "寒い";

            else 
                if (0.81 * tbxNum1 + tbxNum2 * (0.99 * tbxNum1 - 14.3) + 46.3 <= 60)
                    msgbox1.Text = "肌寒い";
            

            else if(0.81 * tbxNum1 + tbxNum2 * (0.99 * tbxNum1 - 14.3) + 46.3 <= 65)
                msgbox1.Text = "何も感じない";

            else if(0.81 * tbxNum1 + tbxNum2 * (0.99 * tbxNum1 - 14.3) + 46.3 <= 70)
                msgbox1.Text = "快い";

            else if(0.81 * tbxNum1 + tbxNum2 * (0.99 * tbxNum1 - 14.3) + 46.3 <= 75)
                msgbox1.Text = "暑くない";

            else if(0.81 * tbxNum1 + tbxNum2 * (0.99 * tbxNum1 - 14.3) + 46.3 <= 80)
                msgbox1.Text = "やや暑い";

            else if(0.81 * tbxNum1 + tbxNum2 * (0.99 * tbxNum1 - 14.3) + 46.3 <= 85)
                msgbox1.Text = "暑くて汗が出る";

            else if(0.81 * tbxNum1 + tbxNum2 * (0.99 * tbxNum1 - 14.3) + 46.3 > 85)
                msgbox1.Text = "暑くてたまらない";
              
        }

    }
}
