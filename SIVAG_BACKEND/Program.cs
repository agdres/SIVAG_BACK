using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using SIVAG_BACKEND.Core.Context;
using SIVAG_BACKEND.Hubs;
using SIVAG_BACKEND.Interfaces;
using SIVAG_BACKEND.Interfaces.General;
using SIVAG_BACKEND.Services;

var builder = WebApplication.CreateBuilder(args);

// Usar SignalR
builder.Services.AddSignalR();
// Add services to the container.
string Conexion = builder.Configuration.GetConnectionString("Conexion");
builder.Services.AddDbContext<SIVAG_Context>(options => 
    options.UseSqlServer(Conexion),
    ServiceLifetime.Scoped
);

// cors
builder.Services.AddCors(options => options.AddPolicy("CorsPolicity", builder => builder.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod()));


// Interfaces
builder.Services.AddScoped<IBodegas,BodegasServices>();
builder.Services.AddScoped<IDepartamentos,DepartamentosServices>();
builder.Services.AddScoped<IFormas_Pago,Formas_PagoServices>();
builder.Services.AddScoped<IMedios_Pago,Medios_PagoService>();
builder.Services.AddScoped<IMensajes, MensajesServices>();
builder.Services.AddScoped<IMonedas,MonedasServices>();
builder.Services.AddScoped<IMunicipios,MunicipiosServices>();
builder.Services.AddScoped<IPaises,PaisesServices>();
builder.Services.AddScoped<ITipos_Documentos, Tipos_DocumentosServices>();

// Hubs
builder.Services.AddScoped<Hub_Generales>();

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
app.UseCors("CorsPolicity");

app.UseHttpsRedirection();

app.UseAuthorization();
// Hubs
app.MapHub<Hub_Generales>("/Generales");

app.MapControllers();

app.Run();
