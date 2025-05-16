using CiudApp.Models;

namespace CiudApp.Data;

public interface ICiudadRepository
{

    public IEnumerable<Ciudad> GetAllCiudades();
    public Ciudad GetCiudad(int id);
    public void AddCiudad(Ciudad ciudad);
    public void UpdateCiudad(Ciudad ciudad);
    public void DeleteCiudad(int id);

    public void SaveChanges();
}
