using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;

namespace Webhotel.Services
{
    public class DatabaseConnection
    {
        private readonly string _connectionString;

        public DatabaseConnection(IConfiguration configuration)
        {
            // Récupérer la chaîne de connexion depuis appsettings.json
            _connectionString = configuration.GetConnectionString("DefaultConnection");
        }

        // Retourner une nouvelle connexion MySQL
        public MySqlConnection GetConnection()
        {
            return new MySqlConnection(_connectionString);
        }
    }
}
