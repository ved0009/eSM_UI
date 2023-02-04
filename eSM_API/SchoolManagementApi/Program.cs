using SchoolManagement.Service.IService;
using SchoolManagement.Service.Repositry;
using SchoolManagement.Service.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// DI Services 
builder.Services.AddTransient<IDapperConnection, DapperConnection>();
builder.Services.AddTransient<ICommonAPI, SCommonAPI>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
