using cenope.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaDeProveedores.Models
{
    public class Producto : Registro
    {
        public string Nombre { get; set; }
        public string Codigo { get; set; }
    }
}
