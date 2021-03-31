using System;
using System.ComponentModel.DataAnnotations;
namespace test.Models
{
    public class Actividad
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Duracion de llamada")]
        [StringLength(20)]
        [Required(ErrorMessage = "{0} Es obligatorio.")]
        public string Duracion_llamada { get; set; }
        [Display(Name = "Descripcion")]
        [Required(ErrorMessage = "{0} Es obligatorio.")]
        [StringLength(150)]
        public string Descripcion { get; set; }
        [StringLength(20)]
        public string Fecha { get; set; }
        [Display(Name = "Tipo actividad")]
        [Required(ErrorMessage = "{0} Es obligatorio.")]
        [StringLength(20)]
        public string Tipo { get; set; }
        [Display(Name = "Resolvio")]
        [Required(ErrorMessage = "{0} Es obligatorio.")]
        [StringLength(20)]
        public string Resolvio { get; set; }
        public string Id_user { get; set; }
    }
}