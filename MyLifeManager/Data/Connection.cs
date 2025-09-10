using MySql.Data.MySqlClient;

namespace MyLifeManager.Data
{
    public static class Connection
    {
        private static string connectionString = "server=localhost;port=3306;database=mylifemanager12;user=root;password=123456";
        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }
    }
}