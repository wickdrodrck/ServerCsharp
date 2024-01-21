using System.ComponentModel.DataAnnotations;

namespace EjemploFormularioValidaciones_2.Models
{
    public class Data
    {
        [Required]
        public int ID { get; set; }

        [Required(ErrorMessage ="El campo {0} es obligatorio")]
        public String Nombre{get;set;}

        [Required(ErrorMessage ="El campo {0} es obligatorio")]
        [Range(18,60,ErrorMessage ="El campo {0} debe estar entre{1} - {2}")]
        public int Edad { get; set; }   

        [Required]
        public string Ciclo { get; set; }

        [Required]
        public string Ingles { get; set; }
    }
}
