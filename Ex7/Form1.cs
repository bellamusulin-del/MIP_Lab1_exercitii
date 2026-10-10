using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1_MIP_ex7
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
        private void buttonPiros_Click(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Red;
        }

        private void buttonKek_Click(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Blue;
        }

        private void buttonFelkovert_Click(object sender, EventArgs e)
        {
            label1.Font = new Font(label1.Font, FontStyle.Bold);
        }

        private void buttonDolt_Click(object sender, EventArgs e)
        {
            label1.Font = new Font(label1.Font, FontStyle.Italic);
        }
    }
}
