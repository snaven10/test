using System;
using System.ComponentModel.DataAnnotations;
namespace test.Models
{
    public class Actividad
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Digitar duracion de llamada")]
        [StringLength(20)]
        [Required(ErrorMessage = "{0} Es obligatorio.")]
        public string Duracion_llamada { get; set; }
        [Display(Name = "Digitar una descripcion")]
        [StringLength(150)]
        public string Descripcion { get; set; }
        public int Id_tipo { get; set; }
        public int Id_resol { get; set; }

    }
}