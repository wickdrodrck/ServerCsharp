using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1Práctica3.Clases
{
    public class Almacen
    {
        Queso[] almacenquesos;

        public Almacen()
        {
            this.Almacenquesos = new Queso[] {};
        }

        public Queso[] Almacenquesos { get => almacenquesos; set => almacenquesos = value; }
    }
}
