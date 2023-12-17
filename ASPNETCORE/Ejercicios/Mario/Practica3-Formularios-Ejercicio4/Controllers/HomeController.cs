using Microsoft.AspNetCore.Mvc;
using Practica3_Formularios_Ejercicio4.Models;
using Practica3_Formularios_Ejercicio4.Servicios;

public class HomeController : Controller
{
    private readonly ICharlaService charlaService;

    public HomeController(ICharlaService charlaService)
    {
        this.charlaService = charlaService;
    }

    public ActionResult Index()
    {
        var model = new CharlaViewModel
        {
            Fecha = DateTime.Now,
            Texto = "Se organiza una charla con profesionales del mundo del Desarrollo."
        };
        return View(model);
    }

    public ActionResult Confirmacion()
    {
        return View(new Alumno());
    }

    [HttpPost]
    public ActionResult Confirmacion(Alumno viewModel)
    {
        if (ModelState.IsValid)
        {
            var alumno = new Alumno
            {
                Nombre = viewModel.Nombre,
                Curso = viewModel.Curso,
                Email = viewModel.Email,
                Asistira = viewModel.Asistira
            };

            charlaService.RegistrarAsistencia(alumno);

            string mensaje;

            if (alumno.Asistira)
            {
                mensaje = "Gracias por confirmar tu asistencia.";
            }
            else
            {
                mensaje = "Lamentamos que no puedas asistir.";
            }

            return RedirectToAction("Agradecimiento", new AgradecimientoViewModel
            {
                Nombre = alumno.Nombre,
                Mensaje = mensaje
            });
        }
        else
        {
           return View(viewModel);
        }

        
    }

    public ActionResult Agradecimiento(AgradecimientoViewModel viewModel)
    {
        return View(viewModel);
    }
}

