using MySql.Data.MySqlClient;
using System.Data;
namespace Grocery_Store_Online
{
    internal static class Program
    {
        private static MySqlConnection connection;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]

        static void Main()
        {
            EstablishConnection();
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());

            DismantleConnection();
        }
        private static void EstablishConnection()
        {
            string connection_string = "server=localhost;port=3306;database=userauth;user=root;password=password";
            connection = new MySqlConnection(connection_string);
            connection.Open();
        }
        private static void DismantleConnection()
        {
            connection.Close();
        }
        public static MySqlConnection getConnector()
        {
            return connection;
        }
    }
}