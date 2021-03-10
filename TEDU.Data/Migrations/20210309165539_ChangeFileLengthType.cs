using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TEDU.Data.Migrations
{
    public partial class ChangeFileLengthType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "FileSize",
                table: "ProductImages",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("e33a7493-7c96-4e36-b0dd-df70386004f5"),
                column: "ConcurrencyStamp",
                value: "3d4497d5-a6f1-480a-917b-2d36c620fb32");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("55ab337c-d028-40dc-9c41-8aee98ae164f"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b6563da2-aff6-4ba5-838c-b19bb92f9ef1", "AQAAAAEAACcQAAAAEHuQd1U/8AnetXBlhSVcVGYtf0b7Gm8iiouJ3mITqxIWXEZ1Sz5AYgRKbKWk2PNAnw==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 3, 9, 23, 55, 38, 775, DateTimeKind.Local).AddTicks(3980));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "FileSize",
                table: "ProductImages",
                type: "int",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("e33a7493-7c96-4e36-b0dd-df70386004f5"),
                column: "ConcurrencyStamp",
                value: "2c8f2e62-95e5-40a0-b7bc-6de012f2df5f");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("55ab337c-d028-40dc-9c41-8aee98ae164f"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "eee52095-dc56-48f7-970f-65893c7e31ab", "AQAAAAEAACcQAAAAEGCEoeF/yvzg9GXNLYI7RNzmVhjT5NJfNv0mE4b1l6wOm+Zdwus93Yf+48Abv6VGmA==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 1, 20, 16, 13, 25, 127, DateTimeKind.Local).AddTicks(7366));
        }
    }
}
