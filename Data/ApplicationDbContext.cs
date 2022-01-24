using AppSenaJmoc.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppSenaJmoc.Data
{
    public class ApplicationDbContext :DbContext 
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
                
        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Tecnico> Tecnicos { get; set; }
        public DbSet<Equipo> Equipos { get; set; }
        public DbSet<Proveedor> Proveedores { get; set; }
        public DbSet<Materiales> Materiales1 { get; set; }
        public DbSet<Presupuesto> Presupuestos { get; set; }
        public DbSet<Detalle_presupuesto> detalle_Presupuestos { get; set; }
        public DbSet<Factura> Facturas { get; set; }
        public DbSet<Detalle_factura> detalle_Facturas { get; set; }
    }
}
