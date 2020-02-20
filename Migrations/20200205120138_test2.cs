using Microsoft.EntityFrameworkCore.Migrations;

namespace FreakyFashion1.Migrations
{
    public partial class test2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ArticleNumber", "ImageUrl", "Name", "Price" },
                values: new object[] { "100", "https://via.placeholder.com/200x360.png?text=Moon", "T-shirt", 499m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ArticleNumber", "ImageUrl", "Price" },
                values: new object[] { "200", "https://via.placeholder.com/200x360.png?text=Mars", 399m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ArticleNumber", "ImageUrl", "Price" },
                values: new object[] { "100", "https://via.placeholder.com/200x360.png?text=Moon", 499m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ArticleNumber", "ImageUrl", "Price" },
                values: new object[] { "200", "https://via.placeholder.com/200x360.png?text=Mars", 399m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ArticleNumber", "ImageUrl", "Price" },
                values: new object[] { "100", "https://via.placeholder.com/200x360.png?text=Moon", 499m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "ArticleNumber", "ImageUrl", "Price" },
                values: new object[] { "200", "https://via.placeholder.com/200x360.png?text=Mars", 399m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "ArticleNumber", "ImageUrl", "Name", "Price" },
                values: new object[] { "100", "https://via.placeholder.com/200x360.png?text=Moon", "Byxor", 499m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 18,
                column: "Name",
                value: "Byxor");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "ArticleNumber", "ImageUrl", "Price" },
                values: new object[] { "200", "https://via.placeholder.com/200x360.png?text=Mars", 399m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "ArticleNumber", "ImageUrl", "Price" },
                values: new object[] { "100", "https://via.placeholder.com/200x360.png?text=Moon", 499m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "ArticleNumber", "ImageUrl", "Price" },
                values: new object[] { "200", "https://via.placeholder.com/200x360.png?text=Mars", 399m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "ArticleNumber", "ImageUrl", "Price" },
                values: new object[] { "100", "https://via.placeholder.com/200x360.png?text=Moon", 499m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ArticleNumber", "ImageUrl", "Name", "Price" },
                values: new object[] { "200", "https://via.placeholder.com/200x360.png?text=Mars", "Klänning", 399m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ArticleNumber", "ImageUrl", "Price" },
                values: new object[] { "100", "https://via.placeholder.com/200x360.png?text=Moon", 499m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ArticleNumber", "ImageUrl", "Price" },
                values: new object[] { "200", "https://via.placeholder.com/200x360.png?text=Mars", 399m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ArticleNumber", "ImageUrl", "Price" },
                values: new object[] { "100", "https://via.placeholder.com/200x360.png?text=Moon", 499m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ArticleNumber", "ImageUrl", "Price" },
                values: new object[] { "200", "https://via.placeholder.com/200x360.png?text=Mars", 399m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "ArticleNumber", "ImageUrl", "Price" },
                values: new object[] { "100", "https://via.placeholder.com/200x360.png?text=Moon", 499m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "ArticleNumber", "ImageUrl", "Name", "Price" },
                values: new object[] { "200", "https://via.placeholder.com/200x360.png?text=Mars", "T-shirt", 399m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 18,
                column: "Name",
                value: "T-shirt");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "ArticleNumber", "ImageUrl", "Price" },
                values: new object[] { "100", "https://via.placeholder.com/200x360.png?text=Moon", 499m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "ArticleNumber", "ImageUrl", "Price" },
                values: new object[] { "200", "https://via.placeholder.com/200x360.png?text=Mars", 399m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "ArticleNumber", "ImageUrl", "Price" },
                values: new object[] { "100", "https://via.placeholder.com/200x360.png?text=Moon", 499m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "ArticleNumber", "ImageUrl", "Price" },
                values: new object[] { "200", "https://via.placeholder.com/200x360.png?text=Mars", 399m });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "ArticleNumber", "Description", "ImageUrl", "Name", "Price" },
                values: new object[,]
                {
                    { 25, "100", "Lorem ipsum dolor", "https://via.placeholder.com/200x360.png?text=Moon", "Byxor", 499m },
                    { 26, "200", "Lorem ipsum dolor", "https://via.placeholder.com/200x360.png?text=Mars", "Byxor", 399m },
                    { 27, "200", "Lorem ipsum dolor", "https://via.placeholder.com/200x360.png?text=Mars", "Byxor", 399m }
                });
        }
    }
}
