using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CiudApp.Models;

public class Resena
{

    [Key]
    public int Id { get; set; }

    [ForeignKey("Ciudad")]
    public int CiudadId { get; set; }

    public Ciudad Ciudad { get; set; }

    public string Titulo { get; set; }
    public string Descripcion { get; set; }
    public int Calificacion { get; set; }
    public DateTime Fecha { get; set; }
    public bool Recomendacion { get; set; }

    public Resena() { }
}
