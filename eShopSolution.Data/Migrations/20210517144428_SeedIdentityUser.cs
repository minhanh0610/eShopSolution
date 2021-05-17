using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShopSolution.Data.Migrations
{
    public partial class SeedIdentityUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 17, 21, 44, 27, 772, DateTimeKind.Local).AddTicks(2207),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 5, 17, 21, 35, 54, 989, DateTimeKind.Local).AddTicks(7250));

            migrationBuilder.InsertData(
                table: "AppRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[] { new Guid("5d3bd30b-7313-42db-a974-8d917ac8fdc6"), "744064bc-ac47-4be8-9f48-5a8ee8ac4323", "Administrator role", "admin", "admin" });

            migrationBuilder.InsertData(
                table: "AppUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("5d3bd30b-7313-42db-a974-8d917ac8fdc6"), new Guid("35533699-0033-495c-b8cd-c706d127b8a8") });

            migrationBuilder.InsertData(
                table: "AppUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Dob", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("35533699-0033-495c-b8cd-c706d127b8a8"), 0, "499561e8-2d4a-4cdc-9996-3ebdc270b6fd", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "leminhanh0610@gmail.com", true, "Minh", "Anh", false, null, "leminhanh0610@gmail.com", "admin", "AQAAAAEAACcQAAAAEOjLjru+SZhIsaNypo83nfiWEK9U7HxkDOYG1EZg4vH+dPGNBLaxthDxCm8yhuXTIA==", null, false, "", false, "admin" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 17, 21, 44, 27, 788, DateTimeKind.Local).AddTicks(8173));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("5d3bd30b-7313-42db-a974-8d917ac8fdc6"));

            migrationBuilder.DeleteData(
                table: "AppUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5d3bd30b-7313-42db-a974-8d917ac8fdc6"), new Guid("35533699-0033-495c-b8cd-c706d127b8a8") });

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("35533699-0033-495c-b8cd-c706d127b8a8"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 17, 21, 35, 54, 989, DateTimeKind.Local).AddTicks(7250),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 5, 17, 21, 44, 27, 772, DateTimeKind.Local).AddTicks(2207));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 17, 21, 35, 55, 6, DateTimeKind.Local).AddTicks(3167));
        }
    }
}
