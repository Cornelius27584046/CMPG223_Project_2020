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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Client has beem added");
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Client details has beem updated");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Client has beem removed");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Client has beem added");
            this.Close();
        }
    }
}
