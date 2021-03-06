﻿using System;
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

        public int UrenGespeeld { get; set; }

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

        /// <summary>
        /// Een nieuwe groep aanmaken voor de games
        /// </summary>
        /// <param name="groep"></param>
        /// <returns></returns>
        public int AddGroep(string groep)
        {
            if (Groepen.Any(s => s == groep))
            {
                return 0;
            }

            Groepen.Add(groep);
            return 1;
        }

        /// <summary>
        /// testdata voor het inladen van de afbeeldingen
        /// </summary>
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
            if(Naam == "Counter Strike : Global Offensive")
            {
                ImageInt = 6;
            }
            if (Naam == "Grand Theft Auto V")
            {
                ImageInt = 7;
            }
            if (Naam == "Team Fortress 2")
            {
                ImageInt = 8;
            }
            if (Naam == "Dota 2")
            {
                ImageInt = 9;
            }
            if (Naam == "Fallout 4")
            {
                ImageInt = 10;
            }
            if (Naam == "Goat Simulator")
            {
                ImageInt = 11;
            }
        }
    }
}