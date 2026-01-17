using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MeowsicLabzz.Migrations
{
    /// <inheritdoc />
    public partial class UpdateArtistSeedTypes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                values: new object[] { "b5f682cc-d2f2-4528-ac8a-871732313649", "AQAAAAIAAYagAAAAEGtSyawPiYc1j570QYU9G/jDu/bcJwSxDWBr47Y5/Ovrj0rMj0cR8ew5ypNgvdLBeQ==", "7fcb7788-cab1-41e2-b8db-433b5bbffe8c" });
        }
    }
}
