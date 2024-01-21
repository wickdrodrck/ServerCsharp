using System.ComponentModel.DataAnnotations;

namespace P3Ejercicio2.Models
{
    public class Ciclo
    {
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string codigo { get; set; }
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string siglas { get; set; }
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string nombre { get; set; }
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public int ncursos { get; set;}
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string aula { get; set; }
    }
}
