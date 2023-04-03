using Dapper;
using ToDo_Api.Data.Utilities;
using ToDo_Api.Model.User;

namespace ToDo_Api.Data.User
{
	public interface IInsertUserDataRequest
	{
		Task<bool> InsertUser(InsertUserDataModel model);

    }

    public class InsertUserDataRequest : IInsertUserDataRequest
    {
		private readonly IProjectDatabaseConnection _dbConnection;
		public InsertUserDataRequest(IProjectDatabaseConnection dbConnection)
		{
			_dbConnection= dbConnection;
		}

		public async Task<bool> InsertUser(InsertUserDataModel model)
		{
			var query = $"INSERT INTO [User](Id, UserName, Password) VALUES(@Id, @UserName, @Password)";

			var conn = _dbConnection.GetConnection();

			var response = await conn.ExecuteAsync(query, model) ;

			return response > 0;
		}
	}
}
