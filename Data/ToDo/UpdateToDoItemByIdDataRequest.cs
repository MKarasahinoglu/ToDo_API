using Dapper;
using ToDo_Api.Data.Utilities;
using ToDo_Api.Model.ToDo;

namespace ToDo_Api.Data.ToDo
{
	public interface IUpdateToDoItemByIdDataRequest
	{
		Task<bool> UpdateToDoItemById(InsertToDoItemDataModel model, int id);

    }

    public class UpdateToDoItemByIdDataRequest:IUpdateToDoItemByIdDataRequest
	{
		private readonly IProjectDatabaseConnection _connection;
		public UpdateToDoItemByIdDataRequest(IProjectDatabaseConnection connection)
		{
			_connection = connection;
		}

		public async Task<bool> UpdateToDoItemById(InsertToDoItemDataModel model, int id)
		{
			var query = $"update ToDo set Title=@Title, IsDone=@IsDone, UserId=@UserId where Id={id}";
			var conn=_connection.GetConnection();
			var response= await conn.ExecuteAsync(query,model);
			return response > 0;
		}
	}
}
