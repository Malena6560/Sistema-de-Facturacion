using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Progamacion3F.Models
{
    public class Clientes
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int IDClientes { get; set; }
        [Required]
        public int RNC { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Telefono { get; set; }
        public string Email { get; set; }
        public int IDCategoria { get; set; }

        [ForeignKey("IDCategoria")]
        public Categorias Categoria { get; set; }
    }
}