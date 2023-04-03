using ToDo_Api.Data.ToDo;

namespace ToDo_Api.Service.ToDo
{
	public interface IDeleteToDoItemByIdServiceRequest
	{
		Task<bool> DeleteToDoItemById(int id);

    }

    public class DeleteToDoItemByIdServiceRequest: IDeleteToDoItemByIdServiceRequest
	{
		private readonly IDeleteToDoItemByIdDataRequest _deleteToDoItemByIdDataRequest;

        public DeleteToDoItemByIdServiceRequest(IDeleteToDoItemByIdDataRequest deleteToDoItemByIdDataRequest)
		{
			_deleteToDoItemByIdDataRequest= deleteToDoItemByIdDataRequest;
		}
		public async Task<bool> DeleteToDoItemById(int id)
		{
			return await _deleteToDoItemByIdDataRequest.DeleteToDoItemById(id);
		}
	}
}
