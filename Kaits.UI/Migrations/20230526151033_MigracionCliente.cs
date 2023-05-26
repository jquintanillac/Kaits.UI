using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Kaits.UI.Migrations
{
    /// <inheritdoc />
    public partial class MigracionCliente : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    cod_cliente = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    clie_nomb = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    clie_apell = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    clie_dociden = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    fec_creacion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    user_creacion = table.Column<int>(type: "int", nullable: true),
                    fec_modificacion = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.cod_cliente);
                });

            migrationBuilder.CreateTable(
                name: "Detalle_Pedido",
                columns: table => new
                {
                    Id_detped = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cod_producto = table.Column<int>(type: "int", nullable: false),
                    desc_producto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    detped_cantidad = table.Column<int>(type: "int", nullable: false),
                    detped_precunit = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    detped_subtotal = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    fec_creacion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    user_creacion = table.Column<int>(type: "int", nullable: true),
                    fec_modificacion = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Detalle_Pedido", x => x.Id_detped);
                });

            migrationBuilder.CreateTable(
                name: "Pedido",
                columns: table => new
                {
                    Id_Orden = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ord_fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    cod_cliente = table.Column<int>(type: "int", nullable: false),
                    ord_precio_total = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    fec_creacion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    user_creacion = table.Column<int>(type: "int", nullable: true),
                    fec_modificacion = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pedido", x => x.Id_Orden);
                });

            migrationBuilder.CreateTable(
                name: "Productos",
                columns: table => new
                {
                    cod_producto = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    prod_descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    fec_creacion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    user_creacion = table.Column<int>(type: "int", nullable: true),
                    fec_modificacion = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Productos", x => x.cod_producto);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "Detalle_Pedido");

            migrationBuilder.DropTable(
                name: "Pedido");

            migrationBuilder.DropTable(
                name: "Productos");
        }
    }
}
