using Microsoft.EntityFrameworkCore;
using PROYECTO_APP_BusCar.DOMAIN.Core.Interfaces;
using PROYECTO_APP_BusCar.DOMAIN.Infrastructure.Data;
using PROYECTO_APP_BusCar.DOMAIN.Infrastructure.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

var connectionString = builder
    .Configuration
    .GetConnectionString("HDevConnection");
builder
    .Services
    .AddDbContext<DB_BUSContext>
    (Options => Options.UseSqlServer(connectionString));


builder.Services.AddTransient<IOrigenRepository, OrigenRepository>();
builder.Services.AddTransient<IPagos_PaypalRepository, Pagos_PaypalRepository>();
builder.Services.AddTransient<IPersonalRepository, PersonalRepository>();
builder.Services.AddTransient<IPrecioRepository, PrecioRepository>();



var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
