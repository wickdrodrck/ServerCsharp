using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using P3Ejercicio2.Interfaces;
using P3Ejercicio2.Models;

namespace P3Ejercicio2.Controllers
{
    public class CiclosController : Controller
    {
        private static int posicionAlumno = 0;
        private IRepositorioCiclos datos;
        private IRepositorioAlumnos datos2;
        

        public CiclosController(IRepositorioCiclos r, IRepositorioAlumnos r2)
        {
            this.datos = r;
            this.datos2 = r2;
        }
        public IActionResult Index()
        {
            return View(this.datos.GetCiclos());
        }

        public IActionResult Privacy()
        {
            return View();
        }
        

        public IActionResult CicloAdd()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CicloAdd(Ciclo c)
        {
            if (ModelState.IsValid)
            {
                this.datos.addCiclos(c);
                return Redirect("Index");
            }
            return View(c);
        }


        public IActionResult EliminarCurso(int id)
        {
            posicionAlumno = id;
            datos.eliminciclo(posicionAlumno);
            return RedirectToAction("Index");

        }

        public IActionResult Details(int id)
        {
            return View(this.datos.GetCiclo(id));
        }



    }
}

