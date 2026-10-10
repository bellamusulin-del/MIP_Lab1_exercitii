using System;
using System.Drawing;
using System.Windows.Forms;

namespace MIP_Lab1_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            Pen toll = new Pen(Color.Black, 2);

            g.DrawRectangle(toll, 100, 80, 300, 200);

            g.DrawLine(toll, 100, 80, 400, 280);

            g.DrawLine(toll, 400, 80, 100, 280);
        }
    }
}
