using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RedSocial.BD.Migrations
{
    public partial class Usuario : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Nombre",
                table: "Estadisticas");

            migrationBuilder.AddColumn<string>(
                name: "COnfirmPassword",
                table: "Usuarios",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Descripcion",
                table: "Usuarios",
                type: "nvarchar(300)",
                maxLength: 300,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Usuarios",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ImgPerfil",
                table: "Usuarios",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ImgPortada",
                table: "Usuarios",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "NameUsuario",
                table: "Usuarios",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "password",
                table: "Usuarios",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IdUsuario_UQ3",
                table: "Usuarios",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IdUsuario_UQ2",
                table: "Rankings",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IdUsuario_UQ1",
                table: "Publicaciones",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IdUsuario_UQ",
                table: "Estadisticas",
                column: "Id",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IdUsuario_UQ3",
                table: "Usuarios");

            migrationBuilder.DropIndex(
                name: "IdUsuario_UQ2",
                table: "Rankings");

            migrationBuilder.DropIndex(
                name: "IdUsuario_UQ1",
                table: "Publicaciones");

            migrationBuilder.DropIndex(
                name: "IdUsuario_UQ",
                table: "Estadisticas");

            migrationBuilder.DropColumn(
                name: "COnfirmPassword",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "Descripcion",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "ImgPerfil",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "ImgPortada",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "NameUsuario",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "password",
                table: "Usuarios");

            migrationBuilder.AddColumn<string>(
                name: "Nombre",
                table: "Estadisticas",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
