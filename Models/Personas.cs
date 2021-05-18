using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Tarea2_Primer_Registro_Blazor.Models
{
    public class Personas
    {
        [Key]

        [Required(ErrorMessage = "No debe de estar Vacío el campo 'PersonaId'")]
        public int PersonaId { get; set; }

        [Required(ErrorMessage = "No debe de estar Vacío el campo 'Nombre'")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "No debe de estar Vacío el campo 'Telefono'")]
        public string Telefono { get; set; }

        [Required(ErrorMessage = "No debe de estar Vacío el campo 'Cedula'")]
        public string Cedula { get; set; }

        [Required(ErrorMessage = "No debe de estar Vacío el campo 'Direccion'")]
        public string Direccion { get; set; }

        [Required(ErrorMessage = "No debe de estar Vacío el campo 'Telefono'")]
        [DisplayFormat(DataFormatString = "{0:dd,mm,yyyy}")]
        public DateTime FechaNacimiento { get; set; }
    }
}
