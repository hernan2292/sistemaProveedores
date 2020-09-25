using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using SistemaDeProveedores.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cenope.Models
{
    public class SistemaProveedoresContextClass : DbContext
    {
        public SistemaProveedoresContextClass(DbContextOptions<SistemaProveedoresContextClass> options)
            : base(options)
        {
        }

        public DbSet<Factura> Facturas { get; set; }
        public DbSet<FacturaEstado> FacturasEstados { get; set; }
        public DbSet<FacturaEstadoActualizado> FacturasEstadosActualizados { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<ProductoFactura> ProductosFacturas { get; set; }
        public DbSet<Proveedor> Proveedores { get; set; }
        public DbSet<Registro> Registros { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

    }
}
