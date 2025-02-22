using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ECommerceWeb.Server.Migrations
{
    public partial class Seeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Icon", "Name", "Url" },
                values: new object[] { 1, "book", "Books", "books" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Icon", "Name", "Url" },
                values: new object[] { 2, "phone", "Phones", "phones" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Icon", "Name", "Url" },
                values: new object[] { 3, "puzzle-piece", "Toys", "toys" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "DateCreated", "DateUpdated", "Description", "Image", "IsDeleted", "IsPublic", "OriginalPrice", "Price", "Title" },
                values: new object[] { 1, 1, new DateTime(2025, 2, 22, 14, 43, 20, 91, DateTimeKind.Local).AddTicks(655), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Iphone is the most iconic phone ever. If you have this phone you look rich :)", "https://e7.pngegg.com/pngimages/599/150/png-clipart-iphone-x-front-view-apple%E6%89%8B%E6%9C%BA-iphone-thumbnail.png", false, false, 99.999m, 100.000m, "Iphone 15 PRO MAX ULTRA AMAZING LAST VERSION PRIME EDITION" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "DateCreated", "DateUpdated", "Description", "Image", "IsDeleted", "IsPublic", "OriginalPrice", "Price", "Title" },
                values: new object[] { 3, 2, new DateTime(2025, 2, 22, 14, 43, 20, 92, DateTimeKind.Local).AddTicks(8442), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gun and guns Half-Life is most iconic game ever", "https://upload.wikimedia.org/wikipedia/en/2/25/Half-Life_2_cover.jpg", false, false, 49.99m, 10.99m, "Half-Life" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "DateCreated", "DateUpdated", "Description", "Image", "IsDeleted", "IsPublic", "OriginalPrice", "Price", "Title" },
                values: new object[] { 2, 3, new DateTime(2025, 2, 22, 14, 43, 20, 92, DateTimeKind.Local).AddTicks(8426), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gun and guns Half-Life is most iconic game ever", "https://upload.wikimedia.org/wikipedia/en/2/25/Half-Life_2_cover.jpg", false, false, 49.99m, 10.99m, "Half-Life" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
