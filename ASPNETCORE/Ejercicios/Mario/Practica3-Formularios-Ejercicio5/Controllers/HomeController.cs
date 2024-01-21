using Microsoft.AspNetCore.Mvc;
using Practica3_Formularios_Ejercicio5.Models;
using Practica3_Formularios_Ejercicio5.Servicios;

namespace Practica3_Formularios_Ejercicio5.Controllers
{
    public class HomeController : Controller
    {
        private readonly IAlumnoService alumnoService;

        public HomeController(IAlumnoService alumnoService)
        {
            this.alumnoService = alumnoService;
        }

        public ActionResult Index()
        {
            var alumnos = alumnoService.ObtenerAlumnos();

            // Mensaje de depuración
            Console.WriteLine($"Número de alumnos: {alumnos.Count}");

            return View(alumnos);
        }

        public ActionResult Crear()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Crear(Alumno alumno)
        {
            if (ModelState.IsValid)
            {
                alumnoService.AgregarAlumno(alumno);
                return RedirectToAction("Index");  // Añade esta línea
            }

            return View(alumno);
        }

        public ActionResult Editar(string dni)
        {
            var alumno = alumnoService.ObtenerAlumnoPorDni(dni);

            if (alumno == null)
            {
                return NotFound();
            }

            return View(alumno);
        }

        [HttpPost]
        public ActionResult Editar(Alumno alumno)
        {
            if (ModelState.IsValid)
            {
                alumnoService.ModificarAlumno(alumno);
                return RedirectToAction("Index");
            }

            return View(alumno);
        }

        public ActionResult Borrar(string dni)
        {
            var alumno = alumnoService.ObtenerAlumnoPorDni(dni);

            if (alumno == null)
            {
                return NotFound();
            }

            return View(alumno);
        }

        [HttpPost, ActionName("Borrar")]
        public ActionResult ConfirmarBorrar(string dni)
        {
            alumnoService.EliminarAlumno(dni);
            return RedirectToAction("Index");
        }

        public ActionResult Ver(string dni)
        {
            var alumno = alumnoService.ObtenerAlumnoPorDni(dni);

            if (alumno == null)
            {
                return NotFound();
            }

            return View(alumno);
        }
    }


}
