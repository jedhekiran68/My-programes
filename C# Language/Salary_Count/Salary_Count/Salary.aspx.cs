using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Salary_Count
{
    public partial class Salary : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int a, b, perday, total ,ans;

            a = Int32.Parse(TextBox1.Text);
            b = Int32.Parse(TextBox2.Text);

            perday = a / 30;
         
            total = perday * b;
            ans = a - total;

            Label3.Text = ans.ToString();





        }
    }
}