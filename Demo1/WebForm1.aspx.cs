﻿using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Demo1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAnswer_Click(object sender, EventArgs e)
        {
            lblAnswer.Text = (1 + 1 + 1 * 0 + 1).ToString();
        }
    }
}