using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DataViewingControl
{
    public partial class Repeater : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //var ds = new DataSet();
            //ds.ReadXml(@"C:\Users\jdr81\documents\visual studio 2015\Projects\Demo1\DataViewingControl\Data.xml");

            Repeater1.DataSource = XmlDataSource1;
            Repeater1.DataBind();
        }
    }
}