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
    public partial class Conform_Order : Form
    {
        public Conform_Order()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            localhost.Service1 server = new localhost.Service1();
            server.Orderdate(textBox1.Text, textBox2.Text);
            textBox1.Text = " ";
            textBox2.Text = " ";
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OrderList order = new OrderList();
            this.Hide();
            order.Show();
        }
    }
}
