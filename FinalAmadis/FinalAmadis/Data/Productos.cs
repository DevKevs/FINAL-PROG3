using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalAmadis.Data
{
    public class RootProductos
    {
        public int IdProducto { get; set; }
        public string Nombre_producto { get; set; }
        public string Categoria_producto { get; set; }
        public string Foto_producto { get; set; }
        public string Descripcion_producto { get; set; }
        public string Stock { get; set; }
        public string Precio { get; set; }
    }
}
