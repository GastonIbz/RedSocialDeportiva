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
                name: "TablaPublicacion",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Usuario = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ContenidoPublicacion = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    FechaPublicacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MeGusta = table.Column<int>(type: "int", nullable: false),
                    VecesCompartido = table.Column<int>(type: "int", nullable: false),
                    EsPrivada = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TablaPublicacion", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TablaRanking",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TablaRanking", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TablaUsuario",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PasswordHash = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    PasswordSalt = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Descripcion = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    ImgPerfil = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImgPortada = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TablaUsuario", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IdUsuario_UQ",
                table: "TablaPublicacion",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IdUsuario_UQ1",
                table: "TablaRanking",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IdUsuario_UQ2",
                table: "TablaUsuario",
                column: "Id",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TablaPublicacion");

            migrationBuilder.DropTable(
                name: "TablaRanking");

            migrationBuilder.DropTable(
                name: "TablaUsuario");
        }
    }
}
