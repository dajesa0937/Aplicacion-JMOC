using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AppSenaJmoc.Models
{
    public class Cliente
    {
        [Key]
        public int Id_Cliente { get; set; }

        [Required]
        [MaxLength(100)]
        [Display(Name ="Nombre")]
        public string Nombre_Cliente { get; set; }

        [MaxLength(100)]
        [Display(Name ="Apellidos")]
        public string Apellidos_Cliente { get; set; }

        [Display(Name ="Telefono")]
        public string Telefono_Cliente { get; set; }

        [Display(Name ="Email")]
        public string Email_Cliente { get; set; }

        [Display(Name ="Ciudad")]
        public string Ciudad_Cliente { get; set; }
    }
}
