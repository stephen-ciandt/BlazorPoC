using Microsoft.EntityFrameworkCore.Migrations;

namespace MusicLibraryServer.Migrations
{
    public partial class SeedAlbumTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Albums",
                columns: new[] { "Id", "Artist", "Artists", "Engineer", "Is45rpm", "IsMono", "Label", "Notes", "Number", "Rating", "ReleaseYear", "Title", "Year" },
                values: new object[] { 1, "ABBA", "ABBA", "", true, false, "Abbey Road Studios", "", (short)0, (byte)8, (short)2016, "The Album", (short)1977 });

            migrationBuilder.InsertData(
                table: "Albums",
                columns: new[] { "Id", "Artist", "Artists", "Engineer", "Is45rpm", "IsMono", "Label", "Notes", "Number", "Rating", "ReleaseYear", "Title", "Year" },
                values: new object[] { 2, "ABBA", "ABBA", "", true, false, "Abbey Road Studios", "", (short)0, (byte)8, (short)2016, "The Album", (short)1977 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
