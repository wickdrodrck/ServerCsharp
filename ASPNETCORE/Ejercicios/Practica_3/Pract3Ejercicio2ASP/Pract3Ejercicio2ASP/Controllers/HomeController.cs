using Microsoft.AspNetCore.Mvc;
using Pract3Ejercicio2ASP.Models;
using System.Diagnostics;
using Pract3Ejercicio2ASP.Servicios;

namespace Pract3Ejercicio2ASP.Controllers
{
    
    public class HomeController : Controller
    {
        private readonly ServicioArray ds;
        private Usuario usus = new Usuario();
        public HomeController(ServicioArray dss)
        {
            this.ds = dss;
        }

        public IActionResult Index()
        {
            usus.Aficiones = ds.GetAficiones();
            return View(usus);
        }
        public IActionResult Datos(Usuario usum)
        {
            usum.Aficiones = usum.Aficiones.Where(x => x.chequeado).ToList();
            if (usum.Aficiones.Count() == 0)
            {
                usum.Mensaje = usum.Nombre + ", eres un soso";
            } else if (usum.Aficiones.Count() == 1)
            {
                usum.Mensaje = usum.Nombre + " deberías buscar más aficiones aparte de " + usum.Aficiones[0].Nombre;
            } else if (usum.Aficiones.Count() == 3) {
                usum.Mensaje = usum.Nombre + " creo que tienes muchas aficiones.";
            }
            return View(usum);
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