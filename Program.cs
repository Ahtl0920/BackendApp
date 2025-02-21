using MauiApp1.Api.Data;
using Microsoft.EntityFrameworkCore;
using MauiApp1.Api.Services;

var builder = WebApplication.CreateBuilder(args);

// ?? Verificar que la cadena de conexi�n se est� leyendo correctamente
string connectionString = builder.Configuration.GetConnectionString("A3ERP") ?? "";
Console.WriteLine($"Cadena de conexi�n: {connectionString}");

// ?? Validar que la cadena de conexi�n no est� vac�a
if (string.IsNullOrWhiteSpace(connectionString))
{
    throw new InvalidOperationException(" Error: La cadena de conexi�n a la base de datos no est� configurada.");
}

// Add services to the container.
builder.Services.AddControllers();

// ?? Configurar Entity Framework con la cadena de conexi�n correcta
builder.Services.AddDbContext<AppDbContext>(options =>
{
    try
    {
        options.UseSqlServer(connectionString);
        Console.WriteLine(" Conectado correctamente a la base de datos.");
    }
    catch (Exception ex)
    {
        Console.WriteLine($" Error al conectar con SQL Server: {ex.Message}");
        throw;
    }
});

// ?? Inyecci�n de Dependencias
builder.Services.AddScoped<IAlbaranService, AlbaranService>();
builder.Services.AddScoped<ILineaAlbaranService, LineaAlbaranService>();
//builder.Services.AddScoped<IClienteService, ClienteService>();
//builder.Services.AddScoped<IMercanciaService, MercanciaService>();
//builder.Services.AddScoped<IRepartidorService, RepartidorService>();

// ?? Configuraci�n de CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll",
        policy => policy.AllowAnyOrigin()
                       .AllowAnyMethod()
                       .AllowAnyHeader());
});

// ?? Swagger / OpenAPI
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// ?? Configurar el pipeline de solicitudes HTTP
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// ?? Habilitar CORS antes de Authorization
app.UseCors("AllowAll");

app.UseAuthorization();

app.MapControllers();

app.Run();
