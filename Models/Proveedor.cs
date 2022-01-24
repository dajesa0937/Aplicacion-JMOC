using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AppSenaJmoc.Models
{
    public class Proveedor
    {
        [Key]
        public int Id_Proveedor { get; set; }

        [Required]
        [MaxLength(100)]
        [Display(Name ="Nombre")]
        public string Nombre_Provedor { get; set; }

        [Required]
        [MaxLength(100)]
        [Display(Name = "Direccion")]
        public string Direccion_Proveedor { get; set; }


        [Required]
        [MaxLength(100)]
        [Display(Name ="Telefono")]
        public string Telefono_Proveedor  { get; set; }

        [Required]
        [MaxLength(100)]
        [Display(Name ="Email")]
        public string Email_Proveedor { get; set; }

        [Required]
        [MaxLength(100)]
        [Display(Name = "Ciudad")]
        public string Ciudad_Proveedor { get; set; }
    }
}
