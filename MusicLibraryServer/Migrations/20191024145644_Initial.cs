using Microsoft.EntityFrameworkCore.Migrations;

namespace MusicLibraryServer.Migrations
{
    public partial class Initial : Migration
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Albums");
        }
    }
}
