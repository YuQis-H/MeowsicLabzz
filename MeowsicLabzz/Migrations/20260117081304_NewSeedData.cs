using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MeowsicLabzz.Migrations
{
    /// <inheritdoc />
    public partial class NewSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "User",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "User",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "User",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "User",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Songs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Songs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Songs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "Songs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "MyPlaylist",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "MyPlaylist",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "MyPlaylist",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "MyPlaylist",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "MusicDiscovery",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "MusicDiscovery",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "MusicDiscovery",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "MusicDiscovery",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Moods",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Moods",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Moods",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "Moods",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Genres",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Genres",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Genres",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "Genres",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Friends",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Friends",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Friends",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "Friends",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Artists",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Artists",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Artists",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "Artists",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Albums",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Albums",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Albums",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "Albums",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "CreatedBy", "GenreId", "UpdatedAt", "UpdatedBy" },
                values: new object[] { new DateTime(2026, 1, 17, 16, 13, 3, 670, DateTimeKind.Local).AddTicks(9162), "System", 1, new DateTime(2026, 1, 17, 16, 13, 3, 670, DateTimeKind.Local).AddTicks(9163), "System" });

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "CreatedBy", "GenreId", "UpdatedAt", "UpdatedBy" },
                values: new object[] { new DateTime(2026, 1, 17, 16, 13, 3, 670, DateTimeKind.Local).AddTicks(9164), "System", 1, new DateTime(2026, 1, 17, 16, 13, 3, 670, DateTimeKind.Local).AddTicks(9165), "System" });

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "CreatedBy", "GenreId", "UpdatedAt", "UpdatedBy" },
                values: new object[] { new DateTime(2026, 1, 17, 16, 13, 3, 670, DateTimeKind.Local).AddTicks(9166), "System", 1, new DateTime(2026, 1, 17, 16, 13, 3, 670, DateTimeKind.Local).AddTicks(9167), "System" });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "CreatedBy", "UpdatedAt", "UpdatedBy" },
                values: new object[] { new DateTime(2026, 1, 17, 16, 13, 3, 670, DateTimeKind.Local).AddTicks(9029), "System", new DateTime(2026, 1, 17, 16, 13, 3, 670, DateTimeKind.Local).AddTicks(9029), "System" });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "CreatedBy", "UpdatedAt", "UpdatedBy" },
                values: new object[] { new DateTime(2026, 1, 17, 16, 13, 3, 670, DateTimeKind.Local).AddTicks(9031), "System", new DateTime(2026, 1, 17, 16, 13, 3, 670, DateTimeKind.Local).AddTicks(9031), "System" });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "CreatedBy", "UpdatedAt", "UpdatedBy" },
                values: new object[] { new DateTime(2026, 1, 17, 16, 13, 3, 670, DateTimeKind.Local).AddTicks(9033), "System", new DateTime(2026, 1, 17, 16, 13, 3, 670, DateTimeKind.Local).AddTicks(9033), "System" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "43a2118e-d407-47a0-853b-ac3a9701e15e", "AQAAAAIAAYagAAAAEHajF87Bs4lVc2bzZm1oI0w5Ofexaz7snF2HJ9AUSIe106zw+PfeaoS885eEy5TZVQ==", "45b54756-9d46-4ff5-97b4-fcc61bc679b5" });

            migrationBuilder.InsertData(
                table: "Friends",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Name", "UpdatedAt", "UpdatedBy", "UserID" },
                values: new object[,]
                {
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Chee Peng", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Ding Tan", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null }
                });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "CreatedBy", "UpdatedAt", "UpdatedBy" },
                values: new object[] { new DateTime(2026, 1, 17, 16, 13, 3, 670, DateTimeKind.Local).AddTicks(8943), "System", new DateTime(2026, 1, 17, 16, 13, 3, 670, DateTimeKind.Local).AddTicks(8944), "System" });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "CreatedBy", "UpdatedAt", "UpdatedBy" },
                values: new object[] { new DateTime(2026, 1, 17, 16, 13, 3, 670, DateTimeKind.Local).AddTicks(8945), "System", new DateTime(2026, 1, 17, 16, 13, 3, 670, DateTimeKind.Local).AddTicks(8946), "System" });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "CreatedBy", "UpdatedAt", "UpdatedBy" },
                values: new object[] { new DateTime(2026, 1, 17, 16, 13, 3, 670, DateTimeKind.Local).AddTicks(8947), "System", new DateTime(2026, 1, 17, 16, 13, 3, 670, DateTimeKind.Local).AddTicks(8947), "System" });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "CreatedBy", "UpdatedAt", "UpdatedBy" },
                values: new object[] { new DateTime(2026, 1, 17, 16, 13, 3, 670, DateTimeKind.Local).AddTicks(8949), "System", new DateTime(2026, 1, 17, 16, 13, 3, 670, DateTimeKind.Local).AddTicks(8949), "System" });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "CreatedBy", "UpdatedAt", "UpdatedBy" },
                values: new object[] { new DateTime(2026, 1, 17, 16, 13, 3, 670, DateTimeKind.Local).AddTicks(8843), "System", new DateTime(2026, 1, 17, 16, 13, 3, 670, DateTimeKind.Local).AddTicks(8858), "System" });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "CreatedBy", "UpdatedAt", "UpdatedBy" },
                values: new object[] { new DateTime(2026, 1, 17, 16, 13, 3, 670, DateTimeKind.Local).AddTicks(8860), "System", new DateTime(2026, 1, 17, 16, 13, 3, 670, DateTimeKind.Local).AddTicks(8861), "System" });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "CreatedBy", "UpdatedAt", "UpdatedBy" },
                values: new object[] { new DateTime(2026, 1, 17, 16, 13, 3, 670, DateTimeKind.Local).AddTicks(8862), "System", new DateTime(2026, 1, 17, 16, 13, 3, 670, DateTimeKind.Local).AddTicks(8863), "System" });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "CreatedBy", "UpdatedAt", "UpdatedBy" },
                values: new object[] { new DateTime(2026, 1, 17, 16, 13, 3, 670, DateTimeKind.Local).AddTicks(8864), "System", new DateTime(2026, 1, 17, 16, 13, 3, 670, DateTimeKind.Local).AddTicks(8864), "System" });

            migrationBuilder.InsertData(
                table: "MusicDiscovery",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "SongId", "UpdatedAt", "UpdatedBy", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0 },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0 }
                });

            migrationBuilder.InsertData(
                table: "MyPlaylist",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Description", "Name", "UpdatedAt", "UpdatedBy", "UserID" },
                values: new object[,]
                {
                    { 1, new DateTime(2026, 1, 17, 16, 13, 3, 670, DateTimeKind.Local).AddTicks(9642), "System", " ", "Chill Tunes", new DateTime(2026, 1, 17, 16, 13, 3, 670, DateTimeKind.Local).AddTicks(9643), "System", null },
                    { 3, new DateTime(2026, 1, 17, 16, 13, 3, 670, DateTimeKind.Local).AddTicks(9645), "System", " ", "Study Music", new DateTime(2026, 1, 17, 16, 13, 3, 670, DateTimeKind.Local).AddTicks(9646), "System", null }
                });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AlbumId", "ArtistId", "CreatedAt", "CreatedBy", "GenreId", "UpdatedAt", "UpdatedBy" },
                values: new object[] { 0, 0, new DateTime(2026, 1, 17, 16, 13, 3, 670, DateTimeKind.Local).AddTicks(9256), "System", 0, new DateTime(2026, 1, 17, 16, 13, 3, 670, DateTimeKind.Local).AddTicks(9256), "System" });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AlbumId", "ArtistId", "CreatedAt", "CreatedBy", "GenreId", "UpdatedAt", "UpdatedBy" },
                values: new object[] { 0, 0, new DateTime(2026, 1, 17, 16, 13, 3, 670, DateTimeKind.Local).AddTicks(9258), "System", 0, new DateTime(2026, 1, 17, 16, 13, 3, 670, DateTimeKind.Local).AddTicks(9258), "System" });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AlbumId", "ArtistId", "CreatedAt", "CreatedBy", "GenreId", "UpdatedAt", "UpdatedBy" },
                values: new object[] { 0, 0, new DateTime(2026, 1, 17, 16, 13, 3, 670, DateTimeKind.Local).AddTicks(9259), "System", 0, new DateTime(2026, 1, 17, 16, 13, 3, 670, DateTimeKind.Local).AddTicks(9260), "System" });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AlbumId", "ArtistId", "CreatedAt", "CreatedBy", "GenreId", "UpdatedAt", "UpdatedBy" },
                values: new object[] { 0, 0, new DateTime(2026, 1, 17, 16, 13, 3, 670, DateTimeKind.Local).AddTicks(9261), "System", 0, new DateTime(2026, 1, 17, 16, 13, 3, 670, DateTimeKind.Local).AddTicks(9261), "System" });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AlbumId", "ArtistId", "CreatedAt", "CreatedBy", "GenreId", "UpdatedAt", "UpdatedBy" },
                values: new object[] { 0, 0, new DateTime(2026, 1, 17, 16, 13, 3, 670, DateTimeKind.Local).AddTicks(9262), "System", 0, new DateTime(2026, 1, 17, 16, 13, 3, 670, DateTimeKind.Local).AddTicks(9263), "System" });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AlbumId", "ArtistId", "CreatedAt", "CreatedBy", "GenreId", "UpdatedAt", "UpdatedBy" },
                values: new object[] { 0, 0, new DateTime(2026, 1, 17, 16, 13, 3, 670, DateTimeKind.Local).AddTicks(9264), "System", 0, new DateTime(2026, 1, 17, 16, 13, 3, 670, DateTimeKind.Local).AddTicks(9264), "System" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Friends",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Friends",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "MusicDiscovery",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "MusicDiscovery",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "MyPlaylist",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "MyPlaylist",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "User");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "User");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "User");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "User");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Songs");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Songs");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Songs");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "Songs");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "MyPlaylist");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "MyPlaylist");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "MyPlaylist");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "MyPlaylist");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "MusicDiscovery");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "MusicDiscovery");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "MusicDiscovery");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "MusicDiscovery");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Moods");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Moods");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Moods");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "Moods");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Genres");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Genres");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Genres");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "Genres");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Friends");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Friends");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Friends");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "Friends");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Artists");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Artists");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Artists");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "Artists");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Albums");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Albums");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Albums");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "Albums");

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 1,
                column: "GenreId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 2,
                column: "GenreId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 3,
                column: "GenreId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "00d9f8d1-b5c5-42da-b146-efa573746538", "AQAAAAIAAYagAAAAED/f5Kojerbu4Cy1ht2ioP8KJ1eoHe5cizPkXWsqeEMgtdREa2DuGODH70QFRt4aVw==", "d2bcbe2d-d310-4d07-8e78-d968f0418d03" });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AlbumId", "ArtistId", "GenreId" },
                values: new object[] { 1, 1, 1 });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AlbumId", "ArtistId", "GenreId" },
                values: new object[] { 1, 1, 2 });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AlbumId", "ArtistId", "GenreId" },
                values: new object[] { 2, 2, 2 });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AlbumId", "ArtistId", "GenreId" },
                values: new object[] { 2, 2, 3 });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AlbumId", "ArtistId", "GenreId" },
                values: new object[] { 3, 3, 1 });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AlbumId", "ArtistId", "GenreId" },
                values: new object[] { 3, 3, 1 });
        }
    }
}
