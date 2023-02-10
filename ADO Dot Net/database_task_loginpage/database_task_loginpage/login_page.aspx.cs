using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace database_task_loginpage
{
    public partial class login_page : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            string url;
            url = "data source=DESKTOP-P5QVRFC\\SQLEXPRESS;Initial catalog=jk;Integrated security=true;";

            SqlConnection c1 = new SqlConnection(url);

            string q = "select * from jedhe  where username='" + TextBox1.Text + "' and password='" + TextBox2.Text + "'";



            SqlCommand cmd = new SqlCommand(q, c1);

            c1.Open();
            SqlDataReader r1 = cmd.ExecuteReader();

            if (r1.Read())
            {
                TextBox1.Text = r1["username"].ToString();
                TextBox2.Text = r1["password"].ToString();

                Response.Write("<script>alert('login successfull')</script>");
               
            }
            else
            {
                Response.Write("<script>alert('login failed')</script>");
            }















        }
    }
}