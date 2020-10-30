using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp13
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Staff member details has been changed");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Staff member has been added");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Staff member details has been deleted");
        }
    }
}
