using MauiApp1.Api.Data;
using Microsoft.EntityFrameworkCore;
using MauiApp1.Api.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();


builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));


builder.Services.AddScoped<AlbaranService>();
builder.Services.AddScoped<LineaAlbaranService>();

//new
builder.Services.AddScoped<IAlbaranService, AlbaranService>();
builder.Services.AddScoped<ILineaAlbaranService, LineaAlbaranService>();
builder.Services.AddScoped<IClienteService, ClienteService>();
builder.Services.AddScoped<IMercanciaService, MercanciaService>();
builder.Services.AddScoped<IRepartidorService, RepartidorService>();





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

app.Run();  
