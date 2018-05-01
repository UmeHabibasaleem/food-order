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
            server.enteritems(txtitemname.Text, txtcategory.Text, txtid.Text, txtimage.Text);
            txtitemname.Text = " ";
            txtcategory.Text = " ";
            txtid.Text = " ";
            txtimage.Text = " ";

            /*int n = dataGridView1.Rows.Add();
            dataGridView1.Rows[n].Cells[0].Value = txtitemname.Text;
            dataGridView1.Rows[n].Cells[1].Value = txtid.Text;
            dataGridView1.Rows[n].Cells[2].Value = txtcategory.Text;
            dataGridView1.Rows[n].Cells[3].Value = txtprice.Text;*/

        }

        private void Additems_Load(object sender, EventArgs e)
        {

        }
    }
}
