// HomeController.cs
using Microsoft.AspNetCore.Mvc;
using Practica3_Formularios_Ejercicio3.Models;
using Practica3_Formularios_Ejercicio3.Servicios;

public class HomeController : Controller
{
    private readonly IPerfilService _perfilService;

    public HomeController(IPerfilService perfilService)
    {
        _perfilService = perfilService;
    }

    public IActionResult Index()
    {
        return View();
        //esto es http get
    }

    [HttpPost]
    public IActionResult ProcesarFormulario(PerfilViewModel perfil)
    {
        if (ModelState.IsValid)
        {
            _perfilService.GuardarPerfil(perfil);
            return RedirectToAction("MostrarPerfil", new {perfil.Nombre});
        }

        // Si el modelo no es válido, vuelve al formulario.
        return View("Index");
    }

    public IActionResult MostrarPerfil(string nombre)
    {
        var perfil = _perfilService.ObtenerPerfil(nombre);

        if (perfil != null)
        {
            return View("Perfil", perfil);
        }

        return RedirectToAction("Index");
    }
}

