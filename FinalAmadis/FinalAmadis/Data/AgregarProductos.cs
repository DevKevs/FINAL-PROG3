using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalAmadis.Data
{
    public class AgregarProductos
    {
        public int IdUsuarios { get; set; }
        public int IdProducto { get; set; }
        public string Nombre_producto { get; set; }
        public string Cantidad { get; set; }
        public string Suma_total { get; set; }
        public string Categoria { get; set; }
        public string Descripcion { get; set; }
        public string Foto { get; set; }
        public string N_Stock { get; set; }
    }
}
