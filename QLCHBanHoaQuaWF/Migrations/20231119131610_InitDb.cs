using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QLCHWF.Migrations
{
    /// <inheritdoc />
    public partial class InitDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    CustomerID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DateCreated = table.Column<DateTime>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.CustomerID);
                });

            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    EmployeeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Salary = table.Column<decimal>(type: "decimal(10,2)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.EmployeeID);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    CalculationUnit = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Inventory = table.Column<int>(type: "int", nullable: false),
                    ImageData = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "date", nullable: false),
                    ImportUnitPrice = table.Column<decimal>(type: "decimal(10,2)", nullable: true),
                    UnitPrice = table.Column<decimal>(type: "decimal(10,2)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductID);
                });

            migrationBuilder.CreateTable(
                name: "Providers",
                columns: table => new
                {
                    ProviderID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProviderName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Providers", x => x.ProviderID);
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    RoleID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleName = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => x.RoleID);
                });

            migrationBuilder.CreateTable(
                name: "SalesOrders",
                columns: table => new
                {
                    OrderID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderDate = table.Column<DateTime>(type: "date", nullable: false),
                    TotalPrice = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    EmployeeID = table.Column<int>(type: "int", nullable: true),
                    CustomerID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalesOrders", x => x.OrderID);
                    table.ForeignKey(
                        name: "FK_SalesOrders_Customer_CustomerID",
                        column: x => x.CustomerID,
                        principalTable: "Customer",
                        principalColumn: "CustomerID");
                    table.ForeignKey(
                        name: "FK_SalesOrders_Employee_EmployeeID",
                        column: x => x.EmployeeID,
                        principalTable: "Employee",
                        principalColumn: "EmployeeID");
                });

            migrationBuilder.CreateTable(
                name: "ImportOrders",
                columns: table => new
                {
                    OrderID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderDate = table.Column<DateTime>(type: "date", nullable: false),
                    TotalPrice = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    EmployeeID = table.Column<int>(type: "int", nullable: true),
                    ProviderID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImportOrders", x => x.OrderID);
                    table.ForeignKey(
                        name: "FK_ImportOrders_Employee_EmployeeID",
                        column: x => x.EmployeeID,
                        principalTable: "Employee",
                        principalColumn: "EmployeeID");
                    table.ForeignKey(
                        name: "FK_ImportOrders_Providers_ProviderID",
                        column: x => x.ProviderID,
                        principalTable: "Providers",
                        principalColumn: "ProviderID");
                });

            migrationBuilder.CreateTable(
                name: "Permissions",
                columns: table => new
                {
                    PermissionID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserRoleID = table.Column<int>(type: "int", nullable: false),
                    CanReadProduct = table.Column<bool>(type: "bit", nullable: false),
                    CanCreateProduct = table.Column<bool>(type: "bit", nullable: false),
                    CanUpdateProduct = table.Column<bool>(type: "bit", nullable: false),
                    CanDeleteProduct = table.Column<bool>(type: "bit", nullable: false),
                    CanExportProduct = table.Column<bool>(type: "bit", nullable: false),
                    CanImportProduct = table.Column<bool>(type: "bit", nullable: false),
                    CanDeleteImportOrder = table.Column<bool>(type: "bit", nullable: false),
                    CanExportImportOrder = table.Column<bool>(type: "bit", nullable: false),
                    CanImportImportOrder = table.Column<bool>(type: "bit", nullable: false),
                    CanDeleteSalesOrder = table.Column<bool>(type: "bit", nullable: false),
                    CanExportSalesOrder = table.Column<bool>(type: "bit", nullable: false),
                    CanImportSalesOrder = table.Column<bool>(type: "bit", nullable: false),
                    CanReadCustomer = table.Column<bool>(type: "bit", nullable: false),
                    CanCreateCustomer = table.Column<bool>(type: "bit", nullable: false),
                    CanUpdateCustomer = table.Column<bool>(type: "bit", nullable: false),
                    CanDeleteCustomer = table.Column<bool>(type: "bit", nullable: false),
                    CanReadProvider = table.Column<bool>(type: "bit", nullable: false),
                    CanCreatedProvider = table.Column<bool>(type: "bit", nullable: false),
                    CanUpdateProvider = table.Column<bool>(type: "bit", nullable: false),
                    CanDeleteProvider = table.Column<bool>(type: "bit", nullable: false),
                    CanReadEmployee = table.Column<bool>(type: "bit", nullable: false),
                    CanCreateEmployee = table.Column<bool>(type: "bit", nullable: false),
                    CanUpdateEmployee = table.Column<bool>(type: "bit", nullable: false),
                    CanDeleteEmployee = table.Column<bool>(type: "bit", nullable: false),
                    CanReadDetailImportOrder = table.Column<bool>(type: "bit", nullable: false),
                    CanReadDetailSalesOrder = table.Column<bool>(type: "bit", nullable: false),
                    IsAdmin = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Permissions", x => x.PermissionID);
                    table.ForeignKey(
                        name: "FK_Permissions_UserRoles_UserRoleID",
                        column: x => x.UserRoleID,
                        principalTable: "UserRoles",
                        principalColumn: "RoleID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    EmployeeID = table.Column<int>(type: "int", nullable: false),
                    RoleID = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastLogin = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Lock = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => new { x.EmployeeID, x.RoleID });
                    table.ForeignKey(
                        name: "FK_Users_Employee_EmployeeID",
                        column: x => x.EmployeeID,
                        principalTable: "Employee",
                        principalColumn: "EmployeeID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Users_UserRoles_RoleID",
                        column: x => x.RoleID,
                        principalTable: "UserRoles",
                        principalColumn: "RoleID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DetailSalesOrders",
                columns: table => new
                {
                    DetailOrderID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderID = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    UnitPrice = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    TotalPrice = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    ProductID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetailSalesOrders", x => x.DetailOrderID);
                    table.ForeignKey(
                        name: "FK_DetailSalesOrders_Products_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Products",
                        principalColumn: "ProductID");
                    table.ForeignKey(
                        name: "FK_DetailSalesOrders_SalesOrders_OrderID",
                        column: x => x.OrderID,
                        principalTable: "SalesOrders",
                        principalColumn: "OrderID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DetailImportOrders",
                columns: table => new
                {
                    DetailOrderID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderID = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    UnitPrice = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    TotalPrice = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    ProductID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetailImportOrders", x => x.DetailOrderID);
                    table.ForeignKey(
                        name: "FK_DetailImportOrders_ImportOrders_OrderID",
                        column: x => x.OrderID,
                        principalTable: "ImportOrders",
                        principalColumn: "OrderID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DetailImportOrders_Products_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Products",
                        principalColumn: "ProductID");
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleID", "DateCreated", "Description", "RoleName" },
                values: new object[] { 1, new DateTime(2023, 11, 19, 20, 16, 10, 135, DateTimeKind.Local).AddTicks(8959), null, "Nhân viên" });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "PermissionID", "CanCreateCustomer", "CanCreateEmployee", "CanCreateProduct", "CanCreatedProvider", "CanDeleteCustomer", "CanDeleteEmployee", "CanDeleteImportOrder", "CanDeleteProduct", "CanDeleteProvider", "CanDeleteSalesOrder", "CanExportImportOrder", "CanExportProduct", "CanExportSalesOrder", "CanImportImportOrder", "CanImportProduct", "CanImportSalesOrder", "CanReadCustomer", "CanReadDetailImportOrder", "CanReadDetailSalesOrder", "CanReadEmployee", "CanReadProduct", "CanReadProvider", "CanUpdateCustomer", "CanUpdateEmployee", "CanUpdateProduct", "CanUpdateProvider", "IsAdmin", "UserRoleID" },
                values: new object[] { 1, true, false, false, false, true, false, false, false, false, false, false, false, false, false, false, false, true, true, true, false, false, false, true, false, false, false, false, 1 });

            migrationBuilder.CreateIndex(
                name: "IX_DetailImportOrders_OrderID",
                table: "DetailImportOrders",
                column: "OrderID");

            migrationBuilder.CreateIndex(
                name: "IX_DetailImportOrders_ProductID",
                table: "DetailImportOrders",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_DetailSalesOrders_OrderID",
                table: "DetailSalesOrders",
                column: "OrderID");

            migrationBuilder.CreateIndex(
                name: "IX_DetailSalesOrders_ProductID",
                table: "DetailSalesOrders",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_Email",
                table: "Employee",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ImportOrders_EmployeeID",
                table: "ImportOrders",
                column: "EmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_ImportOrders_ProviderID",
                table: "ImportOrders",
                column: "ProviderID");

            migrationBuilder.CreateIndex(
                name: "IX_Permissions_UserRoleID",
                table: "Permissions",
                column: "UserRoleID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SalesOrders_CustomerID",
                table: "SalesOrders",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_SalesOrders_EmployeeID",
                table: "SalesOrders",
                column: "EmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_RoleName",
                table: "UserRoles",
                column: "RoleName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_Email",
                table: "Users",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_RoleID",
                table: "Users",
                column: "RoleID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DetailImportOrders");

            migrationBuilder.DropTable(
                name: "DetailSalesOrders");

            migrationBuilder.DropTable(
                name: "Permissions");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "ImportOrders");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "SalesOrders");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "Providers");

            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropTable(
                name: "Employee");
        }
    }
}
