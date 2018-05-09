using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfService1
{
    public class UserProduct
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string price;

        public string Price
        {
            get { return price; }
            set { price = value; }
        }
        private string id;

        public string Id
        {
            get { return id; }
            set { id = value; }
        }
    }
}