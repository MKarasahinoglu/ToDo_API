using Dapper;
using ToDo_Api.Data.Utilities;
using ToDo_Api.Model.ToDo;

namespace ToDo_Api.Data.ToDo
{
	public interface IGetToDoItemByIdDataRequest
	{
		Task<GetToDoItemDataModel> GetToDoItemById(int id);

    }

    public class GetToDoItemByIdDataRequest:IGetToDoItemByIdDataRequest
	{
		private readonly IProjectDatabaseConnection _connection;
		public GetToDoItemByIdDataRequest(IProjectDatabaseConnection connection)
		{
			_connection= connection;
		}

		public async Task<GetToDoItemDataModel> GetToDoItemById(int id)
		{
			var query = $"Select * from ToDo where Id={id}";
			var conn= _connection.GetConnection();
			var response= await conn.QueryFirstOrDefaultAsync<GetToDoItemDataModel>(query);
			return response;
		}
	}
}
