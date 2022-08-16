using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RedSocial.BD.Migrations
{
    public partial class Relaciones : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameIndex(
                name: "IdUsuario_UQ3",
                table: "Usuarios",
                newName: "IdUsuario_UQ4");

            migrationBuilder.AddColumn<int>(
                name: "RelacionId",
                table: "Usuarios",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Relaciones",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idUsuario = table.Column<int>(type: "int", nullable: false),
                    usuarioId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Relaciones", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Relaciones_Usuarios_usuarioId",
                        column: x => x.usuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_RelacionId",
                table: "Usuarios",
                column: "RelacionId");

            migrationBuilder.CreateIndex(
                name: "IdUsuario_UQ3",
                table: "Relaciones",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Relaciones_usuarioId",
                table: "Relaciones",
                column: "usuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Usuarios_Relaciones_RelacionId",
                table: "Usuarios",
                column: "RelacionId",
                principalTable: "Relaciones",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Usuarios_Relaciones_RelacionId",
                table: "Usuarios");

            migrationBuilder.DropTable(
                name: "Relaciones");

            migrationBuilder.DropIndex(
                name: "IX_Usuarios_RelacionId",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "RelacionId",
                table: "Usuarios");

            migrationBuilder.RenameIndex(
                name: "IdUsuario_UQ4",
                table: "Usuarios",
                newName: "IdUsuario_UQ3");
        }
    }
}
