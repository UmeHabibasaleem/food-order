using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;
namespace WcfService1
{
    [DataContract]
    public class Product
    {
        private string id;

        [DataMember]
        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        private string name;

        [DataMember]
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string category;

        [DataMember]
        public string Category
        {
            get { return category; }
            set { category = value; }
        }
        private string image;

        [DataMember]
        public string Image
        {
            get { return image; }
            set { image = value; }
        }
        private string price;
        [DataMember]
        public string Price
        {
            get { return price; }
            set { price = value; }
        }
    }
}