using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace aspnetcoreapp.Migrations
{
    public partial class AjustesInicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ajustes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DomingoInicio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LunesInicio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MartesInicio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MiercolesInicio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    JuevesInicio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ViernesInicio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SabadoInicio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DomingoFinal = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LunesFinal = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MartesFinal = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MiercolesFinal = table.Column<DateTime>(type: "datetime2", nullable: false),
                    JuevesFinal = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ViernesFinal = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SabadoFinal = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ISL = table.Column<int>(type: "int", nullable: false),
                    FSL = table.Column<int>(type: "int", nullable: false),
                    Domingo = table.Column<bool>(type: "bit", nullable: false),
                    Lunes = table.Column<bool>(type: "bit", nullable: false),
                    Martes = table.Column<bool>(type: "bit", nullable: false),
                    Miercoles = table.Column<bool>(type: "bit", nullable: false),
                    Jueves = table.Column<bool>(type: "bit", nullable: false),
                    Viernes = table.Column<bool>(type: "bit", nullable: false),
                    Sabado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ajustes", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ajustes");
        }
    }
}
