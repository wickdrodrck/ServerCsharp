using Dapper;
using EjemploFormularioValidaciones_2.Interfaces;
using EjemploFormularioValidaciones_2.Models;
using EjemploFormularioValidaciones_2.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Data.SqlClient;
using System.Diagnostics;

namespace EjemploFormularioValidaciones_2.Controllers
{
    public class HomeController : Controller
    {


        private readonly IData datos;
       

        public  HomeController(IData d)
        {
            this.datos = d;
           
            
        }
        public IActionResult Index()
        {
              
              return View();
        }


        public async Task<IActionResult> AddData()
        {
            DataViewModel dt = new DataViewModel();
            IEnumerable<String> l = this.datos.getCiclos();
            IEnumerable<string> n = DataBBDDService.nIngles;
            dt.Ciclos = l.Select(item=>new SelectListItem(item,item));
            dt.NivelIngles = n;
            return View(dt);
        }

        [HttpPost]
        public async Task<IActionResult> AddData(DataViewModel d)
        {
            if (!ModelState.IsValid)
                return View("AddData", d);

            //Con este código evitamos que al refrescar la URL nos introduzcan una persona repetida
            //o bien que la repetición se de al introducir los datos
            if (await this.datos.isData(d.Nombre) == 1)
            {
                ModelState.AddModelError(nameof(d.Nombre), $"El nombre {d.Nombre} ya existe");
                //El $ es para que interprete d.Nombre como variable y no como texto
                //nameof es el nombre del campo al que le aplicamos el error
                //El segundo parámetro es la cadena que queremos que aparezca

                IEnumerable<String> l = this.datos.getCiclos();
                IEnumerable<string> n = DataBBDDService.nIngles;
                d.Ciclos = l.Select(item => new SelectListItem
                {
                    Text = item,
                    Value = item,
                    Selected = item == d.Ciclo

                });
                d.NivelIngles = n;
                return View(d);
            }
            await datos.addData(d);
            return RedirectToAction("ListAll");
        }


        public async Task<IActionResult> ListAll()
        {
          IEnumerable<Data> l= await datos.listAll();
          return View(l);
        }

        [HttpGet]
        public async Task<IActionResult> UpdateData(int ID)
        {
            Data d = await this.datos.findData(ID);

            if (d is null)
                return RedirectToAction("Index");
            DataViewModel dt = new DataViewModel { Nombre = d.Nombre, Edad = d.Edad, ID = d.ID };
            IEnumerable<String> l = this.datos.getCiclos();
            dt.Ciclos = l.Select(item => new SelectListItem
            {
                Text=item,
                Value=item,
                Selected=item==d.Ciclo
                 
            }    );

            return View(dt);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateData(DataViewModel d)
        {
            await this.datos.updateData(d);
            return RedirectToAction("ListAll");
        }

       

        public async Task<IActionResult> DeleteData(int id)
        {
            await this.datos.deleteData(id);
            return RedirectToAction("ListAll");
        }








        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}