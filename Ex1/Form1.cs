using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MIP_Lab1_ex1
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

        private void txt_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_up_Click(object sender, EventArgs e)
        {
            txt_box.Top -= 10;
        }

        private void btn_down_Click(object sender, EventArgs e)
        {
            txt_box.Top += 10;
        }

        private void btn_left_Click(object sender, EventArgs e)
        {
            txt_box.Left -= 10;
        }
    }
}
