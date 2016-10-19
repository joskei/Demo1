using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WcfNonSSL_WebClient
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            
        }

        protected void Button1_Click(object sender, EventArgs e)
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
                    Label1.Text = textResult;
                }
                else
                {
                    Label1.Text = "No response";
                }
            }
            catch (Exception ex)
            {
                Label1.Text = ex.ToString();
            }
        }
    }
}