using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace database_task_loginpage
{
    public partial class forgrt_password : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            string jk1;
            jk1 = "Data source=DESKTOP-P5QVRFC\\SQLEXPRESS; Initial Catalog=jk;Integrated Security=true;";

            SqlConnection c1 = new SqlConnection(jk1);

            string x;
            x = "Update jedhe set  password='" + TextBox3.Text + "' where id=1";

            c1.Open();

            SqlCommand cmd = new SqlCommand(x, c1);

            cmd.ExecuteNonQuery();
           

                Response.Write("<script>alert('password changed successfully')</script>");

                TextBox2.Text = "";
                TextBox3.Text = "";

            

        }
    }
}