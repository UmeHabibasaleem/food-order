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
    public partial class UserRecord : Form
    {
        public UserRecord()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            cmdAdminpage admin = new cmdAdminpage();
            this.Hide();
            admin.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BindingSource source = new BindingSource();
            localhost.Service1 server = new localhost.Service1();
            source.DataSource = server.ShowUser();
            dataGridView1.DataSource = source;
        }
    }
}
