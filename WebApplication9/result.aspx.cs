using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class jquery_jquery_ajax_load_result : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            string name = Request.Form["name"];
            string city = Request.Form["city"];

            Response.Write("Welcome Mr. " + name + " from " + city);
            Response.End();
        }
    }
}