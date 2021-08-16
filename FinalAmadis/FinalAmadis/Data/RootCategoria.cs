using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace FinalAmadis.Data
{
    public class RootCategoria
    {
        public string IdCategoria { get; set; }
        
        [Required(ErrorMessage = "Este campo es obligatorio...")]
        public string Nombre_categoria { get; set; }
    }
}
