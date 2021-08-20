using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalAmadis.Data
{
    public class Pago
    {
        public string IdUsuario { get; set; }
        [Required(ErrorMessage = "El campo es requerido")]
        public string Telefono { get; set; }
        [Required(ErrorMessage = "El campo es requerido")]
        public string Total { get; set; }
        [Required(ErrorMessage = "El campo es requerido")]
        public string Direccion { get; set; }
        [Required(ErrorMessage = "El campo es requerido")]
        public string Latitud { get; set; }
        [Required(ErrorMessage = "El campo es requerido")]
        public string Longitud { get; set; }
        [Required(ErrorMessage = "El campo Provincia es requerido")]
        public string Provincia { get; set; }
        public string Municipio { get; set; }
        [Required(ErrorMessage = "El campo Distrito Municipal es requerido")]
        public string Distrito_Municipal { get; set; }
        [Required(ErrorMessage = "El campo Nombre de la calle es requerido")]
        public string Nombre_Calle { get; set; }
        [Required(ErrorMessage = "El campo Numero de la calle es requerido")]
        public string No_Calle { get; set; }
        [Required(ErrorMessage = "El campo numero de la casa es requerido")]
        public string No_Casa { get; set; }
        public string Estado { get; set; }

    }
}
