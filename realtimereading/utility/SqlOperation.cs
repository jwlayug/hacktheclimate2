using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace realtimereading.utility
{
    public class SqlOperation
    {
        public MySqlDataReader login(string username, string password)
        {
            string sql = "SELECT * FROM user WHERE username = @username AND password = @password AND accountstatus = 1";
            MySqlCommand com = new MySqlCommand(sql, DBConnection.getConnection());
            com.Parameters.AddWithValue("@username", username);
            com.Parameters.AddWithValue("@password", password);
            MySqlDataReader sdr = com.ExecuteReader();
            com.Dispose();
            return sdr;
        }

        public void register(string firstname, string lastname, string email, string username, string password)
        {
            string sql = "INSERT INTO user (firstname, lastname, email, username, password, datejoined, accountstatus, readinterval) VALUES (@firstname, @lastname, @email, @username, @password, @date, @status, 0)";
            MySqlCommand com = new MySqlCommand(sql, DBConnection.getConnection());
            com.Parameters.AddWithValue("firstname", firstname);
            com.Parameters.AddWithValue("lastname", lastname);
            com.Parameters.AddWithValue("email", email);
            com.Parameters.AddWithValue("username", username);
            com.Parameters.AddWithValue("password", password);
            com.Parameters.AddWithValue("date", DateTime.Now);
            com.Parameters.AddWithValue("status", 1);
            com.ExecuteNonQuery();
            com.Dispose();
        }

        public void saveInterval(string minutes, int userid)
        {
            string sql = "UPDATE user SET readinterval = @minutes WHERE id = @userid";
            MySqlCommand com = new MySqlCommand(sql, DBConnection.getConnection());
            com.Parameters.AddWithValue("@minutes", minutes);
            com.Parameters.AddWithValue("@userid", userid);
            com.ExecuteNonQuery();
            com.Dispose();
        }

        public void insertTempReading(double temperature, int userid)
        {
            string sql = "INSERT INTO tempreading (reading, readtime, userid) VALUES (@reading, @readtime, @userid)";
            MySqlCommand com = new MySqlCommand(sql, DBConnection.getConnection());
            com.Parameters.AddWithValue("@reading", temperature);
            com.Parameters.AddWithValue("@readtime", DateTime.Now);
            com.Parameters.AddWithValue("@userid", userid);
            com.ExecuteNonQuery();
            com.Dispose();
        }

        public void insertMoistureReading(int moisture, int plotid)
        {
            string sql = "INSERT INTO moisturereading (reading, readtime, plotid) VALUES (@reading, @readtime, @plotid)";
            MySqlCommand com = new MySqlCommand(sql, DBConnection.getConnection());
            com.Parameters.AddWithValue("@reading", moisture);
            com.Parameters.AddWithValue("@readtime", DateTime.Now);
            com.Parameters.AddWithValue("@plotid", plotid);
            com.ExecuteNonQuery();
            com.Dispose();
        }

        public MySqlDataReader getInterval(int userid)
        {
            string sql = "SELECT * FROM user WHERE id = @userid";
            MySqlCommand com = new MySqlCommand(sql, DBConnection.getConnection());
            com.Parameters.AddWithValue("@userid", userid);
            MySqlDataReader sdr = com.ExecuteReader();
            com.Dispose();
            return sdr;
        }

        public void insertWatering(double water, int moisturereadingid)
        {
            string sql = "INSERT INTO watering (amountofwater, wateringtime, mreadid) VALUES (@water, @time, @mreadid)";
            MySqlCommand com = new MySqlCommand(sql, DBConnection.getConnection());
            com.Parameters.AddWithValue("@water", water);
            com.Parameters.AddWithValue("@time", DateTime.Now);
            com.Parameters.AddWithValue("@mreadid", moisturereadingid);
            com.ExecuteNonQuery();
            com.Dispose();
        }
    }
}