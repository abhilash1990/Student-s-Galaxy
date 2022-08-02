using Microsoft.EntityFrameworkCore;
using Students_Galaxy_Application;
using Students_Galaxy_Domain;
using Students_Galaxy_Infrastructure.Contexts;
using Students_Galaxy_Infrastructure.UnitofWork;

var builder = WebApplication.CreateBuilder(args);
var services = builder.Services;
var configuration = builder.Configuration;
var env = builder.Environment;

// Add services to the container.

services.AddDbContext<InventoryManagementContext>(options =>
options.UseSqlServer(configuration.GetConnectionString("StudentsGalaxyDb")));

services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
services.AddEndpointsApiExplorer();
services.AddSwaggerGen();

services.AddScoped<UnitOfWork>();
services.AddTransient<IProductHandler, ProductHandler>();
services.AddTransient<IProductManagement, ProductManagement>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseRouting();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();
