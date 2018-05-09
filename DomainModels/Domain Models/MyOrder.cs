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
    }
}
