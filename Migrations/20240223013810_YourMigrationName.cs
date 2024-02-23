using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mission06_Imerlishvili.Migrations
{
    public partial class YourMigrationName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Plex",
                table: "Applications",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Plex",
                table: "Applications");
        }
    }
}
