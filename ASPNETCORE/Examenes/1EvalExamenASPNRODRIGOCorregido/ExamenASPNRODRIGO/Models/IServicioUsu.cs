namespace ExamenASPNRODRIGO.Models
{
    public interface IServicioUsu
    {
        public List<Alumno> GetAlumnos();
        public Usuario isUsuario(string email);
        public Usuario isUsuario(string usuario, string contrasenna);
        public Boolean isRepetido(string usuario, string contrasenna);
        public void CambiarContra(string email, string nuevac);
    }
}
