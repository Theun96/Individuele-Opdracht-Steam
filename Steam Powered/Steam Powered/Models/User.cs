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
        public int Rol { get; set; }

        private Library PersonalLibary { get; set; }
        private List<User> FriendList { get; } 

        public User(string username, string nickname, string password, string adres, string status, double geld, int rol)
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

        public List<User> Friends()
        {
            return FriendList;
        }

        public void AddGame(Game game)
        {
            PersonalLibary.AddGame(game);
        }

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