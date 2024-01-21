using Microsoft.AspNetCore.Mvc;

namespace EjemploHacer.Controllers
{
    public class ControladorEjemploPersona : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult OtroIndex()
        {

        }
    }
}
