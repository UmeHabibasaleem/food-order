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

        private void cmdRemove_Click(object sender, EventArgs e)
        {
            deleteitem d1 = new deleteitem();
            this.Hide();
            d1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Infopage f = new Infopage();
            this.Hide();
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            User_food_list f = new User_food_list();
            this.Hide();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Conform_Order ord = new Conform_Order();
            this.Hide();
            ord.Show();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            UserRecord record = new UserRecord();
            this.Hide();
            record.Show();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Display d = new Display();
            this.Hide();
            d.Show();
        }
    }
}
