namespace CiudApp.Models;

public class ResenaCreateDto
{
    public int CiudadId { get; set; }

    public string Titulo { get; set; }
    public string Descripcion { get; set; }
    public int Calificacion { get; set; }
    public bool Recomendacion { get; set; }

}
