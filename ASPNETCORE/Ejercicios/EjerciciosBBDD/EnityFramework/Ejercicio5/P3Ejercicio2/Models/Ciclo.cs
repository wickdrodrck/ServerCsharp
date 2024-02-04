using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace P3Ejercicio2.Models
{
    [Table("Ciclos")]
    public class Ciclo
    {
        [Key]
        [Column("Id")]
        public int CicloID { get; set; }
        [Column("codigo")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string codigo { get; set; }
        [Column("siglas")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string siglas { get; set; }
        [Column("nombre")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string nombre { get; set; }
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Column("ncursos")]
        public int ncursos { get; set;}
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Column("aula")]
        public string aula { get; set; }
    }
}
