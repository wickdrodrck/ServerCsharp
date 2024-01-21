using Pract3Ejercicio2ASP.Models;

namespace Pract3Ejercicio2ASP.Servicios
{
    public class ServicioArray
    {
        public List<Aficion> GetAficiones()
        {
            return new List<Aficion>()
                {
                new Aficion
                {
                    Nombre = "Ajedrez",
                    chequeado = false
                },
                    new Aficion
                    {
                        Nombre = "Piraguismo",
                        chequeado = false
                    }
                    ,
                    new Aficion
                    {
                        Nombre = "Padel",
                        chequeado = false
                    }
                };
        }
    }
    }

