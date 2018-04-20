using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain_Models
{
    class UserInformation
    {

        private string Username;

        public string username
        {
            get { return Username; }
            set { Username = value; }
        }

        private string password;

        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        private string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        private string phoneno;

        public string Phoneno
        {
            get { return phoneno; }
            set { phoneno = value; }
        }
        private string HomeAddress;

        public string homeAddress
        {
            get { return HomeAddress; }
            set { HomeAddress = value; }
        }
        private string pincode;

        public string Pincode
        {
            get { return pincode; }
            set { pincode = value; }
        }
    }
}
