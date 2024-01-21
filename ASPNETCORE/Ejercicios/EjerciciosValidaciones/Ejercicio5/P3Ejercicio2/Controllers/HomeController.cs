using Microsoft.AspNetCore.Mvc;
using P3Ejercicio2.Models;
using P3Ejercicio2.Interfaces;
using System.Diagnostics;

namespace P3Ejercicio2.Controllers
{
    public class HomeController : Controller
    {
        private static int posicionAlumno = 0;
        private IRepositorioAlumnos datos;
        private IRepositorioCiclos datos2;

        public HomeController(IRepositorioAlumnos r, IRepositorioCiclos r2)
        {
            this.datos = r;
            this.datos2 = r2;
        }
        [HttpPost]
        public IActionResult Index(string codigo)
        {
            List<Alumno> lam = new List<Alumno>();
            Ciclo c2 = new Ciclo();
            foreach (var x in datos2.GetCiclos())
            {
                if (x.codigo == codigo)
                {
                    c2 = x;
                }
            }
            foreach (var x in datos.GetAlumnos())
            {
                if (x.Curso == c2.siglas)
                {
                    lam.Add(x);
                }
            }
            ModeloListaAlumnosCurso MLAC = new ModeloListaAlumnosCurso();
            MLAC.curso = c2;
            MLAC.alumnos = lam;
            return View(MLAC);

        }



        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Add(int id)
        {
            Alumno a = new Alumno();
            posicionAlumno = id - 1;
            a.Curso = this.datos2.GetCiclo(posicionAlumno).siglas;
            return View(a);
        }
        [HttpPost]
        public IActionResult Add(Alumno a)
        {
            if (ModelState.IsValid)
            {
                this.datos.addAlumno(a);
                posicionAlumno = 0;
                return RedirectToAction("Index", "Ciclos");
            }
            else
            {
                return View(a);
            }

        }

        public IActionResult Edit(int id)
        {
            posicionAlumno = id - 1;
            return View(this.datos.GetAlumno(id - 1));

        }

        [HttpPost]
        public IActionResult Edit(Alumno a)
        {

            this.datos.GetAlumno(posicionAlumno).Telefono = a.Telefono;
            return RedirectToAction("Index");

        }

        public IActionResult Delete(int id)
        {
            posicionAlumno = id - 1;
            return View(this.datos.GetAlumno(id - 1));
        }
        [HttpPost]
        public IActionResult Delete(Alumno a)
        {
            this.datos.deleteAlumno(posicionAlumno);
            return RedirectToAction("Index");
        }

        public IActionResult Details(int id, string curso)
        {
            ModeloListaId MLI = new ModeloListaId();
            Console.WriteLine(curso);
            MLI.alumno = this.datos.GetAlumno(id - 1);
            MLI.curso = curso;
            return View(MLI);
        }
    }
}
