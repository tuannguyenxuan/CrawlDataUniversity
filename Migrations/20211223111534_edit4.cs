using Microsoft.EntityFrameworkCore.Migrations;

namespace CrawlDataUniversity.Migrations
{
    public partial class edit4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Universities_Addresses_AddressId",
                table: "Universities");

            migrationBuilder.DropForeignKey(
                name: "FK_Universities_Provinces_ProvinceId",
                table: "Universities");

            migrationBuilder.DropIndex(
                name: "IX_Universities_AddressId",
                table: "Universities");

            migrationBuilder.DropIndex(
                name: "IX_Universities_ProvinceId",
                table: "Universities");

            migrationBuilder.DropColumn(
                name: "ProvinceId",
                table: "Universities");

            migrationBuilder.RenameColumn(
                name: "Province",
                table: "Addresses",
                newName: "ProvinceName");

            migrationBuilder.AddColumn<int>(
                name: "UniversityId",
                table: "Addresses",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_ProvinceId",
                table: "Addresses",
                column: "ProvinceId");

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_UniversityId",
                table: "Addresses",
                column: "UniversityId");

            migrationBuilder.AddForeignKey(
                name: "FK_Addresses_Provinces_ProvinceId",
                table: "Addresses",
                column: "ProvinceId",
                principalTable: "Provinces",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Addresses_Universities_UniversityId",
                table: "Addresses",
                column: "UniversityId",
                principalTable: "Universities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Addresses_Provinces_ProvinceId",
                table: "Addresses");

            migrationBuilder.DropForeignKey(
                name: "FK_Addresses_Universities_UniversityId",
                table: "Addresses");

            migrationBuilder.DropIndex(
                name: "IX_Addresses_ProvinceId",
                table: "Addresses");

            migrationBuilder.DropIndex(
                name: "IX_Addresses_UniversityId",
                table: "Addresses");

            migrationBuilder.DropColumn(
                name: "UniversityId",
                table: "Addresses");

            migrationBuilder.RenameColumn(
                name: "ProvinceName",
                table: "Addresses",
                newName: "Province");

            migrationBuilder.AddColumn<int>(
                name: "ProvinceId",
                table: "Universities",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Universities_AddressId",
                table: "Universities",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Universities_ProvinceId",
                table: "Universities",
                column: "ProvinceId");

            migrationBuilder.AddForeignKey(
                name: "FK_Universities_Addresses_AddressId",
                table: "Universities",
                column: "AddressId",
                principalTable: "Addresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Universities_Provinces_ProvinceId",
                table: "Universities",
                column: "ProvinceId",
                principalTable: "Provinces",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
