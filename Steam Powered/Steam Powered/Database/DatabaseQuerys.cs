using System.Collections.Generic;

namespace Steam_Powered.Database
{
    public static class DatabaseQuerys
    {
        public static Dictionary<string, string> Query = new Dictionary<string, string>();

        static DatabaseQuerys()
        {
            Query["GetAllUsers"] = "SELECT * FROM Users";
            Query["GetAllGames"] = "SELECT * FROM Games";
            Query["GetLogin"] = "SELECT * FROM Games";
            Query["InsertNewLogin"] = "INSERT INTO PLAYER(USERNAME, NICKNAME, WACHTWOORD, ADRES, STATUS, GELD) VALUES (:username, :nickname, :wachtwoord, :adres, 0.00)";
        }
    }
}