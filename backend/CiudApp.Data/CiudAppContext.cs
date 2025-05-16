using CiudApp.Models;
using Microsoft.EntityFrameworkCore;
namespace CiudApp.Data;

public class CiudAppContext : DbContext
{

    public CiudAppContext(DbContextOptions<CiudAppContext> options) : base(options)
    {
    }

    public DbSet<Ciudad> Ciudades { get; set; }
    public DbSet<Resena> Resenas { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Ciudad>().HasData(
                new Ciudad
                {
                    Id = 1,
                    Nombre = "Zaragoza",
                    Pais = "España",
                    Poblacion = 700000,
                    SoftDelete = false,
                    FechaRegistro = DateTime.Now,
                },
                new Ciudad
                {
                    Id = 2,
                    Nombre = "Londres",
                    Pais = "Inglaterra",
                    Poblacion = 10000000,
                    SoftDelete = false,
                    FechaRegistro = DateTime.Now,
                }
            );
    }
}
