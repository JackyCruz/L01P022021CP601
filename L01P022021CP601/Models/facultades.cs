using System.ComponentModel.DataAnnotations;

namespace L01P022021CP601.Models
{
    public class facultades
    {
        [Key]
        [Display(Name = "ID")]
        public int id { get; set; }
        [Display(Name = "Nombre")]
        public string? facultad { get; set; }

    }
}
