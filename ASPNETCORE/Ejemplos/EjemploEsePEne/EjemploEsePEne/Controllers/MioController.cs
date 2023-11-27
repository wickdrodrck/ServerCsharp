using Microsoft.AspNetCore.Mvc;

namespace EjemploEsePEne.Controllers
{
    public class MioController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Fecha = DateTime.Today;
            ViewData["Nombre"] = "Rosa";
            return View();
        }

        public IActionResult OtroIndex()
        {
            Persona p = new Persona()
            {
                Nombre = "Rosa",
                Fecha = DateTime.Today,
                Edad = 34
            };
            return View(p);
        }
    }
}
