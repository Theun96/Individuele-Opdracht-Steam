using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Steam_Powered.Models
{
    public class Library
    {
        readonly List<Game> _games = new List<Game>();
        
        public Library()
        {
        }

        public void AddGame(Game game)
        {
            foreach (Game g in _games)
            {
                if (g == game)
                {
                    break;
                }
            }
            game.InLibrary = true;
            _games.Add(game);
        }
    }
}