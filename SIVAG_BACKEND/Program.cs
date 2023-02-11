using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using SIVAG_BACKEND.Core.Context;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
string Conexion = builder.Configuration.GetConnectionString("Conexion");
builder.Services.AddDbContext<SIVAG_Context>(options => 
    options.UseSqlServer(Conexion)
);



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
