using SistemaDeProveedores.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cenope.Models
{
    public class Registro
    {
        public Guid Id { get; set; }
        public DateTime FechaCreado { get; set; }
        public DateTime FechaEliminado { get; set; }
        public string IdUsuarioCreado { get; set; }
        public string IdUsuarioEliminado { get; set; }
    }
}
