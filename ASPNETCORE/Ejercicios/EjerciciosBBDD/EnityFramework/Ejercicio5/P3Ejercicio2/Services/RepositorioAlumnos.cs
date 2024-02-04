using P3Ejercicio2.Models;
using P3Ejercicio2.Interfaces;

namespace P3Ejercicio2.Services
{
    public class RepositorioAlumnos : IRepositorioAlumnos
    {
        public List<Alumno> ListaAlumnos { get; set; }
        private BBDContext _context;
        public RepositorioAlumnos(BBDContext context)
        {
            _context = context;
            ListaAlumnos = _context.Alumnos.ToList();
        }

        

        public IEnumerable<Alumno> GetAlumnos()
        {
            return ListaAlumnos;
        }

        public void addAlumno(Alumno a)
        {
            _context.Alumnos.Add(a);
            _context.SaveChanges();
        }

        public Alumno GetAlumno(int id)
        {
            return _context.Alumnos.Find(id);
        }

        public void deleteAlumno(int id)
        {
            var cicloParaEliminar = _context.Alumnos.Find(id);
            _context.Alumnos.Remove(cicloParaEliminar);
        }
    }
}

