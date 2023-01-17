using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Set_get_cookie_task
{
    public partial class page2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String a, b;
            a=Request.Cookies["username"].Value;

            b = Request.Cookies["password"].Value;

            if (a == TextBox1.Text && b == TextBox2.Text)
            {
                Label3.ForeColor = System.Drawing.Color.Green;
                Label3.Text="login successfull";
            }
            else
            {
                Label3.ForeColor = System.Drawing.Color.Red;
                Label3.Text="Login failed";

                
            }
           // Response.Redirect("page2.aspx");
        }
    }
}