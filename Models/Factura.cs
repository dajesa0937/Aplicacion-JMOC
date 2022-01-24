using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AppSenaJmoc.Models
{
    public class Factura
    {
        [Key]
        public int Id_factura { get; set; }


        [Display(Name ="Total a Pagar")]
        public string Total_pagar_factura { get; set; }

        [ForeignKey("Equipo")]
        public int Id_Equipo { get; set; }

        [ForeignKey("Id_Equipo")]
        public virtual Equipo Equipo { get; set; }


        [ForeignKey("Tecnico")]
        public int Id_Tecnico { get; set; }

        [ForeignKey("Id_Tecnico")]
        public virtual Tecnico Tecnico { get; set; }



        [ForeignKey("Detalle_factura")]
        public int Id_Detalle_factura { get; set; }

        [ForeignKey("Id_Detalle_factura")]
        public virtual Detalle_factura Detalle_factura { get; set; }

    }
}
