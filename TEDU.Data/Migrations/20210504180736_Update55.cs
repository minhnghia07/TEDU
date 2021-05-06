using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TEDU.Data.Migrations
{
    public partial class Update55 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("e33a7493-7c96-4e36-b0dd-df70386004f5"),
                column: "ConcurrencyStamp",
                value: "071f86ea-4e61-45e7-8f64-75f9614574e4");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("55ab337c-d028-40dc-9c41-8aee98ae164f"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6fddd102-4cbc-4c75-87d6-c497ead18282", "AQAAAAEAACcQAAAAEKy6JGVavgGO8LZuKUqiuUrFxSC/NBSfntM8LgNJlbajZx4JbpNb5ixlWyB9s06yPA==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 5, 1, 7, 35, 887, DateTimeKind.Local).AddTicks(5973));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
