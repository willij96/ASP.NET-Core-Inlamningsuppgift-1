using Microsoft.EntityFrameworkCore.Migrations;

namespace FreakyFashion1.Migrations
{
    public partial class v3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ProductCategory",
                columns: new[] { "ProductId", "CategoryId" },
                values: new object[] { 2, 4 });

            migrationBuilder.InsertData(
                table: "ProductCategory",
                columns: new[] { "ProductId", "CategoryId" },
                values: new object[] { 3, 4 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumns: new[] { "ProductId", "CategoryId" },
                keyValues: new object[] { 2, 4 });

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumns: new[] { "ProductId", "CategoryId" },
                keyValues: new object[] { 3, 4 });
        }
    }
}
