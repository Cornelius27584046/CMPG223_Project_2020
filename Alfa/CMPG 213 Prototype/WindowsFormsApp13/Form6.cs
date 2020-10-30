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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton2.Checked)
            {
                radioButton4.Visible = false;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                radioButton4.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked && radioButton3.Checked)
            {
                MessageBox.Show("Amount deposited new Balance:");
            }
            else if(radioButton1.Checked && radioButton4.Checked)
            { 
                //check balance first
                MessageBox.Show("Amount withdraw new Balance:");
            }

            if (radioButton2.Checked && radioButton3.Checked)
            {
                MessageBox.Show("Amount deposited new Balance:");
            }
        }
    }
}
