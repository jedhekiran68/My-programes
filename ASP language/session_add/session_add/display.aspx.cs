using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace session_add
{
    public partial class display : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int c;
            int x, y;
            x = Int32.Parse(Session["a"].ToString());
            y = Int32.Parse(Session["b"].ToString());

            c = x + y;

            Response.Write("Addition is"+c);
        }
    }
}