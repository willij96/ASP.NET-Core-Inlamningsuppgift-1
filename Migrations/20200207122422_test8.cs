using Microsoft.EntityFrameworkCore.Migrations;

namespace FreakyFashion1.Migrations
{
    public partial class test8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumns: new[] { "ProductId", "CategoryId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumns: new[] { "ProductId", "CategoryId" },
                keyValues: new object[] { 4, 1 });

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumns: new[] { "ProductId", "CategoryId" },
                keyValues: new object[] { 6, 1 });

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumns: new[] { "ProductId", "CategoryId" },
                keyValues: new object[] { 7, 1 });

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumns: new[] { "ProductId", "CategoryId" },
                keyValues: new object[] { 9, 2 });

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumns: new[] { "ProductId", "CategoryId" },
                keyValues: new object[] { 10, 2 });

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumns: new[] { "ProductId", "CategoryId" },
                keyValues: new object[] { 12, 2 });

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumns: new[] { "ProductId", "CategoryId" },
                keyValues: new object[] { 14, 2 });

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
                keyValues: new object[] { 18, 3 });

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
                keyValues: new object[] { 23, 3 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ArticleNumber", "ImageUrl", "Name", "Price" },
                values: new object[] { "100", "/images/Prada.jpg", "T-shirt", 499m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ImageUrl", "Name" },
                values: new object[] { "/images/jeans.jpg", "Byxor" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ArticleNumber", "Price" },
                values: new object[] { "100", 499m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ArticleNumber", "ImageUrl", "Name", "Price" },
                values: new object[] { "100", "/images/jeans.jpg", "Byxor", 499m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ImageUrl", "Name" },
                values: new object[] { "/images/Prada.jpg", "T-shirt" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ArticleNumber", "Price" },
                values: new object[] { "100", 499m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ArticleNumber", "ImageUrl", "Name", "Price" },
                values: new object[] { "200", "/images/jeans.jpg", "Byxor", 399m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ImageUrl", "Name" },
                values: new object[] { "/images/beicheDress.jpg", "Klänning" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ArticleNumber", "ImageUrl", "Name", "Price" },
                values: new object[] { "200", "/images/jeans.jpg", "Byxor", 399m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ImageUrl", "Name" },
                values: new object[] { "/images/beicheDress.jpg", "Klänning" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ArticleNumber", "Price" },
                values: new object[] { "200", 399m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "ArticleNumber", "ImageUrl", "Name", "Price" },
                values: new object[] { "100", "/images/jeans.jpg", "Byxor", 499m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "ArticleNumber", "ImageUrl", "Name", "Price" },
                values: new object[] { "200", "/images/Prada.jpg", "T-shirt", 399m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "ImageUrl", "Name" },
                values: new object[] { "/images/beicheDress.jpg", "Klänning" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "ImageUrl", "Name" },
                values: new object[] { "/images/Prada.jpg", "T-shirt" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "ImageUrl", "Name" },
                values: new object[] { "/images/Prada.jpg", "T-shirt" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "ArticleNumber", "ImageUrl", "Name", "Price" },
                values: new object[] { "200", "/images/beicheDress.jpg", "Klänning", 399m });

            migrationBuilder.InsertData(
                table: "ProductCategory",
                columns: new[] { "ProductId", "CategoryId" },
                values: new object[,]
                {
                    { 9, 3 },
                    { 4, 3 },
                    { 6, 3 },
                    { 23, 1 },
                    { 21, 2 },
                    { 20, 2 },
                    { 18, 1 },
                    { 17, 2 },
                    { 16, 3 },
                    { 14, 1 },
                    { 12, 3 },
                    { 10, 1 },
                    { 7, 2 },
                    { 2, 2 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumns: new[] { "ProductId", "CategoryId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumns: new[] { "ProductId", "CategoryId" },
                keyValues: new object[] { 4, 3 });

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumns: new[] { "ProductId", "CategoryId" },
                keyValues: new object[] { 6, 3 });

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumns: new[] { "ProductId", "CategoryId" },
                keyValues: new object[] { 7, 2 });

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumns: new[] { "ProductId", "CategoryId" },
                keyValues: new object[] { 9, 3 });

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumns: new[] { "ProductId", "CategoryId" },
                keyValues: new object[] { 10, 1 });

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumns: new[] { "ProductId", "CategoryId" },
                keyValues: new object[] { 12, 3 });

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumns: new[] { "ProductId", "CategoryId" },
                keyValues: new object[] { 14, 1 });

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumns: new[] { "ProductId", "CategoryId" },
                keyValues: new object[] { 16, 3 });

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumns: new[] { "ProductId", "CategoryId" },
                keyValues: new object[] { 17, 2 });

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumns: new[] { "ProductId", "CategoryId" },
                keyValues: new object[] { 18, 1 });

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumns: new[] { "ProductId", "CategoryId" },
                keyValues: new object[] { 20, 2 });

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumns: new[] { "ProductId", "CategoryId" },
                keyValues: new object[] { 21, 2 });

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumns: new[] { "ProductId", "CategoryId" },
                keyValues: new object[] { 23, 1 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ArticleNumber", "ImageUrl", "Name", "Price" },
                values: new object[] { "200", "/images/beicheDress.jpg", "Klänning", 399m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ImageUrl", "Name" },
                values: new object[] { "/images/beicheDress.jpg", "Klänning" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ArticleNumber", "Price" },
                values: new object[] { "200", 399m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ArticleNumber", "ImageUrl", "Name", "Price" },
                values: new object[] { "200", "/images/beicheDress.jpg", "Klänning", 399m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ImageUrl", "Name" },
                values: new object[] { "/images/beicheDress.jpg", "Klänning" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ArticleNumber", "Price" },
                values: new object[] { "200", 399m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ArticleNumber", "ImageUrl", "Name", "Price" },
                values: new object[] { "100", "/images/Prada.jpg", "T-shirt", 499m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ImageUrl", "Name" },
                values: new object[] { "/images/Prada.jpg", "T-shirt" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ArticleNumber", "ImageUrl", "Name", "Price" },
                values: new object[] { "100", "/images/Prada.jpg", "T-shirt", 499m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ImageUrl", "Name" },
                values: new object[] { "/images/Prada.jpg", "T-shirt" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ArticleNumber", "Price" },
                values: new object[] { "100", 499m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "ArticleNumber", "ImageUrl", "Name", "Price" },
                values: new object[] { "200", "/images/Prada.jpg", "T-shirt", 399m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "ArticleNumber", "ImageUrl", "Name", "Price" },
                values: new object[] { "100", "/images/jeans.jpg", "Byxor", 499m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "ImageUrl", "Name" },
                values: new object[] { "/images/jeans.jpg", "Byxor" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "ImageUrl", "Name" },
                values: new object[] { "/images/jeans.jpg", "Byxor" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "ImageUrl", "Name" },
                values: new object[] { "/images/jeans.jpg", "Byxor" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "ArticleNumber", "ImageUrl", "Name", "Price" },
                values: new object[] { "100", "/images/jeans.jpg", "Byxor", 499m });

            migrationBuilder.InsertData(
                table: "ProductCategory",
                columns: new[] { "ProductId", "CategoryId" },
                values: new object[,]
                {
                    { 18, 3 },
                    { 16, 2 },
                    { 23, 3 },
                    { 14, 2 },
                    { 10, 2 },
                    { 21, 3 },
                    { 7, 1 },
                    { 12, 2 },
                    { 20, 3 },
                    { 4, 1 },
                    { 17, 3 },
                    { 2, 1 },
                    { 6, 1 },
                    { 9, 2 }
                });
        }
    }
}
