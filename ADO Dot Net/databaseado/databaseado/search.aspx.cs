using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace databaseado
{
    public partial class search : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            // search a data

            string url;
            url = "data source=DESKTOP-P5QVRFC\\SQLEXPRESS;Initial catalog=crud;Integrated security=true;";

            SqlConnection c1 = new SqlConnection(url);

            string q = "select * from jedhe  where id='" + TextBox6.Text + "'";

            SqlCommand cmd = new SqlCommand(q, c1);

            c1.Open();
            SqlDataReader r1 = cmd.ExecuteReader();

            if (r1.Read())
            {
                TextBox1.Text = r1["name"].ToString();
                TextBox2.Text = r1["address"].ToString();
                TextBox3.Text = r1["email"].ToString();
                TextBox4.Text = r1["address"].ToString();
                TextBox5.Text = r1["email"].ToString();

            }
            else
            {
                Response.Write("<script>alert('data failed')</script>");
            }









        }
    }
}