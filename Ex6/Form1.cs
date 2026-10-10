using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1_MIP_ex6
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
        private void buttonFel_Click(object sender, EventArgs e)
        {
            label1.Left = 0;
            label1.Top = 0;
        }

        private void buttonLe_Click(object sender, EventArgs e)
        {
            label1.Left = 0;
            label1.Top = this.ClientSize.Height - label1.Height;
        }
    }
}
