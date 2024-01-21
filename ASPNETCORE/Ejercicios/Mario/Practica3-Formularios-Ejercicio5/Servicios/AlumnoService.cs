using Practica3_Formularios_Ejercicio5.Models;

namespace Practica3_Formularios_Ejercicio5.Servicios
{
    public interface IAlumnoService
    {
        List<Alumno> ObtenerAlumnos();
        void AgregarAlumno(Alumno alumno);
        void ModificarTelefono(string dni, string nuevoTelefono);
        void EliminarAlumno(string dni);
        Alumno ObtenerAlumnoPorDni(string dni);

        void ModificarAlumno(Alumno alumno);
    }

    public class AlumnoService : IAlumnoService
    {
        private List<Alumno> alumnos = new List<Alumno>();

        public List<Alumno> ObtenerAlumnos()
        {
            return alumnos;
        }

        public void AgregarAlumno(Alumno alumno)
        {
            alumnos.Add(alumno);
        }

        public void ModificarTelefono(string dni, string nuevoTelefono)
        {
            var alumno = alumnos.FirstOrDefault(a => a.Dni == dni);
            if (alumno != null)
            {
                alumno.Telefono = nuevoTelefono;
            }
        }

        public void EliminarAlumno(string dni)
        {
            alumnos.RemoveAll(a => a.Dni == dni);
        }

        public Alumno ObtenerAlumnoPorDni(string dni)
        {
            return alumnos.FirstOrDefault(a => a.Dni == dni);
        }

        public void ModificarAlumno(Alumno alumno)
        {
            var alumnoExistente = alumnos.FirstOrDefault(a => a.Dni == alumno.Dni);
            if (alumnoExistente != null)
            {
                alumnoExistente.Telefono = alumno.Telefono;
            }
        }
    }

}
