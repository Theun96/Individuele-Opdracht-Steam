using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Steam_Powered.Models
{
    public class Library
    {
        private List<Game> _games;
        private List<Game> _wishList; 

        public Library()
        {
            _games = new List<Game>();
            _wishList = new List<Game>();
        }

        public int AddGame(Game game)
        {
            if (_games.Any(g => g == game))
            {
                return 0;
            }

            game.InLibrary = true;
            game.OnWishList = false;

            foreach (Game g in _wishList.Where(g => g == game))
            {
                _wishList.Remove(g);
            }

            _games.Add(game);
            return 1;
        }

        public int RemoveGame(Game game)
        {
            foreach (Game g in _games.Where(g => g == game))
            {
                _games.Remove(g);
                return 1;
            }

            return 0;
        }

        public int AddGameWishList(Game game)
        {
            if (_wishList.Any(g => g == game || game.InLibrary))
            {
                return 0;
            }

            game.OnWishList = true;
            _wishList.Add(game);

            return 1;
        }

        public List<Game> ShowLibrary()
        {
            return _games;
        }
    }
}