using AndroidAPI.Data;
using AndroidAPI.Interface;
using AndroidAPI.Models;
using AndroidAPI.Models.Responce;
using AndroidAPI.Repository;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IPizzaData, PizzaDATA>();
builder.Services.AddScoped<ITechData, TechDATA>();
builder.Services.AddSingleton<IUserFoodRepository, UserFoodRepository>();
builder.Services.AddSingleton<IUserTechRepository, UserTechRepository>();

var app = builder.Build();

app.UseHttpsRedirection();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();