using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Strange_Language
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            var input = tbxInput.Text;
            var lengthOfFirstHalf = input.Length / 2;

            var firstPart = input.Substring(0, lengthOfFirstHalf);
            var secondPart = input.Substring(lengthOfFirstHalf);
            var result = secondPart + firstPart;

            MessageBox.Show(result);

            
        }
    }
}
