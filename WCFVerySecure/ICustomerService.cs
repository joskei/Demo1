using System.Collections.Generic;
using System.ServiceModel;
using WcfDemo;

namespace WCFVerySecure
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface ICustomerService

    {

        [OperationContract]

        List<Customer> GetCustomerList();

    }
}
