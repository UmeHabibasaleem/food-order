using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfService1
{
    public class Order
    {
        private string date;

        public string Date
        {
            get { return date; }
            set { date = value; }
        }
        private string number;

        public string Number
        {
            get { return number; }
            set { number = value; }
        }
    }
}