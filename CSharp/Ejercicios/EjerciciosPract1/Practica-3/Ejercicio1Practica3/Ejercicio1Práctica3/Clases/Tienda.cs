using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1Práctica3.Clases
{
    internal class Tienda
    {
        Queso[] tiendaquesos;

        public Tienda()
        {
            this.Tiendaquesos = new Queso[] { };
        }

        public Queso[] Tiendaquesos { get => tiendaquesos; set => tiendaquesos = value; }
    }
}
