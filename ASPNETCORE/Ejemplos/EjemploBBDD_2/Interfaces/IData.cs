using EjemploFormularioValidaciones_2.Models;

namespace EjemploFormularioValidaciones_2.Interfaces
{
    public interface IData
    {
        public Task addData(Data d);
        public  Task<int> isData(string nombre);
        public  Task<IEnumerable<Data>> listAll();

        public Task<Data> findData(string nombre);
        public Task<Data> findData(int ID);

        public  Task updateData(Data d);

        public Task deleteData(int id);
    }
}
