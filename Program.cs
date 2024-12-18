using Microsoft.EntityFrameworkCore;
using TodoListAPI.Data;

var builder = WebApplication.CreateBuilder(args);
// Add database context
builder.Services.AddDbContext<TodoContext>(options => options.UseSqlite(builder.Configuration.GetConnectionString("TodoDatabase")));

 //Auto generated add add configuration .add database core

// Add services to the container.

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
