using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace databaseado
{
    public partial class update : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e) // update  data
        {
            string jk;
            jk = "Data source=DESKTOP-P5QVRFC\\SQLEXPRESS; Initial Catalog=crud;Integrated Security=true;";

            SqlConnection c1 = new SqlConnection(jk);

            string x;
            x = "Update jedhe set roll_no='"+TextBox1.Text+"',name='" + TextBox2.Text + "', address='" + TextBox3.Text + "'" +
                ",email='"+TextBox4.Text+"',mobile_no='"+TextBox5.Text+"' where id='" + TextBox6.Text + "'";

            c1.Open();

            SqlCommand cmd = new SqlCommand(x, c1);

            cmd.ExecuteNonQuery();

            Response.Write("<script>alert('data update successfully')</script>");

            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            TextBox5.Text = "";

        }
    }
}