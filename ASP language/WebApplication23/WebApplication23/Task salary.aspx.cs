using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication23
{
    public partial class Task_salary : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int a, b, c, d;
            a = Int32.Parse(TextBox1.Text);

            b = Int32.Parse(TextBox2.Text);

            c = a / b;
            d = a - c;
            Label3.Text = d.ToString(); 
        }
    }
}