using Microsoft.AspNetCore.Authentication;
using Microsoft.EntityFrameworkCore;
using P3Ejercicio2.Models;

namespace P3Ejercicio2
{
    public class BBDContext : DbContext
    {
        public BBDContext(DbContextOptions<BBDContext> options) : base(options)
        {
        }
        public DbSet<Ciclo> Ciclos { get; set; }
        public DbSet<Alumno> Alumnos { get; set; }
    }
}
