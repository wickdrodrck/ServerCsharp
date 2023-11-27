using ExamenASPNRODRIGO.Models;

namespace ExamenASPNRODRIGO.Servicios
{
    public class ServicioUsu : IServicioUsu
    {
        private List<Usuario> Usuars;

        public ServicioUsu()
        {
            Usuars = new List<Usuario> {
                new Alumno { nombre = "Raul", usuario = "raul123", contra = "popipo14", email = "raulcitoelmaschulito27@correo.algo", curso = 1, Ciclo = EnumCiclo.ASIR, idiomas = new List<string> { "inglés", "francés" } },
                new Alumno { nombre = "Noelia", usuario = "noel.lg", contra = "4114Paris", email = "Noeliaatiendecorreo@correo.algo", curso = 2, Ciclo = EnumCiclo.DAW, idiomas = new List<string> { "aleman", "portugués" } },
                new Profesor { nombre = "Pepe", usuario = "pepitogrillo", contra = "1mas1sondos!", email = "pepeprofeguay@correo.algo", Especialidad = EnumEspecialidad.INFORMATICA},
                new Profesor { nombre = "Felicia", usuario = "Felizyprofe", contra = "M1chiMich!24", email = "feliciateenseña@correo.algo", Especialidad = EnumEspecialidad.MARKETING}
                };
        }

        public List<Alumno> GetAlumnos()
        {
            List<Alumno> listaalumnae = new List<Alumno>();
            foreach(Usuario alum in Usuars)
            {
                if(alum.GetType().Name == "Alumno")
                {
                    listaalumnae.Add((Alumno)alum);
                }
            }
            return listaalumnae;
        }

        public bool isRepetido(string usuario, string contrasenna)
        {
            foreach (Usuario alum in Usuars)
            {
                if (alum.usuario == usuario && alum.contra == contrasenna)
                {
                    return true;
                }
            }
            return false;
        }

        public Usuario isUsuario(string email)
        {
            for (int i = 0; i < Usuars.Count; i++)
            {
                if (Usuars[i].email == email)
                {
                    return Usuars[i];
                }
            }
            return null;
        }

        public Usuario isUsuario(string usuario, string contrasenna)
        {
            for (int i = 0; i < Usuars.Count; i++)
            {
                if (Usuars[i].usuario == usuario && Usuars[i].contra == contrasenna)
                {
                    return Usuars[i];
                }
            }
            return null;
        }

    }
}
