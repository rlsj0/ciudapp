using CiudApp.Data;
using CiudApp.Models;

namespace CiudApp.Business;

public class CiudadService : ICiudadService
{
    private readonly ICiudadRepository _repository;

    public CiudadService(ICiudadRepository repository)
    {
        _repository = repository;
    }

    public Ciudad CreateCiudad(CiudadCreateDto ciudad)
    {
        var nuevaCiudad = new Ciudad
        {
            Nombre = ciudad.Nombre,
            Pais = ciudad.Pais,
            Poblacion = ciudad.Poblacion,
            SoftDelete = false,
            FechaRegistro = DateTime.Now
        };
        _repository.AddCiudad(nuevaCiudad);
        _repository.SaveChanges();
        return nuevaCiudad;
    }

    public void DeleteCiudad(int id)
    {
        var c = _repository.GetCiudad(id);
        if (c == null)
        {
            throw new KeyNotFoundException($"No hay ciudades con el id {id}");
        }
        _repository.DeleteCiudad(id);
        _repository.SaveChanges();
    }

    public IEnumerable<CiudadReadDto> GetAllCiudades()
    {
        var ciudades = _repository.GetAllCiudades();

        return ciudades.Select(c => new CiudadReadDto
        {
            Id = c.Id,
            Nombre = c.Nombre,
            Pais = c.Pais,
            Poblacion = c.Poblacion,
            SoftDelete = c.SoftDelete,
            FechaRegistro = c.FechaRegistro
        });
    }

    public CiudadReadDto GetCiudadById(int id)
    {
        var c = _repository.GetCiudad(id);
        if (c == null)
        {
            throw new KeyNotFoundException($"No hay ciudades con el id {id}");
        }
        var ciudadDto = new CiudadReadDto
        {
            Id = c.Id,
            Nombre = c.Nombre,
            Pais = c.Pais,
            Poblacion = c.Poblacion,
            SoftDelete = c.SoftDelete,
            FechaRegistro = c.FechaRegistro
        };

        return ciudadDto;
    }

    public void UpdateCiudad(int id, CiudadCreateDto crearCiudad)
    {
        var ciudad = _repository.GetCiudad(id);

        if (ciudad == null)
        {
            throw new KeyNotFoundException($"No hay ciudades con el id {id}");
        }

        ciudad.Nombre = crearCiudad.Nombre;
        ciudad.Pais = crearCiudad.Pais;
        ciudad.Poblacion = crearCiudad.Poblacion;
        ciudad.SoftDelete = crearCiudad.SoftDelete;

        _repository.SaveChanges();
    }
}
