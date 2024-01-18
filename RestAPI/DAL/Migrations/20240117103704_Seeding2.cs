using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class Seeding2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Routes",
                columns: new[] { "ID", "Provider", "RouteNumber" },
                values: new object[,]
                {
                    { 21, "BKK", "8E" },
                    { 22, "BKK", "9" },
                    { 23, "BKK", "72" },
                    { 24, "BKK", "80" },
                    { 25, "BKK", "77" }
                });

            migrationBuilder.InsertData(
                table: "Stops",
                columns: new[] { "ID", "Name" },
                values: new object[,]
                {
                    { 261, "Sasadi út" },
                    { 262, "Nagyszeben út" },
                    { 263, "Gazdagréti út" },
                    { 264, "Regős köz" },
                    { 265, "Frankhegy utca" },
                    { 266, "Kaptárkő utca" },
                    { 267, "Telekes utca" },
                    { 268, "Gazdagréti tér" },
                    { 269, "Szent Pio atya tér" },
                    { 270, "Irhás árok" },
                    { 271, "Oltvány köz" },
                    { 272, "Eper utca" },
                    { 273, "Márton Áron tér" },
                    { 274, "Sümeg utca" },
                    { 275, "Farkasréti temető" },
                    { 276, "Hegytető utca" },
                    { 277, "Korompai utca" },
                    { 278, "Sion lépcső" },
                    { 279, "Breznó lépcső" },
                    { 280, "Zólyomi út" },
                    { 281, "BAH-csomópont" },
                    { 282, "Mészáros utca" },
                    { 283, "Sánc utca" },
                    { 284, "Nagyszeben tér" },
                    { 285, "Jégvirág utca" },
                    { 263, "" },
                    { 263, "" },
                    { 263, "" },
                    { 263, "" },
                    { 263, "" },
                    { 263, "" },
                    { 263, "" },
                    { 263, "" },
                    { 263, "" },
                    { 263, "" },
                    { 263, "" },
                    { 263, "" },
				});

            migrationBuilder.InsertData(
                table: "RouteStops",
                columns: new[] { "Direction", "Order", "RouteID", "StopID" },
                values: new object[,]
                {
                    { "Outbound", 1, 21, 96 },
                    { "Outbound", 2, 21, 261 },
                    { "Outbound", 3, 21, 262 },
                    { "Outbound", 4, 21, 263 },
                    { "Outbound", 5, 21, 264 },
                    { "Outbound", 6, 21, 265 },
                    { "Outbound", 7, 21, 266 },
                    { "Outbound", 8, 21, 267 },
                    { "Outbound", 9, 21, 268 },
                    { "Outbound", 10, 21, 269 },
                    { "Outbound", 11, 21, 270 },
                    { "Outbound", 12, 21, 271 },
                    { "Outbound", 13, 21, 272 },
                    { "Outbound", 14, 21, 273 },
                    { "Outbound", 15, 21, 274 },
                    { "Outbound", 16, 21, 275 },
                    { "Outbound", 17, 21, 276 },
                    { "Outbound", 18, 21, 277 },
                    { "Outbound", 19, 21, 278 },
                    { "Outbound", 20, 21, 279 },
                    { "Outbound", 21, 21, 280 },
                    { "Outbound", 22, 21, 281 },
                    { "Outbound", 23, 21, 281 },
                    { "Outbound", 24, 21, 282 },
                    { "Outbound", 25, 21, 283 },
                    { "Outbound", 26, 21, 241 },
                    { "Outbound", 27, 21, 18 },
                    { "Outbound", 28, 21, 19 },
                    { "Outbound", 29, 21, 20 },
                    { "Outbound", 30, 21, 21 },
                    { "Outbound", 31, 21, 22 },
                    { "Outbound", 32, 21, 24 },
                    { "Outbound", 33, 21, 28 },
                    { "Outbound", 34, 21, 29 },
                    { "Outbound", 35, 21, 30 },
                    { "Outbound", 36, 21, 33 },
                    { "Outbound", 37, 21, 34 },
                    { "Outbound", 38, 21, 35 },
                    { "Outbound", 39, 21, 37 },
                    { "Outbound", 40, 21, 38 },
                    { "Outbound", 41, 21, 39 },
					{ "Inbound", 1, 21, 39 },
                    { "Inbound", 2, 21, 38 },
                    { "Inbound", 3, 21, 37 },
                    { "Inbound", 4, 21, 35 },
                    { "Inbound", 5, 21, 34 },
                    { "Inbound", 6, 21, 33 },
                    { "Inbound", 7, 21, 30 },
                    { "Inbound", 8, 21, 29 },
                    { "Inbound", 9, 21, 28 },
                    { "Inbound", 10, 21, 24 },
                    { "Inbound", 11, 21, 22 },
                    { "Inbound", 12, 21, 21 },
                    { "Inbound", 13, 21, 20 },
                    { "Inbound", 14, 21, 19 },
                    { "Inbound", 15, 21, 18 },
                    { "Inbound", 16, 21, 241 },
                    { "Inbound", 17, 21, 283 },
                    { "Inbound", 18, 21, 282 },
                    { "Inbound", 19, 21, 281 },
                    { "Inbound", 20, 21, 280 },
                    { "Inbound", 21, 21, 279 },
                    { "Inbound", 22, 21, 278 },
                    { "Inbound", 23, 21, 277 },
                    { "Inbound", 24, 21, 276 },
                    { "Inbound", 25, 21, 275 },
                    { "Inbound", 26, 21, 274 },
                    { "Inbound", 27, 21, 273 },
                    { "Inbound", 28, 21, 272 },
                    { "Inbound", 29, 21, 271 },
                    { "Inbound", 30, 21, 270 },
                    { "Inbound", 31, 21, 269 },
                    { "Inbound", 32, 21, 268 },
                    { "Inbound", 33, 21, 267 },
                    { "Inbound", 34, 21, 266 },
                    { "Inbound", 35, 21, 265 },
                    { "Inbound", 36, 21, 264 },
                    { "Inbound", 37, 21, 284 },
                    { "Inbound", 38, 21, 263 },
                    { "Inbound", 39, 21, 285 },
                    { "Inbound", 40, 21, 96 },
				});
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Routes",
                keyColumn: "ID",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Routes",
                keyColumn: "ID",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Routes",
                keyColumn: "ID",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Routes",
                keyColumn: "ID",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Stops",
                keyColumn: "ID",
                keyValue: 262);

            migrationBuilder.DeleteData(
                table: "Routes",
                keyColumn: "ID",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Stops",
                keyColumn: "ID",
                keyValue: 261);
        }
    }
}
