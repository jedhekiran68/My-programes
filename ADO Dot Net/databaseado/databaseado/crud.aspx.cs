using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace databaseado
{
    public partial class crud : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)  // insert data
        {
            string jk;
            jk = "data source=DESKTOP-P5QVRFC\\SQLEXPRESS;Initial Catalog=crud;Integrated security=true;";

            SqlConnection s1 = new SqlConnection(jk);

            string q;
            q = "insert into jedhe values('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + TextBox5.Text + "')";

            SqlCommand cmd = new SqlCommand(q,s1);
            s1.Open();
            cmd.ExecuteNonQuery();

            Response.Write("<script>alert('data insert successfully')</script>");

            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            TextBox5.Text = "";

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("search.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("update.aspx");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("delete.aspx");

        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            Response.Redirect("display.aspx");
        }
    }
}