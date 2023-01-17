using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication21
{
    public partial class DropDown_list : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
         
            Label4.Text=("Registration no is"+"  "+TextBox1.Text);

            Label5.Text=("my name is" + "  "+TextBox3.Text  +"  "+ TextBox2.Text);

            Label6.Text = ("mobile no is" + "  "+TextBox4.Text);

            if (DropDownList1.SelectedItem.Value == "Maharashtra")
            {
                Label8.Text = ("Welcome to Mumbai");
            }

           else if (DropDownList1.SelectedItem.Value == "Jammu Kashmir")
            {
                Label8.Text = ("Take care  Pakistan army");
            }
            else if (DropDownList1.SelectedItem.Value == "Rajasthan")
            {
                Label8.Text = ("Take a lot of water in sahara ");
            }
            else if (DropDownList1.SelectedItem.Value == "Gujarat")
            {
                Label8.Text = ("Welcome Pm.Narendra Modi");
            }
            else if (DropDownList1.SelectedItem.Value == "Nagpur")
            {
                Label8.Text = ("Stay safe for corona virus");
            }
            else if (DropDownList1.SelectedItem.Value == "Gondiya")
            {
                Label8.Text = ("Live and let live");
            }
            else if (DropDownList1.SelectedItem.Value == "Up")
            {
                Label8.Text = ("Utter pradesh");
            }
            else if (DropDownList1.SelectedItem.Value == "Mp")
            {
                Label8.Text = ("Madhya pradesh");
            }



        }
    }
}