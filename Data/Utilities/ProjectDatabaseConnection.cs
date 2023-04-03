using System.Data;
using System.Data.SqlClient;

namespace ToDo_Api.Data.Utilities
{
    public interface IProjectDatabaseConnection
    {
        IDbConnection GetConnection();
    }
    public class ProjectDatabaseConnection : IProjectDatabaseConnection
    {
        private readonly string _connectionString;
        public ProjectDatabaseConnection(string connectionString)
        {
            _connectionString = connectionString;
        }
        public IDbConnection GetConnection()
        {
            return new SqlConnection(_connectionString);
        }
    }
}
