using System;
using System.Collections.Generic;
using System;
using System.Windows.Forms;

namespace Lab1_MIP_ex2
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

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            Random rnd = new Random();

            label1.Left = rnd.Next(0, this.ClientSize.Width - label1.Width);
            label1.Top = rnd.Next(0, this.ClientSize.Height - label1.Height);
        }
    }
}
