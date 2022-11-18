using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace A8
{
    public partial class ImageVerifier : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ImageString.ImageUrl = "imageVerifier.aspx?";    
        }
    }
}