using EjemploVistasYServicios.Models;

namespace EjemploVistasYServicios.Servicios
{
    public class LibroService : ILibroService
    {
        private List<Libro> _libros;

        public LibroService()
        {
            // Inicialización de datos de prueba
            _libros = new List<Libro>
        {
            new Libro { Id = 1, Titulo = "Cien años de soledad", Autor = "Gabriel García Márquez", AñoPublicacion = 1967 },
            new Libro { Id = 2, Titulo = "1984", Autor = "George Orwell", AñoPublicacion = 1949 },
            new Libro { Id = 3, Titulo = "El señor de los anillos", Autor = "J.R.R. Tolkien", AñoPublicacion = 1954 }
        };
        }

        public List<Libro> ObtenerLibros()
        {
            return _libros;
        }

        public Libro ObtenerLibroPorId(int id)
        {
            return _libros.Find(libro => libro.Id == id);
        }
        public void AgregarLibro(LibroViewModel libroViewModel)
        {
            // Supongamos que generamos automáticamente el ID
            int nuevoId = _libros.Count + 1;

            // Crear un nuevo libro a partir del modelo de vista
            var nuevoLibro = new Libro
            {
                Id = nuevoId,
                Titulo = libroViewModel.Titulo,
                Autor = libroViewModel.Autor,
                AñoPublicacion = libroViewModel.AñoPublicacion
            };

            _libros.Add(nuevoLibro);
        }
    }
}
