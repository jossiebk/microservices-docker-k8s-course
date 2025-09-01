using ProductService.Repositorios;
using ProductService.Servicios;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<RepositorioProductos>();
builder.Services.AddScoped<ServicioProductos>();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
