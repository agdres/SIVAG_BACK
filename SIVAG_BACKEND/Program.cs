using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using SIVAG_BACKEND.Core.Context;
using SIVAG_BACKEND.Interfaces;
using SIVAG_BACKEND.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
string Conexion = builder.Configuration.GetConnectionString("Conexion");
builder.Services.AddDbContext<SIVAG_Context>(options => 
    options.UseSqlServer(Conexion),
    ServiceLifetime.Scoped
);


// Interfaces
builder.Services.AddScoped<ITipos_Documentos, Tipos_DocumentosServices>();


//
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

app.Run();
