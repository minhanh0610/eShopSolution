using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShopSolution.Data.Migrations
{
    public partial class AddProductImageTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 5, 17, 21, 44, 27, 772, DateTimeKind.Local).AddTicks(2207));

            migrationBuilder.CreateTable(
                name: "ProductImages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Caption = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    IsDefault = table.Column<bool>(type: "bit", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SortOrder = table.Column<int>(type: "int", nullable: false),
                    FileSize = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductImages_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("5d3bd30b-7313-42db-a974-8d917ac8fdc6"),
                column: "ConcurrencyStamp",
                value: "efca2821-08ab-481c-befe-a6059c286e75");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("35533699-0033-495c-b8cd-c706d127b8a8"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "201f7713-f23a-4251-9987-8144ee70657a", "AQAAAAEAACcQAAAAEONDdryBYuerkNZUqzD638BmO7h2qbHQvabYJi/dujlzDpbGZwdscxTPPVquKemvxQ==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 19, 16, 47, 49, 254, DateTimeKind.Local).AddTicks(3212));

            migrationBuilder.CreateIndex(
                name: "IX_ProductImages_ProductId",
                table: "ProductImages",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductImages");

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 17, 21, 44, 27, 772, DateTimeKind.Local).AddTicks(2207),
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("5d3bd30b-7313-42db-a974-8d917ac8fdc6"),
                column: "ConcurrencyStamp",
                value: "744064bc-ac47-4be8-9f48-5a8ee8ac4323");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("35533699-0033-495c-b8cd-c706d127b8a8"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "499561e8-2d4a-4cdc-9996-3ebdc270b6fd", "AQAAAAEAACcQAAAAEOjLjru+SZhIsaNypo83nfiWEK9U7HxkDOYG1EZg4vH+dPGNBLaxthDxCm8yhuXTIA==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 17, 21, 44, 27, 788, DateTimeKind.Local).AddTicks(8173));
        }
    }
}
