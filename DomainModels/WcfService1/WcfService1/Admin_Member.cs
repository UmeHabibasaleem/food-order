using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfService1
{
    public class Admin_Member
    {
        public static List<Admin_restriction> member = new List<Admin_restriction>();
        public void identify_admin(Admin_restriction r1)
        {
            member.Add(r1);
        }
        public bool empty_list()
        {
            if (!member.Any())
            {
                
                return true;
            }
            else
            {
                return false;
            }

        }
        public void logout_admin(Admin_restriction r1)
        {


            member.Remove(r1);
        }
        
    }
}