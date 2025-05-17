using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CiudApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class Migracion3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Ciudades",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaRegistro",
                value: new DateTime(2025, 5, 17, 13, 1, 28, 657, DateTimeKind.Local).AddTicks(5265));

            migrationBuilder.UpdateData(
                table: "Ciudades",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaRegistro",
                value: new DateTime(2025, 5, 17, 13, 1, 28, 657, DateTimeKind.Local).AddTicks(5326));

            migrationBuilder.InsertData(
                table: "Ciudades",
                columns: new[] { "Id", "FechaRegistro", "Nombre", "Pais", "Poblacion", "SoftDelete" },
                values: new object[,]
                {
                    { 3, new DateTime(2025, 5, 17, 13, 1, 28, 657, DateTimeKind.Local).AddTicks(5331), "Sevilla", "España", 688711, false },
                    { 4, new DateTime(2025, 5, 17, 13, 1, 28, 657, DateTimeKind.Local).AddTicks(5336), "Buenos Aires", "Argentina", 2890000, false },
                    { 5, new DateTime(2025, 5, 17, 13, 1, 28, 657, DateTimeKind.Local).AddTicks(5340), "Lisboa", "Portugal", 504718, false },
                    { 6, new DateTime(2025, 5, 17, 13, 1, 28, 657, DateTimeKind.Local).AddTicks(5344), "Venecia", "Italia", 261905, false },
                    { 7, new DateTime(2025, 5, 17, 13, 1, 28, 657, DateTimeKind.Local).AddTicks(5348), "Barcelona", "España", 1620000, false },
                    { 8, new DateTime(2025, 5, 17, 13, 1, 28, 657, DateTimeKind.Local).AddTicks(5352), "París", "Francia", 2148000, false },
                    { 9, new DateTime(2025, 5, 17, 13, 1, 28, 657, DateTimeKind.Local).AddTicks(5356), "Tokio", "Japón", 13960000, false }
                });

            migrationBuilder.InsertData(
                table: "Resenas",
                columns: new[] { "Id", "Calificacion", "CiudadId", "Descripcion", "Fecha", "Recomendacion", "Titulo" },
                values: new object[,]
                {
                    { 1, 5, 1, "El transporte fue eficiente y fácil de usar.", new DateTime(2025, 5, 17, 13, 1, 28, 657, DateTimeKind.Local).AddTicks(5627), true, "Una experiencia maravillosa" },
                    { 2, 4, 1, "Tuve una experiencia muy positiva, lo recomiendo.", new DateTime(2025, 5, 17, 13, 1, 28, 657, DateTimeKind.Local).AddTicks(5636), true, "Volvería sin dudarlo" },
                    { 3, 5, 1, "Tuve una experiencia muy positiva, lo recomiendo.", new DateTime(2025, 5, 17, 13, 1, 28, 657, DateTimeKind.Local).AddTicks(5640), true, "Inolvidable" },
                    { 4, 1, 1, "Todo fue extremadamente caro para lo que ofrecía.", new DateTime(2025, 5, 17, 13, 1, 28, 657, DateTimeKind.Local).AddTicks(5644), false, "Mal clima" },
                    { 5, 2, 1, "Todo fue extremadamente caro para lo que ofrecía.", new DateTime(2025, 5, 17, 13, 1, 28, 657, DateTimeKind.Local).AddTicks(5648), false, "Experiencia regular" },
                    { 6, 2, 1, "Esperaba más, me decepcionó bastante.", new DateTime(2025, 5, 17, 13, 1, 28, 657, DateTimeKind.Local).AddTicks(5652), false, "Muy sucia" },
                    { 7, 5, 2, "Mucho que ver y disfrutar, fue un gran viaje.", new DateTime(2025, 5, 17, 13, 1, 28, 657, DateTimeKind.Local).AddTicks(5656), true, "Inolvidable" },
                    { 8, 5, 2, "Mucho que ver y disfrutar, fue un gran viaje.", new DateTime(2025, 5, 17, 13, 1, 28, 657, DateTimeKind.Local).AddTicks(5660), true, "Encantadora" },
                    { 9, 4, 2, "La ciudad es hermosa y está llena de historia.", new DateTime(2025, 5, 17, 13, 1, 28, 657, DateTimeKind.Local).AddTicks(5664), true, "Inolvidable" },
                    { 10, 3, 2, "Poca oferta cultural y muchas obras en las calles.", new DateTime(2025, 5, 17, 13, 1, 28, 657, DateTimeKind.Local).AddTicks(5668), false, "Demasiado caro" },
                    { 11, 2, 2, "Esperaba más, me decepcionó bastante.", new DateTime(2025, 5, 17, 13, 1, 28, 657, DateTimeKind.Local).AddTicks(5672), false, "Demasiado caro" },
                    { 12, 1, 2, "Todo fue extremadamente caro para lo que ofrecía.", new DateTime(2025, 5, 17, 13, 1, 28, 657, DateTimeKind.Local).AddTicks(5675), false, "No volvería" },
                    { 13, 4, 3, "Mucho que ver y disfrutar, fue un gran viaje.", new DateTime(2025, 5, 17, 13, 1, 28, 657, DateTimeKind.Local).AddTicks(5679), true, "Una experiencia maravillosa" },
                    { 14, 4, 3, "Perfecta para unas vacaciones tranquilas y culturales.", new DateTime(2025, 5, 17, 13, 1, 28, 657, DateTimeKind.Local).AddTicks(5683), true, "Volvería sin dudarlo" },
                    { 15, 5, 3, "Las personas fueron muy amables y la comida deliciosa.", new DateTime(2025, 5, 17, 13, 1, 28, 657, DateTimeKind.Local).AddTicks(5687), true, "Inolvidable" },
                    { 16, 3, 3, "Tuve muchos problemas con el transporte.", new DateTime(2025, 5, 17, 13, 1, 28, 657, DateTimeKind.Local).AddTicks(5691), false, "Decepcionante" },
                    { 17, 3, 3, "Todo fue extremadamente caro para lo que ofrecía.", new DateTime(2025, 5, 17, 13, 1, 28, 657, DateTimeKind.Local).AddTicks(5695), false, "Experiencia regular" },
                    { 18, 2, 3, "No me sentí seguro durante mi estancia.", new DateTime(2025, 5, 17, 13, 1, 28, 657, DateTimeKind.Local).AddTicks(5698), false, "Demasiado caro" },
                    { 19, 5, 4, "Mucho que ver y disfrutar, fue un gran viaje.", new DateTime(2025, 5, 17, 13, 1, 28, 657, DateTimeKind.Local).AddTicks(5702), true, "Muy recomendable" },
                    { 20, 4, 4, "El transporte fue eficiente y fácil de usar.", new DateTime(2025, 5, 17, 13, 1, 28, 657, DateTimeKind.Local).AddTicks(5706), true, "Me encantó" },
                    { 21, 4, 4, "El transporte fue eficiente y fácil de usar.", new DateTime(2025, 5, 17, 13, 1, 28, 657, DateTimeKind.Local).AddTicks(5710), true, "Volvería sin dudarlo" },
                    { 22, 1, 4, "No me sentí seguro durante mi estancia.", new DateTime(2025, 5, 17, 13, 1, 28, 657, DateTimeKind.Local).AddTicks(5723), false, "Mal clima" },
                    { 23, 2, 4, "Esperaba más, me decepcionó bastante.", new DateTime(2025, 5, 17, 13, 1, 28, 657, DateTimeKind.Local).AddTicks(5727), false, "Muy sucia" },
                    { 24, 3, 4, "Poca oferta cultural y muchas obras en las calles.", new DateTime(2025, 5, 17, 13, 1, 28, 657, DateTimeKind.Local).AddTicks(5731), false, "No volvería" },
                    { 25, 5, 5, "La ciudad es hermosa y está llena de historia.", new DateTime(2025, 5, 17, 13, 1, 28, 657, DateTimeKind.Local).AddTicks(5735), true, "Inolvidable" },
                    { 26, 4, 5, "Las personas fueron muy amables y la comida deliciosa.", new DateTime(2025, 5, 17, 13, 1, 28, 657, DateTimeKind.Local).AddTicks(5738), true, "Encantadora" },
                    { 27, 5, 5, "El transporte fue eficiente y fácil de usar.", new DateTime(2025, 5, 17, 13, 1, 28, 657, DateTimeKind.Local).AddTicks(5742), true, "Volvería sin dudarlo" },
                    { 28, 3, 5, "La ciudad estaba abarrotada y sucia.", new DateTime(2025, 5, 17, 13, 1, 28, 657, DateTimeKind.Local).AddTicks(5746), false, "Mal clima" },
                    { 29, 1, 5, "Esperaba más, me decepcionó bastante.", new DateTime(2025, 5, 17, 13, 1, 28, 657, DateTimeKind.Local).AddTicks(5750), false, "Experiencia regular" },
                    { 30, 3, 5, "No me sentí seguro durante mi estancia.", new DateTime(2025, 5, 17, 13, 1, 28, 657, DateTimeKind.Local).AddTicks(5754), false, "Decepcionante" },
                    { 31, 4, 6, "La ciudad es hermosa y está llena de historia.", new DateTime(2025, 5, 17, 13, 1, 28, 657, DateTimeKind.Local).AddTicks(5758), true, "Me encantó" },
                    { 32, 4, 6, "Tuve una experiencia muy positiva, lo recomiendo.", new DateTime(2025, 5, 17, 13, 1, 28, 657, DateTimeKind.Local).AddTicks(5761), true, "Volvería sin dudarlo" },
                    { 33, 4, 6, "La ciudad es hermosa y está llena de historia.", new DateTime(2025, 5, 17, 13, 1, 28, 657, DateTimeKind.Local).AddTicks(5765), true, "Volvería sin dudarlo" },
                    { 34, 3, 6, "Todo fue extremadamente caro para lo que ofrecía.", new DateTime(2025, 5, 17, 13, 1, 28, 657, DateTimeKind.Local).AddTicks(5770), false, "Muy sucia" },
                    { 35, 2, 6, "Poca oferta cultural y muchas obras en las calles.", new DateTime(2025, 5, 17, 13, 1, 28, 657, DateTimeKind.Local).AddTicks(5774), false, "Experiencia regular" },
                    { 36, 2, 6, "No me sentí seguro durante mi estancia.", new DateTime(2025, 5, 17, 13, 1, 28, 657, DateTimeKind.Local).AddTicks(5778), false, "Mal clima" },
                    { 37, 4, 7, "Las personas fueron muy amables y la comida deliciosa.", new DateTime(2025, 5, 17, 13, 1, 28, 657, DateTimeKind.Local).AddTicks(5781), true, "Me encantó" },
                    { 38, 5, 7, "El transporte fue eficiente y fácil de usar.", new DateTime(2025, 5, 17, 13, 1, 28, 657, DateTimeKind.Local).AddTicks(5785), true, "Me encantó" },
                    { 39, 5, 7, "Perfecta para unas vacaciones tranquilas y culturales.", new DateTime(2025, 5, 17, 13, 1, 28, 657, DateTimeKind.Local).AddTicks(5789), true, "Volvería sin dudarlo" },
                    { 40, 2, 7, "Todo fue extremadamente caro para lo que ofrecía.", new DateTime(2025, 5, 17, 13, 1, 28, 657, DateTimeKind.Local).AddTicks(5793), false, "Decepcionante" },
                    { 41, 3, 7, "No me sentí seguro durante mi estancia.", new DateTime(2025, 5, 17, 13, 1, 28, 657, DateTimeKind.Local).AddTicks(5797), false, "Decepcionante" },
                    { 42, 3, 7, "Esperaba más, me decepcionó bastante.", new DateTime(2025, 5, 17, 13, 1, 28, 657, DateTimeKind.Local).AddTicks(5801), false, "Experiencia regular" },
                    { 43, 5, 8, "Tuve una experiencia muy positiva, lo recomiendo.", new DateTime(2025, 5, 17, 13, 1, 28, 657, DateTimeKind.Local).AddTicks(5804), true, "Muy recomendable" },
                    { 44, 5, 8, "Perfecta para unas vacaciones tranquilas y culturales.", new DateTime(2025, 5, 17, 13, 1, 28, 657, DateTimeKind.Local).AddTicks(5809), true, "Inolvidable" },
                    { 45, 4, 8, "La ciudad es hermosa y está llena de historia.", new DateTime(2025, 5, 17, 13, 1, 28, 657, DateTimeKind.Local).AddTicks(5813), true, "Volvería sin dudarlo" },
                    { 46, 3, 8, "La ciudad estaba abarrotada y sucia.", new DateTime(2025, 5, 17, 13, 1, 28, 657, DateTimeKind.Local).AddTicks(5816), false, "Decepcionante" },
                    { 47, 2, 8, "Esperaba más, me decepcionó bastante.", new DateTime(2025, 5, 17, 13, 1, 28, 657, DateTimeKind.Local).AddTicks(5820), false, "Demasiado caro" },
                    { 48, 2, 8, "No me sentí seguro durante mi estancia.", new DateTime(2025, 5, 17, 13, 1, 28, 657, DateTimeKind.Local).AddTicks(5824), false, "Experiencia regular" },
                    { 49, 4, 9, "Las personas fueron muy amables y la comida deliciosa.", new DateTime(2025, 5, 17, 13, 1, 28, 657, DateTimeKind.Local).AddTicks(5828), true, "Encantadora" },
                    { 50, 4, 9, "Perfecta para unas vacaciones tranquilas y culturales.", new DateTime(2025, 5, 17, 13, 1, 28, 657, DateTimeKind.Local).AddTicks(5832), true, "Muy recomendable" },
                    { 51, 4, 9, "Perfecta para unas vacaciones tranquilas y culturales.", new DateTime(2025, 5, 17, 13, 1, 28, 657, DateTimeKind.Local).AddTicks(5835), true, "Encantadora" },
                    { 52, 1, 9, "La ciudad estaba abarrotada y sucia.", new DateTime(2025, 5, 17, 13, 1, 28, 657, DateTimeKind.Local).AddTicks(5839), false, "Experiencia regular" },
                    { 53, 2, 9, "Todo fue extremadamente caro para lo que ofrecía.", new DateTime(2025, 5, 17, 13, 1, 28, 657, DateTimeKind.Local).AddTicks(5843), false, "Mal clima" },
                    { 54, 1, 9, "Poca oferta cultural y muchas obras en las calles.", new DateTime(2025, 5, 17, 13, 1, 28, 657, DateTimeKind.Local).AddTicks(5847), false, "Mal clima" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Resenas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Resenas",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Resenas",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Resenas",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Resenas",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Resenas",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Resenas",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Resenas",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Resenas",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Resenas",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Resenas",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Resenas",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Resenas",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Resenas",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Resenas",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Resenas",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Resenas",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Resenas",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Resenas",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Resenas",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Resenas",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Resenas",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Resenas",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Resenas",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Resenas",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Resenas",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Resenas",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Resenas",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Resenas",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Resenas",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Resenas",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Resenas",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Resenas",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Resenas",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Resenas",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Resenas",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Resenas",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Resenas",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Resenas",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Resenas",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Resenas",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Resenas",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Resenas",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Resenas",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Resenas",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Resenas",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Resenas",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Resenas",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Resenas",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Resenas",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Resenas",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Resenas",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Resenas",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Resenas",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Ciudades",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Ciudades",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Ciudades",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Ciudades",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Ciudades",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Ciudades",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Ciudades",
                keyColumn: "Id",
                keyValue: 9);

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
        }
    }
}
