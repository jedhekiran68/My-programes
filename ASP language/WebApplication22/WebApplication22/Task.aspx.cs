using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication22
{
    public partial class Task : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "1")
            {
                Label4.Text = ("one");
            }
            else if (TextBox1.Text == "2")
            {
                Label4.Text = ("two");
            }
            else if (TextBox1.Text == "3")
            {
                Label4.Text = ("Three");
            }
            else if (TextBox1.Text == "4")
            {
                Label4.Text = ("Four");
            }
            else if (TextBox1.Text == "5")
            {
                Label4.Text = ("Five");
            }
            else if (TextBox1.Text == "6")
            {
                Label4.Text = ("Six");
            }
            else if (TextBox1.Text == "7")
            {
                Label4.Text = ("Seven");
            }
            else if (TextBox1.Text == "8")
            {
                Label4.Text = ("Eight");
            }
            else if (TextBox1.Text == "9")
            {
                Label4.Text = ("Nine");
            }
            else if (TextBox1.Text == "0")
            {
                Label4.Text=("zero");
            }
        }
    }
}