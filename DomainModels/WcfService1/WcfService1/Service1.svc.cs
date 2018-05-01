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
            UserInformation u1 = new UserInformation();
            u1.username = userName;
            u1.Password = Password;
            u1.Phoneno = phoneno;
            u1.Email = email;
            u1.homeAddress = homeaddress;
            u1.Pincode = pincode;
            User_DL d1 = new User_DL();
            d1.Adduser(u1);
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
        public void enteritems(string productName, string catagory, string id, string ima)
        {
            Product item = new Product();
            item.name = productName;
            item.id = id;
            item.category = catagory;
            item.image = ima;
            Shoppingcart cart = new Shoppingcart();
            cart.addItems(item);
        }
        public Product searchitems(int i)
        {
            Product l = new Product();
            Shoppingcart u = new Shoppingcart();
            l = u.searchitems(i);
            return l;
        }
        public int getlengthofarray()
        {
            Shoppingcart t = new Shoppingcart();
            int y = t.lengthofarray();
            return y;
        }


        public void deleteitems(string productName, string catagory, string id, string image)
        {

            Shoppingcart cart = new Shoppingcart();
            foreach (Product item12 in Shoppingcart.items)
            {
                if (item12.name == productName && item12.category == catagory && item12.id == id)
                {
                    cart.deleteItems(item12);
                }
            }


        }










 

                
    }
}




