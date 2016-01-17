using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Steam_Powered.Models;

namespace Steam_Powered
{
    public partial class Steam : System.Web.UI.MasterPage
    {
        private Administratie admin;

        protected void Page_Load(object sender, EventArgs e)
        {
            btnSubmitSearch.Enabled = false;

            if (Session["AdminClass"] == null)
            {
                admin = new Administratie();
                Session["AdminClass"] = admin;
            }
            
            if(Session["User"] == null) return;
            LoggedIn.Visible = true;
            Anonymous.Visible = false;
        }

        protected void btnLogUit_OnClick(object sender, EventArgs e)
        {
            Session["User"] = null;
            Response.Redirect("/Content Pages/Default.aspx");
        }
    }
}