using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication18
{
    public partial class dropdown_list : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
             Label2.Text = TextBox1.Text;


            if (DropDownList3.SelectedItem.Value == "red")
            {
                Label2.ForeColor = System.Drawing.Color.Red;
            }

            else if (DropDownList3.SelectedItem.Value == "green")
            {
                Label2.ForeColor = System.Drawing.Color.Green;
            }

            else if (DropDownList3.SelectedItem.Value == "black")
            {
                Label2.ForeColor = System.Drawing.Color.Black;
            }


            if (DropDownList1.SelectedItem.Value == "25")
            {
                Label2.Font.Size = 25;
            }

            else if (DropDownList1.SelectedItem.Value == "35")
            {
                Label2.Font.Size = 35;
            }

            else if (DropDownList1.SelectedItem.Value == "45")
            {
                Label2.Font.Size = 45;
            }

           else if (DropDownList1.SelectedItem.Value == "50")
            {
                Label2.Font.Size = 50;
            }
        }
    }
}