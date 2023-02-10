using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace database_task
{
    public partial class page1 : System.Web.UI.Page
    {
       
        protected void Button1_Click(object sender, EventArgs e)
        {

            string jk;
            jk = "data source=DESKTOP-P5QVRFC\\SQLEXPRESS; Initial Catalog=database2;Integrated Security=true;";

            SqlConnection s1 = new SqlConnection(jk);

            string query;
            query = "insert into student (username,address,password,mobile_no)values('" + TextBox1.Text + "','"+TextBox2.Text+"','"+TextBox3.Text+"','"+TextBox4.Text+"')";

            SqlCommand cmd = new SqlCommand(query,s1);

            s1.Open();

            cmd.ExecuteNonQuery();

           Response.Write("<script>alert('data insert into database')</script>");

            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";


















        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("page2.aspx");
        }
    }
}