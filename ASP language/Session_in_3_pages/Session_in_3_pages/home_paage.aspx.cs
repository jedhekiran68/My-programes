using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Session_in_3_pages
{
    public partial class home_paage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            int b, c;

            b = Int32.Parse(Session["a"].ToString());
            c = b * b;

            Response.Write(c);



            Response.Redirect("display_page.aspx");
            
        }
    }
}