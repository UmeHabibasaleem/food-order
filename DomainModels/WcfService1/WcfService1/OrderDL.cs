using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfService1
{
    public class OrderDL
    {
        public static List<Order> items = new List<Order>();
        public void addItems(Order t)
        {
            items.Add(t);
        }
        //void deleteOrder();
    }
}