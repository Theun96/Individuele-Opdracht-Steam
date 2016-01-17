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
        public string DlcVan { get; set; }
        public double Prijs { get; set; }

        public bool InLibrary { get; set; }
        public bool OnWishList { get; set; }

        private List<string> Groepen { get; set; } 

        public int ImageInt { get; private set; }

        public Game(string naam, string beschrijving, int categorie, DateTime uitgiftedatum, string dlcVan, double prijs)
        {
            Naam = naam;
            Beschrijving = beschrijving;
            Categorie = categorie;
            UitgifteDatum = uitgiftedatum;
            DlcVan = dlcVan;
            Prijs = prijs;

            Groepen = new List<string>();

            ImgControl();
        }

        public int AddGroep(string groep)
        {
            if (Groepen.Any(s => s == groep))
            {
                return 0;
            }

            Groepen.Add(groep);
            return 1;
        }

        private void ImgControl()
        {
            if (Naam == "Tom Clancy's Rainbow Six Siege")
            {
                ImageInt = 1;
            }
            if (Naam == "Resident Evil 0")
            {
                ImageInt = 2;
            }
            if (Naam == "Steam Controller")
            {
                ImageInt = 3;
            }
            if (Naam == "Steam Link")
            {
                ImageInt = 4;
            }
            if (Naam == "Killing Floor 2")
            {
                ImageInt = 5;
            }
        }
    }
}