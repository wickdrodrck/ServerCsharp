using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploColecciones.Modelos
{
    public class Alumno
    {

        private String nombre;
        private String dni;
        private int edad;
        private String imagen;

        public Alumno(string nombre, string dni, int edad)
        {
            this.Nombre = nombre;
            this.Dni = dni;
            this.Edad = edad;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Dni { get => dni; set => dni = value; }
        public int Edad { get => edad; set => edad = value; }
        public string Imagen { get => imagen; set => imagen = value; }

        public void cumpleAnos()
        {
            this.edad++;
        }
    }
}
