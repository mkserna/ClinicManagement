using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Assessment_MarianaPerezSerna.Migrations
{
    /// <inheritdoc />
    public partial class SeederData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "doctors",
                columns: new[] { "id", "email", "lastname", "name", "password", "role_id", "specialty_id" },
                values: new object[,]
                {
                    { 1, "marianaperezserna@gmail.com", "perez serna", "mariana", "123654789", 1, 1 },
                    { 2, "juangomez@gmail.com", "gómez lópez", "juan", "123654789", 1, 2 },
                    { 3, "anaramirez@gmail.com", "ramírez torres", "ana", "123654789", 1, 3 },
                    { 4, "luismartinez@gmail.com", "martínez rivera", "luis", "123654789", 1, 4 },
                    { 5, "carlafernandez@gmail.com", "fernández pérez", "carla", "123654789", 1, 5 },
                    { 6, "pedrohernandez@gmail.com", "hernández núñez", "pedro", "123654789", 1, 6 }
                });

            migrationBuilder.InsertData(
                table: "patients",
                columns: new[] { "id", "address", "email", "lastname", "name", "password", "phone", "role_id" },
                values: new object[,]
                {
                    { 1, "calle falsa 123, ciudad x", "juanperez@gmail.com", "perez", "juan", "741258963", "1234567890", 2 },
                    { 2, "avenida del sol 456, ciudad y", "anagarcia@yahoo.com", "garcia", "ana", "741258963", "0987654321", 2 },
                    { 3, "barrio norte 789, ciudad z", "luismartinez@outlook.com", "martinez", "luis", "741258963", "5678901234", 2 },
                    { 4, "calle nueva 101, ciudad w", "mariarodriguez@hotmail.com", "rodriguez", "maria", "741258963", "1234509876", 2 },
                    { 5, "plaza central 202, ciudad v", "pedrolopez@correo.com", "lopez", "pedro", "741258963", "1122334455", 2 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "doctors",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "doctors",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "doctors",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "doctors",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "doctors",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "doctors",
                keyColumn: "id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "patients",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "patients",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "patients",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "patients",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "patients",
                keyColumn: "id",
                keyValue: 5);
        }
    }
}
