using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace databse_insert
{
    public partial class page1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            string jk;
            jk= "data source=DESKTOP-P5QVRFC\\SQLEXPRESS;Initial catalog=dbinsert;Integrated Security=true;";

            SqlConnection con = new SqlConnection(jk);

            string q;
            q = "insert into jedhe(name,email,mobile_no,address) values('"+TextBox1.Text+ "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "')";
            con.Open();

            SqlCommand cmd = new SqlCommand(q, con);

            cmd.ExecuteNonQuery();

            Response.Write("<Script>alert('data insert into database')</Script>");

            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";


        }
    }
}