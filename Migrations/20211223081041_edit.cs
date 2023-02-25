using Microsoft.EntityFrameworkCore.Migrations;

namespace CrawlDataUniversity.Migrations
{
    public partial class edit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UniversityMajors_Universities_UniversityId",
                table: "UniversityMajors");

            migrationBuilder.AlterColumn<int>(
                name: "UniversityId",
                table: "UniversityMajors",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_UniversityMajors_Universities_UniversityId",
                table: "UniversityMajors",
                column: "UniversityId",
                principalTable: "Universities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UniversityMajors_Universities_UniversityId",
                table: "UniversityMajors");

            migrationBuilder.AlterColumn<int>(
                name: "UniversityId",
                table: "UniversityMajors",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_UniversityMajors_Universities_UniversityId",
                table: "UniversityMajors",
                column: "UniversityId",
                principalTable: "Universities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
