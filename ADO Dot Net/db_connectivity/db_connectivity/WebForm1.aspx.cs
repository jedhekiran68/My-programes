using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace db_connectivity
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            string abc, xyz;

            abc = TextBox1.Text;
            xyz = TextBox2.Text;

            string pqr;

            pqr = "Data Source=DESKTOP-P5QVRFC\\SQLEXPRESS;Initial Catalog=akash;Integrated Security=true;";

            SqlConnection s1 = new SqlConnection(pqr);

            string jk;
            jk = "insert into student(username,password)values('" + abc + "','" + xyz + "')";

            s1.Open();

            SqlCommand cmd = new SqlCommand(jk,s1);

            cmd.Parameters.AddWithValue(@abc, abc);
            cmd.Parameters.AddWithValue(@xyz, xyz);

            cmd.ExecuteNonQuery();

            Response.Write("data send successfully");









        }
    }
}