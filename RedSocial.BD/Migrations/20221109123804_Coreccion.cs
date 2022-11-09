using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RedSocial.BD.Migrations
{
    public partial class Coreccion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TablaRanking");

            migrationBuilder.DropColumn(
                name: "Usuario",
                table: "TablaPublicacion");

            migrationBuilder.RenameIndex(
                name: "IdUsuario_UQ2",
                table: "TablaUsuario",
                newName: "IdUsuario_UQ1");

            migrationBuilder.AddColumn<int>(
                name: "UsuarioId",
                table: "TablaPublicacion",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "TablaEEntidad",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NombreEquipo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JuegoProfesional = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PosicionMundial = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PosicionPaisNatal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PartidasJugadas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ganadas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Perdidas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    empatadas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MVP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MayorLogro = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Horas = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TablaEEntidad", x => x.id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TablaPublicacion_UsuarioId",
                table: "TablaPublicacion",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IdEstadistica_UQ",
                table: "TablaEEntidad",
                column: "id",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_TablaPublicacion_TablaUsuario_UsuarioId",
                table: "TablaPublicacion",
                column: "UsuarioId",
                principalTable: "TablaUsuario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TablaPublicacion_TablaUsuario_UsuarioId",
                table: "TablaPublicacion");

            migrationBuilder.DropTable(
                name: "TablaEEntidad");

            migrationBuilder.DropIndex(
                name: "IX_TablaPublicacion_UsuarioId",
                table: "TablaPublicacion");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "TablaPublicacion");

            migrationBuilder.RenameIndex(
                name: "IdUsuario_UQ1",
                table: "TablaUsuario",
                newName: "IdUsuario_UQ2");

            migrationBuilder.AddColumn<string>(
                name: "Usuario",
                table: "TablaPublicacion",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "TablaRanking",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NickName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Partidas = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PorcentajeDeVictorias = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Puntos = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Victorias = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TablaRanking", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IdUsuario_UQ1",
                table: "TablaRanking",
                column: "Id",
                unique: true);
        }
    }
}
