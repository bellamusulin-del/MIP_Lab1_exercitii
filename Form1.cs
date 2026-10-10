using System;
using System.Collections.Generic;
using System;
using System.Windows.Forms;

namespace Lab1_MIP_ex3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.MouseEnter += button1_MouseEnter;
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            Random rnd = new Random();

            this.Left = rnd.Next(0, 800);
            this.Top = rnd.Next(0, 500);
        }
    }
}
