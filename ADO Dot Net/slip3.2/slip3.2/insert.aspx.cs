using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace slip3._2
{
    public partial class insert : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string url;
            url = "Data source=DESKTOP-P5QVRFC\\SQLEXPRESS;initial catalog=practice;Integrated Security=true;";

            SqlConnection sc = new SqlConnection(url);

            string z;
            z = "insert into college (tname,tsubject,tclass,tmobileno) values('" + TextBox2.Text + "','"+TextBox3.Text+"','"+TextBox4.Text+"','"+TextBox5.Text+"')";
            sc.Open();

            SqlCommand cmd = new SqlCommand(z, sc);

            cmd.ExecuteNonQuery();

            Response.Write("<script>alert('data insert into table')</script>");

            


        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("search.aspx");
        }
    }
}