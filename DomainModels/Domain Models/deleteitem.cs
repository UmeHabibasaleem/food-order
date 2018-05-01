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
    public partial class deleteitem : Form
    {
        public deleteitem()
        {
            InitializeComponent();
        }

        private void cmddelete_Click(object sender, EventArgs e)
        {
            localhost.Service1 server = new localhost.Service1();
            server.deleteitems(txtitemname.Text, txtcategory.Text, txtid.Text, txtimage.Text);
            txtitemname.Text = " ";
            txtcategory.Text = " ";
            txtid.Text = " ";
            txtimage.Text = " ";
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            Adminpage d1 = new Adminpage();
            this.Hide();
            d1.Show();
        }
    }
}
