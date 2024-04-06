using System.ComponentModel.DataAnnotations;

namespace L01P022021CP601.Models
{
    public class materias
    {
        [Key]
        [Display(Name = "ID")]
        public int id { get; set; }
        [Display(Name = "Nombre")]
        public string? materia { get; set; }
        [Display(Name = "Materia")]
        public int? unidades_valorativas { get; set; }
        [Display(Name = "Unidades")]
        public String? estado { get; set; }
    }
}
