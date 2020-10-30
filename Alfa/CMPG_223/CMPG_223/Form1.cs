using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMPG_223
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void staffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Users form1 = new Users();
            form1.MdiParent = this;
            form1.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void ordersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Orders form2 = new Orders();
            form2.MdiParent = this;
            form2.Show(); 
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stock form3 = new Stock();
            form3.MdiParent = this;
            form3.Show();
        }

        private void invoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Invoice form4 = new Invoice();
            form4.MdiParent = this;
            form4.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Login form5 = new Login();
            form5.MdiParent = this;
            form5.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login form5 = new Login();
            form5.MdiParent = this;
            form5.Show();
        }
    }
}
