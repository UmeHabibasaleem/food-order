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
    public partial class MyOrder : Form
    {
        public MyOrder()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BindingSource source = new BindingSource();
            localhost.Service1 server = new localhost.Service1();
            server.ShowUserProduct();
            source.DataSource = server.ShowUserProduct();
            dataGridView1.DataSource = source;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool a ;
            bool y;
            localhost.Service1 server = new localhost.Service1();
            server.loginAsAdmin(out a , out y);
            if (a == true)
            {
            cmdAdminpage adm = new cmdAdminpage();
            this.Hide();
            adm.Show();
            }
            else
            {
                MessageBox.Show("Your order is confirmed");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Feedback f = new Feedback();
            this.Hide();
            f.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Delivered_order d1 = new Delivered_order();
            this.Hide();
            d1.Show();
        }
    }
}
