using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterestCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            var amount = nudAmount.Value;
            var rate = nudRate.Value;
            var years = nudYears.Value;

            var balance = amount;
            for(var i = 0; i < years;i ++)
            {
                var interest = balance * rate / 100;
                balance += interest;
            }
            MessageBox.Show(balance.ToString());
        }
    }
}
