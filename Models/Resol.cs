using System;
using System.ComponentModel.DataAnnotations;
namespace test.Models
{
    public class Resol
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Digitar un tipo")]
        [StringLength(20)]
        [Required(ErrorMessage = "{0} Es obligatorio.")]
        public string Name { get; set; }
        public Resol()
        {
        }
    }
}