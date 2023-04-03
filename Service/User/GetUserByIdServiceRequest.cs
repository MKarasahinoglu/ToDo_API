using ToDo_Api.Data.User;
using ToDo_Api.Model.User;

namespace ToDo_Api.Service.User
{
    public interface IGetUserByIdServiceRequest
    {
        Task<GetUserDataModel> GetUserById(int id);
    }
    public class GetUserByIdServiceRequest: IGetUserByIdServiceRequest
    {
        private readonly IGetUserByIdDataRequest _getUserByIdDataRequest;
        public GetUserByIdServiceRequest(IGetUserByIdDataRequest getUserByIdDataRequest)
        {
            _getUserByIdDataRequest= getUserByIdDataRequest;
        }

        public async Task<GetUserDataModel> GetUserById(int id)
        {
            return await _getUserByIdDataRequest.GetUserById(id);
        }
    }
}
