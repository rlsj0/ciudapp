using CiudApp.Business;
using CiudApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace CiudApp.API.Controllers;

[ApiController]
[Route("[controller]")]
public class ResenaController : ControllerBase
{

    private readonly IResenaService _resenaService;

    public ResenaController(IResenaService resenaService)
    {
        _resenaService = resenaService;
    }

    // GET all /Ciudad/{id}/Resena
    [HttpGet("/Ciudad/{ciudadId}/Resena")]
    public IActionResult GetResenasPorCiudad(int ciudadId)
    {
        try
        {
            var resenas = _resenaService.GetResenasPorCiudad(ciudadId);
            return Ok(resenas);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    // POST /Resena

    [HttpPost]
    public IActionResult CreateResena([FromBody] ResenaCreateDto resenaCreateDto)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        try
        {
            var resena = _resenaService.CreateResena(resenaCreateDto);
            return Ok(resena.Id);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    // DELETE /Resena
    [HttpDelete("{id}")]
    public IActionResult DeleteResena(int id)
    {
        try
        {
            _resenaService.DeleteResena(id);
            return NoContent();
        }
        catch (KeyNotFoundException ex)
        {
            return NotFound(ex.Message);
        }
    }
}

