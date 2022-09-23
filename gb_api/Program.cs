using gb_api.Server.Application;
using gb_api.Server.Data.IncidentDB;
using gb_api.Server.Data.LocatieDB;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// DB init
builder.Services.AddDbContext<IncidentContext>(contextOptions => contextOptions.UseInMemoryDatabase("Incident"));
builder.Services.AddDbContext<LocatieContext>(contextOptions => contextOptions.UseInMemoryDatabase("Locatie"));
builder.Services.AddConnections();


// Dependency injection 
builder.Services.AddScoped<IIncidentRepository, IncidentRepository>();
builder.Services.AddScoped<IncidentService>();
builder.Services.AddScoped<LocatieService>();
builder.Services.AddScoped<ILocatieRepository, LocatieRepository>();


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
