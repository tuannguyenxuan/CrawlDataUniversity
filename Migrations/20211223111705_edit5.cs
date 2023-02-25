using Microsoft.EntityFrameworkCore.Migrations;

namespace CrawlDataUniversity.Migrations
{
    public partial class edit5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AddressId",
                table: "Universities");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AddressId",
                table: "Universities",
                type: "int",
                nullable: true);
        }
    }
}
