using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace database1
{
    public partial class page1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

          

            string abc;
            abc = "Data Source=DESKTOP-P5QVRFC\\SQLEXPRESS;Initial Catalog=database1;Integrated Security=true;";

            SqlConnection c1 = new SqlConnection(abc);

           

            string jk;
            jk = "insert into student(name,address,password)Values('" +TextBox1.Text+ "','" + TextBox2.Text + "','" +TextBox3.Text+ "')";

            c1.Open();

            SqlCommand c2 = new SqlCommand(jk, c1);

            
            c2.ExecuteNonQuery();

           
            Response.Write("<Script>alert('data saved successfully')</Script>");

            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
        }

        protected void Button2_Click(object sender, EventArgs e)
        {

           

            string abc;
            abc = "Data Source=DESKTOP-P5QVRFC\\SQLEXPRESS;Initial Catalog=database1;Integrated Security=true;";

            SqlConnection c1 = new SqlConnection(abc);

            string jk;
            jk = "delete from student where sid='" + TextBox4.Text + "'";

            c1.Open();

            SqlCommand c2 = new SqlCommand(jk, c1);


            c2.ExecuteNonQuery();

            Response.Write("<Script>alert('data delete successfully')</Script>");

            TextBox4.Text = "";




        }
    }
}