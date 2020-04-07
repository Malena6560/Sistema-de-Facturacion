using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Progamacion3F.Models
{
    public class DetalleFactura
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int IDDetalle { get; set; }
        [ForeignKey("IDFactura")]
        public Factura IDFactura { get; set; }
        [ForeignKey("IDProductos")]
        public Productos IDProductos { get; set; }
        [Required]
        public int Cantidad { get; set; }
        [Required]
        public decimal Precio { get; set; }
    }
}