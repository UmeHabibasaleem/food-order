using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Domain_Models
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
             localhost.Service1 server = new localhost.Service1();
            bool isvaliduser;
            bool isvaliduserpassed;
            server.isValidUser(txtUsername.Text, txtpassword.Text, out isvaliduser, out isvaliduserpassed);
            if (isvaliduser)
            {
                MessageBox.Show("valid user");
                User_food_list f = new User_food_list();
                this.Hide();
                f.Show();
            }
            else
            {
                MessageBox.Show("invalid user");
            }
            txtUsername.Text = " ";
            txtpassword.Text = " ";
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            localhost.Service1 server = new localhost.Service1();
            server.Identify_admin(txtUsername.Text, txtpassword.Text);
            txtUsername.Text = " ";
            txtpassword.Text = " ";
            cmdAdminpage admin = new cmdAdminpage();
            this.Hide();
            admin.Show();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
