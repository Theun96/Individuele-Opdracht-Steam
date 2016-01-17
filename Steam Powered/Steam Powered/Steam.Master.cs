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
        private Administratie _admin;
        private User _currentUser;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["AdminClass"] == null)
            {
                _admin = new Administratie();
                Session["AdminClass"] = _admin;
            }
            else
            {
                _admin = (Administratie) Session["AdminClass"];
            }

            if(Session["User"] == null) return;
            LoggedIn.Visible = true;
            Anonymous.Visible = false;

            _currentUser = _admin.GetUserData();
            btnUserProfile.Text = _currentUser.NickName;
            btnUserGeld.Text = _currentUser.Geld.ToString("C");
        }

        protected void btnLogUit_OnClick(object sender, EventArgs e)
        {
            Session["User"] = null;
            Response.Redirect("/Content Pages/Default.aspx");
        }

        protected void btnUserProfile_OnClick(object sender, EventArgs e)
        {
            Response.Redirect("/Content Pages/UserPage.aspx");
        }
    }
}