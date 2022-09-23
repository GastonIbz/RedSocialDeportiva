using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RedSocial.BD.Migrations
{
    public partial class EstadisticaBR : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "accounType",
                table: "TablaEstadistica",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "image",
                table: "TablaEstadistica",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "name",
                table: "TablaEstadistica",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "timeWindow",
                table: "TablaEstadistica",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "accounType",
                table: "TablaEstadistica");

            migrationBuilder.DropColumn(
                name: "image",
                table: "TablaEstadistica");

            migrationBuilder.DropColumn(
                name: "name",
                table: "TablaEstadistica");

            migrationBuilder.DropColumn(
                name: "timeWindow",
                table: "TablaEstadistica");
        }
    }
}
