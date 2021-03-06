﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        void registerUser(string userName, string Password, string phoneno, string email, string homeaddress, string pincode);

        [OperationContract]
        bool isValidUser(string userName, string Password);

        
        [OperationContract]
        void enteritems(string productName, string catagory, string id, string ima,string item);

        [OperationContract]
        List<Product> Showproduct();

        [OperationContract]
        List<UserProduct> ShowUserProduct();

        [OperationContract]
        void delteOrder();

        [OperationContract]
        void Identify_admin(string name , string password );

        [OperationContract]
        List<Admin_restriction>Admin_list();


        [OperationContract]
        List<feedback> userfeedback();

        [OperationContract]
        void userviews(string feedback);

        [OperationContract]
        void Useritems(string productName, string price, string id);

        [OperationContract]
        bool loginAsAdmin();

        /*[OperationContract]
        Product searchitems(int i);*/


         [OperationContract]
        void deleteitems(string productName, string catagory, string id, string image , string pri);

         [OperationContract]
         void Orderdate(string Date, string number);

         [OperationContract]
         List<Order> ShowOrder();

         [OperationContract]
         List<UserInformation> ShowUser();

        /*[OperationContract]
        int getlengthofarray();*/ 

        [OperationContract]
        string GetData(int value);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        // TODO: Add your service operations here
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
