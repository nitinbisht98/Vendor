using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;

namespace Vendor.Repository
{
    public class DbContext
    {

        private readonly MySqlConnection connection;
        public DbContext(IConfiguration configuration)
        {
            this.connection = new MySqlConnection(configuration.GetConnectionString("DBConnectionstring"));
        }

        public MySqlConnection GetConnection()
        {
            return connection;
        }

    }
}