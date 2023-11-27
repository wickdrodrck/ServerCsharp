using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2P3.Clases
{
    public class Mesa
    {
        int numermesa;
        Pedido pedidom;

        

        public Mesa(int numermesa, Pedido pedidom)
        {
            this.Numermesa = numermesa;
            this.Pedidom = pedidom;
        }

        public int Numermesa { get => numermesa; set => numermesa = value; }
        internal Pedido Pedidom { get => pedidom; set => pedidom = value; }
    }
}
