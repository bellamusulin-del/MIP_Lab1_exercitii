using System;
using System.Drawing;
using System.Windows.Forms;

namespace MIP_Lab1_9
{
    public partial class Form1 : Form
    {
        Random random = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Graphics g = CreateGraphics();

            int x = random.Next(0, ClientSize.Width - 50);
            int y = random.Next(0, ClientSize.Height - 50);

            int tipus = random.Next(0, 3);

            Pen toll = new Pen(Color.Black, 2);

            if (tipus == 0)
            {
                g.DrawRectangle(toll, x, y, 50, 50);
            }
            else if (tipus == 1)
            {
                g.DrawEllipse(toll, x, y, 50, 50);
            }
            else
            {
                g.DrawLine(toll, x, y, x + 50, y + 50);
            }
        }
    }
}
