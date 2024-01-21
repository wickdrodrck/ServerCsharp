using P3Ejercicio2.Interfaces;
using P3Ejercicio2.Models;

namespace P3Ejercicio2.Services
{
    public class RepositorioCiclos : IRepositorioCiclos
    {
        public RepositorioCiclos()
        {

            ciclos = new List<Ciclo>
            {
                new Ciclo { codigo = "CICLO001", siglas = "DAW1", nombre = "Desarrollo Aplicaciones Web", ncursos = 5, aula = "A101", alumnos = new List<Alumno>() },
                new Ciclo { codigo = "CICLO002", siglas = "ASIR", nombre = "Administracion Sistemas y Redes", ncursos = 4, aula = "A102", alumnos = new List<Alumno>() },

            };

        }
        public List<Ciclo> ciclos { get; set; }


        public void addCiclos(Ciclo c)
        {
            this.ciclos.Add(c);
        }



        public Ciclo GetCiclo(int id)
        {
            return this.ciclos[id];
        }

        public IEnumerable<Ciclo> GetCiclos()
        {
            return ciclos;
        }
    }
}
