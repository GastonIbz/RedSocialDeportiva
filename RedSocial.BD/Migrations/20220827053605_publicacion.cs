using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RedSocial.BD.Migrations
{
    public partial class publicacion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "fechaPublicacion",
                table: "Publicaciones",
                newName: "FechaPublicacion");

            migrationBuilder.RenameColumn(
                name: "contenidoPublicacion",
                table: "Publicaciones",
                newName: "ContenidoPublicacion");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Usuarios",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Usuarios",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ContenidoPublicacion",
                table: "Publicaciones",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "EsPrivada",
                table: "Publicaciones",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "MeGusta",
                table: "Publicaciones",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Usuario",
                table: "Publicaciones",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "VecesCompartido",
                table: "Publicaciones",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Password",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "EsPrivada",
                table: "Publicaciones");

            migrationBuilder.DropColumn(
                name: "MeGusta",
                table: "Publicaciones");

            migrationBuilder.DropColumn(
                name: "Usuario",
                table: "Publicaciones");

            migrationBuilder.DropColumn(
                name: "VecesCompartido",
                table: "Publicaciones");

            migrationBuilder.RenameColumn(
                name: "FechaPublicacion",
                table: "Publicaciones",
                newName: "fechaPublicacion");

            migrationBuilder.RenameColumn(
                name: "ContenidoPublicacion",
                table: "Publicaciones",
                newName: "contenidoPublicacion");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Usuarios",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "contenidoPublicacion",
                table: "Publicaciones",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);
        }
    }
}
