using Microsoft.EntityFrameworkCore;
using Students_Galaxy_Infrastructure;
using Students_Galaxy_Infrastructure.Contexts;
using Students_Galaxy_Infrastructure.Repositories;
using Students_Galaxy_Infrastructure.UnitofWork;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
IConfiguration configuration = builder.Configuration;

builder.Services.AddDbContext<InventoryManagementContext>(options =>
options.UseSqlServer(configuration.GetConnectionString("StudentsGalaxyDb")));

builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<UnitOfWork>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
