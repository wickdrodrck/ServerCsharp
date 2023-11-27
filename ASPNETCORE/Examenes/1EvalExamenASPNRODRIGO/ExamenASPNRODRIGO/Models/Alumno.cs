namespace ExamenASPNRODRIGO.Models
{
    public class Alumno : Usuario
    {
        public EnumCiclo Ciclo { get; set; }
        public int curso { get; set; }
        public List<string> idiomas { get; set; }
    }
}
