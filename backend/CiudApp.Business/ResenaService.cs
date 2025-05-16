using CiudApp.Data;
using CiudApp.Models;

namespace CiudApp.Business;

public class ResenaService : IResenaService
{
    private readonly IResenaRepository _resenaRepository;
    private readonly ICiudadRepository _ciudadRepository;

    public ResenaService(IResenaRepository resenaRepository,
                         ICiudadRepository ciudadRepository)
    {
        _resenaRepository = resenaRepository;
        _ciudadRepository = ciudadRepository;
    }

    public Resena CreateResena(ResenaCreateDto resena)
    {
        var ciudad = _ciudadRepository.GetCiudad(resena.CiudadId);
        if (ciudad == null)
        {
            throw new KeyNotFoundException($"No hay ciudades con el id {resena.CiudadId}");
        }

        var nuevaResena = new Resena
        {
            CiudadId = resena.CiudadId,
            Titulo = resena.Titulo,
            Descripcion = resena.Descripcion,
            Fecha = DateTime.Now,
            Calificacion = resena.Calificacion,
            Recomendacion = resena.Recomendacion
        };
        _resenaRepository.AddResena(nuevaResena);
        _resenaRepository.SaveChanges();
        return nuevaResena;
    }

    public void DeleteResena(int id)
    {
        var resena = _resenaRepository.GetResena(id);
        if (resena == null)
        {
            throw new KeyNotFoundException($"No hay reseñas con el id {id}");
        }
        _resenaRepository.DeleteResena(id);
        _resenaRepository.SaveChanges();
    }

    public IEnumerable<ResenaReadDto> GetResenasPorCiudad(int id)
    {
        var ciudad = _ciudadRepository.GetCiudad(id);
        if (ciudad == null)
        {
            throw new KeyNotFoundException($"No hay ciudades con el id {id}");
        }

        var resenas = _resenaRepository.GetResenasPorCiudad(id);

        var resenasDto = resenas.Select(r => new ResenaReadDto
        {
            Id = r.Id,
            CiudadId = r.CiudadId,
            Titulo = r.Titulo,
            Descripcion = r.Descripcion,
            Calificacion = r.Calificacion,
            Fecha = r.Fecha,
            Recomendacion = r.Recomendacion
        });

        return resenasDto;
    }
}
