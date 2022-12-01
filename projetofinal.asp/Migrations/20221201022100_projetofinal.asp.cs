using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace projetofinal.asp.Migrations
{
    /// <inheritdoc />
    public partial class projetofinalasp : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IdConsumidor",
                table: "Consumidors",
                newName: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Consumidors",
                newName: "IdConsumidor");
        }
    }
}
