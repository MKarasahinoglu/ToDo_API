using ToDo_Api.Data.ToDo;
using ToDo_Api.Data.User;
using ToDo_Api.Model.ToDo;

namespace ToDo_Api.Service.ToDo
{
	public interface IGetToDoItemByIdServiceRequest
	{
		Task<GetToDoItemDataModel> GetToDoItemById(int id);

    }

    public class GetToDoItemByIdServiceRequest: IGetToDoItemByIdServiceRequest
	{
		private readonly IGetToDoItemByIdDataRequest _getToDoItemByIdDataRequest;
        public GetToDoItemByIdServiceRequest(IGetToDoItemByIdDataRequest getToDoItemByIdDataRequest)
		{
			_getToDoItemByIdDataRequest= getToDoItemByIdDataRequest;
		}

		public async Task<GetToDoItemDataModel> GetToDoItemById(int id)
		{
			return await _getToDoItemByIdDataRequest.GetToDoItemById(id);
		}
	}
}
