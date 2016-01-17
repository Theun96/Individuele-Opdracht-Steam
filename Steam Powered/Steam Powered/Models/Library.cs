using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Steam_Powered.Models
{
    public class Library
    {
        private List<Game> _games;

        public Library()
        {
            _games = new List<Game>();
        }

        /// <summary>
        /// Een nieuwe game toevoegen aan je library
        /// return 0: als deze game al in je library staat
        /// return 1: als de game succesvol is toegevoegd
        /// </summary>
        /// <param name="game"></param>
        /// <returns></returns>
        public int AddGame(Game game)
        {
            foreach (Game g in _games.Where(g => g == game))
            {
                //if (g.InLibrary) return 3;
                g.InLibrary = true;
                g.OnWishList = false;

                return 1;
            }

            game.InLibrary = true;
            game.OnWishList = false;

            _games.Add(game);
            return 1;
        }

        /// <summary>
        /// Een Game uit je eigen library verwijderen
        /// return 1: als dit succes is
        /// return 0: als dit niet gelukt is
        /// </summary>
        /// <param name="game"></param>
        /// <returns></returns>
        public int RemoveGame(Game game)
        {
            foreach (Game g in _games.Where(g => g == game))
            {
                _games.Remove(g);
                return 1;
            }

            return 0;
        }

        /// <summary>
        /// Een game aan je wishlist toevoegen
        /// Checken of de game al gekocht is
        /// Checken of de game al in je wishlist staat
        /// </summary>
        /// <param name="game"></param>
        /// <returns></returns>
        public int AddGameWishList(Game game)
        {
            if (_games.Any(g => g == game || game.InLibrary))
            {
                return 0;
            }

            game.OnWishList = true;
            _games.Add(game);

            return 1;
        }

        public List<Game> ShowLibrary()
        {
            return _games;
        }
    }
}