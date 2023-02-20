using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using SIVAG_BACKEND.Core.Context;
using SIVAG_BACKEND.Hubs;
using SIVAG_BACKEND.Interfaces;
using SIVAG_BACKEND.Interfaces.General;
using SIVAG_BACKEND.Interfaces.Public;
using SIVAG_BACKEND.Services;
using SIVAG_BACKEND.Services.Token;
using SIVAG_BACKEND.Utilities;
using System.Configuration;
using System.Text;

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
//

// JWT

var appSettings = builder.Configuration.GetSection("AppSettings"); // se obtiene el valor del appsetting.json mencionado
builder.Services.Configure<AppSettings>(appSettings); // lo obtenido del json se agrega a la clase
// Obtiene el secreto de la clas AppSetting y se almacena en una variable llave
var _appSettings = appSettings.Get<AppSettings>();


builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {
        options.SaveToken = true;
        options.TokenValidationParameters = new TokenValidationParameters
        {
            
            ValidateIssuerSigningKey = true,
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(_appSettings.Key)),
            ValidateIssuer = true,
            ValidIssuer = _appSettings.ValidIssuer,
            ValidateAudience = true,
            ValidAudience = _appSettings.ValidAudience,
            ValidateLifetime = true,
            ClockSkew = TimeSpan.Zero
        };
        options.RequireHttpsMetadata = true;
    });

//

// Interfaces
builder.Services.AddScoped<ILogin,TokenServices>();

builder.Services.AddScoped<IBodegas,BodegasServices>();
builder.Services.AddScoped<IDepartamentos,DepartamentosServices>();
builder.Services.AddScoped<IGeneros,GenerosServices>();
builder.Services.AddScoped<IFormas_Pago,Formas_PagoServices>();
builder.Services.AddScoped<IIdiomas,IdiomasServices>();
builder.Services.AddScoped<IMedios_Pago,Medios_PagoService>();
builder.Services.AddScoped<IMensajes, MensajesServices>();
builder.Services.AddScoped<IMonedas_Paises,Monedas_PaisesServices>();
builder.Services.AddScoped<IMonedas,MonedasServices>();
builder.Services.AddScoped<IMunicipios,MunicipiosServices>();
builder.Services.AddScoped<IPaises_Idiomas,Paises_IdiomasServices>();
builder.Services.AddScoped<IPaises,PaisesServices>();
builder.Services.AddScoped<ITipos_Documentos, Tipos_DocumentosServices>();
builder.Services.AddScoped<IUsuarios, UsuariosServices>();

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

app.UseAuthentication();
app.UseAuthorization();
// Hubs
app.MapHub<Hub_Generales>("/Generales");

app.MapControllers();

app.Run();
