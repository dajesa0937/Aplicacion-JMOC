using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AppSenaJmoc.Models
{
    public class Detalle_factura
    {
        [Key]
        public int Id_Detalle_factura { get; set; }

        [Display(Name ="Cantidad")]
        public string Cantidad_Detalle { get; set; }

        [ForeignKey("Materiales")]
        public int Id_Materiales { get; set; }

        [ForeignKey("Id_Materiales")]
        public virtual Materiales Materiales { get; set; }
    }
}
