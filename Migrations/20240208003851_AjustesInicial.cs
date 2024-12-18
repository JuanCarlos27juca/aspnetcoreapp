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

            migrationBuilder.InsertData(
                table: "Ajustes",
                columns: new[] { "Id", "Domingo", "DomingoFinal", "DomingoInicio", "FSL", "ISL", "Jueves", "JuevesFinal", "JuevesInicio", "Lunes", "LunesFinal", "LunesInicio", "Martes", "MartesFinal", "MartesInicio", "Miercoles", "MiercolesFinal", "MiercolesInicio", "Sabado", "SabadoFinal", "SabadoInicio", "Viernes", "ViernesFinal", "ViernesInicio" },
                values: new object[] { 1, false, new DateTime(2024, 2, 7, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 7, 7, 0, 0, 0, DateTimeKind.Unspecified), 5, 1, true, new DateTime(2024, 2, 7, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 7, 7, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2024, 2, 7, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 7, 7, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2024, 2, 7, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 7, 7, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2024, 2, 7, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 7, 7, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 2, 7, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 7, 7, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2024, 2, 7, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 7, 7, 0, 0, 0, DateTimeKind.Unspecified) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ajustes");
        }
    }
}
