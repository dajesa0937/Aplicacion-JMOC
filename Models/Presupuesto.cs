using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AppSenaJmoc.Models
{
    public class Presupuesto
    {
        [Key]
        public int Id_Presupuesto { get; set; }

        [Required]
        [MaxLength(100)]
        [Display(Name ="Total a Pagar")]
        public int Total_Pagar_Presupuesto { get; set; }

        [Display(Name ="Hora")]
        public DateTime Hora_Presupuesto { get; set; }

        [Display(Name ="Fecha")]
        public DateTime Fecha_presupuesto { get; set; }

        [ForeignKey("Equipo")]
        public int Id_Equipo { get; set; }

        [ForeignKey("Id_Equipo")]
        public virtual Equipo Equipo { get; set; }

        [ForeignKey("Tecnico")]
        public int Id_Tecnico { get; set; }

        [ForeignKey("Id_Tecnico")]
        public virtual Tecnico Tecnico { get; set; }

        [ForeignKey("Detalle_presupuesto")]
        public int Id_detalle_Presupuesto { get; set; }

        [ForeignKey("Id_detalle_Presupuesto")]
        public virtual Detalle_presupuesto Detalle_presupuesto { get; set; }
    }
}
