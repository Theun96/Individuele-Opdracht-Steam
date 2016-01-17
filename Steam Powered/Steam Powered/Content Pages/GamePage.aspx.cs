using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Oracle.ManagedDataAccess.Client;
using Steam_Powered.Database;
using Steam_Powered.Models;

namespace Steam_Powered.Content_Pages
{
    public partial class GamePage : System.Web.UI.Page
    {
        private Administratie _admin;
        private Game _game;

        public string GameName { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            string idstring = Request.QueryString["naam"];
            if (idstring == null) Response.Redirect("/");
            GameName = idstring;

            _admin = (Administratie)Session["AdminClass"];
            
            foreach (Game g in _admin.Games.Where(g => g.Naam == GameName))
            {
                _game = g;
                imgGameImage.ImageUrl = "/pictures/" + _game.ImageInt + ".jpg";
            }

            lblGameInfo.Text = _game.Beschrijving;

            if (Session["User"] == null)
            {
                btnBuyGame.Enabled = false;
                btnAddWishlist.Enabled = false;
            }
            else
            {
                btnBuyGame.Enabled = true;
                btnAddWishlist.Enabled = true;
            }
        }

        protected void BuyGame_Click(object sender, EventArgs e)
        {
            int i = _admin.BuyGame(GameName);

            if (i == 1)
            {
                lblBuyInfo.Text = "De game is succesvol gekocht";
            }
            if (i == 3)
            {
                lblBuyInfo.Text = "De game staat al in je Library";
            }
            if (i == 0)
            {
                lblBuyInfo.Text = "Er is een fout opgetreden, de game is niet gekocht";
            }

            lblWishInfo.Text = "";
        }

        protected void btnAddWishlist_Click(object sender, EventArgs e)
        {
            User currentUser = _admin.GetUserData();

            List<Game> currentUserLibrary = currentUser.PersonalLibary.ShowLibrary();
            
            foreach (Game g in currentUserLibrary)
            {
                if (g == _game && g.InLibrary)
                {
                    lblWishInfo.Text = "De Game staat al in je library";
                    lblBuyInfo.Text = "";
                    return;
                }

                if (g == _game && g.OnWishList)
                {
                    lblWishInfo.Text = "De Game staat al in je Wishlist";
                    lblBuyInfo.Text = "";
                    return;
                }

            }

            currentUser.PersonalLibary.AddGameWishList(_game);
            lblWishInfo.Text = "De game is succesvol aan je Wishlist toegevoegd";
            lblBuyInfo.Text = "";
        }
    }
}