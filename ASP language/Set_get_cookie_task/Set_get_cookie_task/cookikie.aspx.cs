using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Set_get_cookie_task
{
    public partial class cookikie : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Cookies["username"].Value = TextBox1.Text;

            Response.Cookies["password"].Value = TextBox2.Text;

            Response.Redirect("page2.aspx");
        }
    }
}