using colloquio.Models;
using colloquio.Service;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

//var connectionstring = builder.Configuration.GetConnectionString("Connectionstring");

// Costruisci la configurazione leggendo il file appsettings.json
var configuration = new ConfigurationBuilder()
    .SetBasePath(AppContext.BaseDirectory)
    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
    .Build();

// Leggi il valore della chiave Connectionstring
string connectionstring = configuration.GetValue<string>("Connectionstring");
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<GestionematerialitaContext>(opt => opt.UseSqlServer(connectionstring));
builder.Services.AddScoped<IBustaOperatore, BustaOperatoreService>();
 
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
