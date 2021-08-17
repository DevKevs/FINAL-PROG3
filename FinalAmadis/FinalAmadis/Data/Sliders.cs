using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalAmadis.Data
{
    public class Sliders
    {
        public int IdSlider { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio...")]
        public string Titulo { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio...")]
        public string Recurso { get; set; }
    }
}
