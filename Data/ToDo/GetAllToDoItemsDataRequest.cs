using Dapper;
using ToDo_Api.Data.Utilities;
using ToDo_Api.Model.ToDo;

namespace ToDo_Api.Data.ToDo
{
	public interface IGetAllToDoItemsDataRequest
	{
		Task<List<GetToDoItemDataModel>> GetAllToDoItems();

    }

    public class GetAllToDoItemsDataRequest:IGetAllToDoItemsDataRequest
	{
		private readonly IProjectDatabaseConnection _connection;
		public GetAllToDoItemsDataRequest(IProjectDatabaseConnection connection)
		{
			_connection = connection;
		}

		public async Task<List<GetToDoItemDataModel>> GetAllToDoItems()
		{
			var query = "select * from ToDo";
			var conn=_connection.GetConnection();
			var response = await conn.QueryAsync<GetToDoItemDataModel>(query);
			return response.ToList();
		}
	}
}
