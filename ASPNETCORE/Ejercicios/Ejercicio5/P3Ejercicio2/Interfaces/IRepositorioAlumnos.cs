using P3Ejercicio2.Models;

namespace P3Ejercicio2.Interfaces
{
    public interface IRepositorioAlumnos
    {
        public IEnumerable<Alumno> GetAlumnos();

        public void deleteAlumno(int id);
        public void addAlumno(Alumno a);
        public Alumno GetAlumno(int id);
    }
}
