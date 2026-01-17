using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MeowsicLabzz.Migrations
{
    /// <inheritdoc />
    public partial class AddGoLiveAlbumAndUpdateGodsMenu : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Albums",
                columns: new[] { "Id", "ArtistId", "GenreId", "Title" },
                values: new object[] { 5, 2, 1, "Go Live" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "df38d0d7-17f1-420e-b053-2f42bbc06393", "AQAAAAIAAYagAAAAEAJTwtN/+FQz0H8xOB7/NpLwe9W8GePqnNU7ufu6NhAJuzyhtQgYtVQRphKPZ/yN0w==", "a11cc374-bb85-4a74-85b1-cc63e75258f3" });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 4,
                column: "AlbumId",
                value: 5);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "90421783-e589-44ab-b2a8-9b5166d3b2d9", "AQAAAAIAAYagAAAAEN5crhg90sXa7uE4sGDIW46rYWnvXlPTGv3J1IAS0HgpAOPKsxNeaADg7ax/dlChog==", "80fc39bd-7ad6-4031-b167-3d2ef1389e93" });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 4,
                column: "AlbumId",
                value: 2);
        }
    }
}
