using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QLCHBanHoaQuaWF.Migrations
{
    /// <inheritdoc />
    public partial class update_permissionV2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "CanCreateImportOrder",
                table: "Permissions",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "CanCreateSalesOrder",
                table: "Permissions",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "CanPrintImportOrder",
                table: "Permissions",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "CanPrintSalesOrder",
                table: "Permissions",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "CanReadImportOrder",
                table: "Permissions",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "CanReadSalesOrder",
                table: "Permissions",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 1,
                columns: new[] { "CanCreateImportOrder", "CanCreateSalesOrder", "CanPrintImportOrder", "CanPrintSalesOrder", "CanReadImportOrder", "CanReadSalesOrder" },
                values: new object[] { false, false, false, false, false, false });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "RoleID",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 11, 24, 8, 37, 40, 618, DateTimeKind.Local).AddTicks(1611));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CanCreateImportOrder",
                table: "Permissions");

            migrationBuilder.DropColumn(
                name: "CanCreateSalesOrder",
                table: "Permissions");

            migrationBuilder.DropColumn(
                name: "CanPrintImportOrder",
                table: "Permissions");

            migrationBuilder.DropColumn(
                name: "CanPrintSalesOrder",
                table: "Permissions");

            migrationBuilder.DropColumn(
                name: "CanReadImportOrder",
                table: "Permissions");

            migrationBuilder.DropColumn(
                name: "CanReadSalesOrder",
                table: "Permissions");

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "RoleID",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 11, 24, 7, 52, 57, 727, DateTimeKind.Local).AddTicks(5444));
        }
    }
}
