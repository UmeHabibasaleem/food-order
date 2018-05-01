using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//using System.Int32;

namespace WcfService1
{
    public class Shoppingcart
    {
        public static List<Product> items = new List<Product>();
        
        public void addItems(Product t)
        {
            items.Add(t);
        }
        public Product searchitems(int i)
        {
            Product t1 = Shoppingcart.items[i];
            return t1;
        }

        //void deleteItems(Product t);

          public int lengthofarray()
          {
              int size = items.Count;       
              return size;
          }

    
   
 }
}