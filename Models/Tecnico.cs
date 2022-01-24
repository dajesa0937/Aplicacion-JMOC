using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AppSenaJmoc.Models
{
    public class Tecnico
    {
        [Key]
        public int Id_Tecnico { get; set; }

        [Required]
        [MaxLength(100)]
        [Display(Name ="Nombre")]
        public string Nombre_Tecnico { get; set; }
        
        [Required]
        [MaxLength(100)]
        [Display(Name ="Apellidos")]
        public string Apellidos_Tecnico { get; set; }

        [Required]
        [MaxLength(100)]
        [Display(Name ="Telefono")]
        public string Telefono_Tecnico { get; set; }

        [Required]
        [MaxLength(100)]
        [Display(Name ="Email")]
        public string Email_Tecnico { get; set; }

        [Required]
        [MaxLength(100)]
        [Display(Name ="Ciudad")]
        public string Ciudad_Tecnico { get; set; }
    }
}
