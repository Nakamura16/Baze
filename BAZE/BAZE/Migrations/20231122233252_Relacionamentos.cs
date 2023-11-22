using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BAZE.Migrations
{
    /// <inheritdoc />
    public partial class Relacionamentos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bikes_Usuarios_UsuarioId",
                table: "Bikes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Bikes",
                table: "Bikes");

            migrationBuilder.RenameTable(
                name: "Bikes",
                newName: "T_Bike");

            migrationBuilder.RenameIndex(
                name: "IX_Bikes_UsuarioId",
                table: "T_Bike",
                newName: "IX_T_Bike_UsuarioId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_T_Bike",
                table: "T_Bike",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_T_Bike_Usuarios_UsuarioId",
                table: "T_Bike",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_T_Bike_Usuarios_UsuarioId",
                table: "T_Bike");

            migrationBuilder.DropPrimaryKey(
                name: "PK_T_Bike",
                table: "T_Bike");

            migrationBuilder.RenameTable(
                name: "T_Bike",
                newName: "Bikes");

            migrationBuilder.RenameIndex(
                name: "IX_T_Bike_UsuarioId",
                table: "Bikes",
                newName: "IX_Bikes_UsuarioId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Bikes",
                table: "Bikes",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Bikes_Usuarios_UsuarioId",
                table: "Bikes",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
