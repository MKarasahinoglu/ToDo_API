using ToDo_Api.Data.User;
using ToDo_Api.Model.User;

namespace ToDo_Api.Service.User
{
	public interface IInsertUserServiceRequest
	{
		Task<bool> InsertUser(InsertUserDataModel model);

    }

    public class InsertUserServiceRequest : IInsertUserServiceRequest
    {
		private readonly IInsertUserDataRequest _insertUserDataRequest;
        public InsertUserServiceRequest(IInsertUserDataRequest insertUserDataRequest)
		{
			_insertUserDataRequest= insertUserDataRequest;
		}

		public async Task<bool> InsertUser(InsertUserDataModel model)
		{
			return await _insertUserDataRequest.InsertUser(model);
		}
	}
}
