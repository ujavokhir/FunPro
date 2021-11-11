using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExploringProperties
{
    public partial class ExploringProperties : Form
    {
        public ExploringProperties()
        {
            InitializeComponent();
        }

        private void btn_show_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello " + txt_name.Text + " How are you?");
        }
    }
}
