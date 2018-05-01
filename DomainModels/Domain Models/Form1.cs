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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            localhost.Service1 server = new localhost.Service1();
            int y;
            bool b;
            bool c = true;
            int i; 
            server.getlengthofarray(out y, out b); 
            for (int j = 0; j < y; j++)
            {
                int a = j;
                server.searchitems(int j);
                Product t = new Product();
                t = server.searchitems(int j);
                t.name =                 
                t.category =
                t.id =
                t.price =
            }

        }
    }
}
