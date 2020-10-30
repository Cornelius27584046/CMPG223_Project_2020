using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Net.Sockets;

namespace CMPG_223
{
    public partial class Login : Form
    {
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Dev\\GitHub\\CMPG223_Project_2020-reinhardt\\Alfa\\CMPG_223\\CMPG_223\\Spec1.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cmd;
        SqlDataReader dr;

        public Login()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();

            //check valid details
            if(!IsValidMail(tbxMail.Text))
            {
                System.Windows.Forms.MessageBox.Show("Please enter a correct email");
                con.Close();
                return;
            }

            //log in
            cmd = new SqlCommand("SELECT * FROM LOGIN_DETAILS WHERE Email = @mail", con);
            cmd.Parameters.Add(new SqlParameter("mail", tbxMail.Text));
            dr = cmd.ExecuteReader();
            dr.Read();
            // - check if user exists
            try
            {
                // - check if password matches
                if (!(tbxPW.Text == dr[1].ToString()))
                {
                    System.Windows.Forms.MessageBox.Show("Incorrect password.");
                    con.Close();
                    return;
                }
            } catch(Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("User does not exist.");
                Debug.WriteLine(ex.Message);
                con.Close();
                return;
            }

            con.Close();

            Orders form2 = new Orders();
            form2.MdiParent = this;
            form2.Show();
        }

        bool IsValidMail (String mail) // check if valid email
        {
            try
            {
                var ml = new System.Net.Mail.MailAddress(mail);
                return ml.Address == mail;
            }catch
            {
                return false;
            }
        }
    }
}
