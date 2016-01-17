using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
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
            //als er geen parameter word meegegeven, dan redirect naar homepage
            string idstring = Request.QueryString["naam"];
            if (idstring == null) Response.Redirect("Default.aspx");
            GameName = idstring;

            _admin = (Administratie)Session["AdminClass"];
            
            //zoeken welk plaatje hoort bij de huidige game
            foreach (Game g in _admin.Games.Where(g => g.Naam == GameName))
            {
                _game = g;
                imgGameImage.ImageUrl = "/pictures/" + _game.ImageInt + ".jpg";
            }

            lblGameNaam.Text = _game.Naam;
            lblGameInfo.Text = _game.Beschrijving;
            lblPrijs.Text = _game.Prijs.ToString("C");
            lblReleaseDate.Text = "Release Datum: " + _game.UitgifteDatum.ToString("dd MMMM yyyy");
            
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
            if (i == 4)
            {
                lblBuyInfo.Text = "Je hebt niet genoeg geld om dit spel te kopen";
            }

            lblWishInfo.Text = "";

            //Response.Redirect(Request.RawUrl);
        }

        /// <summary>
        /// Bekijken of de game al in je verlanglijst staat
        /// zo ja, een melding geven
        /// zo nee, de game in je verlanglijst stoppen
        /// of als je de game al gekocht hebt, daar een melding van geven.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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