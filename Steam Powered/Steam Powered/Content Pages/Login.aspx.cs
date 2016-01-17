using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Steam_Powered.Models;

namespace Steam_Powered
{
    public partial class Login : System.Web.UI.Page
    {
        private static Administratie admin { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                admin = new Administratie();
            }
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string passowrd = txtPassword.Text;

            if (admin.Login(username, passowrd) == 1)
            {
                Session["User"] = username;
            }
        }
    }
}