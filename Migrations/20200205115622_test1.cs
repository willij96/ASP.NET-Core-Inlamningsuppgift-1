using Microsoft.EntityFrameworkCore.Migrations;

namespace FreakyFashion1.Migrations
{
    public partial class test1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Klänning");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Klänning");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Klänning");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "Klänning");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: "Klänning");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 6,
                column: "Name",
                value: "Klänning");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 7,
                column: "Name",
                value: "Klänning");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 8,
                column: "Name",
                value: "Klänning");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 9,
                column: "Name",
                value: "Klänning");

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "ArticleNumber", "Description", "ImageUrl", "Name", "Price" },
                values: new object[,]
                {
                    { 27, "200", "Lorem ipsum dolor", "https://via.placeholder.com/200x360.png?text=Mars", "Byxor", 399m },
                    { 26, "200", "Lorem ipsum dolor", "https://via.placeholder.com/200x360.png?text=Mars", "Byxor", 399m },
                    { 25, "100", "Lorem ipsum dolor", "https://via.placeholder.com/200x360.png?text=Moon", "Byxor", 499m },
                    { 24, "200", "Lorem ipsum dolor", "https://via.placeholder.com/200x360.png?text=Mars", "Byxor", 399m },
                    { 23, "200", "Lorem ipsum dolor", "https://via.placeholder.com/200x360.png?text=Mars", "Byxor", 399m },
                    { 21, "200", "Lorem ipsum dolor", "https://via.placeholder.com/200x360.png?text=Mars", "Byxor", 399m },
                    { 20, "200", "Lorem ipsum dolor", "https://via.placeholder.com/200x360.png?text=Mars", "Byxor", 399m },
                    { 19, "100", "Lorem ipsum dolor", "https://via.placeholder.com/200x360.png?text=Moon", "Byxor", 499m },
                    { 18, "200", "Lorem ipsum dolor", "https://via.placeholder.com/200x360.png?text=Mars", "T-shirt", 399m },
                    { 17, "200", "Lorem ipsum dolor", "https://via.placeholder.com/200x360.png?text=Mars", "T-shirt", 399m },
                    { 16, "100", "Lorem ipsum dolor", "https://via.placeholder.com/200x360.png?text=Moon", "T-shirt", 499m },
                    { 15, "200", "Lorem ipsum dolor", "https://via.placeholder.com/200x360.png?text=Mars", "T-shirt", 399m },
                    { 14, "200", "Lorem ipsum dolor", "https://via.placeholder.com/200x360.png?text=Mars", "T-shirt", 399m },
                    { 13, "100", "Lorem ipsum dolor", "https://via.placeholder.com/200x360.png?text=Moon", "T-shirt", 499m },
                    { 12, "200", "Lorem ipsum dolor", "https://via.placeholder.com/200x360.png?text=Mars", "T-shirt", 399m },
                    { 11, "200", "Lorem ipsum dolor", "https://via.placeholder.com/200x360.png?text=Mars", "T-shirt", 399m },
                    { 22, "100", "Lorem ipsum dolor", "https://via.placeholder.com/200x360.png?text=Moon", "Byxor", 499m },
                    { 10, "100", "Lorem ipsum dolor", "https://via.placeholder.com/200x360.png?text=Moon", "T-shirt", 499m }
                });

            migrationBuilder.InsertData(
                table: "ProductCategory",
                columns: new[] { "ProductId", "CategoryId" },
                values: new object[] { 9, 2 });

            migrationBuilder.InsertData(
                table: "ProductCategory",
                columns: new[] { "ProductId", "CategoryId" },
                values: new object[,]
                {
                    { 10, 2 },
                    { 11, 2 },
                    { 12, 2 },
                    { 13, 2 },
                    { 14, 2 },
                    { 15, 2 },
                    { 16, 2 },
                    { 17, 3 },
                    { 18, 3 },
                    { 19, 3 },
                    { 20, 3 },
                    { 21, 3 },
                    { 22, 3 },
                    { 23, 3 },
                    { 24, 3 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                keyValues: new object[] { 11, 2 });

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumns: new[] { "ProductId", "CategoryId" },
                keyValues: new object[] { 12, 2 });

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumns: new[] { "ProductId", "CategoryId" },
                keyValues: new object[] { 13, 2 });

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumns: new[] { "ProductId", "CategoryId" },
                keyValues: new object[] { 14, 2 });

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
                keyValues: new object[] { 18, 3 });

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumns: new[] { "ProductId", "CategoryId" },
                keyValues: new object[] { 19, 3 });

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

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumns: new[] { "ProductId", "CategoryId" },
                keyValues: new object[] { 24, 3 });

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "name");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "name1");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "name2");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "name3");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: "name4");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 6,
                column: "Name",
                value: "name5");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 7,
                column: "Name",
                value: "name6");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 8,
                column: "Name",
                value: "name7");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 9,
                column: "Name",
                value: "name8");
        }
    }
}
