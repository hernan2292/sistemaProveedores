using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaDeProveedores.Models
{
    public class ProductoFactura
    {
        public Guid Id { get; set; }
        public string IdFactura { get; set; }
        public string IdProducto { get; set; }
        public float Cantidad { get; set; }
    }
}
