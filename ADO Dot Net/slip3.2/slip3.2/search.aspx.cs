using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace slip3._2
{
    public partial class search : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string url;
            url = "Data source=DESKTOP-P5QVRFC\\SQLEXPRESS;initial catalog=practice;Integrated Security=true;";

            SqlConnection sn = new SqlConnection(url);

            string p;
            p = "Select * from college where tid='" + TextBox1.Text + "'";

            sn.Open();
            SqlCommand cm = new SqlCommand(p, sn);

            SqlDataReader rs = cm.ExecuteReader();

            if (rs.Read())
            {
                TextBox2.Text = rs["tname"].ToString();
                TextBox3.Text = rs["tsubject"].ToString();
                TextBox4.Text = rs["tclass"].ToString();
                TextBox5.Text = rs["tmobileno"].ToString();


            }
            else
            {
                Response.Write("<script>alert('data failed to search')</script>");
            }


        }
    }
}