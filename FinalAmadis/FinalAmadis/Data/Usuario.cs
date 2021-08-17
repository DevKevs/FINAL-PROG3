using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace FinalAmadis.Data
{
    public class Usuario
    {
        [Required(ErrorMessage = "Correo requerido")]
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "Debes indicar un email válido")]
        public string Correo { get; set; }
        
        [Required(ErrorMessage = "Contraseña requerida")]
        public string Contraseña { get; set; }
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
