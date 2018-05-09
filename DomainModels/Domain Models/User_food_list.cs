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
    public partial class User_food_list : Form
    {
        public User_food_list()
        {
            InitializeComponent();
        }

        private void User_food_list_Load(object sender, EventArgs e)
        {

            localhost.Service1 server = new localhost.Service1();

            foreach (localhost.Product p in server.Showproduct())
            {
                dataGridView1.Rows.Add(false);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selected_row = dataGridView1.Rows[index];
            localhost.Service1 server = new localhost.Service1();
            string a = selected_row.Cells[4].Value.ToString();
            string b = selected_row.Cells[5].Value.ToString();
            string c = selected_row.Cells[2].Value.ToString();
            server.Useritems(a, b, c);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            BindingSource source = new BindingSource();
            localhost.Service1 server = new localhost.Service1();
            server.Showproduct();
            source.DataSource = server.Showproduct();
            dataGridView1.DataSource = source;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MyOrder order = new MyOrder();
            this.Hide();
            order.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cmdAdminpage admin = new cmdAdminpage();
            this.Hide();
            admin.Show();
        }
    }
}
