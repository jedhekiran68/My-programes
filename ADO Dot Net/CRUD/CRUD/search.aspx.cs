using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CRUD
{
    public partial class search : System.Web.UI.Page
    {
        public SqlDataReader SqlDataReader { get; private set; }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string url;
            url = "data source=DESKTOP-P5QVRFC\\SQLEXPRESS;initial catalog=practice;integrated security=true;";

            SqlConnection sc = new SqlConnection(url);

            String j;
            j = "select * from myinfo where no='" + TextBox1.Text + "' ";

            sc.Open();
            SqlCommand sm = new SqlCommand(j, sc);

            SqlDataReader sr = sm.ExecuteReader();

            if(sr.Read())
            {
                TextBox2.Text = sr["name"].ToString();
                TextBox3.Text = sr["address"].ToString();
                TextBox4.Text = sr["study"].ToString();
                TextBox5.Text = sr["mobileno"].ToString();
            }
            else
            {
                Response.Write("<script>alert('Data failed to search')</script>");
            }


            



        }
    }
}