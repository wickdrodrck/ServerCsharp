using Practica3_Formularios_Ejercicio4.Models;

namespace Practica3_Formularios_Ejercicio4.Servicios
{
    public interface ICharlaService
    {
        void RegistrarAsistencia(Alumno alumno);
        List<Alumno> ObtenerAsistentes();
    }

    public class CharlaService : ICharlaService
    {
        private static List<Alumno> alumnos = new List<Alumno>();

        public void RegistrarAsistencia(Alumno alumno)
        {
            alumnos.Add(alumno);
        }

        public List<Alumno> ObtenerAsistentes()
        {
            return alumnos;
        }
    }
}
