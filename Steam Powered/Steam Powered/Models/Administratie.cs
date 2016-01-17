﻿using Oracle.ManagedDataAccess.Client;
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

        /// <summary>
        /// Administratie word hier gedeclareerd
        /// Games en Users word gevuld door de database
        /// Als er is ingelogd word de huidige user toegevoegd voor verder gebruik
        /// </summary>
        public Administratie()
        {
            //declareren
            Games = new List<Game>();
            Users = new List<User>();

            /*
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
                var geld = Convert.ToDouble(dr["geld"]);
                var rol = (dr["rol"]).ToString();

                Users.Add(new User(userName, nickName, wachtwoord, adres, status, geld, rol));
            }

            DataTable dt2 = DatabaseManager.ExecuteReadQuery(DatabaseQuerys.Query["GetAllGames"], null);

            Games.Clear();

            foreach (DataRow dr in dt2.Rows)
            {
                var naam = dr["naam"].ToString();
                var beschrijving = dr["beschrijving"].ToString();
                var categorie = Convert.ToInt32(dr["categorie"]);
                var uitgiftedatum = Convert.ToDateTime(dr["uitgiftedatum"]);
                var dlcVan = (dr["dlc_Van"]).ToString();
                var prijs = Convert.ToDouble(dr["prijs"]);

                Games.Add(new Game(naam, beschrijving, categorie, uitgiftedatum, dlcVan, prijs));
            }*/
            
            
            //Testdata omdat de connectie met de database niet werkt...
            //Testdata: Games
            Games.Add(new Game("Tom Clancy's Rainbow Six Siege", "Tom Clancy's Rainbow Six Siege is het nieuwste deel in de veelgeprezen first-person shooter franchise ontwikkeld door de gerenommeerde Ubisoft Montreal studio.",
                1, new DateTime(2015, 12, 1), "", 59.99));
            Games.Add(new Game("Resident Evil 0", "De geremasterde versie van Resident Evil 0 bevat verbluffende HD-graphics, gemoderniseerde besturing en nog veel meer",
                1, new DateTime(2016, 1, 19), "", 19.99));
            Games.Add(new Game("Steam Controller", "Experience a new level of precise control for your favorite games. The Steam Controller lets you play your entire collection of Steam games on your TV—even the ones designed without controller support in mind.",
                2, new DateTime(2015, 11, 10), "", 54.99));
            Games.Add(new Game("Steam Link", "Play your Steam games on any TV in the house with Steam Link. Setup is easy. Just connect your Steam Link to your TV and home network, where it will automatically discover any computer running Steam. Then grab a controller and play your collection of games from the comfort of your couch.",
                2, new DateTime(2015, 11, 10), "", 54.99));
            Games.Add(new Game("Killing Floor 2", "6-player co-op Zed-slaughtering mayhem. In Early Access so we can get the gameplay balance perfected, to ensure the maximum amount of fun. And blood and guts.",
                1, new DateTime(2015, 4, 21), "", 26.99));
            Games.Add(new Game("Counter Strike : Global Offensive", "Counter-Strike: Global Offensive (CS: GO) will expand upon the team-based action gameplay that it pioneered when it was launched 14 years ago. CS: GO features new maps, characters, and weapons and delivers updated versions of the classic CS content (de_dust, etc.).",
                1, new DateTime(2012, 8, 21), "", 13.99));
            Games.Add(new Game("Grand Theft Auto V", "GTA Online: Executives and Other Criminals is nu beschikbaar.Word een VIP en zet je eigen criminele organisatie op met nieuwe gameplay, aanpasbare appartementen, gepantserde voertuigen, het uitbreidbare Super Yacht en meer.",
                1, new DateTime(2015, 4, 14), "", 59.99));
            Games.Add(new Game("Team Fortress 2", "Nine distinct classes provide a broad range of tactical abilities and personalities. Constantly updated with new game modes, maps, equipment and, most importantly, hats!",
                1, new DateTime(2007, 10, 10), "", 00.00));
            Games.Add(new Game("Dota 2", "Dota begon als een door gebruikers gemaakte wijziging voor Warcraft 3 en is uitgegroeid tot een van de meest gespeelde online games in de wereld. In navolging van de traditie van Counter-Strike, Day of Defeat, Team Fortress, Portal en Alien Swarm is Dota 2 het resultaat van door Valve ingehuurde",
                3, new DateTime(2013, 7, 9), "", 00.00));
            Games.Add(new Game("Fallout 4", "Bethesda Game Studios, the award-winning creators of Fallout 3 and The Elder Scrolls V: Skyrim, welcome you to the world of Fallout 4 – their most ambitious game ever, and the next generation of open-world gaming.",
                4, new DateTime(2015, 11, 10), "", 59.99));
            Games.Add(new Game("Goat Simulator", "Just updated with free breads! Try out the life as a slice of toast, a french baguette or why not just roam around toasting things as the new toaster goat? Goat Simulator has never been less gluten free!",
                5, new DateTime(2014, 4, 1), "", 9.99));

            //Testdata User
            Users.Add(new User("theun", "theun", "password", "adres", "", 100.00, "Player"));
            Users.Add(new User("schut", "schut", "wachtwoord", "adres2", "", 50.00, "Player"));

            //User check
            if (HttpContext.Current.Session["User"] == null) return;

            foreach (User u in Users.Where(u => u.UserName == HttpContext.Current.Session["User"].ToString()))
            {
                _currentUser = u;
            }
        }

        public int BuyGame(string naam)
        {
            foreach (Game g in Games.Where(g => g.Naam == naam))
            {
                if (_currentUser.AddGame(g) == 0)
                {
                    return 3;
                }
                return 1;
            }
            return 0;
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

        public int Login(string userName, string password)
        {
            /*
            OracleParameter[] parameters =
            {
                new OracleParameter("username", userName),
                new OracleParameter("password", password),
            };
            */
            //DataTable dt = DatabaseManager.ExecuteReadQuery(DatabaseQuerys.Query["GetLogin"], parameters);

            //if (dt.Rows.Count != 1) return 0;
            foreach (User u in Users.Where(u => u.UserName == userName && password == u.Password))
            {
                _currentUser = u;
                return 1;
            }
            return 0;
        }

        public int Register(string userName, string nickName, string password, string adres)
        {
            if (Users.Any(u => u.UserName == userName))
            {
                return 0;
            }
            /*
            try
            {
                OracleParameter[] parameters =
                {
                    new OracleParameter("username", userName),
                    new OracleParameter("nickname", nickName),
                    new OracleParameter("wachtwoord", password),
                    new OracleParameter("adres", adres)
                };

                DatabaseManager.ExecuteInsertQuery(DatabaseQuerys.Query["InsertNewLogin"], parameters);
            }
            catch (Exception)
            {
                return 0;
            }
            */
            User newUser = new User(userName, nickName, password, adres, "", 0.00, "Player");

            Users.Add(newUser);
            return 1;
        }

        public User GetUserData()
        {
            return _currentUser;
        }

        public int ChangeUserData(string nickname, string status)
        {
            if (_currentUser == null) return 0;
            foreach (User currentUser in Users.Where(currebtUser => _currentUser == currebtUser))
            {
                currentUser.NickName = nickname;
                currentUser.Status = status;

                _currentUser = currentUser;
                return 1;
            }
            return 0;
        }
    }
}