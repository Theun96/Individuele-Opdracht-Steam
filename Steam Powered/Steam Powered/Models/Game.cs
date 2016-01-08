using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Steam_Powered.Models
{
    public class Game
    {
        public int GameId { get; set; }
        public string Naam { get; set; }
        public string Beschrijving { get; set; }
        public int Categorie { get; set; }
        public DateTime UitgifteDatum { get; set; }
        public int DlcVan { get; set; }
        public double Prijs { get; set; }

        public bool InLibrary { get; set; }

        public Game(int gameid, string naam, string beschrijving, int categorie, DateTime uitgiftedatum, int dlcVan, double prijs)
        {
            GameId = gameid;
            Naam = naam;
            Beschrijving = beschrijving;
            Categorie = categorie;
            UitgifteDatum = uitgiftedatum;
            DlcVan = dlcVan;
            Prijs = prijs;
        }
    }
}