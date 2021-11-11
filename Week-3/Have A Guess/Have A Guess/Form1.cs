using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Have_A_Guess
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int computerNumber;

        private void Form1_Load(object sender, EventArgs e)
        {
            var random = new Random();
            computerNumber = random.Next(1, 100);
            MessageBox.Show(computerNumber.ToString());
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            var userNumber = nudInput.Value;
            if(computerNumber > userNumber)
            {
                MessageBox.Show("My number is more");
            }
            else if(computerNumber< userNumber)
            {
                MessageBox.Show("My number is less!");
            }
            else {
                MessageBox.Show("Well done!");
            }
            
        }
    }
}
