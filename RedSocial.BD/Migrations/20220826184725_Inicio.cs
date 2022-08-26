using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RedSocial.BD.Migrations
{
    public partial class Inicio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Estadisticas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estadisticas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Publicaciones",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    contenidoPublicacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    fechaPublicacion = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Publicaciones", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Rankings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rankings", x => x.Id);
                });

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
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PasswordHash = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    PasswordSalt = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    ImgPerfil = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImgPortada = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RelacionId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Usuarios_Relaciones_RelacionId",
                        column: x => x.RelacionId,
                        principalTable: "Relaciones",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IdUsuario_UQ",
                table: "Estadisticas",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IdUsuario_UQ1",
                table: "Publicaciones",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IdUsuario_UQ2",
                table: "Rankings",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IdUsuario_UQ3",
                table: "Relaciones",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Relaciones_usuarioId",
                table: "Relaciones",
                column: "usuarioId");

            migrationBuilder.CreateIndex(
                name: "IdUsuario_UQ4",
                table: "Usuarios",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_RelacionId",
                table: "Usuarios",
                column: "RelacionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Relaciones_Usuarios_usuarioId",
                table: "Relaciones",
                column: "usuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Relaciones_Usuarios_usuarioId",
                table: "Relaciones");

            migrationBuilder.DropTable(
                name: "Estadisticas");

            migrationBuilder.DropTable(
                name: "Publicaciones");

            migrationBuilder.DropTable(
                name: "Rankings");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "Relaciones");
        }
    }
}
