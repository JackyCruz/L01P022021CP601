using System.ComponentModel.DataAnnotations;

namespace L01P022021CP601.Models
{
    public class alumnos
    {
        [Key]
        [Display(Name = "ID")]
        public int id{ get; set; }
        [Display(Name = "Nombre")]
        public String? codigo { get; set; }
        [Display(Name = "Codigo")]
        public string? nombre { get; set; }
        [Display(Name = "Descripción")]
        public string? apellidos { get; set; }
        [Display(Name = "Apellidos")]
        public int? dui { get; set; }
        [Display(Name = "dui")]
        public int? estado { get; set; }
  
    }
}
