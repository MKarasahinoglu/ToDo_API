using Microsoft.AspNetCore.Mvc;
using ToDo_Api.Model.ToDo;
using ToDo_Api.Service.ToDo;

namespace ToDo_Api.Controllers
{
	[Controller]
	[Route("api/[controller]")]
	public class ToDoController : Controller
	{
		private readonly IGetToDoItemByIdServiceRequest _getToDoItemByIdServiceRequest;
		private readonly IGetAllToDoItemsServiceRequest _getAllToDoItemsServiceRequest;
		private readonly IInsertToDoItemServiceRequest _insertToDoItemServiceRequest;
		private readonly IDeleteToDoItemByIdServiceRequest _deleteToDoItemByIdServiceRequest;
		private readonly IUpdateToDoItemByIdServiceRequest _updateToDoItemByIdServiceRequest;
        public ToDoController(
			IGetToDoItemByIdServiceRequest getToDoItemByIdServiceRequest,
			IGetAllToDoItemsServiceRequest getAllToDoItemsServiceRequest,
			IInsertToDoItemServiceRequest insertToDoItemServiceRequest,
			IDeleteToDoItemByIdServiceRequest deleteToDoItemByIdServiceRequest,
			IUpdateToDoItemByIdServiceRequest updateToDoItemByIdServiceRequest
			)
		{
			_getToDoItemByIdServiceRequest= getToDoItemByIdServiceRequest;
			_getAllToDoItemsServiceRequest= getAllToDoItemsServiceRequest;
			_insertToDoItemServiceRequest= insertToDoItemServiceRequest;
			_deleteToDoItemByIdServiceRequest = deleteToDoItemByIdServiceRequest;
			_updateToDoItemByIdServiceRequest= updateToDoItemByIdServiceRequest;
		}

		[HttpGet("{id}")]
		public async Task<GetToDoItemDataModel> GetToDoItemById(int id)
		{
			return await _getToDoItemByIdServiceRequest.GetToDoItemById(id);
		}
		[HttpGet("ToDoItems")]
		public async Task<List<GetToDoItemDataModel>> GetAllToDoItems()
		{
			return await _getAllToDoItemsServiceRequest.GetAllToDoItems();
		}
		[HttpPost("Insert")]
		public async Task<bool> InsertToDoItem(InsertToDoItemDataModel model)
		{
			return await _insertToDoItemServiceRequest.InsertToDoItem(model);
		}
		[HttpDelete("Delete")]
		public async Task<bool> DeleteToDoItemById(int id)
		{
			return await _deleteToDoItemByIdServiceRequest.DeleteToDoItemById(id);
		}
		[HttpPut("Update")]
		public async Task<bool> UpdateToDoItemById(InsertToDoItemDataModel model, int id)
		{
			return await _updateToDoItemByIdServiceRequest.UpdateToDoItemById(model, id);
		}
	}
}
