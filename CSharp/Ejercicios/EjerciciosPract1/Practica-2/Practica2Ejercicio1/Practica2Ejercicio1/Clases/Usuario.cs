using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Practica2Ejercicio1.Clases
{
    public class Usuario
    {
        string nomb;
        string apel;
        int edad;
        string DNI;

        public Usuario(string nomb, string apel, int edad, string dNI)
        {
            this.Nomb = nomb;
            this.Apel = apel;
            this.Edad = edad;
            DNI1 = dNI;
        }

        public string Nomb { get => nomb; set => nomb = value; }
        public string Apel { get => apel; set => apel = value; }
        public int Edad { get => edad; set => edad = value; }
        public string DNI1 { get => DNI; set => DNI = value; }
    }
}
