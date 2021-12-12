using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheSum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOdd_Click(object sender, EventArgs e)
        {
            checked
            {
                long sum = 0;
                for (var i = 1; i < 1000000; i += 2)
                {
                    sum = sum + i;
                }
                MessageBox.Show(sum.ToString());

            }

        }

        private void btnEven_Click(object sender, EventArgs e)
        {
                long sum = 0;
                for (var i = 2; i < 1000000; i += 2)
                {
                    sum = sum + i;
                }
                MessageBox.Show(sum.ToString());

        }
    }
}
