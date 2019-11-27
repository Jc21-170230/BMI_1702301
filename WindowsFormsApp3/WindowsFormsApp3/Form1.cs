using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            process1.Start();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            process2.Start();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            process3.Start();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            process4.Start();
        }

        private void Process4_Exited(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
    }
}
