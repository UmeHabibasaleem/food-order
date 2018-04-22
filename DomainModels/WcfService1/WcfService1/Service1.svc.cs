using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
        public void registerUser(string userName, string Password ,string phoneno, string email, string homeaddress,string pincode)
        {
            UserInformation user = new UserInformation();
            user.username = userName;
            user.Password = Password;
            user.Phoneno = phoneno;
            user.Email = email;
            user.homeAddress = homeaddress;
            user.Pincode = pincode;
            User_DL d1 = new User_DL();
            d1.Adduser(user);
        }
        public bool isValidUser(string userName, string Password)
        {
            UserInformation user = new UserInformation();
            user.username = userName;
            user.Password = Password;
            bool exist = false;
            User_DL d1 = new User_DL();
            if (d1.searchuser(user) == true)
            {
                exist = true;
            }
            else
            {
                exist = false;
            }
            return exist;
        }

    }
}
