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
            },
            new Ciudad
            {
                Id = 3,
                Nombre = "Sevilla",
                Pais = "España",
                Poblacion = 688711,
                SoftDelete = false,
                FechaRegistro = DateTime.Now,
            },
            new Ciudad
            {
                Id = 4,
                Nombre = "Buenos Aires",
                Pais = "Argentina",
                Poblacion = 2890000,
                SoftDelete = false,
                FechaRegistro = DateTime.Now,
            },
            new Ciudad
            {
                Id = 5,
                Nombre = "Lisboa",
                Pais = "Portugal",
                Poblacion = 504718,
                SoftDelete = false,
                FechaRegistro = DateTime.Now,
            },
            new Ciudad
            {
                Id = 6,
                Nombre = "Venecia",
                Pais = "Italia",
                Poblacion = 261905,
                SoftDelete = false,
                FechaRegistro = DateTime.Now,
            },
            new Ciudad
            {
                Id = 7,
                Nombre = "Barcelona",
                Pais = "España",
                Poblacion = 1620000,
                SoftDelete = false,
                FechaRegistro = DateTime.Now,
            },
            new Ciudad
            {
                Id = 8,
                Nombre = "París",
                Pais = "Francia",
                Poblacion = 2148000,
                SoftDelete = false,
                FechaRegistro = DateTime.Now,
            },
            new Ciudad
            {
                Id = 9,
                Nombre = "Tokio",
                Pais = "Japón",
                Poblacion = 13960000,
                SoftDelete = false,
                FechaRegistro = DateTime.Now,
            }
        );

        modelBuilder.Entity<Resena>().HasData(
            new Resena
            {
                Id = 1,
                CiudadId = 1,
                Titulo = "Una experiencia maravillosa",
                Descripcion = "El transporte fue eficiente y fácil de usar.",
                Calificacion = 5,
                Recomendacion = true,
                Fecha = DateTime.Now
            },
            new Resena
            {
                Id = 2,
                CiudadId = 1,
                Titulo = "Volvería sin dudarlo",
                Descripcion = "Tuve una experiencia muy positiva, lo recomiendo.",
                Calificacion = 4,
                Recomendacion = true,
                Fecha = DateTime.Now
            },
            new Resena
            {
                Id = 3,
                CiudadId = 1,
                Titulo = "Inolvidable",
                Descripcion = "Tuve una experiencia muy positiva, lo recomiendo.",
                Calificacion = 5,
                Recomendacion = true,
                Fecha = DateTime.Now
            },
            new Resena
            {
                Id = 4,
                CiudadId = 1,
                Titulo = "Mal clima",
                Descripcion = "Todo fue extremadamente caro para lo que ofrecía.",
                Calificacion = 1,
                Recomendacion = false,
                Fecha = DateTime.Now
            },
            new Resena
            {
                Id = 5,
                CiudadId = 1,
                Titulo = "Experiencia regular",
                Descripcion = "Todo fue extremadamente caro para lo que ofrecía.",
                Calificacion = 2,
                Recomendacion = false,
                Fecha = DateTime.Now
            },
            new Resena
            {
                Id = 6,
                CiudadId = 1,
                Titulo = "Muy sucia",
                Descripcion = "Esperaba más, me decepcionó bastante.",
                Calificacion = 2,
                Recomendacion = false,
                Fecha = DateTime.Now
            },
            new Resena
            {
                Id = 7,
                CiudadId = 2,
                Titulo = "Inolvidable",
                Descripcion = "Mucho que ver y disfrutar, fue un gran viaje.",
                Calificacion = 5,
                Recomendacion = true,
                Fecha = DateTime.Now
            },
            new Resena
            {
                Id = 8,
                CiudadId = 2,
                Titulo = "Encantadora",
                Descripcion = "Mucho que ver y disfrutar, fue un gran viaje.",
                Calificacion = 5,
                Recomendacion = true,
                Fecha = DateTime.Now
            },
            new Resena
            {
                Id = 9,
                CiudadId = 2,
                Titulo = "Inolvidable",
                Descripcion = "La ciudad es hermosa y está llena de historia.",
                Calificacion = 4,
                Recomendacion = true,
                Fecha = DateTime.Now
            },
            new Resena
            {
                Id = 10,
                CiudadId = 2,
                Titulo = "Demasiado caro",
                Descripcion = "Poca oferta cultural y muchas obras en las calles.",
                Calificacion = 3,
                Recomendacion = false,
                Fecha = DateTime.Now
            },
            new Resena
            {
                Id = 11,
                CiudadId = 2,
                Titulo = "Demasiado caro",
                Descripcion = "Esperaba más, me decepcionó bastante.",
                Calificacion = 2,
                Recomendacion = false,
                Fecha = DateTime.Now
            },
            new Resena
            {
                Id = 12,
                CiudadId = 2,
                Titulo = "No volvería",
                Descripcion = "Todo fue extremadamente caro para lo que ofrecía.",
                Calificacion = 1,
                Recomendacion = false,
                Fecha = DateTime.Now
            },
            new Resena
            {
                Id = 13,
                CiudadId = 3,
                Titulo = "Una experiencia maravillosa",
                Descripcion = "Mucho que ver y disfrutar, fue un gran viaje.",
                Calificacion = 4,
                Recomendacion = true,
                Fecha = DateTime.Now
            },
            new Resena
            {
                Id = 14,
                CiudadId = 3,
                Titulo = "Volvería sin dudarlo",
                Descripcion = "Perfecta para unas vacaciones tranquilas y culturales.",
                Calificacion = 4,
                Recomendacion = true,
                Fecha = DateTime.Now
            },
            new Resena
            {
                Id = 15,
                CiudadId = 3,
                Titulo = "Inolvidable",
                Descripcion = "Las personas fueron muy amables y la comida deliciosa.",
                Calificacion = 5,
                Recomendacion = true,
                Fecha = DateTime.Now
            },
            new Resena
            {
                Id = 16,
                CiudadId = 3,
                Titulo = "Decepcionante",
                Descripcion = "Tuve muchos problemas con el transporte.",
                Calificacion = 3,
                Recomendacion = false,
                Fecha = DateTime.Now
            },
            new Resena
            {
                Id = 17,
                CiudadId = 3,
                Titulo = "Experiencia regular",
                Descripcion = "Todo fue extremadamente caro para lo que ofrecía.",
                Calificacion = 3,
                Recomendacion = false,
                Fecha = DateTime.Now
            },
            new Resena
            {
                Id = 18,
                CiudadId = 3,
                Titulo = "Demasiado caro",
                Descripcion = "No me sentí seguro durante mi estancia.",
                Calificacion = 2,
                Recomendacion = false,
                Fecha = DateTime.Now
            },
            new Resena
            {
                Id = 19,
                CiudadId = 4,
                Titulo = "Muy recomendable",
                Descripcion = "Mucho que ver y disfrutar, fue un gran viaje.",
                Calificacion = 5,
                Recomendacion = true,
                Fecha = DateTime.Now
            },
            new Resena
            {
                Id = 20,
                CiudadId = 4,
                Titulo = "Me encantó",
                Descripcion = "El transporte fue eficiente y fácil de usar.",
                Calificacion = 4,
                Recomendacion = true,
                Fecha = DateTime.Now
            },
            new Resena
            {
                Id = 21,
                CiudadId = 4,
                Titulo = "Volvería sin dudarlo",
                Descripcion = "El transporte fue eficiente y fácil de usar.",
                Calificacion = 4,
                Recomendacion = true,
                Fecha = DateTime.Now
            },
            new Resena
            {
                Id = 22,
                CiudadId = 4,
                Titulo = "Mal clima",
                Descripcion = "No me sentí seguro durante mi estancia.",
                Calificacion = 1,
                Recomendacion = false,
                Fecha = DateTime.Now
            },
            new Resena
            {
                Id = 23,
                CiudadId = 4,
                Titulo = "Muy sucia",
                Descripcion = "Esperaba más, me decepcionó bastante.",
                Calificacion = 2,
                Recomendacion = false,
                Fecha = DateTime.Now
            },
            new Resena
            {
                Id = 24,
                CiudadId = 4,
                Titulo = "No volvería",
                Descripcion = "Poca oferta cultural y muchas obras en las calles.",
                Calificacion = 3,
                Recomendacion = false,
                Fecha = DateTime.Now
            },
            new Resena
            {
                Id = 25,
                CiudadId = 5,
                Titulo = "Inolvidable",
                Descripcion = "La ciudad es hermosa y está llena de historia.",
                Calificacion = 5,
                Recomendacion = true,
                Fecha = DateTime.Now
            },
            new Resena
            {
                Id = 26,
                CiudadId = 5,
                Titulo = "Encantadora",
                Descripcion = "Las personas fueron muy amables y la comida deliciosa.",
                Calificacion = 4,
                Recomendacion = true,
                Fecha = DateTime.Now
            },
            new Resena
            {
                Id = 27,
                CiudadId = 5,
                Titulo = "Volvería sin dudarlo",
                Descripcion = "El transporte fue eficiente y fácil de usar.",
                Calificacion = 5,
                Recomendacion = true,
                Fecha = DateTime.Now
            },
            new Resena
            {
                Id = 28,
                CiudadId = 5,
                Titulo = "Mal clima",
                Descripcion = "La ciudad estaba abarrotada y sucia.",
                Calificacion = 3,
                Recomendacion = false,
                Fecha = DateTime.Now
            },
            new Resena
            {
                Id = 29,
                CiudadId = 5,
                Titulo = "Experiencia regular",
                Descripcion = "Esperaba más, me decepcionó bastante.",
                Calificacion = 1,
                Recomendacion = false,
                Fecha = DateTime.Now
            },
            new Resena
            {
                Id = 30,
                CiudadId = 5,
                Titulo = "Decepcionante",
                Descripcion = "No me sentí seguro durante mi estancia.",
                Calificacion = 3,
                Recomendacion = false,
                Fecha = DateTime.Now
            },
            new Resena
            {
                Id = 31,
                CiudadId = 6,
                Titulo = "Me encantó",
                Descripcion = "La ciudad es hermosa y está llena de historia.",
                Calificacion = 4,
                Recomendacion = true,
                Fecha = DateTime.Now
            },
            new Resena
            {
                Id = 32,
                CiudadId = 6,
                Titulo = "Volvería sin dudarlo",
                Descripcion = "Tuve una experiencia muy positiva, lo recomiendo.",
                Calificacion = 4,
                Recomendacion = true,
                Fecha = DateTime.Now
            },
            new Resena
            {
                Id = 33,
                CiudadId = 6,
                Titulo = "Volvería sin dudarlo",
                Descripcion = "La ciudad es hermosa y está llena de historia.",
                Calificacion = 4,
                Recomendacion = true,
                Fecha = DateTime.Now
            },
            new Resena
            {
                Id = 34,
                CiudadId = 6,
                Titulo = "Muy sucia",
                Descripcion = "Todo fue extremadamente caro para lo que ofrecía.",
                Calificacion = 3,
                Recomendacion = false,
                Fecha = DateTime.Now
            },
            new Resena
            {
                Id = 35,
                CiudadId = 6,
                Titulo = "Experiencia regular",
                Descripcion = "Poca oferta cultural y muchas obras en las calles.",
                Calificacion = 2,
                Recomendacion = false,
                Fecha = DateTime.Now
            },
            new Resena
            {
                Id = 36,
                CiudadId = 6,
                Titulo = "Mal clima",
                Descripcion = "No me sentí seguro durante mi estancia.",
                Calificacion = 2,
                Recomendacion = false,
                Fecha = DateTime.Now
            },
            new Resena
            {
                Id = 37,
                CiudadId = 7,
                Titulo = "Me encantó",
                Descripcion = "Las personas fueron muy amables y la comida deliciosa.",
                Calificacion = 4,
                Recomendacion = true,
                Fecha = DateTime.Now
            },
            new Resena
            {
                Id = 38,
                CiudadId = 7,
                Titulo = "Me encantó",
                Descripcion = "El transporte fue eficiente y fácil de usar.",
                Calificacion = 5,
                Recomendacion = true,
                Fecha = DateTime.Now
            },
            new Resena
            {
                Id = 39,
                CiudadId = 7,
                Titulo = "Volvería sin dudarlo",
                Descripcion = "Perfecta para unas vacaciones tranquilas y culturales.",
                Calificacion = 5,
                Recomendacion = true,
                Fecha = DateTime.Now
            },
            new Resena
            {
                Id = 40,
                CiudadId = 7,
                Titulo = "Decepcionante",
                Descripcion = "Todo fue extremadamente caro para lo que ofrecía.",
                Calificacion = 2,
                Recomendacion = false,
                Fecha = DateTime.Now
            },
            new Resena
            {
                Id = 41,
                CiudadId = 7,
                Titulo = "Decepcionante",
                Descripcion = "No me sentí seguro durante mi estancia.",
                Calificacion = 3,
                Recomendacion = false,
                Fecha = DateTime.Now
            },
            new Resena
            {
                Id = 42,
                CiudadId = 7,
                Titulo = "Experiencia regular",
                Descripcion = "Esperaba más, me decepcionó bastante.",
                Calificacion = 3,
                Recomendacion = false,
                Fecha = DateTime.Now
            },
            new Resena
            {
                Id = 43,
                CiudadId = 8,
                Titulo = "Muy recomendable",
                Descripcion = "Tuve una experiencia muy positiva, lo recomiendo.",
                Calificacion = 5,
                Recomendacion = true,
                Fecha = DateTime.Now
            },
            new Resena
            {
                Id = 44,
                CiudadId = 8,
                Titulo = "Inolvidable",
                Descripcion = "Perfecta para unas vacaciones tranquilas y culturales.",
                Calificacion = 5,
                Recomendacion = true,
                Fecha = DateTime.Now
            },
            new Resena
            {
                Id = 45,
                CiudadId = 8,
                Titulo = "Volvería sin dudarlo",
                Descripcion = "La ciudad es hermosa y está llena de historia.",
                Calificacion = 4,
                Recomendacion = true,
                Fecha = DateTime.Now
            },
            new Resena
            {
                Id = 46,
                CiudadId = 8,
                Titulo = "Decepcionante",
                Descripcion = "La ciudad estaba abarrotada y sucia.",
                Calificacion = 3,
                Recomendacion = false,
                Fecha = DateTime.Now
            },
            new Resena
            {
                Id = 47,
                CiudadId = 8,
                Titulo = "Demasiado caro",
                Descripcion = "Esperaba más, me decepcionó bastante.",
                Calificacion = 2,
                Recomendacion = false,
                Fecha = DateTime.Now
            },
            new Resena
            {
                Id = 48,
                CiudadId = 8,
                Titulo = "Experiencia regular",
                Descripcion = "No me sentí seguro durante mi estancia.",
                Calificacion = 2,
                Recomendacion = false,
                Fecha = DateTime.Now
            },
            new Resena
            {
                Id = 49,
                CiudadId = 9,
                Titulo = "Encantadora",
                Descripcion = "Las personas fueron muy amables y la comida deliciosa.",
                Calificacion = 4,
                Recomendacion = true,
                Fecha = DateTime.Now
            },
            new Resena
            {
                Id = 50,
                CiudadId = 9,
                Titulo = "Muy recomendable",
                Descripcion = "Perfecta para unas vacaciones tranquilas y culturales.",
                Calificacion = 4,
                Recomendacion = true,
                Fecha = DateTime.Now
            },
            new Resena
            {
                Id = 51,
                CiudadId = 9,
                Titulo = "Encantadora",
                Descripcion = "Perfecta para unas vacaciones tranquilas y culturales.",
                Calificacion = 4,
                Recomendacion = true,
                Fecha = DateTime.Now
            },
            new Resena
            {
                Id = 52,
                CiudadId = 9,
                Titulo = "Experiencia regular",
                Descripcion = "La ciudad estaba abarrotada y sucia.",
                Calificacion = 1,
                Recomendacion = false,
                Fecha = DateTime.Now
            },
            new Resena
            {
                Id = 53,
                CiudadId = 9,
                Titulo = "Mal clima",
                Descripcion = "Todo fue extremadamente caro para lo que ofrecía.",
                Calificacion = 2,
                Recomendacion = false,
                Fecha = DateTime.Now
            },
            new Resena
            {
                Id = 54,
                CiudadId = 9,
                Titulo = "Mal clima",
                Descripcion = "Poca oferta cultural y muchas obras en las calles.",
                Calificacion = 1,
                Recomendacion = false,
                Fecha = DateTime.Now
            }
            );
    }
}
