using ToDo_Api.Controllers;
using ToDo_Api.Data.ToDo;
using ToDo_Api.Data.User;
using ToDo_Api.Data.Utilities;
using ToDo_Api.Service.ToDo;
using ToDo_Api.Service.User;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Database Connection
var connectionString = "Data Source=DESKTOP-C5882F0\\SQLEXPRESS;Initial Catalog=ToDo;Integrated Security=True;Pooling=False";
builder.Services.AddSingleton<IProjectDatabaseConnection>(s=> new ProjectDatabaseConnection(connectionString));

// UserData 
builder.Services.AddSingleton<IGetUserByIdDataRequest, GetUserByIdDataRequest>();
builder.Services.AddSingleton<IGetAllUsersDataRequest, GetAllUsersDataRequest>();
builder.Services.AddSingleton<IInsertUserDataRequest, InsertUserDataRequest>();
builder.Services.AddSingleton<IDeleteUserByIdDataRequest, DeleteUserByIdDataRequest>();
builder.Services.AddSingleton<IUpdateUserByIdDataRequest,UpdateUserByIdDataRequest>();

// ToDoData
builder.Services.AddSingleton<IGetToDoItemByIdDataRequest, GetToDoItemByIdDataRequest>();
builder.Services.AddSingleton<IGetAllToDoItemsDataRequest, GetAllToDoItemsDataRequest>();
builder.Services.AddSingleton<IInsertToDoItemDataRequest, InsertToDoItemDataRequest>();
builder.Services.AddSingleton<IDeleteToDoItemByIdDataRequest,DeleteToDoItemByIdDataRequest>();
builder.Services.AddSingleton<IUpdateToDoItemByIdDataRequest,UpdateToDoItemByIdDataRequest>();

// UserService 
builder.Services.AddSingleton<IGetUserByIdServiceRequest, GetUserByIdServiceRequest>();
builder.Services.AddSingleton<IGetAllUsersServiceRequest, GetAllUsersServiceRequest>();
builder.Services.AddSingleton<IInsertUserServiceRequest, InsertUserServiceRequest>();
builder.Services.AddSingleton<IDeleteUserByIdServiceRequest, DeleteUserByIdServiceRequest>();
builder.Services.AddSingleton<IUpdateUserByIdServiceRequest,UpdateUserByIdServiceRequest>();

// ToDoService
builder.Services.AddSingleton<IGetToDoItemByIdServiceRequest, GetToDoItemByIdServiceRequest>();
builder.Services.AddSingleton<IGetAllToDoItemsServiceRequest, GetAllToDoItemsServiceRequest>();
builder.Services.AddSingleton<IInsertToDoItemServiceRequest, InsertToDoItemServiceRequest>();
builder.Services.AddSingleton<IDeleteToDoItemByIdServiceRequest,DeleteToDoItemByIdServiceRequest>();
builder.Services.AddSingleton<IUpdateToDoItemByIdServiceRequest,UpdateToDoItemByIdServiceRequest>();

// Controllers
builder.Services.AddSingleton<UserController>();
builder.Services.AddSingleton<ToDoController>();


var app = builder.Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
