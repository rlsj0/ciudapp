namespace CiudApp.Models;

public class ResenaReadDto
{
    public int Id { get; set; }
    public int CiudadId { get; set; }

    public string Titulo { get; set; }
    public string Descripcion { get; set; }
    public int Calificacion { get; set; }
    public DateTime Fecha { get; set; }
    public bool Recomendacion { get; set; }
}
