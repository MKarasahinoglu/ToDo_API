using Microsoft.AspNetCore.Mvc;
using ToDo_Api.Model.User;
using ToDo_Api.Service.User;

namespace ToDo_Api.Controllers
{
	[Controller]
	[Route("api/[controller]")]
	public class UserController:Controller
	{
		private readonly IGetUserByIdServiceRequest _getUserByIdServiceRequest;
		private readonly IGetAllUsersServiceRequest _getAllUsersServiceRequest;
        private readonly IInsertUserServiceRequest _insertUserServiceRequest;
		private readonly IDeleteUserByIdServiceRequest _deleteUserByIdServiceRequest;
		private readonly IUpdateUserByIdServiceRequest _updateUserByIdServiceRequest;

        public UserController(
			IGetUserByIdServiceRequest getUserByIdServiceRequest, 
			IGetAllUsersServiceRequest getAllUsersServiceRequest,
			IInsertUserServiceRequest insertUserServiceRequest,
			IDeleteUserByIdServiceRequest deleteUserByIdServiceRequest,
			IUpdateUserByIdServiceRequest updateUserByIdServiceRequest
			)
		{
			
			_getUserByIdServiceRequest = getUserByIdServiceRequest;
			_getAllUsersServiceRequest = getAllUsersServiceRequest;
			_insertUserServiceRequest  = insertUserServiceRequest;
			_deleteUserByIdServiceRequest= deleteUserByIdServiceRequest;
			_updateUserByIdServiceRequest = updateUserByIdServiceRequest;
		}

		[HttpGet("{id}")]
		public async Task<GetUserDataModel> GetUserById(int id)
		{
			return await _getUserByIdServiceRequest.GetUserById(id);

		}

		[HttpGet("users")]
		public async Task<List<GetUserDataModel>> GetAllUsers()
		{
			return await _getAllUsersServiceRequest.GetAllUsers();
		}

		[HttpPost("insert")]
		public async Task<bool> InsertUser([FromBody]InsertUserDataModel model)
		{
			return await _insertUserServiceRequest.InsertUser(model);
		}

		[HttpDelete("delete")]
		public async Task<bool> DeleteUserById(int id)
		{
			return await _deleteUserByIdServiceRequest.DeleteUserById(id);
		}

		[HttpPut("update")]
		public async Task<bool> UpdateUserById(InsertUserDataModel model,int id)
		{
			return await _updateUserByIdServiceRequest.UpdateUserById(model,id);
		}
	}
}
