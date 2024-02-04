using P3Ejercicio2.Models;
using P3Ejercicio2.Interfaces;

using Microsoft.Data.SqlClient;

namespace P3Ejercicio2.Services
{
    public class RepositorioAlumnos : IRepositorioAlumnos
    {
        private readonly string connectionString;
        private SqlConnection connecion;
        public RepositorioAlumnos(IConfiguration config)
        {
            connectionString = this.connectionString = config.GetConnectionString("DefaultConnection");

        }

        public List<Alumno> ListaAlumnos { get; set; }

        public IEnumerable<Alumno> GetAlumnos()
        {
            return ListaAlumnos;
        }

        public void addAlumno(Alumno a)
        {
            this.ListaAlumnos.Add(a);
        }

        public Alumno GetAlumno(int id)
        {
            return this.ListaAlumnos[id];
        }

        public void deleteAlumno(int id)
        {
            this.ListaAlumnos.RemoveAt(id);
        }
    }
}

