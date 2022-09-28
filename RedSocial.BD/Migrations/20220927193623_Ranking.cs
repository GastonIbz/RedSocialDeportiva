using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RedSocial.BD.Migrations
{
    public partial class Ranking : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "TablaRanking");

            migrationBuilder.AddColumn<string>(
                name: "NickName",
                table: "TablaRanking",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Partidas",
                table: "TablaRanking",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PorcentajeDeVictorias",
                table: "TablaRanking",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Puntos",
                table: "TablaRanking",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Victorias",
                table: "TablaRanking",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NickName",
                table: "TablaRanking");

            migrationBuilder.DropColumn(
                name: "Partidas",
                table: "TablaRanking");

            migrationBuilder.DropColumn(
                name: "PorcentajeDeVictorias",
                table: "TablaRanking");

            migrationBuilder.DropColumn(
                name: "Puntos",
                table: "TablaRanking");

            migrationBuilder.DropColumn(
                name: "Victorias",
                table: "TablaRanking");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "TablaRanking",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
