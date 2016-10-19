using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using WCFVerySecureClient.CustomerSvc;

namespace WCFVerySecureClient
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                using (var client = new CustomerServiceClient())
                {
                    if (client.ClientCredentials != null)
                    {
                        client.ClientCredentials.UserName.UserName = "Joseph";
                        client.ClientCredentials.UserName.Password = "Entergy123";
                    }

                    var lst = client.GetCustomerList();

                    foreach (var customer in lst)
                    {
                        Console.WriteLine("CustomerID: " + customer.CustomerID);
                        Console.WriteLine("LastName: " + customer.LastName);
                        Console.WriteLine("FirstName: " + customer.FirstName);
                        Console.WriteLine("Address: " + customer.Address);
                        Console.WriteLine("Salary: " + customer.Salary);
                        Console.WriteLine("------------------");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                Console.ReadLine();
            }
            

        }
    }
}
