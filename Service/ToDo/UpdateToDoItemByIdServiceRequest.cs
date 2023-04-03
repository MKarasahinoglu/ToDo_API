using ToDo_Api.Data.ToDo;
using ToDo_Api.Model.ToDo;
using ToDo_Api.Model.User;

namespace ToDo_Api.Service.ToDo
{
	public interface IUpdateToDoItemByIdServiceRequest
	{
		Task<bool> UpdateToDoItemById(InsertToDoItemDataModel model, int id);

    }

    public class UpdateToDoItemByIdServiceRequest: IUpdateToDoItemByIdServiceRequest
	{
		private readonly IUpdateToDoItemByIdDataRequest _updateToDoItemByIdDataRequest;
		public UpdateToDoItemByIdServiceRequest(IUpdateToDoItemByIdDataRequest updateToDoItemByIdDataRequest)
		{
			_updateToDoItemByIdDataRequest= updateToDoItemByIdDataRequest;
		}
		public async Task<bool> UpdateToDoItemById(InsertToDoItemDataModel model,int id)
		{
			return await _updateToDoItemByIdDataRequest.UpdateToDoItemById(model, id);
		}
	}
}
