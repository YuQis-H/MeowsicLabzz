using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MeowsicLabzz.Migrations
{
    /// <inheritdoc />
    public partial class UpdateGenreSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 3,
                column: "GenreId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1ed07d3c-9010-495d-a485-3e76fcf72e67", "AQAAAAIAAYagAAAAEJfgbcXa/3FmP3BqdK0RtbfoOprbL9Z/NpqUm/YziRVRj4BhW1l45nC2EPcXSuRCiQ==", "fa2ee901-04b3-4ff4-bedb-41e211002a53" });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "R&B");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 3,
                column: "GenreId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "df38d0d7-17f1-420e-b053-2f42bbc06393", "AQAAAAIAAYagAAAAEAJTwtN/+FQz0H8xOB7/NpLwe9W8GePqnNU7ufu6NhAJuzyhtQgYtVQRphKPZ/yN0w==", "a11cc374-bb85-4a74-85b1-cc63e75258f3" });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Jazz");
        }
    }
}
