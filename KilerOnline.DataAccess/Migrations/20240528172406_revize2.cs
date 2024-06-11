using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KilerOnline.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class revize2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Regions_Categories_CategoryId",
                table: "Regions");

            migrationBuilder.DropIndex(
                name: "IX_Regions_CategoryId",
                table: "Regions");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Regions");

            migrationBuilder.DropColumn(
                name: "FoodId",
                table: "Regions");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "Regions");

            migrationBuilder.AddColumn<int>(
                name: "RegionId",
                table: "Foods",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Foods_RegionId",
                table: "Foods",
                column: "RegionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Foods_Regions_RegionId",
                table: "Foods",
                column: "RegionId",
                principalTable: "Regions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Foods_Regions_RegionId",
                table: "Foods");

            migrationBuilder.DropIndex(
                name: "IX_Foods_RegionId",
                table: "Foods");

            migrationBuilder.DropColumn(
                name: "RegionId",
                table: "Foods");

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Regions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "FoodId",
                table: "Regions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ProductId",
                table: "Regions",
                type: "int",
                maxLength: 50,
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Regions_CategoryId",
                table: "Regions",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Regions_Categories_CategoryId",
                table: "Regions",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
