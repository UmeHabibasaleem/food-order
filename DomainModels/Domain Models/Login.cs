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
            }
            else
            {
                MessageBox.Show("invalid user");
            }
            txtUsername.Text = " ";
            txtpassword.Text = " ";
        }
    }
}
