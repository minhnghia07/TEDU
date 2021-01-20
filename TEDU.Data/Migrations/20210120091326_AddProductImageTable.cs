using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TEDU.Data.Migrations
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
                oldDefaultValue: new DateTime(2020, 12, 30, 16, 42, 27, 352, DateTimeKind.Local).AddTicks(986));

            migrationBuilder.CreateTable(
                name: "ProductImages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Caption = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDefault = table.Column<bool>(type: "bit", maxLength: 200, nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SortOder = table.Column<int>(type: "int", nullable: false),
                    FileSize = table.Column<int>(type: "int", nullable: false)
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
                defaultValue: new DateTime(2020, 12, 30, 16, 42, 27, 352, DateTimeKind.Local).AddTicks(986),
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("e33a7493-7c96-4e36-b0dd-df70386004f5"),
                column: "ConcurrencyStamp",
                value: "73b557c8-bfa6-4bc7-8367-0131611bc808");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("55ab337c-d028-40dc-9c41-8aee98ae164f"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "fea79d6e-252b-4496-9e2d-2e9578d78c7c", "AQAAAAEAACcQAAAAECULW21bucLLxIZmJGMlH19mxt9iJqNBUfXBbOs+5LTqe7oxLNHRQvw08t5Cfgulmw==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2020, 12, 30, 16, 42, 27, 367, DateTimeKind.Local).AddTicks(4751));
        }
    }
}
