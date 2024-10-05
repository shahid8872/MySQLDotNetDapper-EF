using MySqlConnector;
using System.Data;
using Microsoft.Data.SqlClient;
namespace DadCommerce.Data
{
    public class DapperContext
    {
        private readonly IConfiguration _configuration;
        private readonly string _connectionString;

        public DapperContext(IConfiguration configuration)
        {
            _configuration = configuration;
            _connectionString = _configuration.GetConnectionString("MySqlConn");
        }

        public IDbConnection CreateConnection()
            => new MySqlConnection(_connectionString);
    }
}
