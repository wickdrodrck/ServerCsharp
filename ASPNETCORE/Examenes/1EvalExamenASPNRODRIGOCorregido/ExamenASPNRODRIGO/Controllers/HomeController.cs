using ExamenASPNRODRIGO.Models;
using ExamenASPNRODRIGO.Servicios;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ExamenASPNRODRIGO.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IServicioUsu servicio;

        public HomeController(ILogger<HomeController> logger, IServicioUsu service)
        {
            _logger = logger;
            servicio = service;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult ManejoDatos(Usuario usu)
        {
            if(servicio.isUsuario(usu.usuario, usu.contra) == null)
            {
                return RedirectToAction("Index");
            }
            else
            {
                Usuario usuaro = servicio.isUsuario(usu.usuario, usu.contra);
                if (usuaro.GetType().Name == "Alumno")
                {
                    return RedirectToAction("DatosAlum", usuaro);
                }
                else
                {
                    return RedirectToAction("DatosProf");
                }
            }

            
        }

        public IActionResult DatosAlum(Alumno alum)
        {

            return View(alum);
        }

        public IActionResult Olvidar()
        {
             return View(null);
            
        }

        public IActionResult Olvidar2(string email) {
            ContraseñaOlvidar eamail = new ContraseñaOlvidar();
            eamail.email = email;
            return View("Olvidar",eamail);
        }

        public IActionResult OlvidarContra(ContraseñaOlvidar alum)
        {
            if (alum.ContraseñaRepetida == alum.contra)
            {
                servicio.CambiarContra(alum.email, alum.contra);
                return RedirectToAction("Index");
            }
            else
            {
                return RedirectToAction("Olvidar");
            }

        }

        public IActionResult DatosProf()
        {
            
            return View(servicio.GetAlumnos());
        }

        public IActionResult Registro()
        {
            return View();
        }


    }
}