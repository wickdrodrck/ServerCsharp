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
                new Ciclo { codigo = "CICLO001", siglas = "DAW1", nombre = "Desarrollo Aplicaciones Web", ncursos = 5, aula = "A101" },
                new Ciclo { codigo = "CICLO002", siglas = "ASIR", nombre = "Administracion Sistemas y Redes", ncursos = 4, aula = "A102" },

            };

        }
        public List<Ciclo> ciclos { get; set; }


        public void addCiclos(Ciclo c)
        {
            this.ciclos.Add(c);
        }

        public void editCiclos(Ciclo c)
        {
            for(int x = 0; x< ciclos.Count(); x++)
            {
                if(c.codigo == ciclos[x].codigo)
                {
                    ciclos[x].aula = c.aula;
                }
            };
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
