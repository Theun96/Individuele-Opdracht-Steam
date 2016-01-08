using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Steam_Powered.Models
{
    public class Game
    {
        public string Naam { get; set; }
        public string Beschrijving { get; set; }
        public int Categorie { get; set; }
        public DateTime UitgifteDatum { get; set; }
        public int DlcVan { get; set; }
        public double Prijs { get; set; }

        public bool InLibrary { get; set; }
        public bool OnWishList { get; set; }

        public Game(string naam, string beschrijving, int categorie, DateTime uitgiftedatum, int dlcVan, double prijs)
        {
            Naam = naam;
            Beschrijving = beschrijving;
            Categorie = categorie;
            UitgifteDatum = uitgiftedatum;
            DlcVan = dlcVan;
            Prijs = prijs;
        }
    }
}