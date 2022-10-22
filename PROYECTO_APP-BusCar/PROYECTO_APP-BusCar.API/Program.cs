using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using PROYECTO_APP_BusCar.DOMAIN.Core.Interfaces;
using PROYECTO_APP_BusCar.DOMAIN.Infrastructure.Data;
using PROYECTO_APP_BusCar.DOMAIN.Infrastructure.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Get ConnectionString
var connectionString = builder.Configuration.GetConnectionString("DevConnection");
//Add dbContext
builder
    .Services
    .AddDbContext<DB_BUSContext>
    (options => options.UseSqlServer(connectionString));

builder.Services.AddTransient<IProgramacionRepository, ProgramacionRepository>();
builder.Services.AddTransient<IReservaRepository, ReservaRepository>();
builder.Services.AddTransient<ITripulacionRepository, TripulacionRepository>();
builder.Services.AddTransient<IUsuarioRepository, UsuarioRepository>();

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
