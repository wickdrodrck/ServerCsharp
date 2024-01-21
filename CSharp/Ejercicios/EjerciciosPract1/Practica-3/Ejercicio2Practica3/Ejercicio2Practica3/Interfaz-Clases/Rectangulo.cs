using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2Practica3.Interfaz_Clases
{
    public class Rectangulo : IFigura
    {
        double largo;
        double ancho;

        public Rectangulo(double largo, double ancho)
        {
            this.Largo = largo;
            this.Ancho = ancho;
        }

        public double Largo { get => largo; set => largo = value; }
        public double Ancho { get => ancho; set => ancho = value; }

        public double CalcularArea()
        {
            double area = largo * ancho;
            return area;
        }

        public double CalcularPerimetro()
        {
            double perimetr = (2 * largo + 2 * ancho)/2;
            return perimetr;
        }
    }
}
