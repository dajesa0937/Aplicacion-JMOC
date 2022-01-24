using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AppSenaJmoc.Models
{
    public class Equipo
    {
        [Key]
        public int Id_Equipo { get; set; }
        
        [Required]
        [MaxLength(100)]
        [Display(Name ="Marca")]
        public string Marca_Equipo { get; set; }

        [Required]
        [MaxLength(100)]
        [Display(Name ="Tipo")]
        public string Tipo_Cliente { get; set; }

        [Required]
        [MaxLength(100)]
        [Display(Name ="Serie")]
        public string Serie_Equipo { get; set; }

        [ForeignKey("Cliente")]
        public int Id_Cliente { get;set; }

        [ForeignKey("Id_Cliente")]
        public virtual Cliente Cliente { get; set; }
    }
}
