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
    public partial class cmdAdminpage : Form
    {
        public cmdAdminpage()
        {
            InitializeComponent();
        }

        private void txtAddItems_Click(object sender, EventArgs e)
        {
            Additems items = new Additems();
            this.Hide();
            items.Show();
        }
    }
}
