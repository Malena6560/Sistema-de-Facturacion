using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Progamacion3F.Models
{
    public class Proveedores
    {
        public int ID { get; set; }
        public int RNC { get; set; }
        public string Nombre { get; set; }
        public int Telefono { get; set; }
        public string Email { get; set; }
    }
}