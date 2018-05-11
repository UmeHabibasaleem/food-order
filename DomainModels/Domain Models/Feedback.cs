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
    public partial class Feedback : Form
    {
        public Feedback()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            localhost.Service1 server = new localhost.Service1();
            server.userviews(textBox1.Text);
            textBox1.Text = " ";
            MessageBox.Show("Thank You For Your Feedback");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            MyOrder b = new MyOrder();
            this.Hide();
            b.Show();
            
        }
    }
}
