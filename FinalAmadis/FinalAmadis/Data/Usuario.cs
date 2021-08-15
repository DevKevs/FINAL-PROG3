using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalAmadis.Data
{
    public class Usuario
    {
        public string Email { get; set; }
        public string Passw { get; set; }
        public string Rol { get; set; }
    }
    public class DatosUsuarios
    {
        public int IdUsuario { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Fecha_Nacimiento { get; set; }
        public string Rol { get; set; }
        public string Token { get; set; }
    }

    public class RootUsuario
    {
        public bool ok { get; set; }
        public DatosUsuarios Datos_Usuarios { get; set; }
    }
}
