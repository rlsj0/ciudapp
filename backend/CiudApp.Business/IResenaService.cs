using CiudApp.Models;

namespace CiudApp.Business;

public interface IResenaService
{
    // GetResenasPorCiudad(int id)
    public IEnumerable<ResenaReadDto> GetResenasPorCiudad(int id);
    // CreateResena
    public Resena CreateResena(ResenaCreateDto resena);
    // DeleteResena
    public void DeleteResena(int id);
}
