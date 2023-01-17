using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace set_get_cookie
{
    public partial class cookie : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //  int ab;
            // ab =Int32.Parse( TextBox1.Text);
            Response.Cookies["roll_no"].Value = TextBox1.Text;

            string xyz;
            xyz = TextBox2.Text;
            Response.Cookies["name"].Value = xyz;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Label3.Text = Request.Cookies["roll_no"].Value;

            Label4.Text = Request.Cookies["name"].Value;

        }
    }
}