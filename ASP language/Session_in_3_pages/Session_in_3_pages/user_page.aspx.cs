using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Session_in_3_pages
{
    public partial class user_page : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            int a;
            Session["a"] = TextBox1.Text;

            

            Response.Redirect("Home_paage.aspx");
        }
    }
}