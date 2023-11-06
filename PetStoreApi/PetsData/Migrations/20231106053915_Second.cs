using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PetsData.Migrations
{
    /// <inheritdoc />
    public partial class Second : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Price",
                table: "Pets");

            migrationBuilder.AddColumn<int>(
                name: "PetCategoryId",
                table: "ProductCategories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_ProductCategories_PetCategoryId",
                table: "ProductCategories",
                column: "PetCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductCategories_PetCategories_PetCategoryId",
                table: "ProductCategories",
                column: "PetCategoryId",
                principalTable: "PetCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductCategories_PetCategories_PetCategoryId",
                table: "ProductCategories");

            migrationBuilder.DropIndex(
                name: "IX_ProductCategories_PetCategoryId",
                table: "ProductCategories");

            migrationBuilder.DropColumn(
                name: "PetCategoryId",
                table: "ProductCategories");

            migrationBuilder.AddColumn<float>(
                name: "Price",
                table: "Pets",
                type: "real",
                nullable: false,
                defaultValue: 0f);
        }
    }
}
