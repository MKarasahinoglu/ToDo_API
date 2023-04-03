using Dapper;
using ToDo_Api.Data.Utilities;

namespace ToDo_Api.Data.User
{
	public interface IDeleteUserByIdDataRequest
	{
		Task<bool> DeleteUserById(int id);

    }
	public class DeleteUserByIdDataRequest: IDeleteUserByIdDataRequest
	{
		private readonly IProjectDatabaseConnection _connection;
		public DeleteUserByIdDataRequest(IProjectDatabaseConnection connection)
		{
			_connection= connection;

		}

		public async Task<bool> DeleteUserById(int id)
		{
			string query = $"Delete from [User] where Id={id}";
			var conn = _connection.GetConnection();
			var response= await conn.ExecuteAsync(query);
			return response > 0;
		}
	}
}
