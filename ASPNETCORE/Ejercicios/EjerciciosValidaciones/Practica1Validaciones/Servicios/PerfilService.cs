namespace Practica3_Formularios_Ejercicio3.Servicios
{
    using Practica3_Formularios_Ejercicio3.Models;
    using System.Collections.Generic;

    public interface IPerfilService
    {
        void GuardarPerfil(PerfilViewModel perfil);
        PerfilViewModel ObtenerPerfil(string nombre);
    }

    public class PerfilService : IPerfilService
    {
        private static List<PerfilViewModel> perfiles = new List<PerfilViewModel>();

        public void GuardarPerfil(PerfilViewModel perfil)
        {
            perfiles.Add(perfil);
        }

        public PerfilViewModel ObtenerPerfil(string nombre)
        {
            foreach (var perfil in perfiles)
            {
                if (perfil.Nombre == nombre)
                {
                    return perfil;
                }
            }

            return null; // Si no se encuentra el perfil
        }
    }

}
