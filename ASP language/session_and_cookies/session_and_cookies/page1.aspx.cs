using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace session_and_cookies
{
    public partial class page1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session["abc"] = TextBox1.Text;
            Session["xyz"] = TextBox2.Text;

            Response.Redirect("page2.aspx");
        }
    }
}