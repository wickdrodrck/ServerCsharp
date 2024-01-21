// HomeController.cs
using Microsoft.AspNetCore.Mvc;
using Practica3_Formularios_Ejercicio2.Servicios;
using Practica3_Formularios_Ejercicio2.Models;

public class HomeController : Controller
{
    private readonly IAficionesService _aficionesService;

    //inyección de independencias
    public HomeController(IAficionesService aficionesService)
    {
        _aficionesService = aficionesService;
    }

    public IActionResult Index()
    {
        var aficiones = _aficionesService.ObtenerAficiones();
        return View(aficiones);
    }

    [HttpPost]
    public IActionResult ProcesarFormulario(string nombre, List<string> aficiones)
    {
        _aficionesService.GuardarAficiones(aficiones);

        string mensaje = _aficionesService.ObtenerMensaje(nombre, aficiones);

        var viewModel = new ResultadoViewModel
        {
            Mensaje = mensaje,
            AficionesElegidas = aficiones
        };

        return View("Resultado", viewModel);
    }

    /*
     GET:

        Utilizado para solicitar datos del servidor.
        Los datos se envían a través de la URL como parámetros de consulta.
        Limitado en la cantidad de datos que puedes enviar (la URL tiene un límite práctico).
        Apropiado para operaciones que no tienen efectos secundarios, como recuperar información, buscar, etc.
        Los datos enviados son visibles en la barra de direcciones del navegador.

     POST:

        Utilizado para enviar datos al servidor para ser procesados.
        Los datos se envían en el cuerpo de la solicitud HTTP.
        No hay límite práctico en la cantidad de datos que puedes enviar.
        Apropiado para operaciones que pueden tener efectos secundarios, como agregar, actualizar o eliminar datos en el servidor.
        Los datos enviados no son visibles en la barra de direcciones.
     */
}
