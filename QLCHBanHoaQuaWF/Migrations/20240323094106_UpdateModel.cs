using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace QLCHWF.Migrations
{
    /// <inheritdoc />
    public partial class UpdateModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DetailImportOrders_ImportOrders_OrderID",
                table: "DetailImportOrders");

            migrationBuilder.DropForeignKey(
                name: "FK_DetailImportOrders_Products_ProductID",
                table: "DetailImportOrders");

            migrationBuilder.DropForeignKey(
                name: "FK_DetailSalesOrders_Products_ProductID",
                table: "DetailSalesOrders");

            migrationBuilder.DropForeignKey(
                name: "FK_DetailSalesOrders_SalesOrders_OrderID",
                table: "DetailSalesOrders");

            migrationBuilder.DropForeignKey(
                name: "FK_ImportOrders_Employee_EmployeeID",
                table: "ImportOrders");

            migrationBuilder.DropForeignKey(
                name: "FK_ImportOrders_Providers_ProviderID",
                table: "ImportOrders");

            migrationBuilder.DropForeignKey(
                name: "FK_SalesOrders_Customer_CustomerID",
                table: "SalesOrders");

            migrationBuilder.DropForeignKey(
                name: "FK_SalesOrders_Employee_EmployeeID",
                table: "SalesOrders");

            migrationBuilder.DropForeignKey(
                name: "FK_UserRoles_Permissions_PermissionID",
                table: "UserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Employee_EmployeeID",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_UserRoles_RoleID",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserRoles",
                table: "UserRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SalesOrders",
                table: "SalesOrders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Providers",
                table: "Providers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Products",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Permissions",
                table: "Permissions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ImportOrders",
                table: "ImportOrders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DetailSalesOrders",
                table: "DetailSalesOrders");

            migrationBuilder.DropIndex(
                name: "IX_DetailSalesOrders_OrderID",
                table: "DetailSalesOrders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DetailImportOrders",
                table: "DetailImportOrders");

            migrationBuilder.DropIndex(
                name: "IX_DetailImportOrders_OrderID",
                table: "DetailImportOrders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AppInfos",
                table: "AppInfos");

            migrationBuilder.DropColumn(
                name: "DetailOrderID",
                table: "DetailSalesOrders");

            migrationBuilder.DropColumn(
                name: "TotalPrice",
                table: "DetailSalesOrders");

            migrationBuilder.DropColumn(
                name: "DetailOrderID",
                table: "DetailImportOrders");

            migrationBuilder.DropColumn(
                name: "TotalPrice",
                table: "DetailImportOrders");

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "User");

            migrationBuilder.RenameTable(
                name: "UserRoles",
                newName: "UserRole");

            migrationBuilder.RenameTable(
                name: "SalesOrders",
                newName: "SalesOrder");

            migrationBuilder.RenameTable(
                name: "Providers",
                newName: "Provider");

            migrationBuilder.RenameTable(
                name: "Products",
                newName: "Product");

            migrationBuilder.RenameTable(
                name: "Permissions",
                newName: "Permission");

            migrationBuilder.RenameTable(
                name: "ImportOrders",
                newName: "ImportOrder");

            migrationBuilder.RenameTable(
                name: "DetailSalesOrders",
                newName: "DetailSalesOrder");

            migrationBuilder.RenameTable(
                name: "DetailImportOrders",
                newName: "DetailImportOrder");

            migrationBuilder.RenameTable(
                name: "AppInfos",
                newName: "AppInfo");

            migrationBuilder.RenameIndex(
                name: "IX_Users_RoleID",
                table: "User",
                newName: "IX_User_RoleID");

            migrationBuilder.RenameIndex(
                name: "IX_Users_Email",
                table: "User",
                newName: "IX_User_Email");

            migrationBuilder.RenameIndex(
                name: "IX_UserRoles_RoleName",
                table: "UserRole",
                newName: "IX_UserRole_RoleName");

            migrationBuilder.RenameIndex(
                name: "IX_UserRoles_PermissionID",
                table: "UserRole",
                newName: "IX_UserRole_PermissionID");

            migrationBuilder.RenameIndex(
                name: "IX_SalesOrders_EmployeeID",
                table: "SalesOrder",
                newName: "IX_SalesOrder_EmployeeID");

            migrationBuilder.RenameIndex(
                name: "IX_SalesOrders_CustomerID",
                table: "SalesOrder",
                newName: "IX_SalesOrder_CustomerID");

            migrationBuilder.RenameIndex(
                name: "IX_ImportOrders_ProviderID",
                table: "ImportOrder",
                newName: "IX_ImportOrder_ProviderID");

            migrationBuilder.RenameIndex(
                name: "IX_ImportOrders_EmployeeID",
                table: "ImportOrder",
                newName: "IX_ImportOrder_EmployeeID");

            migrationBuilder.RenameIndex(
                name: "IX_DetailSalesOrders_ProductID",
                table: "DetailSalesOrder",
                newName: "IX_DetailSalesOrder_ProductID");

            migrationBuilder.RenameIndex(
                name: "IX_DetailImportOrders_ProductID",
                table: "DetailImportOrder",
                newName: "IX_DetailImportOrder_ProductID");

            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "Employee",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "Customer",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Customer",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Customer",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "User",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "EmployeeID",
                table: "SalesOrder",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "Provider",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Provider",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Provider",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "Provider",
                type: "date",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AlterColumn<byte[]>(
                name: "ImageData",
                table: "Product",
                type: "varbinary(max)",
                nullable: true,
                oldClrType: typeof(byte[]),
                oldType: "varbinary(max)");

            migrationBuilder.AlterColumn<string>(
                name: "CalculationUnit",
                table: "Product",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<int>(
                name: "EmployeeID",
                table: "ImportOrder",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_User",
                table: "User",
                columns: new[] { "EmployeeID", "RoleID" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserRole",
                table: "UserRole",
                column: "RoleID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SalesOrder",
                table: "SalesOrder",
                column: "OrderID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Provider",
                table: "Provider",
                column: "ProviderID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Product",
                table: "Product",
                column: "ProductID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Permission",
                table: "Permission",
                column: "PermissionID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ImportOrder",
                table: "ImportOrder",
                column: "OrderID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DetailSalesOrder",
                table: "DetailSalesOrder",
                columns: new[] { "OrderID", "ProductID" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_DetailImportOrder",
                table: "DetailImportOrder",
                columns: new[] { "OrderID", "ProductID" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppInfo",
                table: "AppInfo",
                column: "AppName");

            migrationBuilder.UpdateData(
                table: "AppInfo",
                keyColumn: "AppName",
                keyValue: "Cửa hàng của bạn",
                column: "Address",
                value: "Việt Nam");

            migrationBuilder.InsertData(
                table: "Customer",
                columns: new[] { "CustomerID", "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[,]
                {
                    { 1, "Phú Thọ", "Mộng Vân Hồ", new DateTime(2024, 3, 23, 16, 41, 6, 172, DateTimeKind.Local).AddTicks(5944), "NgocHa.Doan@gmail.com", "0932065978" },
                    { 2, "Lai Châu", "Hoàng Khôi Hoàng", new DateTime(2024, 3, 23, 16, 41, 6, 172, DateTimeKind.Local).AddTicks(8896), "ThuyMai15@gmail.com", "0901724444" },
                    { 3, "Hưng Yên", "Việt Thông Mai", new DateTime(2024, 3, 23, 16, 41, 6, 172, DateTimeKind.Local).AddTicks(9031), "NhuHong_Tran@gmail.com", "0946076418" },
                    { 4, "Vĩnh Phúc", "Trang Anh Đặng", new DateTime(2024, 3, 23, 16, 41, 6, 172, DateTimeKind.Local).AddTicks(9117), "NhuMai_Phan@yahoo.com", "0943875888" },
                    { 5, "Bắc Ninh", "Hữu Nghị Phan", new DateTime(2024, 3, 23, 16, 41, 6, 172, DateTimeKind.Local).AddTicks(9186), "HiepHao26@yahoo.com", "0936383028" },
                    { 6, "Cao Bằng", "Việt Cường Dương", new DateTime(2024, 3, 23, 16, 41, 6, 172, DateTimeKind.Local).AddTicks(9267), "BaLong_Truong37@hotmail.com", "0904838500" },
                    { 7, "Đắk Lắk", "Diệu Ngọc Bùi", new DateTime(2024, 3, 23, 16, 41, 6, 172, DateTimeKind.Local).AddTicks(9341), "HaTien_Mai29@gmail.com", "0954614639" },
                    { 8, "Ninh Bình", "Thu Yến Lâm", new DateTime(2024, 3, 23, 16, 41, 6, 172, DateTimeKind.Local).AddTicks(9415), "TatHieu67@hotmail.com", "0994621320" },
                    { 9, "Đồng Tháp", "Hồng Tâm Vương", new DateTime(2024, 3, 23, 16, 41, 6, 172, DateTimeKind.Local).AddTicks(9493), "TheVinh_Ly14@yahoo.com", "0986899442" },
                    { 10, "Quảng Ngãi", "Hùng Thịnh Dương", new DateTime(2024, 3, 23, 16, 41, 6, 172, DateTimeKind.Local).AddTicks(9567), "KhaiTam27@hotmail.com", "0969057283" },
                    { 11, "Hà Nam", "Huy Hoàng Đinh", new DateTime(2024, 3, 23, 16, 41, 6, 172, DateTimeKind.Local).AddTicks(9641), "HoanKiem3@gmail.com", "0947519795" },
                    { 12, "Hải Dương", "Nhã Hồng Trịnh", new DateTime(2024, 3, 23, 16, 41, 6, 172, DateTimeKind.Local).AddTicks(9715), "DucLong_Nguyen@yahoo.com", "0977157307" },
                    { 13, "Lạng Sơn", "Kiều Loan Lê", new DateTime(2024, 3, 23, 16, 41, 6, 172, DateTimeKind.Local).AddTicks(9796), "QuangDat.Vu16@yahoo.com", "0975524550" },
                    { 14, "Thừa Thiên-Huế", "Xuân Nhi Phan", new DateTime(2024, 3, 23, 16, 41, 6, 172, DateTimeKind.Local).AddTicks(9867), "ThyTruc.Pham3@hotmail.com", "0952994779" },
                    { 15, "Phú Yên", "Thiếu Anh Hoàng", new DateTime(2024, 3, 23, 16, 41, 6, 172, DateTimeKind.Local).AddTicks(9942), "NgocAn.Ha51@gmail.com", "0963347256" },
                    { 16, "Vĩnh Phúc", "Hồng Tâm Bùi", new DateTime(2024, 3, 23, 16, 41, 6, 173, DateTimeKind.Local).AddTicks(15), "HuuBao28@yahoo.com", "0947133545" },
                    { 17, "Kiên Giang", "Chí Hiếu Đoàn", new DateTime(2024, 3, 23, 16, 41, 6, 173, DateTimeKind.Local).AddTicks(81), "NhuHao15@yahoo.com", "0914547243" },
                    { 18, "Lai Châu", "Phúc Thịnh Đoàn", new DateTime(2024, 3, 23, 16, 41, 6, 173, DateTimeKind.Local).AddTicks(145), "VietNhi.Bui@yahoo.com", "0978568208" },
                    { 19, "Vĩnh Long", "Quốc Hạnh Phạm", new DateTime(2024, 3, 23, 16, 41, 6, 173, DateTimeKind.Local).AddTicks(217), "TuanChuong.Vuong22@hotmail.com", "0920744606" },
                    { 20, "Tiền Giang", "Minh Hào Hoàng", new DateTime(2024, 3, 23, 16, 41, 6, 173, DateTimeKind.Local).AddTicks(300), "VanThong_Truong16@hotmail.com", "0927676014" },
                    { 21, "Ninh Thuận", "Mộc Miên Trần", new DateTime(2024, 3, 23, 16, 41, 6, 173, DateTimeKind.Local).AddTicks(380), "KimNgoc82@yahoo.com", "0961270364" },
                    { 22, "Gia Lai", "Việt Sơn Vương", new DateTime(2024, 3, 23, 16, 41, 6, 173, DateTimeKind.Local).AddTicks(443), "GiaPhuoc94@yahoo.com", "0960951893" },
                    { 23, "Lạng Sơn", "Ðình Toàn Hà", new DateTime(2024, 3, 23, 16, 41, 6, 173, DateTimeKind.Local).AddTicks(514), "XuanVu88@gmail.com", "0936785225" },
                    { 24, "Ninh Thuận", "Dã Lâm Hoàng", new DateTime(2024, 3, 23, 16, 41, 6, 173, DateTimeKind.Local).AddTicks(581), "NgocHien39@hotmail.com", "0956681866" },
                    { 25, "Bến Tre", "Thanh Thuận Vương", new DateTime(2024, 3, 23, 16, 41, 6, 173, DateTimeKind.Local).AddTicks(648), "TanPhat.Hoang22@hotmail.com", "0999846127" },
                    { 26, "Thái Nguyên", "Thúy Huyền Tăng", new DateTime(2024, 3, 23, 16, 41, 6, 173, DateTimeKind.Local).AddTicks(719), "NhatHa.Phung86@yahoo.com", "0917540756" },
                    { 27, "Bình Dương", "Vân Trang Phan", new DateTime(2024, 3, 23, 16, 41, 6, 173, DateTimeKind.Local).AddTicks(783), "TrongDung_Nguyen@gmail.com", "0947186840" },
                    { 28, "Quảng Nam", "Hoa Thiên Lâm", new DateTime(2024, 3, 23, 16, 41, 6, 173, DateTimeKind.Local).AddTicks(855), "HaMi81@gmail.com", "0907316241" },
                    { 29, "Hà Giang", "Quang Nhật Mai", new DateTime(2024, 3, 23, 16, 41, 6, 173, DateTimeKind.Local).AddTicks(915), "QuyKhanh10@yahoo.com", "0912590816" },
                    { 30, "Hải Dương", "Phi Cường Trương", new DateTime(2024, 3, 23, 16, 41, 6, 173, DateTimeKind.Local).AddTicks(982), "VietKhang.Le85@hotmail.com", "0973625096" },
                    { 31, "Cao Bằng", "Việt Hùng Phan", new DateTime(2024, 3, 23, 16, 41, 6, 173, DateTimeKind.Local).AddTicks(1048), "AnhTuyet80@hotmail.com", "0916857222" },
                    { 32, "Lai Châu", "Minh Yến Trịnh", new DateTime(2024, 3, 23, 16, 41, 6, 173, DateTimeKind.Local).AddTicks(1117), "KimLien49@hotmail.com", "0947974621" },
                    { 33, "Lạng Sơn", "Bá Thịnh Tăng", new DateTime(2024, 3, 23, 16, 41, 6, 173, DateTimeKind.Local).AddTicks(1178), "TrungHai_Duong63@hotmail.com", "0929213291" },
                    { 34, "Thừa Thiên-Huế", "Ðức Chính Hà", new DateTime(2024, 3, 23, 16, 41, 6, 173, DateTimeKind.Local).AddTicks(1248), "VietLong48@hotmail.com", "0966096081" },
                    { 35, "Đồng Nai", "Gia Phước Đinh", new DateTime(2024, 3, 23, 16, 41, 6, 173, DateTimeKind.Local).AddTicks(1313), "HuuNghi97@hotmail.com", "0936986099" },
                    { 36, "Yên Bái", "Kim Hoàng Hồ", new DateTime(2024, 3, 23, 16, 41, 6, 173, DateTimeKind.Local).AddTicks(1371), "BichHai54@gmail.com", "0971490680" },
                    { 37, "Hà Nam", "Việt Hương Đoàn", new DateTime(2024, 3, 23, 16, 41, 6, 173, DateTimeKind.Local).AddTicks(1438), "ThuyLieu_Mai42@hotmail.com", "0924864920" },
                    { 38, "Đắk Lắk", "Bích Trâm Phan", new DateTime(2024, 3, 23, 16, 41, 6, 173, DateTimeKind.Local).AddTicks(1502), "NgocThuan.Tang@gmail.com", "0917704001" },
                    { 39, "Hải Phòng", "Huy Thông Mai", new DateTime(2024, 3, 23, 16, 41, 6, 173, DateTimeKind.Local).AddTicks(1571), "PhuongTrach_Ho@gmail.com", "0902838925" },
                    { 40, "Bình Định", "Phú Thọ Đỗ", new DateTime(2024, 3, 23, 16, 41, 6, 173, DateTimeKind.Local).AddTicks(1637), "TrungNhan.Dinh@gmail.com", "0923094897" },
                    { 41, "Bắc Ninh", "Hải Thụy Vũ", new DateTime(2024, 3, 23, 16, 41, 6, 173, DateTimeKind.Local).AddTicks(1705), "DanhThanh85@yahoo.com", "0932785253" },
                    { 42, "Đắk Lắk", "Ngọc Lân Hồ", new DateTime(2024, 3, 23, 16, 41, 6, 173, DateTimeKind.Local).AddTicks(1767), "VanThuy.Trinh93@yahoo.com", "0978148978" },
                    { 43, "Đồng Tháp", "Xuyến Chi Phùng", new DateTime(2024, 3, 23, 16, 41, 6, 173, DateTimeKind.Local).AddTicks(1834), "VietNhi_Trinh@yahoo.com", "0914980312" },
                    { 44, "Bình Định", "Hải Sinh Phan", new DateTime(2024, 3, 23, 16, 41, 6, 173, DateTimeKind.Local).AddTicks(1898), "ThuNgoc.Hoang@yahoo.com", "0979809532" },
                    { 45, "Vĩnh Phúc", "Thái Sơn Hoàng", new DateTime(2024, 3, 23, 16, 41, 6, 173, DateTimeKind.Local).AddTicks(1962), "VuongTrieu_Duong@hotmail.com", "0978348868" },
                    { 46, "Sơn La", "Tuyết Mai Vương", new DateTime(2024, 3, 23, 16, 41, 6, 173, DateTimeKind.Local).AddTicks(2030), "AnhThy.Duong@gmail.com", "0952731652" },
                    { 47, "Lâm Đồng", "Thúy Liễu Hoàng", new DateTime(2024, 3, 23, 16, 41, 6, 173, DateTimeKind.Local).AddTicks(2091), "KienDuc.Tran@yahoo.com", "0960500836" },
                    { 48, "Đắk Lắk", "Thanh Kiên Phùng", new DateTime(2024, 3, 23, 16, 41, 6, 173, DateTimeKind.Local).AddTicks(2157), "PhuBinh84@hotmail.com", "0954930459" },
                    { 49, "Quảng Bình", "Mỹ Hoàn Phùng", new DateTime(2024, 3, 23, 16, 41, 6, 173, DateTimeKind.Local).AddTicks(2217), "ThuongHuyen.Ho@gmail.com", "0973608140" },
                    { 50, "Bà Rịa-Vũng Tàu", "Minh Ðức Đinh", new DateTime(2024, 3, 23, 16, 41, 6, 173, DateTimeKind.Local).AddTicks(2291), "XuanQuan_Lam@gmail.com", "0943711848" },
                    { 51, "Quảng Bình", "Việt Thi Hoàng", new DateTime(2024, 3, 23, 16, 41, 6, 173, DateTimeKind.Local).AddTicks(2352), "ThuNga7@hotmail.com", "0921925951" },
                    { 52, "Lai Châu", "Trúc Phương Bùi", new DateTime(2024, 3, 23, 16, 41, 6, 173, DateTimeKind.Local).AddTicks(2412), "OanhTho.Tran@hotmail.com", "0946414347" },
                    { 53, "Hòa Bình", "Ngọc Ðoàn Đinh", new DateTime(2024, 3, 23, 16, 41, 6, 173, DateTimeKind.Local).AddTicks(2475), "NgocHien.Do86@hotmail.com", "0962681949" },
                    { 54, "Thừa Thiên-Huế", "Xuân Huy Trần", new DateTime(2024, 3, 23, 16, 41, 6, 173, DateTimeKind.Local).AddTicks(2540), "ThanhAn81@yahoo.com", "0920813404" },
                    { 55, "Lâm Đồng", "Nguyết Ánh Mai", new DateTime(2024, 3, 23, 16, 41, 6, 173, DateTimeKind.Local).AddTicks(2603), "HaiDuong3@yahoo.com", "0967766883" },
                    { 56, "Bình Thuận", "Trường Sinh Phùng", new DateTime(2024, 3, 23, 16, 41, 6, 173, DateTimeKind.Local).AddTicks(2677), "VanKhanh.Doan@hotmail.com", "0981046281" },
                    { 57, "Hậu Giang", "Bửu Diệp Trịnh", new DateTime(2024, 3, 23, 16, 41, 6, 173, DateTimeKind.Local).AddTicks(2742), "TungLam.Bui35@gmail.com", "0918133113" },
                    { 58, "Quảng Trị", "Liễu Oanh Vương", new DateTime(2024, 3, 23, 16, 41, 6, 173, DateTimeKind.Local).AddTicks(2803), "AnLai49@hotmail.com", "0923261487" },
                    { 59, "Điện Biên", "Hải Phương Lâm", new DateTime(2024, 3, 23, 16, 41, 6, 173, DateTimeKind.Local).AddTicks(2869), "MinhThuong.Duong@yahoo.com", "0936297204" },
                    { 60, "Bắc Kạn", "Yên Bằng Phạm", new DateTime(2024, 3, 23, 16, 41, 6, 173, DateTimeKind.Local).AddTicks(2930), "MongVan.Bui49@yahoo.com", "0941532169" },
                    { 61, "Hải Phòng", "Trọng Việt Tăng", new DateTime(2024, 3, 23, 16, 41, 6, 173, DateTimeKind.Local).AddTicks(2993), "DucHai.Pham63@hotmail.com", "0939950391" },
                    { 62, "Quảng Nam", "Quốc Mỹ Tăng", new DateTime(2024, 3, 23, 16, 41, 6, 173, DateTimeKind.Local).AddTicks(3053), "BaoHuynh.Doan75@gmail.com", "0962181642" },
                    { 63, "Bình Dương", "Thế An Vương", new DateTime(2024, 3, 23, 16, 41, 6, 173, DateTimeKind.Local).AddTicks(3124), "DinhSieu.Phung@yahoo.com", "0902619421" },
                    { 64, "Yên Bái", "Hồng Thụy Bùi", new DateTime(2024, 3, 23, 16, 41, 6, 173, DateTimeKind.Local).AddTicks(3188), "ThanhTruc_Vu@yahoo.com", "0995813151" },
                    { 65, "Lai Châu", "Diệu Vân Phùng", new DateTime(2024, 3, 23, 16, 41, 6, 173, DateTimeKind.Local).AddTicks(3255), "KhanhBinh.Dao@yahoo.com", "0922270406" },
                    { 66, "Ninh Thuận", "Hải Thụy Đỗ", new DateTime(2024, 3, 23, 16, 41, 6, 173, DateTimeKind.Local).AddTicks(3320), "DinhQuang_Ly@yahoo.com", "0966278586" },
                    { 67, "Đắk Nông", "Lam Tuyền Trần", new DateTime(2024, 3, 23, 16, 41, 6, 173, DateTimeKind.Local).AddTicks(3386), "HueThuong_Tran93@yahoo.com", "0917831025" },
                    { 68, "Bắc Giang", "Nhật Lệ Phạm", new DateTime(2024, 3, 23, 16, 41, 6, 173, DateTimeKind.Local).AddTicks(3456), "BaoNgoc43@yahoo.com", "0968890013" },
                    { 69, "Vĩnh Long", "Ngọc Mai Phan", new DateTime(2024, 3, 23, 16, 41, 6, 173, DateTimeKind.Local).AddTicks(3514), "BuuToai.Duong0@gmail.com", "0930317478" },
                    { 70, "Tiền Giang", "Quốc Hùng Phùng", new DateTime(2024, 3, 23, 16, 41, 6, 173, DateTimeKind.Local).AddTicks(3588), "TuanLong_Mai@gmail.com", "0967536745" },
                    { 71, "Hà Giang", "Lan Anh Hoàng", new DateTime(2024, 3, 23, 16, 41, 6, 173, DateTimeKind.Local).AddTicks(3651), "BaoBinh_To@hotmail.com", "0955442734" },
                    { 72, "Hưng Yên", "Phương Trà Lê", new DateTime(2024, 3, 23, 16, 41, 6, 173, DateTimeKind.Local).AddTicks(3714), "QuocThien32@yahoo.com", "0922134965" },
                    { 73, "Hòa Bình", "Duy Cường Vương", new DateTime(2024, 3, 23, 16, 41, 6, 173, DateTimeKind.Local).AddTicks(3780), "ThuHa.Tran35@yahoo.com", "0912195846" },
                    { 74, "Hà Nam", "Lương Tuyền Đặng", new DateTime(2024, 3, 23, 16, 41, 6, 173, DateTimeKind.Local).AddTicks(3848), "DinhNgan39@hotmail.com", "0932879117" },
                    { 75, "Sóc Trăng", "Hữu Nghĩa Đặng", new DateTime(2024, 3, 23, 16, 41, 6, 173, DateTimeKind.Local).AddTicks(3907), "ThangLoi94@gmail.com", "0997161353" },
                    { 76, "Lào Cai", "Phượng Bích Dương", new DateTime(2024, 3, 23, 16, 41, 6, 173, DateTimeKind.Local).AddTicks(3972), "DangKhoa_Truong3@gmail.com", "0969746834" },
                    { 77, "Quảng Ngãi", "Mạnh Trường Lâm", new DateTime(2024, 3, 23, 16, 41, 6, 173, DateTimeKind.Local).AddTicks(4047), "TrungChuyen55@hotmail.com", "0906610986" },
                    { 78, "Trà Vinh", "Thúy Mai Nguyễn", new DateTime(2024, 3, 23, 16, 41, 6, 173, DateTimeKind.Local).AddTicks(4112), "BachKim.Trinh@yahoo.com", "0940733344" },
                    { 79, "Thái Nguyên", "Thiên Duyên Ngô", new DateTime(2024, 3, 23, 16, 41, 6, 173, DateTimeKind.Local).AddTicks(4180), "NhatKhuong77@yahoo.com", "0907281820" },
                    { 80, "Cần Thơ", "Tú Ly Mai", new DateTime(2024, 3, 23, 16, 41, 6, 173, DateTimeKind.Local).AddTicks(4247), "KhanhGiang.Dang@hotmail.com", "0932101258" },
                    { 81, "Bắc Ninh", "Ngọc Lan Nguyễn", new DateTime(2024, 3, 23, 16, 41, 6, 173, DateTimeKind.Local).AddTicks(4318), "NguyenNhan.Mai28@hotmail.com", "0975734737" },
                    { 82, "Hà Nội", "Trung Nguyên Dương", new DateTime(2024, 3, 23, 16, 41, 6, 173, DateTimeKind.Local).AddTicks(4383), "ThanhTrung.Trinh1@yahoo.com", "0935801087" },
                    { 83, "Tiền Giang", "Bạch Cúc Đặng", new DateTime(2024, 3, 23, 16, 41, 6, 173, DateTimeKind.Local).AddTicks(4460), "KienLam12@gmail.com", "0939813650" },
                    { 84, "Đồng Tháp", "Tuyết Nga Đỗ", new DateTime(2024, 3, 23, 16, 41, 6, 173, DateTimeKind.Local).AddTicks(4522), "HanhSan.Le@hotmail.com", "0958889846" },
                    { 85, "Yên Bái", "Vân Khanh Trịnh", new DateTime(2024, 3, 23, 16, 41, 6, 173, DateTimeKind.Local).AddTicks(4583), "QuynhChi12@gmail.com", "0901066500" },
                    { 86, "Quảng Ngãi", "Thương Thương Đỗ", new DateTime(2024, 3, 23, 16, 41, 6, 173, DateTimeKind.Local).AddTicks(4648), "KhaiCa5@gmail.com", "0914656059" },
                    { 87, "Lâm Đồng", "Hạnh Chi Phan", new DateTime(2024, 3, 23, 16, 41, 6, 173, DateTimeKind.Local).AddTicks(4708), "QuynhDung24@yahoo.com", "0928333137" },
                    { 88, "Hà Nam", "Diễm Khuê Tăng", new DateTime(2024, 3, 23, 16, 41, 6, 173, DateTimeKind.Local).AddTicks(4778), "QuynhNhi_Bui@yahoo.com", "0972038770" },
                    { 89, "Cao Bằng", "Long Vịnh Hà", new DateTime(2024, 3, 23, 16, 41, 6, 173, DateTimeKind.Local).AddTicks(4838), "PhuongChi_Mai62@gmail.com", "0943095878" },
                    { 90, "Phú Yên", "Bích Vân Lê", new DateTime(2024, 3, 23, 16, 41, 6, 173, DateTimeKind.Local).AddTicks(4907), "BaoHuynh_Dao29@hotmail.com", "0934739580" },
                    { 91, "Quảng Ngãi", "Quảng Thông Lê", new DateTime(2024, 3, 23, 16, 41, 6, 173, DateTimeKind.Local).AddTicks(4968), "AnhHoang.To@yahoo.com", "0950637487" },
                    { 92, "Yên Bái", "Thanh Kiều Hồ", new DateTime(2024, 3, 23, 16, 41, 6, 173, DateTimeKind.Local).AddTicks(5033), "XuyenChi1@gmail.com", "0930051290" },
                    { 93, "Quảng Ngãi", "Hải Phong Ngô", new DateTime(2024, 3, 23, 16, 41, 6, 173, DateTimeKind.Local).AddTicks(5091), "NgocKhang.Truong72@gmail.com", "0908279702" },
                    { 94, "Bắc Ninh", "Viết Tân Đinh", new DateTime(2024, 3, 23, 16, 41, 6, 173, DateTimeKind.Local).AddTicks(5162), "LinhPhuong_Dang15@hotmail.com", "0933365187" },
                    { 95, "Bắc Kạn", "Ánh Hồng Phan", new DateTime(2024, 3, 23, 16, 41, 6, 173, DateTimeKind.Local).AddTicks(5231), "ThaoNguyen_Doan73@gmail.com", "0986798776" },
                    { 96, "Nam Định", "Ngọc Thuận Đặng", new DateTime(2024, 3, 23, 16, 41, 6, 173, DateTimeKind.Local).AddTicks(5296), "HaMi_To@hotmail.com", "0966660034" },
                    { 97, "Nam Định", "Kiều Loan Đào", new DateTime(2024, 3, 23, 16, 41, 6, 173, DateTimeKind.Local).AddTicks(5355), "TamNhi75@gmail.com", "0995355983" },
                    { 98, "Bắc Ninh", "Nhật Huy Vương", new DateTime(2024, 3, 23, 16, 41, 6, 173, DateTimeKind.Local).AddTicks(5415), "VietCuong_Phan44@yahoo.com", "0957988252" },
                    { 99, "Đồng Tháp", "Thiện Tâm Đào", new DateTime(2024, 3, 23, 16, 41, 6, 173, DateTimeKind.Local).AddTicks(5485), "AiThi.Phan18@hotmail.com", "0954601702" },
                    { 100, "Lai Châu", "Hữu Khôi Ngô", new DateTime(2024, 3, 23, 16, 41, 6, 173, DateTimeKind.Local).AddTicks(5547), "NgocKhoi82@yahoo.com", "0900164448" }
                });

            migrationBuilder.InsertData(
                table: "Employee",
                columns: new[] { "EmployeeID", "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[,]
                {
                    { 1, "Tuyên Quang", new DateTime(2024, 3, 23, 16, 41, 6, 178, DateTimeKind.Local).AddTicks(687), "NgocTram61@yahoo.com", "Tùng Quân Đinh", "0922424167", 522129.8298794139000000m },
                    { 2, "Hà Giang", new DateTime(2024, 3, 23, 16, 41, 6, 178, DateTimeKind.Local).AddTicks(3105), "VietNhan_Ly57@gmail.com", "Ðức Kiên Trần", "0965464010", 951139.314495916500000m },
                    { 3, "Phú Yên", new DateTime(2024, 3, 23, 16, 41, 6, 178, DateTimeKind.Local).AddTicks(3228), "TruongPhuc62@gmail.com", "Uyển Như Phạm", "0958656414", 618931.359025966000000m },
                    { 4, "Đắk Lắk", new DateTime(2024, 3, 23, 16, 41, 6, 178, DateTimeKind.Local).AddTicks(3281), "KimThao.Trinh78@yahoo.com", "Bá Trúc Trịnh", "0970104563", 622756.126916582000000m },
                    { 5, "Bà Rịa-Vũng Tàu", new DateTime(2024, 3, 23, 16, 41, 6, 178, DateTimeKind.Local).AddTicks(3324), "TuongLan_To@yahoo.com", "Trung Nguyên Ngô", "0977281836", 632586.909205773500000m },
                    { 6, "Trà Vinh", new DateTime(2024, 3, 23, 16, 41, 6, 178, DateTimeKind.Local).AddTicks(3373), "KimKhanh_Ngo37@yahoo.com", "Thúy Mai Bùi", "0931881066", 825949.652756656000000m },
                    { 7, "Đồng Tháp", new DateTime(2024, 3, 23, 16, 41, 6, 178, DateTimeKind.Local).AddTicks(3414), "ChePhuong.Ly25@yahoo.com", "Yên Bằng Đỗ", "0934912361", 525468.0787485942000000m },
                    { 8, "Phú Yên", new DateTime(2024, 3, 23, 16, 41, 6, 178, DateTimeKind.Local).AddTicks(3453), "DinhChieu52@hotmail.com", "Trọng Hiếu Trương", "0940651624", 536387.7938365107000000m },
                    { 9, "Long An", new DateTime(2024, 3, 23, 16, 41, 6, 178, DateTimeKind.Local).AddTicks(3497), "TuanHung.Tran5@hotmail.com", "Thanh Hường Trần", "0928573220", 583521.558204563500000m },
                    { 10, "Đà Nẵng", new DateTime(2024, 3, 23, 16, 41, 6, 178, DateTimeKind.Local).AddTicks(3536), "DuyAn88@gmail.com", "Quang Triều Đỗ", "0926756614", 987309.929792513000000m },
                    { 11, "Quảng Ninh", new DateTime(2024, 3, 23, 16, 41, 6, 178, DateTimeKind.Local).AddTicks(3576), "LanTruc_Duong68@yahoo.com", "Nguyệt Cát Hoàng", "0949482022", 527122.981198666500000m },
                    { 12, "Bình Thuận", new DateTime(2024, 3, 23, 16, 41, 6, 178, DateTimeKind.Local).AddTicks(3621), "KhanhAn.Ly@hotmail.com", "Ngọc Ẩn Nguyễn", "0940352119", 693864.611799587500000m },
                    { 13, "Cao Bằng", new DateTime(2024, 3, 23, 16, 41, 6, 178, DateTimeKind.Local).AddTicks(3660), "KhanhHoa.Phan@yahoo.com", "Huy Anh Trần", "0992163095", 756652.124732458000000m },
                    { 14, "Thừa Thiên-Huế", new DateTime(2024, 3, 23, 16, 41, 6, 178, DateTimeKind.Local).AddTicks(3699), "LienTran78@yahoo.com", "Khương Duy Nguyễn", "0956528960", 895168.330088361000000m },
                    { 15, "An Giang", new DateTime(2024, 3, 23, 16, 41, 6, 178, DateTimeKind.Local).AddTicks(3744), "VuongTrieu.Tang28@yahoo.com", "Bá Thịnh Đinh", "0993813084", 958204.719068693500000m },
                    { 16, "Điện Biên", new DateTime(2024, 3, 23, 16, 41, 6, 178, DateTimeKind.Local).AddTicks(3782), "VinhDieu_Vuong76@gmail.com", "Kim Tuyến Ngô", "0927119674", 924157.973736528500000m },
                    { 17, "Hưng Yên", new DateTime(2024, 3, 23, 16, 41, 6, 178, DateTimeKind.Local).AddTicks(3826), "BaoLan_Tran@yahoo.com", "Hữu Hùng Đào", "0908846557", 815557.432146667000000m },
                    { 18, "Hải Phòng", new DateTime(2024, 3, 23, 16, 41, 6, 178, DateTimeKind.Local).AddTicks(3866), "ThienMai.Ngo@yahoo.com", "Mai Hà Tăng", "0974876217", 813942.315573827000000m },
                    { 19, "Sóc Trăng", new DateTime(2024, 3, 23, 16, 41, 6, 178, DateTimeKind.Local).AddTicks(3905), "BaoThach_Ngo47@gmail.com", "Anh Duy Đặng", "0999409202", 581635.745780176500000m },
                    { 20, "Quảng Bình", new DateTime(2024, 3, 23, 16, 41, 6, 178, DateTimeKind.Local).AddTicks(3948), "HongNhan_Duong55@yahoo.com", "Thanh Thư Lâm", "0958365578", 946821.975615407000000m },
                    { 21, "Đồng Tháp", new DateTime(2024, 3, 23, 16, 41, 6, 178, DateTimeKind.Local).AddTicks(3986), "ThienLan.Pham@hotmail.com", "Thu Việt Hồ", "0900950819", 573015.238095195500000m },
                    { 22, "Đồng Nai", new DateTime(2024, 3, 23, 16, 41, 6, 178, DateTimeKind.Local).AddTicks(4023), "DinhLoc.Dang85@hotmail.com", "Chi Mai Mai", "0981342479", 613470.960018409500000m },
                    { 23, "Bình Dương", new DateTime(2024, 3, 23, 16, 41, 6, 178, DateTimeKind.Local).AddTicks(4066), "AnhMinh64@hotmail.com", "Kim Ánh Đặng", "0952322360", 785045.72117330500000m },
                    { 24, "Bình Thuận", new DateTime(2024, 3, 23, 16, 41, 6, 178, DateTimeKind.Local).AddTicks(4104), "MongThu90@gmail.com", "Quốc Thiện Trần", "0991364063", 639252.277826942500000m },
                    { 25, "Cao Bằng", new DateTime(2024, 3, 23, 16, 41, 6, 178, DateTimeKind.Local).AddTicks(4141), "ThuyLieu35@gmail.com", "Trọng Tường Hồ", "0972833787", 566515.604917802500000m },
                    { 26, "Gia Lai", new DateTime(2024, 3, 23, 16, 41, 6, 178, DateTimeKind.Local).AddTicks(4184), "ThanhTin_Do@yahoo.com", "Quốc Hải Lê", "0913858596", 862402.94321648500000m },
                    { 27, "Yên Bái", new DateTime(2024, 3, 23, 16, 41, 6, 178, DateTimeKind.Local).AddTicks(4222), "TienDung.Ho@hotmail.com", "Duyên My Đinh", "0945544967", 874977.644172297000000m },
                    { 28, "Bà Rịa-Vũng Tàu", new DateTime(2024, 3, 23, 16, 41, 6, 178, DateTimeKind.Local).AddTicks(4265), "HoaLy.Ly@hotmail.com", "Lục Bình Tăng", "0918468572", 933112.241478828000000m },
                    { 29, "Khánh Hoà", new DateTime(2024, 3, 23, 16, 41, 6, 178, DateTimeKind.Local).AddTicks(4304), "NhanHong.Truong@yahoo.com", "Minh Hưng Trịnh", "0946265271", 643857.884664063000000m },
                    { 30, "Đồng Tháp", new DateTime(2024, 3, 23, 16, 41, 6, 178, DateTimeKind.Local).AddTicks(4342), "LeQuyen_Tran54@gmail.com", "Sĩ Hoàng Tăng", "0953918799", 795257.866580097500000m },
                    { 31, "Bà Rịa-Vũng Tàu", new DateTime(2024, 3, 23, 16, 41, 6, 178, DateTimeKind.Local).AddTicks(4389), "UyenMy93@hotmail.com", "Thanh Huy Phạm", "0905810334", 888431.329740146000000m },
                    { 32, "Hà Tĩnh", new DateTime(2024, 3, 23, 16, 41, 6, 178, DateTimeKind.Local).AddTicks(4429), "TuanSi.Phung@yahoo.com", "Thăng Long Tăng", "0975522330", 532521.3001722811000000m },
                    { 33, "Kiên Giang", new DateTime(2024, 3, 23, 16, 41, 6, 178, DateTimeKind.Local).AddTicks(4469), "BaoPhuong35@gmail.com", "Sỹ Ðan Đinh", "0975988543", 972328.585468382000000m },
                    { 34, "Bến Tre", new DateTime(2024, 3, 23, 16, 41, 6, 178, DateTimeKind.Local).AddTicks(4512), "NhaMai83@hotmail.com", "Bình Dương Tô", "0966831746", 887430.734248277000000m },
                    { 35, "Lâm Đồng", new DateTime(2024, 3, 23, 16, 41, 6, 178, DateTimeKind.Local).AddTicks(4551), "KhaiCa_Ngo89@gmail.com", "Quang Ðạt Ngô", "0990550036", 899317.56484565500000m },
                    { 36, "Lạng Sơn", new DateTime(2024, 3, 23, 16, 41, 6, 178, DateTimeKind.Local).AddTicks(4589), "NgocTru_Mai67@yahoo.com", "Nguyên Thảo Tô", "0908617054", 530840.3822357092500000m },
                    { 37, "Nam Định", new DateTime(2024, 3, 23, 16, 41, 6, 178, DateTimeKind.Local).AddTicks(4632), "ChiThanh0@yahoo.com", "Cẩm Nhung Tăng", "0957258584", 659619.928587227500000m },
                    { 38, "Nghệ An", new DateTime(2024, 3, 23, 16, 41, 6, 178, DateTimeKind.Local).AddTicks(4670), "PhuongNgoc_Duong36@yahoo.com", "Hoàng Miên Phạm", "0916313558", 548840.2444493686000000m },
                    { 39, "Lai Châu", new DateTime(2024, 3, 23, 16, 41, 6, 178, DateTimeKind.Local).AddTicks(4713), "QuangTrieu.Tang@gmail.com", "Chí Anh Hồ", "0936161110", 609375.411193748500000m },
                    { 40, "Hòa Bình", new DateTime(2024, 3, 23, 16, 41, 6, 178, DateTimeKind.Local).AddTicks(4751), "KhietTam_Phung@hotmail.com", "Ðình Ngân Mai", "0902621726", 842724.14037595500000m },
                    { 41, "Vĩnh Phúc", new DateTime(2024, 3, 23, 16, 41, 6, 178, DateTimeKind.Local).AddTicks(4788), "TuongAnh18@gmail.com", "Ngân Trúc Phan", "0914529268", 584717.587249841500000m },
                    { 42, "Vĩnh Long", new DateTime(2024, 3, 23, 16, 41, 6, 178, DateTimeKind.Local).AddTicks(4833), "NgocQuang_Dao@gmail.com", "Thiện Lương Lý", "0946268974", 631039.709958061000000m },
                    { 43, "Bắc Kạn", new DateTime(2024, 3, 23, 16, 41, 6, 178, DateTimeKind.Local).AddTicks(4871), "HuuThong23@yahoo.com", "Huệ Thương Phạm", "0926696778", 677338.289430489000000m },
                    { 44, "Sóc Trăng", new DateTime(2024, 3, 23, 16, 41, 6, 178, DateTimeKind.Local).AddTicks(4909), "ThanhThu33@yahoo.com", "Thái Thảo Trần", "0963895082", 843012.874425347500000m },
                    { 45, "Cao Bằng", new DateTime(2024, 3, 23, 16, 41, 6, 178, DateTimeKind.Local).AddTicks(4956), "SuongSuong8@hotmail.com", "Phước Nhân Mai", "0969441876", 833764.670158187500000m },
                    { 46, "Nam Định", new DateTime(2024, 3, 23, 16, 41, 6, 178, DateTimeKind.Local).AddTicks(4993), "AnhThai.Ho@hotmail.com", "Thục Vân Hồ", "0988315044", 916593.10816453000000m },
                    { 47, "Quảng Nam", new DateTime(2024, 3, 23, 16, 41, 6, 178, DateTimeKind.Local).AddTicks(5033), "BanMai.Mai42@hotmail.com", "Lan Ngọc Hà", "0945827909", 603020.742867344500000m },
                    { 48, "Bình Thuận", new DateTime(2024, 3, 23, 16, 41, 6, 178, DateTimeKind.Local).AddTicks(5077), "CongBang15@gmail.com", "Khánh Hoàn Đào", "0944316277", 968263.199873512000000m },
                    { 49, "Kon Tum", new DateTime(2024, 3, 23, 16, 41, 6, 178, DateTimeKind.Local).AddTicks(5120), "HuuChien_Phan@gmail.com", "Dã Lan Lâm", "0970580651", 990285.439658347000000m },
                    { 50, "Kon Tum", new DateTime(2024, 3, 23, 16, 41, 6, 178, DateTimeKind.Local).AddTicks(5160), "BaThien_Bui40@yahoo.com", "Phương Dung Lý", "0994060088", 956137.559606269000000m },
                    { 51, "Sơn La", new DateTime(2024, 3, 23, 16, 41, 6, 178, DateTimeKind.Local).AddTicks(5208), "NhaHuong_Vu@gmail.com", "Việt Thanh Đoàn", "0912536133", 686378.887295363000000m },
                    { 52, "Khánh Hoà", new DateTime(2024, 3, 23, 16, 41, 6, 178, DateTimeKind.Local).AddTicks(5251), "LuongThien15@gmail.com", "Bửu Chưởng Lý", "0936412056", 985470.313951746000000m },
                    { 53, "Khánh Hoà", new DateTime(2024, 3, 23, 16, 41, 6, 178, DateTimeKind.Local).AddTicks(5293), "YenThanh56@hotmail.com", "Hồng Thảo Dương", "0951909888", 813447.003150247000000m },
                    { 54, "Hải Dương", new DateTime(2024, 3, 23, 16, 41, 6, 178, DateTimeKind.Local).AddTicks(5337), "MaiLien.Ly53@hotmail.com", "Hồng Châu Hà", "0925131783", 692817.240371614500000m },
                    { 55, "Kiên Giang", new DateTime(2024, 3, 23, 16, 41, 6, 178, DateTimeKind.Local).AddTicks(5375), "LinhLan43@hotmail.com", "Minh Kỳ Lê", "0941003651", 886333.363087630500000m },
                    { 56, "Tuyên Quang", new DateTime(2024, 3, 23, 16, 41, 6, 178, DateTimeKind.Local).AddTicks(5423), "MongLong.Vuong@yahoo.com", "Giang Nam Hoàng", "0999248001", 870341.985838324500000m },
                    { 57, "Điện Biên", new DateTime(2024, 3, 23, 16, 41, 6, 178, DateTimeKind.Local).AddTicks(5462), "TrungKien.Lam@yahoo.com", "Thanh Lâm Đinh", "0918946309", 694256.379664812000000m },
                    { 58, "Quảng Nam", new DateTime(2024, 3, 23, 16, 41, 6, 178, DateTimeKind.Local).AddTicks(5500), "NhaSuong_Dang65@yahoo.com", "Nam Thông Bùi", "0994250627", 773840.777308836500000m },
                    { 59, "Bắc Kạn", new DateTime(2024, 3, 23, 16, 41, 6, 178, DateTimeKind.Local).AddTicks(5545), "PhuongPhi34@hotmail.com", "Hải My Mai", "0973323850", 800337.579126811000000m },
                    { 60, "Ninh Bình", new DateTime(2024, 3, 23, 16, 41, 6, 178, DateTimeKind.Local).AddTicks(5583), "BichTram_Pham70@gmail.com", "Diệu Linh Bùi", "0929473671", 530326.4672513775500000m },
                    { 61, "Bình Định", new DateTime(2024, 3, 23, 16, 41, 6, 178, DateTimeKind.Local).AddTicks(5621), "MinhAnh79@hotmail.com", "Hữu Tâm Phùng", "0938282892", 524925.1632626561500000m },
                    { 62, "Long An", new DateTime(2024, 3, 23, 16, 41, 6, 178, DateTimeKind.Local).AddTicks(5668), "TinhTam_Duong@gmail.com", "Tuyết Mai Dương", "0947401152", 701623.483613500000m },
                    { 63, "Hưng Yên", new DateTime(2024, 3, 23, 16, 41, 6, 178, DateTimeKind.Local).AddTicks(5705), "BichHai85@gmail.com", "Giáng Ngọc Hà", "0924389400", 516831.217222504500000m },
                    { 64, "Hà Giang", new DateTime(2024, 3, 23, 16, 41, 6, 178, DateTimeKind.Local).AddTicks(5750), "NgocLinh_Phung52@gmail.com", "Thuận Phương Vũ", "0905254403", 712795.617973939500000m },
                    { 65, "Phú Thọ", new DateTime(2024, 3, 23, 16, 41, 6, 178, DateTimeKind.Local).AddTicks(5789), "XuanMinh77@yahoo.com", "Chính Trực Hoàng", "0903558068", 922177.682741488000000m },
                    { 66, "Thanh Hoá", new DateTime(2024, 3, 23, 16, 41, 6, 178, DateTimeKind.Local).AddTicks(5828), "QuangThach.Ngo71@yahoo.com", "Khang Kiện Mai", "0978806215", 628171.71215447000000m },
                    { 67, "Lâm Đồng", new DateTime(2024, 3, 23, 16, 41, 6, 178, DateTimeKind.Local).AddTicks(5899), "VuHong_Dao5@hotmail.com", "Tịnh Như Đinh", "0971419397", 923192.298368728000000m },
                    { 68, "Tây Ninh", new DateTime(2024, 3, 23, 16, 41, 6, 178, DateTimeKind.Local).AddTicks(5937), "ThaiDuc.Phan9@yahoo.com", "Quốc Hưng Đặng", "0965267231", 615539.688795974000000m },
                    { 69, "Quảng Ninh", new DateTime(2024, 3, 23, 16, 41, 6, 178, DateTimeKind.Local).AddTicks(5976), "MinhHai.Truong84@gmail.com", "Tấn Nam Lý", "0970901203", 997203.752940961000000m },
                    { 70, "Đắk Lắk", new DateTime(2024, 3, 23, 16, 41, 6, 178, DateTimeKind.Local).AddTicks(6021), "QuynhLam_Ly41@gmail.com", "Thúy Ngà Đặng", "0963749874", 994448.133568470500000m },
                    { 71, "Nam Định", new DateTime(2024, 3, 23, 16, 41, 6, 178, DateTimeKind.Local).AddTicks(6059), "KienDuc5@gmail.com", "Danh Văn Đoàn", "0911338691", 928959.601089233000000m },
                    { 72, "Bắc Ninh", new DateTime(2024, 3, 23, 16, 41, 6, 178, DateTimeKind.Local).AddTicks(6097), "BichTram46@gmail.com", "Tùng Lâm Trương", "0949059217", 801949.786568011000000m },
                    { 73, "TP. Hồ Chí Minh", new DateTime(2024, 3, 23, 16, 41, 6, 178, DateTimeKind.Local).AddTicks(6137), "ThanhThien.Hoang71@gmail.com", "Minh Mẫn Phùng", "0914241936", 735726.5575657500000m },
                    { 74, "Hòa Bình", new DateTime(2024, 3, 23, 16, 41, 6, 178, DateTimeKind.Local).AddTicks(6176), "ThanhHoa5@hotmail.com", "Yên Nhi Mai", "0913454588", 881403.289388627500000m },
                    { 75, "Kiên Giang", new DateTime(2024, 3, 23, 16, 41, 6, 178, DateTimeKind.Local).AddTicks(6218), "UyenMinh.Ly14@yahoo.com", "Uyển Nghi Phạm", "0949141674", 910468.350006975500000m },
                    { 76, "Hà Tĩnh", new DateTime(2024, 3, 23, 16, 41, 6, 178, DateTimeKind.Local).AddTicks(6257), "HangNga.Phung@yahoo.com", "Phượng Tiên Lâm", "0958462007", 541545.3537438621000000m },
                    { 77, "Bắc Ninh", new DateTime(2024, 3, 23, 16, 41, 6, 178, DateTimeKind.Local).AddTicks(6295), "HuuNghi.Tang@gmail.com", "Lâm Nhi Hồ", "0993484914", 834008.385823627500000m },
                    { 78, "Bến Tre", new DateTime(2024, 3, 23, 16, 41, 6, 178, DateTimeKind.Local).AddTicks(6338), "BaoBinh17@hotmail.com", "Bá Long Trần", "0948330739", 572078.391519238000000m },
                    { 79, "Yên Bái", new DateTime(2024, 3, 23, 16, 41, 6, 178, DateTimeKind.Local).AddTicks(6374), "HuyViet.Ha72@hotmail.com", "Phúc Hưng Ngô", "0983580813", 571119.196985289000000m },
                    { 80, "Vĩnh Long", new DateTime(2024, 3, 23, 16, 41, 6, 178, DateTimeKind.Local).AddTicks(6411), "BaoThach.To68@hotmail.com", "Yến Trang Phan", "0915470988", 707153.745361339000000m },
                    { 81, "An Giang", new DateTime(2024, 3, 23, 16, 41, 6, 178, DateTimeKind.Local).AddTicks(6455), "QuocViet_Ngo@gmail.com", "Hữu Vĩnh Đỗ", "0921761438", 700704.190303004500000m },
                    { 82, "Đà Nẵng", new DateTime(2024, 3, 23, 16, 41, 6, 178, DateTimeKind.Local).AddTicks(6494), "NguyenBao_Tran@yahoo.com", "Cương Quyết Trịnh", "0983868500", 540758.605771888000000m },
                    { 83, "Phú Yên", new DateTime(2024, 3, 23, 16, 41, 6, 178, DateTimeKind.Local).AddTicks(6532), "DucPhi.Dao6@gmail.com", "Phúc Hưng Tăng", "0934814515", 611008.70576779000000m },
                    { 84, "Gia Lai", new DateTime(2024, 3, 23, 16, 41, 6, 178, DateTimeKind.Local).AddTicks(6576), "MinhThu.Phung65@gmail.com", "Khánh Ngọc Mai", "0945707303", 897709.88251224500000m },
                    { 85, "Sóc Trăng", new DateTime(2024, 3, 23, 16, 41, 6, 178, DateTimeKind.Local).AddTicks(6614), "TrucLien_Ngo@hotmail.com", "Trường Nhân Phùng", "0902512261", 941943.988154028500000m },
                    { 86, "Long An", new DateTime(2024, 3, 23, 16, 41, 6, 178, DateTimeKind.Local).AddTicks(6650), "NhanTu_Ngo66@hotmail.com", "Bạch Kim Đỗ", "0906685430", 918101.811033595500000m },
                    { 87, "Bắc Ninh", new DateTime(2024, 3, 23, 16, 41, 6, 178, DateTimeKind.Local).AddTicks(6691), "HaiPhuong.Duong@hotmail.com", "Quốc Hoài Lê", "0972087623", 510921.6415678713000000m },
                    { 88, "Vĩnh Phúc", new DateTime(2024, 3, 23, 16, 41, 6, 178, DateTimeKind.Local).AddTicks(6735), "TuyetBang49@gmail.com", "Hướng Bình Lê", "0985661681", 835021.970329687000000m },
                    { 89, "Hòa Bình", new DateTime(2024, 3, 23, 16, 41, 6, 178, DateTimeKind.Local).AddTicks(6779), "YenTrang87@gmail.com", "Trúc Mai Lê", "0918569664", 840606.841612318500000m },
                    { 90, "Phú Thọ", new DateTime(2024, 3, 23, 16, 41, 6, 178, DateTimeKind.Local).AddTicks(6817), "VietHung.Tran95@yahoo.com", "Xuân Sơn Lê", "0915183935", 572476.277894590500000m },
                    { 91, "Thanh Hoá", new DateTime(2024, 3, 23, 16, 41, 6, 178, DateTimeKind.Local).AddTicks(6855), "TungAnh_Mai17@hotmail.com", "Xuân xanh Hà", "0977447740", 567668.755289750500000m },
                    { 92, "Quảng Nam", new DateTime(2024, 3, 23, 16, 41, 6, 178, DateTimeKind.Local).AddTicks(6897), "XuanTam58@gmail.com", "Hữu Bào Vương", "0952079494", 754043.180475680500000m },
                    { 93, "Quảng Ninh", new DateTime(2024, 3, 23, 16, 41, 6, 178, DateTimeKind.Local).AddTicks(6935), "PhuongNhung_Phung@hotmail.com", "Thục Tâm Phùng", "0928419707", 739954.547425653000000m },
                    { 94, "TP. Hồ Chí Minh", new DateTime(2024, 3, 23, 16, 41, 6, 178, DateTimeKind.Local).AddTicks(6984), "SuongSuong_Mai37@yahoo.com", "Hà Mi Dương", "0978004476", 883873.486918539500000m },
                    { 95, "Hải Phòng", new DateTime(2024, 3, 23, 16, 41, 6, 178, DateTimeKind.Local).AddTicks(7026), "ThieuLy_Dang65@gmail.com", "Kim Thy Vũ", "0943227999", 539921.2902128367000000m },
                    { 96, "Cần Thơ", new DateTime(2024, 3, 23, 16, 41, 6, 178, DateTimeKind.Local).AddTicks(7062), "NgocCam.Ly85@gmail.com", "Linh Châu Tô", "0942340425", 564789.155287614500000m },
                    { 97, "Bình Phước", new DateTime(2024, 3, 23, 16, 41, 6, 178, DateTimeKind.Local).AddTicks(7099), "ThuSinh72@gmail.com", "Việt Quyết Vương", "0993770518", 756902.871418302500000m },
                    { 98, "Vĩnh Long", new DateTime(2024, 3, 23, 16, 41, 6, 178, DateTimeKind.Local).AddTicks(7143), "TriHung.Vuong49@gmail.com", "Thục Quyên Đỗ", "0960337000", 990247.242083166000000m },
                    { 99, "Sóc Trăng", new DateTime(2024, 3, 23, 16, 41, 6, 178, DateTimeKind.Local).AddTicks(7182), "LamNgoc52@hotmail.com", "Nhất Tiến Hà", "0941442906", 590418.35360168000000m },
                    { 100, "Lạng Sơn", new DateTime(2024, 3, 23, 16, 41, 6, 178, DateTimeKind.Local).AddTicks(7225), "TamDoan.Vuong@gmail.com", "Thu Việt Trịnh", "0990894752", 643503.03501354500000m }
                });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "PermissionID",
                keyValue: 1,
                columns: new[] { "CanCreateProduct", "CanCreateSalesOrder", "CanDeleteProduct", "CanExportSalesOrder", "CanPrintSalesOrder", "CanReadDetailImportOrder", "CanReadProduct", "CanReadSalesOrder", "CanUpdateProduct" },
                values: new object[] { true, true, true, true, true, false, true, true, true });

            migrationBuilder.InsertData(
                table: "Permission",
                columns: new[] { "PermissionID", "CanCreateCustomer", "CanCreateEmployee", "CanCreateImportOrder", "CanCreateProduct", "CanCreateSalesOrder", "CanCreateUserRole", "CanCreatedProvider", "CanDeleteCustomer", "CanDeleteEmployee", "CanDeleteImportOrder", "CanDeleteProduct", "CanDeleteProvider", "CanDeleteSalesOrder", "CanDeleteUserRole", "CanExportImportOrder", "CanExportSalesOrder", "CanPrintImportOrder", "CanPrintSalesOrder", "CanReadCustomer", "CanReadDetailImportOrder", "CanReadDetailSalesOrder", "CanReadEmployee", "CanReadImportOrder", "CanReadOptions", "CanReadProduct", "CanReadProvider", "CanReadSalesOrder", "CanReadStatistics", "CanReadUser", "CanReadUserRole", "CanUpdateCustomer", "CanUpdateEmployee", "CanUpdateProduct", "CanUpdateProvider", "CanUpdateUserRole", "IsAdmin" },
                values: new object[] { 2, false, false, true, true, false, false, true, false, false, false, true, true, false, false, true, false, true, false, false, true, false, false, true, false, true, true, false, false, false, false, false, false, true, true, false, false });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ProductID", "CalculationUnit", "DateCreated", "Description", "ImageData", "ImportUnitPrice", "Inventory", "ProductName", "UnitPrice" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2024, 3, 23, 16, 41, 6, 184, DateTimeKind.Local).AddTicks(2676), null, null, 42303.508097224280000m, 66, "Tivi", 132241.291606892800000m },
                    { 2, null, new DateTime(2024, 3, 23, 16, 41, 6, 184, DateTimeKind.Local).AddTicks(5382), null, null, 28506.08768774480000m, 131, "Máy giặt", 125620.927848374800000m },
                    { 3, null, new DateTime(2024, 3, 23, 16, 41, 6, 184, DateTimeKind.Local).AddTicks(5405), null, null, 15585.307901765960000m, 62, "Tủ lạnh", 150142.193069695800000m },
                    { 4, null, new DateTime(2024, 3, 23, 16, 41, 6, 184, DateTimeKind.Local).AddTicks(5413), null, null, 12684.8064956345920000m, 77, "Máy sấy tóc", 179912.554751261900000m },
                    { 5, null, new DateTime(2024, 3, 23, 16, 41, 6, 184, DateTimeKind.Local).AddTicks(5422), null, null, 23804.30923441560000m, 53, "Quạt điện", 166019.084048111500000m },
                    { 6, null, new DateTime(2024, 3, 23, 16, 41, 6, 184, DateTimeKind.Local).AddTicks(5430), null, null, 11296.3826401911120000m, 114, "Bình nóng lạnh", 199469.324196765500000m },
                    { 7, null, new DateTime(2024, 3, 23, 16, 41, 6, 184, DateTimeKind.Local).AddTicks(5438), null, null, 27302.443521340640000m, 118, "Máy lọc không khí", 115610.668338365200000m },
                    { 8, null, new DateTime(2024, 3, 23, 16, 41, 6, 184, DateTimeKind.Local).AddTicks(5446), null, null, 20285.572075097560000m, 89, "Bếp điện từ", 158860.3053659800000m },
                    { 9, null, new DateTime(2024, 3, 23, 16, 41, 6, 184, DateTimeKind.Local).AddTicks(5454), null, null, 48665.735361213360000m, 117, "Lò vi sóng", 147425.932511251700000m },
                    { 10, null, new DateTime(2024, 3, 23, 16, 41, 6, 184, DateTimeKind.Local).AddTicks(5462), null, null, 31752.838311112880000m, 123, "Lò nướng", 188538.277211412400000m },
                    { 11, null, new DateTime(2024, 3, 23, 16, 41, 6, 184, DateTimeKind.Local).AddTicks(5470), null, null, 38943.785612323000000m, 97, "Máy xay cà phê", 124686.753509806200000m },
                    { 12, null, new DateTime(2024, 3, 23, 16, 41, 6, 184, DateTimeKind.Local).AddTicks(5478), null, null, 42750.893066735480000m, 63, "Máy là", 180278.904198016200000m },
                    { 13, null, new DateTime(2024, 3, 23, 16, 41, 6, 184, DateTimeKind.Local).AddTicks(5485), null, null, 31824.753924724360000m, 139, "Máy hút bụi", 191099.024859295900000m },
                    { 14, null, new DateTime(2024, 3, 23, 16, 41, 6, 184, DateTimeKind.Local).AddTicks(5493), null, null, 25276.508527109760000m, 63, "Bàn ủi hơi nước", 185137.774391541300000m },
                    { 15, null, new DateTime(2024, 3, 23, 16, 41, 6, 184, DateTimeKind.Local).AddTicks(5501), null, null, 28018.129339980120000m, 115, "Bàn ủi điện", 147275.57829378500000m },
                    { 16, null, new DateTime(2024, 3, 23, 16, 41, 6, 184, DateTimeKind.Local).AddTicks(5509), null, null, 18552.032634340040000m, 36, "Máy sưởi dầu", 124820.330617497400000m },
                    { 17, null, new DateTime(2024, 3, 23, 16, 41, 6, 184, DateTimeKind.Local).AddTicks(5517), null, null, 21360.649041562600000m, 99, "Máy sưởi hơi", 158713.297436490900000m },
                    { 18, null, new DateTime(2024, 3, 23, 16, 41, 6, 184, DateTimeKind.Local).AddTicks(5524), null, null, 28189.362452908600000m, 111, "Máy lọc nước", 148286.047275262900000m },
                    { 19, null, new DateTime(2024, 3, 23, 16, 41, 6, 184, DateTimeKind.Local).AddTicks(5531), null, null, 18372.464710156640000m, 139, "Đèn sưởi", 143851.493234387100000m },
                    { 20, null, new DateTime(2024, 3, 23, 16, 41, 6, 184, DateTimeKind.Local).AddTicks(5540), null, null, 35718.469760871160000m, 94, "Máy làm bánh", 167882.90179925600000m },
                    { 21, null, new DateTime(2024, 3, 23, 16, 41, 6, 184, DateTimeKind.Local).AddTicks(5555), null, null, 47808.125608409760000m, 89, "Máy làm kem", 174495.898930734200000m },
                    { 22, null, new DateTime(2024, 3, 23, 16, 41, 6, 184, DateTimeKind.Local).AddTicks(5564), null, null, 44542.919863338040000m, 96, "Máy làm mỳ", 131173.929496302700000m },
                    { 23, null, new DateTime(2024, 3, 23, 16, 41, 6, 184, DateTimeKind.Local).AddTicks(5573), null, null, 39686.431843489000000m, 79, "Đèn trang trí", 192555.90196653500000m },
                    { 24, null, new DateTime(2024, 3, 23, 16, 41, 6, 184, DateTimeKind.Local).AddTicks(5581), null, null, 32542.519173625480000m, 107, "Máy chiếu phim", 109623.0514237024300000m },
                    { 25, null, new DateTime(2024, 3, 23, 16, 41, 6, 184, DateTimeKind.Local).AddTicks(5588), null, null, 39082.609434288720000m, 96, "Điều hòa không khí", 172999.875019364400000m },
                    { 26, null, new DateTime(2024, 3, 23, 16, 41, 6, 184, DateTimeKind.Local).AddTicks(5597), null, null, 29543.683841355280000m, 91, "Máy lạnh", 101837.4089297075500000m },
                    { 27, null, new DateTime(2024, 3, 23, 16, 41, 6, 184, DateTimeKind.Local).AddTicks(5606), null, null, 19170.921973614240000m, 84, "Quạt trần", 170029.154675533700000m },
                    { 28, null, new DateTime(2024, 3, 23, 16, 41, 6, 184, DateTimeKind.Local).AddTicks(5614), null, null, 29998.902836275840000m, 36, "Máy tính xách tay", 198654.447087908300000m },
                    { 29, null, new DateTime(2024, 3, 23, 16, 41, 6, 184, DateTimeKind.Local).AddTicks(5622), null, null, 27550.393883550960000m, 90, "Máy hút mùi", 144219.571439588700000m },
                    { 30, null, new DateTime(2024, 3, 23, 16, 41, 6, 184, DateTimeKind.Local).AddTicks(5631), null, null, 15033.696819087400000m, 140, "Bếp điện đa năng", 197740.783542299700000m },
                    { 31, null, new DateTime(2024, 3, 23, 16, 41, 6, 184, DateTimeKind.Local).AddTicks(5640), null, null, 30861.059226808160000m, 115, "Bàn phím điện tử", 134835.978950475200000m },
                    { 32, null, new DateTime(2024, 3, 23, 16, 41, 6, 184, DateTimeKind.Local).AddTicks(5648), null, null, 13670.693656817360000m, 114, "Chuột máy tính", 168301.621024446100000m },
                    { 33, null, new DateTime(2024, 3, 23, 16, 41, 6, 184, DateTimeKind.Local).AddTicks(5656), null, null, 29081.962589477880000m, 33, "Ổ điện thông minh", 150530.026395409600000m },
                    { 34, null, new DateTime(2024, 3, 23, 16, 41, 6, 184, DateTimeKind.Local).AddTicks(5664), null, null, 35593.581840765920000m, 31, "Thiết bị kết nối Wifi", 189872.009261875400000m },
                    { 35, null, new DateTime(2024, 3, 23, 16, 41, 6, 184, DateTimeKind.Local).AddTicks(5672), null, null, 30146.899699036040000m, 78, "Điện thoại di động", 186572.115828365900000m },
                    { 36, null, new DateTime(2024, 3, 23, 16, 41, 6, 184, DateTimeKind.Local).AddTicks(5680), null, null, 28810.91560257840000m, 45, "Máy tính bảng", 109078.1205499377800000m },
                    { 37, null, new DateTime(2024, 3, 23, 16, 41, 6, 184, DateTimeKind.Local).AddTicks(5689), null, null, 44612.995857262440000m, 71, "Máy in", 134211.797448801900000m },
                    { 38, null, new DateTime(2024, 3, 23, 16, 41, 6, 184, DateTimeKind.Local).AddTicks(5697), null, null, 41110.138520516200000m, 93, "Máy quét", 154483.606039970600000m },
                    { 39, null, new DateTime(2024, 3, 23, 16, 41, 6, 184, DateTimeKind.Local).AddTicks(5705), null, null, 45944.240390030720000m, 72, "Máy fax", 122615.329438975700000m },
                    { 40, null, new DateTime(2024, 3, 23, 16, 41, 6, 184, DateTimeKind.Local).AddTicks(5713), null, null, 15280.228264005080000m, 17, "Máy ảnh số", 123848.489269415900000m },
                    { 41, null, new DateTime(2024, 3, 23, 16, 41, 6, 184, DateTimeKind.Local).AddTicks(5721), null, null, 42736.084506578600000m, 74, "Máy quay phim", 146237.019754227400000m },
                    { 42, null, new DateTime(2024, 3, 23, 16, 41, 6, 184, DateTimeKind.Local).AddTicks(5729), null, null, 11224.9692710084120000m, 109, "Máy nghe nhạc MP3", 103169.5437202199900000m },
                    { 43, null, new DateTime(2024, 3, 23, 16, 41, 6, 184, DateTimeKind.Local).AddTicks(5737), null, null, 13967.5318787496480000m, 114, "Loa di động", 122722.078485566400000m },
                    { 44, null, new DateTime(2024, 3, 23, 16, 41, 6, 184, DateTimeKind.Local).AddTicks(5745), null, null, 43102.653250016720000m, 124, "Tai nghe không dây", 158963.940912524100000m },
                    { 45, null, new DateTime(2024, 3, 23, 16, 41, 6, 184, DateTimeKind.Local).AddTicks(5753), null, null, 39765.766498926760000m, 102, "Bộ sạc pin dự phòng", 109578.347014057900000m },
                    { 46, null, new DateTime(2024, 3, 23, 16, 41, 6, 184, DateTimeKind.Local).AddTicks(5761), null, null, 38040.153073147240000m, 142, "Robot hút bụi", 147269.329446573700000m },
                    { 47, null, new DateTime(2024, 3, 23, 16, 41, 6, 184, DateTimeKind.Local).AddTicks(5769), null, null, 14563.465449256480000m, 137, "Robot lau nhà", 161711.177942141400000m },
                    { 48, null, new DateTime(2024, 3, 23, 16, 41, 6, 184, DateTimeKind.Local).AddTicks(5777), null, null, 28130.536104639800000m, 90, "Bếp từ", 130231.295132508400000m },
                    { 49, null, new DateTime(2024, 3, 23, 16, 41, 6, 184, DateTimeKind.Local).AddTicks(5785), null, null, 39950.795521422960000m, 69, "Máy pha trà", 104657.6951304751900000m },
                    { 50, null, new DateTime(2024, 3, 23, 16, 41, 6, 184, DateTimeKind.Local).AddTicks(5798), null, null, 47511.415950023120000m, 93, "Máy sấy quần áo", 154221.433549164500000m },
                    { 51, null, new DateTime(2024, 3, 23, 16, 41, 6, 184, DateTimeKind.Local).AddTicks(5806), null, null, 18794.18336446120000m, 65, "Đèn chùm", 181782.875261194200000m },
                    { 52, null, new DateTime(2024, 3, 23, 16, 41, 6, 184, DateTimeKind.Local).AddTicks(5816), null, null, 30920.016559643560000m, 69, "Đèn LED", 170626.351048038600000m },
                    { 53, null, new DateTime(2024, 3, 23, 16, 41, 6, 184, DateTimeKind.Local).AddTicks(5823), null, null, 30714.933973647920000m, 58, "Bình siêu tốc", 150118.051828948400000m },
                    { 54, null, new DateTime(2024, 3, 23, 16, 41, 6, 184, DateTimeKind.Local).AddTicks(5836), null, null, 40268.252010040360000m, 105, "Đèn bàn", 108833.7571192149400000m },
                    { 55, null, new DateTime(2024, 3, 23, 16, 41, 6, 184, DateTimeKind.Local).AddTicks(5844), null, null, 47240.900747988520000m, 108, "Đèn ngủ", 121464.398511470900000m },
                    { 56, null, new DateTime(2024, 3, 23, 16, 41, 6, 184, DateTimeKind.Local).AddTicks(5853), null, null, 30977.349056497120000m, 28, "Máy rửa xe", 147921.958197856200000m },
                    { 57, null, new DateTime(2024, 3, 23, 16, 41, 6, 184, DateTimeKind.Local).AddTicks(5862), null, null, 40606.190754991680000m, 131, "Nồi cơm điện", 173248.261475337300000m },
                    { 58, null, new DateTime(2024, 3, 23, 16, 41, 6, 184, DateTimeKind.Local).AddTicks(5869), null, null, 33110.964290726640000m, 74, "Loa kéo", 122768.448668631500000m },
                    { 59, null, new DateTime(2024, 3, 23, 16, 41, 6, 184, DateTimeKind.Local).AddTicks(5877), null, null, 41869.820744379800000m, 78, "Vòi hoa sen", 144428.239932748200000m },
                    { 60, null, new DateTime(2024, 3, 23, 16, 41, 6, 184, DateTimeKind.Local).AddTicks(5885), null, null, 22695.983309053360000m, 58, "Đèn năng lượng mặt trời", 161003.907700527300000m },
                    { 61, null, new DateTime(2024, 3, 23, 16, 41, 6, 184, DateTimeKind.Local).AddTicks(5893), null, null, 13510.9934276242440000m, 51, "Quạt treo tường", 199266.651657995700000m },
                    { 62, null, new DateTime(2024, 3, 23, 16, 41, 6, 184, DateTimeKind.Local).AddTicks(5901), null, null, 16227.755900152080000m, 71, "Dây điện", 137082.97686798400000m },
                    { 63, null, new DateTime(2024, 3, 23, 16, 41, 6, 184, DateTimeKind.Local).AddTicks(5909), null, null, 36046.977283089480000m, 134, "Quạt đứng", 139509.564986500600000m },
                    { 64, null, new DateTime(2024, 3, 23, 16, 41, 6, 184, DateTimeKind.Local).AddTicks(5917), null, null, 18157.038884331040000m, 91, "Cầu dao tự động", 159630.145633712900000m },
                    { 65, null, new DateTime(2024, 3, 23, 16, 41, 6, 184, DateTimeKind.Local).AddTicks(5924), null, null, 43157.517923264880000m, 68, "Đèn sự cố chống cháy nổ", 187735.454067210400000m },
                    { 66, null, new DateTime(2024, 3, 23, 16, 41, 6, 184, DateTimeKind.Local).AddTicks(5932), null, null, 37848.578855221360000m, 97, "Phích cắm 3 chân", 139969.84904268800000m },
                    { 67, null, new DateTime(2024, 3, 23, 16, 41, 6, 184, DateTimeKind.Local).AddTicks(5941), null, null, 33300.693018767280000m, 124, "Công tắc Schneider", 115279.079548463700000m },
                    { 68, null, new DateTime(2024, 3, 23, 16, 41, 6, 184, DateTimeKind.Local).AddTicks(5949), null, null, 42033.943179997360000m, 93, "Thiết bị điện Peha", 153182.043208510800000m },
                    { 69, null, new DateTime(2024, 3, 23, 16, 41, 6, 184, DateTimeKind.Local).AddTicks(5957), null, null, 35786.128251549760000m, 21, "Ổ cắm Schuko", 184939.730011353900000m },
                    { 70, null, new DateTime(2024, 3, 23, 16, 41, 6, 184, DateTimeKind.Local).AddTicks(5965), null, null, 26198.339240486560000m, 49, "Đèn pin", 153502.170520624800000m },
                    { 71, null, new DateTime(2024, 3, 23, 16, 41, 6, 184, DateTimeKind.Local).AddTicks(5973), null, null, 43280.932587487320000m, 52, "Đèn tích điện", 196854.434315070800000m },
                    { 72, null, new DateTime(2024, 3, 23, 16, 41, 6, 184, DateTimeKind.Local).AddTicks(5981), null, null, 22002.32114695040000m, 114, "Nồi áp suất điện", 186008.436874108300000m },
                    { 73, null, new DateTime(2024, 3, 23, 16, 41, 6, 184, DateTimeKind.Local).AddTicks(5989), null, null, 33468.376595290760000m, 30, "Nồi nhôm Sunhouse", 159940.225627459300000m },
                    { 74, null, new DateTime(2024, 3, 23, 16, 41, 6, 184, DateTimeKind.Local).AddTicks(5998), null, null, 32414.397392546480000m, 65, "Vợt muỗi", 107407.5535388442900000m },
                    { 75, null, new DateTime(2024, 3, 23, 16, 41, 6, 184, DateTimeKind.Local).AddTicks(6006), null, null, 40839.584299049760000m, 104, "Chảo chống dính", 130604.184296018900000m },
                    { 76, null, new DateTime(2024, 3, 23, 16, 41, 6, 184, DateTimeKind.Local).AddTicks(6014), null, null, 15489.067666794520000m, 83, "Cửa ABS", 163825.26992157700000m },
                    { 77, null, new DateTime(2024, 3, 23, 16, 41, 6, 184, DateTimeKind.Local).AddTicks(6022), null, null, 25762.650811910280000m, 93, "Cửa căn hộ", 105175.0094337114400000m },
                    { 78, null, new DateTime(2024, 3, 23, 16, 41, 6, 184, DateTimeKind.Local).AddTicks(6029), null, null, 15915.704162417240000m, 73, "Cửa công nghiệp", 182928.232122626500000m },
                    { 79, null, new DateTime(2024, 3, 23, 16, 41, 6, 184, DateTimeKind.Local).AddTicks(6042), null, null, 19125.977066221040000m, 108, "Bình thủy điện", 162460.429861408500000m },
                    { 80, null, new DateTime(2024, 3, 23, 16, 41, 6, 184, DateTimeKind.Local).AddTicks(6050), null, null, 35447.163173625360000m, 10, "Bộ nội Ceramic", 138230.906844659300000m },
                    { 81, null, new DateTime(2024, 3, 23, 16, 41, 6, 184, DateTimeKind.Local).AddTicks(6058), null, null, 40754.446539440360000m, 121, "Máy phát điện", 129820.15314226100000m },
                    { 82, null, new DateTime(2024, 3, 23, 16, 41, 6, 184, DateTimeKind.Local).AddTicks(6066), null, null, 20606.099663694840000m, 88, "Bình sạc", 115557.230466998800000m },
                    { 83, null, new DateTime(2024, 3, 23, 16, 41, 6, 184, DateTimeKind.Local).AddTicks(6073), null, null, 15536.504007771840000m, 85, "Máy xay sinh tố", 192827.434270560800000m },
                    { 84, null, new DateTime(2024, 3, 23, 16, 41, 6, 184, DateTimeKind.Local).AddTicks(6080), null, null, 16726.331620277240000m, 28, "Máy xay thịt", 102831.6031976655100000m },
                    { 85, null, new DateTime(2024, 3, 23, 16, 41, 6, 184, DateTimeKind.Local).AddTicks(6087), null, null, 39854.951103270520000m, 62, "Máy rửa chén", 127227.14294376300000m },
                    { 86, null, new DateTime(2024, 3, 23, 16, 41, 6, 184, DateTimeKind.Local).AddTicks(6095), null, null, 47827.904909382840000m, 95, "Máy massage", 182123.518869835600000m },
                    { 87, null, new DateTime(2024, 3, 23, 16, 41, 6, 184, DateTimeKind.Local).AddTicks(6103), null, null, 35104.34235122720000m, 59, "Máy rửa kính", 147504.783720697900000m },
                    { 88, null, new DateTime(2024, 3, 23, 16, 41, 6, 184, DateTimeKind.Local).AddTicks(6110), null, null, 17850.143389083680000m, 120, "Máy tạo độ ẩm", 164326.198547623600000m },
                    { 89, null, new DateTime(2024, 3, 23, 16, 41, 6, 184, DateTimeKind.Local).AddTicks(6118), null, null, 17323.149339340560000m, 53, "Máy khử mùi", 190557.562786955100000m },
                    { 90, null, new DateTime(2024, 3, 23, 16, 41, 6, 184, DateTimeKind.Local).AddTicks(6125), null, null, 32085.246740067000000m, 89, "Máy đánh trứng", 106422.3766075848100000m },
                    { 91, null, new DateTime(2024, 3, 23, 16, 41, 6, 184, DateTimeKind.Local).AddTicks(6133), null, null, 43059.357597739800000m, 60, "Máy phun sương", 194403.349583472500000m },
                    { 92, null, new DateTime(2024, 3, 23, 16, 41, 6, 184, DateTimeKind.Local).AddTicks(6140), null, null, 36579.499787619640000m, 50, "Máy xay đá", 105370.9294471350900000m },
                    { 93, null, new DateTime(2024, 3, 23, 16, 41, 6, 184, DateTimeKind.Local).AddTicks(6147), null, null, 17041.48206354320000m, 102, "Máy xay hạt cả phê", 115113.242272370800000m },
                    { 94, null, new DateTime(2024, 3, 23, 16, 41, 6, 184, DateTimeKind.Local).AddTicks(6155), null, null, 29912.637012999840000m, 106, "Máy nén khí", 146462.484141249700000m },
                    { 95, null, new DateTime(2024, 3, 23, 16, 41, 6, 184, DateTimeKind.Local).AddTicks(6163), null, null, 29695.105700114240000m, 52, "Máy làm mứt", 129324.950864853200000m },
                    { 96, null, new DateTime(2024, 3, 23, 16, 41, 6, 184, DateTimeKind.Local).AddTicks(6170), null, null, 42666.524082324880000m, 141, "Máy ép nước mía", 194451.732421982600000m },
                    { 97, null, new DateTime(2024, 3, 23, 16, 41, 6, 184, DateTimeKind.Local).AddTicks(6178), null, null, 39304.901193565960000m, 72, "Máy hút chân không", 194560.586957744900000m },
                    { 98, null, new DateTime(2024, 3, 23, 16, 41, 6, 184, DateTimeKind.Local).AddTicks(6185), null, null, 42895.128263524840000m, 99, "Máy pha trà", 118564.779578957600000m },
                    { 99, null, new DateTime(2024, 3, 23, 16, 41, 6, 184, DateTimeKind.Local).AddTicks(6194), null, null, 49613.31601647120000m, 58, "Máy đánh sữa", 139125.403613556400000m },
                    { 100, null, new DateTime(2024, 3, 23, 16, 41, 6, 184, DateTimeKind.Local).AddTicks(6202), null, null, 44940.726852377360000m, 110, "Máy cắt cỏ", 177936.7913005300000m }
                });

            migrationBuilder.InsertData(
                table: "Provider",
                columns: new[] { "ProviderID", "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[,]
                {
                    { 1, "Kiên Giang", new DateTime(2024, 3, 23, 16, 41, 6, 174, DateTimeKind.Local).AddTicks(7531), "KhanhHa.Truong@hotmail.com", "0984831895", "Xuân Liễu Lê" },
                    { 2, "Lai Châu", new DateTime(2024, 3, 23, 16, 41, 6, 174, DateTimeKind.Local).AddTicks(9212), "DucBao50@gmail.com", "0970665509", "Thanh Ngọc Trần" },
                    { 3, "Sóc Trăng", new DateTime(2024, 3, 23, 16, 41, 6, 174, DateTimeKind.Local).AddTicks(9317), "TaiDuc47@yahoo.com", "0904270223", "Xuân Dung Đỗ" },
                    { 4, "Hưng Yên", new DateTime(2024, 3, 23, 16, 41, 6, 174, DateTimeKind.Local).AddTicks(9391), "DieuHuong.Pham35@gmail.com", "0988730620", "Kim Thịnh Hồ" },
                    { 5, "Hòa Bình", new DateTime(2024, 3, 23, 16, 41, 6, 174, DateTimeKind.Local).AddTicks(9479), "QuynhHuong77@gmail.com", "0938226724", "Ngân Trúc Hoàng" },
                    { 6, "Thừa Thiên-Huế", new DateTime(2024, 3, 23, 16, 41, 6, 174, DateTimeKind.Local).AddTicks(9557), "HaiQuan34@yahoo.com", "0986530001", "Công Giang Đào" },
                    { 7, "Thanh Hoá", new DateTime(2024, 3, 23, 16, 41, 6, 174, DateTimeKind.Local).AddTicks(9622), "AnhTung_Dao@yahoo.com", "0945693962", "Trà Giang Lâm" },
                    { 8, "Yên Bái", new DateTime(2024, 3, 23, 16, 41, 6, 174, DateTimeKind.Local).AddTicks(9694), "HaiDuyen.Mai@yahoo.com", "0939746884", "Lan Ngọc Vương" },
                    { 9, "Kon Tum", new DateTime(2024, 3, 23, 16, 41, 6, 174, DateTimeKind.Local).AddTicks(9758), "TuongChinh.Vu@gmail.com", "0949540232", "Ðức Huy Dương" },
                    { 10, "Vĩnh Phúc", new DateTime(2024, 3, 23, 16, 41, 6, 174, DateTimeKind.Local).AddTicks(9827), "VietNga40@yahoo.com", "0985267675", "Sao Băng Trương" },
                    { 11, "Hà Nam", new DateTime(2024, 3, 23, 16, 41, 6, 174, DateTimeKind.Local).AddTicks(9890), "NhuKhang_Truong@gmail.com", "0957817449", "Thùy Oanh Hoàng" },
                    { 12, "Hà Giang", new DateTime(2024, 3, 23, 16, 41, 6, 174, DateTimeKind.Local).AddTicks(9963), "NguyetHong_Hoang@hotmail.com", "0958097069", "Quang Huy Tô" },
                    { 13, "Sơn La", new DateTime(2024, 3, 23, 16, 41, 6, 175, DateTimeKind.Local).AddTicks(34), "NhatHuy_Ly80@hotmail.com", "0979203704", "Kiều Trinh Dương" },
                    { 14, "Nam Định", new DateTime(2024, 3, 23, 16, 41, 6, 175, DateTimeKind.Local).AddTicks(110), "NgocThuan.Truong22@hotmail.com", "0962652172", "Hiền Mai Phạm" },
                    { 15, "Trà Vinh", new DateTime(2024, 3, 23, 16, 41, 6, 175, DateTimeKind.Local).AddTicks(185), "NhatMai80@yahoo.com", "0915135658", "Quang Vũ Dương" },
                    { 16, "Đắk Nông", new DateTime(2024, 3, 23, 16, 41, 6, 175, DateTimeKind.Local).AddTicks(253), "MinhKhang.Ha@gmail.com", "0966385755", "Nghi Minh Mai" },
                    { 17, "Hà Giang", new DateTime(2024, 3, 23, 16, 41, 6, 175, DateTimeKind.Local).AddTicks(323), "MinhGiang.Le@yahoo.com", "0985027419", "Cao Minh Ngô" },
                    { 18, "Cao Bằng", new DateTime(2024, 3, 23, 16, 41, 6, 175, DateTimeKind.Local).AddTicks(385), "HoaiBac.Duong@yahoo.com", "0979365414", "Huy Khiêm Mai" },
                    { 19, "Tiền Giang", new DateTime(2024, 3, 23, 16, 41, 6, 175, DateTimeKind.Local).AddTicks(453), "LucBinh.Do91@hotmail.com", "0949803662", "Bạch Quỳnh Phan" },
                    { 20, "Bình Định", new DateTime(2024, 3, 23, 16, 41, 6, 175, DateTimeKind.Local).AddTicks(517), "HaoNhi_Trinh92@gmail.com", "0996801747", "Lâm Ðồng Vương" },
                    { 21, "Quảng Trị", new DateTime(2024, 3, 23, 16, 41, 6, 175, DateTimeKind.Local).AddTicks(585), "ThongMinh0@hotmail.com", "0973979051", "Hiệp Hòa Đinh" },
                    { 22, "Khánh Hoà", new DateTime(2024, 3, 23, 16, 41, 6, 175, DateTimeKind.Local).AddTicks(653), "AnhHoang.Vuong14@gmail.com", "0995195506", "Thái Sơn Ngô" },
                    { 23, "Trà Vinh", new DateTime(2024, 3, 23, 16, 41, 6, 175, DateTimeKind.Local).AddTicks(728), "NhuNgoc51@gmail.com", "0910799636", "Như Trân Phạm" },
                    { 24, "Trà Vinh", new DateTime(2024, 3, 23, 16, 41, 6, 175, DateTimeKind.Local).AddTicks(795), "HuuLuong_Ho7@gmail.com", "0905642553", "Hồ Nam Đặng" },
                    { 25, "Hải Phòng", new DateTime(2024, 3, 23, 16, 41, 6, 175, DateTimeKind.Local).AddTicks(862), "HiepHao.Ha@hotmail.com", "0910839817", "Như Thảo Phùng" },
                    { 26, "Hải Dương", new DateTime(2024, 3, 23, 16, 41, 6, 175, DateTimeKind.Local).AddTicks(924), "BaoHuynh22@hotmail.com", "0923204332", "Bích Nhã Tô" },
                    { 27, "Nam Định", new DateTime(2024, 3, 23, 16, 41, 6, 175, DateTimeKind.Local).AddTicks(993), "ThaiMinh_Mai92@gmail.com", "0942283579", "Nguyễn Hải An Trương" },
                    { 28, "Lai Châu", new DateTime(2024, 3, 23, 16, 41, 6, 175, DateTimeKind.Local).AddTicks(1056), "LinhHa.Doan@gmail.com", "0918355908", "Thái Minh Vũ" },
                    { 29, "Hà Nam", new DateTime(2024, 3, 23, 16, 41, 6, 175, DateTimeKind.Local).AddTicks(1122), "VietTien_Trinh@hotmail.com", "0944248777", "Hồng Nhuận Mai" },
                    { 30, "Tiền Giang", new DateTime(2024, 3, 23, 16, 41, 6, 175, DateTimeKind.Local).AddTicks(1194), "ThuLinh_Do5@hotmail.com", "0953596085", "Lâm Ðồng Vương" },
                    { 31, "Đà Nẵng", new DateTime(2024, 3, 23, 16, 41, 6, 175, DateTimeKind.Local).AddTicks(1256), "BaoVan6@yahoo.com", "0930461586", "Tiểu Quỳnh Hồ" },
                    { 32, "TP. Hồ Chí Minh", new DateTime(2024, 3, 23, 16, 41, 6, 175, DateTimeKind.Local).AddTicks(1322), "HuongBinh.Nguyen75@yahoo.com", "0943713456", "Duyên Nương Đặng" },
                    { 33, "Thái Bình", new DateTime(2024, 3, 23, 16, 41, 6, 175, DateTimeKind.Local).AddTicks(1392), "YenNhi91@yahoo.com", "0923603923", "Huy Lĩnh Hồ" },
                    { 34, "Hải Dương", new DateTime(2024, 3, 23, 16, 41, 6, 175, DateTimeKind.Local).AddTicks(1458), "NhanSam_Ho13@yahoo.com", "0900461985", "Thanh Hương Đặng" },
                    { 35, "Đắk Nông", new DateTime(2024, 3, 23, 16, 41, 6, 175, DateTimeKind.Local).AddTicks(1522), "ThanhThao.Dinh@gmail.com", "0965772473", "Thượng Nghị Đoàn" },
                    { 36, "Hưng Yên", new DateTime(2024, 3, 23, 16, 41, 6, 175, DateTimeKind.Local).AddTicks(1594), "YenMai.To@gmail.com", "0940211894", "Cao Nguyên Hoàng" },
                    { 37, "Lai Châu", new DateTime(2024, 3, 23, 16, 41, 6, 175, DateTimeKind.Local).AddTicks(1652), "ThiNgon52@yahoo.com", "0977543402", "Thiều Ly Đào" },
                    { 38, "Hòa Bình", new DateTime(2024, 3, 23, 16, 41, 6, 175, DateTimeKind.Local).AddTicks(1721), "ThanhKien78@yahoo.com", "0970588909", "Thu Vân Hà" },
                    { 39, "Quảng Ngãi", new DateTime(2024, 3, 23, 16, 41, 6, 175, DateTimeKind.Local).AddTicks(1783), "QuocTru68@yahoo.com", "0963809635", "Việt Hùng Đoàn" },
                    { 40, "Quảng Trị", new DateTime(2024, 3, 23, 16, 41, 6, 175, DateTimeKind.Local).AddTicks(1851), "TuanDung41@gmail.com", "0939231003", "Hồng Xuân Trần" },
                    { 41, "Bắc Giang", new DateTime(2024, 3, 23, 16, 41, 6, 175, DateTimeKind.Local).AddTicks(1919), "QuangHuu_Ngo99@yahoo.com", "0901286203", "Ðắc Thành Đoàn" },
                    { 42, "Điện Biên", new DateTime(2024, 3, 23, 16, 41, 6, 175, DateTimeKind.Local).AddTicks(1981), "MaiLinh.Phan@hotmail.com", "0942457582", "Thúy Hà Bùi" },
                    { 43, "TP. Hồ Chí Minh", new DateTime(2024, 3, 23, 16, 41, 6, 175, DateTimeKind.Local).AddTicks(2056), "NhatMai_Vuong33@hotmail.com", "0978585948", "Quốc Thông Nguyễn" },
                    { 44, "Hà Tĩnh", new DateTime(2024, 3, 23, 16, 41, 6, 175, DateTimeKind.Local).AddTicks(2121), "MongThu_Lam@yahoo.com", "0950028387", "Tâm Nhi Vũ" },
                    { 45, "Hà Nam", new DateTime(2024, 3, 23, 16, 41, 6, 175, DateTimeKind.Local).AddTicks(2187), "MinhHieu_Dang54@yahoo.com", "0959993570", "Thu Nga Vương" },
                    { 46, "Lạng Sơn", new DateTime(2024, 3, 23, 16, 41, 6, 175, DateTimeKind.Local).AddTicks(2252), "QuocTruong79@yahoo.com", "0996286923", "Quỳnh Trang Vương" },
                    { 47, "TP. Hồ Chí Minh", new DateTime(2024, 3, 23, 16, 41, 6, 175, DateTimeKind.Local).AddTicks(2319), "DanhNhan.Nguyen@hotmail.com", "0971839686", "Mỹ Xuân Đặng" },
                    { 48, "Bắc Giang", new DateTime(2024, 3, 23, 16, 41, 6, 175, DateTimeKind.Local).AddTicks(2382), "BichThu33@hotmail.com", "0971999594", "Xuân Trung Hoàng" },
                    { 49, "Bà Rịa-Vũng Tàu", new DateTime(2024, 3, 23, 16, 41, 6, 175, DateTimeKind.Local).AddTicks(2453), "HuongThao66@gmail.com", "0909267447", "Thiên Khánh Hồ" },
                    { 50, "Bạc Liêu", new DateTime(2024, 3, 23, 16, 41, 6, 175, DateTimeKind.Local).AddTicks(2524), "ThanhThe80@gmail.com", "0960812246", "Vương Việt Trương" },
                    { 51, "Bình Thuận", new DateTime(2024, 3, 23, 16, 41, 6, 175, DateTimeKind.Local).AddTicks(2587), "ThePhuong_Dinh@gmail.com", "0981525123", "Mai Khanh Trương" },
                    { 52, "Khánh Hoà", new DateTime(2024, 3, 23, 16, 41, 6, 175, DateTimeKind.Local).AddTicks(2658), "QuangVu19@hotmail.com", "0904994163", "Giáng Uyên Lê" },
                    { 53, "Quảng Bình", new DateTime(2024, 3, 23, 16, 41, 6, 175, DateTimeKind.Local).AddTicks(2719), "BichHao.Duong98@yahoo.com", "0978824690", "Vy Lam Lê" },
                    { 54, "Bắc Ninh", new DateTime(2024, 3, 23, 16, 41, 6, 175, DateTimeKind.Local).AddTicks(2787), "ThuHuyen.Lam@gmail.com", "0952752355", "Minh Quang Trương" },
                    { 55, "Bắc Giang", new DateTime(2024, 3, 23, 16, 41, 6, 175, DateTimeKind.Local).AddTicks(2856), "GiaNhi.Duong76@hotmail.com", "0984995945", "Tường Lân Lê" },
                    { 56, "Hà Nội", new DateTime(2024, 3, 23, 16, 41, 6, 175, DateTimeKind.Local).AddTicks(2928), "ThienLan6@hotmail.com", "0973655170", "Uyên Nhi Bùi" },
                    { 57, "Vĩnh Phúc", new DateTime(2024, 3, 23, 16, 41, 6, 175, DateTimeKind.Local).AddTicks(2988), "PhuongBich67@yahoo.com", "0960446772", "Hồng Thảo Tăng" },
                    { 58, "Lạng Sơn", new DateTime(2024, 3, 23, 16, 41, 6, 175, DateTimeKind.Local).AddTicks(3060), "TueMan.Dang36@hotmail.com", "0942085593", "Mỹ Trang Hoàng" },
                    { 59, "Bắc Kạn", new DateTime(2024, 3, 23, 16, 41, 6, 175, DateTimeKind.Local).AddTicks(3122), "SaoBang_Vuong22@gmail.com", "0930426556", "Khánh My Tô" },
                    { 60, "Hà Nam", new DateTime(2024, 3, 23, 16, 41, 6, 175, DateTimeKind.Local).AddTicks(3189), "QueAnh.Ngo@yahoo.com", "0956609497", "Ðắc Thái Lê" },
                    { 61, "Bắc Giang", new DateTime(2024, 3, 23, 16, 41, 6, 175, DateTimeKind.Local).AddTicks(3259), "NhatHung.Mai@gmail.com", "0967210204", "Liên Phương Phan" },
                    { 62, "Cà Mau", new DateTime(2024, 3, 23, 16, 41, 6, 175, DateTimeKind.Local).AddTicks(3322), "QuynhSa_Dinh89@gmail.com", "0951254603", "Thế Quyền Hồ" },
                    { 63, "Nam Định", new DateTime(2024, 3, 23, 16, 41, 6, 175, DateTimeKind.Local).AddTicks(3387), "LeNga29@gmail.com", "0961876398", "Linh Nhi Mai" },
                    { 64, "Bến Tre", new DateTime(2024, 3, 23, 16, 41, 6, 175, DateTimeKind.Local).AddTicks(3445), "HungCuong.Mai@hotmail.com", "0978455978", "Trường Vinh Ngô" },
                    { 65, "Bình Dương", new DateTime(2024, 3, 23, 16, 41, 6, 175, DateTimeKind.Local).AddTicks(3512), "KieuGiang_Phung86@gmail.com", "0975860302", "Túy Loan Vương" },
                    { 66, "Tây Ninh", new DateTime(2024, 3, 23, 16, 41, 6, 175, DateTimeKind.Local).AddTicks(3582), "ThanhThuy_Pham15@yahoo.com", "0908433682", "Phương Thùy Ngô" },
                    { 67, "Quảng Bình", new DateTime(2024, 3, 23, 16, 41, 6, 175, DateTimeKind.Local).AddTicks(3651), "ThanhTung3@hotmail.com", "0996347763", "Tường Vinh Vũ" },
                    { 68, "Cà Mau", new DateTime(2024, 3, 23, 16, 41, 6, 175, DateTimeKind.Local).AddTicks(3713), "DucAn_Bui20@gmail.com", "0957629558", "Ðình Chiểu Đoàn" },
                    { 69, "Hà Tĩnh", new DateTime(2024, 3, 23, 16, 41, 6, 175, DateTimeKind.Local).AddTicks(3785), "KimKhanh26@hotmail.com", "0935884239", "Hữu Ðịnh Trương" },
                    { 70, "Đồng Nai", new DateTime(2024, 3, 23, 16, 41, 6, 175, DateTimeKind.Local).AddTicks(3855), "BaoHuynh_Duong@gmail.com", "0911914498", "Kim Phượng Ngô" },
                    { 71, "Hậu Giang", new DateTime(2024, 3, 23, 16, 41, 6, 175, DateTimeKind.Local).AddTicks(3917), "TuyLoan83@yahoo.com", "0948366518", "Huệ An Vũ" },
                    { 72, "Khánh Hoà", new DateTime(2024, 3, 23, 16, 41, 6, 175, DateTimeKind.Local).AddTicks(3986), "ThanhThuy.Ngo1@gmail.com", "0994851013", "Cát Ly Phùng" },
                    { 73, "Kon Tum", new DateTime(2024, 3, 23, 16, 41, 6, 175, DateTimeKind.Local).AddTicks(4051), "HoangThu_Lam7@yahoo.com", "0903281715", "Tố Nhi Đinh" },
                    { 74, "Hà Tĩnh", new DateTime(2024, 3, 23, 16, 41, 6, 175, DateTimeKind.Local).AddTicks(4120), "DinhNam.Ngo98@gmail.com", "0900780427", "Hồng Minh Trần" },
                    { 75, "Sóc Trăng", new DateTime(2024, 3, 23, 16, 41, 6, 175, DateTimeKind.Local).AddTicks(4182), "ThanhTam.Dang@yahoo.com", "0961783129", "Thu Giang Hồ" },
                    { 76, "Bắc Kạn", new DateTime(2024, 3, 23, 16, 41, 6, 175, DateTimeKind.Local).AddTicks(4248), "TheVinh.Lam@yahoo.com", "0978901368", "Mộng Vy Lâm" },
                    { 77, "Cà Mau", new DateTime(2024, 3, 23, 16, 41, 6, 175, DateTimeKind.Local).AddTicks(4321), "TuyetXuan.Bui@hotmail.com", "0964659135", "Phú Bình Lý" },
                    { 78, "Ninh Bình", new DateTime(2024, 3, 23, 16, 41, 6, 175, DateTimeKind.Local).AddTicks(4395), "HaiLong_Vuong8@yahoo.com", "0973473010", "Mộng Lan Hà" },
                    { 79, "Kiên Giang", new DateTime(2024, 3, 23, 16, 41, 6, 175, DateTimeKind.Local).AddTicks(4458), "HanhThao81@hotmail.com", "0999893814", "Thiện Phước Tăng" },
                    { 80, "Ninh Bình", new DateTime(2024, 3, 23, 16, 41, 6, 175, DateTimeKind.Local).AddTicks(4523), "BaTung_Duong32@gmail.com", "0975555809", "Mộng Vân Trần" },
                    { 81, "An Giang", new DateTime(2024, 3, 23, 16, 41, 6, 175, DateTimeKind.Local).AddTicks(4589), "TrongTan77@gmail.com", "0979454175", "Trung Hải Phùng" },
                    { 82, "Bình Thuận", new DateTime(2024, 3, 23, 16, 41, 6, 175, DateTimeKind.Local).AddTicks(4654), "CongAn53@hotmail.com", "0981872581", "Vạn Thắng Lý" },
                    { 83, "Quảng Ninh", new DateTime(2024, 3, 23, 16, 41, 6, 175, DateTimeKind.Local).AddTicks(4719), "DinhChuong31@hotmail.com", "0948645968", "Giang Thiên Đặng" },
                    { 84, "Nam Định", new DateTime(2024, 3, 23, 16, 41, 6, 175, DateTimeKind.Local).AddTicks(4781), "KimThao0@gmail.com", "0972749914", "Nhật Quang Dương" },
                    { 85, "Sơn La", new DateTime(2024, 3, 23, 16, 41, 6, 175, DateTimeKind.Local).AddTicks(4846), "HoaiTin48@gmail.com", "0913677676", "Ngọc Bích Hoàng" },
                    { 86, "Lâm Đồng", new DateTime(2024, 3, 23, 16, 41, 6, 175, DateTimeKind.Local).AddTicks(4906), "ThuyTam0@gmail.com", "0910583931", "Ðông Phong Ngô" },
                    { 87, "Hậu Giang", new DateTime(2024, 3, 23, 16, 41, 6, 175, DateTimeKind.Local).AddTicks(4976), "QuangDanh.Phan23@gmail.com", "0905103524", "Hương Thu Bùi" },
                    { 88, "Tây Ninh", new DateTime(2024, 3, 23, 16, 41, 6, 175, DateTimeKind.Local).AddTicks(5041), "TrucCuong_Phan@gmail.com", "0980539433", "Dạ Nguyệt Đặng" },
                    { 89, "Phú Thọ", new DateTime(2024, 3, 23, 16, 41, 6, 175, DateTimeKind.Local).AddTicks(5122), "TheTuong_Bui39@gmail.com", "0935958408", "Mộc Miên Đặng" },
                    { 90, "Hà Nội", new DateTime(2024, 3, 23, 16, 41, 6, 175, DateTimeKind.Local).AddTicks(5183), "NhuHao_Phan@gmail.com", "0928058063", "Nhật Dũng Mai" },
                    { 91, "Thái Nguyên", new DateTime(2024, 3, 23, 16, 41, 6, 175, DateTimeKind.Local).AddTicks(5250), "PhiNhung11@hotmail.com", "0930513283", "Tiến Ðức Đào" },
                    { 92, "Bình Phước", new DateTime(2024, 3, 23, 16, 41, 6, 175, DateTimeKind.Local).AddTicks(5319), "KhaiHoa_Ha@yahoo.com", "0951700249", "Xuân Bảo Phùng" },
                    { 93, "Quảng Nam", new DateTime(2024, 3, 23, 16, 41, 6, 175, DateTimeKind.Local).AddTicks(5377), "KhanhMinh_Tang59@gmail.com", "0955090857", "Tuấn Châu Hoàng" },
                    { 94, "Bình Thuận", new DateTime(2024, 3, 23, 16, 41, 6, 175, DateTimeKind.Local).AddTicks(5447), "NhatMai.Dao54@gmail.com", "0925412216", "Khánh Chi Hà" },
                    { 95, "Sơn La", new DateTime(2024, 3, 23, 16, 41, 6, 175, DateTimeKind.Local).AddTicks(5506), "HongTam.Vuong31@gmail.com", "0943806707", "Thanh Quang Mai" },
                    { 96, "Sóc Trăng", new DateTime(2024, 3, 23, 16, 41, 6, 175, DateTimeKind.Local).AddTicks(5574), "QuynhNgan.Tran@hotmail.com", "0944354928", "Mỹ Huyền Đặng" },
                    { 97, "Bình Dương", new DateTime(2024, 3, 23, 16, 41, 6, 175, DateTimeKind.Local).AddTicks(5637), "MyYen62@yahoo.com", "0926151671", "Bích Hạnh Hồ" },
                    { 98, "Thái Bình", new DateTime(2024, 3, 23, 16, 41, 6, 175, DateTimeKind.Local).AddTicks(5705), "PhiNhan_Truong@gmail.com", "0946154581", "Bữu Toại Hà" },
                    { 99, "Đồng Tháp", new DateTime(2024, 3, 23, 16, 41, 6, 175, DateTimeKind.Local).AddTicks(5766), "DiemPhuoc_Vuong@yahoo.com", "0910148646", "Phúc Khang Lâm" },
                    { 100, "Nam Định", new DateTime(2024, 3, 23, 16, 41, 6, 175, DateTimeKind.Local).AddTicks(5835), "PhucSinh.Trinh59@yahoo.com", "0904683268", "Thúy Loan Trương" }
                });

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "RoleID",
                keyValue: 1,
                columns: new[] { "DateCreated", "RoleName" },
                values: new object[] { new DateTime(2024, 3, 23, 16, 41, 6, 171, DateTimeKind.Local).AddTicks(1267), "Nhân viên bán hàng" });

            migrationBuilder.InsertData(
                table: "ImportOrder",
                columns: new[] { "OrderID", "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[,]
                {
                    { 1, 21, new DateTime(2024, 5, 25, 7, 20, 20, 688, DateTimeKind.Unspecified).AddTicks(6573), 71, 6176312.182194744880000m },
                    { 2, 78, new DateTime(2024, 5, 6, 0, 23, 28, 914, DateTimeKind.Unspecified).AddTicks(2549), 2, 5159601.87148180880000m },
                    { 3, 76, new DateTime(2024, 5, 17, 20, 50, 19, 519, DateTimeKind.Unspecified).AddTicks(361), 50, 1963748.795622510960000m },
                    { 4, 16, new DateTime(2024, 5, 28, 1, 56, 9, 558, DateTimeKind.Unspecified).AddTicks(4139), 50, 2054938.6522928039040000m },
                    { 5, 92, new DateTime(2024, 5, 6, 15, 53, 38, 352, DateTimeKind.Unspecified).AddTicks(8677), 39, 3118364.50970844360000m },
                    { 6, 86, new DateTime(2024, 5, 5, 10, 56, 41, 942, DateTimeKind.Unspecified).AddTicks(2992), 82, 2236683.7627578401760000m },
                    { 7, 22, new DateTime(2024, 5, 18, 7, 20, 47, 705, DateTimeKind.Unspecified).AddTicks(2018), 95, 5078254.494969359040000m },
                    { 8, 9, new DateTime(2024, 5, 25, 21, 36, 27, 787, DateTimeKind.Unspecified).AddTicks(7267), 5, 2900836.806738951080000m },
                    { 9, 12, new DateTime(2024, 5, 23, 11, 3, 27, 309, DateTimeKind.Unspecified).AddTicks(3528), 90, 8516503.688212338000000m },
                    { 10, 66, new DateTime(2024, 5, 6, 22, 36, 9, 648, DateTimeKind.Unspecified).AddTicks(4425), 20, 6128297.794044785840000m },
                    { 11, 16, new DateTime(2024, 5, 17, 1, 44, 40, 93, DateTimeKind.Unspecified).AddTicks(1060), 13, 7282487.909504401000000m },
                    { 12, 81, new DateTime(2024, 5, 17, 16, 37, 57, 342, DateTimeKind.Unspecified).AddTicks(7511), 26, 5856872.350142760760000m },
                    { 13, 58, new DateTime(2024, 5, 8, 15, 37, 12, 307, DateTimeKind.Unspecified).AddTicks(4808), 51, 6174002.261396525840000m },
                    { 14, 57, new DateTime(2024, 5, 26, 20, 54, 23, 37, DateTimeKind.Unspecified).AddTicks(3671), 23, 3159563.565888720000000m },
                    { 15, 74, new DateTime(2024, 5, 16, 4, 35, 11, 430, DateTimeKind.Unspecified).AddTicks(7552), 70, 4931190.763836501120000m },
                    { 16, 8, new DateTime(2024, 5, 29, 16, 11, 7, 607, DateTimeKind.Unspecified).AddTicks(339), 69, 2263347.981389484880000m },
                    { 17, 7, new DateTime(2024, 5, 28, 14, 50, 53, 616, DateTimeKind.Unspecified).AddTicks(7544), 64, 3738113.582273455000000m },
                    { 18, 47, new DateTime(2024, 5, 4, 3, 49, 16, 464, DateTimeKind.Unspecified).AddTicks(2151), 17, 4848570.341900279200000m },
                    { 19, 13, new DateTime(2024, 5, 9, 18, 27, 53, 515, DateTimeKind.Unspecified).AddTicks(374), 4, 3637748.012611014720000m },
                    { 20, 39, new DateTime(2024, 5, 18, 12, 51, 32, 155, DateTimeKind.Unspecified).AddTicks(8794), 89, 5143459.645565447040000m },
                    { 21, 34, new DateTime(2024, 5, 27, 23, 40, 9, 102, DateTimeKind.Unspecified).AddTicks(1982), 42, 7075602.590044644480000m },
                    { 22, 12, new DateTime(2024, 5, 18, 18, 15, 19, 898, DateTimeKind.Unspecified).AddTicks(9805), 47, 6904152.578817396200000m },
                    { 23, 93, new DateTime(2024, 5, 6, 20, 37, 59, 109, DateTimeKind.Unspecified).AddTicks(9325), 39, 6627634.117862663000000m },
                    { 24, 88, new DateTime(2024, 5, 8, 0, 49, 2, 432, DateTimeKind.Unspecified).AddTicks(3700), 58, 6410876.277204219560000m },
                    { 25, 82, new DateTime(2024, 5, 8, 3, 8, 56, 617, DateTimeKind.Unspecified).AddTicks(2631), 19, 6096887.071749040320000m },
                    { 26, 47, new DateTime(2024, 5, 1, 10, 54, 19, 229, DateTimeKind.Unspecified).AddTicks(7153), 82, 4402008.892361936720000m },
                    { 27, 12, new DateTime(2024, 5, 15, 12, 13, 3, 793, DateTimeKind.Unspecified).AddTicks(3651), 74, 2588074.466437922400000m },
                    { 28, 77, new DateTime(2024, 5, 13, 3, 5, 38, 861, DateTimeKind.Unspecified).AddTicks(6963), 77, 3059888.089300135680000m },
                    { 29, 95, new DateTime(2024, 5, 10, 2, 43, 51, 112, DateTimeKind.Unspecified).AddTicks(4499), 46, 4876419.717388519920000m },
                    { 30, 21, new DateTime(2024, 5, 17, 14, 28, 21, 86, DateTimeKind.Unspecified).AddTicks(4732), 34, 2931570.879722043000000m },
                    { 31, 54, new DateTime(2024, 5, 26, 20, 5, 2, 263, DateTimeKind.Unspecified).AddTicks(7823), 58, 5832740.193866742240000m },
                    { 32, 85, new DateTime(2024, 5, 8, 11, 3, 52, 387, DateTimeKind.Unspecified).AddTicks(957), 66, 2378700.696286220640000m },
                    { 33, 13, new DateTime(2024, 5, 9, 18, 36, 22, 704, DateTimeKind.Unspecified).AddTicks(2177), 4, 3373507.660379434080000m },
                    { 34, 17, new DateTime(2024, 5, 20, 5, 3, 6, 382, DateTimeKind.Unspecified).AddTicks(4038), 81, 3666138.929598889760000m },
                    { 35, 43, new DateTime(2024, 5, 25, 7, 33, 13, 24, DateTimeKind.Unspecified).AddTicks(3341), 95, 4250712.857564081640000m },
                    { 36, 79, new DateTime(2024, 5, 13, 16, 17, 35, 465, DateTimeKind.Unspecified).AddTicks(409), 86, 3226822.54748878080000m },
                    { 37, 39, new DateTime(2024, 5, 29, 19, 15, 50, 958, DateTimeKind.Unspecified).AddTicks(4582), 39, 6335045.411731266480000m },
                    { 38, 53, new DateTime(2024, 5, 2, 4, 11, 28, 533, DateTimeKind.Unspecified).AddTicks(3477), 68, 6125410.639556913800000m },
                    { 39, 41, new DateTime(2024, 5, 24, 10, 1, 58, 301, DateTimeKind.Unspecified).AddTicks(7892), 16, 5697085.808363809280000m },
                    { 40, 69, new DateTime(2024, 5, 22, 13, 38, 17, 224, DateTimeKind.Unspecified).AddTicks(477), 23, 1558583.282928518160000m },
                    { 41, 56, new DateTime(2024, 5, 8, 6, 54, 40, 691, DateTimeKind.Unspecified).AddTicks(3558), 12, 6624093.098519683000000m },
                    { 42, 40, new DateTime(2024, 5, 23, 4, 27, 17, 784, DateTimeKind.Unspecified).AddTicks(4938), 100, 1998044.5302394973360000m },
                    { 43, 19, new DateTime(2024, 5, 7, 22, 41, 47, 910, DateTimeKind.Unspecified).AddTicks(4413), 39, 2583993.3975686848800000m },
                    { 44, 24, new DateTime(2024, 5, 5, 12, 31, 33, 983, DateTimeKind.Unspecified).AddTicks(1509), 68, 7499861.665502909280000m },
                    { 45, 37, new DateTime(2024, 5, 18, 6, 44, 9, 204, DateTimeKind.Unspecified).AddTicks(5097), 67, 7237369.502804670320000m },
                    { 46, 51, new DateTime(2024, 5, 23, 3, 50, 3, 996, DateTimeKind.Unspecified).AddTicks(366), 15, 7417829.849263711800000m },
                    { 47, 86, new DateTime(2024, 5, 19, 19, 46, 3, 300, DateTimeKind.Unspecified).AddTicks(5480), 15, 2767058.435358731200000m },
                    { 48, 11, new DateTime(2024, 5, 7, 9, 18, 46, 435, DateTimeKind.Unspecified).AddTicks(8686), 86, 4191449.879591330200000m },
                    { 49, 8, new DateTime(2024, 5, 16, 7, 41, 12, 500, DateTimeKind.Unspecified).AddTicks(2661), 95, 5513209.781956368480000m },
                    { 50, 92, new DateTime(2024, 5, 13, 0, 47, 41, 27, DateTimeKind.Unspecified).AddTicks(9308), 51, 7269246.640353537360000m },
                    { 51, 89, new DateTime(2024, 5, 9, 12, 39, 45, 210, DateTimeKind.Unspecified).AddTicks(4336), 84, 2612391.48766010680000m },
                    { 52, 76, new DateTime(2024, 5, 3, 22, 24, 15, 951, DateTimeKind.Unspecified).AddTicks(169), 55, 3895922.086515088560000m },
                    { 53, 74, new DateTime(2024, 5, 7, 0, 20, 52, 486, DateTimeKind.Unspecified).AddTicks(8832), 31, 3655077.142864102480000m },
                    { 54, 59, new DateTime(2024, 5, 25, 2, 25, 20, 48, DateTimeKind.Unspecified).AddTicks(7460), 67, 6684529.833666699760000m },
                    { 55, 72, new DateTime(2024, 5, 8, 23, 6, 51, 734, DateTimeKind.Unspecified).AddTicks(5915), 39, 8597843.936133910640000m },
                    { 56, 100, new DateTime(2024, 5, 15, 17, 41, 44, 533, DateTimeKind.Unspecified).AddTicks(1819), 49, 3221644.301875700480000m },
                    { 57, 86, new DateTime(2024, 5, 21, 21, 50, 9, 935, DateTimeKind.Unspecified).AddTicks(7635), 97, 8121238.150998336000000m },
                    { 58, 30, new DateTime(2024, 5, 22, 0, 6, 53, 32, DateTimeKind.Unspecified).AddTicks(1596), 95, 4602424.036411002960000m },
                    { 59, 98, new DateTime(2024, 5, 20, 17, 49, 24, 244, DateTimeKind.Unspecified).AddTicks(6473), 13, 5736165.441980032600000m },
                    { 60, 45, new DateTime(2024, 5, 8, 23, 40, 59, 765, DateTimeKind.Unspecified).AddTicks(4198), 44, 2610038.080541136400000m },
                    { 61, 99, new DateTime(2024, 5, 11, 23, 40, 39, 64, DateTimeKind.Unspecified).AddTicks(6675), 30, 1513231.2638939153280000m },
                    { 62, 33, new DateTime(2024, 5, 13, 13, 7, 48, 766, DateTimeKind.Unspecified).AddTicks(2102), 40, 2417935.629122659920000m },
                    { 63, 1, new DateTime(2024, 5, 18, 9, 23, 48, 198, DateTimeKind.Unspecified).AddTicks(135), 1, 6668690.797371553800000m },
                    { 64, 57, new DateTime(2024, 5, 16, 19, 56, 16, 76, DateTimeKind.Unspecified).AddTicks(6487), 57, 3177481.804757932000000m },
                    { 65, 8, new DateTime(2024, 5, 17, 18, 45, 49, 298, DateTimeKind.Unspecified).AddTicks(9399), 41, 5610477.330024434400000m },
                    { 66, 90, new DateTime(2024, 5, 20, 14, 45, 41, 723, DateTimeKind.Unspecified).AddTicks(3331), 30, 5866529.722559310800000m },
                    { 67, 76, new DateTime(2024, 5, 29, 21, 47, 28, 756, DateTimeKind.Unspecified).AddTicks(6952), 60, 6260530.287528248640000m },
                    { 68, 15, new DateTime(2024, 5, 19, 2, 22, 53, 52, DateTimeKind.Unspecified).AddTicks(1829), 31, 6178989.647459611920000m },
                    { 69, 44, new DateTime(2024, 5, 8, 12, 38, 5, 454, DateTimeKind.Unspecified).AddTicks(2825), 8, 3972260.235922023360000m },
                    { 70, 6, new DateTime(2024, 5, 19, 17, 41, 43, 11, DateTimeKind.Unspecified).AddTicks(8326), 34, 2777023.959491575360000m },
                    { 71, 77, new DateTime(2024, 5, 2, 3, 46, 11, 572, DateTimeKind.Unspecified).AddTicks(9779), 18, 5496678.438610889640000m },
                    { 72, 97, new DateTime(2024, 5, 15, 4, 15, 36, 296, DateTimeKind.Unspecified).AddTicks(2984), 28, 3608380.66809986560000m },
                    { 73, 35, new DateTime(2024, 5, 6, 2, 3, 32, 863, DateTimeKind.Unspecified).AddTicks(7804), 66, 3982736.814839600440000m },
                    { 74, 76, new DateTime(2024, 5, 17, 23, 57, 29, 699, DateTimeKind.Unspecified).AddTicks(3576), 25, 4375943.647993774800000m },
                    { 75, 10, new DateTime(2024, 5, 5, 9, 27, 24, 425, DateTimeKind.Unspecified).AddTicks(7247), 33, 7351125.173828956800000m },
                    { 76, 89, new DateTime(2024, 5, 6, 3, 30, 53, 307, DateTimeKind.Unspecified).AddTicks(8338), 46, 2431783.623686739640000m },
                    { 77, 48, new DateTime(2024, 5, 28, 6, 16, 33, 46, DateTimeKind.Unspecified).AddTicks(4821), 36, 4328125.336400927040000m },
                    { 78, 21, new DateTime(2024, 5, 9, 12, 27, 20, 375, DateTimeKind.Unspecified).AddTicks(2452), 10, 2530596.961824341160000m },
                    { 79, 77, new DateTime(2024, 5, 19, 20, 20, 14, 862, DateTimeKind.Unspecified).AddTicks(9762), 27, 3136660.238860250560000m },
                    { 80, 14, new DateTime(2024, 5, 29, 23, 53, 0, 210, DateTimeKind.Unspecified).AddTicks(715), 23, 3544716.317362536000000m },
                    { 81, 49, new DateTime(2024, 5, 22, 10, 9, 13, 729, DateTimeKind.Unspecified).AddTicks(6867), 92, 7987871.521730310560000m },
                    { 82, 20, new DateTime(2024, 5, 3, 11, 1, 53, 593, DateTimeKind.Unspecified).AddTicks(3441), 15, 3400006.444509648600000m },
                    { 83, 51, new DateTime(2024, 5, 7, 18, 49, 51, 913, DateTimeKind.Unspecified).AddTicks(9153), 14, 2687815.193344528320000m },
                    { 84, 3, new DateTime(2024, 5, 29, 20, 28, 3, 538, DateTimeKind.Unspecified).AddTicks(5947), 17, 1806443.814989941920000m },
                    { 85, 53, new DateTime(2024, 5, 18, 18, 33, 11, 537, DateTimeKind.Unspecified).AddTicks(3487), 71, 5778967.909974225400000m },
                    { 86, 84, new DateTime(2024, 5, 28, 18, 24, 25, 790, DateTimeKind.Unspecified).AddTicks(6626), 23, 7795948.500229402920000m },
                    { 87, 28, new DateTime(2024, 5, 24, 7, 23, 23, 225, DateTimeKind.Unspecified).AddTicks(1818), 92, 4493355.82095708160000m },
                    { 88, 27, new DateTime(2024, 5, 2, 2, 26, 58, 345, DateTimeKind.Unspecified).AddTicks(1674), 15, 3320126.670369564480000m },
                    { 89, 57, new DateTime(2024, 5, 7, 15, 0, 34, 331, DateTimeKind.Unspecified).AddTicks(8120), 19, 2165393.667417570000000m },
                    { 90, 91, new DateTime(2024, 5, 17, 12, 20, 20, 839, DateTimeKind.Unspecified).AddTicks(8096), 9, 5679088.672991859000000m },
                    { 91, 80, new DateTime(2024, 5, 29, 20, 30, 35, 200, DateTimeKind.Unspecified).AddTicks(1734), 46, 6286666.209270010800000m },
                    { 92, 45, new DateTime(2024, 5, 8, 0, 0, 16, 508, DateTimeKind.Unspecified).AddTicks(8015), 63, 4170062.975788638960000m },
                    { 93, 74, new DateTime(2024, 5, 20, 15, 36, 57, 606, DateTimeKind.Unspecified).AddTicks(2375), 7, 2862968.98667525760000m },
                    { 94, 3, new DateTime(2024, 5, 20, 10, 0, 22, 285, DateTimeKind.Unspecified).AddTicks(3376), 48, 5743226.306495969280000m },
                    { 95, 28, new DateTime(2024, 5, 10, 9, 56, 37, 444, DateTimeKind.Unspecified).AddTicks(3801), 1, 3236766.521312452160000m },
                    { 96, 53, new DateTime(2024, 5, 17, 6, 3, 42, 639, DateTimeKind.Unspecified).AddTicks(751), 45, 8277305.671971026720000m },
                    { 97, 25, new DateTime(2024, 5, 15, 6, 45, 43, 476, DateTimeKind.Unspecified).AddTicks(2223), 57, 5541991.068292800360000m },
                    { 98, 74, new DateTime(2024, 5, 18, 7, 49, 48, 298, DateTimeKind.Unspecified).AddTicks(8572), 77, 7377962.061326272480000m },
                    { 99, 53, new DateTime(2024, 5, 28, 23, 19, 59, 760, DateTimeKind.Unspecified).AddTicks(7862), 99, 5655918.02587771680000m },
                    { 100, 71, new DateTime(2024, 5, 2, 1, 41, 53, 919, DateTimeKind.Unspecified).AddTicks(6005), 75, 7999449.379723170080000m }
                });

            migrationBuilder.InsertData(
                table: "SalesOrder",
                columns: new[] { "OrderID", "ChangePrice", "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[,]
                {
                    { 1, 0m, 100, 21, new DateTime(2024, 5, 11, 16, 26, 4, 656, DateTimeKind.Unspecified).AddTicks(2764), 10579303.328551424000000m, 10579303.328551424000000m },
                    { 2, 0m, 56, 1, new DateTime(2024, 5, 20, 15, 23, 36, 608, DateTimeKind.Unspecified).AddTicks(1126), 6281046.392418740000000m, 6281046.392418740000000m },
                    { 3, 0m, 22, 83, new DateTime(2024, 5, 18, 19, 43, 2, 150, DateTimeKind.Unspecified).AddTicks(8403), 9609100.356460531200000m, 9609100.356460531200000m },
                    { 4, 0m, 63, 33, new DateTime(2024, 5, 3, 18, 10, 23, 315, DateTimeKind.Unspecified).AddTicks(1352), 15292567.153857261500000m, 15292567.153857261500000m },
                    { 5, 0m, 40, 1, new DateTime(2024, 5, 21, 22, 56, 27, 262, DateTimeKind.Unspecified).AddTicks(1214), 12949488.555752697000000m, 12949488.555752697000000m },
                    { 6, 0m, 58, 79, new DateTime(2024, 5, 21, 15, 18, 54, 566, DateTimeKind.Unspecified).AddTicks(7689), 16755423.232528302000000m, 16755423.232528302000000m },
                    { 7, 0m, 42, 88, new DateTime(2024, 5, 11, 12, 42, 2, 958, DateTimeKind.Unspecified).AddTicks(1698), 7861525.447008833600000m, 7861525.447008833600000m },
                    { 8, 0m, 72, 66, new DateTime(2024, 5, 26, 17, 13, 51, 714, DateTimeKind.Unspecified).AddTicks(9563), 8578456.4897629200000m, 8578456.4897629200000m },
                    { 9, 0m, 43, 1, new DateTime(2024, 5, 25, 20, 56, 33, 489, DateTimeKind.Unspecified).AddTicks(1763), 8550704.085652598600000m, 8550704.085652598600000m },
                    { 10, 0m, 12, 63, new DateTime(2024, 5, 8, 2, 36, 7, 934, DateTimeKind.Unspecified).AddTicks(6176), 13197679.404798868000000m, 13197679.404798868000000m },
                    { 11, 0m, 58, 15, new DateTime(2024, 5, 13, 17, 36, 7, 409, DateTimeKind.Unspecified).AddTicks(7307), 11221807.815882558000000m, 11221807.815882558000000m },
                    { 12, 0m, 79, 15, new DateTime(2024, 5, 19, 6, 9, 29, 2, DateTimeKind.Unspecified).AddTicks(1128), 13340638.910653198800000m, 13340638.910653198800000m },
                    { 13, 0m, 12, 2, new DateTime(2024, 5, 11, 10, 29, 13, 562, DateTimeKind.Unspecified).AddTicks(7288), 10510446.367261274500000m, 10510446.367261274500000m },
                    { 14, 0m, 100, 63, new DateTime(2024, 5, 9, 0, 21, 0, 762, DateTimeKind.Unspecified).AddTicks(103), 11478542.012275560600000m, 11478542.012275560600000m },
                    { 15, 0m, 89, 94, new DateTime(2024, 5, 10, 7, 50, 1, 45, DateTimeKind.Unspecified).AddTicks(1480), 8983810.27592088500000m, 8983810.27592088500000m },
                    { 16, 0m, 43, 78, new DateTime(2024, 5, 5, 3, 27, 57, 189, DateTimeKind.Unspecified).AddTicks(9172), 10734548.433104776400000m, 10734548.433104776400000m },
                    { 17, 0m, 44, 70, new DateTime(2024, 5, 6, 16, 22, 8, 836, DateTimeKind.Unspecified).AddTicks(2727), 12062210.605173308400000m, 12062210.605173308400000m },
                    { 18, 0m, 16, 74, new DateTime(2024, 5, 15, 8, 34, 33, 194, DateTimeKind.Unspecified).AddTicks(3814), 9045448.883791036900000m, 9045448.883791036900000m },
                    { 19, 0m, 88, 76, new DateTime(2024, 5, 9, 15, 13, 22, 583, DateTimeKind.Unspecified).AddTicks(7495), 8487238.100828838900000m, 8487238.100828838900000m },
                    { 20, 0m, 57, 41, new DateTime(2024, 5, 3, 10, 57, 9, 204, DateTimeKind.Unspecified).AddTicks(7377), 8394145.08996280000000m, 8394145.08996280000000m },
                    { 21, 0m, 90, 3, new DateTime(2024, 5, 26, 17, 36, 6, 673, DateTimeKind.Unspecified).AddTicks(2782), 10295258.036913317800000m, 10295258.036913317800000m },
                    { 22, 0m, 84, 9, new DateTime(2024, 5, 15, 8, 47, 2, 839, DateTimeKind.Unspecified).AddTicks(2927), 7739261.840281859300000m, 7739261.840281859300000m },
                    { 23, 0m, 36, 9, new DateTime(2024, 5, 12, 0, 13, 54, 750, DateTimeKind.Unspecified).AddTicks(1635), 16944919.37305508000000m, 16944919.37305508000000m },
                    { 24, 0m, 20, 30, new DateTime(2024, 5, 5, 15, 35, 47, 548, DateTimeKind.Unspecified).AddTicks(1164), 9866074.6281332187000000m, 9866074.6281332187000000m },
                    { 25, 0m, 35, 25, new DateTime(2024, 5, 18, 22, 58, 45, 841, DateTimeKind.Unspecified).AddTicks(8802), 10379992.501161864000000m, 10379992.501161864000000m },
                    { 26, 0m, 14, 73, new DateTime(2024, 5, 15, 21, 53, 56, 934, DateTimeKind.Unspecified).AddTicks(6094), 5906569.7179230379000000m, 5906569.7179230379000000m },
                    { 27, 0m, 92, 51, new DateTime(2024, 5, 12, 22, 17, 39, 902, DateTimeKind.Unspecified).AddTicks(3081), 8671486.888452218700000m, 8671486.888452218700000m },
                    { 28, 0m, 9, 16, new DateTime(2024, 5, 12, 6, 9, 15, 841, DateTimeKind.Unspecified).AddTicks(368), 13111193.507801947800000m, 13111193.507801947800000m },
                    { 29, 0m, 20, 30, new DateTime(2024, 5, 12, 6, 46, 26, 966, DateTimeKind.Unspecified).AddTicks(1844), 12547102.715244216900000m, 12547102.715244216900000m },
                    { 30, 0m, 43, 80, new DateTime(2024, 5, 28, 14, 19, 16, 524, DateTimeKind.Unspecified).AddTicks(2151), 10875743.094826483500000m, 10875743.094826483500000m },
                    { 31, 0m, 14, 24, new DateTime(2024, 5, 21, 21, 57, 37, 875, DateTimeKind.Unspecified).AddTicks(7324), 9977862.442335164800000m, 9977862.442335164800000m },
                    { 32, 0m, 70, 3, new DateTime(2024, 5, 12, 10, 39, 27, 733, DateTimeKind.Unspecified).AddTicks(766), 10098097.261466766000000m, 10098097.261466766000000m },
                    { 33, 0m, 63, 87, new DateTime(2024, 5, 28, 1, 3, 41, 574, DateTimeKind.Unspecified).AddTicks(375), 12493992.190818996800000m, 12493992.190818996800000m },
                    { 34, 0m, 37, 99, new DateTime(2024, 5, 11, 13, 21, 55, 662, DateTimeKind.Unspecified).AddTicks(8271), 13670784.666855028800000m, 13670784.666855028800000m },
                    { 35, 0m, 10, 5, new DateTime(2024, 5, 18, 18, 41, 47, 212, DateTimeKind.Unspecified).AddTicks(1152), 11754043.297187051700000m, 11754043.297187051700000m },
                    { 36, 0m, 67, 99, new DateTime(2024, 5, 18, 8, 35, 55, 71, DateTimeKind.Unspecified).AddTicks(6395), 7308234.0768458312600000m, 7308234.0768458312600000m },
                    { 37, 0m, 55, 69, new DateTime(2024, 5, 4, 6, 21, 26, 707, DateTimeKind.Unspecified).AddTicks(291), 9529037.618864934900000m, 9529037.618864934900000m },
                    { 38, 0m, 72, 76, new DateTime(2024, 5, 1, 8, 53, 16, 917, DateTimeKind.Unspecified).AddTicks(2859), 8651081.938238353600000m, 8651081.938238353600000m },
                    { 39, 0m, 29, 82, new DateTime(2024, 5, 3, 5, 20, 56, 53, DateTimeKind.Unspecified).AddTicks(8737), 6375997.130826736400000m, 6375997.130826736400000m },
                    { 40, 0m, 32, 1, new DateTime(2024, 5, 27, 14, 8, 18, 906, DateTimeKind.Unspecified).AddTicks(3678), 10527121.587900351500000m, 10527121.587900351500000m },
                    { 41, 0m, 11, 40, new DateTime(2024, 5, 28, 17, 48, 4, 612, DateTimeKind.Unspecified).AddTicks(5928), 11845198.600092419400000m, 11845198.600092419400000m },
                    { 42, 0m, 63, 30, new DateTime(2024, 5, 25, 7, 46, 45, 424, DateTimeKind.Unspecified).AddTicks(6487), 7118698.5166951793100000m, 7118698.5166951793100000m },
                    { 43, 0m, 7, 16, new DateTime(2024, 5, 20, 8, 8, 19, 590, DateTimeKind.Unspecified).AddTicks(2392), 8713267.572475214400000m, 8713267.572475214400000m },
                    { 44, 0m, 54, 66, new DateTime(2024, 5, 9, 15, 54, 48, 458, DateTimeKind.Unspecified).AddTicks(5337), 7948197.045626205000000m, 7948197.045626205000000m },
                    { 45, 0m, 27, 36, new DateTime(2024, 5, 8, 18, 55, 54, 775, DateTimeKind.Unspecified).AddTicks(783), 8766267.761124632000000m, 8766267.761124632000000m },
                    { 46, 0m, 12, 75, new DateTime(2024, 5, 16, 14, 17, 43, 513, DateTimeKind.Unspecified).AddTicks(7042), 7805274.460668406100000m, 7805274.460668406100000m },
                    { 47, 0m, 26, 43, new DateTime(2024, 5, 5, 21, 36, 31, 763, DateTimeKind.Unspecified).AddTicks(5217), 8570692.430933494200000m, 8570692.430933494200000m },
                    { 48, 0m, 81, 3, new DateTime(2024, 5, 10, 17, 24, 50, 328, DateTimeKind.Unspecified).AddTicks(8545), 7683646.412817995600000m, 7683646.412817995600000m },
                    { 49, 0m, 80, 1, new DateTime(2024, 5, 27, 10, 7, 14, 689, DateTimeKind.Unspecified).AddTicks(8249), 7221380.9640027881100000m, 7221380.9640027881100000m },
                    { 50, 0m, 37, 17, new DateTime(2024, 5, 10, 8, 42, 39, 279, DateTimeKind.Unspecified).AddTicks(1779), 9253286.012949870000000m, 9253286.012949870000000m },
                    { 51, 0m, 66, 7, new DateTime(2024, 5, 13, 1, 49, 23, 954, DateTimeKind.Unspecified).AddTicks(6857), 13451932.769328370800000m, 13451932.769328370800000m },
                    { 52, 0m, 94, 41, new DateTime(2024, 5, 24, 10, 28, 20, 329, DateTimeKind.Unspecified).AddTicks(8403), 9725702.009738200200000m, 9725702.009738200200000m },
                    { 53, 0m, 42, 88, new DateTime(2024, 5, 12, 13, 41, 6, 775, DateTimeKind.Unspecified).AddTicks(9028), 9157201.161565852400000m, 9157201.161565852400000m },
                    { 54, 0m, 47, 8, new DateTime(2024, 5, 22, 17, 31, 50, 584, DateTimeKind.Unspecified).AddTicks(7753), 6638859.1842721113400000m, 6638859.1842721113400000m },
                    { 55, 0m, 80, 11, new DateTime(2024, 5, 14, 8, 53, 55, 452, DateTimeKind.Unspecified).AddTicks(9548), 8988365.489848846600000m, 8988365.489848846600000m },
                    { 56, 0m, 78, 77, new DateTime(2024, 5, 1, 17, 3, 29, 207, DateTimeKind.Unspecified).AddTicks(4022), 11242068.823037071200000m, 11242068.823037071200000m },
                    { 57, 0m, 75, 20, new DateTime(2024, 5, 26, 17, 23, 7, 335, DateTimeKind.Unspecified).AddTicks(4258), 11954130.041798273700000m, 11954130.041798273700000m },
                    { 58, 0m, 25, 31, new DateTime(2024, 5, 12, 15, 35, 59, 495, DateTimeKind.Unspecified).AddTicks(7516), 7979949.163461047500000m, 7979949.163461047500000m },
                    { 59, 0m, 19, 96, new DateTime(2024, 5, 4, 2, 33, 59, 838, DateTimeKind.Unspecified).AddTicks(8972), 8521266.156032143800000m, 8521266.156032143800000m },
                    { 60, 0m, 55, 73, new DateTime(2024, 5, 19, 15, 0, 21, 658, DateTimeKind.Unspecified).AddTicks(2780), 9177222.738930056100000m, 9177222.738930056100000m },
                    { 61, 0m, 51, 18, new DateTime(2024, 5, 10, 9, 47, 34, 727, DateTimeKind.Unspecified).AddTicks(9216), 12155265.751137737700000m, 12155265.751137737700000m },
                    { 62, 0m, 90, 75, new DateTime(2024, 5, 24, 17, 2, 6, 565, DateTimeKind.Unspecified).AddTicks(7217), 10692472.19570275200000m, 10692472.19570275200000m },
                    { 63, 0m, 90, 77, new DateTime(2024, 5, 1, 15, 6, 1, 436, DateTimeKind.Unspecified).AddTicks(205), 7114987.814311530600000m, 7114987.814311530600000m },
                    { 64, 0m, 52, 10, new DateTime(2024, 5, 3, 4, 18, 6, 849, DateTimeKind.Unspecified).AddTicks(4967), 13408932.233231883600000m, 13408932.233231883600000m },
                    { 65, 0m, 10, 34, new DateTime(2024, 5, 25, 11, 59, 37, 97, DateTimeKind.Unspecified).AddTicks(6018), 11639598.152167044800000m, 11639598.152167044800000m },
                    { 66, 0m, 3, 15, new DateTime(2024, 5, 5, 22, 9, 9, 882, DateTimeKind.Unspecified).AddTicks(1696), 8118251.24447590400000m, 8118251.24447590400000m },
                    { 67, 0m, 7, 71, new DateTime(2024, 5, 2, 13, 23, 35, 196, DateTimeKind.Unspecified).AddTicks(5544), 7377861.091101676800000m, 7377861.091101676800000m },
                    { 68, 0m, 64, 2, new DateTime(2024, 5, 24, 1, 30, 59, 65, DateTimeKind.Unspecified).AddTicks(8438), 8271830.333259583200000m, 8271830.333259583200000m },
                    { 69, 0m, 53, 20, new DateTime(2024, 5, 6, 6, 38, 6, 210, DateTimeKind.Unspecified).AddTicks(4390), 16644575.701021851000000m, 16644575.701021851000000m },
                    { 70, 0m, 67, 52, new DateTime(2024, 5, 15, 11, 55, 37, 966, DateTimeKind.Unspecified).AddTicks(6283), 8749623.719675613600000m, 8749623.719675613600000m },
                    { 71, 0m, 83, 84, new DateTime(2024, 5, 25, 19, 39, 0, 964, DateTimeKind.Unspecified).AddTicks(6291), 14764082.573630310000000m, 14764082.573630310000000m },
                    { 72, 0m, 81, 32, new DateTime(2024, 5, 5, 9, 22, 53, 24, DateTimeKind.Unspecified).AddTicks(6614), 9300421.843705415000000m, 9300421.843705415000000m },
                    { 73, 0m, 53, 28, new DateTime(2024, 5, 2, 7, 14, 7, 815, DateTimeKind.Unspecified).AddTicks(3158), 14234680.080843877700000m, 14234680.080843877700000m },
                    { 74, 0m, 13, 57, new DateTime(2024, 5, 17, 14, 28, 54, 483, DateTimeKind.Unspecified).AddTicks(4126), 7518528.7477191003000000m, 7518528.7477191003000000m },
                    { 75, 0m, 86, 46, new DateTime(2024, 5, 6, 14, 12, 7, 335, DateTimeKind.Unspecified).AddTicks(4426), 9925918.006497436400000m, 9925918.006497436400000m },
                    { 76, 0m, 12, 25, new DateTime(2024, 5, 3, 12, 3, 47, 634, DateTimeKind.Unspecified).AddTicks(1193), 12123069.97419669800000m, 12123069.97419669800000m },
                    { 77, 0m, 55, 65, new DateTime(2024, 5, 9, 22, 15, 26, 787, DateTimeKind.Unspecified).AddTicks(3490), 7888125.7075283580000000m, 7888125.7075283580000000m },
                    { 78, 0m, 45, 10, new DateTime(2024, 5, 13, 18, 43, 59, 93, DateTimeKind.Unspecified).AddTicks(3602), 15731827.962545879000000m, 15731827.962545879000000m },
                    { 79, 0m, 59, 57, new DateTime(2024, 5, 11, 4, 3, 49, 125, DateTimeKind.Unspecified).AddTicks(6624), 9097784.072238876000000m, 9097784.072238876000000m },
                    { 80, 0m, 83, 53, new DateTime(2024, 5, 16, 23, 4, 32, 338, DateTimeKind.Unspecified).AddTicks(1781), 12440781.616019337000000m, 12440781.616019337000000m },
                    { 81, 0m, 59, 45, new DateTime(2024, 5, 11, 17, 33, 23, 40, DateTimeKind.Unspecified).AddTicks(5474), 9736511.48566957500000m, 9736511.48566957500000m },
                    { 82, 0m, 81, 37, new DateTime(2024, 5, 28, 17, 23, 42, 126, DateTimeKind.Unspecified).AddTicks(4376), 8897906.745958907600000m, 8897906.745958907600000m },
                    { 83, 0m, 61, 67, new DateTime(2024, 5, 21, 15, 41, 40, 20, DateTimeKind.Unspecified).AddTicks(2836), 16968814.215809350400000m, 16968814.215809350400000m },
                    { 84, 0m, 84, 31, new DateTime(2024, 5, 3, 8, 35, 23, 750, DateTimeKind.Unspecified).AddTicks(7749), 8226528.2558132408000000m, 8226528.2558132408000000m },
                    { 85, 0m, 91, 17, new DateTime(2024, 5, 2, 13, 22, 51, 934, DateTimeKind.Unspecified).AddTicks(1353), 10559852.86433232900000m, 10559852.86433232900000m },
                    { 86, 0m, 85, 81, new DateTime(2024, 5, 16, 9, 44, 57, 282, DateTimeKind.Unspecified).AddTicks(9513), 12384399.283148820800000m, 12384399.283148820800000m },
                    { 87, 0m, 98, 25, new DateTime(2024, 5, 1, 20, 19, 50, 908, DateTimeKind.Unspecified).AddTicks(4644), 10177830.076728155100000m, 10177830.076728155100000m },
                    { 88, 0m, 77, 98, new DateTime(2024, 5, 19, 12, 41, 39, 422, DateTimeKind.Unspecified).AddTicks(40), 10845529.104143157600000m, 10845529.104143157600000m },
                    { 89, 0m, 100, 52, new DateTime(2024, 5, 5, 11, 22, 52, 435, DateTimeKind.Unspecified).AddTicks(1846), 13720144.520660767200000m, 13720144.520660767200000m },
                    { 90, 0m, 46, 30, new DateTime(2024, 5, 9, 19, 5, 29, 22, DateTimeKind.Unspecified).AddTicks(9149), 9365169.1414674632800000m, 9365169.1414674632800000m },
                    { 91, 0m, 35, 88, new DateTime(2024, 5, 23, 0, 47, 1, 986, DateTimeKind.Unspecified).AddTicks(1076), 16718688.064178635000000m, 16718688.064178635000000m },
                    { 92, 0m, 63, 63, new DateTime(2024, 5, 29, 14, 20, 31, 101, DateTimeKind.Unspecified).AddTicks(5046), 6743739.4846166457600000m, 6743739.4846166457600000m },
                    { 93, 0m, 19, 40, new DateTime(2024, 5, 8, 7, 28, 1, 103, DateTimeKind.Unspecified).AddTicks(6331), 7597473.989976472800000m, 7597473.989976472800000m },
                    { 94, 0m, 48, 59, new DateTime(2024, 5, 23, 2, 46, 39, 957, DateTimeKind.Unspecified).AddTicks(701), 12595773.636147474200000m, 12595773.636147474200000m },
                    { 95, 0m, 63, 54, new DateTime(2024, 5, 29, 5, 5, 19, 518, DateTimeKind.Unspecified).AddTicks(1943), 7371522.199296632400000m, 7371522.199296632400000m },
                    { 96, 0m, 96, 25, new DateTime(2024, 5, 19, 21, 32, 41, 815, DateTimeKind.Unspecified).AddTicks(968), 10305941.818365077800000m, 10305941.818365077800000m },
                    { 97, 0m, 91, 78, new DateTime(2024, 5, 24, 8, 45, 33, 430, DateTimeKind.Unspecified).AddTicks(4520), 13424680.500084398100000m, 13424680.500084398100000m },
                    { 98, 0m, 36, 63, new DateTime(2024, 5, 28, 20, 28, 40, 284, DateTimeKind.Unspecified).AddTicks(2480), 8655228.909263904800000m, 8655228.909263904800000m },
                    { 99, 0m, 2, 17, new DateTime(2024, 5, 6, 0, 41, 45, 292, DateTimeKind.Unspecified).AddTicks(4936), 7791022.602359158400000m, 7791022.602359158400000m },
                    { 100, 0m, 94, 55, new DateTime(2024, 5, 8, 14, 52, 48, 260, DateTimeKind.Unspecified).AddTicks(1145), 12099701.8084360400000m, 12099701.8084360400000m }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "EmployeeID", "RoleID", "Email", "LastLogin", "Lock", "Password" },
                values: new object[,]
                {
                    { 2, 1, "VietNhan_Ly57@gmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 3, 1, "TruongPhuc62@gmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 4, 1, "KimThao.Trinh78@yahoo.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 5, 1, "TuongLan_To@yahoo.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 6, 1, "KimKhanh_Ngo37@yahoo.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 11, 1, "LanTruc_Duong68@yahoo.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 14, 1, "LienTran78@yahoo.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 17, 1, "BaoLan_Tran@yahoo.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 18, 1, "ThienMai.Ngo@yahoo.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 19, 1, "BaoThach_Ngo47@gmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 21, 1, "ThienLan.Pham@hotmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 22, 1, "DinhLoc.Dang85@hotmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 28, 1, "HoaLy.Ly@hotmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 29, 1, "NhanHong.Truong@yahoo.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 31, 1, "UyenMy93@hotmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 32, 1, "TuanSi.Phung@yahoo.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 34, 1, "NhaMai83@hotmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 38, 1, "PhuongNgoc_Duong36@yahoo.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 39, 1, "QuangTrieu.Tang@gmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 42, 1, "NgocQuang_Dao@gmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 43, 1, "HuuThong23@yahoo.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 44, 1, "ThanhThu33@yahoo.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 46, 1, "AnhThai.Ho@hotmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 47, 1, "BanMai.Mai42@hotmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 48, 1, "CongBang15@gmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 49, 1, "HuuChien_Phan@gmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 54, 1, "MaiLien.Ly53@hotmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 55, 1, "LinhLan43@hotmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 56, 1, "MongLong.Vuong@yahoo.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 60, 1, "BichTram_Pham70@gmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 61, 1, "MinhAnh79@hotmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 62, 1, "TinhTam_Duong@gmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 63, 1, "BichHai85@gmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 66, 1, "QuangThach.Ngo71@yahoo.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 68, 1, "ThaiDuc.Phan9@yahoo.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 69, 1, "MinhHai.Truong84@gmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 70, 1, "QuynhLam_Ly41@gmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 73, 1, "ThanhThien.Hoang71@gmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 74, 1, "ThanhHoa5@hotmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 75, 1, "UyenMinh.Ly14@yahoo.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 76, 1, "HangNga.Phung@yahoo.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 77, 1, "HuuNghi.Tang@gmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 81, 1, "QuocViet_Ngo@gmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 83, 1, "DucPhi.Dao6@gmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 85, 1, "TrucLien_Ngo@hotmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 86, 1, "NhanTu_Ngo66@hotmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 89, 1, "YenTrang87@gmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 90, 1, "VietHung.Tran95@yahoo.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 91, 1, "TungAnh_Mai17@hotmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 93, 1, "PhuongNhung_Phung@hotmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 95, 1, "ThieuLy_Dang65@gmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 96, 1, "NgocCam.Ly85@gmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 99, 1, "LamNgoc52@hotmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 100, 1, "TamDoan.Vuong@gmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" }
                });

            migrationBuilder.InsertData(
                table: "UserRole",
                columns: new[] { "RoleID", "DateCreated", "Description", "PermissionID", "RoleName" },
                values: new object[] { 2, new DateTime(2024, 3, 23, 16, 41, 6, 171, DateTimeKind.Local).AddTicks(1280), null, 2, "Nhân viên nhập hàng" });

            migrationBuilder.InsertData(
                table: "DetailImportOrder",
                columns: new[] { "OrderID", "ProductID", "Quantity", "UnitPrice" },
                values: new object[,]
                {
                    { 1, 1, 146, 42303.508097224280000m },
                    { 2, 2, 181, 28506.08768774480000m },
                    { 3, 3, 126, 15585.307901765960000m },
                    { 4, 4, 162, 12684.8064956345920000m },
                    { 5, 5, 131, 23804.30923441560000m },
                    { 6, 6, 198, 11296.3826401911120000m },
                    { 7, 7, 186, 27302.443521340640000m },
                    { 8, 8, 143, 20285.572075097560000m },
                    { 9, 9, 175, 48665.735361213360000m },
                    { 10, 10, 193, 31752.838311112880000m },
                    { 11, 11, 187, 38943.785612323000000m },
                    { 12, 12, 137, 42750.893066735480000m },
                    { 13, 13, 194, 31824.753924724360000m },
                    { 14, 14, 125, 25276.508527109760000m },
                    { 15, 15, 176, 28018.129339980120000m },
                    { 16, 16, 122, 18552.032634340040000m },
                    { 17, 17, 175, 21360.649041562600000m },
                    { 18, 18, 172, 28189.362452908600000m },
                    { 19, 19, 198, 18372.464710156640000m },
                    { 20, 20, 144, 35718.469760871160000m },
                    { 21, 21, 148, 47808.125608409760000m },
                    { 22, 22, 155, 44542.919863338040000m },
                    { 23, 23, 167, 39686.431843489000000m },
                    { 24, 24, 197, 32542.519173625480000m },
                    { 25, 25, 156, 39082.609434288720000m },
                    { 26, 26, 149, 29543.683841355280000m },
                    { 27, 27, 135, 19170.921973614240000m },
                    { 28, 28, 102, 29998.902836275840000m },
                    { 29, 29, 177, 27550.393883550960000m },
                    { 30, 30, 195, 15033.696819087400000m },
                    { 31, 31, 189, 30861.059226808160000m },
                    { 32, 32, 174, 13670.693656817360000m },
                    { 33, 33, 116, 29081.962589477880000m },
                    { 34, 34, 103, 35593.581840765920000m },
                    { 35, 35, 141, 30146.899699036040000m },
                    { 36, 36, 112, 28810.91560257840000m },
                    { 37, 37, 142, 44612.995857262440000m },
                    { 38, 38, 149, 41110.138520516200000m },
                    { 39, 39, 124, 45944.240390030720000m },
                    { 40, 40, 102, 15280.228264005080000m },
                    { 41, 41, 155, 42736.084506578600000m },
                    { 42, 42, 178, 11224.9692710084120000m },
                    { 43, 43, 185, 13967.5318787496480000m },
                    { 44, 44, 174, 43102.653250016720000m },
                    { 45, 45, 182, 39765.766498926760000m },
                    { 46, 46, 195, 38040.153073147240000m },
                    { 47, 47, 190, 14563.465449256480000m },
                    { 48, 48, 149, 28130.536104639800000m },
                    { 49, 49, 138, 39950.795521422960000m },
                    { 50, 50, 153, 47511.415950023120000m },
                    { 51, 51, 139, 18794.18336446120000m },
                    { 52, 52, 126, 30920.016559643560000m },
                    { 53, 53, 119, 30714.933973647920000m },
                    { 54, 54, 166, 40268.252010040360000m },
                    { 55, 55, 182, 47240.900747988520000m },
                    { 56, 56, 104, 30977.349056497120000m },
                    { 57, 57, 200, 40606.190754991680000m },
                    { 58, 58, 139, 33110.964290726640000m },
                    { 59, 59, 137, 41869.820744379800000m },
                    { 60, 60, 115, 22695.983309053360000m },
                    { 61, 61, 112, 13510.9934276242440000m },
                    { 62, 62, 149, 16227.755900152080000m },
                    { 63, 63, 185, 36046.977283089480000m },
                    { 64, 64, 175, 18157.038884331040000m },
                    { 65, 65, 130, 43157.517923264880000m },
                    { 66, 66, 155, 37848.578855221360000m },
                    { 67, 67, 188, 33300.693018767280000m },
                    { 68, 68, 147, 42033.943179997360000m },
                    { 69, 69, 111, 35786.128251549760000m },
                    { 70, 70, 106, 26198.339240486560000m },
                    { 71, 71, 127, 43280.932587487320000m },
                    { 72, 72, 164, 22002.32114695040000m },
                    { 73, 73, 119, 33468.376595290760000m },
                    { 74, 74, 135, 32414.397392546480000m },
                    { 75, 75, 180, 40839.584299049760000m },
                    { 76, 76, 157, 15489.067666794520000m },
                    { 77, 77, 168, 25762.650811910280000m },
                    { 78, 78, 159, 15915.704162417240000m },
                    { 79, 79, 164, 19125.977066221040000m },
                    { 80, 80, 100, 35447.163173625360000m },
                    { 81, 81, 196, 40754.446539440360000m },
                    { 82, 82, 165, 20606.099663694840000m },
                    { 83, 83, 173, 15536.504007771840000m },
                    { 84, 84, 108, 16726.331620277240000m },
                    { 85, 85, 145, 39854.951103270520000m },
                    { 86, 86, 163, 47827.904909382840000m },
                    { 87, 87, 128, 35104.34235122720000m },
                    { 88, 88, 186, 17850.143389083680000m },
                    { 89, 89, 125, 17323.149339340560000m },
                    { 90, 90, 177, 32085.246740067000000m },
                    { 91, 91, 146, 43059.357597739800000m },
                    { 92, 92, 114, 36579.499787619640000m },
                    { 93, 93, 168, 17041.48206354320000m },
                    { 94, 94, 192, 29912.637012999840000m },
                    { 95, 95, 109, 29695.105700114240000m },
                    { 96, 96, 194, 42666.524082324880000m },
                    { 97, 97, 141, 39304.901193565960000m },
                    { 98, 98, 172, 42895.128263524840000m },
                    { 99, 99, 114, 49613.31601647120000m },
                    { 100, 100, 178, 44940.726852377360000m }
                });

            migrationBuilder.InsertData(
                table: "DetailSalesOrder",
                columns: new[] { "OrderID", "ProductID", "Quantity", "UnitPrice" },
                values: new object[,]
                {
                    { 1, 1, 80, 132241.291606892800000m },
                    { 2, 2, 50, 125620.927848374800000m },
                    { 3, 3, 64, 150142.193069695800000m },
                    { 4, 4, 85, 179912.554751261900000m },
                    { 5, 5, 78, 166019.084048111500000m },
                    { 6, 6, 84, 199469.324196765500000m },
                    { 7, 7, 68, 115610.668338365200000m },
                    { 8, 8, 54, 158860.3053659800000m },
                    { 9, 9, 58, 147425.932511251700000m },
                    { 10, 10, 70, 188538.277211412400000m },
                    { 11, 11, 90, 124686.753509806200000m },
                    { 12, 12, 74, 180278.904198016200000m },
                    { 13, 13, 55, 191099.024859295900000m },
                    { 14, 14, 62, 185137.774391541300000m },
                    { 15, 15, 61, 147275.57829378500000m },
                    { 16, 16, 86, 124820.330617497400000m },
                    { 17, 17, 76, 158713.297436490900000m },
                    { 18, 18, 61, 148286.047275262900000m },
                    { 19, 19, 59, 143851.493234387100000m },
                    { 20, 20, 50, 167882.90179925600000m },
                    { 21, 21, 59, 174495.898930734200000m },
                    { 22, 22, 59, 131173.929496302700000m },
                    { 23, 23, 88, 192555.90196653500000m },
                    { 24, 24, 90, 109623.0514237024300000m },
                    { 25, 25, 60, 172999.875019364400000m },
                    { 26, 26, 58, 101837.4089297075500000m },
                    { 27, 27, 51, 170029.154675533700000m },
                    { 28, 28, 66, 198654.447087908300000m },
                    { 29, 29, 87, 144219.571439588700000m },
                    { 30, 30, 55, 197740.783542299700000m },
                    { 31, 31, 74, 134835.978950475200000m },
                    { 32, 32, 60, 168301.621024446100000m },
                    { 33, 33, 83, 150530.026395409600000m },
                    { 34, 34, 72, 189872.009261875400000m },
                    { 35, 35, 63, 186572.115828365900000m },
                    { 36, 36, 67, 109078.1205499377800000m },
                    { 37, 37, 71, 134211.797448801900000m },
                    { 38, 38, 56, 154483.606039970600000m },
                    { 39, 39, 52, 122615.329438975700000m },
                    { 40, 40, 85, 123848.489269415900000m },
                    { 41, 41, 81, 146237.019754227400000m },
                    { 42, 42, 69, 103169.5437202199900000m },
                    { 43, 43, 71, 122722.078485566400000m },
                    { 44, 44, 50, 158963.940912524100000m },
                    { 45, 45, 80, 109578.347014057900000m },
                    { 46, 46, 53, 147269.329446573700000m },
                    { 47, 47, 53, 161711.177942141400000m },
                    { 48, 48, 59, 130231.295132508400000m },
                    { 49, 49, 69, 104657.6951304751900000m },
                    { 50, 50, 60, 154221.433549164500000m },
                    { 51, 51, 74, 181782.875261194200000m },
                    { 52, 52, 57, 170626.351048038600000m },
                    { 53, 53, 61, 150118.051828948400000m },
                    { 54, 54, 61, 108833.7571192149400000m },
                    { 55, 55, 74, 121464.398511470900000m },
                    { 56, 56, 76, 147921.958197856200000m },
                    { 57, 57, 69, 173248.261475337300000m },
                    { 58, 58, 65, 122768.448668631500000m },
                    { 59, 59, 59, 144428.239932748200000m },
                    { 60, 60, 57, 161003.907700527300000m },
                    { 61, 61, 61, 199266.651657995700000m },
                    { 62, 62, 78, 137082.97686798400000m },
                    { 63, 63, 51, 139509.564986500600000m },
                    { 64, 64, 84, 159630.145633712900000m },
                    { 65, 65, 62, 187735.454067210400000m },
                    { 66, 66, 58, 139969.84904268800000m },
                    { 67, 67, 64, 115279.079548463700000m },
                    { 68, 68, 54, 153182.043208510800000m },
                    { 69, 69, 90, 184939.730011353900000m },
                    { 70, 70, 57, 153502.170520624800000m },
                    { 71, 71, 75, 196854.434315070800000m },
                    { 72, 72, 50, 186008.436874108300000m },
                    { 73, 73, 89, 159940.225627459300000m },
                    { 74, 74, 70, 107407.5535388442900000m },
                    { 75, 75, 76, 130604.184296018900000m },
                    { 76, 76, 74, 163825.26992157700000m },
                    { 77, 77, 75, 105175.0094337114400000m },
                    { 78, 78, 86, 182928.232122626500000m },
                    { 79, 79, 56, 162460.429861408500000m },
                    { 80, 80, 90, 138230.906844659300000m },
                    { 81, 81, 75, 129820.15314226100000m },
                    { 82, 82, 77, 115557.230466998800000m },
                    { 83, 83, 88, 192827.434270560800000m },
                    { 84, 84, 80, 102831.6031976655100000m },
                    { 85, 85, 83, 127227.14294376300000m },
                    { 86, 86, 68, 182123.518869835600000m },
                    { 87, 87, 69, 147504.783720697900000m },
                    { 88, 88, 66, 164326.198547623600000m },
                    { 89, 89, 72, 190557.562786955100000m },
                    { 90, 90, 88, 106422.3766075848100000m },
                    { 91, 91, 86, 194403.349583472500000m },
                    { 92, 92, 64, 105370.9294471350900000m },
                    { 93, 93, 66, 115113.242272370800000m },
                    { 94, 94, 86, 146462.484141249700000m },
                    { 95, 95, 57, 129324.950864853200000m },
                    { 96, 96, 53, 194451.732421982600000m },
                    { 97, 97, 69, 194560.586957744900000m },
                    { 98, 98, 73, 118564.779578957600000m },
                    { 99, 99, 56, 139125.403613556400000m },
                    { 100, 100, 68, 177936.7913005300000m }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "EmployeeID", "RoleID", "Email", "LastLogin", "Lock", "Password" },
                values: new object[,]
                {
                    { 1, 2, "NgocTram61@yahoo.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 7, 2, "ChePhuong.Ly25@yahoo.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 8, 2, "DinhChieu52@hotmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 9, 2, "TuanHung.Tran5@hotmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 10, 2, "DuyAn88@gmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 12, 2, "KhanhAn.Ly@hotmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 13, 2, "KhanhHoa.Phan@yahoo.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 15, 2, "VuongTrieu.Tang28@yahoo.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 16, 2, "VinhDieu_Vuong76@gmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 20, 2, "HongNhan_Duong55@yahoo.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 23, 2, "AnhMinh64@hotmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 24, 2, "MongThu90@gmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 25, 2, "ThuyLieu35@gmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 26, 2, "ThanhTin_Do@yahoo.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 27, 2, "TienDung.Ho@hotmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 30, 2, "LeQuyen_Tran54@gmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 33, 2, "BaoPhuong35@gmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 35, 2, "KhaiCa_Ngo89@gmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 36, 2, "NgocTru_Mai67@yahoo.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 37, 2, "ChiThanh0@yahoo.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 40, 2, "KhietTam_Phung@hotmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 41, 2, "TuongAnh18@gmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 45, 2, "SuongSuong8@hotmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 50, 2, "BaThien_Bui40@yahoo.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 51, 2, "NhaHuong_Vu@gmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 52, 2, "LuongThien15@gmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 53, 2, "YenThanh56@hotmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 57, 2, "TrungKien.Lam@yahoo.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 58, 2, "NhaSuong_Dang65@yahoo.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 59, 2, "PhuongPhi34@hotmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 64, 2, "NgocLinh_Phung52@gmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 65, 2, "XuanMinh77@yahoo.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 67, 2, "VuHong_Dao5@hotmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 71, 2, "KienDuc5@gmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 72, 2, "BichTram46@gmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 78, 2, "BaoBinh17@hotmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 79, 2, "HuyViet.Ha72@hotmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 80, 2, "BaoThach.To68@hotmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 82, 2, "NguyenBao_Tran@yahoo.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 84, 2, "MinhThu.Phung65@gmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 87, 2, "HaiPhuong.Duong@hotmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 88, 2, "TuyetBang49@gmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 92, 2, "XuanTam58@gmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 94, 2, "SuongSuong_Mai37@yahoo.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 97, 2, "ThuSinh72@gmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 98, 2, "TriHung.Vuong49@gmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_DetailImportOrder_ImportOrder_OrderID",
                table: "DetailImportOrder",
                column: "OrderID",
                principalTable: "ImportOrder",
                principalColumn: "OrderID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DetailImportOrder_Product_ProductID",
                table: "DetailImportOrder",
                column: "ProductID",
                principalTable: "Product",
                principalColumn: "ProductID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DetailSalesOrder_Product_ProductID",
                table: "DetailSalesOrder",
                column: "ProductID",
                principalTable: "Product",
                principalColumn: "ProductID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DetailSalesOrder_SalesOrder_OrderID",
                table: "DetailSalesOrder",
                column: "OrderID",
                principalTable: "SalesOrder",
                principalColumn: "OrderID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ImportOrder_Employee_EmployeeID",
                table: "ImportOrder",
                column: "EmployeeID",
                principalTable: "Employee",
                principalColumn: "EmployeeID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ImportOrder_Provider_ProviderID",
                table: "ImportOrder",
                column: "ProviderID",
                principalTable: "Provider",
                principalColumn: "ProviderID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SalesOrder_Customer_CustomerID",
                table: "SalesOrder",
                column: "CustomerID",
                principalTable: "Customer",
                principalColumn: "CustomerID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SalesOrder_Employee_EmployeeID",
                table: "SalesOrder",
                column: "EmployeeID",
                principalTable: "Employee",
                principalColumn: "EmployeeID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_User_Employee_EmployeeID",
                table: "User",
                column: "EmployeeID",
                principalTable: "Employee",
                principalColumn: "EmployeeID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_User_UserRole_RoleID",
                table: "User",
                column: "RoleID",
                principalTable: "UserRole",
                principalColumn: "RoleID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserRole_Permission_PermissionID",
                table: "UserRole",
                column: "PermissionID",
                principalTable: "Permission",
                principalColumn: "PermissionID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DetailImportOrder_ImportOrder_OrderID",
                table: "DetailImportOrder");

            migrationBuilder.DropForeignKey(
                name: "FK_DetailImportOrder_Product_ProductID",
                table: "DetailImportOrder");

            migrationBuilder.DropForeignKey(
                name: "FK_DetailSalesOrder_Product_ProductID",
                table: "DetailSalesOrder");

            migrationBuilder.DropForeignKey(
                name: "FK_DetailSalesOrder_SalesOrder_OrderID",
                table: "DetailSalesOrder");

            migrationBuilder.DropForeignKey(
                name: "FK_ImportOrder_Employee_EmployeeID",
                table: "ImportOrder");

            migrationBuilder.DropForeignKey(
                name: "FK_ImportOrder_Provider_ProviderID",
                table: "ImportOrder");

            migrationBuilder.DropForeignKey(
                name: "FK_SalesOrder_Customer_CustomerID",
                table: "SalesOrder");

            migrationBuilder.DropForeignKey(
                name: "FK_SalesOrder_Employee_EmployeeID",
                table: "SalesOrder");

            migrationBuilder.DropForeignKey(
                name: "FK_User_Employee_EmployeeID",
                table: "User");

            migrationBuilder.DropForeignKey(
                name: "FK_User_UserRole_RoleID",
                table: "User");

            migrationBuilder.DropForeignKey(
                name: "FK_UserRole_Permission_PermissionID",
                table: "UserRole");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserRole",
                table: "UserRole");

            migrationBuilder.DropPrimaryKey(
                name: "PK_User",
                table: "User");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SalesOrder",
                table: "SalesOrder");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Provider",
                table: "Provider");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Product",
                table: "Product");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Permission",
                table: "Permission");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ImportOrder",
                table: "ImportOrder");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DetailSalesOrder",
                table: "DetailSalesOrder");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DetailImportOrder",
                table: "DetailImportOrder");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AppInfo",
                table: "AppInfo");

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 4, 4 });

            migrationBuilder.DeleteData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 5, 5 });

            migrationBuilder.DeleteData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 6, 6 });

            migrationBuilder.DeleteData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 7, 7 });

            migrationBuilder.DeleteData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 8, 8 });

            migrationBuilder.DeleteData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 9, 9 });

            migrationBuilder.DeleteData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 10, 10 });

            migrationBuilder.DeleteData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 11, 11 });

            migrationBuilder.DeleteData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 12, 12 });

            migrationBuilder.DeleteData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 13, 13 });

            migrationBuilder.DeleteData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 14, 14 });

            migrationBuilder.DeleteData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 15, 15 });

            migrationBuilder.DeleteData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 16, 16 });

            migrationBuilder.DeleteData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 17, 17 });

            migrationBuilder.DeleteData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 18, 18 });

            migrationBuilder.DeleteData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 19, 19 });

            migrationBuilder.DeleteData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 20, 20 });

            migrationBuilder.DeleteData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 21, 21 });

            migrationBuilder.DeleteData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 22, 22 });

            migrationBuilder.DeleteData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 23, 23 });

            migrationBuilder.DeleteData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 24, 24 });

            migrationBuilder.DeleteData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 25, 25 });

            migrationBuilder.DeleteData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 26, 26 });

            migrationBuilder.DeleteData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 27, 27 });

            migrationBuilder.DeleteData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 28, 28 });

            migrationBuilder.DeleteData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 29, 29 });

            migrationBuilder.DeleteData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 30, 30 });

            migrationBuilder.DeleteData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 31, 31 });

            migrationBuilder.DeleteData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 32, 32 });

            migrationBuilder.DeleteData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 33, 33 });

            migrationBuilder.DeleteData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 34, 34 });

            migrationBuilder.DeleteData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 35, 35 });

            migrationBuilder.DeleteData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 36, 36 });

            migrationBuilder.DeleteData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 37, 37 });

            migrationBuilder.DeleteData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 38, 38 });

            migrationBuilder.DeleteData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 39, 39 });

            migrationBuilder.DeleteData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 40, 40 });

            migrationBuilder.DeleteData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 41, 41 });

            migrationBuilder.DeleteData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 42, 42 });

            migrationBuilder.DeleteData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 43, 43 });

            migrationBuilder.DeleteData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 44, 44 });

            migrationBuilder.DeleteData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 45, 45 });

            migrationBuilder.DeleteData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 46, 46 });

            migrationBuilder.DeleteData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 47, 47 });

            migrationBuilder.DeleteData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 48, 48 });

            migrationBuilder.DeleteData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 49, 49 });

            migrationBuilder.DeleteData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 50, 50 });

            migrationBuilder.DeleteData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 51, 51 });

            migrationBuilder.DeleteData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 52, 52 });

            migrationBuilder.DeleteData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 53, 53 });

            migrationBuilder.DeleteData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 54, 54 });

            migrationBuilder.DeleteData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 55, 55 });

            migrationBuilder.DeleteData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 56, 56 });

            migrationBuilder.DeleteData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 57, 57 });

            migrationBuilder.DeleteData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 58, 58 });

            migrationBuilder.DeleteData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 59, 59 });

            migrationBuilder.DeleteData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 60, 60 });

            migrationBuilder.DeleteData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 61, 61 });

            migrationBuilder.DeleteData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 62, 62 });

            migrationBuilder.DeleteData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 63, 63 });

            migrationBuilder.DeleteData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 64, 64 });

            migrationBuilder.DeleteData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 65, 65 });

            migrationBuilder.DeleteData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 66, 66 });

            migrationBuilder.DeleteData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 67, 67 });

            migrationBuilder.DeleteData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 68, 68 });

            migrationBuilder.DeleteData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 69, 69 });

            migrationBuilder.DeleteData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 70, 70 });

            migrationBuilder.DeleteData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 71, 71 });

            migrationBuilder.DeleteData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 72, 72 });

            migrationBuilder.DeleteData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 73, 73 });

            migrationBuilder.DeleteData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 74, 74 });

            migrationBuilder.DeleteData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 75, 75 });

            migrationBuilder.DeleteData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 76, 76 });

            migrationBuilder.DeleteData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 77, 77 });

            migrationBuilder.DeleteData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 78, 78 });

            migrationBuilder.DeleteData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 79, 79 });

            migrationBuilder.DeleteData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 80, 80 });

            migrationBuilder.DeleteData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 81, 81 });

            migrationBuilder.DeleteData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 82, 82 });

            migrationBuilder.DeleteData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 83, 83 });

            migrationBuilder.DeleteData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 84, 84 });

            migrationBuilder.DeleteData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 85, 85 });

            migrationBuilder.DeleteData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 86, 86 });

            migrationBuilder.DeleteData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 87, 87 });

            migrationBuilder.DeleteData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 88, 88 });

            migrationBuilder.DeleteData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 89, 89 });

            migrationBuilder.DeleteData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 90, 90 });

            migrationBuilder.DeleteData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 91, 91 });

            migrationBuilder.DeleteData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 92, 92 });

            migrationBuilder.DeleteData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 93, 93 });

            migrationBuilder.DeleteData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 94, 94 });

            migrationBuilder.DeleteData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 95, 95 });

            migrationBuilder.DeleteData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 96, 96 });

            migrationBuilder.DeleteData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 97, 97 });

            migrationBuilder.DeleteData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 98, 98 });

            migrationBuilder.DeleteData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 99, 99 });

            migrationBuilder.DeleteData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 100, 100 });

            migrationBuilder.DeleteData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 4, 4 });

            migrationBuilder.DeleteData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 5, 5 });

            migrationBuilder.DeleteData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 6, 6 });

            migrationBuilder.DeleteData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 7, 7 });

            migrationBuilder.DeleteData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 8, 8 });

            migrationBuilder.DeleteData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 9, 9 });

            migrationBuilder.DeleteData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 10, 10 });

            migrationBuilder.DeleteData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 11, 11 });

            migrationBuilder.DeleteData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 12, 12 });

            migrationBuilder.DeleteData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 13, 13 });

            migrationBuilder.DeleteData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 14, 14 });

            migrationBuilder.DeleteData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 15, 15 });

            migrationBuilder.DeleteData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 16, 16 });

            migrationBuilder.DeleteData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 17, 17 });

            migrationBuilder.DeleteData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 18, 18 });

            migrationBuilder.DeleteData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 19, 19 });

            migrationBuilder.DeleteData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 20, 20 });

            migrationBuilder.DeleteData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 21, 21 });

            migrationBuilder.DeleteData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 22, 22 });

            migrationBuilder.DeleteData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 23, 23 });

            migrationBuilder.DeleteData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 24, 24 });

            migrationBuilder.DeleteData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 25, 25 });

            migrationBuilder.DeleteData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 26, 26 });

            migrationBuilder.DeleteData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 27, 27 });

            migrationBuilder.DeleteData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 28, 28 });

            migrationBuilder.DeleteData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 29, 29 });

            migrationBuilder.DeleteData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 30, 30 });

            migrationBuilder.DeleteData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 31, 31 });

            migrationBuilder.DeleteData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 32, 32 });

            migrationBuilder.DeleteData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 33, 33 });

            migrationBuilder.DeleteData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 34, 34 });

            migrationBuilder.DeleteData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 35, 35 });

            migrationBuilder.DeleteData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 36, 36 });

            migrationBuilder.DeleteData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 37, 37 });

            migrationBuilder.DeleteData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 38, 38 });

            migrationBuilder.DeleteData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 39, 39 });

            migrationBuilder.DeleteData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 40, 40 });

            migrationBuilder.DeleteData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 41, 41 });

            migrationBuilder.DeleteData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 42, 42 });

            migrationBuilder.DeleteData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 43, 43 });

            migrationBuilder.DeleteData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 44, 44 });

            migrationBuilder.DeleteData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 45, 45 });

            migrationBuilder.DeleteData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 46, 46 });

            migrationBuilder.DeleteData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 47, 47 });

            migrationBuilder.DeleteData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 48, 48 });

            migrationBuilder.DeleteData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 49, 49 });

            migrationBuilder.DeleteData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 50, 50 });

            migrationBuilder.DeleteData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 51, 51 });

            migrationBuilder.DeleteData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 52, 52 });

            migrationBuilder.DeleteData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 53, 53 });

            migrationBuilder.DeleteData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 54, 54 });

            migrationBuilder.DeleteData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 55, 55 });

            migrationBuilder.DeleteData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 56, 56 });

            migrationBuilder.DeleteData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 57, 57 });

            migrationBuilder.DeleteData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 58, 58 });

            migrationBuilder.DeleteData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 59, 59 });

            migrationBuilder.DeleteData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 60, 60 });

            migrationBuilder.DeleteData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 61, 61 });

            migrationBuilder.DeleteData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 62, 62 });

            migrationBuilder.DeleteData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 63, 63 });

            migrationBuilder.DeleteData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 64, 64 });

            migrationBuilder.DeleteData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 65, 65 });

            migrationBuilder.DeleteData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 66, 66 });

            migrationBuilder.DeleteData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 67, 67 });

            migrationBuilder.DeleteData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 68, 68 });

            migrationBuilder.DeleteData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 69, 69 });

            migrationBuilder.DeleteData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 70, 70 });

            migrationBuilder.DeleteData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 71, 71 });

            migrationBuilder.DeleteData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 72, 72 });

            migrationBuilder.DeleteData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 73, 73 });

            migrationBuilder.DeleteData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 74, 74 });

            migrationBuilder.DeleteData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 75, 75 });

            migrationBuilder.DeleteData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 76, 76 });

            migrationBuilder.DeleteData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 77, 77 });

            migrationBuilder.DeleteData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 78, 78 });

            migrationBuilder.DeleteData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 79, 79 });

            migrationBuilder.DeleteData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 80, 80 });

            migrationBuilder.DeleteData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 81, 81 });

            migrationBuilder.DeleteData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 82, 82 });

            migrationBuilder.DeleteData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 83, 83 });

            migrationBuilder.DeleteData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 84, 84 });

            migrationBuilder.DeleteData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 85, 85 });

            migrationBuilder.DeleteData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 86, 86 });

            migrationBuilder.DeleteData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 87, 87 });

            migrationBuilder.DeleteData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 88, 88 });

            migrationBuilder.DeleteData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 89, 89 });

            migrationBuilder.DeleteData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 90, 90 });

            migrationBuilder.DeleteData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 91, 91 });

            migrationBuilder.DeleteData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 92, 92 });

            migrationBuilder.DeleteData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 93, 93 });

            migrationBuilder.DeleteData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 94, 94 });

            migrationBuilder.DeleteData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 95, 95 });

            migrationBuilder.DeleteData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 96, 96 });

            migrationBuilder.DeleteData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 97, 97 });

            migrationBuilder.DeleteData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 98, 98 });

            migrationBuilder.DeleteData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 99, 99 });

            migrationBuilder.DeleteData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 100, 100 });

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 4, 1 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 5, 1 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 6, 1 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 7, 2 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 8, 2 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 9, 2 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 10, 2 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 11, 1 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 12, 2 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 13, 2 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 14, 1 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 15, 2 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 16, 2 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 17, 1 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 18, 1 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 19, 1 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 20, 2 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 21, 1 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 22, 1 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 23, 2 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 24, 2 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 25, 2 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 26, 2 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 27, 2 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 28, 1 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 29, 1 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 30, 2 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 31, 1 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 32, 1 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 33, 2 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 34, 1 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 35, 2 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 36, 2 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 37, 2 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 38, 1 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 39, 1 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 40, 2 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 41, 2 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 42, 1 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 43, 1 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 44, 1 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 45, 2 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 46, 1 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 47, 1 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 48, 1 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 49, 1 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 50, 2 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 51, 2 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 52, 2 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 53, 2 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 54, 1 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 55, 1 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 56, 1 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 57, 2 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 58, 2 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 59, 2 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 60, 1 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 61, 1 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 62, 1 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 63, 1 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 64, 2 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 65, 2 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 66, 1 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 67, 2 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 68, 1 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 69, 1 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 70, 1 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 71, 2 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 72, 2 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 73, 1 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 74, 1 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 75, 1 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 76, 1 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 77, 1 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 78, 2 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 79, 2 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 80, 2 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 81, 1 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 82, 2 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 83, 1 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 84, 2 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 85, 1 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 86, 1 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 87, 2 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 88, 2 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 89, 1 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 90, 1 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 91, 1 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 92, 2 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 93, 1 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 94, 2 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 95, 1 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 96, 1 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 97, 2 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 98, 2 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 99, 1 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 100, 1 });

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "UserRole",
                keyColumn: "RoleID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Permission",
                keyColumn: "PermissionID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 100);

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "Provider");

            migrationBuilder.RenameTable(
                name: "UserRole",
                newName: "UserRoles");

            migrationBuilder.RenameTable(
                name: "User",
                newName: "Users");

            migrationBuilder.RenameTable(
                name: "SalesOrder",
                newName: "SalesOrders");

            migrationBuilder.RenameTable(
                name: "Provider",
                newName: "Providers");

            migrationBuilder.RenameTable(
                name: "Product",
                newName: "Products");

            migrationBuilder.RenameTable(
                name: "Permission",
                newName: "Permissions");

            migrationBuilder.RenameTable(
                name: "ImportOrder",
                newName: "ImportOrders");

            migrationBuilder.RenameTable(
                name: "DetailSalesOrder",
                newName: "DetailSalesOrders");

            migrationBuilder.RenameTable(
                name: "DetailImportOrder",
                newName: "DetailImportOrders");

            migrationBuilder.RenameTable(
                name: "AppInfo",
                newName: "AppInfos");

            migrationBuilder.RenameIndex(
                name: "IX_UserRole_RoleName",
                table: "UserRoles",
                newName: "IX_UserRoles_RoleName");

            migrationBuilder.RenameIndex(
                name: "IX_UserRole_PermissionID",
                table: "UserRoles",
                newName: "IX_UserRoles_PermissionID");

            migrationBuilder.RenameIndex(
                name: "IX_User_RoleID",
                table: "Users",
                newName: "IX_Users_RoleID");

            migrationBuilder.RenameIndex(
                name: "IX_User_Email",
                table: "Users",
                newName: "IX_Users_Email");

            migrationBuilder.RenameIndex(
                name: "IX_SalesOrder_EmployeeID",
                table: "SalesOrders",
                newName: "IX_SalesOrders_EmployeeID");

            migrationBuilder.RenameIndex(
                name: "IX_SalesOrder_CustomerID",
                table: "SalesOrders",
                newName: "IX_SalesOrders_CustomerID");

            migrationBuilder.RenameIndex(
                name: "IX_ImportOrder_ProviderID",
                table: "ImportOrders",
                newName: "IX_ImportOrders_ProviderID");

            migrationBuilder.RenameIndex(
                name: "IX_ImportOrder_EmployeeID",
                table: "ImportOrders",
                newName: "IX_ImportOrders_EmployeeID");

            migrationBuilder.RenameIndex(
                name: "IX_DetailSalesOrder_ProductID",
                table: "DetailSalesOrders",
                newName: "IX_DetailSalesOrders_ProductID");

            migrationBuilder.RenameIndex(
                name: "IX_DetailImportOrder_ProductID",
                table: "DetailImportOrders",
                newName: "IX_DetailImportOrders_ProductID");

            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "Employee",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "Customer",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Customer",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Customer",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "EmployeeID",
                table: "SalesOrders",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "Providers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Providers",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Providers",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<byte[]>(
                name: "ImageData",
                table: "Products",
                type: "varbinary(max)",
                nullable: false,
                defaultValue: new byte[0],
                oldClrType: typeof(byte[]),
                oldType: "varbinary(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CalculationUnit",
                table: "Products",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "EmployeeID",
                table: "ImportOrders",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "DetailOrderID",
                table: "DetailSalesOrders",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<decimal>(
                name: "TotalPrice",
                table: "DetailSalesOrders",
                type: "decimal(10,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "DetailOrderID",
                table: "DetailImportOrders",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<decimal>(
                name: "TotalPrice",
                table: "DetailImportOrders",
                type: "decimal(10,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserRoles",
                table: "UserRoles",
                column: "RoleID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                columns: new[] { "EmployeeID", "RoleID" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_SalesOrders",
                table: "SalesOrders",
                column: "OrderID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Providers",
                table: "Providers",
                column: "ProviderID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Products",
                table: "Products",
                column: "ProductID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Permissions",
                table: "Permissions",
                column: "PermissionID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ImportOrders",
                table: "ImportOrders",
                column: "OrderID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DetailSalesOrders",
                table: "DetailSalesOrders",
                column: "DetailOrderID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DetailImportOrders",
                table: "DetailImportOrders",
                column: "DetailOrderID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppInfos",
                table: "AppInfos",
                column: "AppName");

            migrationBuilder.UpdateData(
                table: "AppInfos",
                keyColumn: "AppName",
                keyValue: "Cửa hàng của bạn",
                column: "Address",
                value: "Hưng Yên");

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 1,
                columns: new[] { "CanCreateProduct", "CanCreateSalesOrder", "CanDeleteProduct", "CanExportSalesOrder", "CanPrintSalesOrder", "CanReadDetailImportOrder", "CanReadProduct", "CanReadSalesOrder", "CanUpdateProduct" },
                values: new object[] { false, false, false, false, false, true, false, false, false });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "RoleID",
                keyValue: 1,
                columns: new[] { "DateCreated", "RoleName" },
                values: new object[] { new DateTime(2023, 11, 24, 8, 37, 40, 618, DateTimeKind.Local).AddTicks(1611), "Nhân viên" });

            migrationBuilder.CreateIndex(
                name: "IX_DetailSalesOrders_OrderID",
                table: "DetailSalesOrders",
                column: "OrderID");

            migrationBuilder.CreateIndex(
                name: "IX_DetailImportOrders_OrderID",
                table: "DetailImportOrders",
                column: "OrderID");

            migrationBuilder.AddForeignKey(
                name: "FK_DetailImportOrders_ImportOrders_OrderID",
                table: "DetailImportOrders",
                column: "OrderID",
                principalTable: "ImportOrders",
                principalColumn: "OrderID",
                onDelete: ReferentialAction.Cascade);

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
                name: "FK_DetailSalesOrders_SalesOrders_OrderID",
                table: "DetailSalesOrders",
                column: "OrderID",
                principalTable: "SalesOrders",
                principalColumn: "OrderID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ImportOrders_Employee_EmployeeID",
                table: "ImportOrders",
                column: "EmployeeID",
                principalTable: "Employee",
                principalColumn: "EmployeeID");

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
                name: "FK_SalesOrders_Employee_EmployeeID",
                table: "SalesOrders",
                column: "EmployeeID",
                principalTable: "Employee",
                principalColumn: "EmployeeID");

            migrationBuilder.AddForeignKey(
                name: "FK_UserRoles_Permissions_PermissionID",
                table: "UserRoles",
                column: "PermissionID",
                principalTable: "Permissions",
                principalColumn: "PermissionID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Employee_EmployeeID",
                table: "Users",
                column: "EmployeeID",
                principalTable: "Employee",
                principalColumn: "EmployeeID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_UserRoles_RoleID",
                table: "Users",
                column: "RoleID",
                principalTable: "UserRoles",
                principalColumn: "RoleID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
