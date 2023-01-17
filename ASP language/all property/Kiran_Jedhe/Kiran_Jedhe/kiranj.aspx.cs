using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Kiran_Jedhe
{
    public partial class kiranj : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["mobile"] != null)
            {
                Response.Write("name:"+Session["mobile"].ToString());
            }
            else
            {
                Response.Redirect("property.aspx");
            }

            if (Session["tp"] != null)
            {
                Response.Write("Permanant address:" + Session["tp"].ToString());
            }
            else
            {
                Response.Redirect("property.aspx");
            }

            if (Session["k"] != null)
            {
                Response.Write("Current address:" + Session["k"].ToString());
            }
            else
            {
                Response.Redirect("property.aspx");
            }

            if (Session["i"] != null)
            {
                Response.Write("Pincode:" + Session["i"].ToString());
            }
            else
            {
                Response.Redirect("property.aspx");
            }






           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("last_page.aspx");
        }
    }
}