using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var a = Convert.ToDouble(tbxA.Text);
            var b = Convert.ToDouble(tbxB.Text);

            var result = a + b;
            MessageBox.Show(result.ToString());
        }

        private void btnSubstract_Click(object sender, EventArgs e)
        {
            var a = Convert.ToDouble(tbxA.Text);
            var b = Convert.ToDouble(tbxB.Text);

            var result = a - b;
            MessageBox.Show(result.ToString());
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            var a = Convert.ToDouble(tbxA.Text);
            var b = Convert.ToDouble(tbxB.Text);

            var result = a * b;
            MessageBox.Show(result.ToString());
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            var a = Convert.ToDouble(tbxA.Text);
            var b = Convert.ToDouble(tbxB.Text);

            var result = a / b;
            MessageBox.Show(result.ToString());
        }

        private void btnPower_Click(object sender, EventArgs e)
        {
            var a = Convert.ToDouble(tbxA.Text);
            var b = Convert.ToDouble(tbxB.Text);

            var result = Math.Pow(a, b);
            MessageBox.Show(result.ToString());
        }

        private void btnRemainder_Click(object sender, EventArgs e)
        {
            var a = Convert.ToDouble(tbxA.Text);
            var b = Convert.ToDouble(tbxB.Text);

            var result = a % b;
            MessageBox.Show(result.ToString());
        }
    }
}
