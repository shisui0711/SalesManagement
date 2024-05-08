using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QLCHWF.Migrations
{
    /// <inheritdoc />
    public partial class update_salesorder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "ChangePrice",
                table: "SalesOrders",
                type: "decimal(10,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "PurchasePrice",
                table: "SalesOrders",
                type: "decimal(10,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.CreateTable(
                name: "AppInfos",
                columns: table => new
                {
                    AppName = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppInfos", x => x.AppName);
                });

            migrationBuilder.InsertData(
                table: "AppInfos",
                columns: new[] { "AppName", "Address", "Email", "Phone" },
                values: new object[] { "Cửa hàng của bạn", "Hưng Yên", null, "0987654321" });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "RoleID",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 11, 21, 13, 52, 14, 120, DateTimeKind.Local).AddTicks(3484));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppInfos");

            migrationBuilder.DropColumn(
                name: "ChangePrice",
                table: "SalesOrders");

            migrationBuilder.DropColumn(
                name: "PurchasePrice",
                table: "SalesOrders");

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "RoleID",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 11, 19, 20, 16, 10, 135, DateTimeKind.Local).AddTicks(8959));
        }
    }
}
