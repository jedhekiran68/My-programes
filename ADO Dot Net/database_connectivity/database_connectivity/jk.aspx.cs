using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace database_connectivity
{
    public partial class jk : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string jk;
            jk= "server=DESKTOP-P5QVRFC\SQLEXPRESS;uid=root;database=db1;password=;";

            SqlConnection s1 = new SqlConnection(jk);

            s1.Open();

            Response.Write("database connected");


        }
    }
}