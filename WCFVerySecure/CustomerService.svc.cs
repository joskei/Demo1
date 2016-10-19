using System;
using System.Collections.Generic;
using System.IdentityModel.Selectors;
using System.IdentityModel.Tokens;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Web.Services;
using WcfDemo;

namespace WCFVerySecure
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class CustomerService : ICustomerService
    {
        public class PasswordValidator : UserNamePasswordValidator
        {
            public override void Validate(string userName, string password)
            {
                if (string.Equals(userName, "Joseph", StringComparison.OrdinalIgnoreCase)
                    && password == "Entergy123") return;
                throw new SecurityTokenValidationException();
            }
        }

        //[WebInvoke(Method = "GET",
        //    ResponseFormat = WebMessageFormat.Json,
        //    BodyStyle = WebMessageBodyStyle.Wrapped,
        //    UriTemplate = "GetCustomers")]
        [WebMethod]
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
