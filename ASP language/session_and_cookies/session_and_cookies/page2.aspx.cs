using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace session_and_cookies
{
    public partial class page2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Session["abc"] != null && Session["xyz"] != null)
            {
                Response.Write(Session["abc"].ToString());
                Response.Write(Session["xyz"].ToString());
            }
            else 
            {
              
                Response.Redirect("page1.aspx");
            }


        }
    }
}