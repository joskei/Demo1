﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfDemo
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class CustomerService : ICustomerService
    {
        [WebInvoke(Method = "GET",
            ResponseFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Wrapped,
            UriTemplate = "GetCustomers")]
        public List<Customer> GetCustomerList()
        {
            return PopulateCustomerData();
        }

        private List<Customer> PopulateCustomerData()

        {

            var lstCustomer = new List<Customer>();
            var customer1 = new Customer
            {
                CustomerID = 1,
                FirstName = "John",
                LastName = "Meaney",
                Address = "Chicago",
                Salary = "$100,000"
            };

            lstCustomer.Add(customer1);

            var customer2 = new Customer
            {
                CustomerID = 1,
                FirstName = "Peter",
                LastName = "Shaw",
                Address = "New York",
                Salary = "$200,000"
            };
            
            lstCustomer.Add(customer2);

            return lstCustomer;

        }
    }
}
