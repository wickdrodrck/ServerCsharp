using Ejercicio5ASPNETFormus.Models;

namespace Ejercicio5ASPNETFormus.Servicios
{
    public class ServicioAlumnos
    {
        private List<Persona> Alumnos;
        public ServicioAlumnos()
        {
            this.Alumnos = new List<Persona>();
        }

        public void AñadirAlumno(Persona alumno)
        {
            Alumnos.Add(alumno);
        }
        public List<Persona> DevolverAlumnos()
        {
            return Alumnos;
        }

        public void Eliminar(string telefono)
        {
            for(int i = 0; i < Alumnos.Count; i++)
            {
                if (Alumnos[i].telefono == telefono)
                {
                    Alumnos.RemoveAt(i);
                }
            }
        }

        public void Editar(string telefonoviej, string nuev)
        {
            for (int i = 0; i < Alumnos.Count; i++)
            {
                if (Alumnos[i].telefono == telefonoviej)
                {
                    Alumnos[i].telefono = nuev;
                }
            }
        }

        public Persona VerAlumno(string telefono)
        {
            for (int i = 0; i < Alumnos.Count; i++)
            {
                if (Alumnos[i].telefono == telefono)
                {
                    return Alumnos[i];
                }
            }
            return null;
        }
    }
}
