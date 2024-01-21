using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJEMPLOPOO.Modelos
{
    public class Coche : Vehiculo
    {
        private String modelo;
        private bool electrico;

        public Coche(string matricula, double autonomia, double kilometros, string marca, string modelo, bool electrico) : base( matricula,  autonomia,  kilometros,  marca)
        {
            this.Modelo = modelo;
            this.Electrico = electrico;
        }

        public string Modelo { get => modelo; set => modelo = value; }
        public bool Electrico { get => electrico; set => electrico = value; }
    }
}
