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
    public partial class Delivered_order : Form
    {
        public Delivered_order()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                localhost.Service1 server = new localhost.Service1();
                server.delteOrder();
                MessageBox.Show("order list is update");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MyOrder m1 = new MyOrder();
            this.Hide();
            m1.Show();
        }
    }
}
