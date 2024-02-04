using P3Ejercicio2.Interfaces;
using P3Ejercicio2.Models;

namespace P3Ejercicio2.Services
{
    public class RepositorioCiclos : IRepositorioCiclos
    {
        private BBDContext _context;
        public List<Ciclo> ciclos { get; set; }
        public RepositorioCiclos(BBDContext context)
        {

            _context = context;
            ciclos = _context.Ciclos.ToList();

        }
        


        public void addCiclos(Ciclo c)
        {
            _context.Ciclos.Add(c);
            _context.SaveChanges();
        }

        public void eliminciclo(int id)
        {
            var elimiciclo = _context.Ciclos.Find(id);
            _context.Ciclos.Remove(elimiciclo);
            _context.SaveChanges();
        }


        public Ciclo GetCiclo(int id)
        {
            return _context.Ciclos.Find(id);
        }

        public IEnumerable<Ciclo> GetCiclos()
        {
            return ciclos;
        }
    }
}
