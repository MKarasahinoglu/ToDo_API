using Dapper;
using ToDo_Api.Data.Utilities;

namespace ToDo_Api.Data.ToDo
{
	public interface IDeleteToDoItemByIdDataRequest
	{
		Task<bool> DeleteToDoItemById(int id);

    }

    public class DeleteToDoItemByIdDataRequest: IDeleteToDoItemByIdDataRequest
	{
		private readonly IProjectDatabaseConnection	_connection;
		public DeleteToDoItemByIdDataRequest(IProjectDatabaseConnection connection)
		{
			_connection = connection;
		}

		public async Task<bool> DeleteToDoItemById(int id)
		{
			var query = $"Delete from ToDo where Id={id}";
			var conn=_connection.GetConnection();
			var response= await conn.ExecuteAsync(query);
			return response > 0;
		}
	}
}
