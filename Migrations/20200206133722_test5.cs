using Microsoft.EntityFrameworkCore.Migrations;

namespace FreakyFashion1.Migrations
{
    public partial class test5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 17,
                column: "ImageUrl",
                value: "/images/jeans.jpg");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 18,
                column: "ImageUrl",
                value: "/images/jeans.jpg");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 19,
                column: "ImageUrl",
                value: "/images/jeans.jpg");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 20,
                column: "ImageUrl",
                value: "/images/jeans.jpg");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 21,
                column: "ImageUrl",
                value: "/images/jeans.jpg");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 22,
                column: "ImageUrl",
                value: "/images/jeans.jpg");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 23,
                column: "ImageUrl",
                value: "/images/jeans.jpg");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 24,
                column: "ImageUrl",
                value: "/images/jeans.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 17,
                column: "ImageUrl",
                value: "https://via.placeholder.com/200x360.png?text=Moon");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 18,
                column: "ImageUrl",
                value: "https://via.placeholder.com/200x360.png?text=Mars");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 19,
                column: "ImageUrl",
                value: "https://via.placeholder.com/200x360.png?text=Mars");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 20,
                column: "ImageUrl",
                value: "https://via.placeholder.com/200x360.png?text=Moon");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 21,
                column: "ImageUrl",
                value: "https://via.placeholder.com/200x360.png?text=Mars");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 22,
                column: "ImageUrl",
                value: "https://via.placeholder.com/200x360.png?text=Mars");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 23,
                column: "ImageUrl",
                value: "https://via.placeholder.com/200x360.png?text=Moon");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 24,
                column: "ImageUrl",
                value: "https://via.placeholder.com/200x360.png?text=Mars");
        }
    }
}
