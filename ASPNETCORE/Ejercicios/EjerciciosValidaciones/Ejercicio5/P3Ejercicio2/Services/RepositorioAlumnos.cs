using P3Ejercicio2.Models;
using P3Ejercicio2.Interfaces;

namespace P3Ejercicio2.Services
{
    public class RepositorioAlumnos : IRepositorioAlumnos
    {

        public RepositorioAlumnos()
        {
            ListaAlumnos = new List<Alumno>
        {
            new Alumno
            {
                DNI="11111111A",
                Nombre="Ana",
                Apellidos="Sanz López",
                Telefono="677878787",
                Curso="DAW1",
                Edad=18
            },
            new Alumno
            {
                DNI="22222222B",
                Nombre="Juan",
                Apellidos="Rodríguez Pérez",
                Telefono="655434323",
                Curso="DAW1",
                Edad=19
            },
            new Alumno
            {
                DNI="33333333C",
                Nombre="Beatriz",
                Apellidos="García Sanz",
                Telefono="699878787",
                Curso="DAW1",
                Edad=19
            },
            new Alumno
            {
                DNI="33333333G",
                Nombre="Raquel",
                Apellidos="García Esukorria",
                Telefono="612822786",
                Curso="ASIR",
                Edad=18
        } };

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

