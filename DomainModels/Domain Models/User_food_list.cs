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

        }

        private void button1_Click(object sender, EventArgs e)
        {
            BindingSource source = new BindingSource();
            localhost.Service1 server = new localhost.Service1();
            server.Showproduct();
            source.DataSource = server.Showproduct();
            dataGridView1.DataSource = source;
        }
    }
}
