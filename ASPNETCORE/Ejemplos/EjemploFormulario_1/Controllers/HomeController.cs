using EjemploFormulario_1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace EjemploFormulario_1.Controllers
{
    public class HomeController : Controller
    {


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        //[HttpPost]
        //public IActionResult Contact(ContactModelView c)
        //{
        //    String n = c.Nombre;
        //    return View("ShowData",c);
        //}

       
        [HttpPost]
        public IActionResult Contact(ContactModelView c)
        {

            return RedirectToAction("ShowData",c);
        }

        public IActionResult ShowData(ContactModelView c)
        {
            return View("ShowData",c);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}