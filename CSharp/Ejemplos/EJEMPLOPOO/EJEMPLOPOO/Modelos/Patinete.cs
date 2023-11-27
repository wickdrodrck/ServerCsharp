using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJEMPLOPOO.Modelos
{
    public class Patinete : Vehiculo
    {
        private int nruedas;

        public Patinete(string matricula, double kilometros, double autonomia, string marca, int nruedas) : base(matricula, kilometros, autonomia, marca)
        {
            Nruedas = nruedas;
        }

        public int Nruedas { get => nruedas; set => nruedas = value; }
    }
}
