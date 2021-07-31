using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAbs_Click(object sender, EventArgs e)
        {
            int num, result;
            num = int.Parse(txtInput.Text);
            result = Math.Abs(num);
            lblOutput.Text = result.ToString();
        }

        private void btnRoot_Click(object sender, EventArgs e)
        {
            double num, result;
            num = double.Parse(txtInput.Text);
            result = Math.Round(Math.Sqrt(num),5);
            lblOutput.Text = result.ToString();
        }
    }
}
