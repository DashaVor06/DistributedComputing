using BusinessLogic.DTO.Request;
using BusinessLogic.DTO.Response;
using BusinessLogic.Profiles;
using BusinessLogic.Servicies;
using DataAccess.Models;
using DataAccess.Repositories;
using Infrastructure.RepositoriesImplementation;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddSingleton<IRepository<Creator>, InMemoryRepository<Creator>>();
builder.Services.AddScoped<IBaseService<CreatorRequestTo, CreatorResponseTo>, CreatorService>();

builder.Services.AddAutoMapper(typeof(UserProfile));

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
