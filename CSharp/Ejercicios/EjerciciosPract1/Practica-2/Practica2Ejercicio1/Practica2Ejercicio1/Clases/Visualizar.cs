using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2Ejercicio1.Clases
{
    public class Visualizar
    {
        List<Usuario> usuarray;
        public Visualizar()
        {
            usuarray = new List<Usuario>();
        }

        public void añadir(string nomb, string ape, int edad, string dni)
        {
            usuarray.Append(new Usuario(nomb,ape,edad,dni));
        }

        public List<Usuario> devolverArray()
        {
            return usuarray;
        }
    }
}
