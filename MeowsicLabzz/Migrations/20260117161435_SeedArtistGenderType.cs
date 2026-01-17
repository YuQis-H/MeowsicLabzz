using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MeowsicLabzz.Migrations
{
    /// <inheritdoc />
    public partial class SeedArtistGenderType : Migration
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
                values: new object[] { "07377846-4aa7-4773-a0e1-fd8e66ad7b55", "AQAAAAIAAYagAAAAECg8wtAWY/0CZVzmTDZAK/h+eEcQN8dewEu08oxOZ6DbPubsEBij3lSLL+ZW2Dz4+Q==", "c525e412-30fa-4476-9697-dfe09aa72c19" });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 5,
                column: "GenreId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 6,
                column: "GenreId",
                value: 3);
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
                values: new object[] { "0a6bebd9-4aa3-4f05-b079-307f9de56e90", "AQAAAAIAAYagAAAAEIk7VOAEMW0F9VEvfX+2UD6IwuJrHXtkInR62CUsiio6wX/5RonMRIV6e3slXiuuug==", "47fab45b-1bfb-4cab-9fa6-69fde3d4f787" });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 5,
                column: "GenreId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 6,
                column: "GenreId",
                value: 1);
        }
    }
}
