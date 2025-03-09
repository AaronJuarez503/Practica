using Microsoft.EntityFrameworkCore;
namespace Practica.CodeFirst.Models
{
    public class ESFEDbContext: DbContext
    {
        public ESFEDbContext(DbContextOptions<ESFEDbContext> options) : base(options) { }

        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<Alumno> Alumnos { get; set; }

    }
}
