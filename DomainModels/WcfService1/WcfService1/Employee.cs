﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfService1
{
    public class Employee
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string salary;

        public string Salary
        {
            get { return salary; }
            set { salary = value; }
        }
        private int employeeid;

        public int Employeeid
        {
            get { return employeeid; }
            set { employeeid = value; }
        }
        private string Address;

        public string address
        {
            get { return Address; }
            set { Address = value; }
        }
    }
}