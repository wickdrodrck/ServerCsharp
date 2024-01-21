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


        public DataBBDDService(IConfiguration config)
        {
            this.connectionString = config.GetConnectionString("DefaultConnection");

        }

        public async Task addData(Data d) //es como retornar void
        {
            connection = new SqlConnection(this.connectionString);
            await connection.ExecuteAsync("Añadir_Registro", 
                new {nombre=d.Nombre,edad=d.Edad},
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

        public async Task<Data> findData(string nombre)
        {
            string sql = @"SELECT * FROM Datos WHERE Nombre=@Nombre";
            connection = new SqlConnection(this.connectionString);
            Data d = await connection.QueryFirstOrDefaultAsync<Data>(sql, new { nombre });
            return d;
        }

        public async Task<Data> findData(int  ID)
        {
            string sql = @"SELECT * FROM Datos WHERE Id=@Id";
            connection = new SqlConnection(this.connectionString);
            Data d = await connection.QueryFirstOrDefaultAsync<Data>(sql, new { ID });
            return d;
        }
        public async Task updateData(Data d)
        {
            string sql = @"UPDATE Datos SET Edad=@Edad WHERE Id=@ID";
            connection = new SqlConnection(this.connectionString);
            await connection.ExecuteAsync(sql, d);
        }

        public async Task deleteData(int id)
        {
            string sql = @"DELETE  FROM Datos WHERE Id=@Id";
            connection = new SqlConnection(this.connectionString);
            await connection.ExecuteAsync(sql, new { id });
        }
        

        
    }
}
