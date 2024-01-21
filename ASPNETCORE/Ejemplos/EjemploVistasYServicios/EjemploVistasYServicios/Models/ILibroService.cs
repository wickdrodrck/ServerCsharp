namespace EjemploVistasYServicios.Models
{
    public interface ILibroService
    {
        List<Libro> ObtenerLibros();
        Libro ObtenerLibroPorId(int id);
        void AgregarLibro(LibroViewModel libroViewModel);
    }
}
