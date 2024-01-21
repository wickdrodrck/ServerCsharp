using Microsoft.AspNetCore.Mvc;

namespace Ejemplos.Controllers
{
    public class NoHITController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
