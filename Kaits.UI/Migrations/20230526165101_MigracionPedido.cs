using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Kaits.UI.Migrations
{
    /// <inheritdoc />
    public partial class MigracionPedido : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Id_Orden",
                table: "Detalle_Pedido",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Id_Orden",
                table: "Detalle_Pedido");
        }
    }
}
