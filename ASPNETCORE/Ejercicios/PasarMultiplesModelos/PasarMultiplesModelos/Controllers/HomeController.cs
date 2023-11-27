using Microsoft.AspNetCore.Mvc;
using PasarMultiplesModelos.Models;
using System.Diagnostics;

namespace PasarMultiplesModelos.Controllers
{
    public class HomeController : Controller
    {
        List<Alumno> miLista = new List<Alumno>()
            {
                new Alumno()
                {
                    Nombre="Pepito Perez",
                    Telefono = "12345678A",
                    Nota = 7

                },
                new Alumno()
                {
                    Nombre="Anita Dinamita",
                    Telefono="45834958347",
                    Nota = 1
                },
                new Alumno()
                {
                    Nombre = "Fernando Alonso",
                    Telefono= "33333333333333",
                    Nota=33
                }
            };
        public IActionResult Index()
        {
           
            Curso Micurso = new Curso()
            {
                Siglas = "DAW2",
                Aula = "LABORATORIO33",
                Listado = miLista
            };
            return View(Micurso);
        }
        public IActionResult VerAlumnos()
        {
            return View(miLista);
        }
        public IActionResult Privacy()
        {
            return View();
        }

   
    }
}