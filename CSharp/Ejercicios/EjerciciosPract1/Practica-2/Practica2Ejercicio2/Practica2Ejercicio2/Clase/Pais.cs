using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2Ejercicio2.Clase
{
    public class Pais
    {
        String nombrePais;
        String saludo;

        public Pais(string nombrePais, string saludo)
        {
            this.NombrePais = nombrePais;
            this.Saludo = saludo;
        }

        public string NombrePais { get => nombrePais; set => nombrePais = value; }
        public string Saludo { get => saludo; set => saludo = value; }
    }
}
