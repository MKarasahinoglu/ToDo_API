﻿namespace ToDo_Api.Model.ToDo
{
	public class GetToDoItemDataModel
	{
		public int Id { get; set; }
		public string ?Title { get; set; }
		public bool ?IsDone { get; set; }
		public int UserId { get; set; }
	}
}
