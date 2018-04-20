using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain_Models
{
    class User_DL
    {

        public static List<UserInformation> username = new List<UserInformation>();
        void Adduser(UserInformation u1);
        bool search(UserInformation u1); 
    }
}
