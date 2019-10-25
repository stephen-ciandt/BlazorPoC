using Microsoft.EntityFrameworkCore.Migrations;

namespace MusicLibrary.Server.Migrations
{
    public partial class Initialise : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Albums",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsMono = table.Column<bool>(nullable: false),
                    Is45rpm = table.Column<bool>(nullable: false),
                    Rating = table.Column<byte>(nullable: false),
                    Year = table.Column<short>(nullable: false),
                    Number = table.Column<short>(nullable: false),
                    ReleaseYear = table.Column<short>(nullable: false),
                    Label = table.Column<string>(nullable: false),
                    Notes = table.Column<string>(nullable: false),
                    Title = table.Column<string>(nullable: false),
                    Artist = table.Column<string>(nullable: false),
                    Artists = table.Column<string>(nullable: false),
                    Engineer = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Albums", x => x.Id);
                });

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
            migrationBuilder.DropTable(
                name: "Albums");
        }
    }
}
