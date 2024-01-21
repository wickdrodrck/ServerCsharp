
using Microsoft.AspNetCore.Mvc.Rendering;

namespace EjemploFormularioValidaciones_2.Models
{
    public class DataViewModel:Data
    {
        public IEnumerable<SelectListItem>? Ciclos { get; set; }

        public IEnumerable<string>? NivelIngles { get; set; }

    }
}
