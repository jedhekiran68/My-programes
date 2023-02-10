using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace databaseupdate
{
    public partial class page1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string jk;
            jk = "Data source=DESKTOP-P5QVRFC\\SQLEXPRESS; Initial Catalog=update;Integrated Security=true;";

            SqlConnection c1 = new SqlConnection(jk);

            string x;
            x = "Update student set name='" + TextBox1.Text + "', address='" + TextBox2.Text + "' where id='" + TextBox3.Text + "'";

            c1.Open();

            SqlCommand cmd = new SqlCommand(x,c1);

            cmd.ExecuteNonQuery();

            Response.Write("<script>alert('data update successfully')</script>");

            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";






            
           


        }
    }
}