using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShowdDigits
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            var input = Convert.ToInt32(tbxInput.Text);
            var result = "";
            while(input>0)
            {
                var lastDigit = input  % 10;
                result += lastDigit + "\n";
                input = input / 10;
            }
            MessageBox.Show(result);
        }
    }
}
