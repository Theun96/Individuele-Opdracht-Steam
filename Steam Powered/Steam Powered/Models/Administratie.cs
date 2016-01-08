using Steam_Powered.Database;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Steam_Powered.Models
{
    public class Administratie
    {
        private User _currentUser;

        public List<Game> Games { get; set; }
        public List<User> Users { get; set; } 

        public Administratie()
        {
            //declareren
            Games = new List<Game>();
            Users = new List<User>();

            //users ophalen
            DataTable dt = DatabaseManager.ExecuteReadQuery(DatabaseQuerys.Query["GetAllUsers"], null);

            Users.Clear();

            foreach (DataRow dr in dt.Rows)
            {
                var userName = dr["username"].ToString();
                var nickName = dr["nickname"].ToString();
                var wachtwoord = dr["wachtwoord"].ToString();
                var adres = dr["adres"].ToString();
                var status = dr["status"].ToString();
                var geld = Convert.ToDouble(dr["username"]);
                var rol = Convert.ToInt32(dr["rol"]);

                Users.Add(new User(userName, nickName, wachtwoord, adres, status, geld, rol));
            }

            dt = DatabaseManager.ExecuteReadQuery(DatabaseQuerys.Query["GetAllGames"], null);

            Games.Clear();

            foreach (DataRow dr in dt.Rows)
            {
                var naam = dr["naam"].ToString();
                var beschrijving = dr["beschrijving"].ToString();
                var categorie = Convert.ToInt32(dr["categorie"]);
                var uitgiftedatum = Convert.ToDateTime(dr["uitgiftedatum"]);
                var dlcVan = Convert.ToInt32(dr["dlc_Van"]);
                var prijs = Convert.ToDouble(dr["prijs"]);

                Games.Add(new Game(naam, beschrijving, categorie, uitgiftedatum, dlcVan, prijs));
            }
        }

        public void BuyGame(string naam)
        {
            foreach (Game g in Games.Where(g => g.Naam == naam))
            {
                _currentUser.AddGame(g);
            }
        }

        public int AddContent(Game game)
        {
            if (Games.Any(g => g == game))
            {
                return 0;
            }
            Games.Add(game);
            return 1;
        }

        public int RemoveContent(Game game)
        {
            foreach (Game g in Games.Where(g => g == game))
            {
                Games.Remove(g);
                return 1;
            }
            return 0;
        }

        public int Login(User loggedUser)
        {
            _currentUser = loggedUser;
            return 1;
        }

        public int Register(string userName, string nickName, string password, string adres)
        {
            if (Users.Any(u => u.UserName == userName))
            {
                return 0;
            }

            User newUser = new User(userName, nickName, password, adres, "", 0.00, 0);
            
            Users.Add(newUser);
            return 1;
        }
    }
}