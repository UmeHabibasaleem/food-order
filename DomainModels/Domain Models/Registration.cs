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
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserInformation u1 = new UserInformation();
            u1.username = textBox1.Text;
            u1.Password = textBox2.Text;
            u1.Phoneno = textBox3.Text;
            u1.Email = textBox4.Text;
            u1.homeAddress = textBox5.Text;
            u1.Pincode = textBox6.Text;
            User_DL d1 = new User_DL();
            if (d1.searchuser(u1) == true)
            {
                MessageBox.Show("User already has been registered");
            }
            else
            {
                MessageBox.Show("User has been registered");
                d1.Adduser(u1);
            }
        }
    }
}
