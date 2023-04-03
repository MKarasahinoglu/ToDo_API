using Dapper;
using ToDo_Api.Data.Utilities;
using ToDo_Api.Model.User;

namespace ToDo_Api.Data.User
{
	public interface IUpdateUserByIdDataRequest
	{
		Task<bool> UpdateUserById(InsertUserDataModel model, int id);

    }
	public class UpdateUserByIdDataRequest: IUpdateUserByIdDataRequest
	{
		private readonly IProjectDatabaseConnection _connection;
		public UpdateUserByIdDataRequest(IProjectDatabaseConnection connection)
		{
			_connection= connection;
		}

		public async Task<bool> UpdateUserById(InsertUserDataModel model, int id)
		{
			var query = $"update [User] set Id={id}, UserName=@UserName, Password=@Password where Id={id}";
			var conn = _connection.GetConnection();
			var response = await conn.ExecuteAsync(query, model);
			return response > 0;
		}
	}
}
