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
                values: new object[] { 261, "" });

            migrationBuilder.InsertData(
                table: "RouteStops",
                columns: new[] { "Direction", "Order", "RouteID", "StopID" },
                values: new object[,] {
                    { "Outbound", 1, 21, 261 } 
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "RouteStops",
                keyColumn: "ID",
                keyValue: 780);

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
