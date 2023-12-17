using System.ComponentModel.DataAnnotations;

namespace Practica3_Formularios_Ejercicio4.Models
{
    public class Alumno
    {
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Curso { get; set; }
        [Required, EmailAddress]
        public string Email { get; set; }
        [Required, Range(18,40)]
        public int Edad { get; set; }
        [Required]
        public bool Asistira { get; set; }
    }
}
