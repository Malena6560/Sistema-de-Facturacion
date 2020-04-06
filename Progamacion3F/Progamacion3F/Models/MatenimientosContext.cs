using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Progamacion3F.Models
{
    public class MatenimientosContext:DbContext
    {
        
        public DbSet<Productos> Producto { get; set; }
        public DbSet<Clientes> Cliente { get; set; }
        public DbSet<Proveedores> Proveedor { get; set; }
    }
}