using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2Practica3.Interfaz_Clases
{
    public class TrianguloEquilatero : IFigura
    {
        double lado;

        public TrianguloEquilatero(double lado)
        {
            this.Lado = lado;
        }

        public double Lado { get => lado; set => lado = value; }

        public double CalcularArea()
        {
            double are = (lado * lado) / 2;
            return are;
        }

        public double CalcularPerimetro()
        {
            double perimetro = lado * 3;
            return perimetro;
        }
    }
}
