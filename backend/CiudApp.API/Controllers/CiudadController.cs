using CiudApp.Business;
using CiudApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace CiudApp.API.Controllers;

[ApiController]
[Route("[controller]")]
public class CiudadController : ControllerBase
{
    private readonly ICiudadService _ciudadService;

    public CiudadController(ICiudadService ciudadService)
    {
        _ciudadService = ciudadService;
    }

    [HttpGet(Name = "GetAllCiudades")]
    public ActionResult<IEnumerable<CiudadReadDto>> GetCiudades()
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        try
        {
            var ciudades = _ciudadService.GetAllCiudades();
            return Ok(ciudades);
        }
        catch (Exception ex)
        {
            return BadRequest(ex);
        }
    }

    [HttpGet("{id}", Name = "GetCiudad")]
    public IActionResult GetCiudad(int id)
    {
        try
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var ciudad = _ciudadService.GetCiudadById(id);
            return Ok(ciudad);
        }
        catch (KeyNotFoundException)
        {
            return NotFound($"La ciudad de id {id} no existe");
        }
    }

    [HttpPost]
    public IActionResult CreateCiudad([FromBody] CiudadCreateDto ciudadCreateDto)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        try
        {
            var ciudad = _ciudadService.CreateCiudad(ciudadCreateDto);
            return Ok(ciudad.Id);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpPut("{id}")]
    public IActionResult UpdateCiudad(int id,
                                    [FromBody] CiudadCreateDto ciudadCreateDto)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        try
        {
            _ciudadService.UpdateCiudad(id, ciudadCreateDto);
            return Ok(id);
        }

        catch (KeyNotFoundException)
        {
            return NotFound();
        }
    }

    [HttpDelete("{id}")]
    public IActionResult DeleteCiudad(int id)
    {
        try
        {
            _ciudadService.DeleteCiudad(id);
            return NoContent();
        }
        catch (KeyNotFoundException ex)
        {
            return NotFound(ex.Message);
        }
    }


}
