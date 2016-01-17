using System.Collections.Generic;

namespace Steam_Powered.Database
{
    public static class DatabaseQuerys
    {
        public static Dictionary<string, string> Query = new Dictionary<string, string>();

        static DatabaseQuerys()
        {
            Query["GetAllUsers"] = "SELECT * FROM PLAYER";
            Query["GetAllGames"] = "SELECT * FROM GAME";
            Query["GetSpecificGame"] = "SELECT * FROM GAME WHERE naam = :gamenaam";
            Query["GetLogin"] = "SELECT * FROM Players";
            Query["InsertNewLogin"] = "INSERT INTO PLAYER(USERNAME, NICKNAME, WACHTWOORD, ADRES, STATUS, GELD) VALUES (:username, :nickname, :wachtwoord, :adres, 0.00)";
        }
    }
}