using Dapper;
using ToDo_Api.Data.Utilities;
using ToDo_Api.Model.ToDo;

namespace ToDo_Api.Data.ToDo
{
	public interface IInsertToDoItemDataRequest
	{
		Task<bool> InsertToDoItem(InsertToDoItemDataModel model);

    }

    public class InsertToDoItemDataRequest: IInsertToDoItemDataRequest
	{
		private readonly IProjectDatabaseConnection _connection;
		public InsertToDoItemDataRequest(IProjectDatabaseConnection connection)
		{
			_connection	= connection;
		}

		public async Task<bool> InsertToDoItem(InsertToDoItemDataModel model)
		{
			var query = "Insert into ToDo (Title,IsDone,UserId) values(@Title,@IsDone,@UserId) ";
			var conn= _connection.GetConnection();
			var response= await conn.ExecuteAsync(query,model);
			return response > 0;
		}
	}
}
