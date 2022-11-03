//1. Using para trabajar con Entity Framework
using Microsoft.EntityFrameworkCore;
using UniversityApiBackend.DataAccess; //acceso a nuestro contexto creado en carpta Data Acess

var builder = WebApplication.CreateBuilder(args); //configuraciones que usara nuestra app

//2. TODO: Conexión con la base de datos
//obtener conexión
const string CONNECTIONNAME = "UniversityDB";
var connectionString = builder.Configuration.GetConnectionString(CONNECTIONNAME);

//3. Establecer nuestro contexto 
builder.Services.AddDbContext<UniversityDBContext>(options => options.UseSqlServer(connectionString));


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

app.Run(); //ejecución de la app
