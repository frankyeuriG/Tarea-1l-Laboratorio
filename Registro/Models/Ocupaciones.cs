using System.ComponentModel.DataAnnotations;
namespace Registro.Models
{
    public class Ocupaciones
    {
        [Key]
        public int OcupacionId { get; set; }

        [Required(ErrorMessage ="La descripcion es requerida")]
        public string Descripcion { get; set; }

        [Range(minimum:9000, maximum:2000000, ErrorMessage ="El salario no esta dentro del rango requerido ( entre 9,000 y 2,000,000)")]
        public float? Salario { get; set; }

      

    }
}