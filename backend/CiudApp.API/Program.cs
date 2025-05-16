using CiudApp.Business;
using CiudApp.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddScoped<ICiudadService, CiudadService>();
builder.Services.AddScoped<IResenaService, ResenaService>();

// Aqui el tema de la BBDD
var connectionString = builder.Configuration.GetConnectionString("ServerDB_localhost");

builder.Services.AddDbContext<CiudAppContext>(options =>
{
    options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
});


builder.Services.AddScoped<ICiudadRepository, CiudadRepository>();
builder.Services.AddScoped<IResenaRepository, ResenaRepository>();
// Add Controllers
builder.Services.AddControllers();

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();


// Migraciones

using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<CiudAppContext>();
    db.Database.Migrate();
}

// Configure the HTTP request pipeline.
// if (app.Environment.IsDevelopment())
// {
app.UseSwagger();
app.UseSwaggerUI();
// }

app.UseHttpsRedirection();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();

