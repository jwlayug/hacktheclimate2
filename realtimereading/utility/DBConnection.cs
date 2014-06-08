using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace realtimereading.utility
{
    public class DBConnection
    {
        public static MySqlConnection getConnection()
        {
            string conString = ConfigurationManager.ConnectionStrings["climatecon"].ConnectionString;

            MySqlConnection connection = new MySqlConnection(conString);
            connection.Open();
            return connection;
        }
    }
}