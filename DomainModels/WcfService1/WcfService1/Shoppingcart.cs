using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfService1
{
    public class Shoppingcart
    {
        public static List<Product> items = new List<Product>();
        
        public void addItems(Product t)
        {
            items.Add(t);
        }

        //void deleteItems(Product t);
    }
}