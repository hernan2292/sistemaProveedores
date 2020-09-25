using cenope.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaDeProveedores.Models
{
    public class Usuario : Registro
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Uid { get; set; }
        public string Email { get; set; }
        public string Rol { get; set; }
        public string Password { get; set; }
    }
}
