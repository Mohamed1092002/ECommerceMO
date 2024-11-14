using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ECommerce.API.Migrations
{
    /// <inheritdoc />
    public partial class Seed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
    table: "Categories",
    columns: ["Id", "Description", "Name"],
    values: new object[,]
    {
            { 1, "Electronics items", "Electronics" },
            { 2, "Clothing items", "Clothing" },
            { 3, "Home and Kitchen items", "Home & Kitchen" }
    }
);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
    table: "Category",
    keyColumn: "Id",
    keyValues: [1, 2, 3]
);
        }
    }
}
