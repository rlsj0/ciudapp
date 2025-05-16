namespace CiudApp.Models;

public class CiudadCreateDto
{
    public string Nombre { get; set; }
    public string Pais { get; set; }
    public int Poblacion { get; set; }
    public bool SoftDelete { get; set; }
}
