using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalAmadis.Data
{
    public class ExampleModel
    {
        [Required(ErrorMessage = "El campo Cedula es requerido")]
        [StringLength(11, ErrorMessage = "El Cedula es muy largo")]
        public string Cedula { get; set; }
        [Required(ErrorMessage = "El campo Nombre es requerido")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "El campo Apellido es requerido")]
        public string Apellido { get; set; }
        [Required(ErrorMessage = "El campo Fecha de nacimiento es requerido")]
        public string Fecha_Nacimiento { get; set; }
        [Required(ErrorMessage = "El campo Tipo de sangre es requerido")]
        public string Tipo_Sangre { get; set; }
        [Required(ErrorMessage = "El campo Provincia es requerido")]
        public string Provincia { get; set; }
        [Required(ErrorMessage = "El campo Provincia es requerido")]
        public string Telefono { get; set; }
        [Required(ErrorMessage = "El campo Direccion es requerido")]
        public string Direccion { get; set; }
        [Required(ErrorMessage = "El campo Longitud es requerido")]
        public string Longitud { get; set; }
        [Required(ErrorMessage = "El campo Latitud es requerido")]
        public string Latitud { get; set; }
        [Required(ErrorMessage = "El campo Vacunacion es requerido")]
        public string Vacunacion { get; set; }
        [Required(ErrorMessage = "El campo Justificacion es requerido")]
        public string Justificacion { get; set; }
        [Required(ErrorMessage = "El campo Municipio es requerido")]
        public string Municipio { get; set; }
        [Required(ErrorMessage = "El campo Distrito Municipal es requerido")]
        public string Distrito_Municipal { get; set; }
        [Required(ErrorMessage = "El campo Nombre de la calle es requerido")]
        public string Nombre_Calle { get; set; }
        [Required(ErrorMessage = "El campo Numero de la calle es requerido")]
        public string No_Calle { get; set; }
        [Required(ErrorMessage = "El campo numero de la casa es requerido")]
        public string No_Casa { get; set; }
    }
}
