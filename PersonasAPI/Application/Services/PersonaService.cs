using PersonasAPI.Domain.Entities;
using PersonasAPI.Application.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersonasAPI.Application.Services;

public class PersonaService
{
    private readonly IPersonaRepository _personaRepository;

    public PersonaService(IPersonaRepository personaRepository)
    {
        _personaRepository = personaRepository;
    }

    public async Task<List<Persona>> GetAllAsync()
    {
        // Obtener todas las personas desde el repositorio
        return await _personaRepository.GetAllAsync();
    }

    public async Task<Persona> GetByIdAsync(int id)
    {
        // Obtener una persona por su ID
        return await _personaRepository.GetByIdAsync(id);
    }

    public async Task<Persona> CreateAsync(Persona persona)
    {
        // Validar que la persona no exista, etc.
        return await _personaRepository.CreateAsync(persona);
    }

    public async Task<Persona> UpdateAsync(int id, Persona persona)
    {
        // Validar que la persona existe
        var existingPersona = await _personaRepository.GetByIdAsync(id);
        if (existingPersona == null)
        {
            // Aquí puedes lanzar una excepción o manejarlo de otra forma
            return null; // O lanzar una excepción
        }

        // Actualiza las propiedades de existingPersona
        existingPersona.Cedula = persona.Cedula;
        existingPersona.Nombre = persona.Nombre;
        existingPersona.Apellido = persona.Apellido;
        existingPersona.NumeroCelular = persona.NumeroCelular;

        // Llama al repositorio para guardar los cambios
        return await _personaRepository.UpdateAsync(id, existingPersona); // id es el tipo 'int'
    }

    public async Task<bool> DeleteAsync(int id)
    {
        // Validar que la persona existe
        var existingPersona = await _personaRepository.GetByIdAsync(id);
        if (existingPersona == null)
        {
            return false; // La persona no existe
        }

        // Llama al repositorio para eliminar la persona
        return await _personaRepository.DeleteAsync(id); // Aquí pasa el id, no el objeto Persona
    }
}
