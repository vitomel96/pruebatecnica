using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PersonasAPI.Application.Interfaces;
using PersonasAPI.Domain.Entities;
using System.Threading.Tasks;
using PersonasAPI.Application.Services;

[ApiController]
[Route("api/[controller]")]
[Authorize]

public class PersonaController : ControllerBase
{
    private readonly PersonaService _personaService;

    public PersonaController(PersonaService personaService)
    {
        _personaService = personaService;
    }

    // Obtener todas las personas
    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var personas = await _personaService.GetAllAsync();
        return Ok(personas);
    }

    // Obtener una persona por ID
    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var persona = await _personaService.GetByIdAsync(id);
        if (persona == null)
        {
            return NotFound(); // 404 Not Found si la persona no existe
        }

        return Ok(persona);
    }

    // Crear una nueva persona
    [HttpPost]
    public async Task<IActionResult> Create([FromBody] Persona persona)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState); // 400 Bad Request si el modelo no es válido
        }

        var createdPersona = await _personaService.CreateAsync(persona);
        return CreatedAtAction(nameof(GetById), new { id = createdPersona.Id }, createdPersona); // 201 Created
    }

    // Actualizar una persona existente
    [HttpPut("{id}")]
    public async Task<IActionResult> Update(int id, [FromBody] Persona persona)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState); // 400 Bad Request si el modelo no es válido
        }

        var updatedPersona = await _personaService.UpdateAsync(id, persona);
        if (updatedPersona == null)
        {
            return NotFound(); // 404 Not Found si la persona no existe
        }

        return Ok(updatedPersona); // 200 OK
    }

    // Eliminar una persona
    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        var deleted = await _personaService.DeleteAsync(id);
        if (!deleted)
        {
            return NotFound(); // 404 Not Found si la persona no existe
        }

        return NoContent(); // 204 No Content
    }
}
