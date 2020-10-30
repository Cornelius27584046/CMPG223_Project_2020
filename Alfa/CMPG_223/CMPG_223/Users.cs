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
    public partial class Users : Form
    {
        public Users()
        {
            InitializeComponent();
        }

        private void Users_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton1.Checked == true)
            {
                textBox11.Visible = true;
                textBox12.Visible = true;
                textBox14.Visible = true;
                textBox13.Visible = true;
                comboBox2.Visible = true;
                label12.Visible = true;
                label13.Visible = true;
                label14.Visible = true;
                label15.Visible = true;
                label16.Visible = true;
            }
            else
            {
                textBox11.Visible = false;
                textBox12.Visible = false;
                textBox14.Visible = false;
                textBox13.Visible = false;
                comboBox2.Visible = false;
                label12.Visible = false;
                label13.Visible = false;
                label14.Visible = false;
                label15.Visible = false;
                label16.Visible = false;
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //drie sql insert statments begin met address dan user dan medical aid
            MessageBox.Show("User Added");
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                //Soek en autofill die textboxes

                textBox28.Visible = true;
                textBox19.Visible = true;
                textBox20.Visible = true;
                textBox21.Visible = true;
                textBox22.Visible = true;
                textBox23.Visible = true;
                textBox24.Visible = true;
                textBox25.Visible = true;
                textBox26.Visible = true;
                textBox27.Visible = true;
                radioButton2.Visible = true;
                label32.Visible = true;
                label22.Visible = true;
                label23.Visible = true;
                label24.Visible = true;
                label25.Visible = true;
                label26.Visible = true;
                label27.Visible = true;
                label28.Visible = true;
                label29.Visible = true;
                label30.Visible = true;
                label31.Visible = true;
               
            }
            catch(Exception)
            {
                MessageBox.Show("User Id Is wrong");
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                textBox15.Visible = true;
                textBox16.Visible = true;
                textBox17.Visible = true;
                textBox18.Visible = true;
                comboBox3.Visible = true;
                label17.Visible = true;
                label18.Visible = true;
                label19.Visible = true;
                label20.Visible = true;
                label21.Visible = true;
            }
            else
            {
                textBox15.Visible = false;
                textBox16.Visible = false;
                textBox17.Visible = false;
                textBox18.Visible = false;
                comboBox3.Visible = false;
                label17.Visible = false;
                label18.Visible = false;
                label19.Visible = false;
                label20.Visible = false;
                label21.Visible = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Information Updated");
        }

        private void textBox30_TextChanged(object sender, EventArgs e)
        {
            // SEARCH QUERY
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Delete query
            MessageBox.Show("User Deleted");
        }

        private void label35_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
