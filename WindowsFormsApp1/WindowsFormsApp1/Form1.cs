using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int intFirst;
            int intSecond;
            intFirst = int.Parse(tbxFirst.Text);
            intSecond = int.Parse(tbxSecond.Text);
            int intResult = intFirst + intSecond;
            lblResult.Text = intResult.ToString();
        }

        private void TbxFirst_TextChanged(object sender, EventArgs e)
        {
            tbxFirst.Text = "";
            tbxSecond.Text = "";
            lblResult.Text = "";
        }

        private void TbxSecond_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            int intFirst = int.Parse(tbxFirst.Text);
            int intSecond = int.Parse(tbxSecond.Text);
            int intResult = intFirst - intSecond;
            lblResult.Text = intResult.ToString();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            int intFirst = int.Parse(tbxFirst.Text);
            int intSecond = int.Parse(tbxSecond.Text);
            int intResult = intFirst * intSecond;
            lblResult.Text = intResult.ToString();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            int intFirst = int.Parse(tbxFirst.Text);
            int intSecond = int.Parse(tbxSecond.Text);
            double dblResult = (double)intFirst / intSecond;
            lblResult.Text = String.Format("{0:0.####}", dblResult);
        }
    }
}
