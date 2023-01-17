using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication24
{
    public partial class Image_and_Image_button : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            Image5.ImageUrl = ImageButton1.ImageUrl;

            Image2.ImageUrl = ImageButton2.ImageUrl;
            Image4.ImageUrl = ImageButton2.ImageUrl;

            Image1.ImageUrl = ImageButton3.ImageUrl;
            Image3.ImageUrl = ImageButton3.ImageUrl;

        }
    }
}