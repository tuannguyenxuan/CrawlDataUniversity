using Microsoft.EntityFrameworkCore.Migrations;

namespace CrawlDataUniversity.Migrations
{
    public partial class edit2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Universities_Address_AddressId",
                table: "Universities");

            migrationBuilder.DropIndex(
                name: "IX_Universities_AddressId",
                table: "Universities");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Address",
                table: "Address");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Address");

            migrationBuilder.RenameTable(
                name: "Address",
                newName: "Addresses");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "Addresses",
                newName: "Address");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Address",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Address",
                table: "Address",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Universities_AddressId",
                table: "Universities",
                column: "AddressId");

            migrationBuilder.AddForeignKey(
                name: "FK_Universities_Address_AddressId",
                table: "Universities",
                column: "AddressId",
                principalTable: "Address",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
