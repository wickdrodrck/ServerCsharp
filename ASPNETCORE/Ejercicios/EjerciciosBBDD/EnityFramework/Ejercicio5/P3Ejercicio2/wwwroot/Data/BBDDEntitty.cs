
using Microsoft.EntityFrameworkCore;
namespace P3Ejercicio2
{
	public class BBDDEntitty : DbContext

	{
		public BBDDEntitty(DbContextOptions<BarContext> options) : base(options)
		{
		}
		public DbSet<Ciclo> Ciclos { get; set; }
		public DbSert<Alumno> Alumnos { get; set; }

	}
}