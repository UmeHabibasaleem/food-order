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
    public partial class Display : Form
    {
        public Display()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            localhost.Service1 server = new localhost.Service1();
            BindingSource source = new BindingSource();
            server.userfeedback();
            source.DataSource = server.userfeedback();
            dataGridView1.DataSource = source;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cmdAdminpage a = new cmdAdminpage();
            this.Hide();
            a.Show();
        }
    }
}
