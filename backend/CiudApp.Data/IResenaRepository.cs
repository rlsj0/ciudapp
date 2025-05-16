using CiudApp.Models;

namespace CiudApp.Data;

public interface IResenaRepository
{
    // Get Resena
    public Resena GetResena(int id);
    // Create Resena
    public void AddResena(Resena resena);
    // Get Resena por Ciudad
    public IEnumerable<Resena> GetResenasPorCiudad(int id);
    // Delete Resena
    public void DeleteResena(int id);
    // SaveChanges
    public void SaveChanges();
}
