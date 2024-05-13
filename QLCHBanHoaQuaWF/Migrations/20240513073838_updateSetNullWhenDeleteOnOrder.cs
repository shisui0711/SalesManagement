using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace QLCHWF.Migrations
{
    /// <inheritdoc />
    public partial class updateSetNullWhenDeleteOnOrder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 5, 2 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 7, 2 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 8, 1 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 9, 2 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 10, 1 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 12, 1 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 16, 1 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 19, 2 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 22, 2 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 23, 2 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 26, 2 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 30, 2 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 32, 2 });

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
                keyValues: new object[] { 38, 1 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 39, 1 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 41, 2 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 42, 2 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 45, 1 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 46, 2 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 50, 1 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 54, 1 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 60, 2 });

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
                keyValues: new object[] { 63, 2 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 67, 1 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 70, 1 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 71, 1 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 72, 1 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 76, 2 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 79, 1 });

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
                keyValues: new object[] { 87, 2 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 89, 2 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 95, 2 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 96, 2 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 98, 1 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 100, 2 });

            migrationBuilder.AlterColumn<int>(
                name: "EmployeeID",
                table: "SalesOrder",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "CustomerID",
                table: "SalesOrder",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ProviderID",
                table: "ImportOrder",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "EmployeeID",
                table: "ImportOrder",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 1,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Hà Nam", "Phi Nhạn Phan", new DateTime(2024, 5, 13, 14, 38, 37, 98, DateTimeKind.Local).AddTicks(7800), "MyDiem67@hotmail.com", "0965109006" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 2,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Bạc Liêu", "Hồng Khuê Trần", new DateTime(2024, 5, 13, 14, 38, 37, 99, DateTimeKind.Local).AddTicks(2170), "NgocSuong.Ha@yahoo.com", "0967618282" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 3,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "An Giang", "Thúy Liên Đoàn", new DateTime(2024, 5, 13, 14, 38, 37, 99, DateTimeKind.Local).AddTicks(2515), "GiaHuan26@hotmail.com", "0988666553" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 4,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Bình Thuận", "Diệu Ngọc Lý", new DateTime(2024, 5, 13, 14, 38, 37, 99, DateTimeKind.Local).AddTicks(2844), "MinhHao_Truong28@hotmail.com", "0942806050" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 5,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Vĩnh Long", "Thanh Thủy Hoàng", new DateTime(2024, 5, 13, 14, 38, 37, 99, DateTimeKind.Local).AddTicks(3074), "ThanhAn53@hotmail.com", "0971167392" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 6,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Đắk Lắk", "Hiệp Dinh Hà", new DateTime(2024, 5, 13, 14, 38, 37, 99, DateTimeKind.Local).AddTicks(3376), "NhuKhang21@gmail.com", "0903658898" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 7,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Đồng Tháp", "Vĩnh Ân Đinh", new DateTime(2024, 5, 13, 14, 38, 37, 99, DateTimeKind.Local).AddTicks(3600), "TuongLan_Phan62@hotmail.com", "0961165317" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 8,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Kon Tum", "Diệu Hồng Vũ", new DateTime(2024, 5, 13, 14, 38, 37, 99, DateTimeKind.Local).AddTicks(3837), "TanDung44@gmail.com", "0921990351" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 9,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Thái Bình", "Thúy Vân Đoàn", new DateTime(2024, 5, 13, 14, 38, 37, 99, DateTimeKind.Local).AddTicks(4144), "TuyetTrinh.Nguyen@hotmail.com", "0902052930" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 10,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Hải Phòng", "Thất Dũng Trịnh", new DateTime(2024, 5, 13, 14, 38, 37, 99, DateTimeKind.Local).AddTicks(4502), "ThaiTam6@yahoo.com", "0978220355" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 11,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Quảng Nam", "Tiên Phương Mai", new DateTime(2024, 5, 13, 14, 38, 37, 99, DateTimeKind.Local).AddTicks(4708), "XuanLieu34@yahoo.com", "0900777543" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 12,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Khánh Hoà", "Việt Cương Phan", new DateTime(2024, 5, 13, 14, 38, 37, 99, DateTimeKind.Local).AddTicks(4891), "HongPhuc_Ly65@yahoo.com", "0920368707" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 13,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Nam Định", "Tuệ Mẫn Trần", new DateTime(2024, 5, 13, 14, 38, 37, 99, DateTimeKind.Local).AddTicks(5112), "HuongLy.Ho@yahoo.com", "0974891678" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 14,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Sơn La", "Vy Lam Đoàn", new DateTime(2024, 5, 13, 14, 38, 37, 99, DateTimeKind.Local).AddTicks(5275), "ThaiTan_Dang26@gmail.com", "0943693070" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 15,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Lai Châu", "Trọng Tường Lê", new DateTime(2024, 5, 13, 14, 38, 37, 99, DateTimeKind.Local).AddTicks(5470), "DucManh88@yahoo.com", "0920121880" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 16,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Nghệ An", "Xuân Loan Tô", new DateTime(2024, 5, 13, 14, 38, 37, 99, DateTimeKind.Local).AddTicks(5642), "HieuDung.Dao@gmail.com", "0963144763" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 17,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Cà Mau", "Thu Phương Trương", new DateTime(2024, 5, 13, 14, 38, 37, 99, DateTimeKind.Local).AddTicks(5859), "HaGiang_Phung@hotmail.com", "0938638699" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 18,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Thái Nguyên", "Đan Tâm Lâm", new DateTime(2024, 5, 13, 14, 38, 37, 99, DateTimeKind.Local).AddTicks(6041), "DiemHuong84@hotmail.com", "0906986971" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 19,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Bắc Ninh", "Thanh Nga Ngô", new DateTime(2024, 5, 13, 14, 38, 37, 99, DateTimeKind.Local).AddTicks(6225), "ThanhToan.Tang39@hotmail.com", "0937997679" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 20,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Hà Giang", "Trung Thực Trương", new DateTime(2024, 5, 13, 14, 38, 37, 99, DateTimeKind.Local).AddTicks(6452), "MaiHa_Ho93@gmail.com", "0962847393" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 21,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Đồng Tháp", "Uyên Minh Hoàng", new DateTime(2024, 5, 13, 14, 38, 37, 99, DateTimeKind.Local).AddTicks(6610), "TuyetNhung55@hotmail.com", "0909733402" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 22,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Bình Định", "Thanh Vy Dương", new DateTime(2024, 5, 13, 14, 38, 37, 99, DateTimeKind.Local).AddTicks(6803), "NgocVan8@yahoo.com", "0953304294" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 23,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Quảng Bình", "Thúy My Đinh", new DateTime(2024, 5, 13, 14, 38, 37, 99, DateTimeKind.Local).AddTicks(6975), "KimThuy_Dang49@yahoo.com", "0944232916" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 24,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Cà Mau", "Bảo Thoa Bùi", new DateTime(2024, 5, 13, 14, 38, 37, 99, DateTimeKind.Local).AddTicks(7208), "ManhThang_Bui52@hotmail.com", "0988251610" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 25,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Cà Mau", "Xuân Trang Đặng", new DateTime(2024, 5, 13, 14, 38, 37, 99, DateTimeKind.Local).AddTicks(7384), "ThienHung.Ngo32@gmail.com", "0962805009" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 26,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Nam Định", "Minh Vương Vương", new DateTime(2024, 5, 13, 14, 38, 37, 99, DateTimeKind.Local).AddTicks(7582), "NgocLe_Ho@gmail.com", "0909081636" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 27,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Thái Bình", "Ngọc Ẩn Đặng", new DateTime(2024, 5, 13, 14, 38, 37, 99, DateTimeKind.Local).AddTicks(7743), "KimKhanh_Phan@hotmail.com", "0962861298" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 28,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Quảng Bình", "Phương Triều Trịnh", new DateTime(2024, 5, 13, 14, 38, 37, 99, DateTimeKind.Local).AddTicks(8019), "AnhThai87@hotmail.com", "0965924736" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 29,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Sóc Trăng", "Quang Hữu Hoàng", new DateTime(2024, 5, 13, 14, 38, 37, 99, DateTimeKind.Local).AddTicks(8193), "VietThanh_Dao@gmail.com", "0993870097" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 30,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Ninh Thuận", "Thủy Hằng Lâm", new DateTime(2024, 5, 13, 14, 38, 37, 99, DateTimeKind.Local).AddTicks(8369), "GiaoLinh50@yahoo.com", "0939146036" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 31,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Sóc Trăng", "Thiên Phú Lê", new DateTime(2024, 5, 13, 14, 38, 37, 99, DateTimeKind.Local).AddTicks(8610), "TienGiang34@hotmail.com", "0987740979" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 32,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Lâm Đồng", "Thu Việt Phùng", new DateTime(2024, 5, 13, 14, 38, 37, 99, DateTimeKind.Local).AddTicks(8784), "AnBinh_Vu42@yahoo.com", "0958648164" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 33,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Lai Châu", "Mỹ Thuận Vũ", new DateTime(2024, 5, 13, 14, 38, 37, 99, DateTimeKind.Local).AddTicks(8968), "ThuyNhi4@yahoo.com", "0902026338" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 34,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Thừa Thiên-Huế", "Công Hào Trương", new DateTime(2024, 5, 13, 14, 38, 37, 99, DateTimeKind.Local).AddTicks(9130), "HongThinh.Truong@yahoo.com", "0985366587" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 35,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Hưng Yên", "Ngọc Hoa Đào", new DateTime(2024, 5, 13, 14, 38, 37, 99, DateTimeKind.Local).AddTicks(9352), "DinhCuong73@yahoo.com", "0985378728" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 36,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Hải Dương", "Hữu Trác Trần", new DateTime(2024, 5, 13, 14, 38, 37, 99, DateTimeKind.Local).AddTicks(9516), "ThanhLam.Tran98@hotmail.com", "0923083341" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 37,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Đắk Lắk", "Như Mai Lâm", new DateTime(2024, 5, 13, 14, 38, 37, 99, DateTimeKind.Local).AddTicks(9704), "AnhTho_Vuong@gmail.com", "0907575477" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 38,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Thái Bình", "Khánh Ðan Phùng", new DateTime(2024, 5, 13, 14, 38, 37, 99, DateTimeKind.Local).AddTicks(9853), "LienNhu.Doan67@gmail.com", "0921224284" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 39,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Tây Ninh", "Cao Thọ Tô", new DateTime(2024, 5, 13, 14, 38, 37, 100, DateTimeKind.Local).AddTicks(57), "KimDan_Ha54@gmail.com", "0945567071" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 40,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Hà Nội", "Yến Hồng Hồ", new DateTime(2024, 5, 13, 14, 38, 37, 100, DateTimeKind.Local).AddTicks(233), "ThuSuong.To64@yahoo.com", "0980960636" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 41,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Bắc Ninh", "Nam Ninh Ngô", new DateTime(2024, 5, 13, 14, 38, 37, 100, DateTimeKind.Local).AddTicks(387), "NhanHong89@gmail.com", "0992422894" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 42,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Quảng Ninh", "Ngọc Thuận Tăng", new DateTime(2024, 5, 13, 14, 38, 37, 100, DateTimeKind.Local).AddTicks(549), "MongLan22@yahoo.com", "0907078664" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 43,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Khánh Hoà", "Gia Cẩn Hà", new DateTime(2024, 5, 13, 14, 38, 37, 100, DateTimeKind.Local).AddTicks(722), "HoangViet_Phung@yahoo.com", "0998214686" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 44,
                columns: new[] { "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Kim Phượng Hồ", new DateTime(2024, 5, 13, 14, 38, 37, 100, DateTimeKind.Local).AddTicks(902), "HaiThuy_Ha@hotmail.com", "0981625818" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 45,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Vĩnh Phúc", "Hướng Thiện Đoàn", new DateTime(2024, 5, 13, 14, 38, 37, 100, DateTimeKind.Local).AddTicks(1055), "HoaMi_Ly@yahoo.com", "0925348651" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 46,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Hải Dương", "Sao Băng Trương", new DateTime(2024, 5, 13, 14, 38, 37, 100, DateTimeKind.Local).AddTicks(1211), "HongChau_Truong46@yahoo.com", "0982153161" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 47,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Thanh Hoá", "Quang Dương Tô", new DateTime(2024, 5, 13, 14, 38, 37, 100, DateTimeKind.Local).AddTicks(1407), "TrungLuc32@hotmail.com", "0977141257" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 48,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Bình Thuận", "Vân Ngọc Đinh", new DateTime(2024, 5, 13, 14, 38, 37, 100, DateTimeKind.Local).AddTicks(1572), "LeChi72@hotmail.com", "0910891484" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 49,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "An Giang", "Bích Thủy Đặng", new DateTime(2024, 5, 13, 14, 38, 37, 100, DateTimeKind.Local).AddTicks(1722), "TuDong57@hotmail.com", "0930125590" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 50,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Hà Giang", "Huyền Linh Hà", new DateTime(2024, 5, 13, 14, 38, 37, 100, DateTimeKind.Local).AddTicks(1877), "KienGiang.Vu73@gmail.com", "0930367161" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 51,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Kon Tum", "Duy Luận Phùng", new DateTime(2024, 5, 13, 14, 38, 37, 100, DateTimeKind.Local).AddTicks(2066), "ThanhY_Duong71@gmail.com", "0916648432" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 52,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Hậu Giang", "Quốc Toản Tăng", new DateTime(2024, 5, 13, 14, 38, 37, 100, DateTimeKind.Local).AddTicks(2216), "DucGiang_Ho23@hotmail.com", "0991301166" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 53,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Hà Giang", "Bích Loan Trương", new DateTime(2024, 5, 13, 14, 38, 37, 100, DateTimeKind.Local).AddTicks(2373), "HanhDung84@gmail.com", "0903083506" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 54,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Đồng Nai", "Bảo Huy Hà", new DateTime(2024, 5, 13, 14, 38, 37, 100, DateTimeKind.Local).AddTicks(2516), "NguyetCat.Bui@yahoo.com", "0901011573" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 55,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Hưng Yên", "Quang Linh Phạm", new DateTime(2024, 5, 13, 14, 38, 37, 100, DateTimeKind.Local).AddTicks(2687), "VietHoang.To@gmail.com", "0924198287" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 56,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Tuyên Quang", "Thanh Dân Vũ", new DateTime(2024, 5, 13, 14, 38, 37, 100, DateTimeKind.Local).AddTicks(2877), "BuuDiep.Dang71@gmail.com", "0940766518" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 57,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Phú Yên", "Gia Uy Đinh", new DateTime(2024, 5, 13, 14, 38, 37, 100, DateTimeKind.Local).AddTicks(3041), "DieuNuong_Dinh94@hotmail.com", "0981698301" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 58,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Tuyên Quang", "Cao Tiến Phạm", new DateTime(2024, 5, 13, 14, 38, 37, 100, DateTimeKind.Local).AddTicks(3192), "HanhLinh77@yahoo.com", "0914647151" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 59,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Đắk Lắk", "Thành Thiện Hồ", new DateTime(2024, 5, 13, 14, 38, 37, 100, DateTimeKind.Local).AddTicks(3372), "TuongNguyen_Le83@yahoo.com", "0921956732" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 60,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Hà Tĩnh", "Hải Miên Đỗ", new DateTime(2024, 5, 13, 14, 38, 37, 100, DateTimeKind.Local).AddTicks(3540), "DucQuyen26@hotmail.com", "0962538378" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 61,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Hà Tĩnh", "Nguyên Hạnh Đinh", new DateTime(2024, 5, 13, 14, 38, 37, 100, DateTimeKind.Local).AddTicks(3687), "DiemLoc18@yahoo.com", "0987183925" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 62,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Bà Rịa-Vũng Tàu", "Quang Thuận Lâm", new DateTime(2024, 5, 13, 14, 38, 37, 100, DateTimeKind.Local).AddTicks(3849), "HieuThong_Ngo19@hotmail.com", "0981269180" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 63,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Bắc Ninh", "Trân Châu Vương", new DateTime(2024, 5, 13, 14, 38, 37, 100, DateTimeKind.Local).AddTicks(4041), "QuangThai_Vu12@yahoo.com", "0919213122" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 64,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Sơn La", "Chánh Việt Phan", new DateTime(2024, 5, 13, 14, 38, 37, 100, DateTimeKind.Local).AddTicks(4204), "TruongThanh30@hotmail.com", "0930571148" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 65,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Bình Định", "Phi Long Hà", new DateTime(2024, 5, 13, 14, 38, 37, 100, DateTimeKind.Local).AddTicks(4359), "XuanThien_Hoang@hotmail.com", "0978813092" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 66,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Bình Phước", "Phi Hùng Tăng", new DateTime(2024, 5, 13, 14, 38, 37, 100, DateTimeKind.Local).AddTicks(4526), "KimDuyen95@yahoo.com", "0999744500" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 67,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Trà Vinh", "Hạnh Linh Lê", new DateTime(2024, 5, 13, 14, 38, 37, 100, DateTimeKind.Local).AddTicks(4679), "HuuCuong.Ly@gmail.com", "0954052544" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 68,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Hải Phòng", "Đan Thu Lý", new DateTime(2024, 5, 13, 14, 38, 37, 100, DateTimeKind.Local).AddTicks(4830), "ThuHoai13@yahoo.com", "0968163315" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 69,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Hòa Bình", "Tố Quyên Tô", new DateTime(2024, 5, 13, 14, 38, 37, 100, DateTimeKind.Local).AddTicks(4984), "DinhChieu_Le44@hotmail.com", "0903228756" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 70,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Lạng Sơn", "Bích Ty Vũ", new DateTime(2024, 5, 13, 14, 38, 37, 100, DateTimeKind.Local).AddTicks(5173), "HiepHao.Dao@gmail.com", "0967135722" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 71,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Bình Phước", "Duy Uyên Phan", new DateTime(2024, 5, 13, 14, 38, 37, 100, DateTimeKind.Local).AddTicks(5349), "XuanVan41@yahoo.com", "0909618004" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 72,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Đồng Tháp", "Tuyết Chi Đinh", new DateTime(2024, 5, 13, 14, 38, 37, 100, DateTimeKind.Local).AddTicks(5502), "DinhHop.Ngo@yahoo.com", "0964729005" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 73,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Trà Vinh", "Mộng Nguyệt Đinh", new DateTime(2024, 5, 13, 14, 38, 37, 100, DateTimeKind.Local).AddTicks(5667), "AnKhang.Do72@gmail.com", "0972869099" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 74,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Đà Nẵng", "Uy Vũ Nguyễn", new DateTime(2024, 5, 13, 14, 38, 37, 100, DateTimeKind.Local).AddTicks(5819), "TanThanh23@gmail.com", "0982622139" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 75,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Vĩnh Long", "Quảng Thông Đặng", new DateTime(2024, 5, 13, 14, 38, 37, 100, DateTimeKind.Local).AddTicks(5980), "YenThao_Truong@yahoo.com", "0986829392" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 76,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Hưng Yên", "Tấn Dũng Mai", new DateTime(2024, 5, 13, 14, 38, 37, 100, DateTimeKind.Local).AddTicks(6126), "KimTrang9@hotmail.com", "0996210378" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 77,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Ninh Bình", "Duy Hùng Đinh", new DateTime(2024, 5, 13, 14, 38, 37, 100, DateTimeKind.Local).AddTicks(6294), "DinhNhan67@gmail.com", "0932974643" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 78,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Yên Bái", "Thu Việt Phùng", new DateTime(2024, 5, 13, 14, 38, 37, 100, DateTimeKind.Local).AddTicks(6470), "NguyetAnh.Do80@gmail.com", "0949120856" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 79,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Hà Giang", "Tiền Giang Ngô", new DateTime(2024, 5, 13, 14, 38, 37, 100, DateTimeKind.Local).AddTicks(6634), "SongLam.Duong80@yahoo.com", "0903523645" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 80,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Bà Rịa-Vũng Tàu", "Kim Sơn Hà", new DateTime(2024, 5, 13, 14, 38, 37, 100, DateTimeKind.Local).AddTicks(6784), "PhuongLien_Truong75@gmail.com", "0985902910" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 81,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Hà Nam", "Xuân Uyên Phan", new DateTime(2024, 5, 13, 14, 38, 37, 100, DateTimeKind.Local).AddTicks(7044), "VietPhuong29@hotmail.com", "0935618235" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 82,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Quảng Nam", "Vân Du Tô", new DateTime(2024, 5, 13, 14, 38, 37, 100, DateTimeKind.Local).AddTicks(7229), "DacThanh42@yahoo.com", "0982824540" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 83,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Quảng Nam", "Thụy Du Lý", new DateTime(2024, 5, 13, 14, 38, 37, 100, DateTimeKind.Local).AddTicks(7373), "HoangHa69@yahoo.com", "0943002939" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 84,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Ninh Thuận", "Thiên Duyên Đinh", new DateTime(2024, 5, 13, 14, 38, 37, 100, DateTimeKind.Local).AddTicks(7540), "ThanhHoa.Vuong@yahoo.com", "0983291359" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 85,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Đắk Lắk", "Gia Linh Hoàng", new DateTime(2024, 5, 13, 14, 38, 37, 100, DateTimeKind.Local).AddTicks(7691), "PhungYen.Duong11@gmail.com", "0972253621" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 86,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Lạng Sơn", "Nghĩa Dũng Đinh", new DateTime(2024, 5, 13, 14, 38, 37, 100, DateTimeKind.Local).AddTicks(7866), "PhiNhung7@gmail.com", "0991059406" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 87,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Lạng Sơn", "Lan Nhi Phùng", new DateTime(2024, 5, 13, 14, 38, 37, 100, DateTimeKind.Local).AddTicks(8012), "HaNhi1@gmail.com", "0952095099" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 88,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Hải Phòng", "Hồng Trúc Dương", new DateTime(2024, 5, 13, 14, 38, 37, 100, DateTimeKind.Local).AddTicks(8168), "DieuAnh92@hotmail.com", "0955745750" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 89,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Vĩnh Phúc", "Thúy Nga Trịnh", new DateTime(2024, 5, 13, 14, 38, 37, 100, DateTimeKind.Local).AddTicks(8308), "HuuChau29@hotmail.com", "0901658314" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 90,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Ninh Bình", "Thành Ðệ Lâm", new DateTime(2024, 5, 13, 14, 38, 37, 100, DateTimeKind.Local).AddTicks(8547), "BinhThuan_Nguyen13@yahoo.com", "0921316438" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 91,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Thanh Hoá", "Khắc Việt Mai", new DateTime(2024, 5, 13, 14, 38, 37, 100, DateTimeKind.Local).AddTicks(8778), "PhucNguyen.Phung@yahoo.com", "0912516386" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 92,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Nghệ An", "Tâm Thanh Lý", new DateTime(2024, 5, 13, 14, 38, 37, 100, DateTimeKind.Local).AddTicks(8980), "LamDung.Do42@gmail.com", "0914012876" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 93,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Hà Nam", "Huỳnh Anh Lâm", new DateTime(2024, 5, 13, 14, 38, 37, 100, DateTimeKind.Local).AddTicks(9249), "MinhHuong7@yahoo.com", "0966064639" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 94,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Nghệ An", "Minh Tâm Đinh", new DateTime(2024, 5, 13, 14, 38, 37, 100, DateTimeKind.Local).AddTicks(9426), "YenLoan.Dang@hotmail.com", "0996741127" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 95,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Tây Ninh", "Công Án Đỗ", new DateTime(2024, 5, 13, 14, 38, 37, 100, DateTimeKind.Local).AddTicks(9593), "BichThoa.Doan@yahoo.com", "0979969163" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 96,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Hà Nội", "Ngọc Tú Đoàn", new DateTime(2024, 5, 13, 14, 38, 37, 100, DateTimeKind.Local).AddTicks(9730), "HuyAnh.Duong@gmail.com", "0992354886" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 97,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Hòa Bình", "Thế Năng Dương", new DateTime(2024, 5, 13, 14, 38, 37, 100, DateTimeKind.Local).AddTicks(9870), "MinhKiet.Dinh@hotmail.com", "0981321717" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 98,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Ninh Bình", "Tuyền Lâm Đặng", new DateTime(2024, 5, 13, 14, 38, 37, 101, DateTimeKind.Local).AddTicks(2), "BaoToan_Tang81@hotmail.com", "0967321380" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 99,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "TP. Hồ Chí Minh", "Gia Kiệt Vũ", new DateTime(2024, 5, 13, 14, 38, 37, 101, DateTimeKind.Local).AddTicks(149), "DienVy_Tang@hotmail.com", "0998979140" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 100,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Phú Yên", "Khánh Thủy Dương", new DateTime(2024, 5, 13, 14, 38, 37, 101, DateTimeKind.Local).AddTicks(329), "XuanThu_Dang@gmail.com", "0986513472" });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 192, 21582.572550588320000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 2, 2 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 124, 21850.484463779880000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 3, 3 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 134, 47586.182616159120000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 4, 4 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 192, 35942.483010855760000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 5, 5 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 149, 40960.514271888280000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 6, 6 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 188, 13499.7320024428680000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 7, 7 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 177, 16584.189266360920000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 8, 8 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 113, 10816.1300266665160000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 9, 9 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 136, 39691.415237129480000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 10, 10 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 184, 32499.421705724680000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 11, 11 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 187, 41990.136517357760000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 12, 12 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 169, 38706.576955975840000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 13, 13 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 155, 31043.197231486920000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 14, 14 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 196, 13803.5126073318480000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 15, 15 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 187, 40923.10060087440000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 16, 16 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 107, 32154.515940089720000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 17, 17 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 193, 26840.473003742160000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 18, 18 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 129, 24632.936679313920000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 19, 19 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 179, 29292.902120184680000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 20, 20 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 100, 13248.8284682952520000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 21, 21 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 124, 11662.7993482174040000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 22, 22 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 143, 27835.382240684560000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 23, 23 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 126, 15030.932116080160000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 24, 24 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 153, 10079.62834798506360000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 25, 25 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 177, 34947.066587977160000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 26, 26 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 169, 31020.860735692840000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 27, 27 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 100, 14106.111593099520000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 28, 28 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 181, 48913.897159717560000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 29, 29 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 138, 41776.414506400480000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 30, 30 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 155, 27398.916985201240000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 31, 31 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 196, 14570.867077992920000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 32, 32 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 125, 18578.012613612160000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 33, 33 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 141, 44008.661778543920000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 34, 34 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 175, 41068.187984706560000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 35, 35 },
                column: "UnitPrice",
                value: 22870.178848779520000m);

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 36, 36 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 148, 17266.046570141680000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 37, 37 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 178, 34024.165129026160000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 38, 38 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 136, 18937.137283172200000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 39, 39 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 158, 45497.029608958280000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 40, 40 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 199, 11860.6641769197280000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 41, 41 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 129, 44577.049375997880000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 42, 42 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 118, 13476.5886416096760000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 43, 43 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 188, 10321.77561178210920000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 44, 44 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 144, 43370.118309263720000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 45, 45 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 166, 12012.3875247807000000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 46, 46 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 137, 19749.183972815920000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 47, 47 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 120, 40560.572865639320000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 48, 48 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 132, 41047.883554979360000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 49, 49 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 100, 37341.698466926120000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 50, 50 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 103, 13527.5012892656080000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 51, 51 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 190, 26101.342249023120000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 52, 52 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 149, 30167.796517666480000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 53, 53 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 170, 40008.741035796880000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 54, 54 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 193, 20090.10412531920000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 55, 55 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 131, 39450.635165327480000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 56, 56 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 135, 30347.765495260760000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 57, 57 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 198, 25964.059979794440000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 58, 58 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 191, 40037.096916225480000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 59, 59 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 200, 21244.743457164200000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 60, 60 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 153, 46070.322223246480000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 61, 61 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 109, 31048.181750706760000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 62, 62 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 161, 37671.624663443760000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 63, 63 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 118, 29974.782771123760000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 64, 64 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 187, 13993.7494403778640000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 65, 65 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 158, 30803.954737921000000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 66, 66 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 197, 17947.170313531520000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 67, 67 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 148, 34789.206422630120000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 68, 68 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 157, 45349.700473241920000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 69, 69 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 135, 29017.137521097760000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 70, 70 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 146, 44705.063290285120000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 71, 71 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 189, 47643.615414626640000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 72, 72 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 153, 19235.923262663080000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 73, 73 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 174, 48838.961998373960000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 74, 74 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 171, 26329.688273424880000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 75, 75 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 118, 18218.221034065440000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 76, 76 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 126, 14022.338628492600000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 77, 77 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 146, 35256.817114844960000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 78, 78 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 130, 32073.011917227480000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 79, 79 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 114, 35530.074812163640000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 80, 80 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 114, 31412.536394652680000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 81, 81 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 107, 48460.479808653160000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 82, 82 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 111, 38617.907917450720000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 83, 83 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 170, 13328.3348608990600000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 84, 84 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 108, 30805.97783940480000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 85, 85 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 193, 37230.165511780440000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 86, 86 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 118, 27479.280447082240000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 87, 87 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 117, 48307.668567964640000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 88, 88 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 170, 14401.434858311760000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 89, 89 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 172, 43445.12856768960000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 90, 90 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 122, 47300.452813266320000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 91, 91 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 186, 35863.694762297640000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 92, 92 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 135, 28557.889624223920000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 93, 93 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 152, 18802.808933316560000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 94, 94 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 190, 34403.61473754120000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 95, 95 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 126, 25158.918332728520000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 96, 96 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 136, 24076.162967694080000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 97, 97 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 155, 46487.9842438120000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 98, 98 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 126, 29797.454014035560000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 99, 99 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 169, 15528.934842029360000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 100, 100 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 166, 47448.695126401360000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 78, 179865.404825107800000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 2, 2 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 55, 144212.56142162900000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 3, 3 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 52, 175756.884451639900000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 4, 4 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 57, 157650.191140973400000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 5, 5 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 78, 184877.937242765200000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 6, 6 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 71, 144725.967076565500000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 7, 7 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 66, 110627.098946932300000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 8, 8 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 77, 106542.3192424065700000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 9, 9 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 58, 103805.5386469370700000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 10, 10 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 85, 122937.493042206100000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 11, 11 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 88, 195746.113531192100000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 12, 12 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 60, 134008.306151083600000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 13, 13 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 72, 102034.5496143647300000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 14, 14 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 61, 149726.116094666900000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 15, 15 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 55, 135778.346728115300000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 16, 16 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 71, 196195.192986639300000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 17, 17 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 86, 106270.577697286800000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 18, 18 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 72, 114848.862498375800000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 19, 19 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 87, 175216.494972720300000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 20, 20 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 65, 108190.2673356748800000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 21, 21 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 80, 165066.672496256800000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 22, 22 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 72, 158268.813074824600000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 23, 23 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 56, 199292.992753639400000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 24, 24 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 82, 193957.973484207600000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 25, 25 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 85, 122401.181817004100000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 26, 26 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 77, 133850.486692100400000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 27, 27 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 71, 112966.644651312500000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 28, 28 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 50, 140722.760190656300000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 29, 29 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 89, 195951.07115735600000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 30, 30 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 70, 154517.816325231500000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 31, 31 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 81, 168837.067272602400000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 32, 32 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 60, 199448.481757203100000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 33, 33 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 90, 116593.527921084100000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 34, 34 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 53, 139179.099610308500000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 35, 35 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 84, 190643.406043551300000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 36, 36 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 55, 112090.077216163500000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 37, 37 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 63, 199005.173395353500000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 38, 38 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 52, 114331.88040087700000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 39, 39 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 64, 116218.839765677200000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 40, 40 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 81, 151666.126184863500000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 41, 41 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 77, 140458.6069231400000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 42, 42 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 73, 198101.259236479400000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 43, 43 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 57, 175861.245214189800000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 44, 44 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 69, 134283.563927800700000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 45, 45 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 61, 167789.846874594100000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 46, 46 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 86, 188048.321478427400000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 47, 47 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 57, 125839.208559766800000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 48, 48 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 80, 195146.005058969400000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 49, 49 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 86, 178827.268942096200000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 50, 50 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 68, 140662.006251246800000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 51, 51 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 58, 125572.77167008200000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 52, 52 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 59, 199731.44430264600000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 53, 53 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 51, 149644.437322656200000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 54, 54 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 58, 190454.026062503600000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 55, 55 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 82, 166910.884187622300000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 56, 56 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 66, 175646.001603358800000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 57, 57 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 82, 158621.139805017100000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 58, 58 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 65, 126370.872889124300000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 59, 59 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 50, 146335.878373540700000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 60, 60 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 83, 138805.249110038800000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 61, 61 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 90, 140496.246098662600000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 62, 62 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 82, 110504.710996245800000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 63, 63 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 82, 144588.404619093300000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 64, 64 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 65, 166630.396154742700000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 65, 65 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 65, 177931.371119991400000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 66, 66 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 67, 163230.245177881400000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 67, 67 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 76, 140395.544949094400000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 68, 68 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 86, 101301.524192390200000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 69, 69 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 78, 190497.24754527700000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 70, 70 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 74, 162276.3931748200000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 71, 71 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 77, 137441.842630758200000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 72, 72 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 59, 123214.499684686600000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 73, 73 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 89, 198466.093621885300000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 74, 74 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 84, 127358.268544054800000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 75, 75 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 52, 168408.073498090900000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 76, 76 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 62, 193423.051441324700000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 77, 77 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 73, 155730.324526951300000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 78, 78 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 69, 174072.388347199400000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 79, 79 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 68, 120755.478030430700000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 80, 80 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 71, 146415.482162061600000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 81, 81 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 89, 156785.759821908400000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 82, 82 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 76, 178643.441565756500000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 83, 83 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 69, 168557.896695038100000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 84, 84 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 74, 192413.119346500600000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 85, 85 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 83, 143009.550713715700000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 86, 86 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 66, 115446.3370717500000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 87, 87 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 61, 109605.2236761623900000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 88, 88 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 82, 190591.118221002800000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 89, 89 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 78, 189458.507145888600000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 90, 90 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 54, 169591.700809816800000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 91, 91 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 64, 166636.307357158100000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 92, 92 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 64, 114646.487695358800000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 93, 93 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 79, 117465.114320022900000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 94, 94 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 67, 167473.971209743800000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 95, 95 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 85, 187381.114421353900000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 96, 96 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 67, 112682.168872545900000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 97, 97 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 66, 103513.9869190387600000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 98, 98 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 80, 160330.32957091400000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 99, 99 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 52, 182302.182754327800000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 100, 100 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 71, 120256.779892499800000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 1,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Bình Phước", new DateTime(2024, 5, 13, 14, 38, 37, 130, DateTimeKind.Local).AddTicks(2555), "VietSon_Bui@hotmail.com", "Hải Yến Lê", "0922220004", 966242.128817180500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 2,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Nam Định", new DateTime(2024, 5, 13, 14, 38, 37, 130, DateTimeKind.Local).AddTicks(8943), "HaGiang.Dao2@hotmail.com", "Thúy Kiều Nguyễn", "0992756936", 705112.212426931500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 3,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Quảng Ninh", new DateTime(2024, 5, 13, 14, 38, 37, 130, DateTimeKind.Local).AddTicks(9180), "VyLam_Nguyen@yahoo.com", "Ngọc Tuyết Đoàn", "0963219140", 881688.696744249000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 4,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Hà Nội", new DateTime(2024, 5, 13, 14, 38, 37, 130, DateTimeKind.Local).AddTicks(9312), "ThaoVy81@gmail.com", "Thiên Thư Lâm", "0916109818", 974278.926629919000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 5,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Long An", new DateTime(2024, 5, 13, 14, 38, 37, 130, DateTimeKind.Local).AddTicks(9400), "DanKhanh_Tran@yahoo.com", "Ðình Dương Hoàng", "0952599593", 778142.972396210500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 6,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Quảng Nam", new DateTime(2024, 5, 13, 14, 38, 37, 130, DateTimeKind.Local).AddTicks(9504), "HuyTran_Duong@gmail.com", "Hà Giang Lý", "0937193985", 535114.18128992000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 7,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Quảng Bình", new DateTime(2024, 5, 13, 14, 38, 37, 130, DateTimeKind.Local).AddTicks(9620), "HuuCuong54@yahoo.com", "Chí Khang Tô", "0904093704", 839971.042002655500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 8,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Đồng Tháp", new DateTime(2024, 5, 13, 14, 38, 37, 130, DateTimeKind.Local).AddTicks(9703), "KieuTrinh_Tran79@yahoo.com", "Quỳnh Trâm Hà", "0985813689", 748471.434693578500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 9,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "TP. Hồ Chí Minh", new DateTime(2024, 5, 13, 14, 38, 37, 130, DateTimeKind.Local).AddTicks(9928), "TruongVu86@gmail.com", "Bạch Tuyết Tô", "0998804247", 916129.979491277000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 10,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Cần Thơ", new DateTime(2024, 5, 13, 14, 38, 37, 131, DateTimeKind.Local).AddTicks(68), "DuyLuan_Pham@gmail.com", "Thanh Ngọc Hà", "0974216125", 606242.808225682500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 11,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Bến Tre", new DateTime(2024, 5, 13, 14, 38, 37, 131, DateTimeKind.Local).AddTicks(170), "UyenVi.To@hotmail.com", "Ðông Hải Trương", "0938824606", 886962.367281872000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 12,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Hải Dương", new DateTime(2024, 5, 13, 14, 38, 37, 131, DateTimeKind.Local).AddTicks(279), "ThienLuan_Hoang40@hotmail.com", "Nguyệt Cầm Hoàng", "0972540351", 929994.673055742500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 13,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Bình Phước", new DateTime(2024, 5, 13, 14, 38, 37, 131, DateTimeKind.Local).AddTicks(371), "VietTan_Hoang@yahoo.com", "Ái Thy Đỗ", "0931800212", 810565.395506178000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 14,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Hưng Yên", new DateTime(2024, 5, 13, 14, 38, 37, 131, DateTimeKind.Local).AddTicks(481), "VinhLong_Dao@hotmail.com", "Kim Phượng Vũ", "0981192803", 509902.9335399271500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 15,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Tây Ninh", new DateTime(2024, 5, 13, 14, 38, 37, 131, DateTimeKind.Local).AddTicks(571), "BaThinh_Dao29@yahoo.com", "Khánh Chi Phùng", "0910478850", 538818.9137327409500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 16,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Quảng Nam", new DateTime(2024, 5, 13, 14, 38, 37, 131, DateTimeKind.Local).AddTicks(676), "MinhDan.Vu56@yahoo.com", "Kiệt Võ Tăng", "0933749289", 815666.825227282500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 17,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Bắc Giang", new DateTime(2024, 5, 13, 14, 38, 37, 131, DateTimeKind.Local).AddTicks(879), "CongLuat.Tang@yahoo.com", "Ngọc Vân Hà", "0957285244", 944664.416076158500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 18,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Hải Phòng", new DateTime(2024, 5, 13, 14, 38, 37, 131, DateTimeKind.Local).AddTicks(998), "ChiGiang.Nguyen@hotmail.com", "Bích Liên Ngô", "0951929461", 581009.687077189500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 19,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Hải Phòng", new DateTime(2024, 5, 13, 14, 38, 37, 131, DateTimeKind.Local).AddTicks(1093), "VietAnh42@yahoo.com", "Nam Phương Lê", "0940619648", 738229.734107629000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 20,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Quảng Ngãi", new DateTime(2024, 5, 13, 14, 38, 37, 131, DateTimeKind.Local).AddTicks(1273), "MongNguyet.Le@gmail.com", "Hải Ân Đoàn", "0984534979", 657015.827481201000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 21,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Phú Thọ", new DateTime(2024, 5, 13, 14, 38, 37, 131, DateTimeKind.Local).AddTicks(1376), "KimNgoc_Vuong@yahoo.com", "Gia Ân Dương", "0928508886", 510138.2368533361000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 22,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Thanh Hoá", new DateTime(2024, 5, 13, 14, 38, 37, 131, DateTimeKind.Local).AddTicks(1478), "ThuPhuong61@gmail.com", "Thất Cương Đỗ", "0991167799", 818886.07266515500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 23,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Thanh Hoá", new DateTime(2024, 5, 13, 14, 38, 37, 131, DateTimeKind.Local).AddTicks(1593), "GiangUyen.Bui92@yahoo.com", "Hồng Hà Đào", "0919549570", 582307.836793636000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 24,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Đắk Lắk", new DateTime(2024, 5, 13, 14, 38, 37, 131, DateTimeKind.Local).AddTicks(1690), "QuangXuan99@yahoo.com", "Tùng Anh Đoàn", "0908559673", 721162.692299767500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 25,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Thái Nguyên", new DateTime(2024, 5, 13, 14, 38, 37, 131, DateTimeKind.Local).AddTicks(1869), "AnhMai90@yahoo.com", "Nhật Mai Đỗ", "0964651931", 940733.9623147500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 26,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Tuyên Quang", new DateTime(2024, 5, 13, 14, 38, 37, 131, DateTimeKind.Local).AddTicks(2035), "OanhVu.Pham22@yahoo.com", "Lương Quyền Hoàng", "0943849420", 609017.991271001500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 27,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "An Giang", new DateTime(2024, 5, 13, 14, 38, 37, 131, DateTimeKind.Local).AddTicks(2134), "MongLan_Ha26@hotmail.com", "Thúy Liên Hoàng", "0992938946", 880175.517025068000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 28,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Đắk Nông", new DateTime(2024, 5, 13, 14, 38, 37, 131, DateTimeKind.Local).AddTicks(2242), "TuongLan98@hotmail.com", "Ðăng Ðạt Phạm", "0993774061", 641602.942243043500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 29,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Kiên Giang", new DateTime(2024, 5, 13, 14, 38, 37, 131, DateTimeKind.Local).AddTicks(2341), "VietThi.Phung83@hotmail.com", "Ngọc Ðào Tăng", "0964688192", 765769.262265184000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 30,
                columns: new[] { "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { new DateTime(2024, 5, 13, 14, 38, 37, 131, DateTimeKind.Local).AddTicks(2501), "TrieuThanh42@hotmail.com", "Thế Trung Tăng", "0973772805", 905598.534126059500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 31,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Quảng Ngãi", new DateTime(2024, 5, 13, 14, 38, 37, 131, DateTimeKind.Local).AddTicks(2607), "NgocLoan_Ha57@yahoo.com", "Gia Cẩn Lý", "0977008114", 860883.406290223000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 32,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Bắc Giang", new DateTime(2024, 5, 13, 14, 38, 37, 131, DateTimeKind.Local).AddTicks(2705), "ThuyDu_Truong@yahoo.com", "Quốc Khánh Đoàn", "0903591449", 581761.870415443500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 33,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Hà Giang", new DateTime(2024, 5, 13, 14, 38, 37, 131, DateTimeKind.Local).AddTicks(2867), "CuongThinh15@gmail.com", "Cao Thọ Lê", "0995127215", 533383.8947344004000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 34,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Bạc Liêu", new DateTime(2024, 5, 13, 14, 38, 37, 131, DateTimeKind.Local).AddTicks(3043), "LinhSan8@yahoo.com", "Mỹ Phương Ngô", "0938710780", 590563.142377901000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 35,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Đồng Tháp", new DateTime(2024, 5, 13, 14, 38, 37, 131, DateTimeKind.Local).AddTicks(3183), "MaiHa.Bui@yahoo.com", "Ngọc Tuấn Trần", "0976566292", 715069.193936118000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 36,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Nghệ An", new DateTime(2024, 5, 13, 14, 38, 37, 131, DateTimeKind.Local).AddTicks(3360), "ThanhTin_Dinh@hotmail.com", "Mộc Miên Tăng", "0933583119", 759450.433759604500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 37,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "An Giang", new DateTime(2024, 5, 13, 14, 38, 37, 131, DateTimeKind.Local).AddTicks(3457), "NguyenHong68@hotmail.com", "Hạ Uyên Dương", "0960378866", 812902.353127009000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 38,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Lào Cai", new DateTime(2024, 5, 13, 14, 38, 37, 131, DateTimeKind.Local).AddTicks(3549), "AnhTuan.Tang9@hotmail.com", "Hoàng Mỹ Lâm", "0963696008", 902965.809230066500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 39,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Lạng Sơn", new DateTime(2024, 5, 13, 14, 38, 37, 131, DateTimeKind.Local).AddTicks(3665), "HongGiang.Truong25@hotmail.com", "Thủy Trang Lý", "0946444639", 970138.964619852500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 40,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Lào Cai", new DateTime(2024, 5, 13, 14, 38, 37, 131, DateTimeKind.Local).AddTicks(3859), "ThuHau.Bui@yahoo.com", "Bảo Thúy Bùi", "0939226280", 612074.220513737000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 41,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Vĩnh Phúc", new DateTime(2024, 5, 13, 14, 38, 37, 131, DateTimeKind.Local).AddTicks(3957), "KimPhuong.To@gmail.com", "Gia Khiêm Lý", "0907987185", 876122.185430070500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 42,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Đồng Tháp", new DateTime(2024, 5, 13, 14, 38, 37, 131, DateTimeKind.Local).AddTicks(4069), "BinhDat.Trinh@yahoo.com", "Trúc Quỳnh Vũ", "0993052465", 873986.382423764000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 43,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Tuyên Quang", new DateTime(2024, 5, 13, 14, 38, 37, 131, DateTimeKind.Local).AddTicks(4263), "XuanNghi.Trinh91@yahoo.com", "Hoàng Long Mai", "0922664638", 878676.344888539500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 44,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Đồng Tháp", new DateTime(2024, 5, 13, 14, 38, 37, 131, DateTimeKind.Local).AddTicks(4359), "CongHai62@yahoo.com", "Thúy Ngọc Đỗ", "0914000309", 984508.425999702500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 45,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Hà Giang", new DateTime(2024, 5, 13, 14, 38, 37, 131, DateTimeKind.Local).AddTicks(4469), "ThuDuyen.Phung62@hotmail.com", "Gia Phúc Nguyễn", "0978025927", 948929.446518507500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 46,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Bắc Ninh", new DateTime(2024, 5, 13, 14, 38, 37, 131, DateTimeKind.Local).AddTicks(4561), "HuuKhoat23@yahoo.com", "Hồng Thảo Phan", "0925849601", 863856.588778791500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 47,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Tiền Giang", new DateTime(2024, 5, 13, 14, 38, 37, 131, DateTimeKind.Local).AddTicks(4647), "MinhGiang32@yahoo.com", "Mai Anh Tăng", "0992891901", 786648.792408288500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 48,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Hậu Giang", new DateTime(2024, 5, 13, 14, 38, 37, 131, DateTimeKind.Local).AddTicks(4753), "YenSon89@gmail.com", "Dân Hiệp Đỗ", "0976380243", 850192.885325952000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 49,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Cà Mau", new DateTime(2024, 5, 13, 14, 38, 37, 131, DateTimeKind.Local).AddTicks(4845), "MinhMinh21@hotmail.com", "Lam Hà Phạm", "0935993744", 983570.598102317000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 50,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Bạc Liêu", new DateTime(2024, 5, 13, 14, 38, 37, 131, DateTimeKind.Local).AddTicks(4993), "XuanHien_Dao@hotmail.com", "Trí Tịnh Trần", "0980311118", 609355.913507393500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 51,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Bình Phước", new DateTime(2024, 5, 13, 14, 38, 37, 131, DateTimeKind.Local).AddTicks(5077), "HaiBang71@yahoo.com", "Giang Thanh Đào", "0916430717", 744972.331760733000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 52,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Điện Biên", new DateTime(2024, 5, 13, 14, 38, 37, 131, DateTimeKind.Local).AddTicks(5404), "LocUyen_Tang18@yahoo.com", "Thiên Di Phạm", "0979170778", 784543.497955711500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 53,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Bắc Ninh", new DateTime(2024, 5, 13, 14, 38, 37, 131, DateTimeKind.Local).AddTicks(5528), "LamDong.Tran@gmail.com", "Tường Lân Ngô", "0993523430", 886353.76582649500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 54,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Hưng Yên", new DateTime(2024, 5, 13, 14, 38, 37, 131, DateTimeKind.Local).AddTicks(5619), "DiemLien26@yahoo.com", "Ðình Ngân Hồ", "0983047720", 532503.8672340741000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 55,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Phú Thọ", new DateTime(2024, 5, 13, 14, 38, 37, 131, DateTimeKind.Local).AddTicks(5701), "DinhQuang19@gmail.com", "Việt Long Lâm", "0968700247", 680769.744074499000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 56,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Kiên Giang", new DateTime(2024, 5, 13, 14, 38, 37, 131, DateTimeKind.Local).AddTicks(5871), "PhuongNgoc.Ho@yahoo.com", "Lệ Nhi Lâm", "0980802581", 749857.113555121500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 57,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Bắc Ninh", new DateTime(2024, 5, 13, 14, 38, 37, 131, DateTimeKind.Local).AddTicks(5959), "DiemChi5@hotmail.com", "Gia Bảo Lý", "0959046700", 972828.58967924500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 58,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Ninh Bình", new DateTime(2024, 5, 13, 14, 38, 37, 131, DateTimeKind.Local).AddTicks(6038), "KimDan_Doan@yahoo.com", "Hoàng Xuân Vương", "0967747003", 625700.424551088500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 59,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Đồng Nai", new DateTime(2024, 5, 13, 14, 38, 37, 131, DateTimeKind.Local).AddTicks(6133), "TruongThanh.Phan@hotmail.com", "Trúc Ly Lê", "0937147851", 876339.067222691000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 60,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Tây Ninh", new DateTime(2024, 5, 13, 14, 38, 37, 131, DateTimeKind.Local).AddTicks(6215), "DaiTrang.To92@gmail.com", "Trọng Khánh Hà", "0984037854", 675671.769614034000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 61,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Sóc Trăng", new DateTime(2024, 5, 13, 14, 38, 37, 131, DateTimeKind.Local).AddTicks(6328), "NgocHoan40@gmail.com", "Khánh Quỳnh Vũ", "0989934631", 724651.706246565500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 62,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Thái Nguyên", new DateTime(2024, 5, 13, 14, 38, 37, 131, DateTimeKind.Local).AddTicks(6429), "DanKhanh.To26@gmail.com", "Cường Dũng Vương", "0988468815", 582256.497204981500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 63,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Bắc Kạn", new DateTime(2024, 5, 13, 14, 38, 37, 131, DateTimeKind.Local).AddTicks(6521), "CongGiang.Mai38@hotmail.com", "Tấn Phát Vương", "0930752130", 550645.100426541500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 64,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Quảng Bình", new DateTime(2024, 5, 13, 14, 38, 37, 131, DateTimeKind.Local).AddTicks(6657), "HuuNghi61@yahoo.com", "Phú Bình Đào", "0925608846", 725428.019411469000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 65,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Tiền Giang", new DateTime(2024, 5, 13, 14, 38, 37, 131, DateTimeKind.Local).AddTicks(6753), "DongNghi60@gmail.com", "Uyên Thơ Dương", "0901908694", 705287.720274143000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 66,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Thái Bình", new DateTime(2024, 5, 13, 14, 38, 37, 131, DateTimeKind.Local).AddTicks(6847), "HieuNghia11@yahoo.com", "Nguyệt Anh Bùi", "0912618540", 615015.367094163500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 67,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Yên Bái", new DateTime(2024, 5, 13, 14, 38, 37, 131, DateTimeKind.Local).AddTicks(7005), "VietTuyet.Tran89@hotmail.com", "Nam Ninh Đỗ", "0988967803", 849344.439169183000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 68,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Phú Yên", new DateTime(2024, 5, 13, 14, 38, 37, 131, DateTimeKind.Local).AddTicks(7098), "TanLoi.To5@yahoo.com", "Mộng Vy Lý", "0985760724", 518922.5374059304500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 69,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Cao Bằng", new DateTime(2024, 5, 13, 14, 38, 37, 131, DateTimeKind.Local).AddTicks(7194), "MinhKhoi2@gmail.com", "Vĩnh Long Đinh", "0964078392", 605363.773936816500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 70,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Khánh Hoà", new DateTime(2024, 5, 13, 14, 38, 37, 131, DateTimeKind.Local).AddTicks(7307), "ThuNhan35@gmail.com", "Hoa Tiên Trần", "0994947585", 653135.726607384000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 71,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Phú Yên", new DateTime(2024, 5, 13, 14, 38, 37, 131, DateTimeKind.Local).AddTicks(7393), "ThuyVan_Ha53@gmail.com", "Quang Linh Trịnh", "0913270183", 533106.2781259739000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 72,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Quảng Ninh", new DateTime(2024, 5, 13, 14, 38, 37, 131, DateTimeKind.Local).AddTicks(7528), "NguyenPhong_Dang@hotmail.com", "Khánh Minh Lâm", "0907894844", 753986.168050577000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 73,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Thừa Thiên-Huế", new DateTime(2024, 5, 13, 14, 38, 37, 131, DateTimeKind.Local).AddTicks(7618), "ThaiLan58@gmail.com", "Yên Mai Trịnh", "0960350032", 656066.099961794000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 74,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Bình Thuận", new DateTime(2024, 5, 13, 14, 38, 37, 131, DateTimeKind.Local).AddTicks(7707), "AiKhanh49@hotmail.com", "Kim Chi Đỗ", "0978908709", 929001.323870769500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 75,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Ninh Bình", new DateTime(2024, 5, 13, 14, 38, 37, 131, DateTimeKind.Local).AddTicks(7857), "GiaHuan_Truong89@yahoo.com", "Phương Triều Hoàng", "0972324894", 693223.350620431500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 76,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Kiên Giang", new DateTime(2024, 5, 13, 14, 38, 37, 131, DateTimeKind.Local).AddTicks(7943), "ThuanToan.Vu40@yahoo.com", "Trung Chính Dương", "0922373862", 777207.542015567000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 77,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Lào Cai", new DateTime(2024, 5, 13, 14, 38, 37, 131, DateTimeKind.Local).AddTicks(8048), "HuyenAnh.Phung80@hotmail.com", "Chí Dũng Vũ", "0902148994", 703517.290201303000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 78,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Sóc Trăng", new DateTime(2024, 5, 13, 14, 38, 37, 131, DateTimeKind.Local).AddTicks(8148), "PhuongTram.Le@hotmail.com", "Việt Anh Đinh", "0930848384", 935816.756303676500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 79,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Trà Vinh", new DateTime(2024, 5, 13, 14, 38, 37, 131, DateTimeKind.Local).AddTicks(8236), "CuongThinh_Nguyen46@hotmail.com", "Thanh Thu Đinh", "0934121452", 711353.109405563500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 80,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Kon Tum", new DateTime(2024, 5, 13, 14, 38, 37, 131, DateTimeKind.Local).AddTicks(8324), "AnhThao_Ngo@hotmail.com", "Quang Khanh Phan", "0927474939", 671218.492286086000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 81,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Thái Bình", new DateTime(2024, 5, 13, 14, 38, 37, 131, DateTimeKind.Local).AddTicks(8424), "NgocHien_Pham78@hotmail.com", "Vân Thường Đỗ", "0972394565", 962286.042374496500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 82,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Hà Nam", new DateTime(2024, 5, 13, 14, 38, 37, 131, DateTimeKind.Local).AddTicks(8512), "MinhHuyen38@hotmail.com", "Đông Vy Bùi", "0984696656", 591524.127481104000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 83,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Khánh Hoà", new DateTime(2024, 5, 13, 14, 38, 37, 131, DateTimeKind.Local).AddTicks(8612), "MyHuong.Dinh@hotmail.com", "Duyên My Hồ", "0913472380", 694540.212206950500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 84,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Bắc Giang", new DateTime(2024, 5, 13, 14, 38, 37, 131, DateTimeKind.Local).AddTicks(8705), "QuocAnh70@yahoo.com", "Quang Ðức Vương", "0932127712", 591580.273999833500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 85,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Thái Nguyên", new DateTime(2024, 5, 13, 14, 38, 37, 131, DateTimeKind.Local).AddTicks(8806), "TuyAnh.To@yahoo.com", "Anh Duy Đào", "0959768100", 564805.822052419000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 86,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Vĩnh Long", new DateTime(2024, 5, 13, 14, 38, 37, 131, DateTimeKind.Local).AddTicks(8921), "BaTruc56@hotmail.com", "Thiện Phước Hoàng", "0918567738", 913280.85527964000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 87,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Lào Cai", new DateTime(2024, 5, 13, 14, 38, 37, 131, DateTimeKind.Local).AddTicks(9010), "LanNhi_Tran99@yahoo.com", "Phượng Tiên Bùi", "0935140417", 919835.124047305500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 88,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "An Giang", new DateTime(2024, 5, 13, 14, 38, 37, 131, DateTimeKind.Local).AddTicks(9097), "MinhKhanh_Ly69@hotmail.com", "Mộng Long Lê", "0915328780", 680626.943098903000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 89,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Đắk Nông", new DateTime(2024, 5, 13, 14, 38, 37, 131, DateTimeKind.Local).AddTicks(9195), "KieuHoa_Doan64@gmail.com", "Lệ Băng Vương", "0919192657", 679484.200154478000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 90,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Tây Ninh", new DateTime(2024, 5, 13, 14, 38, 37, 131, DateTimeKind.Local).AddTicks(9283), "NamSon.Pham@gmail.com", "Từ Ân Tô", "0948238981", 867930.277470570500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 91,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Đắk Nông", new DateTime(2024, 5, 13, 14, 38, 37, 131, DateTimeKind.Local).AddTicks(9371), "ThanhThe95@hotmail.com", "Việt Phương Hà", "0979435484", 773502.985412990500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 92,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Quảng Ngãi", new DateTime(2024, 5, 13, 14, 38, 37, 131, DateTimeKind.Local).AddTicks(9472), "QuynhGiao_Vu@hotmail.com", "Phượng Liên Hoàng", "0905042102", 613267.570164427500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 93,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Phú Yên", new DateTime(2024, 5, 13, 14, 38, 37, 131, DateTimeKind.Local).AddTicks(9576), "NhatLan_Hoang@gmail.com", "Chấn Hùng Đoàn", "0922400865", 672811.594143692500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 94,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Tiền Giang", new DateTime(2024, 5, 13, 14, 38, 37, 131, DateTimeKind.Local).AddTicks(9667), "PhuocLoc_Ho45@gmail.com", "Nguyên Thảo Dương", "0921231419", 791523.952661186500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 95,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Đồng Tháp", new DateTime(2024, 5, 13, 14, 38, 37, 131, DateTimeKind.Local).AddTicks(9764), "PhuongVy_Tran45@yahoo.com", "Kỳ Anh Phùng", "0928248652", 770727.502449538000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 96,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Quảng Nam", new DateTime(2024, 5, 13, 14, 38, 37, 131, DateTimeKind.Local).AddTicks(9851), "VinhToan.Pham21@gmail.com", "Kiều Anh Phùng", "0922866050", 731491.741606173500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 97,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Phú Thọ", new DateTime(2024, 5, 13, 14, 38, 37, 131, DateTimeKind.Local).AddTicks(9950), "PhiCuong.Ngo70@yahoo.com", "Phương Ngọc Nguyễn", "0915039832", 599021.586059014500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 98,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Bắc Giang", new DateTime(2024, 5, 13, 14, 38, 37, 132, DateTimeKind.Local).AddTicks(38), "DanQue_Truong@yahoo.com", "Ðình Phúc Vương", "0946756285", 952107.254833551500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 99,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Phú Yên", new DateTime(2024, 5, 13, 14, 38, 37, 132, DateTimeKind.Local).AddTicks(123), "NhatKhuong.To@hotmail.com", "Hải Thụy Tăng", "0947370393", 589525.460528276000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 100,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Quảng Nam", new DateTime(2024, 5, 13, 14, 38, 37, 132, DateTimeKind.Local).AddTicks(211), "CamHuong4@hotmail.com", "Duy Tân Phùng", "0920386150", 981943.391882063500000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 1,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 62, new DateTime(2024, 5, 27, 18, 54, 19, 192, DateTimeKind.Unspecified).AddTicks(3019), 34, 4143853.929712957440000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 2,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 46, new DateTime(2024, 5, 7, 16, 21, 13, 662, DateTimeKind.Unspecified).AddTicks(1203), 46, 2709460.073508705120000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 3,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 13, new DateTime(2024, 5, 19, 12, 34, 53, 68, DateTimeKind.Unspecified).AddTicks(1327), 15, 6376548.470565322080000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 4,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 78, new DateTime(2024, 5, 14, 20, 23, 27, 649, DateTimeKind.Unspecified).AddTicks(4105), 87, 6900956.738084305920000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 5,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 84, new DateTime(2024, 5, 9, 0, 29, 12, 286, DateTimeKind.Unspecified).AddTicks(1634), 54, 6103116.626511353720000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 6,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 78, new DateTime(2024, 5, 16, 19, 6, 27, 398, DateTimeKind.Unspecified).AddTicks(1140), 22, 2537949.6164592591840000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 7,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 20, new DateTime(2024, 5, 14, 4, 22, 47, 475, DateTimeKind.Unspecified).AddTicks(8801), 13, 2935401.500145882840000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 8,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 86, new DateTime(2024, 5, 22, 23, 53, 21, 390, DateTimeKind.Unspecified).AddTicks(5661), 36, 1222222.6930133163080000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 9,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 5, new DateTime(2024, 5, 20, 15, 1, 48, 488, DateTimeKind.Unspecified).AddTicks(3344), 93, 5398032.472249609280000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 10,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 43, new DateTime(2024, 5, 22, 2, 8, 55, 919, DateTimeKind.Unspecified).AddTicks(5787), 66, 5979893.593853341120000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 11,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 1, new DateTime(2024, 5, 9, 10, 3, 33, 901, DateTimeKind.Unspecified).AddTicks(720), 3, 7852155.528745901120000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 12,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 60, new DateTime(2024, 5, 11, 9, 22, 34, 688, DateTimeKind.Unspecified).AddTicks(9294), 27, 6541411.505559916960000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 13,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 5, new DateTime(2024, 5, 23, 12, 1, 27, 582, DateTimeKind.Unspecified).AddTicks(5079), 27, 4811695.570880472600000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 14,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 22, new DateTime(2024, 5, 4, 23, 5, 31, 26, DateTimeKind.Unspecified).AddTicks(8114), 87, 2705488.4710370422080000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 15,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 19, new DateTime(2024, 5, 9, 3, 34, 49, 427, DateTimeKind.Unspecified).AddTicks(1123), 40, 7652619.81236351280000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 16,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 17, new DateTime(2024, 5, 12, 6, 52, 59, 488, DateTimeKind.Unspecified).AddTicks(330), 36, 3440533.205589600040000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 17,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 34, new DateTime(2024, 5, 23, 10, 34, 17, 656, DateTimeKind.Unspecified).AddTicks(9807), 3, 5180211.289722236880000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 18,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 26, new DateTime(2024, 5, 15, 20, 37, 26, 122, DateTimeKind.Unspecified).AddTicks(3331), 90, 3177648.831631495680000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 19,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 63, new DateTime(2024, 5, 16, 2, 54, 52, 623, DateTimeKind.Unspecified).AddTicks(4789), 45, 5243429.479513057720000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 20,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 60, new DateTime(2024, 5, 26, 21, 41, 14, 755, DateTimeKind.Unspecified).AddTicks(4178), 2, 1324882.8468295252000000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 21,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 100, new DateTime(2024, 5, 25, 16, 6, 38, 511, DateTimeKind.Unspecified).AddTicks(533), 36, 1446187.1191789580960000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 22,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 32, new DateTime(2024, 5, 7, 21, 5, 51, 914, DateTimeKind.Unspecified).AddTicks(4151), 95, 3980459.660417892080000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 23,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 71, new DateTime(2024, 5, 12, 17, 36, 6, 436, DateTimeKind.Unspecified).AddTicks(3342), 59, 1893897.446626100160000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 24,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 70, new DateTime(2024, 5, 9, 20, 20, 41, 212, DateTimeKind.Unspecified).AddTicks(6040), 43, 1542183.13724171473080000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 25,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 4, new DateTime(2024, 5, 5, 5, 44, 38, 339, DateTimeKind.Unspecified).AddTicks(3120), 19, 6185630.786071957320000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 26,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 83, new DateTime(2024, 5, 2, 10, 48, 38, 926, DateTimeKind.Unspecified).AddTicks(3176), 9, 5242525.464332089960000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 27,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 69, new DateTime(2024, 5, 25, 1, 47, 45, 514, DateTimeKind.Unspecified).AddTicks(4049), 3, 1410611.159309952000000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 28,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 55, new DateTime(2024, 5, 29, 12, 32, 27, 540, DateTimeKind.Unspecified).AddTicks(2745), 36, 8853415.385908878360000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 29,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 92, new DateTime(2024, 5, 20, 13, 9, 54, 845, DateTimeKind.Unspecified).AddTicks(7191), 35, 5765145.201883266240000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 30,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 20, new DateTime(2024, 5, 11, 11, 4, 56, 632, DateTimeKind.Unspecified).AddTicks(308), 97, 4246832.132706192200000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 31,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 43, new DateTime(2024, 5, 14, 21, 38, 45, 791, DateTimeKind.Unspecified).AddTicks(3400), 76, 2855889.947286612320000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 32,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 43, new DateTime(2024, 5, 11, 19, 36, 57, 334, DateTimeKind.Unspecified).AddTicks(5024), 92, 2322251.576701520000000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 33,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 7, new DateTime(2024, 5, 21, 6, 26, 47, 829, DateTimeKind.Unspecified).AddTicks(8085), 89, 6205221.310774692720000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 34,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 75, new DateTime(2024, 5, 23, 23, 54, 49, 948, DateTimeKind.Unspecified).AddTicks(6006), 89, 7186932.897323648000000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 35,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 86, new DateTime(2024, 5, 25, 14, 15, 52, 523, DateTimeKind.Unspecified).AddTicks(4858), 6, 3270435.575375471360000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 36,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 25, new DateTime(2024, 5, 5, 13, 24, 4, 170, DateTimeKind.Unspecified).AddTicks(4391), 41, 2555374.892380968640000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 37,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 86, new DateTime(2024, 5, 28, 0, 47, 43, 366, DateTimeKind.Unspecified).AddTicks(1255), 61, 6056301.392966656480000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 38,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 67, new DateTime(2024, 5, 8, 15, 36, 15, 4, DateTimeKind.Unspecified).AddTicks(6322), 84, 2575450.670511419200000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 39,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 76, new DateTime(2024, 5, 6, 7, 49, 38, 574, DateTimeKind.Unspecified).AddTicks(5399), 84, 7188530.678215408240000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 40,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 5, new DateTime(2024, 5, 27, 0, 31, 42, 689, DateTimeKind.Unspecified).AddTicks(9492), 10, 2360272.1712070258720000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 41,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 57, new DateTime(2024, 5, 11, 11, 53, 27, 813, DateTimeKind.Unspecified).AddTicks(3577), 4, 5750439.369503726520000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 42,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 33, new DateTime(2024, 5, 6, 17, 58, 48, 932, DateTimeKind.Unspecified).AddTicks(6324), 66, 1590237.4597099417680000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 43,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 15, new DateTime(2024, 5, 23, 9, 5, 4, 222, DateTimeKind.Unspecified).AddTicks(278), 15, 1940493.81501503652960000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 44,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 13, new DateTime(2024, 5, 1, 5, 18, 26, 358, DateTimeKind.Unspecified).AddTicks(7393), 95, 6245297.036533975680000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 45,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 31, new DateTime(2024, 5, 15, 17, 21, 40, 34, DateTimeKind.Unspecified).AddTicks(3045), 8, 1994056.3291135962000000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 46,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 51, new DateTime(2024, 5, 25, 11, 22, 47, 883, DateTimeKind.Unspecified).AddTicks(280), 63, 2705638.204275781040000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 47,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 86, new DateTime(2024, 5, 22, 8, 12, 41, 270, DateTimeKind.Unspecified).AddTicks(5279), 40, 4867268.743876718400000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 48,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 84, new DateTime(2024, 5, 22, 16, 8, 24, 704, DateTimeKind.Unspecified).AddTicks(1638), 40, 5418320.629257275520000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 49,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 63, new DateTime(2024, 5, 17, 9, 21, 8, 711, DateTimeKind.Unspecified).AddTicks(563), 79, 3734169.846692612000000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 50,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 32, new DateTime(2024, 5, 26, 8, 45, 30, 441, DateTimeKind.Unspecified).AddTicks(5962), 100, 1393332.6327943576240000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 51,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 21, new DateTime(2024, 5, 19, 12, 58, 42, 566, DateTimeKind.Unspecified).AddTicks(8854), 42, 4959255.027314392800000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 52,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 29, new DateTime(2024, 5, 23, 18, 46, 5, 778, DateTimeKind.Unspecified).AddTicks(7092), 100, 4495001.681132305520000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 53,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 5, new DateTime(2024, 5, 5, 13, 37, 33, 679, DateTimeKind.Unspecified).AddTicks(9452), 85, 6801485.976085469600000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 54,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 92, new DateTime(2024, 5, 19, 0, 4, 36, 721, DateTimeKind.Unspecified).AddTicks(9340), 25, 3877390.09618660560000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 55,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 80, new DateTime(2024, 5, 15, 17, 10, 28, 194, DateTimeKind.Unspecified).AddTicks(2928), 81, 5168033.206657899880000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 56,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 28, new DateTime(2024, 5, 22, 9, 58, 16, 135, DateTimeKind.Unspecified).AddTicks(2670), 94, 4096948.341860202600000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 57,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 94, new DateTime(2024, 5, 6, 6, 58, 13, 490, DateTimeKind.Unspecified).AddTicks(4734), 70, 5140883.875999299120000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 58,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 61, new DateTime(2024, 5, 14, 10, 3, 40, 914, DateTimeKind.Unspecified).AddTicks(3906), 88, 7647085.510999066680000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 59,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 17, new DateTime(2024, 5, 7, 20, 52, 32, 925, DateTimeKind.Unspecified).AddTicks(4148), 73, 4248948.691432840000000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 60,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 97, new DateTime(2024, 5, 7, 8, 54, 20, 367, DateTimeKind.Unspecified).AddTicks(6090), 100, 7048759.300156711440000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 61,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 54, new DateTime(2024, 5, 15, 12, 44, 12, 360, DateTimeKind.Unspecified).AddTicks(3248), 68, 3384251.810827036840000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 62,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 78, new DateTime(2024, 5, 16, 3, 6, 27, 58, DateTimeKind.Unspecified).AddTicks(9199), 41, 6065131.570814445360000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 63,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 65, new DateTime(2024, 5, 25, 20, 48, 11, 524, DateTimeKind.Unspecified).AddTicks(4323), 32, 3537024.366992603680000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 64,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 52, new DateTime(2024, 5, 14, 18, 10, 2, 778, DateTimeKind.Unspecified).AddTicks(7647), 69, 2616831.1453506605680000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 65,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 91, new DateTime(2024, 5, 6, 3, 49, 4, 695, DateTimeKind.Unspecified).AddTicks(9839), 11, 4867024.848591518000000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 66,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 48, new DateTime(2024, 5, 4, 6, 50, 57, 368, DateTimeKind.Unspecified).AddTicks(53), 83, 3535592.551765709440000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 67,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 87, new DateTime(2024, 5, 26, 6, 10, 46, 230, DateTimeKind.Unspecified).AddTicks(2152), 80, 5148802.550549257760000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 68,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 59, new DateTime(2024, 5, 28, 12, 13, 8, 997, DateTimeKind.Unspecified).AddTicks(106), 19, 7119902.974298981440000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 69,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 38, new DateTime(2024, 5, 5, 13, 30, 12, 845, DateTimeKind.Unspecified).AddTicks(3314), 50, 3917313.565348197600000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 70,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 28, new DateTime(2024, 5, 14, 21, 8, 39, 656, DateTimeKind.Unspecified).AddTicks(2796), 43, 6526939.240381627520000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 71,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 30, new DateTime(2024, 5, 15, 5, 32, 36, 363, DateTimeKind.Unspecified).AddTicks(8530), 99, 9004643.313364434960000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 72,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 61, new DateTime(2024, 5, 21, 14, 21, 58, 301, DateTimeKind.Unspecified).AddTicks(6644), 53, 2943096.259187451240000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 73,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 11, new DateTime(2024, 5, 11, 5, 33, 24, 441, DateTimeKind.Unspecified).AddTicks(9751), 83, 8497979.387717069040000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 74,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 91, new DateTime(2024, 5, 2, 17, 3, 1, 884, DateTimeKind.Unspecified).AddTicks(5384), 46, 4502376.694755654480000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 75,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 92, new DateTime(2024, 5, 4, 7, 59, 39, 939, DateTimeKind.Unspecified).AddTicks(2853), 59, 2149750.082019721920000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 76,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 99, new DateTime(2024, 5, 26, 16, 19, 26, 956, DateTimeKind.Unspecified).AddTicks(2460), 35, 1766814.667190067600000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 77,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 68, new DateTime(2024, 5, 3, 5, 10, 0, 305, DateTimeKind.Unspecified).AddTicks(7577), 79, 5147495.298767364160000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 78,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 88, new DateTime(2024, 5, 7, 17, 1, 27, 971, DateTimeKind.Unspecified).AddTicks(8653), 26, 4169491.549239572400000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 79,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 97, new DateTime(2024, 5, 12, 14, 42, 49, 184, DateTimeKind.Unspecified).AddTicks(4467), 30, 4050428.528586654960000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 80,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 53, new DateTime(2024, 5, 20, 10, 44, 8, 608, DateTimeKind.Unspecified).AddTicks(7591), 60, 3581029.148990405520000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 81,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 63, new DateTime(2024, 5, 26, 8, 40, 22, 498, DateTimeKind.Unspecified).AddTicks(2212), 79, 5185271.339525888120000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 82,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 7, new DateTime(2024, 5, 8, 18, 23, 46, 940, DateTimeKind.Unspecified).AddTicks(2271), 95, 4286587.778837029920000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 83,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 44, new DateTime(2024, 5, 2, 11, 11, 56, 507, DateTimeKind.Unspecified).AddTicks(9973), 60, 2265816.9263528402000000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 84,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 91, new DateTime(2024, 5, 28, 13, 44, 26, 598, DateTimeKind.Unspecified).AddTicks(8366), 12, 3327045.60665571840000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 85,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 8, new DateTime(2024, 5, 22, 12, 45, 52, 389, DateTimeKind.Unspecified).AddTicks(3297), 46, 7185421.943773624920000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 86,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 84, new DateTime(2024, 5, 11, 3, 4, 46, 317, DateTimeKind.Unspecified).AddTicks(6813), 6, 3242555.092755704320000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 87,
                columns: new[] { "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { new DateTime(2024, 5, 2, 10, 22, 47, 337, DateTimeKind.Unspecified).AddTicks(2278), 77, 5651997.222451862880000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 88,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 91, new DateTime(2024, 5, 20, 6, 51, 8, 165, DateTimeKind.Unspecified).AddTicks(1478), 45, 2448243.925912999200000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 89,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 20, new DateTime(2024, 5, 29, 22, 21, 15, 676, DateTimeKind.Unspecified).AddTicks(7295), 86, 7472562.11364261120000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 90,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 20, new DateTime(2024, 5, 14, 4, 20, 12, 347, DateTimeKind.Unspecified).AddTicks(9092), 12, 5770655.243218491040000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 91,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 62, new DateTime(2024, 5, 8, 11, 28, 10, 427, DateTimeKind.Unspecified).AddTicks(4411), 2, 6670647.225787361040000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 92,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 41, new DateTime(2024, 5, 14, 21, 18, 54, 21, DateTimeKind.Unspecified).AddTicks(6796), 38, 3855315.099270229200000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 93,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 12, new DateTime(2024, 5, 22, 9, 30, 38, 967, DateTimeKind.Unspecified).AddTicks(4263), 98, 2858026.957864117120000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 94,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 80, new DateTime(2024, 5, 9, 11, 11, 27, 787, DateTimeKind.Unspecified).AddTicks(396), 77, 6536686.80013282800000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 95,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 63, new DateTime(2024, 5, 28, 23, 21, 59, 689, DateTimeKind.Unspecified).AddTicks(186), 92, 3170023.709923793520000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 96,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 54, new DateTime(2024, 5, 25, 17, 29, 56, 438, DateTimeKind.Unspecified).AddTicks(6505), 40, 3274358.163606394880000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 97,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 65, new DateTime(2024, 5, 9, 21, 25, 34, 254, DateTimeKind.Unspecified).AddTicks(7557), 34, 7205637.5577908600000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 98,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 23, new DateTime(2024, 5, 1, 13, 40, 10, 468, DateTimeKind.Unspecified).AddTicks(3119), 88, 3754479.205768480560000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 99,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 48, new DateTime(2024, 5, 29, 10, 22, 40, 238, DateTimeKind.Unspecified).AddTicks(4623), 99, 2624389.988302961840000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 100,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 57, new DateTime(2024, 5, 29, 17, 9, 46, 300, DateTimeKind.Unspecified).AddTicks(7274), 63, 7876483.390982625760000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 13, 14, 38, 37, 135, DateTimeKind.Local).AddTicks(2487), 21582.572550588320000m, 114, 179865.404825107800000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 2,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 13, 14, 38, 37, 135, DateTimeKind.Local).AddTicks(7038), 21850.484463779880000m, 69, 144212.56142162900000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 3,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 13, 14, 38, 37, 135, DateTimeKind.Local).AddTicks(7099), 47586.182616159120000m, 82, 175756.884451639900000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 4,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 13, 14, 38, 37, 135, DateTimeKind.Local).AddTicks(7120), 35942.483010855760000m, 135, 157650.191140973400000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 5,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 13, 14, 38, 37, 135, DateTimeKind.Local).AddTicks(7140), 40960.514271888280000m, 71, 184877.937242765200000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 6,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 13, 14, 38, 37, 135, DateTimeKind.Local).AddTicks(7160), 13499.7320024428680000m, 117, 144725.967076565500000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 7,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 13, 14, 38, 37, 135, DateTimeKind.Local).AddTicks(7186), 16584.189266360920000m, 111, 110627.098946932300000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 8,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 13, 14, 38, 37, 135, DateTimeKind.Local).AddTicks(7206), 10816.1300266665160000m, 36, 106542.3192424065700000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 9,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 13, 14, 38, 37, 135, DateTimeKind.Local).AddTicks(7227), 39691.415237129480000m, 78, 103805.5386469370700000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 10,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 13, 14, 38, 37, 135, DateTimeKind.Local).AddTicks(7249), 32499.421705724680000m, 99, 122937.493042206100000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 11,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 13, 14, 38, 37, 135, DateTimeKind.Local).AddTicks(7266), 41990.136517357760000m, 99, 195746.113531192100000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 12,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 13, 14, 38, 37, 135, DateTimeKind.Local).AddTicks(7287), 38706.576955975840000m, 109, 134008.306151083600000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 13,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 13, 14, 38, 37, 135, DateTimeKind.Local).AddTicks(7307), 31043.197231486920000m, 83, 102034.5496143647300000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 14,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 13, 14, 38, 37, 135, DateTimeKind.Local).AddTicks(7329), 13803.5126073318480000m, 135, 149726.116094666900000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 15,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 13, 14, 38, 37, 135, DateTimeKind.Local).AddTicks(7349), 40923.10060087440000m, 132, 135778.346728115300000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 16,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 13, 14, 38, 37, 135, DateTimeKind.Local).AddTicks(7415), 32154.515940089720000m, 36, 196195.192986639300000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 17,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 13, 14, 38, 37, 135, DateTimeKind.Local).AddTicks(7436), 26840.473003742160000m, 107, 106270.577697286800000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 18,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 13, 14, 38, 37, 135, DateTimeKind.Local).AddTicks(7456), 24632.936679313920000m, 57, 114848.862498375800000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 19,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 13, 14, 38, 37, 135, DateTimeKind.Local).AddTicks(7477), 29292.902120184680000m, 92, 175216.494972720300000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 20,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 13, 14, 38, 37, 135, DateTimeKind.Local).AddTicks(7496), 13248.8284682952520000m, 35, 108190.2673356748800000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 21,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 13, 14, 38, 37, 135, DateTimeKind.Local).AddTicks(7517), 11662.7993482174040000m, 44, 165066.672496256800000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 22,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 13, 14, 38, 37, 135, DateTimeKind.Local).AddTicks(7538), 27835.382240684560000m, 71, 158268.813074824600000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 23,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 13, 14, 38, 37, 135, DateTimeKind.Local).AddTicks(7559), 15030.932116080160000m, 70, 199292.992753639400000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 24,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 13, 14, 38, 37, 135, DateTimeKind.Local).AddTicks(7579), 10079.62834798506360000m, 71, 193957.973484207600000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 25,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 13, 14, 38, 37, 135, DateTimeKind.Local).AddTicks(7598), 34947.066587977160000m, 92, 122401.181817004100000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 26,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 13, 14, 38, 37, 135, DateTimeKind.Local).AddTicks(7617), 31020.860735692840000m, 92, 133850.486692100400000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 27,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 13, 14, 38, 37, 135, DateTimeKind.Local).AddTicks(7636), 14106.111593099520000m, 29, 112966.644651312500000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 28,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 13, 14, 38, 37, 135, DateTimeKind.Local).AddTicks(7655), 48913.897159717560000m, 131, 140722.760190656300000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 29,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 13, 14, 38, 37, 135, DateTimeKind.Local).AddTicks(7674), 41776.414506400480000m, 49, 195951.07115735600000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 30,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 13, 14, 38, 37, 135, DateTimeKind.Local).AddTicks(7694), 27398.916985201240000m, 85, 154517.816325231500000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 31,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 13, 14, 38, 37, 135, DateTimeKind.Local).AddTicks(7714), 14570.867077992920000m, 115, 168837.067272602400000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 32,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 13, 14, 38, 37, 135, DateTimeKind.Local).AddTicks(7733), 18578.012613612160000m, 65, 199448.481757203100000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 33,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 13, 14, 38, 37, 135, DateTimeKind.Local).AddTicks(7751), 44008.661778543920000m, 51, 116593.527921084100000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 34,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 13, 14, 38, 37, 135, DateTimeKind.Local).AddTicks(7771), 41068.187984706560000m, 122, 139179.099610308500000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 35,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 13, 14, 38, 37, 135, DateTimeKind.Local).AddTicks(7791), 22870.178848779520000m, 59, 190643.406043551300000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 36,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 13, 14, 38, 37, 135, DateTimeKind.Local).AddTicks(7810), 17266.046570141680000m, 93, 112090.077216163500000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 37,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 13, 14, 38, 37, 135, DateTimeKind.Local).AddTicks(7830), 34024.165129026160000m, 115, 199005.173395353500000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 38,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 13, 14, 38, 37, 135, DateTimeKind.Local).AddTicks(7849), 18937.137283172200000m, 84, 114331.88040087700000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 39,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 13, 14, 38, 37, 135, DateTimeKind.Local).AddTicks(7868), 45497.029608958280000m, 94, 116218.839765677200000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 40,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 13, 14, 38, 37, 135, DateTimeKind.Local).AddTicks(7887), 11860.6641769197280000m, 118, 151666.126184863500000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 41,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 13, 14, 38, 37, 135, DateTimeKind.Local).AddTicks(7906), 44577.049375997880000m, 52, 140458.6069231400000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 42,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 13, 14, 38, 37, 135, DateTimeKind.Local).AddTicks(7926), 13476.5886416096760000m, 45, 198101.259236479400000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 43,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 13, 14, 38, 37, 135, DateTimeKind.Local).AddTicks(7945), 10321.77561178210920000m, 131, 175861.245214189800000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 44,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 13, 14, 38, 37, 135, DateTimeKind.Local).AddTicks(7965), 43370.118309263720000m, 75, 134283.563927800700000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 45,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 13, 14, 38, 37, 135, DateTimeKind.Local).AddTicks(7995), 12012.3875247807000000m, 105, 167789.846874594100000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 46,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 13, 14, 38, 37, 135, DateTimeKind.Local).AddTicks(8015), 19749.183972815920000m, 51, 188048.321478427400000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 47,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 13, 14, 38, 37, 135, DateTimeKind.Local).AddTicks(8034), 40560.572865639320000m, 63, 125839.208559766800000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 48,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 13, 14, 38, 37, 135, DateTimeKind.Local).AddTicks(8052), 41047.883554979360000m, 52, 195146.005058969400000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 49,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 13, 14, 38, 37, 135, DateTimeKind.Local).AddTicks(8072), 37341.698466926120000m, 14, 178827.268942096200000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 50,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 13, 14, 38, 37, 135, DateTimeKind.Local).AddTicks(8091), 13527.5012892656080000m, 35, 140662.006251246800000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 51,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 13, 14, 38, 37, 135, DateTimeKind.Local).AddTicks(8111), 26101.342249023120000m, 132, 125572.77167008200000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 52,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 13, 14, 38, 37, 135, DateTimeKind.Local).AddTicks(8130), 30167.796517666480000m, 90, 199731.44430264600000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 53,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 13, 14, 38, 37, 135, DateTimeKind.Local).AddTicks(8149), 40008.741035796880000m, 119, 149644.437322656200000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 54,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 13, 14, 38, 37, 135, DateTimeKind.Local).AddTicks(8168), 20090.10412531920000m, 135, 190454.026062503600000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 55,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 13, 14, 38, 37, 135, DateTimeKind.Local).AddTicks(8188), 39450.635165327480000m, 49, 166910.884187622300000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 56,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 13, 14, 38, 37, 135, DateTimeKind.Local).AddTicks(8224), 30347.765495260760000m, 69, 175646.001603358800000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 57,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 13, 14, 38, 37, 135, DateTimeKind.Local).AddTicks(8243), 25964.059979794440000m, 116, 158621.139805017100000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 58,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 13, 14, 38, 37, 135, DateTimeKind.Local).AddTicks(8262), 40037.096916225480000m, 126, 126370.872889124300000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 59,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 13, 14, 38, 37, 135, DateTimeKind.Local).AddTicks(8282), 21244.743457164200000m, 150, 146335.878373540700000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 60,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 13, 14, 38, 37, 135, DateTimeKind.Local).AddTicks(8302), 46070.322223246480000m, 70, 138805.249110038800000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 61,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 13, 14, 38, 37, 135, DateTimeKind.Local).AddTicks(8322), 31048.181750706760000m, 19, 140496.246098662600000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 62,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 13, 14, 38, 37, 135, DateTimeKind.Local).AddTicks(8343), 37671.624663443760000m, 79, 110504.710996245800000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 63,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 13, 14, 38, 37, 135, DateTimeKind.Local).AddTicks(8363), 29974.782771123760000m, 36, 144588.404619093300000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 64,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 13, 14, 38, 37, 135, DateTimeKind.Local).AddTicks(8383), 13993.7494403778640000m, 122, 166630.396154742700000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 65,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 13, 14, 38, 37, 135, DateTimeKind.Local).AddTicks(8402), 30803.954737921000000m, 93, 177931.371119991400000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 66,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 13, 14, 38, 37, 135, DateTimeKind.Local).AddTicks(8421), 17947.170313531520000m, 130, 163230.245177881400000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 67,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 13, 14, 38, 37, 135, DateTimeKind.Local).AddTicks(8441), 34789.206422630120000m, 72, 140395.544949094400000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 68,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 13, 14, 38, 37, 135, DateTimeKind.Local).AddTicks(8460), 45349.700473241920000m, 71, 101301.524192390200000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 69,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 13, 14, 38, 37, 135, DateTimeKind.Local).AddTicks(8480), 29017.137521097760000m, 57, 190497.24754527700000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 70,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 13, 14, 38, 37, 135, DateTimeKind.Local).AddTicks(8500), 44705.063290285120000m, 72, 162276.3931748200000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 71,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 13, 14, 38, 37, 135, DateTimeKind.Local).AddTicks(8520), 47643.615414626640000m, 112, 137441.842630758200000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 72,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 13, 14, 38, 37, 135, DateTimeKind.Local).AddTicks(8540), 19235.923262663080000m, 94, 123214.499684686600000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 73,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 13, 14, 38, 37, 135, DateTimeKind.Local).AddTicks(8559), 48838.961998373960000m, 85, 198466.093621885300000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 74,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 13, 14, 38, 37, 135, DateTimeKind.Local).AddTicks(8579), 26329.688273424880000m, 87, 127358.268544054800000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 75,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 13, 14, 38, 37, 135, DateTimeKind.Local).AddTicks(8611), 18218.221034065440000m, 66, 168408.073498090900000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 76,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 13, 14, 38, 37, 135, DateTimeKind.Local).AddTicks(8631), 14022.338628492600000m, 64, 193423.051441324700000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 77,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 13, 14, 38, 37, 135, DateTimeKind.Local).AddTicks(8650), 35256.817114844960000m, 73, 155730.324526951300000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 78,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 13, 14, 38, 37, 135, DateTimeKind.Local).AddTicks(8670), 32073.011917227480000m, 61, 174072.388347199400000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 79,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 13, 14, 38, 37, 135, DateTimeKind.Local).AddTicks(8689), 35530.074812163640000m, 46, 120755.478030430700000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 80,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 13, 14, 38, 37, 135, DateTimeKind.Local).AddTicks(8708), 31412.536394652680000m, 43, 146415.482162061600000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 81,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 13, 14, 38, 37, 135, DateTimeKind.Local).AddTicks(8727), 48460.479808653160000m, 18, 156785.759821908400000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 82,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 13, 14, 38, 37, 135, DateTimeKind.Local).AddTicks(8746), 38617.907917450720000m, 35, 178643.441565756500000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 83,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 13, 14, 38, 37, 135, DateTimeKind.Local).AddTicks(8766), 13328.3348608990600000m, 101, 168557.896695038100000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 84,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 13, 14, 38, 37, 135, DateTimeKind.Local).AddTicks(8785), 30805.97783940480000m, 34, 192413.119346500600000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 85,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 13, 14, 38, 37, 135, DateTimeKind.Local).AddTicks(8804), 37230.165511780440000m, 110, 143009.550713715700000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 86,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 13, 14, 38, 37, 135, DateTimeKind.Local).AddTicks(8843), 27479.280447082240000m, 52, 115446.3370717500000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 87,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 13, 14, 38, 37, 135, DateTimeKind.Local).AddTicks(8864), 48307.668567964640000m, 56, 109605.2236761623900000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 88,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 13, 14, 38, 37, 135, DateTimeKind.Local).AddTicks(8884), 14401.434858311760000m, 88, 190591.118221002800000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 89,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 13, 14, 38, 37, 135, DateTimeKind.Local).AddTicks(8903), 43445.12856768960000m, 94, 189458.507145888600000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 90,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 13, 14, 38, 37, 135, DateTimeKind.Local).AddTicks(8923), 47300.452813266320000m, 68, 169591.700809816800000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 91,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 13, 14, 38, 37, 135, DateTimeKind.Local).AddTicks(8943), 35863.694762297640000m, 122, 166636.307357158100000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 92,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 13, 14, 38, 37, 135, DateTimeKind.Local).AddTicks(8962), 28557.889624223920000m, 71, 114646.487695358800000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 93,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 13, 14, 38, 37, 135, DateTimeKind.Local).AddTicks(8982), 18802.808933316560000m, 73, 117465.114320022900000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 94,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 13, 14, 38, 37, 135, DateTimeKind.Local).AddTicks(9000), 34403.61473754120000m, 123, 167473.971209743800000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 95,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 13, 14, 38, 37, 135, DateTimeKind.Local).AddTicks(9019), 25158.918332728520000m, 41, 187381.114421353900000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 96,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 13, 14, 38, 37, 135, DateTimeKind.Local).AddTicks(9038), 24076.162967694080000m, 69, 112682.168872545900000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 97,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 13, 14, 38, 37, 135, DateTimeKind.Local).AddTicks(9057), 46487.9842438120000m, 89, 103513.9869190387600000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 98,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 13, 14, 38, 37, 135, DateTimeKind.Local).AddTicks(9077), 29797.454014035560000m, 46, 160330.32957091400000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 99,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 13, 14, 38, 37, 135, DateTimeKind.Local).AddTicks(9097), 15528.934842029360000m, 117, 182302.182754327800000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 100,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 13, 14, 38, 37, 135, DateTimeKind.Local).AddTicks(9116), 47448.695126401360000m, 95, 120256.779892499800000m });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 1,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Hưng Yên", new DateTime(2024, 5, 13, 14, 38, 37, 104, DateTimeKind.Local).AddTicks(8296), "BachDu_Ha@hotmail.com", "0929743716", "Bảo An Vương" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 2,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "TP. Hồ Chí Minh", new DateTime(2024, 5, 13, 14, 38, 37, 105, DateTimeKind.Local).AddTicks(2052), "NhaKhanh47@hotmail.com", "0911665777", "Hồng Minh Bùi" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 3,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Hậu Giang", new DateTime(2024, 5, 13, 14, 38, 37, 105, DateTimeKind.Local).AddTicks(2349), "ThienMy_Dang95@hotmail.com", "0925240137", "Bá Thịnh Vũ" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 4,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Thái Bình", new DateTime(2024, 5, 13, 14, 38, 37, 105, DateTimeKind.Local).AddTicks(2598), "HaiThuy.Tran@yahoo.com", "0938690884", "Thanh Nhung Vũ" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 5,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Điện Biên", new DateTime(2024, 5, 13, 14, 38, 37, 105, DateTimeKind.Local).AddTicks(2792), "VanHuong_Truong34@yahoo.com", "0979284107", "Phương Nhung Đỗ" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 6,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Lạng Sơn", new DateTime(2024, 5, 13, 14, 38, 37, 105, DateTimeKind.Local).AddTicks(3010), "BaoThai_Do36@yahoo.com", "0948723220", "Bích Thoa Phạm" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 7,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Đồng Nai", new DateTime(2024, 5, 13, 14, 38, 37, 105, DateTimeKind.Local).AddTicks(3172), "TheLuc_Tran@hotmail.com", "0960655153", "Hải My Hồ" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 8,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Thanh Hoá", new DateTime(2024, 5, 13, 14, 38, 37, 105, DateTimeKind.Local).AddTicks(3341), "DuyHoang_Doan55@gmail.com", "0938400686", "Minh Vũ Trần" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 9,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Đắk Lắk", new DateTime(2024, 5, 13, 14, 38, 37, 105, DateTimeKind.Local).AddTicks(3529), "ThaoHuong.Mai0@yahoo.com", "0964488470", "Cẩm Ly Trương" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 10,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Bình Phước", new DateTime(2024, 5, 13, 14, 38, 37, 105, DateTimeKind.Local).AddTicks(3746), "QueAnh91@hotmail.com", "0952212501", "Thanh Nhã Trương" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 11,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Đà Nẵng", new DateTime(2024, 5, 13, 14, 38, 37, 105, DateTimeKind.Local).AddTicks(3912), "ThiNgon_Ho20@gmail.com", "0976192627", "Hải Duyên Trương" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 12,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Yên Bái", new DateTime(2024, 5, 13, 14, 38, 37, 105, DateTimeKind.Local).AddTicks(4081), "LamGiang24@hotmail.com", "0980996153", "Thiên Phương Nguyễn" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 13,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Trà Vinh", new DateTime(2024, 5, 13, 14, 38, 37, 105, DateTimeKind.Local).AddTicks(4280), "QuangDat.Ngo@yahoo.com", "0927236011", "Thiện Tính Trần" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 14,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Lâm Đồng", new DateTime(2024, 5, 13, 14, 38, 37, 105, DateTimeKind.Local).AddTicks(4501), "ThuyOanh_Ngo83@gmail.com", "0927248829", "Hồng Minh Vũ" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 15,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Quảng Trị", new DateTime(2024, 5, 13, 14, 38, 37, 105, DateTimeKind.Local).AddTicks(4677), "TuanKhoan42@hotmail.com", "0913873737", "Diên Vỹ Đào" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 16,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Hà Tĩnh", new DateTime(2024, 5, 13, 14, 38, 37, 105, DateTimeKind.Local).AddTicks(4850), "CongHau43@gmail.com", "0933633899", "Lan Hương Bùi" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 17,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Đắk Nông", new DateTime(2024, 5, 13, 14, 38, 37, 105, DateTimeKind.Local).AddTicks(5013), "HoaiBac0@hotmail.com", "0917873489", "Thiên Tuyền Nguyễn" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 18,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Phú Thọ", new DateTime(2024, 5, 13, 14, 38, 37, 105, DateTimeKind.Local).AddTicks(5194), "GiaUy.Nguyen@gmail.com", "0994733739", "Ðức Ân Hà" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 19,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Điện Biên", new DateTime(2024, 5, 13, 14, 38, 37, 105, DateTimeKind.Local).AddTicks(5372), "DoanThanh_Phung56@gmail.com", "0958842016", "Ðức Phong Dương" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 20,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Hà Nam", new DateTime(2024, 5, 13, 14, 38, 37, 105, DateTimeKind.Local).AddTicks(5574), "NhatLinh34@hotmail.com", "0954970749", "Hải Dương Lê" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 21,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Bình Dương", new DateTime(2024, 5, 13, 14, 38, 37, 105, DateTimeKind.Local).AddTicks(5781), "HuongTra_Tran@hotmail.com", "0952163077", "Hữu Bào Đặng" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 22,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Long An", new DateTime(2024, 5, 13, 14, 38, 37, 105, DateTimeKind.Local).AddTicks(5978), "LanTruc79@yahoo.com", "0977788552", "Minh Vũ Đỗ" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 23,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Vĩnh Long", new DateTime(2024, 5, 13, 14, 38, 37, 105, DateTimeKind.Local).AddTicks(6212), "HongLinh.Tang@yahoo.com", "0969437963", "Hải Vy Vương" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 24,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Kon Tum", new DateTime(2024, 5, 13, 14, 38, 37, 105, DateTimeKind.Local).AddTicks(6442), "HuuBao44@hotmail.com", "0904819497", "Hồng Hoa Vũ" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 25,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Thái Nguyên", new DateTime(2024, 5, 13, 14, 38, 37, 105, DateTimeKind.Local).AddTicks(6614), "QuangDat_To@hotmail.com", "0927209283", "Nhật Thịnh Lâm" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 26,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Đà Nẵng", new DateTime(2024, 5, 13, 14, 38, 37, 105, DateTimeKind.Local).AddTicks(6824), "ThienNgon.Tran@gmail.com", "0963413550", "Như Phương Ngô" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 27,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Bình Thuận", new DateTime(2024, 5, 13, 14, 38, 37, 105, DateTimeKind.Local).AddTicks(7113), "HongDiem18@gmail.com", "0997421887", "Bạch Mai Mai" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 28,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Lai Châu", new DateTime(2024, 5, 13, 14, 38, 37, 105, DateTimeKind.Local).AddTicks(7323), "KieuNga_Le@hotmail.com", "0991850202", "Ðông Trà Vũ" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 29,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Hà Tĩnh", new DateTime(2024, 5, 13, 14, 38, 37, 105, DateTimeKind.Local).AddTicks(7537), "HuuHanh31@yahoo.com", "0967404598", "Kiều Nga Trương" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 30,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Quảng Trị", new DateTime(2024, 5, 13, 14, 38, 37, 105, DateTimeKind.Local).AddTicks(7704), "NgocDiep52@yahoo.com", "0921102250", "Thượng Khang Lâm" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 31,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Lạng Sơn", new DateTime(2024, 5, 13, 14, 38, 37, 105, DateTimeKind.Local).AddTicks(7871), "SaoBang_Truong@gmail.com", "0980610687", "Huy Anh Lý" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 32,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Hà Nội", new DateTime(2024, 5, 13, 14, 38, 37, 105, DateTimeKind.Local).AddTicks(8094), "ThanhPhong.Phung67@yahoo.com", "0969841309", "Bảo Huy Mai" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 33,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Hòa Bình", new DateTime(2024, 5, 13, 14, 38, 37, 105, DateTimeKind.Local).AddTicks(8400), "ThaoQuyen_Tang17@hotmail.com", "0934926376", "Thúy Huyền Vũ" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 34,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Yên Bái", new DateTime(2024, 5, 13, 14, 38, 37, 105, DateTimeKind.Local).AddTicks(8658), "HaiThuy_Vuong@gmail.com", "0948045384", "Xuân Thanh Đào" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 35,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "An Giang", new DateTime(2024, 5, 13, 14, 38, 37, 105, DateTimeKind.Local).AddTicks(8889), "BichChieu99@hotmail.com", "0986719432", "Mỹ Thuần Trịnh" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 36,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Cao Bằng", new DateTime(2024, 5, 13, 14, 38, 37, 105, DateTimeKind.Local).AddTicks(9099), "KhoiNguyen.Vuong@hotmail.com", "0916115447", "Niệm Nhiên Vũ" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 37,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Đà Nẵng", new DateTime(2024, 5, 13, 14, 38, 37, 105, DateTimeKind.Local).AddTicks(9309), "QuocBinh.Dinh@yahoo.com", "0960218865", "Tâm Khanh Bùi" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 38,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Lai Châu", new DateTime(2024, 5, 13, 14, 38, 37, 105, DateTimeKind.Local).AddTicks(9559), "SyThuc47@yahoo.com", "0961176652", "Giang Thiên Lê" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 39,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Khánh Hoà", new DateTime(2024, 5, 13, 14, 38, 37, 106, DateTimeKind.Local).AddTicks(991), "TanTruong7@hotmail.com", "0965721980", "Xuân Uyên Lê" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 40,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Quảng Trị", new DateTime(2024, 5, 13, 14, 38, 37, 106, DateTimeKind.Local).AddTicks(1230), "NgocLe.Dinh@yahoo.com", "0964174518", "Trọng Vinh Đinh" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 41,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Lâm Đồng", new DateTime(2024, 5, 13, 14, 38, 37, 106, DateTimeKind.Local).AddTicks(1540), "QuangKhai_Le11@hotmail.com", "0938259385", "Công Hiếu Đoàn" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 42,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Hà Tĩnh", new DateTime(2024, 5, 13, 14, 38, 37, 106, DateTimeKind.Local).AddTicks(1713), "AnHang.To@yahoo.com", "0929588558", "Như Tâm Phan" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 43,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Hưng Yên", new DateTime(2024, 5, 13, 14, 38, 37, 112, DateTimeKind.Local).AddTicks(4633), "HongLiem.Lam39@yahoo.com", "0938466636", "Đan Linh Trịnh" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 44,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Lạng Sơn", new DateTime(2024, 5, 13, 14, 38, 37, 112, DateTimeKind.Local).AddTicks(4938), "BangBang17@hotmail.com", "0960889560", "Trường An Lâm" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 45,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Điện Biên", new DateTime(2024, 5, 13, 14, 38, 37, 112, DateTimeKind.Local).AddTicks(5127), "DuongAnh57@yahoo.com", "0972534586", "Tùng Châu Vương" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 46,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Hậu Giang", new DateTime(2024, 5, 13, 14, 38, 37, 112, DateTimeKind.Local).AddTicks(5340), "ThienMinh79@yahoo.com", "0947731288", "Bảo Lâm Ngô" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 47,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Bình Thuận", new DateTime(2024, 5, 13, 14, 38, 37, 112, DateTimeKind.Local).AddTicks(5511), "DiemChau67@hotmail.com", "0996937705", "Xuyến Chi Trương" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 48,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Thái Nguyên", new DateTime(2024, 5, 13, 14, 38, 37, 112, DateTimeKind.Local).AddTicks(5689), "DongTra_Do68@yahoo.com", "0931689244", "Xuân Mai Nguyễn" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 49,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Kon Tum", new DateTime(2024, 5, 13, 14, 38, 37, 112, DateTimeKind.Local).AddTicks(5854), "NamHung_Pham21@hotmail.com", "0905507754", "Minh Hương Tô" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 50,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Cà Mau", new DateTime(2024, 5, 13, 14, 38, 37, 112, DateTimeKind.Local).AddTicks(6117), "HongThinh33@hotmail.com", "0985380326", "Lệ Nhi Lâm" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 51,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Cao Bằng", new DateTime(2024, 5, 13, 14, 38, 37, 112, DateTimeKind.Local).AddTicks(6316), "HangAnh46@yahoo.com", "0960927005", "Huy Anh Vũ" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 52,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Đắk Lắk", new DateTime(2024, 5, 13, 14, 38, 37, 112, DateTimeKind.Local).AddTicks(6474), "NamViet_Phung@gmail.com", "0992429960", "Như Thảo Tăng" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 53,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Lào Cai", new DateTime(2024, 5, 13, 14, 38, 37, 112, DateTimeKind.Local).AddTicks(6706), "QuangDung_Trinh6@hotmail.com", "0938187020", "Ðan Quế Phan" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 54,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Gia Lai", new DateTime(2024, 5, 13, 14, 38, 37, 112, DateTimeKind.Local).AddTicks(6881), "GiaBinh.Bui85@yahoo.com", "0982417223", "Ngọc Yến Phạm" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 55,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Hòa Bình", new DateTime(2024, 5, 13, 14, 38, 37, 112, DateTimeKind.Local).AddTicks(7045), "NgocTru98@gmail.com", "0990454846", "Tú Ly Hoàng" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 56,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Bắc Kạn", new DateTime(2024, 5, 13, 14, 38, 37, 112, DateTimeKind.Local).AddTicks(7187), "DangKhuong.Dao@yahoo.com", "0934271690", "Quốc Tiến Tăng" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 57,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Hậu Giang", new DateTime(2024, 5, 13, 14, 38, 37, 112, DateTimeKind.Local).AddTicks(7385), "HaHai.Ly41@yahoo.com", "0938307378", "Khắc Anh Tô" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 58,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Quảng Trị", new DateTime(2024, 5, 13, 14, 38, 37, 112, DateTimeKind.Local).AddTicks(7545), "HaiLy.Dinh79@gmail.com", "0949118454", "Thiên Tuyền Phan" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 59,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Yên Bái", new DateTime(2024, 5, 13, 14, 38, 37, 112, DateTimeKind.Local).AddTicks(7695), "ThanhThuy.Duong@gmail.com", "0993057215", "Bảo Phương Tăng" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 60,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Quảng Bình", new DateTime(2024, 5, 13, 14, 38, 37, 112, DateTimeKind.Local).AddTicks(7893), "HuongLam_To81@hotmail.com", "0941029223", "Ðức Hòa Lâm" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 61,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Thái Bình", new DateTime(2024, 5, 13, 14, 38, 37, 112, DateTimeKind.Local).AddTicks(8075), "KhueTrung_Ho63@hotmail.com", "0988040217", "Duy Hiếu Phan" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 62,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Cao Bằng", new DateTime(2024, 5, 13, 14, 38, 37, 112, DateTimeKind.Local).AddTicks(8263), "HaHai83@yahoo.com", "0951177417", "Thuận Thành Đào" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 63,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Tây Ninh", new DateTime(2024, 5, 13, 14, 38, 37, 112, DateTimeKind.Local).AddTicks(8460), "HanhChi_Le81@gmail.com", "0902993642", "Thanh Hồng Phạm" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 64,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Ninh Bình", new DateTime(2024, 5, 13, 14, 38, 37, 112, DateTimeKind.Local).AddTicks(8613), "AnhMai72@hotmail.com", "0997416340", "Vĩnh Hải Bùi" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 65,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Lai Châu", new DateTime(2024, 5, 13, 14, 38, 37, 112, DateTimeKind.Local).AddTicks(8778), "ThienAn.Nguyen89@hotmail.com", "0941626568", "Vinh Diệu Hoàng" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 66,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Cao Bằng", new DateTime(2024, 5, 13, 14, 38, 37, 112, DateTimeKind.Local).AddTicks(9004), "GiaHiep.Dao@yahoo.com", "0990948952", "Mạnh Thắng Bùi" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 67,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Đắk Nông", new DateTime(2024, 5, 13, 14, 38, 37, 112, DateTimeKind.Local).AddTicks(9318), "DinhNguyen.Ly@yahoo.com", "0949512366", "Ngọc Diệp Đoàn" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 68,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Hòa Bình", new DateTime(2024, 5, 13, 14, 38, 37, 112, DateTimeKind.Local).AddTicks(9503), "HuuLong70@hotmail.com", "0970067306", "Thu Ngọc Lê" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 69,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Quảng Ngãi", new DateTime(2024, 5, 13, 14, 38, 37, 112, DateTimeKind.Local).AddTicks(9647), "DucTrung_Ha@hotmail.com", "0968546651", "Hữu Trí Đào" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 70,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Phú Thọ", new DateTime(2024, 5, 13, 14, 38, 37, 112, DateTimeKind.Local).AddTicks(9804), "ThuLoan_Bui@gmail.com", "0983973698", "Ðinh Hương Tô" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 71,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Kiên Giang", new DateTime(2024, 5, 13, 14, 38, 37, 112, DateTimeKind.Local).AddTicks(9950), "DaHuong.Ly69@hotmail.com", "0961546028", "Sông Hà Trịnh" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 72,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Quảng Ngãi", new DateTime(2024, 5, 13, 14, 38, 37, 113, DateTimeKind.Local).AddTicks(151), "OanhTho65@gmail.com", "0951659358", "Diệu Anh Trần" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 73,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Phú Yên", new DateTime(2024, 5, 13, 14, 38, 37, 113, DateTimeKind.Local).AddTicks(358), "ThienAn18@gmail.com", "0996568355", "Khoa Trưởng Tăng" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 74,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "TP. Hồ Chí Minh", new DateTime(2024, 5, 13, 14, 38, 37, 113, DateTimeKind.Local).AddTicks(1059), "KimLoan15@yahoo.com", "0946732888", "Nghĩa Dũng Phạm" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 75,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Bà Rịa-Vũng Tàu", new DateTime(2024, 5, 13, 14, 38, 37, 113, DateTimeKind.Local).AddTicks(1274), "HiepHoa94@gmail.com", "0936241763", "Trường Vũ Vũ" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 76,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Hà Nam", new DateTime(2024, 5, 13, 14, 38, 37, 113, DateTimeKind.Local).AddTicks(1440), "ChuanKhoa83@gmail.com", "0936737670", "Tuấn Ðức Mai" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 77,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Ninh Thuận", new DateTime(2024, 5, 13, 14, 38, 37, 113, DateTimeKind.Local).AddTicks(1635), "PhuongHien51@gmail.com", "0926854363", "Tuyết Xuân Tăng" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 78,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Đồng Tháp", new DateTime(2024, 5, 13, 14, 38, 37, 113, DateTimeKind.Local).AddTicks(1822), "MaiThao63@gmail.com", "0976283308", "Vàng Anh Tô" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 79,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Lạng Sơn", new DateTime(2024, 5, 13, 14, 38, 37, 113, DateTimeKind.Local).AddTicks(2002), "ToQuyen13@gmail.com", "0934611656", "Hà Mi Đỗ" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 80,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Bình Phước", new DateTime(2024, 5, 13, 14, 38, 37, 113, DateTimeKind.Local).AddTicks(2216), "NgocThien_Le@gmail.com", "0989030004", "Tú Trinh Đỗ" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 81,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Trà Vinh", new DateTime(2024, 5, 13, 14, 38, 37, 113, DateTimeKind.Local).AddTicks(2409), "ChanHung_Duong@gmail.com", "0916648993", "Vân Chi Trần" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 82,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Hải Phòng", new DateTime(2024, 5, 13, 14, 38, 37, 113, DateTimeKind.Local).AddTicks(2560), "MongTuyen1@hotmail.com", "0956072806", "Bách Du Tăng" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 83,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Đắk Lắk", new DateTime(2024, 5, 13, 14, 38, 37, 113, DateTimeKind.Local).AddTicks(2854), "CatLy.Phan74@yahoo.com", "0926049687", "Bích Ðào Đỗ" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 84,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Nam Định", new DateTime(2024, 5, 13, 14, 38, 37, 113, DateTimeKind.Local).AddTicks(3059), "PhiCuong_Phung@gmail.com", "0949187159", "Thường Xuân Hà" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 85,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Lai Châu", new DateTime(2024, 5, 13, 14, 38, 37, 113, DateTimeKind.Local).AddTicks(3244), "DiemHang_Ho@yahoo.com", "0961139076", "Thuận Hòa Tô" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 86,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Hưng Yên", new DateTime(2024, 5, 13, 14, 38, 37, 113, DateTimeKind.Local).AddTicks(3379), "GiaHan_Mai@hotmail.com", "0992115499", "Quang Dũng Lâm" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 87,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Yên Bái", new DateTime(2024, 5, 13, 14, 38, 37, 113, DateTimeKind.Local).AddTicks(3530), "QuangDanh64@hotmail.com", "0960333433", "Thành Doanh Vương" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 88,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Bắc Giang", new DateTime(2024, 5, 13, 14, 38, 37, 113, DateTimeKind.Local).AddTicks(3669), "DongTuyen79@hotmail.com", "0993098463", "Anh Ðào Hà" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 89,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Lâm Đồng", new DateTime(2024, 5, 13, 14, 38, 37, 113, DateTimeKind.Local).AddTicks(3859), "HongMinh_Do44@hotmail.com", "0934552906", "Thái Sang Tăng" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 90,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Đồng Tháp", new DateTime(2024, 5, 13, 14, 38, 37, 113, DateTimeKind.Local).AddTicks(4014), "CaoSon.Vuong@gmail.com", "0961766608", "Xuân Cao Dương" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 91,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Hậu Giang", new DateTime(2024, 5, 13, 14, 38, 37, 113, DateTimeKind.Local).AddTicks(4152), "VietTan_Ha@gmail.com", "0932346002", "Trân Châu Lê" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 92,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Trà Vinh", new DateTime(2024, 5, 13, 14, 38, 37, 113, DateTimeKind.Local).AddTicks(4338), "HoangOanh_Tang36@hotmail.com", "0994636776", "Hiếu Minh Đoàn" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 93,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Cao Bằng", new DateTime(2024, 5, 13, 14, 38, 37, 113, DateTimeKind.Local).AddTicks(4684), "TramHuong.Nguyen@yahoo.com", "0952398714", "Ðông Tuyền Phạm" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 94,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Vĩnh Long", new DateTime(2024, 5, 13, 14, 38, 37, 113, DateTimeKind.Local).AddTicks(4853), "TrungHieu1@gmail.com", "0990941996", "Hoàng Cúc Lý" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 95,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Đồng Nai", new DateTime(2024, 5, 13, 14, 38, 37, 113, DateTimeKind.Local).AddTicks(5007), "DuyenNuong.Doan@hotmail.com", "0942917103", "Hoàng Hà Tô" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 96,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Thái Bình", new DateTime(2024, 5, 13, 14, 38, 37, 113, DateTimeKind.Local).AddTicks(5173), "HongLiem_Tran9@gmail.com", "0986962969", "Minh Nghĩa Lê" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 97,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Quảng Ninh", new DateTime(2024, 5, 13, 14, 38, 37, 113, DateTimeKind.Local).AddTicks(5369), "XuanLan.Duong44@yahoo.com", "0953660426", "Loan Châu Bùi" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 98,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Đồng Tháp", new DateTime(2024, 5, 13, 14, 38, 37, 113, DateTimeKind.Local).AddTicks(5525), "DuyMy99@hotmail.com", "0974478424", "Thi Cầm Trần" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 99,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "An Giang", new DateTime(2024, 5, 13, 14, 38, 37, 113, DateTimeKind.Local).AddTicks(5670), "KimTuyet_Pham@yahoo.com", "0916292974", "Nguyên Lộc Dương" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 100,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Sơn La", new DateTime(2024, 5, 13, 14, 38, 37, 113, DateTimeKind.Local).AddTicks(5833), "BaoVy.Dinh22@yahoo.com", "0952988288", "Phương Thi Vũ" });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 1,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 36, 9, new DateTime(2024, 5, 22, 2, 52, 48, 793, DateTimeKind.Unspecified).AddTicks(1026), 14029501.576358408400000m, 14029501.576358408400000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 2,
                columns: new[] { "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 28, new DateTime(2024, 5, 8, 17, 32, 58, 974, DateTimeKind.Unspecified).AddTicks(7494), 7931690.87818959500000m, 7931690.87818959500000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 3,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 13, 49, new DateTime(2024, 5, 5, 16, 0, 1, 730, DateTimeKind.Unspecified).AddTicks(70), 9139357.991485274800000m, 9139357.991485274800000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 4,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 53, 6, new DateTime(2024, 5, 19, 22, 57, 35, 517, DateTimeKind.Unspecified).AddTicks(6463), 8986060.895035483800000m, 8986060.895035483800000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 5,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 17, 92, new DateTime(2024, 5, 2, 22, 12, 50, 651, DateTimeKind.Unspecified).AddTicks(5092), 14420479.104935685600000m, 14420479.104935685600000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 6,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 6, 62, new DateTime(2024, 5, 23, 17, 58, 56, 146, DateTimeKind.Unspecified).AddTicks(5848), 10275543.662436150500000m, 10275543.662436150500000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 7,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 10, 41, new DateTime(2024, 5, 7, 8, 46, 37, 553, DateTimeKind.Unspecified).AddTicks(7), 7301388.530497531800000m, 7301388.530497531800000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 8,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 95, 97, new DateTime(2024, 5, 7, 2, 50, 11, 909, DateTimeKind.Unspecified).AddTicks(7017), 8203758.5816653058900000m, 8203758.5816653058900000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 9,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 44, 13, new DateTime(2024, 5, 20, 1, 31, 37, 52, DateTimeKind.Unspecified).AddTicks(4946), 6020721.2415223500600000m, 6020721.2415223500600000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 10,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 65, 96, new DateTime(2024, 5, 11, 16, 54, 40, 39, DateTimeKind.Unspecified).AddTicks(731), 10449686.908587518500000m, 10449686.908587518500000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 11,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 89, 27, new DateTime(2024, 5, 28, 2, 29, 19, 902, DateTimeKind.Unspecified).AddTicks(6420), 17225657.990744904800000m, 17225657.990744904800000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 12,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 8, 52, new DateTime(2024, 5, 21, 9, 21, 29, 825, DateTimeKind.Unspecified).AddTicks(4820), 8040498.369065016000000m, 8040498.369065016000000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 13,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 60, 34, new DateTime(2024, 5, 25, 9, 56, 38, 621, DateTimeKind.Unspecified).AddTicks(8979), 7346487.5722342605600000m, 7346487.5722342605600000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 14,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 57, 69, new DateTime(2024, 5, 10, 4, 4, 27, 380, DateTimeKind.Unspecified).AddTicks(3340), 9133293.081774680900000m, 9133293.081774680900000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 15,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 16, 34, new DateTime(2024, 5, 28, 14, 24, 8, 256, DateTimeKind.Unspecified).AddTicks(4613), 7467809.070046341500000m, 7467809.070046341500000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 16,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 47, 4, new DateTime(2024, 5, 14, 2, 42, 46, 586, DateTimeKind.Unspecified).AddTicks(3564), 13929858.702051390300000m, 13929858.702051390300000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 17,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 47, 84, new DateTime(2024, 5, 16, 6, 34, 43, 678, DateTimeKind.Unspecified).AddTicks(7138), 9139269.681966664800000m, 9139269.681966664800000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 18,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 37, 51, new DateTime(2024, 5, 6, 15, 59, 39, 224, DateTimeKind.Unspecified).AddTicks(574), 8269118.099883057600000m, 8269118.099883057600000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 19,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 79, 68, new DateTime(2024, 5, 6, 16, 1, 34, 893, DateTimeKind.Unspecified).AddTicks(928), 15243835.062626666100000m, 15243835.062626666100000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 20,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 34, 14, new DateTime(2024, 5, 19, 11, 39, 20, 349, DateTimeKind.Unspecified).AddTicks(2894), 7032367.3768188672000000m, 7032367.3768188672000000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 21,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 17, 1, new DateTime(2024, 5, 22, 22, 50, 39, 361, DateTimeKind.Unspecified).AddTicks(4962), 13205333.799700544000000m, 13205333.799700544000000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 22,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 45, 52, new DateTime(2024, 5, 1, 8, 9, 25, 71, DateTimeKind.Unspecified).AddTicks(1454), 11395354.541387371200000m, 11395354.541387371200000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 23,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 38, 32, new DateTime(2024, 5, 10, 14, 30, 48, 413, DateTimeKind.Unspecified).AddTicks(1986), 11160407.594203806400000m, 11160407.594203806400000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 24,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 77, 87, new DateTime(2024, 5, 22, 7, 2, 8, 113, DateTimeKind.Unspecified).AddTicks(962), 15904553.825705023200000m, 15904553.825705023200000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 25,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 91, 54, new DateTime(2024, 5, 15, 13, 7, 49, 968, DateTimeKind.Unspecified).AddTicks(8003), 10404100.454445348500000m, 10404100.454445348500000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 26,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 2, 4, new DateTime(2024, 5, 20, 6, 43, 20, 986, DateTimeKind.Unspecified).AddTicks(8778), 10306487.475291730800000m, 10306487.475291730800000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 27,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 57, 100, new DateTime(2024, 5, 15, 20, 7, 37, 929, DateTimeKind.Unspecified).AddTicks(122), 8020631.770243187500000m, 8020631.770243187500000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 28,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 37, 80, new DateTime(2024, 5, 27, 12, 28, 51, 916, DateTimeKind.Unspecified).AddTicks(237), 7036138.009532815000000m, 7036138.009532815000000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 29,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 18, 2, new DateTime(2024, 5, 23, 0, 14, 59, 680, DateTimeKind.Unspecified).AddTicks(6844), 17439645.33300468400000m, 17439645.33300468400000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 30,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 90, 58, new DateTime(2024, 5, 7, 15, 1, 13, 490, DateTimeKind.Unspecified).AddTicks(2807), 10816247.142766205000000m, 10816247.142766205000000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 31,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 100, 81, new DateTime(2024, 5, 24, 19, 33, 36, 856, DateTimeKind.Unspecified).AddTicks(9507), 13675802.449080794400000m, 13675802.449080794400000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 32,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 68, 79, new DateTime(2024, 5, 7, 20, 1, 28, 862, DateTimeKind.Unspecified).AddTicks(814), 11966908.905432186000000m, 11966908.905432186000000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 33,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 22, 36, new DateTime(2024, 5, 19, 22, 7, 0, 79, DateTimeKind.Unspecified).AddTicks(2054), 10493417.512897569000000m, 10493417.512897569000000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 34,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 64, 40, new DateTime(2024, 5, 29, 18, 58, 40, 227, DateTimeKind.Unspecified).AddTicks(7605), 7376492.279346350500000m, 7376492.279346350500000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 35,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 46, 34, new DateTime(2024, 5, 3, 10, 15, 11, 571, DateTimeKind.Unspecified).AddTicks(2175), 16014046.107658309200000m, 16014046.107658309200000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 36,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 52, 52, new DateTime(2024, 5, 23, 8, 50, 40, 631, DateTimeKind.Unspecified).AddTicks(8338), 6164954.246888992500000m, 6164954.246888992500000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 37,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 80, 50, new DateTime(2024, 5, 1, 20, 45, 10, 324, DateTimeKind.Unspecified).AddTicks(9579), 12537325.923907270500000m, 12537325.923907270500000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 38,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 92, 42, new DateTime(2024, 5, 14, 20, 56, 2, 268, DateTimeKind.Unspecified).AddTicks(9514), 5945257.78084560400000m, 5945257.78084560400000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 39,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 49, 69, new DateTime(2024, 5, 9, 22, 56, 9, 272, DateTimeKind.Unspecified).AddTicks(2172), 7438005.745003340800000m, 7438005.745003340800000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 40,
                columns: new[] { "CustomerID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 26, new DateTime(2024, 5, 15, 0, 21, 25, 195, DateTimeKind.Unspecified).AddTicks(2673), 12284956.220973943500000m, 12284956.220973943500000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 41,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 71, 55, new DateTime(2024, 5, 4, 20, 25, 36, 324, DateTimeKind.Unspecified).AddTicks(2587), 10815312.7330817800000m, 10815312.7330817800000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 42,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 42, 25, new DateTime(2024, 5, 20, 13, 6, 0, 361, DateTimeKind.Unspecified).AddTicks(2521), 14461391.924262996200000m, 14461391.924262996200000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 43,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 48, 88, new DateTime(2024, 5, 1, 16, 42, 40, 728, DateTimeKind.Unspecified).AddTicks(1474), 10024090.977208818600000m, 10024090.977208818600000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 44,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 43, 33, new DateTime(2024, 5, 15, 22, 8, 25, 580, DateTimeKind.Unspecified).AddTicks(357), 9265565.911018248300000m, 9265565.911018248300000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 45,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 36, 37, new DateTime(2024, 5, 5, 3, 50, 14, 101, DateTimeKind.Unspecified).AddTicks(3006), 10235180.659350240100000m, 10235180.659350240100000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 46,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 77, 15, new DateTime(2024, 5, 13, 7, 52, 17, 276, DateTimeKind.Unspecified).AddTicks(90), 16172155.647144756400000m, 16172155.647144756400000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 47,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 83, 100, new DateTime(2024, 5, 16, 22, 58, 1, 32, DateTimeKind.Unspecified).AddTicks(9145), 7172834.887906707600000m, 7172834.887906707600000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 48,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 30, 9, new DateTime(2024, 5, 2, 13, 32, 34, 506, DateTimeKind.Unspecified).AddTicks(5409), 15611680.404717552000000m, 15611680.404717552000000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 49,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 86, 27, new DateTime(2024, 5, 18, 7, 42, 53, 61, DateTimeKind.Unspecified).AddTicks(8045), 15379145.129020273200000m, 15379145.129020273200000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 50,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 89, 59, new DateTime(2024, 5, 10, 10, 27, 22, 710, DateTimeKind.Unspecified).AddTicks(5002), 9565016.425084782400000m, 9565016.425084782400000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 51,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 85, 20, new DateTime(2024, 5, 19, 20, 34, 28, 453, DateTimeKind.Unspecified).AddTicks(3654), 7283220.75686475600000m, 7283220.75686475600000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 52,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 17, 41, new DateTime(2024, 5, 11, 12, 43, 54, 741, DateTimeKind.Unspecified).AddTicks(1612), 11784155.21385611400000m, 11784155.21385611400000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 53,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 21, 25, new DateTime(2024, 5, 18, 10, 25, 25, 395, DateTimeKind.Unspecified).AddTicks(8081), 7631866.303455466200000m, 7631866.303455466200000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 54,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 51, 61, new DateTime(2024, 5, 22, 9, 35, 19, 910, DateTimeKind.Unspecified).AddTicks(8445), 11046333.511625208800000m, 11046333.511625208800000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 55,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 100, 76, new DateTime(2024, 5, 8, 4, 3, 50, 737, DateTimeKind.Unspecified).AddTicks(107), 13686692.503385028600000m, 13686692.503385028600000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 56,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 1, 20, new DateTime(2024, 5, 22, 22, 10, 11, 48, DateTimeKind.Unspecified).AddTicks(6929), 11592636.105821680800000m, 11592636.105821680800000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 57,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 34, 5, new DateTime(2024, 5, 28, 4, 46, 6, 996, DateTimeKind.Unspecified).AddTicks(8136), 13006933.464011402200000m, 13006933.464011402200000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 58,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 94, 39, new DateTime(2024, 5, 3, 3, 3, 40, 513, DateTimeKind.Unspecified).AddTicks(7237), 8214106.737793079500000m, 8214106.737793079500000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 59,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 56, 48, new DateTime(2024, 5, 9, 22, 20, 45, 746, DateTimeKind.Unspecified).AddTicks(1407), 7316793.918677035000000m, 7316793.918677035000000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 60,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 29, 11, new DateTime(2024, 5, 3, 0, 57, 50, 21, DateTimeKind.Unspecified).AddTicks(1967), 11520835.676133220400000m, 11520835.676133220400000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 61,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 81, 60, new DateTime(2024, 5, 25, 3, 59, 37, 427, DateTimeKind.Unspecified).AddTicks(1767), 12644662.148879634000000m, 12644662.148879634000000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 62,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 14, 23, new DateTime(2024, 5, 11, 2, 37, 25, 503, DateTimeKind.Unspecified).AddTicks(3308), 9061386.301692155600000m, 9061386.301692155600000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 63,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 72, 92, new DateTime(2024, 5, 19, 10, 10, 11, 740, DateTimeKind.Unspecified).AddTicks(1229), 11856249.178765650600000m, 11856249.178765650600000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 64,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 16, 95, new DateTime(2024, 5, 8, 11, 35, 2, 233, DateTimeKind.Unspecified).AddTicks(549), 10830975.750058275500000m, 10830975.750058275500000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 65,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 53, 92, new DateTime(2024, 5, 24, 15, 15, 40, 923, DateTimeKind.Unspecified).AddTicks(9124), 11565539.122799441000000m, 11565539.122799441000000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 66,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 83, 3, new DateTime(2024, 5, 11, 15, 51, 42, 631, DateTimeKind.Unspecified).AddTicks(7228), 10936426.426918053800000m, 10936426.426918053800000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 67,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 98, 74, new DateTime(2024, 5, 15, 6, 22, 9, 933, DateTimeKind.Unspecified).AddTicks(2030), 10670061.416131174400000m, 10670061.416131174400000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 68,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 52, 87, new DateTime(2024, 5, 14, 14, 55, 47, 506, DateTimeKind.Unspecified).AddTicks(2794), 8711931.080545557200000m, 8711931.080545557200000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 69,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 33, 40, new DateTime(2024, 5, 20, 22, 48, 47, 471, DateTimeKind.Unspecified).AddTicks(8623), 14858785.30853160600000m, 14858785.30853160600000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 70,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 81, 17, new DateTime(2024, 5, 17, 17, 54, 31, 104, DateTimeKind.Unspecified).AddTicks(3839), 12008453.0949366800000m, 12008453.0949366800000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 71,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 23, 67, new DateTime(2024, 5, 26, 7, 37, 16, 313, DateTimeKind.Unspecified).AddTicks(8671), 10583021.882568381400000m, 10583021.882568381400000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 72,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 9, 68, new DateTime(2024, 5, 18, 20, 47, 12, 28, DateTimeKind.Unspecified).AddTicks(7122), 7269655.481396509400000m, 7269655.481396509400000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 73,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 98, 37, new DateTime(2024, 5, 20, 9, 54, 22, 255, DateTimeKind.Unspecified).AddTicks(509), 17663482.332347791700000m, 17663482.332347791700000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 74,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 15, 89, new DateTime(2024, 5, 23, 15, 1, 26, 725, DateTimeKind.Unspecified).AddTicks(1634), 10698094.557700603200000m, 10698094.557700603200000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 75,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 4, 60, new DateTime(2024, 5, 11, 0, 49, 4, 998, DateTimeKind.Unspecified).AddTicks(3463), 8757219.821900726800000m, 8757219.821900726800000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 76,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 21, 75, new DateTime(2024, 5, 26, 21, 41, 28, 304, DateTimeKind.Unspecified).AddTicks(3752), 11992229.189362131400000m, 11992229.189362131400000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 77,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 96, 87, new DateTime(2024, 5, 23, 19, 43, 15, 356, DateTimeKind.Unspecified).AddTicks(8365), 11368313.690467444900000m, 11368313.690467444900000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 78,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 96, 54, new DateTime(2024, 5, 14, 10, 44, 54, 636, DateTimeKind.Unspecified).AddTicks(1807), 12010994.795956758600000m, 12010994.795956758600000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 79,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 72, 57, new DateTime(2024, 5, 1, 23, 8, 54, 382, DateTimeKind.Unspecified).AddTicks(4363), 8211372.506069287600000m, 8211372.506069287600000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 80,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 5, 59, new DateTime(2024, 5, 17, 5, 58, 34, 295, DateTimeKind.Unspecified).AddTicks(5581), 10395499.233506373600000m, 10395499.233506373600000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 81,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 12, 2, new DateTime(2024, 5, 4, 8, 43, 35, 703, DateTimeKind.Unspecified).AddTicks(3763), 13953932.624149847600000m, 13953932.624149847600000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 82,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 24, 99, new DateTime(2024, 5, 28, 0, 23, 45, 648, DateTimeKind.Unspecified).AddTicks(5502), 13576901.558997494000000m, 13576901.558997494000000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 83,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 73, 38, new DateTime(2024, 5, 3, 5, 40, 0, 222, DateTimeKind.Unspecified).AddTicks(6245), 11630494.871957628900000m, 11630494.871957628900000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 84,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 9, 99, new DateTime(2024, 5, 9, 7, 46, 12, 420, DateTimeKind.Unspecified).AddTicks(8954), 14238570.831641044400000m, 14238570.831641044400000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 85,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 84, 15, new DateTime(2024, 5, 11, 9, 39, 41, 340, DateTimeKind.Unspecified).AddTicks(8042), 11869792.709238403100000m, 11869792.709238403100000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 86,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 2, 57, new DateTime(2024, 5, 28, 5, 11, 11, 427, DateTimeKind.Unspecified).AddTicks(103), 7619458.2467355000000m, 7619458.2467355000000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 87,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 19, 4, new DateTime(2024, 5, 9, 13, 32, 31, 337, DateTimeKind.Unspecified).AddTicks(254), 6685918.6442459057900000m, 6685918.6442459057900000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 88,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 66, 7, new DateTime(2024, 5, 6, 8, 24, 58, 167, DateTimeKind.Unspecified).AddTicks(2566), 15628471.694122229600000m, 15628471.694122229600000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 89,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 50, 88, new DateTime(2024, 5, 20, 23, 4, 58, 608, DateTimeKind.Unspecified).AddTicks(4823), 14777763.557379310800000m, 14777763.557379310800000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 90,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 97, 35, new DateTime(2024, 5, 14, 19, 12, 21, 59, DateTimeKind.Unspecified).AddTicks(4445), 9157951.843730107200000m, 9157951.843730107200000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 91,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 7, 100, new DateTime(2024, 5, 18, 16, 21, 45, 788, DateTimeKind.Unspecified).AddTicks(6724), 10664723.670858118400000m, 10664723.670858118400000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 92,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 23, 15, new DateTime(2024, 5, 27, 19, 34, 40, 479, DateTimeKind.Unspecified).AddTicks(4492), 7337375.212502963200000m, 7337375.212502963200000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 93,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 76, 93, new DateTime(2024, 5, 3, 13, 17, 52, 912, DateTimeKind.Unspecified).AddTicks(8711), 9279744.031281809100000m, 9279744.031281809100000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 94,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 4, 59, new DateTime(2024, 5, 3, 8, 12, 42, 579, DateTimeKind.Unspecified).AddTicks(6318), 11220756.071052834600000m, 11220756.071052834600000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 95,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 62, 68, new DateTime(2024, 5, 8, 20, 1, 28, 271, DateTimeKind.Unspecified).AddTicks(8531), 15927394.725815081500000m, 15927394.725815081500000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 96,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 1, 6, new DateTime(2024, 5, 17, 1, 46, 37, 432, DateTimeKind.Unspecified).AddTicks(3909), 7549705.314460575300000m, 7549705.314460575300000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 97,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 68, 92, new DateTime(2024, 5, 29, 12, 41, 32, 911, DateTimeKind.Unspecified).AddTicks(6583), 6831923.1366565581600000m, 6831923.1366565581600000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 98,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 18, 6, new DateTime(2024, 5, 3, 11, 25, 12, 460, DateTimeKind.Unspecified).AddTicks(1135), 12826426.36567312000000m, 12826426.36567312000000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 99,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 14, 94, new DateTime(2024, 5, 8, 10, 33, 58, 549, DateTimeKind.Unspecified).AddTicks(7647), 9479713.503225045600000m, 9479713.503225045600000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 100,
                columns: new[] { "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 32, new DateTime(2024, 5, 18, 22, 54, 21, 770, DateTimeKind.Unspecified).AddTicks(9456), 8538231.372367485800000m, 8538231.372367485800000m });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 2, 2 },
                column: "Email",
                value: "HaGiang.Dao2@hotmail.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 3, 2 },
                column: "Email",
                value: "VyLam_Nguyen@yahoo.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 4, 2 },
                column: "Email",
                value: "ThaoVy81@gmail.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 6, 2 },
                column: "Email",
                value: "HuyTran_Duong@gmail.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 11, 1 },
                column: "Email",
                value: "UyenVi.To@hotmail.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 13, 2 },
                column: "Email",
                value: "VietTan_Hoang@yahoo.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 14, 2 },
                column: "Email",
                value: "VinhLong_Dao@hotmail.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 15, 2 },
                column: "Email",
                value: "BaThinh_Dao29@yahoo.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 17, 1 },
                column: "Email",
                value: "CongLuat.Tang@yahoo.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 18, 1 },
                column: "Email",
                value: "ChiGiang.Nguyen@hotmail.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 20, 2 },
                column: "Email",
                value: "MongNguyet.Le@gmail.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 21, 1 },
                column: "Email",
                value: "KimNgoc_Vuong@yahoo.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 24, 2 },
                column: "Email",
                value: "QuangXuan99@yahoo.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 25, 1 },
                column: "Email",
                value: "AnhMai90@yahoo.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 27, 1 },
                column: "Email",
                value: "MongLan_Ha26@hotmail.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 28, 2 },
                column: "Email",
                value: "TuongLan98@hotmail.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 29, 2 },
                column: "Email",
                value: "VietThi.Phung83@hotmail.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 31, 1 },
                column: "Email",
                value: "NgocLoan_Ha57@yahoo.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 33, 2 },
                column: "Email",
                value: "CuongThinh15@gmail.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 37, 1 },
                column: "Email",
                value: "NguyenHong68@hotmail.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 40, 2 },
                column: "Email",
                value: "ThuHau.Bui@yahoo.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 43, 1 },
                column: "Email",
                value: "XuanNghi.Trinh91@yahoo.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 44, 1 },
                column: "Email",
                value: "CongHai62@yahoo.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 47, 2 },
                column: "Email",
                value: "MinhGiang32@yahoo.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 48, 2 },
                column: "Email",
                value: "YenSon89@gmail.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 49, 1 },
                column: "Email",
                value: "MinhMinh21@hotmail.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 51, 1 },
                column: "Email",
                value: "HaiBang71@yahoo.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 52, 2 },
                column: "Email",
                value: "LocUyen_Tang18@yahoo.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 53, 2 },
                column: "Email",
                value: "LamDong.Tran@gmail.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 55, 2 },
                column: "Email",
                value: "DinhQuang19@gmail.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 56, 1 },
                column: "Email",
                value: "PhuongNgoc.Ho@yahoo.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 57, 1 },
                column: "Email",
                value: "DiemChi5@hotmail.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 58, 2 },
                column: "Email",
                value: "KimDan_Doan@yahoo.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 59, 2 },
                column: "Email",
                value: "TruongThanh.Phan@hotmail.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 64, 2 },
                column: "Email",
                value: "HuuNghi61@yahoo.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 65, 1 },
                column: "Email",
                value: "DongNghi60@gmail.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 66, 1 },
                column: "Email",
                value: "HieuNghia11@yahoo.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 68, 1 },
                column: "Email",
                value: "TanLoi.To5@yahoo.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 69, 1 },
                column: "Email",
                value: "MinhKhoi2@gmail.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 73, 1 },
                column: "Email",
                value: "ThaiLan58@gmail.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 74, 2 },
                column: "Email",
                value: "AiKhanh49@hotmail.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 75, 1 },
                column: "Email",
                value: "GiaHuan_Truong89@yahoo.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 77, 2 },
                column: "Email",
                value: "HuyenAnh.Phung80@hotmail.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 78, 1 },
                column: "Email",
                value: "PhuongTram.Le@hotmail.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 84, 1 },
                column: "Email",
                value: "QuocAnh70@yahoo.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 85, 2 },
                column: "Email",
                value: "TuyAnh.To@yahoo.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 86, 1 },
                column: "Email",
                value: "BaTruc56@hotmail.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 88, 2 },
                column: "Email",
                value: "MinhKhanh_Ly69@hotmail.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 90, 1 },
                column: "Email",
                value: "NamSon.Pham@gmail.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 91, 1 },
                column: "Email",
                value: "ThanhThe95@hotmail.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 92, 2 },
                column: "Email",
                value: "QuynhGiao_Vu@hotmail.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 93, 1 },
                column: "Email",
                value: "NhatLan_Hoang@gmail.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 94, 1 },
                column: "Email",
                value: "PhuocLoc_Ho45@gmail.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 97, 2 },
                column: "Email",
                value: "PhiCuong.Ngo70@yahoo.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 99, 1 },
                column: "Email",
                value: "NhatKhuong.To@hotmail.com");

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "EmployeeID", "RoleID", "Email", "LastLogin", "Lock", "Password" },
                values: new object[,]
                {
                    { 1, 2, "VietSon_Bui@hotmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 5, 1, "DanKhanh_Tran@yahoo.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 7, 1, "HuuCuong54@yahoo.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 8, 2, "KieuTrinh_Tran79@yahoo.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 9, 1, "TruongVu86@gmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 10, 2, "DuyLuan_Pham@gmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 12, 2, "ThienLuan_Hoang40@hotmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 16, 2, "MinhDan.Vu56@yahoo.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 19, 1, "VietAnh42@yahoo.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 22, 1, "ThuPhuong61@gmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 23, 1, "GiangUyen.Bui92@yahoo.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 26, 1, "OanhVu.Pham22@yahoo.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 30, 1, "TrieuThanh42@hotmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 32, 1, "ThuyDu_Truong@yahoo.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 34, 2, "LinhSan8@yahoo.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 35, 1, "MaiHa.Bui@yahoo.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 36, 1, "ThanhTin_Dinh@hotmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 38, 2, "AnhTuan.Tang9@hotmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 39, 2, "HongGiang.Truong25@hotmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 41, 1, "KimPhuong.To@gmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 42, 1, "BinhDat.Trinh@yahoo.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 45, 2, "ThuDuyen.Phung62@hotmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 46, 1, "HuuKhoat23@yahoo.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 50, 2, "XuanHien_Dao@hotmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 54, 2, "DiemLien26@yahoo.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 60, 1, "DaiTrang.To92@gmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 61, 2, "NgocHoan40@gmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 62, 2, "DanKhanh.To26@gmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 63, 1, "CongGiang.Mai38@hotmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 67, 2, "VietTuyet.Tran89@hotmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 70, 2, "ThuNhan35@gmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 71, 2, "ThuyVan_Ha53@gmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 72, 2, "NguyenPhong_Dang@hotmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 76, 1, "ThuanToan.Vu40@yahoo.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 79, 2, "CuongThinh_Nguyen46@hotmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 80, 1, "AnhThao_Ngo@hotmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 81, 2, "NgocHien_Pham78@hotmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 82, 1, "MinhHuyen38@hotmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 83, 2, "MyHuong.Dinh@hotmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 87, 1, "LanNhi_Tran99@yahoo.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 89, 1, "KieuHoa_Doan64@gmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 95, 1, "PhuongVy_Tran45@yahoo.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 96, 1, "VinhToan.Pham21@gmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 98, 2, "DanQue_Truong@yahoo.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 100, 1, "CamHuong4@hotmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" }
                });

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "RoleID",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2024, 5, 13, 14, 38, 37, 93, DateTimeKind.Local).AddTicks(2033));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "RoleID",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2024, 5, 13, 14, 38, 37, 93, DateTimeKind.Local).AddTicks(2067));

            migrationBuilder.AddForeignKey(
                name: "FK_ImportOrder_Employee_EmployeeID",
                table: "ImportOrder",
                column: "EmployeeID",
                principalTable: "Employee",
                principalColumn: "EmployeeID");

            migrationBuilder.AddForeignKey(
                name: "FK_ImportOrder_Provider_ProviderID",
                table: "ImportOrder",
                column: "ProviderID",
                principalTable: "Provider",
                principalColumn: "ProviderID");

            migrationBuilder.AddForeignKey(
                name: "FK_SalesOrder_Customer_CustomerID",
                table: "SalesOrder",
                column: "CustomerID",
                principalTable: "Customer",
                principalColumn: "CustomerID");

            migrationBuilder.AddForeignKey(
                name: "FK_SalesOrder_Employee_EmployeeID",
                table: "SalesOrder",
                column: "EmployeeID",
                principalTable: "Employee",
                principalColumn: "EmployeeID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 5, 1 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 7, 1 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 8, 2 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 9, 1 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 10, 2 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 12, 2 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 16, 2 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 19, 1 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 22, 1 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 23, 1 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 26, 1 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 30, 1 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 32, 1 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 34, 2 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 35, 1 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 36, 1 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 38, 2 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 39, 2 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 41, 1 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 42, 1 });

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
                keyValues: new object[] { 50, 2 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 54, 2 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 60, 1 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 61, 2 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 62, 2 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 63, 1 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 67, 2 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 70, 2 });

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
                keyValues: new object[] { 76, 1 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 79, 2 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 80, 1 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 81, 2 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 82, 1 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 83, 2 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 87, 1 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 89, 1 });

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
                keyValues: new object[] { 98, 2 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 100, 1 });

            migrationBuilder.AlterColumn<int>(
                name: "EmployeeID",
                table: "SalesOrder",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CustomerID",
                table: "SalesOrder",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ProviderID",
                table: "ImportOrder",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "EmployeeID",
                table: "ImportOrder",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 1,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Quảng Ninh", "Như Hoa Hồ", new DateTime(2024, 4, 20, 16, 6, 48, 33, DateTimeKind.Local).AddTicks(9192), "DuyMinh75@gmail.com", "0962623150" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 2,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Yên Bái", "Gia Khiêm Mai", new DateTime(2024, 4, 20, 16, 6, 48, 34, DateTimeKind.Local).AddTicks(1822), "SonHai.Le@yahoo.com", "0904872361" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 3,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Hà Tĩnh", "Ngọc Tiển Đào", new DateTime(2024, 4, 20, 16, 6, 48, 34, DateTimeKind.Local).AddTicks(1931), "MinhHanh.Do@yahoo.com", "0909431862" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 4,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Thái Nguyên", "Ánh Dương Trịnh", new DateTime(2024, 4, 20, 16, 6, 48, 34, DateTimeKind.Local).AddTicks(2009), "DucTri.Truong47@hotmail.com", "0978646356" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 5,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Nghệ An", "Ngọc Khương Vũ", new DateTime(2024, 4, 20, 16, 6, 48, 34, DateTimeKind.Local).AddTicks(2088), "HoaLy_Duong@gmail.com", "0924686491" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 6,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Cần Thơ", "Phương Lan Lê", new DateTime(2024, 4, 20, 16, 6, 48, 34, DateTimeKind.Local).AddTicks(2156), "QuocHai.Dao39@gmail.com", "0979219405" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 7,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Hòa Bình", "Thục Trinh Hoàng", new DateTime(2024, 4, 20, 16, 6, 48, 34, DateTimeKind.Local).AddTicks(2219), "HuyenAnh_Ho@yahoo.com", "0932539502" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 8,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Đồng Tháp", "Lan Trúc Vương", new DateTime(2024, 4, 20, 16, 6, 48, 34, DateTimeKind.Local).AddTicks(2293), "HanhMy_Truong74@hotmail.com", "0904333893" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 9,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Quảng Ninh", "Lâm Nhi Lê", new DateTime(2024, 4, 20, 16, 6, 48, 34, DateTimeKind.Local).AddTicks(2357), "BaLoc_Truong50@gmail.com", "0975367701" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 10,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Cần Thơ", "Tuyền Lâm Dương", new DateTime(2024, 4, 20, 16, 6, 48, 34, DateTimeKind.Local).AddTicks(2423), "ThanhMan80@gmail.com", "0926329337" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 11,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Lai Châu", "Khuê Trung Phạm", new DateTime(2024, 4, 20, 16, 6, 48, 34, DateTimeKind.Local).AddTicks(2485), "HuuTam.Ha@hotmail.com", "0972274479" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 12,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Bắc Ninh", "Hương Ly Trương", new DateTime(2024, 4, 20, 16, 6, 48, 34, DateTimeKind.Local).AddTicks(2545), "MinhHuan_Tang@hotmail.com", "0926603466" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 13,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Vĩnh Phúc", "Uyển Nhi Đặng", new DateTime(2024, 4, 20, 16, 6, 48, 34, DateTimeKind.Local).AddTicks(2605), "DucPhong96@yahoo.com", "0909149158" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 14,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Thanh Hoá", "Kim Lan Ngô", new DateTime(2024, 4, 20, 16, 6, 48, 34, DateTimeKind.Local).AddTicks(2668), "QuangThuan70@yahoo.com", "0925403370" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 15,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Tuyên Quang", "Ngọc Ðiệp Trương", new DateTime(2024, 4, 20, 16, 6, 48, 34, DateTimeKind.Local).AddTicks(2736), "ChanHung_Do@hotmail.com", "0916772170" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 16,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Đắk Lắk", "Quân Dương Trần", new DateTime(2024, 4, 20, 16, 6, 48, 34, DateTimeKind.Local).AddTicks(2795), "LienChi_Vuong19@gmail.com", "0936858504" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 17,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Tây Ninh", "Tuyết Trinh Trần", new DateTime(2024, 4, 20, 16, 6, 48, 34, DateTimeKind.Local).AddTicks(2868), "QuocDien.Vuong@yahoo.com", "0972154857" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 18,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Hà Nội", "Hướng Tiền Phùng", new DateTime(2024, 4, 20, 16, 6, 48, 34, DateTimeKind.Local).AddTicks(2925), "BaLong78@yahoo.com", "0965638217" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 19,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Thái Nguyên", "Hồng Liêm Trịnh", new DateTime(2024, 4, 20, 16, 6, 48, 34, DateTimeKind.Local).AddTicks(2985), "AiNhi8@yahoo.com", "0990812129" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 20,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "An Giang", "Hương Liên Lâm", new DateTime(2024, 4, 20, 16, 6, 48, 34, DateTimeKind.Local).AddTicks(3045), "HongThu30@hotmail.com", "0960583964" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 21,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Kon Tum", "Thượng Năng Phùng", new DateTime(2024, 4, 20, 16, 6, 48, 34, DateTimeKind.Local).AddTicks(3108), "MinhMinh96@gmail.com", "0987537010" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 22,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Tuyên Quang", "Chí Thanh Hồ", new DateTime(2024, 4, 20, 16, 6, 48, 34, DateTimeKind.Local).AddTicks(3167), "LeBang_Hoang@gmail.com", "0928013598" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 23,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Sơn La", "Thanh Phi Lâm", new DateTime(2024, 4, 20, 16, 6, 48, 34, DateTimeKind.Local).AddTicks(3234), "TrangNha_Lam39@yahoo.com", "0919185248" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 24,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Hậu Giang", "Bảo Thạch Hà", new DateTime(2024, 4, 20, 16, 6, 48, 34, DateTimeKind.Local).AddTicks(3293), "KimLan_Pham@yahoo.com", "0910956563" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 25,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Hà Nam", "Khánh Hoàn Bùi", new DateTime(2024, 4, 20, 16, 6, 48, 34, DateTimeKind.Local).AddTicks(3352), "BichSan.Mai88@hotmail.com", "0920139749" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 26,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Kiên Giang", "Thanh Thiên Nguyễn", new DateTime(2024, 4, 20, 16, 6, 48, 34, DateTimeKind.Local).AddTicks(3414), "DieuNuong_Nguyen@yahoo.com", "0926726997" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 27,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Cao Bằng", "Thi Ngôn Đào", new DateTime(2024, 4, 20, 16, 6, 48, 34, DateTimeKind.Local).AddTicks(3477), "HaiYen15@gmail.com", "0983059863" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 28,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Hậu Giang", "Phước Lộc Phan", new DateTime(2024, 4, 20, 16, 6, 48, 34, DateTimeKind.Local).AddTicks(3545), "KhoiNguyen.Nguyen@gmail.com", "0957138280" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 29,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Kiên Giang", "Vinh Quốc Lâm", new DateTime(2024, 4, 20, 16, 6, 48, 34, DateTimeKind.Local).AddTicks(3615), "BichHien_Bui@hotmail.com", "0976140611" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 30,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Bà Rịa-Vũng Tàu", "Mạnh Trình Trịnh", new DateTime(2024, 4, 20, 16, 6, 48, 34, DateTimeKind.Local).AddTicks(3676), "DucThang19@yahoo.com", "0921803919" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 31,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Cao Bằng", "Nguyệt Quế Vũ", new DateTime(2024, 4, 20, 16, 6, 48, 34, DateTimeKind.Local).AddTicks(3737), "MaiAnh.Doan15@yahoo.com", "0976801351" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 32,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Sơn La", "Việt Khuê Phan", new DateTime(2024, 4, 20, 16, 6, 48, 34, DateTimeKind.Local).AddTicks(3800), "NgocQuyen_Lam@yahoo.com", "0952625460" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 33,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Thái Nguyên", "Hòa Hợp Hồ", new DateTime(2024, 4, 20, 16, 6, 48, 34, DateTimeKind.Local).AddTicks(3863), "MinhThuong_Ho30@yahoo.com", "0995807834" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 34,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Điện Biên", "Ðình Cường Phùng", new DateTime(2024, 4, 20, 16, 6, 48, 34, DateTimeKind.Local).AddTicks(3926), "DangDat.Phan74@hotmail.com", "0950275809" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 35,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Bắc Giang", "Thúy Nga Phan", new DateTime(2024, 4, 20, 16, 6, 48, 34, DateTimeKind.Local).AddTicks(3990), "MinhDanh.Pham10@hotmail.com", "0999159499" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 36,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Cần Thơ", "Thanh Tuấn Phan", new DateTime(2024, 4, 20, 16, 6, 48, 34, DateTimeKind.Local).AddTicks(4049), "ThuGiang.Vuong@yahoo.com", "0934708712" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 37,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "TP. Hồ Chí Minh", "Lệ Quân Phạm", new DateTime(2024, 4, 20, 16, 6, 48, 34, DateTimeKind.Local).AddTicks(4112), "ThanhHoa0@gmail.com", "0923510611" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 38,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Tiền Giang", "Anh Khoa Vương", new DateTime(2024, 4, 20, 16, 6, 48, 34, DateTimeKind.Local).AddTicks(4169), "HoangViet_Nguyen@yahoo.com", "0974969797" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 39,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Vĩnh Phúc", "Thanh Thư Bùi", new DateTime(2024, 4, 20, 16, 6, 48, 34, DateTimeKind.Local).AddTicks(4233), "QuocMy.Do@hotmail.com", "0978936365" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 40,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Bạc Liêu", "Hải Ngân Ngô", new DateTime(2024, 4, 20, 16, 6, 48, 34, DateTimeKind.Local).AddTicks(4292), "DucAn_Ly@gmail.com", "0932469540" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 41,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Cao Bằng", "Bích Hậu Đỗ", new DateTime(2024, 4, 20, 16, 6, 48, 34, DateTimeKind.Local).AddTicks(4349), "ThuyKieu_Phan84@hotmail.com", "0950021420" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 42,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Trà Vinh", "Bá Thiện Ngô", new DateTime(2024, 4, 20, 16, 6, 48, 34, DateTimeKind.Local).AddTicks(4410), "HaGiang_Vu68@yahoo.com", "0975987276" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 43,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Tây Ninh", "Bảo Tiên Ngô", new DateTime(2024, 4, 20, 16, 6, 48, 34, DateTimeKind.Local).AddTicks(4475), "HaHai_Nguyen59@gmail.com", "0921028706" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 44,
                columns: new[] { "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Hồng Thắm Hà", new DateTime(2024, 4, 20, 16, 6, 48, 34, DateTimeKind.Local).AddTicks(4531), "HongTham_Hoang@hotmail.com", "0996725189" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 45,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Lai Châu", "Thanh Minh Trịnh", new DateTime(2024, 4, 20, 16, 6, 48, 34, DateTimeKind.Local).AddTicks(4593), "DuyNhuong.Ho@hotmail.com", "0940038906" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 46,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Hà Giang", "Tài Nguyên Phạm", new DateTime(2024, 4, 20, 16, 6, 48, 34, DateTimeKind.Local).AddTicks(4666), "PhiHung.Le45@hotmail.com", "0964517147" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 47,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Quảng Ninh", "Minh Thông Phùng", new DateTime(2024, 4, 20, 16, 6, 48, 34, DateTimeKind.Local).AddTicks(4719), "NhuAnh75@hotmail.com", "0905640738" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 48,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Thái Bình", "Minh Khang Dương", new DateTime(2024, 4, 20, 16, 6, 48, 34, DateTimeKind.Local).AddTicks(4779), "DinhLoc_Dinh41@yahoo.com", "0930552174" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 49,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Hậu Giang", "Phương Thi Lâm", new DateTime(2024, 4, 20, 16, 6, 48, 34, DateTimeKind.Local).AddTicks(4836), "MyHanh.Truong@yahoo.com", "0915118777" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 50,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Cà Mau", "Trúc Vy Ngô", new DateTime(2024, 4, 20, 16, 6, 48, 34, DateTimeKind.Local).AddTicks(4902), "PhuongNga.Phan76@hotmail.com", "0910688752" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 51,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Bắc Giang", "Thúy Vy Lý", new DateTime(2024, 4, 20, 16, 6, 48, 34, DateTimeKind.Local).AddTicks(4961), "XuanKien_Bui94@gmail.com", "0994769804" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 52,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Lâm Đồng", "Xuân Minh Đoàn", new DateTime(2024, 4, 20, 16, 6, 48, 34, DateTimeKind.Local).AddTicks(5022), "MinhMan.Ly53@hotmail.com", "0908557367" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 53,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "An Giang", "Trúc Sinh Trương", new DateTime(2024, 4, 20, 16, 6, 48, 34, DateTimeKind.Local).AddTicks(5078), "ThuHau_Dinh93@hotmail.com", "0911463593" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 54,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Hải Dương", "Bích Hiền Tô", new DateTime(2024, 4, 20, 16, 6, 48, 34, DateTimeKind.Local).AddTicks(5138), "ThienTam_Ho@hotmail.com", "0993722270" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 55,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Phú Yên", "Minh Châu Trương", new DateTime(2024, 4, 20, 16, 6, 48, 34, DateTimeKind.Local).AddTicks(5193), "TrongKien.Dinh@hotmail.com", "0976508388" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 56,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Thái Nguyên", "Kiều Minh Hà", new DateTime(2024, 4, 20, 16, 6, 48, 34, DateTimeKind.Local).AddTicks(5258), "TheHuan.Do4@gmail.com", "0963852861" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 57,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Hà Tĩnh", "Bích Hợp Lý", new DateTime(2024, 4, 20, 16, 6, 48, 34, DateTimeKind.Local).AddTicks(5319), "XuanYen27@yahoo.com", "0926069209" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 58,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Kon Tum", "Nhật Lệ Tăng", new DateTime(2024, 4, 20, 16, 6, 48, 34, DateTimeKind.Local).AddTicks(5375), "QueAnh.Tang43@yahoo.com", "0970533136" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 59,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Hòa Bình", "Hòa Hiệp Bùi", new DateTime(2024, 4, 20, 16, 6, 48, 34, DateTimeKind.Local).AddTicks(5436), "ThanhVinh.Phan@hotmail.com", "0985858802" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 60,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Cần Thơ", "Lưu Ly Trương", new DateTime(2024, 4, 20, 16, 6, 48, 34, DateTimeKind.Local).AddTicks(5494), "HongKhanh_Phan@hotmail.com", "0931605508" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 61,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Vĩnh Long", "Bích Hảo Hồ", new DateTime(2024, 4, 20, 16, 6, 48, 34, DateTimeKind.Local).AddTicks(5555), "TaiDuc_Pham@yahoo.com", "0904113629" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 62,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Hòa Bình", "Ðại Thống Lê", new DateTime(2024, 4, 20, 16, 6, 48, 34, DateTimeKind.Local).AddTicks(5611), "TruongLong.Ngo@gmail.com", "0983219432" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 63,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Hà Nội", "Ngọc Lệ Phan", new DateTime(2024, 4, 20, 16, 6, 48, 34, DateTimeKind.Local).AddTicks(5674), "ThienMy75@yahoo.com", "0925609084" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 64,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Phú Yên", "Thanh Thiên Tô", new DateTime(2024, 4, 20, 16, 6, 48, 34, DateTimeKind.Local).AddTicks(5740), "ThuMinh.Nguyen@gmail.com", "0937416607" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 65,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Đắk Nông", "Xuân Cung Đỗ", new DateTime(2024, 4, 20, 16, 6, 48, 34, DateTimeKind.Local).AddTicks(5802), "ThienThao87@gmail.com", "0942258185" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 66,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Tây Ninh", "Trường Chinh Phùng", new DateTime(2024, 4, 20, 16, 6, 48, 34, DateTimeKind.Local).AddTicks(5857), "KimThu56@hotmail.com", "0931119803" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 67,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Nam Định", "Quỳnh Dao Đặng", new DateTime(2024, 4, 20, 16, 6, 48, 34, DateTimeKind.Local).AddTicks(5916), "ChuanKhoa.Tang82@gmail.com", "0933136721" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 68,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Thái Nguyên", "Hoài Bắc Phạm", new DateTime(2024, 4, 20, 16, 6, 48, 34, DateTimeKind.Local).AddTicks(5980), "HanhLinh_Ha@hotmail.com", "0940130604" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 69,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Nghệ An", "Kiên Bình Đỗ", new DateTime(2024, 4, 20, 16, 6, 48, 34, DateTimeKind.Local).AddTicks(6041), "DuyCuong5@gmail.com", "0975296327" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 70,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Khánh Hoà", "Thiên Nga Nguyễn", new DateTime(2024, 4, 20, 16, 6, 48, 34, DateTimeKind.Local).AddTicks(6109), "MinhNhan33@gmail.com", "0918372732" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 71,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Quảng Trị", "Thy Trúc Hà", new DateTime(2024, 4, 20, 16, 6, 48, 34, DateTimeKind.Local).AddTicks(6166), "NgocDiep_Ly@gmail.com", "0960279821" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 72,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Quảng Bình", "Nhật Duy Ngô", new DateTime(2024, 4, 20, 16, 6, 48, 34, DateTimeKind.Local).AddTicks(6226), "ThinhCuong_Truong84@hotmail.com", "0990304849" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 73,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Quảng Bình", "Ðông Nhi Phùng", new DateTime(2024, 4, 20, 16, 6, 48, 34, DateTimeKind.Local).AddTicks(6295), "VietNhi_Vuong7@yahoo.com", "0944975904" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 74,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Hà Nội", "Ðức Bình Mai", new DateTime(2024, 4, 20, 16, 6, 48, 34, DateTimeKind.Local).AddTicks(6362), "LamOanh85@gmail.com", "0908868700" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 75,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Cà Mau", "Bảo Vy Tăng", new DateTime(2024, 4, 20, 16, 6, 48, 34, DateTimeKind.Local).AddTicks(6417), "MinhVu.Le@yahoo.com", "0979203985" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 76,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Cao Bằng", "Duy Minh Nguyễn", new DateTime(2024, 4, 20, 16, 6, 48, 34, DateTimeKind.Local).AddTicks(6475), "MongVi_Vuong5@yahoo.com", "0982881771" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 77,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Hà Nội", "Hàm Thơ Đặng", new DateTime(2024, 4, 20, 16, 6, 48, 34, DateTimeKind.Local).AddTicks(6536), "BaoAn_Mai65@gmail.com", "0998510214" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 78,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Tây Ninh", "Tuấn Khải Trần", new DateTime(2024, 4, 20, 16, 6, 48, 34, DateTimeKind.Local).AddTicks(6600), "HaVy2@yahoo.com", "0905596760" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 79,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Thanh Hoá", "Hoàn Vũ Vũ", new DateTime(2024, 4, 20, 16, 6, 48, 34, DateTimeKind.Local).AddTicks(6657), "ThongTue_Hoang62@gmail.com", "0916854270" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 80,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Lâm Đồng", "Yến Thảo Mai", new DateTime(2024, 4, 20, 16, 6, 48, 34, DateTimeKind.Local).AddTicks(6714), "MyThuan48@hotmail.com", "0985397985" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 81,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Đắk Nông", "Diệu Anh Trịnh", new DateTime(2024, 4, 20, 16, 6, 48, 34, DateTimeKind.Local).AddTicks(6778), "PhuongTrinh_Dang74@yahoo.com", "0965833355" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 82,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Kiên Giang", "Minh Hào Phạm", new DateTime(2024, 4, 20, 16, 6, 48, 34, DateTimeKind.Local).AddTicks(6838), "ThuyDu.Vu81@yahoo.com", "0961572282" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 83,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Cao Bằng", "Minh Uyên Phạm", new DateTime(2024, 4, 20, 16, 6, 48, 34, DateTimeKind.Local).AddTicks(6900), "KimXuyen.Duong@yahoo.com", "0901490219" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 84,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Cà Mau", "Nam An Vũ", new DateTime(2024, 4, 20, 16, 6, 48, 34, DateTimeKind.Local).AddTicks(6959), "KhanhGiang_Hoang71@yahoo.com", "0969193921" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 85,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Đồng Tháp", "Ðình Kim Ngô", new DateTime(2024, 4, 20, 16, 6, 48, 34, DateTimeKind.Local).AddTicks(7031), "ThanhTung_Ly6@hotmail.com", "0986414987" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 86,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Hải Phòng", "Gia Cần Vũ", new DateTime(2024, 4, 20, 16, 6, 48, 34, DateTimeKind.Local).AddTicks(7086), "MinhHang63@gmail.com", "0983915652" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 87,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Phú Yên", "Thanh Huy Lâm", new DateTime(2024, 4, 20, 16, 6, 48, 34, DateTimeKind.Local).AddTicks(7148), "VanPhuong.Tran@yahoo.com", "0910094533" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 88,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Điện Biên", "Thảo My Đinh", new DateTime(2024, 4, 20, 16, 6, 48, 34, DateTimeKind.Local).AddTicks(7209), "MaiThanh83@hotmail.com", "0962223002" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 89,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Nam Định", "Hoài Việt Phùng", new DateTime(2024, 4, 20, 16, 6, 48, 34, DateTimeKind.Local).AddTicks(7266), "DiemPhuoc.Dao@yahoo.com", "0963453003" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 90,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Đà Nẵng", "Trường Hiệp Đoàn", new DateTime(2024, 4, 20, 16, 6, 48, 34, DateTimeKind.Local).AddTicks(7327), "QuangLoc_Vuong@gmail.com", "0946997439" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 91,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "TP. Hồ Chí Minh", "Duy Thạch Tăng", new DateTime(2024, 4, 20, 16, 6, 48, 34, DateTimeKind.Local).AddTicks(7384), "ChiSon_Phung97@gmail.com", "0947859353" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 92,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Hậu Giang", "Minh Nghĩa Hoàng", new DateTime(2024, 4, 20, 16, 6, 48, 34, DateTimeKind.Local).AddTicks(7446), "HiepDinh64@yahoo.com", "0961194495" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 93,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Quảng Trị", "Như Khang Đỗ", new DateTime(2024, 4, 20, 16, 6, 48, 34, DateTimeKind.Local).AddTicks(7503), "CaoSy52@hotmail.com", "0991306055" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 94,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Thái Bình", "Ðại Dương Vũ", new DateTime(2024, 4, 20, 16, 6, 48, 34, DateTimeKind.Local).AddTicks(7565), "HongHa.Hoang6@hotmail.com", "0977541074" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 95,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Bến Tre", "Bách Nhân Phạm", new DateTime(2024, 4, 20, 16, 6, 48, 34, DateTimeKind.Local).AddTicks(7621), "XuanKhoa67@hotmail.com", "0996786677" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 96,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Quảng Nam", "Trường Vũ Đỗ", new DateTime(2024, 4, 20, 16, 6, 48, 34, DateTimeKind.Local).AddTicks(7683), "KhanhLy.Ho@hotmail.com", "0907052375" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 97,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Lâm Đồng", "Tuấn Hải Đỗ", new DateTime(2024, 4, 20, 16, 6, 48, 34, DateTimeKind.Local).AddTicks(7738), "HoangPhat_Dao@yahoo.com", "0974798474" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 98,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Khánh Hoà", "Thúy Minh Hà", new DateTime(2024, 4, 20, 16, 6, 48, 34, DateTimeKind.Local).AddTicks(7798), "VanMinh.Pham@yahoo.com", "0903472973" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 99,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Tây Ninh", "Minh Khôi Đặng", new DateTime(2024, 4, 20, 16, 6, 48, 34, DateTimeKind.Local).AddTicks(7859), "CongLap74@hotmail.com", "0906535024" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 100,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Cao Bằng", "Phương Nam Vũ", new DateTime(2024, 4, 20, 16, 6, 48, 34, DateTimeKind.Local).AddTicks(7919), "ThanhKien35@gmail.com", "0970224396" });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 188, 23782.337147665520000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 2, 2 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 126, 20032.006386096280000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 3, 3 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 109, 42052.508792557120000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 4, 4 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 199, 14762.184015541880000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 5, 5 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 119, 33740.096937492280000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 6, 6 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 132, 26774.069641630840000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 7, 7 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 137, 49847.620165532040000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 8, 8 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 146, 17742.722445967320000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 9, 9 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 133, 18311.137027757680000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 10, 10 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 174, 32111.988428366200000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 11, 11 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 161, 32427.209091836240000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 12, 12 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 172, 28366.413575867720000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 13, 13 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 124, 30948.297029216480000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 14, 14 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 118, 44030.836672188880000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 15, 15 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 161, 33299.203446976480000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 16, 16 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 155, 26758.260165805640000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 17, 17 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 116, 27358.400386971720000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 18, 18 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 198, 31227.018996645800000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 19, 19 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 114, 39530.776858413720000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 20, 20 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 181, 18832.179028260280000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 21, 21 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 146, 45094.249484101680000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 22, 22 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 112, 19888.82920082720000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 23, 23 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 121, 14350.115409228960000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 24, 24 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 165, 21964.055261977240000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 25, 25 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 135, 25328.055288344440000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 26, 26 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 103, 49367.901063766240000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 27, 27 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 184, 24507.921380059680000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 28, 28 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 129, 11531.1343528504320000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 29, 29 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 177, 28491.896888883000000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 30, 30 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 144, 36248.217811269680000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 31, 31 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 106, 34916.678504131640000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 32, 32 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 158, 24834.176792320920000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 33, 33 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 192, 30224.432480364480000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 34, 34 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 141, 38308.843285797080000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 35, 35 },
                column: "UnitPrice",
                value: 32102.708454718680000m);

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 36, 36 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 101, 37996.468484079960000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 37, 37 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 195, 14020.410120289520000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 38, 38 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 123, 49996.513541623040000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 39, 39 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 153, 13499.812417402840000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 40, 40 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 109, 18751.342070718360000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 41, 41 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 115, 30357.771300235280000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 42, 42 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 187, 35125.715133773560000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 43, 43 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 113, 34222.208482853080000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 44, 44 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 168, 21419.409922700480000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 45, 45 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 176, 26992.726294171960000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 46, 46 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 196, 49002.581887216960000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 47, 47 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 158, 20583.159935028480000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 48, 48 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 166, 44512.274843533480000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 49, 49 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 182, 28001.637150183320000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 50, 50 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 183, 11104.7311034084200000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 51, 51 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 181, 27176.408492905320000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 52, 52 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 116, 29133.185977769320000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 53, 53 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 112, 14490.085305720680000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 54, 54 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 112, 35417.827677158280000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 55, 55 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 134, 27725.241518218320000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 56, 56 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 138, 18515.928617090840000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 57, 57 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 131, 30122.862008437800000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 58, 58 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 148, 20457.033711905400000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 59, 59 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 173, 16658.482241732080000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 60, 60 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 152, 28646.375655461880000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 61, 61 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 126, 21533.795777356280000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 62, 62 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 163, 29580.505884493040000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 63, 63 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 199, 13355.4530253137680000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 64, 64 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 132, 10149.73712465930160000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 65, 65 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 127, 22163.821455038560000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 66, 66 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 116, 17194.570875618240000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 67, 67 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 178, 20929.411376368760000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 68, 68 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 198, 40076.846624619760000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 69, 69 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 148, 14267.197672132320000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 70, 70 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 199, 47696.737912489000000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 71, 71 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 104, 28210.845559594320000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 72, 72 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 158, 34357.874317488040000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 73, 73 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 143, 43668.730861965520000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 74, 74 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 124, 21277.337188561680000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 75, 75 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 159, 43454.766852679320000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 76, 76 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 140, 44956.074442058960000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 77, 77 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 168, 44513.448321056600000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 78, 78 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 137, 28132.198532306080000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 79, 79 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 198, 47552.433994743960000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 80, 80 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 169, 13262.6051885919960000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 81, 81 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 119, 38902.42249937440000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 82, 82 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 193, 26857.627866360320000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 83, 83 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 184, 25204.519332288880000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 84, 84 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 181, 25565.766731599800000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 85, 85 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 115, 37506.801497530680000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 86, 86 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 100, 11371.9664856033160000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 87, 87 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 188, 26200.29232671960000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 88, 88 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 116, 34201.7503154080000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 89, 89 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 193, 39325.668226491400000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 90, 90 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 177, 32528.798315537360000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 91, 91 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 119, 22047.0274252360000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 92, 92 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 188, 27056.62563035240000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 93, 93 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 122, 19672.862433360160000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 94, 94 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 127, 23920.378969528240000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 95, 95 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 164, 26069.891999493920000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 96, 96 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 138, 30993.017002467640000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 97, 97 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 148, 14253.771772329400000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 98, 98 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 156, 26627.133080494440000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 99, 99 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 162, 48838.130000401680000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 100, 100 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 130, 38534.232946867240000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 86, 184318.235868445200000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 2, 2 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 74, 144548.131105429300000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 3, 3 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 74, 198496.002563571200000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 4, 4 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 50, 183010.005357765700000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 5, 5 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 85, 194462.377173322800000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 6, 6 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 88, 169052.696872161200000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 7, 7 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 71, 180472.791585675500000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 8, 8 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 67, 123716.208291365700000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 9, 9 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 83, 191917.046995999100000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 10, 10 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 90, 102512.9094494061400000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 11, 11 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 67, 166215.565534735300000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 12, 12 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 57, 151940.423461197600000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 13, 13 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 81, 124549.50923706800000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 14, 14 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 74, 179768.873608786400000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 15, 15 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 74, 124604.614859503500000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 16, 16 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 90, 164842.215600988200000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 17, 17 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 63, 117353.176826650200000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 18, 18 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 60, 144962.796712742900000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 19, 19 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 69, 105070.4178284928700000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 20, 20 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 67, 159119.409355757900000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 21, 21 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 88, 174754.051035225400000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 22, 22 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 50, 147725.17384247800000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 23, 23 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 90, 189251.268878471100000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 24, 24 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 55, 175468.538107485600000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 25, 25 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 56, 145281.389446212400000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 26, 26 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 87, 179711.823536378500000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 27, 27 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 86, 183832.843615179400000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 28, 28 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 58, 109386.3841706807100000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 29, 29 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 85, 115067.090235449900000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 30, 30 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 77, 129437.316491051900000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 31, 31 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 53, 179745.1348982100000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 32, 32 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 53, 147023.193579765700000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 33, 33 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 75, 186495.065870133800000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 34, 34 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 77, 140086.767540377400000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 35, 35 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 55, 191920.274742927100000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 36, 36 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 80, 118157.231345558700000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 37, 37 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 90, 166491.106101215800000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 38, 38 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 58, 181053.771378156400000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 39, 39 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 62, 187690.26726032100000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 40, 40 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 76, 119074.363438809700000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 41, 41 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 76, 190954.752188499600000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 42, 42 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 66, 122741.221362514400000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 43, 43 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 62, 136632.8503030700000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 44, 44 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 57, 195711.837952844200000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 45, 45 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 77, 106801.7013939062200000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 46, 46 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 83, 174169.549597339200000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 47, 47 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 51, 151631.873061003500000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 48, 48 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 87, 147612.424585914800000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 49, 49 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 77, 108088.1472827965100000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 50, 50 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 72, 182911.128706656600000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 51, 51 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 72, 126715.264991919700000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 52, 52 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 67, 106429.773301218300000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 53, 53 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 79, 197091.284786811500000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 54, 54 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 62, 191973.878478103400000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 55, 55 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 83, 168728.347614053800000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 56, 56 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 60, 190277.745196069300000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 57, 57 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 69, 107420.8655470431200000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 58, 58 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 85, 130337.474929280400000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 59, 59 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 78, 109548.3290715477200000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 60, 60 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 90, 154589.759831223100000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 61, 61 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 58, 127729.566552862300000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 62, 62 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 50, 182029.19675109600000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 63, 63 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 59, 106593.5669757245100000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 64, 64 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 87, 123698.862457501200000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 65, 65 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 60, 183494.526150747200000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 66, 66 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 66, 194698.458784542400000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 67, 67 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 62, 146257.425321682100000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 68, 68 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 64, 176434.928469481900000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 69, 69 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 86, 191858.428939563800000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 70, 70 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 53, 163754.783431659500000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 71, 71 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 59, 159062.726816565700000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 72, 72 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 85, 128159.942782980300000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 73, 73 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 63, 122445.510339298700000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 74, 74 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 81, 162389.793313838500000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 75, 75 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 57, 146465.843486627700000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 76, 76 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 69, 163228.515152306100000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 77, 77 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 61, 182394.495880331600000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 78, 78 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 84, 191337.234034556900000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 79, 79 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 80, 169950.119680879100000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 80, 80 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 75, 175469.76809156500000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 81, 81 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 72, 102680.7029179511900000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 82, 82 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 63, 132220.521648500000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 83, 83 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 55, 123428.629650641100000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 84, 84 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 52, 197660.21439266700000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 85, 85 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 65, 142109.94075526500000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 86, 86 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 55, 142698.156278966400000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 87, 87 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 53, 134186.510141579100000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 88, 88 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 71, 186030.64220490400000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 89, 89 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 56, 122240.934237545600000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 90, 90 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 58, 119852.693332916400000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 91, 91 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 73, 174521.83597661100000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 92, 92 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 66, 110798.819448765100000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 93, 93 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 75, 143207.837198977600000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 94, 94 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 76, 158717.527488697500000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 95, 95 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 89, 104746.4727560612500000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 96, 96 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 80, 135946.128730162700000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 97, 97 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 79, 184342.023018784800000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 98, 98 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 76, 137398.780589816700000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 99, 99 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 70, 134359.811058059300000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 100, 100 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 74, 195249.007509132900000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 1,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Nam Định", new DateTime(2024, 4, 20, 16, 6, 48, 38, DateTimeKind.Local).AddTicks(7633), "HoangXuan_Ho@gmail.com", "Ðình Tuấn Lê", "0995720782", 968511.800722463000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 2,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Tây Ninh", new DateTime(2024, 4, 20, 16, 6, 48, 38, DateTimeKind.Local).AddTicks(9423), "VietHung_Dang25@hotmail.com", "Như Loan Trần", "0950902992", 682496.460713948500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 3,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Gia Lai", new DateTime(2024, 4, 20, 16, 6, 48, 38, DateTimeKind.Local).AddTicks(9537), "DieuVan_To89@yahoo.com", "Thanh Đan Lâm", "0934884966", 528155.7131556028000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 4,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Thừa Thiên-Huế", new DateTime(2024, 4, 20, 16, 6, 48, 38, DateTimeKind.Local).AddTicks(9577), "BangTam.Dang84@gmail.com", "Thủy Tâm Trịnh", "0966572776", 925070.426668422000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 5,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Bình Phước", new DateTime(2024, 4, 20, 16, 6, 48, 38, DateTimeKind.Local).AddTicks(9614), "KietHong_Dang@gmail.com", "Bích Phượng Vương", "0905052245", 680318.512951758500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 6,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Cà Mau", new DateTime(2024, 4, 20, 16, 6, 48, 38, DateTimeKind.Local).AddTicks(9656), "QuocHoa_To@yahoo.com", "Xuân Mai Ngô", "0900045411", 895438.354575107000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 7,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Hà Nội", new DateTime(2024, 4, 20, 16, 6, 48, 38, DateTimeKind.Local).AddTicks(9691), "TamNguyet91@yahoo.com", "Ðức Bình Lâm", "0950658804", 895794.213468024500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 8,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Điện Biên", new DateTime(2024, 4, 20, 16, 6, 48, 38, DateTimeKind.Local).AddTicks(9724), "QuocQuang.Dao@gmail.com", "Minh Danh Nguyễn", "0971319686", 782636.392666198000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 9,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Bắc Kạn", new DateTime(2024, 4, 20, 16, 6, 48, 38, DateTimeKind.Local).AddTicks(9763), "MinhThien.Ly@hotmail.com", "Nhã Thanh Hà", "0986357855", 820330.878336856000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 10,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Sơn La", new DateTime(2024, 4, 20, 16, 6, 48, 38, DateTimeKind.Local).AddTicks(9801), "HuongDuong.Le27@yahoo.com", "Mộng Hằng Dương", "0968979230", 936088.669441877000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 11,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Quảng Ninh", new DateTime(2024, 4, 20, 16, 6, 48, 38, DateTimeKind.Local).AddTicks(9841), "HieuNghia_Hoang@hotmail.com", "Vân Thường Lâm", "0958701460", 722519.745257391500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 12,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Thanh Hoá", new DateTime(2024, 4, 20, 16, 6, 48, 38, DateTimeKind.Local).AddTicks(9880), "ThanhBinh.Doan92@hotmail.com", "Bảo Sơn Đỗ", "0998547380", 743279.921018093000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 13,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Ninh Bình", new DateTime(2024, 4, 20, 16, 6, 48, 38, DateTimeKind.Local).AddTicks(9916), "NhatHa61@gmail.com", "Bảo Thạch Trương", "0995433903", 765057.085317244000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 14,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Nam Định", new DateTime(2024, 4, 20, 16, 6, 48, 38, DateTimeKind.Local).AddTicks(9955), "QuangThach56@hotmail.com", "Anh Thy Hà", "0989820216", 571662.030536321000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 15,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Bình Phước", new DateTime(2024, 4, 20, 16, 6, 48, 38, DateTimeKind.Local).AddTicks(9987), "QuocHai.Le91@hotmail.com", "Nhã Hương Tăng", "0967558737", 701200.509334507000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 16,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Cần Thơ", new DateTime(2024, 4, 20, 16, 6, 48, 39, DateTimeKind.Local).AddTicks(27), "ThanhVy0@hotmail.com", "Phương Trinh Hà", "0919943951", 971767.433661898000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 17,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Bà Rịa-Vũng Tàu", new DateTime(2024, 4, 20, 16, 6, 48, 39, DateTimeKind.Local).AddTicks(69), "VietAn.Truong@gmail.com", "Ngọc Hiền Trần", "0927107362", 784887.376432156000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 18,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Bến Tre", new DateTime(2024, 4, 20, 16, 6, 48, 39, DateTimeKind.Local).AddTicks(106), "TuyetTram12@hotmail.com", "Tùng Châu Phùng", "0901115918", 685971.262908181000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 19,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Tiền Giang", new DateTime(2024, 4, 20, 16, 6, 48, 39, DateTimeKind.Local).AddTicks(143), "QuynhHoa.Trinh83@yahoo.com", "Thủy Trang Đinh", "0971598663", 763170.067989274500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 20,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Thừa Thiên-Huế", new DateTime(2024, 4, 20, 16, 6, 48, 39, DateTimeKind.Local).AddTicks(183), "QuanDuong_Pham23@hotmail.com", "Từ Ân Bùi", "0939732264", 500853.20901911961500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 21,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Đồng Nai", new DateTime(2024, 4, 20, 16, 6, 48, 39, DateTimeKind.Local).AddTicks(216), "HungDung.Nguyen66@hotmail.com", "Bảo Hoa Hồ", "0984322833", 990369.853858895500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 22,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Bạc Liêu", new DateTime(2024, 4, 20, 16, 6, 48, 39, DateTimeKind.Local).AddTicks(256), "DongTra95@yahoo.com", "Huy Tuấn Trương", "0968157622", 946204.818490921000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 23,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Cao Bằng", new DateTime(2024, 4, 20, 16, 6, 48, 39, DateTimeKind.Local).AddTicks(293), "ThienMinh1@yahoo.com", "Khánh Hà Vũ", "0941045213", 886900.163417627000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 24,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Khánh Hoà", new DateTime(2024, 4, 20, 16, 6, 48, 39, DateTimeKind.Local).AddTicks(334), "NguyetUyen23@hotmail.com", "Thái Tân Trần", "0988477554", 699559.778541732500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 25,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Hòa Bình", new DateTime(2024, 4, 20, 16, 6, 48, 39, DateTimeKind.Local).AddTicks(374), "HanhLinh99@gmail.com", "Bạch Mai Trịnh", "0978659494", 975035.527621328500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 26,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Thái Bình", new DateTime(2024, 4, 20, 16, 6, 48, 39, DateTimeKind.Local).AddTicks(411), "ThaoNghi82@gmail.com", "Thanh Mai Mai", "0964649149", 737832.862663314000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 27,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Điện Biên", new DateTime(2024, 4, 20, 16, 6, 48, 39, DateTimeKind.Local).AddTicks(446), "LinhGiang73@yahoo.com", "Thượng Khang Dương", "0962528311", 815647.053735232000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 28,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Bình Thuận", new DateTime(2024, 4, 20, 16, 6, 48, 39, DateTimeKind.Local).AddTicks(486), "ThuyDao_Pham@yahoo.com", "Mộng Tuyền Lê", "0952546400", 589656.861948382000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 29,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Vĩnh Long", new DateTime(2024, 4, 20, 16, 6, 48, 39, DateTimeKind.Local).AddTicks(519), "MaiKhanh70@hotmail.com", "Minh Giang Phạm", "0951660009", 503248.54122799450500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 30,
                columns: new[] { "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { new DateTime(2024, 4, 20, 16, 6, 48, 39, DateTimeKind.Local).AddTicks(553), "ThuyTam45@hotmail.com", "Quốc Minh Dương", "0952416564", 902494.571663599500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 31,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Thừa Thiên-Huế", new DateTime(2024, 4, 20, 16, 6, 48, 39, DateTimeKind.Local).AddTicks(593), "ThienMai_Bui@hotmail.com", "Ân Thiện Bùi", "0998553437", 855699.176402524000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 32,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Bạc Liêu", new DateTime(2024, 4, 20, 16, 6, 48, 39, DateTimeKind.Local).AddTicks(627), "VietHuong35@yahoo.com", "Như Bảo Đặng", "0911398891", 777548.534932053000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 33,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Hà Nam", new DateTime(2024, 4, 20, 16, 6, 48, 39, DateTimeKind.Local).AddTicks(661), "ManhTuan.Duong88@yahoo.com", "Huệ Hương Hà", "0989372690", 897170.288253287000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 34,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Hải Dương", new DateTime(2024, 4, 20, 16, 6, 48, 39, DateTimeKind.Local).AddTicks(699), "MocMien_Pham@hotmail.com", "Minh Tuệ Dương", "0937439335", 608511.39619925500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 35,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Quảng Trị", new DateTime(2024, 4, 20, 16, 6, 48, 39, DateTimeKind.Local).AddTicks(733), "LeHuyen_Bui@hotmail.com", "Thiện Ðức Hoàng", "0920846460", 932394.228471517000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 36,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Yên Bái", new DateTime(2024, 4, 20, 16, 6, 48, 39, DateTimeKind.Local).AddTicks(772), "QuocTien85@hotmail.com", "Thanh Uyên Mai", "0958433860", 725786.790269394500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 37,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Phú Thọ", new DateTime(2024, 4, 20, 16, 6, 48, 39, DateTimeKind.Local).AddTicks(807), "ThuyLam31@gmail.com", "Chấn Hùng Đinh", "0971281090", 671286.461079373500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 38,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Lạng Sơn", new DateTime(2024, 4, 20, 16, 6, 48, 39, DateTimeKind.Local).AddTicks(841), "KienGiang_Mai@yahoo.com", "Như Quỳnh Hà", "0975129656", 611980.800404851000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 39,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "TP. Hồ Chí Minh", new DateTime(2024, 4, 20, 16, 6, 48, 39, DateTimeKind.Local).AddTicks(879), "TieuMy_Ly@yahoo.com", "Uyển My Đặng", "0972598885", 971448.936860281000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 40,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Quảng Trị", new DateTime(2024, 4, 20, 16, 6, 48, 39, DateTimeKind.Local).AddTicks(915), "NguyetQue17@hotmail.com", "Ðình Dương Vương", "0949247007", 833368.490933972500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 41,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Hải Phòng", new DateTime(2024, 4, 20, 16, 6, 48, 39, DateTimeKind.Local).AddTicks(949), "MocMien_Le90@gmail.com", "Bá Thịnh Vương", "0914493540", 666562.958995117500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 42,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Kon Tum", new DateTime(2024, 4, 20, 16, 6, 48, 39, DateTimeKind.Local).AddTicks(987), "ThienKim_To@gmail.com", "Phú Bình Phan", "0983984512", 584182.15837862500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 43,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Tây Ninh", new DateTime(2024, 4, 20, 16, 6, 48, 39, DateTimeKind.Local).AddTicks(1020), "ThaoUyen.Phung84@gmail.com", "Huyền Ngọc Phan", "0933769692", 678917.887906422500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 44,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Lâm Đồng", new DateTime(2024, 4, 20, 16, 6, 48, 39, DateTimeKind.Local).AddTicks(1061), "ThanhTruc28@yahoo.com", "Hồng Việt Hồ", "0914094563", 547845.6615479988500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 45,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Hải Dương", new DateTime(2024, 4, 20, 16, 6, 48, 39, DateTimeKind.Local).AddTicks(1101), "UyenMinh32@yahoo.com", "Thế Duyệt Trương", "0970112444", 732123.089907073500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 46,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Thái Nguyên", new DateTime(2024, 4, 20, 16, 6, 48, 39, DateTimeKind.Local).AddTicks(1138), "ThuyHuong.Ho95@hotmail.com", "Bích Thảo Lý", "0946463385", 810509.900910622500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 47,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Quảng Ngãi", new DateTime(2024, 4, 20, 16, 6, 48, 39, DateTimeKind.Local).AddTicks(1175), "AnhDuong_Vu86@gmail.com", "Vân Trang Hồ", "0924534353", 711043.551341556500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 48,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Nghệ An", new DateTime(2024, 4, 20, 16, 6, 48, 39, DateTimeKind.Local).AddTicks(1208), "MinhNgoc20@hotmail.com", "Kiên Bình Nguyễn", "0979341910", 963288.997917491000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 49,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Phú Thọ", new DateTime(2024, 4, 20, 16, 6, 48, 39, DateTimeKind.Local).AddTicks(1240), "DinhDon.Lam60@yahoo.com", "Hồng Bạch Thảo Phạm", "0957466943", 782334.628539737000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 50,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Thái Bình", new DateTime(2024, 4, 20, 16, 6, 48, 39, DateTimeKind.Local).AddTicks(1278), "AnhTuan_Vu90@yahoo.com", "Kỳ Anh Tô", "0959430313", 722668.551415683500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 51,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Đắk Nông", new DateTime(2024, 4, 20, 16, 6, 48, 39, DateTimeKind.Local).AddTicks(1309), "QuynhChi.Ha@gmail.com", "Nhã Trúc Ngô", "0998413163", 892252.685347846500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 52,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Bình Phước", new DateTime(2024, 4, 20, 16, 6, 48, 39, DateTimeKind.Local).AddTicks(1342), "TuyLoan_Ngo54@yahoo.com", "Mạnh Ðình Đỗ", "0942814785", 779182.305028493000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 53,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Thái Nguyên", new DateTime(2024, 4, 20, 16, 6, 48, 39, DateTimeKind.Local).AddTicks(1381), "ChinhThuan68@yahoo.com", "Nhất Tiến Phan", "0955073133", 815274.214989427000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 54,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Lạng Sơn", new DateTime(2024, 4, 20, 16, 6, 48, 39, DateTimeKind.Local).AddTicks(1414), "TruongNhan.Pham@gmail.com", "Bích Thủy Tô", "0911489513", 964481.919444707500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 55,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Gia Lai", new DateTime(2024, 4, 20, 16, 6, 48, 39, DateTimeKind.Local).AddTicks(1450), "AnhTai.Hoang@gmail.com", "Kim Quyên Hoàng", "0974444382", 965175.457449064000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 56,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Phú Thọ", new DateTime(2024, 4, 20, 16, 6, 48, 39, DateTimeKind.Local).AddTicks(1488), "DiemChi_Tran@gmail.com", "Thái Chi Tăng", "0960942482", 825463.006851119500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 57,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Hà Tĩnh", new DateTime(2024, 4, 20, 16, 6, 48, 39, DateTimeKind.Local).AddTicks(1521), "PhiPhuong73@hotmail.com", "Ngọc Huệ Phan", "0941225943", 753817.469752049500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 58,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Quảng Bình", new DateTime(2024, 4, 20, 16, 6, 48, 39, DateTimeKind.Local).AddTicks(1559), "HuuCuong_Bui62@gmail.com", "Nhật Quân Trần", "0924052181", 697599.857303654000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 59,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Vĩnh Long", new DateTime(2024, 4, 20, 16, 6, 48, 39, DateTimeKind.Local).AddTicks(1592), "HoanKiem79@yahoo.com", "Bảo Hoàng Lâm", "0922290967", 974231.338996503000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 60,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Tuyên Quang", new DateTime(2024, 4, 20, 16, 6, 48, 39, DateTimeKind.Local).AddTicks(1625), "GiangThien61@hotmail.com", "Yến Hồng Hà", "0954460883", 761209.200721759500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 61,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Hậu Giang", new DateTime(2024, 4, 20, 16, 6, 48, 39, DateTimeKind.Local).AddTicks(1662), "ChiDung.Trinh60@gmail.com", "Trung Nghĩa Phạm", "0912751468", 524979.8858275324500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 62,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Tiền Giang", new DateTime(2024, 4, 20, 16, 6, 48, 39, DateTimeKind.Local).AddTicks(1695), "BichTy44@gmail.com", "Uyên Nhi Phùng", "0931574272", 950635.287599383000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 63,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Nam Định", new DateTime(2024, 4, 20, 16, 6, 48, 39, DateTimeKind.Local).AddTicks(1729), "ThienPhuoc_Duong@hotmail.com", "Trường Vinh Lê", "0922073969", 940524.427093114500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 64,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Thanh Hoá", new DateTime(2024, 4, 20, 16, 6, 48, 39, DateTimeKind.Local).AddTicks(1769), "ThuHoai56@hotmail.com", "Tuyền Lâm Vũ", "0934735139", 726228.701968025500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 65,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Đà Nẵng", new DateTime(2024, 4, 20, 16, 6, 48, 39, DateTimeKind.Local).AddTicks(1803), "TheTrung.Doan99@yahoo.com", "Ý Nhi Hồ", "0913916886", 698821.583019411500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 66,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Bình Phước", new DateTime(2024, 4, 20, 16, 6, 48, 39, DateTimeKind.Local).AddTicks(1841), "LanAnh95@gmail.com", "Minh Hỷ Hà", "0951754414", 993879.06704363500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 67,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Lào Cai", new DateTime(2024, 4, 20, 16, 6, 48, 39, DateTimeKind.Local).AddTicks(1881), "NgocTram17@hotmail.com", "Bạch Liên Trần", "0907537420", 535730.8973999441000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 68,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Nam Định", new DateTime(2024, 4, 20, 16, 6, 48, 39, DateTimeKind.Local).AddTicks(1918), "LinhChi.Ly71@hotmail.com", "Khánh Hằng Hồ", "0961311915", 587865.112147806500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 69,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Bình Phước", new DateTime(2024, 4, 20, 16, 6, 48, 39, DateTimeKind.Local).AddTicks(1954), "ThienKim_Dinh@yahoo.com", "Mỹ Lệ Lê", "0995348240", 542159.5996302792000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 70,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Tuyên Quang", new DateTime(2024, 4, 20, 16, 6, 48, 39, DateTimeKind.Local).AddTicks(1987), "HuuPhuoc_Tran47@yahoo.com", "Thúy Diễm Bùi", "0964011040", 639866.819440500500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 71,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Hậu Giang", new DateTime(2024, 4, 20, 16, 6, 48, 39, DateTimeKind.Local).AddTicks(2022), "ThuThao70@hotmail.com", "Gia Minh Nguyễn", "0966560558", 963611.126128048500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 72,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Sơn La", new DateTime(2024, 4, 20, 16, 6, 48, 39, DateTimeKind.Local).AddTicks(2063), "NgocUyen64@hotmail.com", "Thiên Thanh Dương", "0930313632", 852064.954311419500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 73,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Đắk Lắk", new DateTime(2024, 4, 20, 16, 6, 48, 39, DateTimeKind.Local).AddTicks(2096), "TrucVan_Tran@yahoo.com", "Hùng Anh Lê", "0969555268", 501179.26299749798500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 74,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Kiên Giang", new DateTime(2024, 4, 20, 16, 6, 48, 39, DateTimeKind.Local).AddTicks(2135), "HongThuy.Tran18@yahoo.com", "Xuyến Chi Lê", "0947376240", 543737.1735051732000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 75,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Yên Bái", new DateTime(2024, 4, 20, 16, 6, 48, 39, DateTimeKind.Local).AddTicks(2174), "AnHang_Mai61@gmail.com", "An Nhiên Phan", "0948882162", 973538.243145657000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 76,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Khánh Hoà", new DateTime(2024, 4, 20, 16, 6, 48, 39, DateTimeKind.Local).AddTicks(2205), "BaoHuy85@hotmail.com", "Thế Trung Phạm", "0967605334", 972729.301522645500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 77,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Lâm Đồng", new DateTime(2024, 4, 20, 16, 6, 48, 39, DateTimeKind.Local).AddTicks(2244), "VietKhoa_Vu@yahoo.com", "Kim Thông Lê", "0951977945", 526127.6422289543500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 78,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Kon Tum", new DateTime(2024, 4, 20, 16, 6, 48, 39, DateTimeKind.Local).AddTicks(2282), "ThanhTin55@yahoo.com", "Việt Nhân Dương", "0980076444", 749806.540308860500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 79,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Hưng Yên", new DateTime(2024, 4, 20, 16, 6, 48, 39, DateTimeKind.Local).AddTicks(2316), "MinhMinh74@hotmail.com", "Ngọc Ái Dương", "0902248762", 795245.44525926000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 80,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Cà Mau", new DateTime(2024, 4, 20, 16, 6, 48, 39, DateTimeKind.Local).AddTicks(2352), "XuanPhuong_Ngo99@hotmail.com", "Trâm Oanh Hồ", "0975558425", 672515.978212669500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 81,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Ninh Thuận", new DateTime(2024, 4, 20, 16, 6, 48, 39, DateTimeKind.Local).AddTicks(2392), "UyenNhi.Ngo30@hotmail.com", "Ðồng Bằng Nguyễn", "0993265621", 626159.385121058500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 82,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Ninh Thuận", new DateTime(2024, 4, 20, 16, 6, 48, 39, DateTimeKind.Local).AddTicks(2426), "QuynhTram_Truong7@yahoo.com", "Tuyết Trầm Dương", "0933410202", 847140.490878049000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 83,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Lào Cai", new DateTime(2024, 4, 20, 16, 6, 48, 41, DateTimeKind.Local).AddTicks(1482), "MinhThuy_Phung@yahoo.com", "Thế Minh Tăng", "0954388649", 675275.411161508500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 84,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Hòa Bình", new DateTime(2024, 4, 20, 16, 6, 48, 41, DateTimeKind.Local).AddTicks(1641), "VanDu_Mai8@gmail.com", "Bảo Châu Vũ", "0983924630", 877335.849314781500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 85,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Thái Bình", new DateTime(2024, 4, 20, 16, 6, 48, 41, DateTimeKind.Local).AddTicks(1689), "KienDuc56@yahoo.com", "Tân Phước Trần", "0931595057", 762904.51042675500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 86,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Lào Cai", new DateTime(2024, 4, 20, 16, 6, 48, 41, DateTimeKind.Local).AddTicks(1743), "KimNgoc.Le9@hotmail.com", "Ðại Hành Bùi", "0900598692", 786663.2097456500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 87,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Khánh Hoà", new DateTime(2024, 4, 20, 16, 6, 48, 41, DateTimeKind.Local).AddTicks(1789), "DongPhong.Hoang75@hotmail.com", "Nam Phi Vũ", "0952389299", 843449.379797429000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 88,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Trà Vinh", new DateTime(2024, 4, 20, 16, 6, 48, 41, DateTimeKind.Local).AddTicks(1838), "NgocHien.Truong50@gmail.com", "Thanh Ðoàn Phạm", "0942055939", 833205.393394714500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 89,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Sóc Trăng", new DateTime(2024, 4, 20, 16, 6, 48, 41, DateTimeKind.Local).AddTicks(1879), "AnhHoang97@hotmail.com", "Như Ngọc Hoàng", "0952506480", 973637.528333556000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 90,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Tuyên Quang", new DateTime(2024, 4, 20, 16, 6, 48, 41, DateTimeKind.Local).AddTicks(1922), "HuyenThu.Phung@yahoo.com", "Anh Quốc Mai", "0935847817", 586526.635046731000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 91,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Tiền Giang", new DateTime(2024, 4, 20, 16, 6, 48, 41, DateTimeKind.Local).AddTicks(1971), "DuyenMy42@yahoo.com", "Hồng Quang Phạm", "0998794887", 888468.873238072500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 92,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Bắc Kạn", new DateTime(2024, 4, 20, 16, 6, 48, 41, DateTimeKind.Local).AddTicks(2014), "KimThinh_Tran26@yahoo.com", "Vạn Thông Phan", "0985543243", 844477.67555871000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 93,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Quảng Trị", new DateTime(2024, 4, 20, 16, 6, 48, 41, DateTimeKind.Local).AddTicks(2054), "AnhKhoi.Mai52@yahoo.com", "Hàm Thơ Đinh", "0981866735", 692372.621611593500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 94,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Sóc Trăng", new DateTime(2024, 4, 20, 16, 6, 48, 41, DateTimeKind.Local).AddTicks(2106), "CaoNghiep.Ha@yahoo.com", "Công Hải Phan", "0930421318", 759771.465987338500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 95,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Kon Tum", new DateTime(2024, 4, 20, 16, 6, 48, 41, DateTimeKind.Local).AddTicks(2153), "MongHuong.Phung@gmail.com", "Thanh Hạnh Phạm", "0919592206", 987559.448084830500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 96,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Quảng Trị", new DateTime(2024, 4, 20, 16, 6, 48, 41, DateTimeKind.Local).AddTicks(2193), "DongTuyen.Phan@hotmail.com", "Kiều Minh Lâm", "0981384034", 689303.180910519000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 97,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Kiên Giang", new DateTime(2024, 4, 20, 16, 6, 48, 41, DateTimeKind.Local).AddTicks(2238), "QueLam50@gmail.com", "Thái Tâm Hồ", "0900152327", 816333.391291200500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 98,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Cà Mau", new DateTime(2024, 4, 20, 16, 6, 48, 41, DateTimeKind.Local).AddTicks(2278), "DaiTrang40@gmail.com", "Bảo Duy Phùng", "0966954969", 705765.483945150500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 99,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Lâm Đồng", new DateTime(2024, 4, 20, 16, 6, 48, 41, DateTimeKind.Local).AddTicks(2322), "ThanhCong.Tang29@yahoo.com", "Diệp Vy Hoàng", "0979076053", 772879.235889766000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 100,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Long An", new DateTime(2024, 4, 20, 16, 6, 48, 41, DateTimeKind.Local).AddTicks(2362), "BaoHuynh.Nguyen@yahoo.com", "Công Hiếu Phan", "0967872544", 746070.780908197500000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 1,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 11, new DateTime(2024, 5, 29, 16, 24, 47, 466, DateTimeKind.Unspecified).AddTicks(8032), 35, 4471079.383761117760000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 2,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 26, new DateTime(2024, 5, 24, 0, 3, 9, 430, DateTimeKind.Unspecified).AddTicks(5816), 38, 2524032.804648131280000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 3,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 10, new DateTime(2024, 5, 17, 15, 57, 4, 955, DateTimeKind.Unspecified).AddTicks(427), 19, 4583723.458388726080000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 4,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 79, new DateTime(2024, 5, 12, 1, 22, 2, 310, DateTimeKind.Unspecified).AddTicks(9571), 49, 2937674.619092834120000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 5,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 70, new DateTime(2024, 5, 29, 0, 47, 45, 471, DateTimeKind.Unspecified).AddTicks(3119), 17, 4015071.535561581320000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 6,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 90, new DateTime(2024, 5, 2, 15, 50, 58, 546, DateTimeKind.Unspecified).AddTicks(6100), 11, 3534177.192695270880000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 7,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 49, new DateTime(2024, 5, 7, 3, 10, 9, 842, DateTimeKind.Unspecified).AddTicks(871), 35, 6829123.962677889480000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 8,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 53, new DateTime(2024, 5, 24, 7, 11, 7, 386, DateTimeKind.Unspecified).AddTicks(5289), 46, 2590437.477111228720000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 9,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 52, new DateTime(2024, 5, 4, 19, 23, 31, 268, DateTimeKind.Unspecified).AddTicks(4138), 65, 2435381.224691771440000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 10,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 82, new DateTime(2024, 5, 8, 9, 31, 22, 601, DateTimeKind.Unspecified).AddTicks(9606), 13, 5587485.986535718800000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 11,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 29, new DateTime(2024, 5, 8, 7, 54, 41, 389, DateTimeKind.Unspecified).AddTicks(3001), 34, 5220780.663785634640000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 12,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 76, new DateTime(2024, 5, 26, 9, 49, 10, 240, DateTimeKind.Unspecified).AddTicks(518), 26, 4879023.135049247840000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 13,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 82, new DateTime(2024, 5, 16, 0, 27, 13, 917, DateTimeKind.Unspecified).AddTicks(8852), 92, 3837588.831622843520000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 14,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 68, new DateTime(2024, 5, 27, 5, 33, 34, 857, DateTimeKind.Unspecified).AddTicks(8287), 78, 5195638.727318287840000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 15,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 3, new DateTime(2024, 5, 7, 18, 50, 30, 922, DateTimeKind.Unspecified).AddTicks(3828), 15, 5361171.754963213280000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 16,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 49, new DateTime(2024, 5, 29, 1, 47, 13, 732, DateTimeKind.Unspecified).AddTicks(5096), 90, 4147530.325699874200000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 17,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 87, new DateTime(2024, 5, 20, 14, 18, 49, 930, DateTimeKind.Unspecified).AddTicks(9630), 81, 3173574.444888719520000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 18,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 3, new DateTime(2024, 5, 6, 7, 44, 0, 584, DateTimeKind.Unspecified).AddTicks(997), 81, 6182949.761335868400000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 19,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 84, new DateTime(2024, 5, 11, 6, 46, 52, 203, DateTimeKind.Unspecified).AddTicks(2668), 3, 4506508.561859164080000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 20,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 90, new DateTime(2024, 5, 3, 11, 54, 16, 698, DateTimeKind.Unspecified).AddTicks(568), 71, 3408624.404115110680000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 21,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 3, new DateTime(2024, 5, 21, 19, 53, 48, 984, DateTimeKind.Unspecified).AddTicks(7145), 84, 6583760.424678845280000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 22,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 91, new DateTime(2024, 5, 27, 3, 24, 15, 691, DateTimeKind.Unspecified).AddTicks(6239), 51, 2227548.87049264640000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 23,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 20, new DateTime(2024, 5, 6, 12, 22, 16, 480, DateTimeKind.Unspecified).AddTicks(5391), 1, 1736363.964516704160000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 24,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 41, new DateTime(2024, 5, 28, 14, 28, 52, 661, DateTimeKind.Unspecified).AddTicks(9450), 17, 3624069.118226244600000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 25,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 67, new DateTime(2024, 5, 27, 17, 17, 9, 752, DateTimeKind.Unspecified).AddTicks(5550), 8, 3419287.463926499400000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 26,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 6, new DateTime(2024, 5, 1, 7, 20, 36, 24, DateTimeKind.Unspecified).AddTicks(7848), 85, 5084893.809567922720000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 27,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 1, new DateTime(2024, 5, 13, 23, 10, 58, 395, DateTimeKind.Unspecified).AddTicks(1506), 7, 4509457.533930981120000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 28,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 88, new DateTime(2024, 5, 15, 3, 2, 8, 758, DateTimeKind.Unspecified).AddTicks(3829), 68, 1487516.3315177057280000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 29,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 46, new DateTime(2024, 5, 21, 12, 16, 56, 431, DateTimeKind.Unspecified).AddTicks(5141), 30, 5043065.749332291000000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 30,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 1, new DateTime(2024, 5, 22, 23, 22, 24, 626, DateTimeKind.Unspecified).AddTicks(6593), 99, 5219743.364822833920000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 31,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 52, new DateTime(2024, 5, 6, 22, 56, 21, 692, DateTimeKind.Unspecified).AddTicks(547), 77, 3701167.921437953840000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 32,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 7, new DateTime(2024, 5, 10, 20, 36, 51, 33, DateTimeKind.Unspecified).AddTicks(972), 56, 3923799.933186705360000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 33,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 64, new DateTime(2024, 5, 10, 1, 56, 38, 845, DateTimeKind.Unspecified).AddTicks(4413), 8, 5803091.036229980160000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 34,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 89, new DateTime(2024, 5, 25, 22, 39, 0, 923, DateTimeKind.Unspecified).AddTicks(9850), 47, 5401546.903297388280000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 35,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 11, new DateTime(2024, 5, 27, 14, 20, 10, 391, DateTimeKind.Unspecified).AddTicks(1205), 54, 4590687.309024771240000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 36,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 88, new DateTime(2024, 5, 19, 0, 12, 0, 601, DateTimeKind.Unspecified).AddTicks(7557), 42, 3837643.316892075960000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 37,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 98, new DateTime(2024, 5, 19, 8, 54, 16, 452, DateTimeKind.Unspecified).AddTicks(9983), 55, 2733979.973456456400000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 38,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 62, new DateTime(2024, 5, 18, 8, 1, 56, 109, DateTimeKind.Unspecified).AddTicks(1231), 22, 6149571.165619633920000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 39,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 45, new DateTime(2024, 5, 13, 6, 47, 48, 470, DateTimeKind.Unspecified).AddTicks(743), 78, 2065471.299862634520000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 40,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 82, new DateTime(2024, 5, 25, 7, 58, 36, 67, DateTimeKind.Unspecified).AddTicks(2276), 42, 2043896.285708301240000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 41,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 49, new DateTime(2024, 5, 4, 3, 13, 10, 363, DateTimeKind.Unspecified).AddTicks(8914), 16, 3491143.699527057200000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 42,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 45, new DateTime(2024, 5, 22, 5, 45, 2, 367, DateTimeKind.Unspecified).AddTicks(1959), 77, 6568508.730015655720000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 43,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 5, new DateTime(2024, 5, 28, 15, 6, 46, 286, DateTimeKind.Unspecified).AddTicks(911), 1, 3867109.558562398040000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 44,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 65, new DateTime(2024, 5, 1, 10, 58, 17, 817, DateTimeKind.Unspecified).AddTicks(1582), 69, 3598460.867013680640000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 45,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 83, new DateTime(2024, 5, 16, 10, 30, 56, 186, DateTimeKind.Unspecified).AddTicks(6224), 75, 4750719.827774264960000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 46,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 30, new DateTime(2024, 5, 6, 12, 58, 48, 991, DateTimeKind.Unspecified).AddTicks(501), 40, 9604506.049894524160000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 47,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 76, new DateTime(2024, 5, 3, 6, 9, 16, 653, DateTimeKind.Unspecified).AddTicks(3500), 10, 3252139.269734499840000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 48,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 23, new DateTime(2024, 5, 14, 22, 2, 17, 84, DateTimeKind.Unspecified).AddTicks(4797), 93, 7389037.624026557680000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 49,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 82, new DateTime(2024, 5, 6, 13, 8, 4, 619, DateTimeKind.Unspecified).AddTicks(1690), 78, 5096297.961333364240000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 50,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 19, new DateTime(2024, 5, 24, 9, 33, 37, 861, DateTimeKind.Unspecified).AddTicks(3517), 6, 2032165.7919237408600000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 51,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 98, new DateTime(2024, 5, 6, 19, 52, 12, 778, DateTimeKind.Unspecified).AddTicks(9132), 47, 4918929.937215862920000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 52,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 78, new DateTime(2024, 5, 3, 11, 28, 46, 301, DateTimeKind.Unspecified).AddTicks(8713), 77, 3379449.573421241120000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 53,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 74, new DateTime(2024, 5, 3, 16, 25, 4, 577, DateTimeKind.Unspecified).AddTicks(2258), 36, 1622889.554240716160000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 54,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 51, new DateTime(2024, 5, 10, 21, 51, 2, 968, DateTimeKind.Unspecified).AddTicks(3118), 83, 3966796.699841727360000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 55,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 46, new DateTime(2024, 5, 1, 8, 16, 44, 877, DateTimeKind.Unspecified).AddTicks(4343), 67, 3715182.363441254880000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 56,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 76, new DateTime(2024, 5, 10, 23, 14, 33, 909, DateTimeKind.Unspecified).AddTicks(2393), 16, 2555198.149158535920000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 57,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 64, new DateTime(2024, 5, 6, 10, 29, 35, 644, DateTimeKind.Unspecified).AddTicks(4602), 89, 3946094.923105351800000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 58,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 18, new DateTime(2024, 5, 21, 2, 36, 34, 595, DateTimeKind.Unspecified).AddTicks(7273), 27, 3027640.989361999200000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 59,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 18, new DateTime(2024, 5, 6, 23, 26, 35, 80, DateTimeKind.Unspecified).AddTicks(9204), 76, 2881917.427819649840000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 60,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 88, new DateTime(2024, 5, 27, 0, 26, 13, 331, DateTimeKind.Unspecified).AddTicks(9802), 50, 4354249.099630205760000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 61,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 43, new DateTime(2024, 5, 9, 5, 12, 22, 851, DateTimeKind.Unspecified).AddTicks(2007), 69, 2713258.267946891280000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 62,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 35, new DateTime(2024, 5, 26, 19, 27, 41, 762, DateTimeKind.Unspecified).AddTicks(1456), 38, 4821622.459172365520000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 63,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 51, new DateTime(2024, 5, 9, 12, 51, 30, 144, DateTimeKind.Unspecified).AddTicks(8597), 18, 2657735.1520374398320000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 64,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 7, new DateTime(2024, 5, 3, 14, 9, 24, 188, DateTimeKind.Unspecified).AddTicks(3357), 13, 1339765.30045502781120000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 65,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 9, new DateTime(2024, 5, 15, 5, 0, 33, 916, DateTimeKind.Unspecified).AddTicks(9818), 47, 2814805.324789897120000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 66,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 5, new DateTime(2024, 5, 8, 21, 48, 24, 748, DateTimeKind.Unspecified).AddTicks(5507), 37, 1994570.221571715840000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 67,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 56, new DateTime(2024, 5, 28, 5, 54, 52, 360, DateTimeKind.Unspecified).AddTicks(7363), 30, 3725435.224993639280000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 68,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 89, new DateTime(2024, 5, 9, 8, 26, 19, 626, DateTimeKind.Unspecified).AddTicks(4993), 81, 7935215.631674712480000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 69,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 8, new DateTime(2024, 5, 6, 10, 3, 14, 747, DateTimeKind.Unspecified).AddTicks(7094), 73, 2111545.255475583360000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 70,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 81, new DateTime(2024, 5, 20, 19, 20, 2, 577, DateTimeKind.Unspecified).AddTicks(8458), 30, 9491650.844585311000000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 71,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 50, new DateTime(2024, 5, 10, 10, 8, 41, 918, DateTimeKind.Unspecified).AddTicks(6210), 77, 2933927.938197809280000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 72,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 54, new DateTime(2024, 5, 2, 5, 11, 36, 842, DateTimeKind.Unspecified).AddTicks(5747), 79, 5428544.142163110320000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 73,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 53, new DateTime(2024, 5, 24, 7, 44, 31, 518, DateTimeKind.Unspecified).AddTicks(5936), 52, 6244628.513261069360000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 74,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 2, new DateTime(2024, 5, 4, 13, 44, 50, 260, DateTimeKind.Unspecified).AddTicks(7215), 49, 2638389.811381648320000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 75,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 56, new DateTime(2024, 5, 16, 9, 5, 56, 919, DateTimeKind.Unspecified).AddTicks(7736), 33, 6909307.929576011880000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 76,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 70, new DateTime(2024, 5, 20, 3, 46, 59, 840, DateTimeKind.Unspecified).AddTicks(7892), 52, 6293850.421888254400000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 77,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 65, new DateTime(2024, 5, 12, 3, 36, 29, 757, DateTimeKind.Unspecified).AddTicks(5451), 38, 7478259.317937508800000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 78,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 79, new DateTime(2024, 5, 26, 7, 40, 13, 368, DateTimeKind.Unspecified).AddTicks(3044), 97, 3854111.198925932960000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 79,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 94, new DateTime(2024, 5, 25, 20, 34, 28, 982, DateTimeKind.Unspecified).AddTicks(4992), 34, 9415381.930959304080000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 80,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 7, new DateTime(2024, 5, 27, 15, 41, 41, 252, DateTimeKind.Unspecified).AddTicks(4747), 81, 2241380.2768720473240000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 81,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 66, new DateTime(2024, 5, 26, 6, 37, 21, 40, DateTimeKind.Unspecified).AddTicks(732), 2, 4629388.27742555360000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 82,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 69, new DateTime(2024, 5, 1, 19, 59, 12, 690, DateTimeKind.Unspecified).AddTicks(7278), 56, 5183522.178207541760000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 83,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 87, new DateTime(2024, 5, 5, 13, 6, 27, 417, DateTimeKind.Unspecified).AddTicks(4927), 57, 4637631.557141153920000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 84,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 46, new DateTime(2024, 5, 8, 7, 56, 39, 647, DateTimeKind.Unspecified).AddTicks(6882), 54, 4627403.778419563800000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 85,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 44, new DateTime(2024, 5, 18, 11, 19, 54, 378, DateTimeKind.Unspecified).AddTicks(6937), 69, 4313282.172216028200000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 86,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 9, new DateTime(2024, 5, 5, 17, 23, 21, 947, DateTimeKind.Unspecified).AddTicks(4416), 48, 1137196.6485603316000000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 87,
                columns: new[] { "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { new DateTime(2024, 5, 6, 4, 44, 5, 618, DateTimeKind.Unspecified).AddTicks(5805), 61, 4925654.95742328480000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 88,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 14, new DateTime(2024, 5, 14, 5, 47, 51, 618, DateTimeKind.Unspecified).AddTicks(6812), 67, 3967403.0365873280000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 89,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 8, new DateTime(2024, 5, 7, 5, 1, 31, 768, DateTimeKind.Unspecified).AddTicks(6295), 4, 7589853.967712840200000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 90,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 96, new DateTime(2024, 5, 20, 17, 44, 6, 753, DateTimeKind.Unspecified).AddTicks(6058), 69, 5757597.301850112720000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 91,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 39, new DateTime(2024, 5, 2, 15, 19, 6, 782, DateTimeKind.Unspecified).AddTicks(4517), 46, 2623596.2636030840000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 92,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 13, new DateTime(2024, 5, 15, 14, 20, 20, 963, DateTimeKind.Unspecified).AddTicks(544), 90, 5086645.61850625120000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 93,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 99, new DateTime(2024, 5, 11, 14, 44, 35, 981, DateTimeKind.Unspecified).AddTicks(733), 86, 2400089.216869939520000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 94,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 34, new DateTime(2024, 5, 26, 12, 3, 34, 948, DateTimeKind.Unspecified).AddTicks(250), 70, 3037888.129130086480000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 95,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 88, new DateTime(2024, 5, 25, 9, 51, 3, 73, DateTimeKind.Unspecified).AddTicks(2884), 40, 4275462.287917002880000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 96,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 49, new DateTime(2024, 5, 5, 0, 8, 41, 449, DateTimeKind.Unspecified).AddTicks(7733), 75, 4277036.346340534320000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 97,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 71, new DateTime(2024, 5, 23, 4, 9, 14, 255, DateTimeKind.Unspecified).AddTicks(2483), 56, 2109558.222304751200000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 98,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 20, new DateTime(2024, 5, 17, 2, 49, 45, 280, DateTimeKind.Unspecified).AddTicks(3340), 97, 4153832.760557132640000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 99,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 21, new DateTime(2024, 5, 17, 2, 21, 45, 891, DateTimeKind.Unspecified).AddTicks(4266), 36, 7911777.060065072160000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 100,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 36, new DateTime(2024, 5, 25, 22, 53, 0, 575, DateTimeKind.Unspecified).AddTicks(7320), 44, 5009450.283092741200000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 20, 16, 6, 48, 42, DateTimeKind.Local).AddTicks(5133), 23782.337147665520000m, 102, 184318.235868445200000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 2,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 20, 16, 6, 48, 43, DateTimeKind.Local).AddTicks(2813), 20032.006386096280000m, 52, 144548.131105429300000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 3,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 20, 16, 6, 48, 43, DateTimeKind.Local).AddTicks(2842), 42052.508792557120000m, 35, 198496.002563571200000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 4,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 20, 16, 6, 48, 43, DateTimeKind.Local).AddTicks(2851), 14762.184015541880000m, 149, 183010.005357765700000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 5,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 20, 16, 6, 48, 43, DateTimeKind.Local).AddTicks(2858), 33740.096937492280000m, 34, 194462.377173322800000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 6,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 20, 16, 6, 48, 43, DateTimeKind.Local).AddTicks(2866), 26774.069641630840000m, 44, 169052.696872161200000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 7,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 20, 16, 6, 48, 43, DateTimeKind.Local).AddTicks(2874), 49847.620165532040000m, 66, 180472.791585675500000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 8,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 20, 16, 6, 48, 43, DateTimeKind.Local).AddTicks(2882), 17742.722445967320000m, 79, 123716.208291365700000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 9,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 20, 16, 6, 48, 43, DateTimeKind.Local).AddTicks(2889), 18311.137027757680000m, 50, 191917.046995999100000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 10,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 20, 16, 6, 48, 43, DateTimeKind.Local).AddTicks(2898), 32111.988428366200000m, 84, 102512.9094494061400000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 11,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 20, 16, 6, 48, 43, DateTimeKind.Local).AddTicks(2906), 32427.209091836240000m, 94, 166215.565534735300000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 12,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 20, 16, 6, 48, 43, DateTimeKind.Local).AddTicks(2913), 28366.413575867720000m, 115, 151940.423461197600000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 13,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 20, 16, 6, 48, 43, DateTimeKind.Local).AddTicks(2921), 30948.297029216480000m, 43, 124549.50923706800000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 14,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 20, 16, 6, 48, 43, DateTimeKind.Local).AddTicks(2929), 44030.836672188880000m, 44, 179768.873608786400000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 15,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 20, 16, 6, 48, 43, DateTimeKind.Local).AddTicks(2936), 33299.203446976480000m, 87, 124604.614859503500000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 16,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 20, 16, 6, 48, 43, DateTimeKind.Local).AddTicks(2944), 26758.260165805640000m, 65, 164842.215600988200000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 17,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 20, 16, 6, 48, 43, DateTimeKind.Local).AddTicks(2953), 27358.400386971720000m, 53, 117353.176826650200000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 18,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 20, 16, 6, 48, 43, DateTimeKind.Local).AddTicks(2961), 31227.018996645800000m, 138, 144962.796712742900000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 19,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 20, 16, 6, 48, 43, DateTimeKind.Local).AddTicks(2969), 39530.776858413720000m, 45, 105070.4178284928700000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 20,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 20, 16, 6, 48, 43, DateTimeKind.Local).AddTicks(2977), 18832.179028260280000m, 114, 159119.409355757900000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 21,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 20, 16, 6, 48, 43, DateTimeKind.Local).AddTicks(2984), 45094.249484101680000m, 58, 174754.051035225400000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 22,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 20, 16, 6, 48, 43, DateTimeKind.Local).AddTicks(2992), 19888.82920082720000m, 62, 147725.17384247800000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 23,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 20, 16, 6, 48, 43, DateTimeKind.Local).AddTicks(2999), 14350.115409228960000m, 31, 189251.268878471100000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 24,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 20, 16, 6, 48, 43, DateTimeKind.Local).AddTicks(3071), 21964.055261977240000m, 110, 175468.538107485600000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 25,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 20, 16, 6, 48, 43, DateTimeKind.Local).AddTicks(3078), 25328.055288344440000m, 79, 145281.389446212400000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 26,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 20, 16, 6, 48, 43, DateTimeKind.Local).AddTicks(3101), 49367.901063766240000m, 16, 179711.823536378500000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 27,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 20, 16, 6, 48, 43, DateTimeKind.Local).AddTicks(3108), 24507.921380059680000m, 98, 183832.843615179400000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 28,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 20, 16, 6, 48, 43, DateTimeKind.Local).AddTicks(3115), 11531.1343528504320000m, 71, 109386.3841706807100000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 29,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 20, 16, 6, 48, 43, DateTimeKind.Local).AddTicks(3122), 28491.896888883000000m, 92, 115067.090235449900000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 30,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 20, 16, 6, 48, 43, DateTimeKind.Local).AddTicks(3129), 36248.217811269680000m, 67, 129437.316491051900000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 31,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 20, 16, 6, 48, 43, DateTimeKind.Local).AddTicks(3136), 34916.678504131640000m, 53, 179745.1348982100000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 32,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 20, 16, 6, 48, 43, DateTimeKind.Local).AddTicks(3143), 24834.176792320920000m, 105, 147023.193579765700000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 33,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 20, 16, 6, 48, 43, DateTimeKind.Local).AddTicks(3149), 30224.432480364480000m, 117, 186495.065870133800000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 34,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 20, 16, 6, 48, 43, DateTimeKind.Local).AddTicks(3156), 38308.843285797080000m, 64, 140086.767540377400000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 35,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 20, 16, 6, 48, 43, DateTimeKind.Local).AddTicks(3163), 32102.708454718680000m, 88, 191920.274742927100000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 36,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 20, 16, 6, 48, 43, DateTimeKind.Local).AddTicks(3170), 37996.468484079960000m, 21, 118157.231345558700000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 37,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 20, 16, 6, 48, 43, DateTimeKind.Local).AddTicks(3177), 14020.410120289520000m, 105, 166491.106101215800000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 38,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 20, 16, 6, 48, 43, DateTimeKind.Local).AddTicks(3183), 49996.513541623040000m, 65, 181053.771378156400000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 39,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 20, 16, 6, 48, 43, DateTimeKind.Local).AddTicks(3191), 13499.812417402840000m, 91, 187690.26726032100000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 40,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 20, 16, 6, 48, 43, DateTimeKind.Local).AddTicks(3197), 18751.342070718360000m, 33, 119074.363438809700000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 41,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 20, 16, 6, 48, 43, DateTimeKind.Local).AddTicks(3204), 30357.771300235280000m, 39, 190954.752188499600000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 42,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 20, 16, 6, 48, 43, DateTimeKind.Local).AddTicks(3211), 35125.715133773560000m, 121, 122741.221362514400000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 43,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 20, 16, 6, 48, 43, DateTimeKind.Local).AddTicks(3217), 34222.208482853080000m, 51, 136632.8503030700000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 44,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 20, 16, 6, 48, 43, DateTimeKind.Local).AddTicks(3224), 21419.409922700480000m, 111, 195711.837952844200000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 45,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 20, 16, 6, 48, 43, DateTimeKind.Local).AddTicks(3231), 26992.726294171960000m, 99, 106801.7013939062200000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 46,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 20, 16, 6, 48, 43, DateTimeKind.Local).AddTicks(3237), 49002.581887216960000m, 113, 174169.549597339200000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 47,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 20, 16, 6, 48, 43, DateTimeKind.Local).AddTicks(3244), 20583.159935028480000m, 107, 151631.873061003500000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 48,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 20, 16, 6, 48, 43, DateTimeKind.Local).AddTicks(3251), 44512.274843533480000m, 79, 147612.424585914800000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 49,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 20, 16, 6, 48, 43, DateTimeKind.Local).AddTicks(3259), 28001.637150183320000m, 105, 108088.1472827965100000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 50,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 20, 16, 6, 48, 43, DateTimeKind.Local).AddTicks(3265), 11104.7311034084200000m, 111, 182911.128706656600000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 51,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 20, 16, 6, 48, 43, DateTimeKind.Local).AddTicks(3272), 27176.408492905320000m, 109, 126715.264991919700000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 52,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 20, 16, 6, 48, 43, DateTimeKind.Local).AddTicks(3279), 29133.185977769320000m, 49, 106429.773301218300000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 53,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 20, 16, 6, 48, 43, DateTimeKind.Local).AddTicks(3286), 14490.085305720680000m, 33, 197091.284786811500000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 54,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 20, 16, 6, 48, 43, DateTimeKind.Local).AddTicks(3293), 35417.827677158280000m, 50, 191973.878478103400000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 55,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 20, 16, 6, 48, 43, DateTimeKind.Local).AddTicks(3305), 27725.241518218320000m, 51, 168728.347614053800000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 56,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 20, 16, 6, 48, 43, DateTimeKind.Local).AddTicks(3313), 18515.928617090840000m, 78, 190277.745196069300000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 57,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 20, 16, 6, 48, 43, DateTimeKind.Local).AddTicks(3319), 30122.862008437800000m, 62, 107420.8655470431200000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 58,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 20, 16, 6, 48, 43, DateTimeKind.Local).AddTicks(3326), 20457.033711905400000m, 63, 130337.474929280400000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 59,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 20, 16, 6, 48, 43, DateTimeKind.Local).AddTicks(3332), 16658.482241732080000m, 95, 109548.3290715477200000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 60,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 20, 16, 6, 48, 43, DateTimeKind.Local).AddTicks(3339), 28646.375655461880000m, 62, 154589.759831223100000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 61,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 20, 16, 6, 48, 43, DateTimeKind.Local).AddTicks(3346), 21533.795777356280000m, 68, 127729.566552862300000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 62,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 20, 16, 6, 48, 43, DateTimeKind.Local).AddTicks(3352), 29580.505884493040000m, 113, 182029.19675109600000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 63,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 20, 16, 6, 48, 43, DateTimeKind.Local).AddTicks(3360), 13355.4530253137680000m, 140, 106593.5669757245100000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 64,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 20, 16, 6, 48, 43, DateTimeKind.Local).AddTicks(3368), 10149.73712465930160000m, 45, 123698.862457501200000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 65,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 20, 16, 6, 48, 43, DateTimeKind.Local).AddTicks(3376), 22163.821455038560000m, 67, 183494.526150747200000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 66,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 20, 16, 6, 48, 43, DateTimeKind.Local).AddTicks(3383), 17194.570875618240000m, 50, 194698.458784542400000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 67,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 20, 16, 6, 48, 43, DateTimeKind.Local).AddTicks(3390), 20929.411376368760000m, 116, 146257.425321682100000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 68,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 20, 16, 6, 48, 43, DateTimeKind.Local).AddTicks(3397), 40076.846624619760000m, 134, 176434.928469481900000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 69,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 20, 16, 6, 48, 43, DateTimeKind.Local).AddTicks(3404), 14267.197672132320000m, 62, 191858.428939563800000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 70,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 20, 16, 6, 48, 43, DateTimeKind.Local).AddTicks(3411), 47696.737912489000000m, 146, 163754.783431659500000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 71,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 20, 16, 6, 48, 43, DateTimeKind.Local).AddTicks(3417), 28210.845559594320000m, 45, 159062.726816565700000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 72,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 20, 16, 6, 48, 43, DateTimeKind.Local).AddTicks(3424), 34357.874317488040000m, 73, 128159.942782980300000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 73,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 20, 16, 6, 48, 43, DateTimeKind.Local).AddTicks(3431), 43668.730861965520000m, 80, 122445.510339298700000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 74,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 20, 16, 6, 48, 43, DateTimeKind.Local).AddTicks(3438), 21277.337188561680000m, 43, 162389.793313838500000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 75,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 20, 16, 6, 48, 43, DateTimeKind.Local).AddTicks(3444), 43454.766852679320000m, 102, 146465.843486627700000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 76,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 20, 16, 6, 48, 43, DateTimeKind.Local).AddTicks(3451), 44956.074442058960000m, 71, 163228.515152306100000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 77,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 20, 16, 6, 48, 43, DateTimeKind.Local).AddTicks(3457), 44513.448321056600000m, 107, 182394.495880331600000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 78,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 20, 16, 6, 48, 43, DateTimeKind.Local).AddTicks(3464), 28132.198532306080000m, 53, 191337.234034556900000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 79,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 20, 16, 6, 48, 43, DateTimeKind.Local).AddTicks(3471), 47552.433994743960000m, 118, 169950.119680879100000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 80,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 20, 16, 6, 48, 43, DateTimeKind.Local).AddTicks(3478), 13262.6051885919960000m, 94, 175469.76809156500000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 81,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 20, 16, 6, 48, 43, DateTimeKind.Local).AddTicks(3485), 38902.42249937440000m, 47, 102680.7029179511900000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 82,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 20, 16, 6, 48, 43, DateTimeKind.Local).AddTicks(3492), 26857.627866360320000m, 130, 132220.521648500000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 83,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 20, 16, 6, 48, 43, DateTimeKind.Local).AddTicks(3499), 25204.519332288880000m, 129, 123428.629650641100000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 84,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 20, 16, 6, 48, 43, DateTimeKind.Local).AddTicks(3511), 25565.766731599800000m, 129, 197660.21439266700000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 85,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 20, 16, 6, 48, 43, DateTimeKind.Local).AddTicks(3519), 37506.801497530680000m, 50, 142109.94075526500000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 86,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 20, 16, 6, 48, 43, DateTimeKind.Local).AddTicks(3526), 11371.9664856033160000m, 45, 142698.156278966400000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 87,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 20, 16, 6, 48, 43, DateTimeKind.Local).AddTicks(3533), 26200.29232671960000m, 135, 134186.510141579100000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 88,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 20, 16, 6, 48, 43, DateTimeKind.Local).AddTicks(3540), 34201.7503154080000m, 45, 186030.64220490400000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 89,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 20, 16, 6, 48, 43, DateTimeKind.Local).AddTicks(3547), 39325.668226491400000m, 137, 122240.934237545600000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 90,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 20, 16, 6, 48, 43, DateTimeKind.Local).AddTicks(3554), 32528.798315537360000m, 119, 119852.693332916400000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 91,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 20, 16, 6, 48, 43, DateTimeKind.Local).AddTicks(3561), 22047.0274252360000m, 46, 174521.83597661100000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 92,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 20, 16, 6, 48, 43, DateTimeKind.Local).AddTicks(3568), 27056.62563035240000m, 122, 110798.819448765100000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 93,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 20, 16, 6, 48, 43, DateTimeKind.Local).AddTicks(3576), 19672.862433360160000m, 47, 143207.837198977600000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 94,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 20, 16, 6, 48, 43, DateTimeKind.Local).AddTicks(3583), 23920.378969528240000m, 51, 158717.527488697500000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 95,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 20, 16, 6, 48, 43, DateTimeKind.Local).AddTicks(3590), 26069.891999493920000m, 75, 104746.4727560612500000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 96,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 20, 16, 6, 48, 43, DateTimeKind.Local).AddTicks(3597), 30993.017002467640000m, 58, 135946.128730162700000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 97,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 20, 16, 6, 48, 43, DateTimeKind.Local).AddTicks(3604), 14253.771772329400000m, 69, 184342.023018784800000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 98,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 20, 16, 6, 48, 43, DateTimeKind.Local).AddTicks(3611), 26627.133080494440000m, 80, 137398.780589816700000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 99,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 20, 16, 6, 48, 43, DateTimeKind.Local).AddTicks(3618), 48838.130000401680000m, 92, 134359.811058059300000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 100,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 20, 16, 6, 48, 43, DateTimeKind.Local).AddTicks(3625), 38534.232946867240000m, 56, 195249.007509132900000m });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 1,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Khánh Hoà", new DateTime(2024, 4, 20, 16, 6, 48, 35, DateTimeKind.Local).AddTicks(8090), "MyXuan8@yahoo.com", "0991385103", "Thái Nguyên Dương" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 2,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Ninh Bình", new DateTime(2024, 4, 20, 16, 6, 48, 35, DateTimeKind.Local).AddTicks(9237), "TrucLinh70@hotmail.com", "0907849991", "Việt Dương Phùng" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 3,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Quảng Ngãi", new DateTime(2024, 4, 20, 16, 6, 48, 35, DateTimeKind.Local).AddTicks(9335), "DucHuy_Tang@yahoo.com", "0931827628", "Duy Hải Lê" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 4,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Quảng Trị", new DateTime(2024, 4, 20, 16, 6, 48, 35, DateTimeKind.Local).AddTicks(9402), "BaPhuoc_Vu@gmail.com", "0986185685", "Ái Vân Phan" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 5,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Đồng Tháp", new DateTime(2024, 4, 20, 16, 6, 48, 35, DateTimeKind.Local).AddTicks(9473), "DinhLuc_Ly81@yahoo.com", "0990590735", "Trường Nam Phạm" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 6,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Phú Thọ", new DateTime(2024, 4, 20, 16, 6, 48, 35, DateTimeKind.Local).AddTicks(9537), "HoangXuan_Le74@gmail.com", "0942089677", "Diễm Phương Lâm" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 7,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Long An", new DateTime(2024, 4, 20, 16, 6, 48, 35, DateTimeKind.Local).AddTicks(9606), "YenTrang.Pham75@gmail.com", "0925860939", "Yến Phượng Lý" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 8,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Bắc Ninh", new DateTime(2024, 4, 20, 16, 6, 48, 35, DateTimeKind.Local).AddTicks(9666), "DiemHang_Vuong48@hotmail.com", "0915475869", "Huệ Phương Phùng" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 9,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Quảng Bình", new DateTime(2024, 4, 20, 16, 6, 48, 35, DateTimeKind.Local).AddTicks(9735), "DangAn_Ly@gmail.com", "0918157512", "Ðinh Lộc Trương" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 10,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Thanh Hoá", new DateTime(2024, 4, 20, 16, 6, 48, 35, DateTimeKind.Local).AddTicks(9790), "GiangSon.Dao@yahoo.com", "0962834254", "Lam Giang Lâm" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 11,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Thái Nguyên", new DateTime(2024, 4, 20, 16, 6, 48, 35, DateTimeKind.Local).AddTicks(9854), "ThienLuong21@gmail.com", "0954876046", "Lam Ngọc Hồ" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 12,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Quảng Ninh", new DateTime(2024, 4, 20, 16, 6, 48, 35, DateTimeKind.Local).AddTicks(9914), "HoangQuan_Bui1@gmail.com", "0933489486", "Tâm Nhi Lý" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 13,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Bắc Kạn", new DateTime(2024, 4, 20, 16, 6, 48, 35, DateTimeKind.Local).AddTicks(9980), "XuyenChi33@hotmail.com", "0994061715", "Ðức Tài Đinh" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 14,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Hà Tĩnh", new DateTime(2024, 4, 20, 16, 6, 48, 36, DateTimeKind.Local).AddTicks(42), "DiemLoc36@hotmail.com", "0991609555", "Hoàng Ngôn Nguyễn" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 15,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Ninh Thuận", new DateTime(2024, 4, 20, 16, 6, 48, 36, DateTimeKind.Local).AddTicks(99), "TrangTam_Ha72@hotmail.com", "0912070508", "Quang Ninh Dương" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 16,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Ninh Bình", new DateTime(2024, 4, 20, 16, 6, 48, 36, DateTimeKind.Local).AddTicks(161), "CamNhung97@gmail.com", "0985180960", "Thy Khanh Phùng" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 17,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Thái Bình", new DateTime(2024, 4, 20, 16, 6, 48, 36, DateTimeKind.Local).AddTicks(221), "ThaiDuy_Doan@gmail.com", "0932529901", "Nguyên Khang Hồ" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 18,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Sóc Trăng", new DateTime(2024, 4, 20, 16, 6, 48, 36, DateTimeKind.Local).AddTicks(283), "ThuVan_Ho89@gmail.com", "0983632079", "Thái Ðức Hồ" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 19,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Kon Tum", new DateTime(2024, 4, 20, 16, 6, 48, 36, DateTimeKind.Local).AddTicks(338), "MinhGiang_Phung74@yahoo.com", "0900081962", "Lam Phương Hà" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 20,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Quảng Bình", new DateTime(2024, 4, 20, 16, 6, 48, 36, DateTimeKind.Local).AddTicks(409), "DongTra_Duong87@yahoo.com", "0918960332", "Hoàng Kim Phạm" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 21,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "An Giang", new DateTime(2024, 4, 20, 16, 6, 48, 36, DateTimeKind.Local).AddTicks(467), "ThuongHuyen.Ly82@hotmail.com", "0961921842", "Trúc Phương Phan" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 22,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Thái Bình", new DateTime(2024, 4, 20, 16, 6, 48, 36, DateTimeKind.Local).AddTicks(528), "DanHiep63@gmail.com", "0905630443", "Thanh Thiên Trần" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 23,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Kiên Giang", new DateTime(2024, 4, 20, 16, 6, 48, 36, DateTimeKind.Local).AddTicks(585), "DacTrong.Do@hotmail.com", "0987917474", "Kim Ly Lý" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 24,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Phú Thọ", new DateTime(2024, 4, 20, 16, 6, 48, 36, DateTimeKind.Local).AddTicks(646), "ThuyKhanh26@hotmail.com", "0909554785", "Hoàng Nam Đặng" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 25,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Hải Dương", new DateTime(2024, 4, 20, 16, 6, 48, 36, DateTimeKind.Local).AddTicks(711), "VanhKhuyen98@gmail.com", "0996999907", "Tích Ðức Vương" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 26,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Bình Thuận", new DateTime(2024, 4, 20, 16, 6, 48, 36, DateTimeKind.Local).AddTicks(771), "XuanQuan62@yahoo.com", "0905137843", "Khánh My Trần" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 27,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Ninh Bình", new DateTime(2024, 4, 20, 16, 6, 48, 36, DateTimeKind.Local).AddTicks(832), "QuocBinh_Hoang@gmail.com", "0958282541", "Yên Bằng Trịnh" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 28,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Long An", new DateTime(2024, 4, 20, 16, 6, 48, 36, DateTimeKind.Local).AddTicks(891), "LanTruc7@yahoo.com", "0994282457", "Sỹ Hoàng Ngô" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 29,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Bắc Ninh", new DateTime(2024, 4, 20, 16, 6, 48, 36, DateTimeKind.Local).AddTicks(960), "NgocTuyet39@hotmail.com", "0970289180", "Thiên Trang Hồ" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 30,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Phú Yên", new DateTime(2024, 4, 20, 16, 6, 48, 36, DateTimeKind.Local).AddTicks(1018), "MaiPhuong_Le@yahoo.com", "0930800450", "Ðức Khải Tô" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 31,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Cao Bằng", new DateTime(2024, 4, 20, 16, 6, 48, 36, DateTimeKind.Local).AddTicks(1080), "ChanhViet76@yahoo.com", "0973145137", "Minh Hồng Tô" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 32,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Long An", new DateTime(2024, 4, 20, 16, 6, 48, 36, DateTimeKind.Local).AddTicks(1134), "GiangNam.Duong66@gmail.com", "0997562520", "Đan Thư Mai" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 33,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Hải Phòng", new DateTime(2024, 4, 20, 16, 6, 48, 36, DateTimeKind.Local).AddTicks(1200), "MaiChau_Ly19@gmail.com", "0992066999", "Mỹ Nhi Trần" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 34,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Bắc Giang", new DateTime(2024, 4, 20, 16, 6, 48, 36, DateTimeKind.Local).AddTicks(1260), "ThuongKiet_Vuong@gmail.com", "0955356194", "Huy Vũ Đoàn" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 35,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Bến Tre", new DateTime(2024, 4, 20, 16, 6, 48, 36, DateTimeKind.Local).AddTicks(1320), "MyXuan60@hotmail.com", "0969310175", "Thu Yến Phan" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 36,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Điện Biên", new DateTime(2024, 4, 20, 16, 6, 48, 36, DateTimeKind.Local).AddTicks(1380), "DongTuyen.Ly@gmail.com", "0927686550", "Nguyên Lộc Trần" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 37,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Kiên Giang", new DateTime(2024, 4, 20, 16, 6, 48, 36, DateTimeKind.Local).AddTicks(1433), "VinhAn.Dang7@hotmail.com", "0982991767", "Như Ý Đỗ" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 38,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Quảng Ninh", new DateTime(2024, 4, 20, 16, 6, 48, 36, DateTimeKind.Local).AddTicks(1499), "QuangDung_Bui66@hotmail.com", "0905164278", "Lan Chi Tăng" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 39,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Bắc Giang", new DateTime(2024, 4, 20, 16, 6, 48, 36, DateTimeKind.Local).AddTicks(1559), "HaiVan49@hotmail.com", "0903329775", "Phương Mai Lê" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 40,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Đắk Lắk", new DateTime(2024, 4, 20, 16, 6, 48, 36, DateTimeKind.Local).AddTicks(1618), "HuyQuang_Trinh96@gmail.com", "0956236918", "Trung Nhân Hà" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 41,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Tiền Giang", new DateTime(2024, 4, 20, 16, 6, 48, 36, DateTimeKind.Local).AddTicks(1677), "HoangQuan_Do86@yahoo.com", "0931281298", "Hoàng Khôi Tăng" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 42,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Quảng Trị", new DateTime(2024, 4, 20, 16, 6, 48, 36, DateTimeKind.Local).AddTicks(1738), "ThuanAnh.Mai@yahoo.com", "0943801675", "Thế Quyền Trần" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 43,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "An Giang", new DateTime(2024, 4, 20, 16, 6, 48, 36, DateTimeKind.Local).AddTicks(1800), "NgocCuong_Hoang73@gmail.com", "0978948214", "Ngọc Hạnh Lê" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 44,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Sóc Trăng", new DateTime(2024, 4, 20, 16, 6, 48, 36, DateTimeKind.Local).AddTicks(1862), "ThuongNghi_Tang75@hotmail.com", "0955983687", "Hải Bình Lý" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 45,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Bắc Kạn", new DateTime(2024, 4, 20, 16, 6, 48, 36, DateTimeKind.Local).AddTicks(1929), "ThienTheu.Tang11@yahoo.com", "0912914091", "Hùng Anh Dương" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 46,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Lạng Sơn", new DateTime(2024, 4, 20, 16, 6, 48, 36, DateTimeKind.Local).AddTicks(1990), "DucPhong9@yahoo.com", "0937494484", "Linh Ðan Trịnh" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 47,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Lâm Đồng", new DateTime(2024, 4, 20, 16, 6, 48, 36, DateTimeKind.Local).AddTicks(2054), "QuangTrung_Vu35@yahoo.com", "0949497577", "Trường Nhân Đinh" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 48,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Tây Ninh", new DateTime(2024, 4, 20, 16, 6, 48, 36, DateTimeKind.Local).AddTicks(2114), "VanAnh44@yahoo.com", "0919757151", "Tuấn Sĩ Phùng" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 49,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Hòa Bình", new DateTime(2024, 4, 20, 16, 6, 48, 36, DateTimeKind.Local).AddTicks(2175), "VanLy.Ly54@yahoo.com", "0948607146", "Hải Long Trương" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 50,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Kon Tum", new DateTime(2024, 4, 20, 16, 6, 48, 36, DateTimeKind.Local).AddTicks(2226), "LeThanh.Duong@gmail.com", "0988506042", "Huy Vũ Trịnh" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 51,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Đắk Lắk", new DateTime(2024, 4, 20, 16, 6, 48, 36, DateTimeKind.Local).AddTicks(2304), "QuangThai.To@yahoo.com", "0907040636", "Bích Hằng Nguyễn" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 52,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Bắc Ninh", new DateTime(2024, 4, 20, 16, 6, 48, 36, DateTimeKind.Local).AddTicks(2489), "ThuyTien.Phan69@hotmail.com", "0991135817", "Lệ Chi Trương" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 53,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Lâm Đồng", new DateTime(2024, 4, 20, 16, 6, 48, 36, DateTimeKind.Local).AddTicks(2554), "AnNhan52@yahoo.com", "0974634185", "Viễn Ðông Mai" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 54,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Tuyên Quang", new DateTime(2024, 4, 20, 16, 6, 48, 36, DateTimeKind.Local).AddTicks(2676), "LanNhi89@yahoo.com", "0978532466", "Tâm Đan Phùng" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 55,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Bình Phước", new DateTime(2024, 4, 20, 16, 6, 48, 36, DateTimeKind.Local).AddTicks(2734), "KyAnh77@hotmail.com", "0922877059", "Quang Thuận Đào" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 56,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Kiên Giang", new DateTime(2024, 4, 20, 16, 6, 48, 36, DateTimeKind.Local).AddTicks(2799), "ThuyOanh.Tran81@yahoo.com", "0908573563", "Khánh Nam Tăng" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 57,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Quảng Trị", new DateTime(2024, 4, 20, 16, 6, 48, 36, DateTimeKind.Local).AddTicks(2855), "MinhDan.Truong@gmail.com", "0963196302", "Linh Phương Trương" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 58,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Hải Phòng", new DateTime(2024, 4, 20, 16, 6, 48, 36, DateTimeKind.Local).AddTicks(2923), "HuyHa.Le59@yahoo.com", "0918157285", "Như Ngà Mai" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 59,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Hậu Giang", new DateTime(2024, 4, 20, 16, 6, 48, 36, DateTimeKind.Local).AddTicks(2975), "ChieuQuan10@yahoo.com", "0978585777", "Quang Lân Lý" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 60,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Hà Nội", new DateTime(2024, 4, 20, 16, 6, 48, 36, DateTimeKind.Local).AddTicks(3036), "NhuHong_Nguyen85@hotmail.com", "0999029136", "Kiều Anh Đào" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 61,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Nam Định", new DateTime(2024, 4, 20, 16, 6, 48, 36, DateTimeKind.Local).AddTicks(3098), "VienCanh.Doan@yahoo.com", "0911499956", "Trường Vinh Lý" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 62,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Đắk Lắk", new DateTime(2024, 4, 20, 16, 6, 48, 36, DateTimeKind.Local).AddTicks(3160), "QuocBinh33@yahoo.com", "0918232117", "Ngọc Huyền Bùi" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 63,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Đồng Nai", new DateTime(2024, 4, 20, 16, 6, 48, 36, DateTimeKind.Local).AddTicks(3221), "DucNhan_Hoang6@gmail.com", "0993314925", "Hữu Khang Hoàng" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 64,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Tuyên Quang", new DateTime(2024, 4, 20, 16, 6, 48, 36, DateTimeKind.Local).AddTicks(3278), "ThanhDan_Nguyen76@yahoo.com", "0931801148", "Thu Sương Phan" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 65,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Nam Định", new DateTime(2024, 4, 20, 16, 6, 48, 36, DateTimeKind.Local).AddTicks(3350), "DoanThanh.Phung@hotmail.com", "0962995120", "Phương Nhung Lý" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 66,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Tiền Giang", new DateTime(2024, 4, 20, 16, 6, 48, 36, DateTimeKind.Local).AddTicks(3416), "NghiLuc71@yahoo.com", "0913728990", "Minh Nghĩa Tăng" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 67,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Tây Ninh", new DateTime(2024, 4, 20, 16, 6, 48, 36, DateTimeKind.Local).AddTicks(3477), "ThanhHuyen.Ly20@gmail.com", "0908069225", "Thu Hằng Bùi" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 68,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Thái Nguyên", new DateTime(2024, 4, 20, 16, 6, 48, 36, DateTimeKind.Local).AddTicks(3532), "TuDong.Ly11@gmail.com", "0984457438", "Xuân Vân Bùi" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 69,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Thái Bình", new DateTime(2024, 4, 20, 16, 6, 48, 36, DateTimeKind.Local).AddTicks(3599), "MongNguyet.Dao@hotmail.com", "0934314325", "Ngọc Quế Phạm" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 70,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Lào Cai", new DateTime(2024, 4, 20, 16, 6, 48, 36, DateTimeKind.Local).AddTicks(3656), "MinhTien5@yahoo.com", "0944214206", "Ðình Toàn Trần" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 71,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Bắc Kạn", new DateTime(2024, 4, 20, 16, 6, 48, 36, DateTimeKind.Local).AddTicks(3722), "PhuocNguyen.Hoang22@hotmail.com", "0947640803", "Vương Triều Đỗ" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 72,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Kon Tum", new DateTime(2024, 4, 20, 16, 6, 48, 36, DateTimeKind.Local).AddTicks(3787), "HaiChau84@yahoo.com", "0955996884", "Kim Hương Phùng" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 73,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Tây Ninh", new DateTime(2024, 4, 20, 16, 6, 48, 36, DateTimeKind.Local).AddTicks(3843), "XuanHam_Vu65@hotmail.com", "0925120086", "Tịnh Lâm Dương" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 74,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Ninh Bình", new DateTime(2024, 4, 20, 16, 6, 48, 36, DateTimeKind.Local).AddTicks(3902), "YenPhuong_Pham@hotmail.com", "0967628204", "Trung Thành Tăng" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 75,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Bình Dương", new DateTime(2024, 4, 20, 16, 6, 48, 36, DateTimeKind.Local).AddTicks(3957), "ThuHuyen.Doan@yahoo.com", "0914592008", "Mộng Thi Lê" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 76,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "An Giang", new DateTime(2024, 4, 20, 16, 6, 48, 36, DateTimeKind.Local).AddTicks(4018), "TuTrinh.Pham43@yahoo.com", "0942432109", "Hiếu Nghĩa Lâm" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 77,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Khánh Hoà", new DateTime(2024, 4, 20, 16, 6, 48, 36, DateTimeKind.Local).AddTicks(4076), "DinhSang_Nguyen@gmail.com", "0902866370", "Thanh Liêm Hà" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 78,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Nam Định", new DateTime(2024, 4, 20, 16, 6, 48, 36, DateTimeKind.Local).AddTicks(4137), "LeKhanh98@hotmail.com", "0945517046", "Chi Mai Đào" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 79,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Ninh Bình", new DateTime(2024, 4, 20, 16, 6, 48, 36, DateTimeKind.Local).AddTicks(4192), "DieuVan_Nguyen34@yahoo.com", "0988884042", "Quang Vũ Lý" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 80,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Bình Dương", new DateTime(2024, 4, 20, 16, 6, 48, 36, DateTimeKind.Local).AddTicks(4254), "TrongHieu.Dao@hotmail.com", "0958314901", "Hoạ Mi Đặng" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 81,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Đồng Nai", new DateTime(2024, 4, 20, 16, 6, 48, 36, DateTimeKind.Local).AddTicks(4330), "GiangThien.Doan@yahoo.com", "0905785190", "Yến Ðan Phùng" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 82,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Bình Định", new DateTime(2024, 4, 20, 16, 6, 48, 36, DateTimeKind.Local).AddTicks(4388), "MinhThao16@gmail.com", "0900903618", "Thiên Thảo Trương" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 83,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Cần Thơ", new DateTime(2024, 4, 20, 16, 6, 48, 36, DateTimeKind.Local).AddTicks(4449), "TrucLam_Vuong@gmail.com", "0957079999", "Minh Hồng Vương" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 84,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Gia Lai", new DateTime(2024, 4, 20, 16, 6, 48, 36, DateTimeKind.Local).AddTicks(4504), "VinhHai_Doan57@gmail.com", "0980757238", "Thụy Uyên Nguyễn" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 85,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Đắk Lắk", new DateTime(2024, 4, 20, 16, 6, 48, 36, DateTimeKind.Local).AddTicks(4565), "ChiMai56@hotmail.com", "0909615273", "Quỳnh Hoa Hoàng" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 86,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Cao Bằng", new DateTime(2024, 4, 20, 16, 6, 48, 36, DateTimeKind.Local).AddTicks(4624), "NghiaDung_Vu4@hotmail.com", "0929669285", "Hoàng Ngôn Vũ" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 87,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Tiền Giang", new DateTime(2024, 4, 20, 16, 6, 48, 36, DateTimeKind.Local).AddTicks(4680), "VanThong_Dinh23@yahoo.com", "0931501381", "Trúc Ðào Vũ" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 88,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Lai Châu", new DateTime(2024, 4, 20, 16, 6, 48, 36, DateTimeKind.Local).AddTicks(4741), "ThieuBao0@hotmail.com", "0989533551", "Minh Hiền Ngô" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 89,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Quảng Bình", new DateTime(2024, 4, 20, 16, 6, 48, 36, DateTimeKind.Local).AddTicks(4799), "SiHoang_Do@yahoo.com", "0970579033", "Hà Giang Hoàng" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 90,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Hà Tĩnh", new DateTime(2024, 4, 20, 16, 6, 48, 36, DateTimeKind.Local).AddTicks(4865), "ThuongNghi94@yahoo.com", "0970811534", "Chiêu Minh Trần" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 91,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Lai Châu", new DateTime(2024, 4, 20, 16, 6, 48, 36, DateTimeKind.Local).AddTicks(4920), "DacLuc_Hoang67@hotmail.com", "0938001516", "Hữu Lương Bùi" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 92,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Cà Mau", new DateTime(2024, 4, 20, 16, 6, 48, 36, DateTimeKind.Local).AddTicks(4981), "HuanVo39@hotmail.com", "0912667552", "Mạnh Cương Dương" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 93,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Quảng Trị", new DateTime(2024, 4, 20, 16, 6, 48, 36, DateTimeKind.Local).AddTicks(5038), "PhuongTien.Pham@yahoo.com", "0929577810", "Ðình Quảng Đoàn" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 94,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Khánh Hoà", new DateTime(2024, 4, 20, 16, 6, 48, 36, DateTimeKind.Local).AddTicks(5103), "ThanhAn.Tran@hotmail.com", "0957716470", "Thuận Phong Phan" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 95,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Hà Nội", new DateTime(2024, 4, 20, 16, 6, 48, 36, DateTimeKind.Local).AddTicks(5158), "DongTuyen88@yahoo.com", "0991068796", "Thúy Liên Đoàn" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 96,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Đồng Tháp", new DateTime(2024, 4, 20, 16, 6, 48, 36, DateTimeKind.Local).AddTicks(5222), "ThuyHuong.Vu27@gmail.com", "0929792301", "Bảo Huệ Đoàn" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 97,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Khánh Hoà", new DateTime(2024, 4, 20, 16, 6, 48, 36, DateTimeKind.Local).AddTicks(5289), "LienHuong.Vu@gmail.com", "0911009899", "Bình Minh Tăng" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 98,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Vĩnh Long", new DateTime(2024, 4, 20, 16, 6, 48, 36, DateTimeKind.Local).AddTicks(5343), "AnhDung_Pham53@gmail.com", "0900023400", "Thu Minh Mai" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 99,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Đắk Lắk", new DateTime(2024, 4, 20, 16, 6, 48, 36, DateTimeKind.Local).AddTicks(5409), "ThuyHang2@yahoo.com", "0956175331", "Tùng Quân Hoàng" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 100,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Ninh Bình", new DateTime(2024, 4, 20, 16, 6, 48, 36, DateTimeKind.Local).AddTicks(5464), "MinhVy_Duong47@gmail.com", "0974998018", "Phúc Lâm Hà" });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 1,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 28, 53, new DateTime(2024, 5, 18, 20, 32, 44, 65, DateTimeKind.Unspecified).AddTicks(3890), 15851368.284686287200000m, 15851368.284686287200000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 2,
                columns: new[] { "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 48, new DateTime(2024, 5, 3, 3, 55, 37, 715, DateTimeKind.Unspecified).AddTicks(387), 10696561.701801768200000m, 10696561.701801768200000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 3,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 90, 60, new DateTime(2024, 5, 3, 23, 24, 46, 804, DateTimeKind.Unspecified).AddTicks(4843), 14688704.189704268800000m, 14688704.189704268800000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 4,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 50, 50, new DateTime(2024, 5, 22, 3, 34, 2, 809, DateTimeKind.Unspecified).AddTicks(7038), 9150500.267888285000000m, 9150500.267888285000000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 5,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 95, 27, new DateTime(2024, 5, 10, 3, 26, 27, 654, DateTimeKind.Unspecified).AddTicks(812), 16529302.059732438000000m, 16529302.059732438000000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 6,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 36, 78, new DateTime(2024, 5, 26, 3, 34, 38, 301, DateTimeKind.Unspecified).AddTicks(3786), 14876637.324750185600000m, 14876637.324750185600000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 7,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 35, 100, new DateTime(2024, 5, 24, 5, 56, 10, 135, DateTimeKind.Unspecified).AddTicks(7994), 12813568.202582960500000m, 12813568.202582960500000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 8,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 76, 34, new DateTime(2024, 5, 24, 15, 27, 5, 758, DateTimeKind.Unspecified).AddTicks(4574), 8288985.955521501900000m, 8288985.955521501900000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 9,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 47, 92, new DateTime(2024, 5, 16, 20, 37, 7, 418, DateTimeKind.Unspecified).AddTicks(2550), 15929114.900667925300000m, 15929114.900667925300000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 10,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 89, 29, new DateTime(2024, 5, 26, 23, 29, 9, 825, DateTimeKind.Unspecified).AddTicks(3866), 9226161.8504465526000000m, 9226161.8504465526000000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 11,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 60, 99, new DateTime(2024, 5, 27, 12, 41, 3, 228, DateTimeKind.Unspecified).AddTicks(5339), 11136442.890827265100000m, 11136442.890827265100000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 12,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 86, 16, new DateTime(2024, 5, 11, 19, 36, 11, 571, DateTimeKind.Unspecified).AddTicks(846), 8660604.137288263200000m, 8660604.137288263200000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 13,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 85, 11, new DateTime(2024, 5, 22, 5, 52, 16, 642, DateTimeKind.Unspecified).AddTicks(1989), 10088510.24820250800000m, 10088510.24820250800000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 14,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 58, 77, new DateTime(2024, 5, 20, 8, 8, 31, 82, DateTimeKind.Unspecified).AddTicks(1795), 13302896.647050193600000m, 13302896.647050193600000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 15,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 43, 99, new DateTime(2024, 5, 1, 1, 57, 45, 802, DateTimeKind.Unspecified).AddTicks(5598), 9220741.499603259000000m, 9220741.499603259000000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 16,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 72, 22, new DateTime(2024, 5, 1, 10, 22, 38, 340, DateTimeKind.Unspecified).AddTicks(1312), 14835799.404088938000000m, 14835799.404088938000000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 17,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 32, 98, new DateTime(2024, 5, 15, 12, 46, 25, 151, DateTimeKind.Unspecified).AddTicks(6286), 7393250.140078962600000m, 7393250.140078962600000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 18,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 87, 22, new DateTime(2024, 5, 1, 3, 50, 43, 308, DateTimeKind.Unspecified).AddTicks(1583), 8697767.802764574000000m, 8697767.802764574000000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 19,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 83, 30, new DateTime(2024, 5, 8, 14, 15, 50, 485, DateTimeKind.Unspecified).AddTicks(1617), 7249858.8301660080300000m, 7249858.8301660080300000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 20,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 39, 62, new DateTime(2024, 5, 28, 3, 43, 33, 743, DateTimeKind.Unspecified).AddTicks(5164), 10661000.426835779300000m, 10661000.426835779300000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 21,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 81, 31, new DateTime(2024, 5, 22, 2, 50, 46, 286, DateTimeKind.Unspecified).AddTicks(6082), 15378356.491099835200000m, 15378356.491099835200000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 22,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 42, 44, new DateTime(2024, 5, 20, 23, 59, 11, 357, DateTimeKind.Unspecified).AddTicks(8561), 7386258.69212390000000m, 7386258.69212390000000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 23,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 32, 63, new DateTime(2024, 5, 6, 21, 17, 11, 684, DateTimeKind.Unspecified).AddTicks(5478), 17032614.199062399000000m, 17032614.199062399000000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 24,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 30, 68, new DateTime(2024, 5, 18, 15, 22, 0, 76, DateTimeKind.Unspecified).AddTicks(4579), 9650769.595911708000000m, 9650769.595911708000000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 25,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 70, 11, new DateTime(2024, 5, 26, 9, 16, 14, 866, DateTimeKind.Unspecified).AddTicks(6410), 8135757.808987894400000m, 8135757.808987894400000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 26,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 74, 89, new DateTime(2024, 5, 16, 16, 8, 21, 312, DateTimeKind.Unspecified).AddTicks(4278), 15634928.647664929500000m, 15634928.647664929500000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 27,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 27, 69, new DateTime(2024, 5, 5, 11, 5, 12, 396, DateTimeKind.Unspecified).AddTicks(2414), 15809624.550905428400000m, 15809624.550905428400000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 28,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 61, 49, new DateTime(2024, 5, 12, 23, 18, 19, 462, DateTimeKind.Unspecified).AddTicks(7216), 6344410.2818994811800000m, 6344410.2818994811800000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 29,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 97, 20, new DateTime(2024, 5, 4, 0, 58, 31, 434, DateTimeKind.Unspecified).AddTicks(5584), 9780702.670013241500000m, 9780702.670013241500000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 30,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 49, 49, new DateTime(2024, 5, 10, 19, 10, 57, 414, DateTimeKind.Unspecified).AddTicks(1436), 9966673.369810996300000m, 9966673.369810996300000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 31,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 84, 55, new DateTime(2024, 5, 3, 3, 28, 19, 906, DateTimeKind.Unspecified).AddTicks(5429), 9526492.1496051300000m, 9526492.1496051300000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 32,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 90, 66, new DateTime(2024, 5, 12, 9, 18, 21, 100, DateTimeKind.Unspecified).AddTicks(8823), 7792229.259727582100000m, 7792229.259727582100000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 33,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 18, 72, new DateTime(2024, 5, 23, 13, 14, 58, 265, DateTimeKind.Unspecified).AddTicks(6004), 13987129.940260035000000m, 13987129.940260035000000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 34,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 50, 47, new DateTime(2024, 5, 28, 4, 23, 34, 590, DateTimeKind.Unspecified).AddTicks(6302), 10786681.100609059800000m, 10786681.100609059800000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 35,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 51, 15, new DateTime(2024, 5, 16, 3, 51, 53, 208, DateTimeKind.Unspecified).AddTicks(6910), 10555615.110860990500000m, 10555615.110860990500000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 36,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 92, 7, new DateTime(2024, 5, 7, 23, 9, 0, 978, DateTimeKind.Unspecified).AddTicks(4874), 9452578.507644696000000m, 9452578.507644696000000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 37,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 32, 90, new DateTime(2024, 5, 4, 6, 9, 35, 229, DateTimeKind.Unspecified).AddTicks(9590), 14984199.549109422000000m, 14984199.549109422000000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 38,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 97, 25, new DateTime(2024, 5, 29, 14, 14, 27, 529, DateTimeKind.Unspecified).AddTicks(6872), 10501118.739933071200000m, 10501118.739933071200000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 39,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 20, 32, new DateTime(2024, 5, 3, 17, 41, 9, 256, DateTimeKind.Unspecified).AddTicks(2106), 11636796.57013990200000m, 11636796.57013990200000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 40,
                columns: new[] { "CustomerID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 44, new DateTime(2024, 5, 12, 5, 48, 38, 306, DateTimeKind.Unspecified).AddTicks(806), 9049651.621349537200000m, 9049651.621349537200000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 41,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 20, 35, new DateTime(2024, 5, 6, 3, 29, 59, 30, DateTimeKind.Unspecified).AddTicks(9522), 14512561.166325969600000m, 14512561.166325969600000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 42,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 79, 61, new DateTime(2024, 5, 28, 17, 18, 55, 29, DateTimeKind.Unspecified).AddTicks(8780), 8100920.609925950400000m, 8100920.609925950400000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 43,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 97, 89, new DateTime(2024, 5, 6, 18, 52, 51, 882, DateTimeKind.Unspecified).AddTicks(3064), 8471236.7187903400000m, 8471236.7187903400000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 44,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 2, 59, new DateTime(2024, 5, 15, 6, 23, 9, 179, DateTimeKind.Unspecified).AddTicks(2052), 11155574.763312119400000m, 11155574.763312119400000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 45,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 93, 84, new DateTime(2024, 5, 12, 9, 58, 57, 337, DateTimeKind.Unspecified).AddTicks(3690), 8223731.0073307789400000m, 8223731.0073307789400000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 46,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 89, 73, new DateTime(2024, 5, 10, 16, 43, 32, 780, DateTimeKind.Unspecified).AddTicks(9998), 14456072.616579153600000m, 14456072.616579153600000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 47,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 45, 64, new DateTime(2024, 5, 2, 11, 20, 50, 116, DateTimeKind.Unspecified).AddTicks(6217), 7733225.526111178500000m, 7733225.526111178500000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 48,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 96, 21, new DateTime(2024, 5, 10, 4, 38, 15, 967, DateTimeKind.Unspecified).AddTicks(7408), 12842280.938974587600000m, 12842280.938974587600000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 49,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 26, 3, new DateTime(2024, 5, 15, 12, 0, 51, 147, DateTimeKind.Unspecified).AddTicks(984), 8322787.3407753312700000m, 8322787.3407753312700000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 50,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 38, 76, new DateTime(2024, 5, 23, 10, 24, 22, 842, DateTimeKind.Unspecified).AddTicks(9176), 13169601.266879275200000m, 13169601.266879275200000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 51,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 14, 39, new DateTime(2024, 5, 17, 3, 29, 35, 163, DateTimeKind.Unspecified).AddTicks(2315), 9123499.079418218400000m, 9123499.079418218400000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 52,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 82, 32, new DateTime(2024, 5, 16, 0, 28, 19, 972, DateTimeKind.Unspecified).AddTicks(7242), 7130794.811181626100000m, 7130794.811181626100000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 53,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 3, 80, new DateTime(2024, 5, 14, 9, 12, 54, 574, DateTimeKind.Unspecified).AddTicks(716), 15570211.498158108500000m, 15570211.498158108500000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 54,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 72, 100, new DateTime(2024, 5, 1, 4, 15, 38, 959, DateTimeKind.Unspecified).AddTicks(3289), 11902380.465642410800000m, 11902380.465642410800000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 55,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 28, 26, new DateTime(2024, 5, 16, 15, 56, 8, 806, DateTimeKind.Unspecified).AddTicks(6641), 14004452.851966465400000m, 14004452.851966465400000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 56,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 72, 80, new DateTime(2024, 5, 26, 6, 30, 1, 441, DateTimeKind.Unspecified).AddTicks(6175), 11416664.711764158000000m, 11416664.711764158000000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 57,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 77, 2, new DateTime(2024, 5, 19, 20, 51, 49, 181, DateTimeKind.Unspecified).AddTicks(203), 7412039.7227459752800000m, 7412039.7227459752800000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 58,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 91, 77, new DateTime(2024, 5, 17, 12, 51, 23, 291, DateTimeKind.Unspecified).AddTicks(6289), 11078685.368988834000000m, 11078685.368988834000000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 59,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 39, 10, new DateTime(2024, 5, 28, 2, 5, 40, 365, DateTimeKind.Unspecified).AddTicks(5486), 8544769.6675807221600000m, 8544769.6675807221600000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 60,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 84, 79, new DateTime(2024, 5, 7, 6, 11, 59, 663, DateTimeKind.Unspecified).AddTicks(114), 13913078.384810079000000m, 13913078.384810079000000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 61,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 62, 49, new DateTime(2024, 5, 21, 9, 31, 54, 71, DateTimeKind.Unspecified).AddTicks(590), 7408314.860066013400000m, 7408314.860066013400000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 62,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 61, 92, new DateTime(2024, 5, 25, 4, 1, 20, 390, DateTimeKind.Unspecified).AddTicks(3032), 9101459.83755480000000m, 9101459.83755480000000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 63,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 59, 13, new DateTime(2024, 5, 15, 7, 19, 49, 269, DateTimeKind.Unspecified).AddTicks(5407), 6289020.4515677460900000m, 6289020.4515677460900000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 64,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 83, 81, new DateTime(2024, 5, 19, 3, 7, 39, 910, DateTimeKind.Unspecified).AddTicks(8571), 10761801.033802604400000m, 10761801.033802604400000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 65,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 9, 42, new DateTime(2024, 5, 10, 21, 53, 26, 958, DateTimeKind.Unspecified).AddTicks(586), 11009671.569044832000000m, 11009671.569044832000000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 66,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 100, 42, new DateTime(2024, 5, 13, 13, 16, 17, 107, DateTimeKind.Unspecified).AddTicks(7434), 12850098.279779798400000m, 12850098.279779798400000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 67,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 93, 85, new DateTime(2024, 5, 4, 3, 47, 11, 32, DateTimeKind.Unspecified).AddTicks(4840), 9067960.369944290200000m, 9067960.369944290200000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 68,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 31, 38, new DateTime(2024, 5, 4, 3, 19, 23, 193, DateTimeKind.Unspecified).AddTicks(8010), 11291835.422046841600000m, 11291835.422046841600000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 69,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 19, 68, new DateTime(2024, 5, 7, 17, 6, 24, 119, DateTimeKind.Unspecified).AddTicks(2378), 16499824.888802486800000m, 16499824.888802486800000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 70,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 65, 88, new DateTime(2024, 5, 8, 16, 29, 38, 120, DateTimeKind.Unspecified).AddTicks(8477), 8679003.521877953500000m, 8679003.521877953500000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 71,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 19, 82, new DateTime(2024, 5, 25, 4, 4, 1, 40, DateTimeKind.Unspecified).AddTicks(1201), 9384700.882177376300000m, 9384700.882177376300000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 72,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 94, 27, new DateTime(2024, 5, 24, 16, 13, 54, 5, DateTimeKind.Unspecified).AddTicks(873), 10893595.136553325500000m, 10893595.136553325500000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 73,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 54, 53, new DateTime(2024, 5, 26, 1, 16, 1, 362, DateTimeKind.Unspecified).AddTicks(172), 7714067.151375818100000m, 7714067.151375818100000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 74,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 86, 34, new DateTime(2024, 5, 9, 9, 33, 6, 686, DateTimeKind.Unspecified).AddTicks(947), 13153573.258420918500000m, 13153573.258420918500000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 75,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 66, 32, new DateTime(2024, 5, 10, 18, 52, 1, 273, DateTimeKind.Unspecified).AddTicks(9742), 8348553.078737778900000m, 8348553.078737778900000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 76,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 56, 93, new DateTime(2024, 5, 25, 2, 53, 22, 432, DateTimeKind.Unspecified).AddTicks(6598), 11262767.545509120900000m, 11262767.545509120900000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 77,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 24, 72, new DateTime(2024, 5, 14, 20, 44, 46, 439, DateTimeKind.Unspecified).AddTicks(6821), 11126064.248700227600000m, 11126064.248700227600000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 78,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 48, 47, new DateTime(2024, 5, 19, 6, 19, 14, 979, DateTimeKind.Unspecified).AddTicks(3187), 16072327.658902779600000m, 16072327.658902779600000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 79,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 11, 22, new DateTime(2024, 5, 20, 14, 27, 36, 893, DateTimeKind.Unspecified).AddTicks(5638), 13596009.574470328000000m, 13596009.574470328000000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 80,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 70, 30, new DateTime(2024, 5, 15, 9, 44, 32, 566, DateTimeKind.Unspecified).AddTicks(137), 13160232.60686737500000m, 13160232.60686737500000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 81,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 89, 25, new DateTime(2024, 5, 13, 20, 21, 42, 786, DateTimeKind.Unspecified).AddTicks(9117), 7393010.6100924856800000m, 7393010.6100924856800000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 82,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 70, 39, new DateTime(2024, 5, 27, 16, 31, 59, 810, DateTimeKind.Unspecified).AddTicks(400), 8329892.863855500000m, 8329892.863855500000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 83,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 24, 72, new DateTime(2024, 5, 26, 22, 6, 27, 128, DateTimeKind.Unspecified).AddTicks(4089), 6788574.630785260500000m, 6788574.630785260500000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 84,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 63, 68, new DateTime(2024, 5, 10, 16, 12, 2, 456, DateTimeKind.Unspecified).AddTicks(599), 10278331.14841868400000m, 10278331.14841868400000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 85,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 54, 55, new DateTime(2024, 5, 27, 2, 2, 18, 354, DateTimeKind.Unspecified).AddTicks(1864), 9237146.14909222500000m, 9237146.14909222500000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 86,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 23, 39, new DateTime(2024, 5, 3, 7, 46, 20, 738, DateTimeKind.Unspecified).AddTicks(3493), 7848398.595343152000000m, 7848398.595343152000000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 87,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 26, 1, new DateTime(2024, 5, 16, 1, 30, 56, 256, DateTimeKind.Unspecified).AddTicks(6539), 7111885.037503692300000m, 7111885.037503692300000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 88,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 76, 59, new DateTime(2024, 5, 22, 23, 2, 26, 150, DateTimeKind.Unspecified).AddTicks(5224), 13208175.59654818400000m, 13208175.59654818400000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 89,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 65, 5, new DateTime(2024, 5, 21, 7, 38, 4, 624, DateTimeKind.Unspecified).AddTicks(7940), 6845492.317302553600000m, 6845492.317302553600000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 90,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 65, 12, new DateTime(2024, 5, 26, 11, 21, 23, 96, DateTimeKind.Unspecified).AddTicks(9243), 6951456.213309151200000m, 6951456.213309151200000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 91,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 9, 16, new DateTime(2024, 5, 5, 1, 36, 33, 242, DateTimeKind.Unspecified).AddTicks(5377), 12740094.02629260300000m, 12740094.02629260300000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 92,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 60, 60, new DateTime(2024, 5, 17, 23, 9, 6, 452, DateTimeKind.Unspecified).AddTicks(3807), 7312722.083618496600000m, 7312722.083618496600000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 93,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 88, 19, new DateTime(2024, 5, 11, 16, 43, 30, 31, DateTimeKind.Unspecified).AddTicks(3816), 10740587.789923320000000m, 10740587.789923320000000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 94,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 6, 35, new DateTime(2024, 5, 3, 9, 43, 48, 606, DateTimeKind.Unspecified).AddTicks(7187), 12062532.089141010000000m, 12062532.089141010000000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 95,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 25, 4, new DateTime(2024, 5, 2, 7, 50, 10, 129, DateTimeKind.Unspecified).AddTicks(8617), 9322436.0752894512500000m, 9322436.0752894512500000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 96,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 85, 88, new DateTime(2024, 5, 29, 16, 29, 18, 477, DateTimeKind.Unspecified).AddTicks(2482), 10875690.298413016000000m, 10875690.298413016000000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 97,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 53, 68, new DateTime(2024, 5, 17, 4, 12, 1, 468, DateTimeKind.Unspecified).AddTicks(5664), 14563019.818483999200000m, 14563019.818483999200000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 98,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 98, 33, new DateTime(2024, 5, 22, 4, 35, 14, 493, DateTimeKind.Unspecified).AddTicks(11), 10442307.324826069200000m, 10442307.324826069200000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 99,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 69, 71, new DateTime(2024, 5, 25, 12, 29, 4, 281, DateTimeKind.Unspecified).AddTicks(6893), 9405186.774064151000000m, 9405186.774064151000000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 100,
                columns: new[] { "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 46, new DateTime(2024, 5, 26, 15, 52, 14, 846, DateTimeKind.Unspecified).AddTicks(6367), 14448426.555675834600000m, 14448426.555675834600000m });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 2, 2 },
                column: "Email",
                value: "VietHung_Dang25@hotmail.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 3, 2 },
                column: "Email",
                value: "DieuVan_To89@yahoo.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 4, 2 },
                column: "Email",
                value: "BangTam.Dang84@gmail.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 6, 2 },
                column: "Email",
                value: "QuocHoa_To@yahoo.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 11, 1 },
                column: "Email",
                value: "HieuNghia_Hoang@hotmail.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 13, 2 },
                column: "Email",
                value: "NhatHa61@gmail.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 14, 2 },
                column: "Email",
                value: "QuangThach56@hotmail.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 15, 2 },
                column: "Email",
                value: "QuocHai.Le91@hotmail.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 17, 1 },
                column: "Email",
                value: "VietAn.Truong@gmail.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 18, 1 },
                column: "Email",
                value: "TuyetTram12@hotmail.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 20, 2 },
                column: "Email",
                value: "QuanDuong_Pham23@hotmail.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 21, 1 },
                column: "Email",
                value: "HungDung.Nguyen66@hotmail.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 24, 2 },
                column: "Email",
                value: "NguyetUyen23@hotmail.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 25, 1 },
                column: "Email",
                value: "HanhLinh99@gmail.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 27, 1 },
                column: "Email",
                value: "LinhGiang73@yahoo.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 28, 2 },
                column: "Email",
                value: "ThuyDao_Pham@yahoo.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 29, 2 },
                column: "Email",
                value: "MaiKhanh70@hotmail.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 31, 1 },
                column: "Email",
                value: "ThienMai_Bui@hotmail.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 33, 2 },
                column: "Email",
                value: "ManhTuan.Duong88@yahoo.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 37, 1 },
                column: "Email",
                value: "ThuyLam31@gmail.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 40, 2 },
                column: "Email",
                value: "NguyetQue17@hotmail.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 43, 1 },
                column: "Email",
                value: "ThaoUyen.Phung84@gmail.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 44, 1 },
                column: "Email",
                value: "ThanhTruc28@yahoo.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 47, 2 },
                column: "Email",
                value: "AnhDuong_Vu86@gmail.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 48, 2 },
                column: "Email",
                value: "MinhNgoc20@hotmail.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 49, 1 },
                column: "Email",
                value: "DinhDon.Lam60@yahoo.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 51, 1 },
                column: "Email",
                value: "QuynhChi.Ha@gmail.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 52, 2 },
                column: "Email",
                value: "TuyLoan_Ngo54@yahoo.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 53, 2 },
                column: "Email",
                value: "ChinhThuan68@yahoo.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 55, 2 },
                column: "Email",
                value: "AnhTai.Hoang@gmail.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 56, 1 },
                column: "Email",
                value: "DiemChi_Tran@gmail.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 57, 1 },
                column: "Email",
                value: "PhiPhuong73@hotmail.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 58, 2 },
                column: "Email",
                value: "HuuCuong_Bui62@gmail.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 59, 2 },
                column: "Email",
                value: "HoanKiem79@yahoo.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 64, 2 },
                column: "Email",
                value: "ThuHoai56@hotmail.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 65, 1 },
                column: "Email",
                value: "TheTrung.Doan99@yahoo.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 66, 1 },
                column: "Email",
                value: "LanAnh95@gmail.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 68, 1 },
                column: "Email",
                value: "LinhChi.Ly71@hotmail.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 69, 1 },
                column: "Email",
                value: "ThienKim_Dinh@yahoo.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 73, 1 },
                column: "Email",
                value: "TrucVan_Tran@yahoo.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 74, 2 },
                column: "Email",
                value: "HongThuy.Tran18@yahoo.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 75, 1 },
                column: "Email",
                value: "AnHang_Mai61@gmail.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 77, 2 },
                column: "Email",
                value: "VietKhoa_Vu@yahoo.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 78, 1 },
                column: "Email",
                value: "ThanhTin55@yahoo.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 84, 1 },
                column: "Email",
                value: "VanDu_Mai8@gmail.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 85, 2 },
                column: "Email",
                value: "KienDuc56@yahoo.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 86, 1 },
                column: "Email",
                value: "KimNgoc.Le9@hotmail.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 88, 2 },
                column: "Email",
                value: "NgocHien.Truong50@gmail.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 90, 1 },
                column: "Email",
                value: "HuyenThu.Phung@yahoo.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 91, 1 },
                column: "Email",
                value: "DuyenMy42@yahoo.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 92, 2 },
                column: "Email",
                value: "KimThinh_Tran26@yahoo.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 93, 1 },
                column: "Email",
                value: "AnhKhoi.Mai52@yahoo.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 94, 1 },
                column: "Email",
                value: "CaoNghiep.Ha@yahoo.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 97, 2 },
                column: "Email",
                value: "QueLam50@gmail.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 99, 1 },
                column: "Email",
                value: "ThanhCong.Tang29@yahoo.com");

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "EmployeeID", "RoleID", "Email", "LastLogin", "Lock", "Password" },
                values: new object[,]
                {
                    { 1, 1, "HoangXuan_Ho@gmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 5, 2, "KietHong_Dang@gmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 7, 2, "TamNguyet91@yahoo.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 8, 1, "QuocQuang.Dao@gmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 9, 2, "MinhThien.Ly@hotmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 10, 1, "HuongDuong.Le27@yahoo.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 12, 1, "ThanhBinh.Doan92@hotmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 16, 1, "ThanhVy0@hotmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 19, 2, "QuynhHoa.Trinh83@yahoo.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 22, 2, "DongTra95@yahoo.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 23, 2, "ThienMinh1@yahoo.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 26, 2, "ThaoNghi82@gmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 30, 2, "ThuyTam45@hotmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 32, 2, "VietHuong35@yahoo.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 34, 1, "MocMien_Pham@hotmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 35, 2, "LeHuyen_Bui@hotmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 36, 2, "QuocTien85@hotmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 38, 1, "KienGiang_Mai@yahoo.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 39, 1, "TieuMy_Ly@yahoo.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 41, 2, "MocMien_Le90@gmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 42, 2, "ThienKim_To@gmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 45, 1, "UyenMinh32@yahoo.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 46, 2, "ThuyHuong.Ho95@hotmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 50, 1, "AnhTuan_Vu90@yahoo.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 54, 1, "TruongNhan.Pham@gmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 60, 2, "GiangThien61@hotmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 61, 1, "ChiDung.Trinh60@gmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 62, 1, "BichTy44@gmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 63, 2, "ThienPhuoc_Duong@hotmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 67, 1, "NgocTram17@hotmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 70, 1, "HuuPhuoc_Tran47@yahoo.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 71, 1, "ThuThao70@hotmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 72, 1, "NgocUyen64@hotmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 76, 2, "BaoHuy85@hotmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 79, 1, "MinhMinh74@hotmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 80, 2, "XuanPhuong_Ngo99@hotmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 81, 1, "UyenNhi.Ngo30@hotmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 82, 2, "QuynhTram_Truong7@yahoo.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 83, 1, "MinhThuy_Phung@yahoo.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 87, 2, "DongPhong.Hoang75@hotmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 89, 2, "AnhHoang97@hotmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 95, 2, "MongHuong.Phung@gmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 96, 2, "DongTuyen.Phan@hotmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 98, 1, "DaiTrang40@gmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 100, 2, "BaoHuynh.Nguyen@yahoo.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" }
                });

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "RoleID",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2024, 4, 20, 16, 6, 48, 32, DateTimeKind.Local).AddTicks(4065));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "RoleID",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2024, 4, 20, 16, 6, 48, 32, DateTimeKind.Local).AddTicks(4076));

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
        }
    }
}
