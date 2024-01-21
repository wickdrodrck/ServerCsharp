using Ejercicio5ASPNETFormus.Models;
using Ejercicio5ASPNETFormus.Servicios;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Ejercicio5ASPNETFormus.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ServicioAlumnos _servicioTimido;

        public HomeController(ILogger<HomeController> logger, ServicioAlumnos servicioTimido)
        {
            _logger = logger;
            _servicioTimido = servicioTimido;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var alumnos = _servicioTimido.DevolverAlumnos();
            return View(alumnos);
        }

        [HttpPost]
        public IActionResult AgregarAlumno(Persona alumno)
        {
            
            _servicioTimido.AñadirAlumno(alumno);
            return RedirectToAction("Index");
        }

        public IActionResult Formulario()
        {
            return View();
        }

        public IActionResult Editar(int id)
        {
            
            return RedirectToAction("Index");
        }

        public IActionResult Borrar(int id)
        {
            // Lógica para borrar el alumno con el ID proporcionado
            return RedirectToAction("Index");
        }

        public IActionResult Ver(int id)
        {
            // Lógica para ver los detalles del alumno con el ID proporcionado
            return RedirectToAction("Index");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}