using Ejercicio1ASPNETPract3.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Ejercicio1ASPNETPract3.Controllers
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

        [HttpPost]
        public IActionResult Pagina2(string nombre, int edad)
        {
            
            if (edad >= 18)
            {
                ViewData["Mensaje"] = "Eres Mayor de edad!";
            }
            else
            {
                ViewData["Mensaje"] = "No eres mayor de edad";
            }
            ViewData["Nombre"] = nombre;


            return View();
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