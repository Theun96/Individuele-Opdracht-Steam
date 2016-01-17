using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Web;

namespace Steam_Powered.Models
{
    public class User
    {
        public string UserName { get; set; }
        public string NickName { get; set; }
        public string Password { get; set; }
        public string Adres { get; set; }
        public string Status { get; set; }
        public double Geld { get; set; }
        public string Rol { get; set; }

        public Library PersonalLibary { get; set; }
        public List<User> FriendList { get; } 

        public User(string username, string nickname, string password, string adres, string status, double geld, string rol)
        {
            UserName = username;
            NickName = nickname;
            Password = password;
            Adres = adres;
            Status = status;
            Geld = geld;
            Rol = rol;

            PersonalLibary = new Library();
            FriendList = new List<User>();
        }

        /// <summary>
        /// De lijst met friends terug geven
        /// </summary>
        /// <returns></returns>
        public List<User> Friends()
        {
            return FriendList;
        }

        /// <summary>
        /// een nieuwe game toevoegen aan de library
        /// </summary>
        /// <param name="game"></param>
        /// <returns></returns>
        public int AddGame(Game game)
        {
            if (PersonalLibary.ShowLibrary().Contains(game)) return 3;
            if ((Geld - game.Prijs) >= 0)
            {
                Geld = Geld - game.Prijs;
                return PersonalLibary.AddGame(game) == 1 ? 1 : 3;
            }
            return 0;
        }

        /// <summary>
        /// een nieuwe vriend toevoegen aan de vriendenlijst
        /// </summary>
        /// <param name="friend"></param>
        /// <returns></returns>
        public int AddFriend(User friend)
        {
            if (FriendList.Any(f => f == friend))
            {
                return 0;
            }

            FriendList.Add(friend);
            return 1;
        }
    }
}