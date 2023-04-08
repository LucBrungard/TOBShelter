using System;
using System.Configuration;
using MySqlConnector;

namespace TOBShelter.Services
{
    internal class DBConnection
    {
        private static DBConnection _instance;
        internal readonly MySqlConnection Connection;

        private DBConnection()
        {
            this.Connection = DBConnection.Connect();
        }

        internal static DBConnection GetInstance()
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
