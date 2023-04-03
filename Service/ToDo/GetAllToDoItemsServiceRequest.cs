using ToDo_Api.Data.ToDo;
using ToDo_Api.Model.ToDo;
using ToDo_Api.Service.User;

namespace ToDo_Api.Service.ToDo
{
	public interface IGetAllToDoItemsServiceRequest
	{
		Task<List<GetToDoItemDataModel>> GetAllToDoItems();

    }

    public class GetAllToDoItemsServiceRequest:IGetAllToDoItemsServiceRequest
	{
		private readonly IGetAllToDoItemsDataRequest _getAllToDoItemsDataRequest;
		public GetAllToDoItemsServiceRequest(IGetAllToDoItemsDataRequest getAllToDoItemsDataRequest)
		{
			_getAllToDoItemsDataRequest = getAllToDoItemsDataRequest;
		}
		public async Task<List<GetToDoItemDataModel>> GetAllToDoItems()
		{
			return await _getAllToDoItemsDataRequest.GetAllToDoItems();
		}
	}
}
