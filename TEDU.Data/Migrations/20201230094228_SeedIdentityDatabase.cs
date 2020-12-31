using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TEDU.Data.Migrations
{
    public partial class SeedIdentityDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 12, 30, 16, 42, 27, 352, DateTimeKind.Local).AddTicks(986),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 12, 30, 16, 30, 8, 809, DateTimeKind.Local).AddTicks(9722));

            migrationBuilder.InsertData(
                table: "AppRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[] { new Guid("e33a7493-7c96-4e36-b0dd-df70386004f5"), "73b557c8-bfa6-4bc7-8367-0131611bc808", "Administrator role", "admin", "admin" });

            migrationBuilder.InsertData(
                table: "AppUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("e33a7493-7c96-4e36-b0dd-df70386004f5"), new Guid("55ab337c-d028-40dc-9c41-8aee98ae164f") });

            migrationBuilder.InsertData(
                table: "AppUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Dob", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("55ab337c-d028-40dc-9c41-8aee98ae164f"), 0, "fea79d6e-252b-4496-9e2d-2e9578d78c7c", new DateTime(2020, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "minhnghia@gmail.com", true, "Toan", "Bach", false, null, "minhnghia@gmail.com", "admin", "AQAAAAEAACcQAAAAECULW21bucLLxIZmJGMlH19mxt9iJqNBUfXBbOs+5LTqe7oxLNHRQvw08t5Cfgulmw==", null, false, "", false, "admin" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2020, 12, 30, 16, 42, 27, 367, DateTimeKind.Local).AddTicks(4751));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("e33a7493-7c96-4e36-b0dd-df70386004f5"));

            migrationBuilder.DeleteData(
                table: "AppUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("e33a7493-7c96-4e36-b0dd-df70386004f5"), new Guid("55ab337c-d028-40dc-9c41-8aee98ae164f") });

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("55ab337c-d028-40dc-9c41-8aee98ae164f"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 12, 30, 16, 30, 8, 809, DateTimeKind.Local).AddTicks(9722),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 12, 30, 16, 42, 27, 352, DateTimeKind.Local).AddTicks(986));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2020, 12, 30, 16, 30, 8, 825, DateTimeKind.Local).AddTicks(2624));
        }
    }
}
