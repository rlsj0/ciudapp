using CiudApp.Models;

namespace CiudApp.Data;

public class ResenaRepository : IResenaRepository
{

    private readonly CiudAppContext _context;

    public ResenaRepository(CiudAppContext context)
    {
        _context = context;
    }

    public void AddResena(Resena resena)
    {
        _context.Resenas.Add(resena);
    }

    public void DeleteResena(int id)
    {
        var resena = GetResena(id);

        // Estoy haciendo la comprobación de que existe en service

        _context.Resenas.Remove(resena);
        SaveChanges();
    }

    public Resena GetResena(int id)
    {
        var resena = _context.Resenas.FirstOrDefault(c => c.Id == id);

        if (resena is null)
        {
            throw new KeyNotFoundException("Reseña no encontrada");
        }

        return resena;
    }

    public IEnumerable<Resena> GetResenasPorCiudad(int id)
    {
        var resenas = _context.Resenas.Where(resena => resena.CiudadId == id);
        return resenas;
    }

    public void SaveChanges()
    {
        _context.SaveChanges();
    }
}
