using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CRUD
{
    public partial class update : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string url;
            url = "data source=DESKTOP-P5QVRFC\\SQLEXPRESS;initial catalog=practice;integrated security=true;";

            SqlConnection sc = new SqlConnection(url);

            String j;
            j = "update myinfo set name='" + TextBox1.Text + "',address='" + TextBox2.Text + "',study='" + TextBox3.Text + "',mobileno='" + TextBox4.Text + "'";

            sc.Open();
            SqlCommand sm = new SqlCommand(j, sc);

            sm.ExecuteNonQuery();
            Response.Write("<script>alert('Data update into table')</script>");


        }
    }
}