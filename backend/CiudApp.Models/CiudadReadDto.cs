namespace CiudApp.Models;

public class CiudadReadDto
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public string Pais { get; set; }
    public int Poblacion { get; set; }
    public bool SoftDelete { get; set; }
    public DateTime FechaRegistro { get; set; }
}
