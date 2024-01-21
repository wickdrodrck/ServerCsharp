using Dapper;
using EjemploFormularioValidaciones_2.Interfaces;
using EjemploFormularioValidaciones_2.Models;
using Microsoft.Data.SqlClient;

namespace EjemploFormularioValidaciones_2.Services
{
    public class DataBBDDService : IData
    {
        private readonly string connectionString;
        private SqlConnection connection;
        public static IEnumerable<string> nIngles = new List<string>() { "Bajo", "Medio", "Alto" };
        private IEnumerable<string> lCiclos;

        public DataBBDDService(IConfiguration config)
        {
            this.connectionString = config.GetConnectionString("DefaultConnection");
            this.lCiclos = listAllCiclos();
        }

        //Como no añadimos ciclos, vamos a suponer que no habrá variaciones en operaciones muy seguidas....
        //Por tanto no los sacamos de la bbdd cada vez que llamamos a un método sino al principio de instanciar el servicio
        public IEnumerable<string> getCiclos()
        {
            return this.lCiclos;
        }

        public async Task addData(Data d) //es como retornar void
        {
            connection = new SqlConnection(this.connectionString);
            await connection.ExecuteAsync("Añadir_Registro", 
                new {nombre=d.Nombre,edad=d.Edad, ciclo=d.Ciclo},
                commandType:System.Data.CommandType.StoredProcedure);
           
            
        }

        //public async Task addData(Data d) //es como retornar void
        //{
        //    string sql = @"INSERT INTO Datos (Nombre, Edad) Values(@Nombre, @Edad);";
        //    connection = new SqlConnection(this.connectionString);
        //    await connection.ExecuteAsync(sql, d);

        //}

        public async Task<int> isData(string nombre)
        {
            string sql = @"SELECT 1 FROM Datos WHERE Nombre=@Nombre";
            connection = new SqlConnection(this.connectionString);
            int result=await connection.QueryFirstOrDefaultAsync<int>(sql, new {nombre});
            return result ;
        }


        public async Task<IEnumerable<Data>> listAll()
        {
            string sql = @"SELECT * FROM Datos";
            connection = new SqlConnection(this.connectionString);
            return await connection.QueryAsync<Data>(sql);
        }


        public async Task<Data> findData(int  ID)
        {
            string sql = @"SELECT * FROM Datos WHERE Id=@Id";
            connection = new SqlConnection(this.connectionString);
            Data d = await connection.QueryFirstOrDefaultAsync<Data>(sql, new { ID });
            return d;
        }
        public async Task updateData(DataViewModel d)
        {
            string sql = @"UPDATE Datos SET Edad=@Edad, Ciclo=@Ciclo WHERE Id=@ID";
            connection = new SqlConnection(this.connectionString);
            await connection.ExecuteAsync(sql, d);
        }

        public async Task deleteData(int id)
        {
            string sql = @"DELETE  FROM Datos WHERE Id=@Id";
            connection = new SqlConnection(this.connectionString);
            await connection.ExecuteAsync(sql, new { id });
        }
        
        public IEnumerable<String> listAllCiclos()
        {
            string sql = @"SELECT siglas FROM Ciclos";
            connection = new SqlConnection(this.connectionString);
            return  connection.Query<String>(sql);
        }
        
        //public IEnumerable<string> listNivelIngles()
        //{
        //    IEnumerable<string> n =new List<string>() { "Bajo", "Medio", "Alto" };
        //    return n;
        //}
    }
}
