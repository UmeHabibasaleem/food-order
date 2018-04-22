using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfService1
{
    public class User_DL
    {
         public static List<UserInformation> user = new List<UserInformation>();
        public void Adduser(UserInformation u1)
        {
            user.Add(u1);
        }
        public bool searchuser(UserInformation u1)
        {
            Boolean exist = false;
            foreach (UserInformation u2 in User_DL.user)
            {
                if (u1.username == u2.username && u1.Password == u2.Password)
                {
                    exist = true;
                }
                else
                {
                    exist = false;
                }
            }
            return exist;
        }
    
    
    }
}