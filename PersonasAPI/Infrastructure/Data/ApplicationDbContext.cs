using Microsoft.EntityFrameworkCore;
using PersonasAPI.Domain.Entities;

namespace PersonasAPI.Infrastructure.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        public DbSet<Persona> Personas { get; set; }
    }
}
