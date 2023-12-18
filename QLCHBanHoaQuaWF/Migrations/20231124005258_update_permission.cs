using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QLCHBanHoaQuaWF.Migrations
{
    /// <inheritdoc />
    public partial class update_permission : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DetailImportOrders_Products_ProductID",
                table: "DetailImportOrders");

            migrationBuilder.DropForeignKey(
                name: "FK_DetailSalesOrders_Products_ProductID",
                table: "DetailSalesOrders");

            migrationBuilder.DropForeignKey(
                name: "FK_ImportOrders_Providers_ProviderID",
                table: "ImportOrders");

            migrationBuilder.DropForeignKey(
                name: "FK_Permissions_UserRoles_UserRoleID",
                table: "Permissions");

            migrationBuilder.DropForeignKey(
                name: "FK_SalesOrders_Customer_CustomerID",
                table: "SalesOrders");

            migrationBuilder.DropIndex(
                name: "IX_Permissions_UserRoleID",
                table: "Permissions");

            migrationBuilder.DropColumn(
                name: "UserRoleID",
                table: "Permissions");

            migrationBuilder.RenameColumn(
                name: "CanImportSalesOrder",
                table: "Permissions",
                newName: "CanUpdateUserRole");

            migrationBuilder.RenameColumn(
                name: "CanImportProduct",
                table: "Permissions",
                newName: "CanReadUserRole");

            migrationBuilder.RenameColumn(
                name: "CanImportImportOrder",
                table: "Permissions",
                newName: "CanReadUser");

            migrationBuilder.RenameColumn(
                name: "CanExportProduct",
                table: "Permissions",
                newName: "CanReadStatistics");

            migrationBuilder.AddColumn<int>(
                name: "PermissionID",
                table: "UserRoles",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "CustomerID",
                table: "SalesOrders",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "CanCreateUserRole",
                table: "Permissions",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "CanDeleteUserRole",
                table: "Permissions",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "CanReadOptions",
                table: "Permissions",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<int>(
                name: "ProviderID",
                table: "ImportOrders",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ProductID",
                table: "DetailSalesOrders",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ProductID",
                table: "DetailImportOrders",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 1,
                columns: new[] { "CanCreateUserRole", "CanDeleteUserRole", "CanReadOptions" },
                values: new object[] { false, false, false });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "RoleID",
                keyValue: 1,
                columns: new[] { "DateCreated", "PermissionID" },
                values: new object[] { new DateTime(2023, 11, 24, 7, 52, 57, 727, DateTimeKind.Local).AddTicks(5444), 1 });

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_PermissionID",
                table: "UserRoles",
                column: "PermissionID",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_DetailImportOrders_Products_ProductID",
                table: "DetailImportOrders",
                column: "ProductID",
                principalTable: "Products",
                principalColumn: "ProductID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DetailSalesOrders_Products_ProductID",
                table: "DetailSalesOrders",
                column: "ProductID",
                principalTable: "Products",
                principalColumn: "ProductID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ImportOrders_Providers_ProviderID",
                table: "ImportOrders",
                column: "ProviderID",
                principalTable: "Providers",
                principalColumn: "ProviderID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SalesOrders_Customer_CustomerID",
                table: "SalesOrders",
                column: "CustomerID",
                principalTable: "Customer",
                principalColumn: "CustomerID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserRoles_Permissions_PermissionID",
                table: "UserRoles",
                column: "PermissionID",
                principalTable: "Permissions",
                principalColumn: "PermissionID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DetailImportOrders_Products_ProductID",
                table: "DetailImportOrders");

            migrationBuilder.DropForeignKey(
                name: "FK_DetailSalesOrders_Products_ProductID",
                table: "DetailSalesOrders");

            migrationBuilder.DropForeignKey(
                name: "FK_ImportOrders_Providers_ProviderID",
                table: "ImportOrders");

            migrationBuilder.DropForeignKey(
                name: "FK_SalesOrders_Customer_CustomerID",
                table: "SalesOrders");

            migrationBuilder.DropForeignKey(
                name: "FK_UserRoles_Permissions_PermissionID",
                table: "UserRoles");

            migrationBuilder.DropIndex(
                name: "IX_UserRoles_PermissionID",
                table: "UserRoles");

            migrationBuilder.DropColumn(
                name: "PermissionID",
                table: "UserRoles");

            migrationBuilder.DropColumn(
                name: "CanCreateUserRole",
                table: "Permissions");

            migrationBuilder.DropColumn(
                name: "CanDeleteUserRole",
                table: "Permissions");

            migrationBuilder.DropColumn(
                name: "CanReadOptions",
                table: "Permissions");

            migrationBuilder.RenameColumn(
                name: "CanUpdateUserRole",
                table: "Permissions",
                newName: "CanImportSalesOrder");

            migrationBuilder.RenameColumn(
                name: "CanReadUserRole",
                table: "Permissions",
                newName: "CanImportProduct");

            migrationBuilder.RenameColumn(
                name: "CanReadUser",
                table: "Permissions",
                newName: "CanImportImportOrder");

            migrationBuilder.RenameColumn(
                name: "CanReadStatistics",
                table: "Permissions",
                newName: "CanExportProduct");

            migrationBuilder.AlterColumn<int>(
                name: "CustomerID",
                table: "SalesOrders",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "UserRoleID",
                table: "Permissions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "ProviderID",
                table: "ImportOrders",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ProductID",
                table: "DetailSalesOrders",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ProductID",
                table: "DetailImportOrders",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 1,
                column: "UserRoleID",
                value: 1);

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "RoleID",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 11, 21, 13, 52, 14, 120, DateTimeKind.Local).AddTicks(3484));

            migrationBuilder.CreateIndex(
                name: "IX_Permissions_UserRoleID",
                table: "Permissions",
                column: "UserRoleID",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_DetailImportOrders_Products_ProductID",
                table: "DetailImportOrders",
                column: "ProductID",
                principalTable: "Products",
                principalColumn: "ProductID");

            migrationBuilder.AddForeignKey(
                name: "FK_DetailSalesOrders_Products_ProductID",
                table: "DetailSalesOrders",
                column: "ProductID",
                principalTable: "Products",
                principalColumn: "ProductID");

            migrationBuilder.AddForeignKey(
                name: "FK_ImportOrders_Providers_ProviderID",
                table: "ImportOrders",
                column: "ProviderID",
                principalTable: "Providers",
                principalColumn: "ProviderID");

            migrationBuilder.AddForeignKey(
                name: "FK_Permissions_UserRoles_UserRoleID",
                table: "Permissions",
                column: "UserRoleID",
                principalTable: "UserRoles",
                principalColumn: "RoleID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SalesOrders_Customer_CustomerID",
                table: "SalesOrders",
                column: "CustomerID",
                principalTable: "Customer",
                principalColumn: "CustomerID");
        }
    }
}
