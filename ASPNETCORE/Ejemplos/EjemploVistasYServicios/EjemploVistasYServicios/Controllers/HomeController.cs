using EjemploVistasYServicios.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace EjemploVistasYServicios.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILibroService _libroService;

        public HomeController(ILibroService libroService)
        {
            _libroService = libroService;
        }

        public IActionResult Index()
        {
            var libros = _libroService.ObtenerLibros();
            return View(libros);
        }

        public IActionResult Detalle(int id)
        {
            var libro = _libroService.ObtenerLibroPorId(id);
            return PartialView("_DetalleLibro", libro);
        }

        [HttpGet]
        public IActionResult AgregarLibro()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AgregarLibro(LibroViewModel libroViewModel)
        {
            _libroService.AgregarLibro(libroViewModel);
            return RedirectToAction("Index");
        }
    }
}