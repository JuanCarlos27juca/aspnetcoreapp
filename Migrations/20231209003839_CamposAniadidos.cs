using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace aspnetcoreapp.Migrations
{
    public partial class CamposAniadidos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Direccion",
                table: "Empleados",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaIngreso",
                table: "Empleados",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaNacimiento",
                table: "Empleados",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "HorasEstipuladas",
                table: "Empleados",
                type: "nvarchar(3)",
                maxLength: 3,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "NumeroEmpleado",
                table: "Empleados",
                type: "nvarchar(3)",
                maxLength: 3,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<decimal>(
                name: "PagoPorHora",
                table: "Empleados",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "Puesto",
                table: "Empleados",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Telefono",
                table: "Empleados",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Direccion",
                table: "Empleados");

            migrationBuilder.DropColumn(
                name: "FechaIngreso",
                table: "Empleados");

            migrationBuilder.DropColumn(
                name: "FechaNacimiento",
                table: "Empleados");

            migrationBuilder.DropColumn(
                name: "HorasEstipuladas",
                table: "Empleados");

            migrationBuilder.DropColumn(
                name: "NumeroEmpleado",
                table: "Empleados");

            migrationBuilder.DropColumn(
                name: "PagoPorHora",
                table: "Empleados");

            migrationBuilder.DropColumn(
                name: "Puesto",
                table: "Empleados");

            migrationBuilder.DropColumn(
                name: "Telefono",
                table: "Empleados");
        }
    }
}
