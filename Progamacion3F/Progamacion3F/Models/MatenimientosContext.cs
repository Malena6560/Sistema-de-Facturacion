using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Progamacion3F.Models
{
    public class MatenimientosContext:DbContext
    {
        public MatenimientosContext(): base("FinalProg3")
        {

        }

        public DbSet<Productos> Producto { get; set; }
        public DbSet<Clientes> Cliente { get; set; }
        public DbSet<Proveedores> Proveedor { get; set; }
        public DbSet<Factura> Facturas { get; set; }
        public DbSet<DetalleFactura> DetalleFacturas { get; set; }
        public DbSet<Categorias> Categorias { get; set; }
    }
}