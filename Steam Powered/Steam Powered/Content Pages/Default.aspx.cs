using Steam_Powered.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Steam_Powered
{
    public partial class Default : System.Web.UI.Page
    {
        private User _currentUser;

        public List<Game> Games { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            Games = new List<Game>();

            //testdata 
            
            _currentUser = new User(1, "theun", "theun", "password", "adres", "status enzo", 10.00, 0);
            Games.Add(new Game(1, "game1", "", 1, new DateTime(2016, 1, 7), 0, 19.95));
        }

        private void BuyGame(string naam)
        {
            foreach (Game g in Games.Where(g => g.Naam == naam))
            {
                _currentUser.AddGame(g);
            }
        }

        private int AddContent(Game game)
        {
            if (Games.Any(g => g == game))
            {
                return 0;
            }
            Games.Add(game);
            return 1;
        }

        private int RemoveContent(Game game)
        {
            foreach (Game g in Games.Where(g => g == game))
            {
                Games.Remove(g);
                return 1;
            }
            return 0;
        }
    }
}