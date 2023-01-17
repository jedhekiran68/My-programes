using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Cookies_Set
{
    public partial class Cookie : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            

            string xyz;
            xyz = TextBox2.Text;
            Response.Cookies["nameis"].Value = xyz;

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Label3.Text = Request.Cookies["nameis"].Value;
        }
    }
}