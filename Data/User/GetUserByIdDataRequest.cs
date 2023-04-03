using Dapper;
using ToDo_Api.Data.Utilities;
using ToDo_Api.Model.User;

namespace ToDo_Api.Data.User
{
    public interface IGetUserByIdDataRequest
	{
		Task<GetUserDataModel> GetUserById(int id);

    }
	public class GetUserByIdDataRequest: IGetUserByIdDataRequest
	{
		private readonly IProjectDatabaseConnection _connection;
		public GetUserByIdDataRequest(IProjectDatabaseConnection connection) 
		{ 
			_connection= connection;
		}
		
		public async Task<GetUserDataModel> GetUserById(int id)
		{
			string query = $"Select * From [User] Where Id={id}";
			var conn = _connection.GetConnection();
			var response = await conn.QueryFirstOrDefaultAsync<GetUserDataModel>(query);
			return response;
		}
	}
}
