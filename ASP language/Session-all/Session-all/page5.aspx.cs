using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Session_all
{
    public partial class page5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {


            if (Session["abc"] != null) 
           {
                Response.Write(Session["abc"] = null);
                Response.Redirect("Page_1.aspx");
            }

            else 
            {
                Response.Write("something went wrong");
            }
        }
    }
}