using Dapper;
using ToDo_Api.Data.Utilities;
using ToDo_Api.Model.User;

namespace ToDo_Api.Data.User
{
	public interface IGetAllUsersDataRequest
	{
		Task<List<GetUserDataModel>> GetAllUsers();

    }

    public class GetAllUsersDataRequest : IGetAllUsersDataRequest
    {
		private readonly IProjectDatabaseConnection _dbConnection;

		public GetAllUsersDataRequest(IProjectDatabaseConnection dbConnection)
		{
			_dbConnection = dbConnection;
		}

		public async Task<List<GetUserDataModel>> GetAllUsers()
		{
			var query = "SELECT * FROM [User]";

			var conn = _dbConnection.GetConnection();

			var response = await conn.QueryAsync<GetUserDataModel>(query);

			return response.ToList();
		}
	}
}
