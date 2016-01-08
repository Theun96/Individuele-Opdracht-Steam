using System;
using System.Collections.Generic;

namespace ICT4Rails
{
    public static class DatabaseQuerys
    {
        public static Dictionary<string, string> Query = new Dictionary<string, string>();

        static DatabaseQuerys()
        {
            Query["GetAllLogins"] = "SELECT * FROM EMPLOYEELOGINS";
            
        }
    }
}