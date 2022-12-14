using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace RegistroPersona.Models
{
    public class Personas{

        [Key]
        public int PersonaId {get; set;}

       [Required(ErrorMessage ="Es obligatorio introducir el nombre")]
        public string Nombres { get; set; }

        [Required(ErrorMessage ="Es obligatorio el Correo")]
        public string Email { get; set; }
        
         [Required(ErrorMessage ="Es obligatorio la Direccion")]
        public string Direccion { get; set; }

        [Required(ErrorMessage = "Complete este Campo")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd-MM-yyyy}")]
        public DateTime? FechaNacimiento { get; set; }

        public string Telefono {get; set;}

        public int OcupacionId{get; set;}
    }

  
}