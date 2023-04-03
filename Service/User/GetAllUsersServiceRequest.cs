using ToDo_Api.Data.User;
using ToDo_Api.Model.User;

namespace ToDo_Api.Service.User
{
	public interface IGetAllUsersServiceRequest
	{
		Task<List<GetUserDataModel>> GetAllUsers();
    }

    public class GetAllUsersServiceRequest : IGetAllUsersServiceRequest
    {
		private readonly IGetAllUsersDataRequest _getAllUsersDataRequest;
		public GetAllUsersServiceRequest(IGetAllUsersDataRequest getAllUsersDataRequest)
		{
			_getAllUsersDataRequest= getAllUsersDataRequest;
		}

		public async Task<List<GetUserDataModel>> GetAllUsers()
		{
			return await _getAllUsersDataRequest.GetAllUsers();
		}
	}
}
