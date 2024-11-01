using PersonasAPI.Application.Interfaces;
using PersonasAPI.Domain.Entities;
using PersonasAPI.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersonasAPI.Infrastructure.Repositories
{
    public class PersonaRepository : IPersonaRepository
    {
        private readonly ApplicationDbContext _context;

        public PersonaRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Persona> CreateAsync(Persona persona)
        {
            // Agregar la persona al contexto
            await _context.Personas.AddAsync(persona);
            // Guardar los cambios en la base de datos
            await _context.SaveChangesAsync();
            // Devolver la entidad creada
            return persona; // Debe ser Task<Persona>
        }

        public async Task<Persona> UpdateAsync(int id, Persona persona)
        {
            // Asegurarse de que el ID esté configurado
            persona.Id = id;
            // Actualizar la entidad en el contexto
            _context.Personas.Update(persona);
            // Guardar los cambios en la base de datos
            await _context.SaveChangesAsync();
            // Devolver la entidad actualizada
            return persona; // Debe ser Task<Persona>
        }

        public async Task<bool> DeleteAsync(int id)
        {
            // Buscar la persona por ID
            var persona = await _context.Personas.FindAsync(id);
            if (persona == null) return false; // Si no se encuentra, devolver falso

            // Eliminar la persona del contexto
            _context.Personas.Remove(persona);
            // Guardar los cambios en la base de datos
            await _context.SaveChangesAsync();
            return true; // Debe ser Task<bool>
        }

        public async Task<Persona> GetByIdAsync(int id)
        {
            return await _context.Personas.FindAsync(id);
        }

        public async Task<List<Persona>> GetAllAsync()
        {
            return await _context.Personas.ToListAsync();
        }
    }
}
