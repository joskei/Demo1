using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace WCFNonSSLClient
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var request = (HttpWebRequest)WebRequest.Create("http://localhost:2225/CustomerService.svc/GetCustomers");
                var response = request.GetResponse() as HttpWebResponse;
                var stream = response.GetResponseStream();

                if (stream != null)
                {
                    var reader = new StreamReader(stream);
                    var textResult = reader.ReadToEnd();
                    Console.WriteLine(textResult);
                }
                else
                {
                    Console.WriteLine("No response");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}
