using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace FinalAmadis.Data
{
    public class RootProductos
    {
        public string IdProducto { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio...")]
        public string Nombre_producto { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio...")]
        public string Categoria_producto { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio...")]
        public string Foto_producto { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio...")]
        public string Descripcion_producto { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio...")]
        public string Stock { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio...")]
        public string Precio { get; set; }

    }
}
