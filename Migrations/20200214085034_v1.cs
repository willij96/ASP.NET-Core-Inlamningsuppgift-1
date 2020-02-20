using Microsoft.EntityFrameworkCore.Migrations;

namespace FreakyFashion1.Migrations
{
    public partial class v1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UrlSlug",
                table: "Product",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ArticleNumber", "Description", "UrlSlug" },
                values: new object[] { "Lorem ipsum dolor", "100", "Lorem-ipsum-dolor" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ArticleNumber", "Description", "UrlSlug" },
                values: new object[] { "Lorem ipsum dolor", "100", "Lorem-ipsum-dolor" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ArticleNumber", "Description", "UrlSlug" },
                values: new object[] { "Lorem ipsum dolor", "200", "Lorem-ipsum-dolor" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ArticleNumber", "Description", "UrlSlug" },
                values: new object[] { "Lorem ipsum dolor", "100", "Lorem-ipsum-dolor" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ArticleNumber", "Description", "UrlSlug" },
                values: new object[] { "Lorem ipsum dolor", "100", "Lorem-ipsum-dolor" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ArticleNumber", "Description", "UrlSlug" },
                values: new object[] { "Lorem ipsum dolor", "100", "Lorem-ipsum-dolor" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ArticleNumber", "Description", "UrlSlug" },
                values: new object[] { "Lorem ipsum dolor", "100", "Lorem-ipsum-dolor" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ArticleNumber", "Description", "UrlSlug" },
                values: new object[] { "Lorem ipsum dolor", "100", "Lorem-ipsum-dolor" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ArticleNumber", "Description", "UrlSlug" },
                values: new object[] { "Lorem ipsum dolor", "200", "Lorem-ipsum-dolor" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ArticleNumber", "Description", "UrlSlug" },
                values: new object[] { "Lorem ipsum dolor", "200", "Lorem-ipsum-dolor" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ArticleNumber", "Description", "UrlSlug" },
                values: new object[] { "Lorem ipsum dolor", "200", "Lorem-ipsum-dolor" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ArticleNumber", "Description", "UrlSlug" },
                values: new object[] { "Lorem ipsum dolor", "200", "Lorem-ipsum-dolor" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ArticleNumber", "Description", "UrlSlug" },
                values: new object[] { "Lorem ipsum dolor", "200", "Lorem-ipsum-dolor" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ArticleNumber", "Description", "UrlSlug" },
                values: new object[] { "Lorem ipsum dolor", "200", "Lorem-ipsum-dolor" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ArticleNumber", "Description", "UrlSlug" },
                values: new object[] { "Lorem ipsum dolor", "200", "Lorem-ipsum-dolor" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "ArticleNumber", "Description", "UrlSlug" },
                values: new object[] { "Lorem ipsum dolor", "100", "Lorem-ipsum-dolor" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "ArticleNumber", "Description", "UrlSlug" },
                values: new object[] { "Lorem ipsum dolor", "200", "Lorem-ipsum-dolor" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "ArticleNumber", "Description", "UrlSlug" },
                values: new object[] { "Lorem ipsum dolor", "200", "Lorem-ipsum-dolor" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "ArticleNumber", "Description", "UrlSlug" },
                values: new object[] { "Lorem ipsum dolor", "200", "Lorem-ipsum-dolor" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "ArticleNumber", "Description", "UrlSlug" },
                values: new object[] { "Lorem ipsum dolor", "100", "Lorem-ipsum-dolor" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "ArticleNumber", "Description", "UrlSlug" },
                values: new object[] { "Lorem ipsum dolor", "200", "Lorem-ipsum-dolor" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "ArticleNumber", "Description", "UrlSlug" },
                values: new object[] { "Lorem ipsum dolor", "200", "Lorem-ipsum-dolor" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "ArticleNumber", "Description", "UrlSlug" },
                values: new object[] { "Lorem ipsum dolor", "200", "Lorem-ipsum-dolor" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "ArticleNumber", "Description", "UrlSlug" },
                values: new object[] { "Lorem ipsum dolor", "200", "Lorem-ipsum-dolor" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UrlSlug",
                table: "Product");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ArticleNumber", "Description" },
                values: new object[] { "100", "Lorem ipsum dolor" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ArticleNumber", "Description" },
                values: new object[] { "100", "Lorem ipsum dolor" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ArticleNumber", "Description" },
                values: new object[] { "200", "Lorem ipsum dolor" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ArticleNumber", "Description" },
                values: new object[] { "100", "Lorem ipsum dolor" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ArticleNumber", "Description" },
                values: new object[] { "100", "Lorem ipsum dolor" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ArticleNumber", "Description" },
                values: new object[] { "100", "Lorem ipsum dolor" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ArticleNumber", "Description" },
                values: new object[] { "100", "Lorem ipsum dolor" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ArticleNumber", "Description" },
                values: new object[] { "100", "Lorem ipsum dolor" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ArticleNumber", "Description" },
                values: new object[] { "200", "Lorem ipsum dolor" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ArticleNumber", "Description" },
                values: new object[] { "200", "Lorem ipsum dolor" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ArticleNumber", "Description" },
                values: new object[] { "200", "Lorem ipsum dolor" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ArticleNumber", "Description" },
                values: new object[] { "200", "Lorem ipsum dolor" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ArticleNumber", "Description" },
                values: new object[] { "200", "Lorem ipsum dolor" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ArticleNumber", "Description" },
                values: new object[] { "200", "Lorem ipsum dolor" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ArticleNumber", "Description" },
                values: new object[] { "200", "Lorem ipsum dolor" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "ArticleNumber", "Description" },
                values: new object[] { "100", "Lorem ipsum dolor" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "ArticleNumber", "Description" },
                values: new object[] { "200", "Lorem ipsum dolor" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "ArticleNumber", "Description" },
                values: new object[] { "200", "Lorem ipsum dolor" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "ArticleNumber", "Description" },
                values: new object[] { "200", "Lorem ipsum dolor" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "ArticleNumber", "Description" },
                values: new object[] { "100", "Lorem ipsum dolor" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "ArticleNumber", "Description" },
                values: new object[] { "200", "Lorem ipsum dolor" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "ArticleNumber", "Description" },
                values: new object[] { "200", "Lorem ipsum dolor" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "ArticleNumber", "Description" },
                values: new object[] { "200", "Lorem ipsum dolor" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "ArticleNumber", "Description" },
                values: new object[] { "200", "Lorem ipsum dolor" });
        }
    }
}
