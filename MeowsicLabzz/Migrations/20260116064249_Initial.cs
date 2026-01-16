using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MeowsicLabzz.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Duration",
                table: "Songs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Genres",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "Artists",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "GenreId",
                table: "Albums",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Friends",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Friends", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MusicDiscovery",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    SongId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MusicDiscovery", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MyPlaylist",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MyPlaylist", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

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
                table: "Artists",
                keyColumn: "Id",
                keyValue: 1,
                column: "Gender",
                value: null);

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 2,
                column: "Gender",
                value: null);

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 3,
                column: "Gender",
                value: null);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "00d9f8d1-b5c5-42da-b146-efa573746538", "AQAAAAIAAYagAAAAED/f5Kojerbu4Cy1ht2ioP8KJ1eoHe5cizPkXWsqeEMgtdREa2DuGODH70QFRt4aVw==", "d2bcbe2d-d310-4d07-8e78-d968f0418d03" });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 1,
                column: "Description",
                value: null);

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 2,
                column: "Description",
                value: null);

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 3,
                column: "Description",
                value: null);

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 4,
                column: "Description",
                value: null);

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 1,
                column: "Duration",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 2,
                column: "Duration",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 3,
                column: "Duration",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 4,
                column: "Duration",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 5,
                column: "Duration",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 6,
                column: "Duration",
                value: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Friends");

            migrationBuilder.DropTable(
                name: "MusicDiscovery");

            migrationBuilder.DropTable(
                name: "MyPlaylist");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropColumn(
                name: "Duration",
                table: "Songs");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Genres");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "Artists");

            migrationBuilder.DropColumn(
                name: "GenreId",
                table: "Albums");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b5b732ab-8412-4fe5-82d9-ebbc495fa0d4", "AQAAAAIAAYagAAAAEKlp7XuApZqo8HYEM79Poi9hvubG57exXqV7LQ79SPfJks6q07HFyXy/z2GRqV/5Fg==", "3f92abbd-84ed-41c1-8af1-508e074d0c8a" });
        }
    }
}
