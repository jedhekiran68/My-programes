using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace dbcrud
{
    public partial class page1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string jk;
            jk = "data source=DESKTOP-P5QVRFC\\SQLEXPRESS;Initial catalog=crud;Integrated Security=true;";

            Sql Connection con = new SqlConnection(jk);

            string q;
            q = "insert into jedhe(roll_no,name,address,email,mobile_no) values('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','"+TextBox5.Text+"')";
            con.Open();

            SqlCommand cmd = new SqlCommand(q, con);

            cmd.ExecuteNonQuery();

            Response.Write("<Script>alert('data insert into database')</Script>");

            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            TextBox5.Text = "";

        }
    }
}