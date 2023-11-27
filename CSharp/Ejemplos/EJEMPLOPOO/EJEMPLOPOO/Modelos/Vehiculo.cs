using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJEMPLOPOO.Modelos
{
    public class Vehiculo
    {
        private String matricula;
        private double kilometros;
        private double autonomia;
        private String marca;
        private DateTime fechaMatriculacion;

        public Vehiculo(string matricula, double kilometros, double autonomia, string marca)
        {
            this.matricula = matricula;
            this.kilometros = kilometros;
            this.autonomia = autonomia;
            this.marca = marca;
        }

        public string Matricula { get => matricula; set => matricula = value; }
        public double Kilometros { get => kilometros; set => kilometros = value; }
        public double Autonomia { get => autonomia; set => autonomia = value; }
        public string Marca { get => marca; set => marca = value; }
    }
}
