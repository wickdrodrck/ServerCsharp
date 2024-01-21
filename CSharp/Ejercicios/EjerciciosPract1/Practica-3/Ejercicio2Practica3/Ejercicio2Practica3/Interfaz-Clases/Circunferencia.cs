using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2Practica3.Interfaz_Clases
{
    public class Circunferencia : IFigura
    {
        double radio;

        public Circunferencia(double radio)
        {
            this.Radio = radio;
        }

        public double Radio { get => radio; set => radio = value; }

        public double CalcularArea()
        {
            double area = Math.PI * (radio * radio);
            return area;
        }

        public double CalcularPerimetro()
        {
            double perimetr = 2 * radio;
            return perimetr;
        }
    }
}
