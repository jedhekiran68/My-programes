﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CRUD
{
    public partial class delete : System.Web.UI.Page
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
            j = "delete from myinfo where no='"+TextBox1.Text+"'";

            sc.Open();
            SqlCommand sm = new SqlCommand(j, sc);

            sm.ExecuteNonQuery();
            Response.Write("<script>alert('Data delete into table')</script>");

        }
    }
}