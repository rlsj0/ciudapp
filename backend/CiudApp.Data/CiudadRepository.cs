using CiudApp.Models;

namespace CiudApp.Data;

public class CiudadRepository : ICiudadRepository
{
    private readonly CiudAppContext _context;

    public CiudadRepository(CiudAppContext context)
    {
        _context = context;
    }

    public void AddCiudad(Ciudad ciudad)
    {
        _context.Ciudades.Add(ciudad);
    }

    public void DeleteCiudad(int id)
    {
        var ciudad = GetCiudad(id);
        if (ciudad is null)
        {
            throw new KeyNotFoundException("Ciudad no encontrada");
        }
        _context.Ciudades.Remove(ciudad);
        SaveChanges();
    }

    public IEnumerable<Ciudad> GetAllCiudades()
    {

        var query = _context.Ciudades.AsQueryable();

        var result = query.ToList();

        return result;
    }

    public Ciudad GetCiudad(int id)
    {
        var ciudad = _context.Ciudades.FirstOrDefault(c => c.Id == id);
        if (ciudad is null)
        {
            throw new KeyNotFoundException("Ciudad no encontrada");
        }
        return ciudad;
    }

    public void SaveChanges()
    {
        _context.SaveChanges();
    }

    public void UpdateCiudad(Ciudad ciudad)
    {
        _context.Ciudades.Remove(ciudad);
        SaveChanges();
    }
}
