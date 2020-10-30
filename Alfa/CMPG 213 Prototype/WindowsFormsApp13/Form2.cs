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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public bool login = false;
        public string alfa;
        public string beta;

        private void button1_Click(object sender, EventArgs e)
        {
            alfa = textBox1.Text;
            beta = textBox2.Text;
            if(alfa=="1" && beta=="alfa")
            {
                MessageBox.Show("Welcome");
                login = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Try again please");
            }
        }
    }
}
