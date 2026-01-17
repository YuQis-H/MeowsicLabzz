using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MeowsicLabzz.Migrations
{
    /// <inheritdoc />
    public partial class UpdateAlbumsSongsSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Albums",
                columns: new[] { "Id", "ArtistId", "GenreId", "Title" },
                values: new object[] { 4, 1, 1, "When We All Fall Asleep, Where Do We Go?" });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ArtistType", "Gender" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ArtistType", "Gender" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ArtistType", "Gender" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "90421783-e589-44ab-b2a8-9b5166d3b2d9", "AQAAAAIAAYagAAAAEN5crhg90sXa7uE4sGDIW46rYWnvXlPTGv3J1IAS0HgpAOPKsxNeaADg7ax/dlChog==", "80fc39bd-7ad6-4031-b167-3d2ef1389e93" });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AlbumId", "GenreId" },
                values: new object[] { 4, 1 });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 3,
                column: "GenreId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 4,
                column: "GenreId",
                value: 1);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ArtistType", "Gender" },
                values: new object[] { "Soloist", "Female" });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ArtistType", "Gender" },
                values: new object[] { "Group", "Mixed" });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ArtistType", "Gender" },
                values: new object[] { "Soloist", "Female" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f8bc9356-ca40-4997-9ae0-ae54ab6a6b66", "AQAAAAIAAYagAAAAELfmwk5ENcWn/XU8tRHWF2PJV02A9p+VfEBCMXOZ8XF6xBqDmjzn5NLdpFDR2r0qkg==", "6fdae967-1e2e-479a-8314-27d16792c991" });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AlbumId", "GenreId" },
                values: new object[] { 1, 2 });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 3,
                column: "GenreId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 4,
                column: "GenreId",
                value: 3);
        }
    }
}
