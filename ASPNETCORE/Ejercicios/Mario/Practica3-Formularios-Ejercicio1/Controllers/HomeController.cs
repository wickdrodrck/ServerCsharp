using Microsoft.AspNetCore.Mvc;
using Practica3_Formularios_Ejercicio1.Models;
using System.Diagnostics;

namespace Practica3_Formularios_Ejercicio1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Variables variables)
        {
            string nombre = variables.Nombre;
            int edad = variables.Edad;
            string mensaje;

            if(edad >= 18)
            {
                mensaje = "Mayor de Edad";
            }
            else {
                mensaje = "Menor de Edad";
            }

            Variables modeloActualizado = new Variables
            {
                Nombre = nombre,
                Edad = edad,
                Mensaje = mensaje
            };

            return RedirectToAction("MayoriaEdadNombre",modeloActualizado);
        }

        public IActionResult MayoriaEdadNombre(Variables modelo) 
        {
            return View(modelo);
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