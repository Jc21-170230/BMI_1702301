using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null)
                MessageBox.Show("項目が未選択です", "エラー");
            else
                MessageBox.Show(listBox1.SelectedItem.ToString(), "明日は忘れずに");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
