using Microsoft.AspNetCore.Mvc;
using Practica_1.Models;
using System.Diagnostics;

namespace Practica_1.Controllers
{
    public class HomeController : Controller
    {
        HomeViewIndexController hh = new HomeViewIndexController();

        public HomeController(HomeViewIndexController hh)
        {
            this.hh = hh;
        }
        public IActionResult Index()
        {
            hh = new HomeViewIndexController(new Alumno
            {
                nombre :Rodrigo
                aa
                aa
            })
            return View(perso);
        }

        public IActionResult Privacy()
        {
            return View();
        }

    }
}