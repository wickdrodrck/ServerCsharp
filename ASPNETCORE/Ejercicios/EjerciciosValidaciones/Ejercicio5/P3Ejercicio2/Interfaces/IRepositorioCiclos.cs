using P3Ejercicio2.Models;

namespace P3Ejercicio2.Interfaces
{
    public interface IRepositorioCiclos
    {
        public IEnumerable<Ciclo> GetCiclos();
        public void addCiclos(Ciclo c);
        public Ciclo GetCiclo(int id);
        public void editCiclos(Ciclo c);
    }
}
