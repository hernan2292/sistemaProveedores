using cenope.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaDeProveedores.Models
{
    public class Factura : Registro
    {
        public string IdProveedor { get; set; }
        public string OrdenCompra { get; set; }
        public string Iva { get; set; }
        public string ObservacionRechazado { get; set; }
        public string ObservacionDisconformidad { get; set; }
        public string Archivos { get; set; }
        public DateTime FechaCargaDesde { get; set; }
        public DateTime FechaCargaHasta { get; set; }

    }
}
