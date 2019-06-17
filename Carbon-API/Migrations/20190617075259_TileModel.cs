using Microsoft.EntityFrameworkCore.Migrations;

namespace Carbon_API.Migrations
{
    public partial class TileModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tiles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    type = table.Column<int>(nullable: false),
                    description = table.Column<string>(nullable: true),
                    info = table.Column<string>(nullable: true),
                    money = table.Column<int>(nullable: false),
                    army = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tiles", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tiles");
        }
    }
}
