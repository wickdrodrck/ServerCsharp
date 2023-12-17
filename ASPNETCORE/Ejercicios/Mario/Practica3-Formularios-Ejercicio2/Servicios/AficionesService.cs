namespace Practica3_Formularios_Ejercicio2.Servicios
{
    public interface IAficionesService
    {
        List<string> ObtenerAficiones();
        void GuardarAficiones(List<string> aficiones);
        string ObtenerMensaje(string nombre, List<string> aficiones);
    }

    public class AficionesService : IAficionesService
    {
        private List<string> aficionesElegidas = new List<string>();

        public List<string> ObtenerAficiones()
        {
            // Lista de aficiones disponibles
            return new List<string> { "Fútbol", "Cine", "Música", "Lectura", "Viajes" };
        }

        public void GuardarAficiones(List<string> aficiones)
        {
            aficionesElegidas = aficiones;
        }

        public string ObtenerMensaje(string nombre, List<string> aficiones)
        {
            if (aficiones.Count == 0)
            {
                return $"{nombre}, eres un soso.";
            }
            else if (aficiones.Count == 1)
            {
                return $"{nombre}, deberías buscar más aficiones aparte de \"{aficiones[0]}\".";
            }
            else if (aficiones.Count == 5)
            {
                return $"{nombre}, creo que tienes demasiadas aficiones.";
            }
            else
            {
                return $"{nombre}, has elegido {aficiones.Count} aficiones.";
            }
        }
    }
}
