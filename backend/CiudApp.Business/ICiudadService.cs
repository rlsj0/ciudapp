using CiudApp.Models;

namespace CiudApp.Business;

public interface ICiudadService
{
    // Create
    public Ciudad CreateCiudad(CiudadCreateDto ciudad);

    // Read
    public IEnumerable<CiudadReadDto> GetAllCiudad();
    public CiudadReadDto GetCiudadById(int id);

    // Update
    public void UpdateCiudad(int id, CiudadCreateDto ciudad);

    // Delete
    public void DeleteCiudad(int id);

}
