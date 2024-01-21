using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2P3.Clases
{
    public class Pedido
    {
        string tipomasa;
        string ensalada;
        string refresc;
        string[] ingr = { };

        public Pedido(string tipomasa, string ensalada, string refresc, string[] ingr)
        {
            this.Tipomasa = tipomasa;
            this.Ensalada = ensalada;
            this.Refresc = refresc;
            this.Ingr = ingr;
        }

        public string Tipomasa { get => tipomasa; set => tipomasa = value; }
        public string Ensalada { get => ensalada; set => ensalada = value; }
        public string Refresc { get => refresc; set => refresc = value; }
        public string[] Ingr { get => ingr; set => ingr = value; }
    }
}
