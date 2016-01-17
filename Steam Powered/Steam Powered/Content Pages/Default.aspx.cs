using System;
using Steam_Powered.Models;

namespace Steam_Powered.Content_Pages
{
    public partial class Default : System.Web.UI.Page
    {
        private Administratie _admin;

        protected void Page_Load(object sender, EventArgs e)
        {
            _admin = (Administratie) Session["AdminClass"];
        }
    }
}