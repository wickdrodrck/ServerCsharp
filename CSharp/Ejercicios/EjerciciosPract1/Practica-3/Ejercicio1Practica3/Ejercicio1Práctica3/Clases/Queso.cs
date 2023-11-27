using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1Práctica3.Clases
{
    public class Queso
    {
        string marca;
        string fabric;
        string lote;
        double peso;
        DateTime caducidad;

        public Queso(string marca, string fabric, string lote, double peso, DateTime caducidad)
        {
            this.Marca = marca;
            this.Fabric = fabric;
            this.Lote = lote;
            this.Peso = peso;
            this.Caducidad = caducidad;
        }

        public string Marca { get => marca; set => marca = value; }
        public string Fabric { get => fabric; set => fabric = value; }
        public string Lote { get => lote; set => lote = value; }
        public double Peso { get => peso; set => peso = value; }
        public DateTime Caducidad { get => caducidad; set => caducidad = value; }
    }
}
