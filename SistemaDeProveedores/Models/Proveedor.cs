using cenope.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace SistemaDeProveedores.Models
{
    public class Proveedor : Registro
    {
        public bool Habilitado { get; set; }
    }
}
