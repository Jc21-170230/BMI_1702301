using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
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
            process1.CloseMainWindow();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            process2.CloseMainWindow();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button5_Click(object sender, EventArgs e)
        {
            process3.Start();
        }
    }
}
