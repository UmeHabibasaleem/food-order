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
    public partial class Additems : Form
    {
        public Additems()
        {
            InitializeComponent();
        }

        private void cmdadd_Click(object sender, EventArgs e)
        {
            localhost.Service1 server = new localhost.Service1();
            server.enteritems(txtitemname.Text, txtcategory.Text, txtid.Text, txtimage.Text,txtprice.Text);
            txtitemname.Text = " ";
            txtcategory.Text = " ";
            txtid.Text = " ";
            txtimage.Text = " ";
            txtprice.Text = " ";

        }

        private void Additems_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Infopage f = new Infopage();
            this.Hide();
            f.Show();
        }
    }
}
