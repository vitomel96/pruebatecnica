using PersonasAPI.Domain.Entities;

namespace PersonasAPI.Application.Interfaces;
public interface IPersonaRepository
{
    Task<List<Persona>> GetAllAsync(); // Obtener todas las personas
    Task<Persona> GetByIdAsync(int id); // Obtener persona por ID
    Task<Persona> CreateAsync(Persona persona); // Crear una nueva persona
    Task<Persona> UpdateAsync(int id, Persona persona); // Actualizar una persona existente
    Task<bool> DeleteAsync(int id); // Eliminar una persona por ID
}
