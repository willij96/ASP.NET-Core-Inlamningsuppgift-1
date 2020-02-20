using Microsoft.EntityFrameworkCore.Migrations;

namespace FreakyFashion1.Migrations
{
    public partial class test7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumns: new[] { "ProductId", "CategoryId" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumns: new[] { "ProductId", "CategoryId" },
                keyValues: new object[] { 5, 3 });

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumns: new[] { "ProductId", "CategoryId" },
                keyValues: new object[] { 6, 3 });

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumns: new[] { "ProductId", "CategoryId" },
                keyValues: new object[] { 8, 2 });

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumns: new[] { "ProductId", "CategoryId" },
                keyValues: new object[] { 9, 1 });

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumns: new[] { "ProductId", "CategoryId" },
                keyValues: new object[] { 11, 3 });

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumns: new[] { "ProductId", "CategoryId" },
                keyValues: new object[] { 12, 1 });

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumns: new[] { "ProductId", "CategoryId" },
                keyValues: new object[] { 15, 3 });

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumns: new[] { "ProductId", "CategoryId" },
                keyValues: new object[] { 16, 3 });

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumns: new[] { "ProductId", "CategoryId" },
                keyValues: new object[] { 17, 1 });

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumns: new[] { "ProductId", "CategoryId" },
                keyValues: new object[] { 20, 1 });

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumns: new[] { "ProductId", "CategoryId" },
                keyValues: new object[] { 21, 2 });

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumns: new[] { "ProductId", "CategoryId" },
                keyValues: new object[] { 22, 2 });

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumns: new[] { "ProductId", "CategoryId" },
                keyValues: new object[] { 23, 2 });

            migrationBuilder.InsertData(
                table: "ProductCategory",
                columns: new[] { "ProductId", "CategoryId" },
                values: new object[,]
                {
                    { 9, 2 },
                    { 17, 3 },
                    { 20, 3 },
                    { 12, 2 },
                    { 21, 3 },
                    { 3, 1 },
                    { 22, 3 },
                    { 8, 1 },
                    { 23, 3 },
                    { 16, 2 },
                    { 5, 1 },
                    { 15, 2 },
                    { 11, 2 },
                    { 6, 1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumns: new[] { "ProductId", "CategoryId" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumns: new[] { "ProductId", "CategoryId" },
                keyValues: new object[] { 5, 1 });

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumns: new[] { "ProductId", "CategoryId" },
                keyValues: new object[] { 6, 1 });

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumns: new[] { "ProductId", "CategoryId" },
                keyValues: new object[] { 8, 1 });

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumns: new[] { "ProductId", "CategoryId" },
                keyValues: new object[] { 9, 2 });

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumns: new[] { "ProductId", "CategoryId" },
                keyValues: new object[] { 11, 2 });

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumns: new[] { "ProductId", "CategoryId" },
                keyValues: new object[] { 12, 2 });

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumns: new[] { "ProductId", "CategoryId" },
                keyValues: new object[] { 15, 2 });

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumns: new[] { "ProductId", "CategoryId" },
                keyValues: new object[] { 16, 2 });

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumns: new[] { "ProductId", "CategoryId" },
                keyValues: new object[] { 17, 3 });

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumns: new[] { "ProductId", "CategoryId" },
                keyValues: new object[] { 20, 3 });

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumns: new[] { "ProductId", "CategoryId" },
                keyValues: new object[] { 21, 3 });

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumns: new[] { "ProductId", "CategoryId" },
                keyValues: new object[] { 22, 3 });

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumns: new[] { "ProductId", "CategoryId" },
                keyValues: new object[] { 23, 3 });

            migrationBuilder.InsertData(
                table: "ProductCategory",
                columns: new[] { "ProductId", "CategoryId" },
                values: new object[,]
                {
                    { 9, 1 },
                    { 17, 1 },
                    { 20, 1 },
                    { 12, 1 },
                    { 21, 2 },
                    { 3, 2 },
                    { 22, 2 },
                    { 8, 2 },
                    { 23, 2 },
                    { 16, 3 },
                    { 5, 3 },
                    { 15, 3 },
                    { 11, 3 },
                    { 6, 3 }
                });
        }
    }
}
