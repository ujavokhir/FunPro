using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Leap_Year
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            var Year = nudYear.Value;
            bool isLeap;
            if (Year > 1582)
            {
                if (Year % 4 == 0)
                {
                    if(Year % 100 == 0)
                    {
                        if (Year % 400 == 0)
                        {
                            isLeap = true;
                        }
                        else
                        {
                            isLeap = false;
                        }
                    }
                    else
                    {
                        isLeap = true;
                    }
                }
                else
                {
                    isLeap = false;
                }
            }
            else
            {
                isLeap = false;
            }
            if (isLeap)
                MessageBox.Show("It is a leap year");
            else
                MessageBox.Show("It is not a leap year");
        }
    }
}
