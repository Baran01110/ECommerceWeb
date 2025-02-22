using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ECommerceWeb.Server.Migrations
{
    public partial class ProductsRemoveFromCategoryModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2025, 2, 22, 14, 58, 41, 121, DateTimeKind.Local).AddTicks(1396));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2025, 2, 22, 14, 58, 41, 122, DateTimeKind.Local).AddTicks(2583));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2025, 2, 22, 14, 58, 41, 122, DateTimeKind.Local).AddTicks(2670));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2025, 2, 22, 14, 43, 20, 91, DateTimeKind.Local).AddTicks(655));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2025, 2, 22, 14, 43, 20, 92, DateTimeKind.Local).AddTicks(8426));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2025, 2, 22, 14, 43, 20, 92, DateTimeKind.Local).AddTicks(8442));
        }
    }
}
