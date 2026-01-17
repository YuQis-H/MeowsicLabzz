using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MeowsicLabzz.Migrations
{
    /// <inheritdoc />
    public partial class UpdateArianaGenre : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0a6bebd9-4aa3-4f05-b079-307f9de56e90", "AQAAAAIAAYagAAAAEIk7VOAEMW0F9VEvfX+2UD6IwuJrHXtkInR62CUsiio6wX/5RonMRIV6e3slXiuuug==", "47fab45b-1bfb-4cab-9fa6-69fde3d4f787" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1ed07d3c-9010-495d-a485-3e76fcf72e67", "AQAAAAIAAYagAAAAEJfgbcXa/3FmP3BqdK0RtbfoOprbL9Z/NpqUm/YziRVRj4BhW1l45nC2EPcXSuRCiQ==", "fa2ee901-04b3-4ff4-bedb-41e211002a53" });
        }
    }
}
