using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;
namespace WcfService1
{
    [DataContract]
    public class Admin_restriction
    {
        private string Admin_name;

         [DataMember]
        public string Admin_name1
        {
            get { return Admin_name; }
            set { Admin_name = value; }
        }


        private string Admin_Password;

         [DataMember]
        public string Admin_Password1
        {
            get { return Admin_Password; }
            set { Admin_Password = value; }
        } 
    }
}