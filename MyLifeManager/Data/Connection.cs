using MySql.Data.MySqlClient;

namespace MyLifeManager.Data
{
    public class Connection
    {
        private string connectionString = "server=localhost;port=3306;database=mylifemanager;user=root;password=";

        public MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }
    }
}
