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
            var customerName = tbxName.Text;
            var deposit = nudDeposit.Value;
            var rate = nudRate.Value;

            var balance = deposit + deposit * rate / 100;

            var message = "";
            message += "Date:" + DateTime.Now + "\n";
            message += "Customer name:" + customerName + "\n";
            message += "Deposit:" + deposit + "\n";
            message += "Rate:" + rate + "\n";
            message += "Balance:" + balance + "\n";
            message += "Thank you!";

            MessageBox.Show(message);

        }
    }
}
