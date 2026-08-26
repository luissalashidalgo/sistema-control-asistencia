using ControlAsistencia.Api.Interfaces;
using ControlAsistencia.Api.Repositories;

var builder = WebApplication.CreateBuilder(args);

#region Área de Servicios

builder.Services.AddControllers();
builder.Services.AddSingleton<IRepositorioEmpleados, RepositorioEmpleados>(); //Como maneja una lista en memoria, se utiliza Singleton para que la lista se mantenga mientras la aplicación esté corriendo.

#endregion

var app = builder.Build();

#region Área de Middleware

app.MapControllers();

app.MapGet("/api/ping", () => new { Message = "Ping de prueba" });

app.Run();

#endregion
