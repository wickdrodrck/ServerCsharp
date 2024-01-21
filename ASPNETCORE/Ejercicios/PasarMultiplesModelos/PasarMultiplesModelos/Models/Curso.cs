namespace PasarMultiplesModelos.Models
{
    public class Curso
    {
        public String? Siglas { get; set; }
        public String? Aula { get; set; }

        public List<Alumno> Listado { get; set; }

        public Alumno getDatosAlumno(int posicion)
        {
            return Listado[posicion];
        }
    }
}
