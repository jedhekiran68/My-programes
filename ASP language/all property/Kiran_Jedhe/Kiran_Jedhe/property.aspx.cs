using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Kiran_Jedhe
{
    public partial class property : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
            Session["mobile"] = TextBox1.Text + TextBox2.Text ;

            Session["tp"] = TextBox3.Text;
            Session["k"] = TextBox3.Text;

            Session["i"] = TextBox5.Text;

            Response.Redirect("kiranj.aspx");
            
        }

        protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox1.Checked == true)
            {
                Label10.ForeColor = System.Drawing.Color.Green;
                Label10.Text = "Thanks to accept term and conditions";
            }
            else
            {
                Label10.ForeColor = System.Drawing.Color.Red;
                Label10.Text = "Please accept term and conditions";
            }
        }

        protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
           
        }
    }
}