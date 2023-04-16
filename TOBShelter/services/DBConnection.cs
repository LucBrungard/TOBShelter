using System;
using System.Configuration;
using MySqlConnector;

namespace TOBShelter.Services
{
    public class DBConnection
    {
        private static DBConnection _instance;
        public readonly MySqlConnection Connection;

        private DBConnection()
        {
            this.Connection = DBConnection.Connect();
        }

        public static DBConnection GetInstance()
        {
            if (_instance == null)
                _instance = new DBConnection();

            return _instance;
        }
        private static MySqlConnection Connect()
        {
            var connection = new MySqlConnection(
                ConfigurationManager.ConnectionStrings["DataBaseConnection"].ConnectionString);
            connection.Open();

            return connection;
        }
    }
}
