using Ejercicio3ASPNETForms.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Ejercicio3ASPNETForms.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Formulario()
        {
            return View();
        }

        public IActionResult Detalles(Persona perso)
        {
            if (perso.Asisitir == true)
            {
                perso.Mensaje = "Muchas gracias por su confirmacion";
            }
            else
            {
                perso.Mensaje = "Putoi maricon tienes miedo o que";
            }
            return View(perso);
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