using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AppSenaJmoc.Models
{
    public class Detalle_presupuesto
    {
        [Key]
        public int Id_detalle_Presupuesto { get; set; }
        
        [Display(Name ="Cantidad")]

        public int Cantidad_detalle_Presupuesto { get; set; }

        [ForeignKey("Materiales")]
        public int Id_Materiales { get; set; }

        [ForeignKey("Id_Materiales")]
        public virtual Materiales Materiales { get; set; }
    }
}
