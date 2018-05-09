using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfService1
{
    public class UserSelectedItems
    {
        public static List<UserProduct> useritems = new List<UserProduct>();

        public void useradditems(UserProduct t)
        {
            useritems.Add(t); 
        }
    }
}