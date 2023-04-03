using ToDo_Api.Data.User;
using ToDo_Api.Model.User;

namespace ToDo_Api.Service.User
{
	public interface IUpdateUserByIdServiceRequest
	{
		Task<bool> UpdateUserById(InsertUserDataModel model, int id);

    }
	public class UpdateUserByIdServiceRequest:IUpdateUserByIdServiceRequest
	{
		private readonly IUpdateUserByIdDataRequest _updateUserByIdDataRequest;

        public UpdateUserByIdServiceRequest(IUpdateUserByIdDataRequest updateUserByIdDataRequest)
		{
			_updateUserByIdDataRequest= updateUserByIdDataRequest;

		}

		public async Task<bool> UpdateUserById(InsertUserDataModel model,int id)
		{
			return await _updateUserByIdDataRequest.UpdateUserById(model,id);
			
		}
	}
}
