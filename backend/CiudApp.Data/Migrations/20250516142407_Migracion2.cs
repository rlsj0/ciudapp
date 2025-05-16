using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CiudApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class Migracion2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Resena_Ciudades_CiudadId",
                table: "Resena");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Resena",
                table: "Resena");

            migrationBuilder.RenameTable(
                name: "Resena",
                newName: "Resenas");

            migrationBuilder.RenameIndex(
                name: "IX_Resena_CiudadId",
                table: "Resenas",
                newName: "IX_Resenas_CiudadId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Resenas",
                table: "Resenas",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Ciudades",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaRegistro",
                value: new DateTime(2025, 5, 16, 16, 24, 7, 58, DateTimeKind.Local).AddTicks(6377));

            migrationBuilder.UpdateData(
                table: "Ciudades",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaRegistro",
                value: new DateTime(2025, 5, 16, 16, 24, 7, 58, DateTimeKind.Local).AddTicks(6429));

            migrationBuilder.AddForeignKey(
                name: "FK_Resenas_Ciudades_CiudadId",
                table: "Resenas",
                column: "CiudadId",
                principalTable: "Ciudades",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Resenas_Ciudades_CiudadId",
                table: "Resenas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Resenas",
                table: "Resenas");

            migrationBuilder.RenameTable(
                name: "Resenas",
                newName: "Resena");

            migrationBuilder.RenameIndex(
                name: "IX_Resenas_CiudadId",
                table: "Resena",
                newName: "IX_Resena_CiudadId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Resena",
                table: "Resena",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Ciudades",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaRegistro",
                value: new DateTime(2025, 5, 16, 13, 13, 51, 590, DateTimeKind.Local).AddTicks(1974));

            migrationBuilder.UpdateData(
                table: "Ciudades",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaRegistro",
                value: new DateTime(2025, 5, 16, 13, 13, 51, 590, DateTimeKind.Local).AddTicks(2022));

            migrationBuilder.AddForeignKey(
                name: "FK_Resena_Ciudades_CiudadId",
                table: "Resena",
                column: "CiudadId",
                principalTable: "Ciudades",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
