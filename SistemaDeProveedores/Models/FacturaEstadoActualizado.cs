using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaDeProveedores.Models
{
    public class FacturaEstadoActualizado
    {
        [Key]
        public Guid Id { get; set; }
        public string IdUsuario { get; set; }
        public string IdFactura { get; set; }
        public string IdEstado { get; set; }
        public DateTime Fecha { get; set; }
    }
}
