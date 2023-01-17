using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Session_all
{
    public partial class page3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["abc"] != null)
            {
                Response.Write("Roll no is" + Session["abc"].ToString());
            }
            else
            {
                Response.Redirect("Page_1.aspx");
            }

            if (Session["xyz"] != null)
            {
                Response.Write("Password is" + Session["xyz"].ToString());
            }
            else
            {
                Response.Redirect("Page_1.aspx");
            }

        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("page4.aspx");
        }
    }
}