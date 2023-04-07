using System;
using MySqlConnector;

namespace TOBShelter.Services
{
    internal static class DBConnection
    {
        internal static void Connect()
        {
            // set these values correctly for your database server
            var builder = new MySqlConnectionStringBuilder
            {
                Server = "localhost",
                UserID = "root",
                Password = "(Patapif1012)",
                Database = "nation",
            };

            // open a connection asynchronously
            var connection = new MySqlConnection(builder.ConnectionString);
            connection.Open();

            // create a DB command and set the SQL statement with parameters
            var command = connection.CreateCommand();
            command.CommandText = @"SELECT * FROM continents;";

            // execute the command and read the results
            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    try
                    {
                        Console.Write($"{reader.GetString(i)} ");
                    } catch (InvalidCastException e)
                    {
                        Console.Write($"{reader.GetInt32(i)} ");
                    }
                }
                Console.WriteLine();
            }

            /*const string server = "127.0.0.1";
            const string uid = "root";
            const string pwd = "(Patapif1012)";
            const string database = "nation";
            const int port = 3306;

            string myConnectionString = $"server={server};uid={uid};pwd={pwd};database={database};port={port}";
            Console.WriteLine(myConnectionString);
            MySqlConnection conn = new MySqlConnection(myConnectionString);
            Console.WriteLine(conn.ConnectionString);
            Console.WriteLine(conn.Ping());
            try
            {
                conn.Open();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
*/
            /*try
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder
                {
                    DataSource = "localhost",
                    UserID = "root",
                    Password = "(Patapif1012)",
                    InitialCatalog = "nation"
                };

                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {
                    Console.WriteLine("\nQuery data example:");
                    Console.WriteLine("=========================================\n");

                    connection.Open();

                    String sql = "SELECT * FROM continents";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                for (int i = 0; i < reader.FieldCount; i++)
                                {
                                    Console.Write($"{reader.GetString(i)} ");
                                }
                                Console.WriteLine();
                            }
                        }
                    }
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
            }
            Console.WriteLine("\nDone. Press enter.");
            Console.ReadLine();*/
        }
    }
}
