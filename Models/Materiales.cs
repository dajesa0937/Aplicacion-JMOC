using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AppSenaJmoc.Models
{
    public class Materiales
    {
        [Key]
        public int Id_Materiales { get; set; }

        [Required]
        [MaxLength(100)]
        [Display(Name = "Nombre")]
        public string Nombre_Materiales { get; set; }

        [Required]
        [MaxLength(100)]
        [Display(Name = "Descripcion")]
        public string Descripcion_materiales { get; set; }

        [Required]
        [MaxLength(100)]
        [Display(Name = "Precio")]
        public string Precio_Materiales { get; set; }

        [Required]
        [MaxLength(100)]
        [Display(Name = "Existencias")]
        public int Existencias_Materiales { get; set; }



        [ForeignKey("Proveedor")]
        public int Id_Proveedor { get; set; }

        [ForeignKey("Id_Proveedor")]
        public virtual Proveedor Proveedor { get; set; }

    } 
}