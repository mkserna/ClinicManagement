using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Assessment_MarianaPerezSerna.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "roles",
                columns: new[] { "id", "name" },
                values: new object[,]
                {
                    { 1, "doctor" },
                    { 2, "patient" }
                });

            migrationBuilder.InsertData(
                table: "specialties",
                columns: new[] { "id", "name" },
                values: new object[,]
                {
                    { 1, "neurology" },
                    { 2, "cardiology" },
                    { 3, "dermatology" },
                    { 4, "pediatrics" },
                    { 5, "gynecology" },
                    { 6, "orthopedics" },
                    { 7, "psychology" },
                    { 8, "dentistry" },
                    { 9, "rheumatology" },
                    { 10, "oncology" }
                });

            migrationBuilder.InsertData(
                table: "status_appointments",
                columns: new[] { "id", "name" },
                values: new object[,]
                {
                    { 1, "available" },
                    { 2, "booked" },
                    { 3, "canceled" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "roles",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "roles",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "specialties",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "specialties",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "specialties",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "specialties",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "specialties",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "specialties",
                keyColumn: "id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "specialties",
                keyColumn: "id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "specialties",
                keyColumn: "id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "specialties",
                keyColumn: "id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "specialties",
                keyColumn: "id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "status_appointments",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "status_appointments",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "status_appointments",
                keyColumn: "id",
                keyValue: 3);
        }
    }
}
