using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SistemaDeProveedores.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FacturasEstadosActualizados",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    IdUsuario = table.Column<string>(nullable: true),
                    IdFactura = table.Column<string>(nullable: true),
                    IdEstado = table.Column<string>(nullable: true),
                    Fecha = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FacturasEstadosActualizados", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductosFacturas",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    IdFactura = table.Column<string>(nullable: true),
                    IdProducto = table.Column<string>(nullable: true),
                    Cantidad = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductosFacturas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Registros",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    FechaCreado = table.Column<DateTime>(nullable: false),
                    FechaEliminado = table.Column<DateTime>(nullable: false),
                    IdUsuarioCreado = table.Column<string>(nullable: true),
                    IdUsuarioEliminado = table.Column<string>(nullable: true),
                    Discriminator = table.Column<string>(nullable: false),
                    IdProveedor = table.Column<string>(nullable: true),
                    OrdenCompra = table.Column<string>(nullable: true),
                    Iva = table.Column<string>(nullable: true),
                    ObservacionRechazado = table.Column<string>(nullable: true),
                    ObservacionDisconformidad = table.Column<string>(nullable: true),
                    Archivos = table.Column<string>(nullable: true),
                    FechaCargaDesde = table.Column<DateTime>(nullable: true),
                    FechaCargaHasta = table.Column<DateTime>(nullable: true),
                    Label = table.Column<string>(nullable: true),
                    Nombre = table.Column<string>(nullable: true),
                    Codigo = table.Column<string>(nullable: true),
                    Habilitado = table.Column<bool>(nullable: true),
                    Usuario_Nombre = table.Column<string>(nullable: true),
                    Apellido = table.Column<string>(nullable: true),
                    Uid = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Rol = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Registros", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FacturasEstadosActualizados");

            migrationBuilder.DropTable(
                name: "ProductosFacturas");

            migrationBuilder.DropTable(
                name: "Registros");
        }
    }
}
