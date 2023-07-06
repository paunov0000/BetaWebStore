using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AspNetCoreTemplate.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedIMGUrlsToTheEntities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SubCategoryImageURL",
                table: "SubCategories",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CategoryImageURL",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SubCategoryImageURL",
                table: "SubCategories");

            migrationBuilder.DropColumn(
                name: "CategoryImageURL",
                table: "Categories");
        }
    }
}
