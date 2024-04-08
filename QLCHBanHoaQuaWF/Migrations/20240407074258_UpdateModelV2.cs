using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace QLCHBanHoaQuaWF.Migrations
{
    /// <inheritdoc />
    public partial class UpdateModelV2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                keyValues: new object[] { 14, 1 });

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
                keyValues: new object[] { 19, 1 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 20, 2 });

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
                keyValues: new object[] { 33, 2 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 39, 1 });

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
                keyValues: new object[] { 61, 1 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 62, 1 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 64, 2 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 66, 1 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 69, 1 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 71, 2 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 73, 1 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 78, 2 });

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
                keyValues: new object[] { 84, 2 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 85, 1 });

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
                keyValues: new object[] { 92, 2 });

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
                keyValues: new object[] { 99, 1 });

            migrationBuilder.AlterColumn<string>(
                name: "RoleName",
                table: "UserRole",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "UserRole",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                table: "UserRole",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "User",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "Provider",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "Employee",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "Customer",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 1,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Vĩnh Phúc", "Tuấn Khoan Trần", new DateTime(2024, 4, 7, 14, 42, 57, 574, DateTimeKind.Local).AddTicks(6973), "ChiAnh_Trinh21@yahoo.com", "0930534466" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 2,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Hưng Yên", "Chí Khiêm Vũ", new DateTime(2024, 4, 7, 14, 42, 57, 574, DateTimeKind.Local).AddTicks(9665), "VinhLong.Dang10@hotmail.com", "0993274793" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 3,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Đắk Lắk", "Bảo Ngọc Bùi", new DateTime(2024, 4, 7, 14, 42, 57, 574, DateTimeKind.Local).AddTicks(9793), "HuongLien_Trinh68@hotmail.com", "0911022587" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 4,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Cần Thơ", "Mỹ Vân Đoàn", new DateTime(2024, 4, 7, 14, 42, 57, 574, DateTimeKind.Local).AddTicks(9888), "KhanhQuyen78@hotmail.com", "0973632852" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 5,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Gia Lai", "Kiều Nguyệt Phùng", new DateTime(2024, 4, 7, 14, 42, 57, 574, DateTimeKind.Local).AddTicks(9976), "ThuyGiang.Dinh@hotmail.com", "0959379022" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 6,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Vĩnh Long", "Cát Uy Hồ", new DateTime(2024, 4, 7, 14, 42, 57, 575, DateTimeKind.Local).AddTicks(51), "BaoLam.Ha14@hotmail.com", "0922355390" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 7,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Phú Thọ", "Ý Nhi Hoàng", new DateTime(2024, 4, 7, 14, 42, 57, 575, DateTimeKind.Local).AddTicks(131), "VanChi.Nguyen@gmail.com", "0926394692" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 8,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Long An", "Liên Chi Trần", new DateTime(2024, 4, 7, 14, 42, 57, 575, DateTimeKind.Local).AddTicks(206), "BachTuyet.Le58@gmail.com", "0980913904" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 9,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Ninh Bình", "Cao Sĩ Vương", new DateTime(2024, 4, 7, 14, 42, 57, 575, DateTimeKind.Local).AddTicks(283), "TanTruong.Dao56@hotmail.com", "0916526255" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 10,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Điện Biên", "Yên Bình Phan", new DateTime(2024, 4, 7, 14, 42, 57, 575, DateTimeKind.Local).AddTicks(360), "DanhThanh.Phan@yahoo.com", "0911373196" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 11,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Lạng Sơn", "Như Bảo Đặng", new DateTime(2024, 4, 7, 14, 42, 57, 575, DateTimeKind.Local).AddTicks(432), "VietYen.Ho@gmail.com", "0961681705" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 12,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Hà Nam", "Kiều Trinh Dương", new DateTime(2024, 4, 7, 14, 42, 57, 575, DateTimeKind.Local).AddTicks(517), "MongLam.Vu@hotmail.com", "0978502799" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 13,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Sơn La", "Trọng Hà Phùng", new DateTime(2024, 4, 7, 14, 42, 57, 575, DateTimeKind.Local).AddTicks(585), "ThuLam71@yahoo.com", "0971616038" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 14,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Tiền Giang", "Giang Lam Trịnh", new DateTime(2024, 4, 7, 14, 42, 57, 575, DateTimeKind.Local).AddTicks(655), "ThanhHai.To2@yahoo.com", "0988500256" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 15,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Bình Dương", "Minh Ân Đặng", new DateTime(2024, 4, 7, 14, 42, 57, 575, DateTimeKind.Local).AddTicks(729), "GiaThinh_Hoang19@yahoo.com", "0991216721" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 16,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Lào Cai", "Hồ Nam Trịnh", new DateTime(2024, 4, 7, 14, 42, 57, 575, DateTimeKind.Local).AddTicks(807), "DucHuy.Tang78@yahoo.com", "0932990484" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 17,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Nam Định", "Anh Thơ Hồ", new DateTime(2024, 4, 7, 14, 42, 57, 575, DateTimeKind.Local).AddTicks(881), "CongTrang_Doan@yahoo.com", "0969467566" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 18,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Trà Vinh", "Thuận Phương Hà", new DateTime(2024, 4, 7, 14, 42, 57, 575, DateTimeKind.Local).AddTicks(957), "TueMan.Truong@gmail.com", "0976064859" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 19,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Hưng Yên", "Anh Khôi Đoàn", new DateTime(2024, 4, 7, 14, 42, 57, 575, DateTimeKind.Local).AddTicks(1029), "AiVan.Ly@yahoo.com", "0917790531" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 20,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Bắc Giang", "Nhã Lý Hồ", new DateTime(2024, 4, 7, 14, 42, 57, 575, DateTimeKind.Local).AddTicks(1098), "ThuYen41@gmail.com", "0988695737" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 21,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Hà Tĩnh", "Ðức Tâm Đặng", new DateTime(2024, 4, 7, 14, 42, 57, 575, DateTimeKind.Local).AddTicks(1166), "ThaoLinh71@gmail.com", "0964872697" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 22,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Hưng Yên", "Bình An Hà", new DateTime(2024, 4, 7, 14, 42, 57, 575, DateTimeKind.Local).AddTicks(1243), "KimQuyen_Do@hotmail.com", "0977534842" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 23,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Quảng Bình", "Diệu Vân Lâm", new DateTime(2024, 4, 7, 14, 42, 57, 575, DateTimeKind.Local).AddTicks(1346), "TruongKy_Do@gmail.com", "0931846565" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 24,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Ninh Bình", "Việt Huy Đào", new DateTime(2024, 4, 7, 14, 42, 57, 575, DateTimeKind.Local).AddTicks(1417), "YenTrang.Trinh62@hotmail.com", "0999685341" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 25,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Quảng Nam", "Bạch Yến Tăng", new DateTime(2024, 4, 7, 14, 42, 57, 575, DateTimeKind.Local).AddTicks(1492), "AnhQuan.Trinh35@gmail.com", "0902239133" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 26,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Đắk Lắk", "Giao Kiều Dương", new DateTime(2024, 4, 7, 14, 42, 57, 575, DateTimeKind.Local).AddTicks(1577), "DiemChau15@yahoo.com", "0952935753" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 27,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Sóc Trăng", "Ðại Dương Ngô", new DateTime(2024, 4, 7, 14, 42, 57, 575, DateTimeKind.Local).AddTicks(1792), "HiepVu53@gmail.com", "0928220689" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 28,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Điện Biên", "Thiên Tuyền Vương", new DateTime(2024, 4, 7, 14, 42, 57, 575, DateTimeKind.Local).AddTicks(1866), "VanKhanh69@gmail.com", "0967531422" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 29,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Vĩnh Phúc", "Kim Yến Lý", new DateTime(2024, 4, 7, 14, 42, 57, 575, DateTimeKind.Local).AddTicks(2005), "DoanTu97@yahoo.com", "0933779586" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 30,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Quảng Nam", "Thiện Sinh Tăng", new DateTime(2024, 4, 7, 14, 42, 57, 575, DateTimeKind.Local).AddTicks(2073), "MaiThanh.Pham68@hotmail.com", "0938155592" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 31,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Cà Mau", "Đan Quỳnh Trịnh", new DateTime(2024, 4, 7, 14, 42, 57, 575, DateTimeKind.Local).AddTicks(2148), "NhuTran6@gmail.com", "0943272965" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 32,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Điện Biên", "Chuẩn Khoa Ngô", new DateTime(2024, 4, 7, 14, 42, 57, 575, DateTimeKind.Local).AddTicks(2224), "GiaoHuong.Pham3@hotmail.com", "0916317167" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 33,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Yên Bái", "Tuấn Khoan Tăng", new DateTime(2024, 4, 7, 14, 42, 57, 575, DateTimeKind.Local).AddTicks(2300), "ThanhTam.Le@gmail.com", "0963277661" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 34,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Quảng Trị", "Cát Cát Đoàn", new DateTime(2024, 4, 7, 14, 42, 57, 575, DateTimeKind.Local).AddTicks(2373), "HoangSa_Ngo@hotmail.com", "0977122479" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 35,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Bến Tre", "Quốc Anh Phùng", new DateTime(2024, 4, 7, 14, 42, 57, 575, DateTimeKind.Local).AddTicks(2440), "DiemUyen.To85@gmail.com", "0907748431" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 36,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Vĩnh Long", "Thế Vinh Ngô", new DateTime(2024, 4, 7, 14, 42, 57, 575, DateTimeKind.Local).AddTicks(2511), "NhuTam.Mai4@hotmail.com", "0982310782" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 37,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Ninh Bình", "Thanh Ngọc Tô", new DateTime(2024, 4, 7, 14, 42, 57, 575, DateTimeKind.Local).AddTicks(2576), "ThanhNguyen38@hotmail.com", "0924183191" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 38,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Quảng Ninh", "Kiến Bình Ngô", new DateTime(2024, 4, 7, 14, 42, 57, 575, DateTimeKind.Local).AddTicks(2655), "NhanNguyen52@gmail.com", "0959047047" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 39,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Quảng Nam", "Ngọc Quyên Hoàng", new DateTime(2024, 4, 7, 14, 42, 57, 575, DateTimeKind.Local).AddTicks(2746), "PhuongLan72@yahoo.com", "0939878525" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 40,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Sơn La", "Lâm Dũng Lê", new DateTime(2024, 4, 7, 14, 42, 57, 575, DateTimeKind.Local).AddTicks(2941), "TamDoan.Le87@gmail.com", "0920829551" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 41,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Hà Nam", "Ánh Dương Phan", new DateTime(2024, 4, 7, 14, 42, 57, 575, DateTimeKind.Local).AddTicks(3016), "LamTruong_Ha63@hotmail.com", "0965443171" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 42,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Lạng Sơn", "Nhật Hùng Trương", new DateTime(2024, 4, 7, 14, 42, 57, 575, DateTimeKind.Local).AddTicks(3096), "YenBang.Vuong@gmail.com", "0975171864" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 43,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Tây Ninh", "Xuân Bảo Lâm", new DateTime(2024, 4, 7, 14, 42, 57, 575, DateTimeKind.Local).AddTicks(3173), "DucToan_Ha@hotmail.com", "0934013845" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 44,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Hậu Giang", "Khánh Vy Phan", new DateTime(2024, 4, 7, 14, 42, 57, 575, DateTimeKind.Local).AddTicks(3248), "KhanhNgan.Dinh@yahoo.com", "0979096435" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 45,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Bắc Giang", "Mai Nhi Đoàn", new DateTime(2024, 4, 7, 14, 42, 57, 575, DateTimeKind.Local).AddTicks(3330), "ThuNga5@hotmail.com", "0914475906" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 46,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Gia Lai", "Hồng Khuê Lê", new DateTime(2024, 4, 7, 14, 42, 57, 575, DateTimeKind.Local).AddTicks(3402), "GiangThien66@gmail.com", "0949151567" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 47,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Bến Tre", "Hữu Vượng Trần", new DateTime(2024, 4, 7, 14, 42, 57, 575, DateTimeKind.Local).AddTicks(3486), "SonGiang.Dao@gmail.com", "0996697298" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 48,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Quảng Ninh", "Phúc Hòa Hà", new DateTime(2024, 4, 7, 14, 42, 57, 575, DateTimeKind.Local).AddTicks(3612), "NgocKhanh92@yahoo.com", "0998961688" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 49,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Cần Thơ", "Hải Thụy Ngô", new DateTime(2024, 4, 7, 14, 42, 57, 575, DateTimeKind.Local).AddTicks(3688), "BaPhuoc_Vuong71@yahoo.com", "0902615385" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 50,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Đồng Nai", "Thiện Lương Trịnh", new DateTime(2024, 4, 7, 14, 42, 57, 575, DateTimeKind.Local).AddTicks(3756), "HaiBang30@yahoo.com", "0921082795" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 51,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Đắk Lắk", "Trung Nghĩa Tăng", new DateTime(2024, 4, 7, 14, 42, 57, 575, DateTimeKind.Local).AddTicks(3980), "MyHiep.Phung@gmail.com", "0962114387" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 52,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Hà Giang", "Ngọc Lâm Dương", new DateTime(2024, 4, 7, 14, 42, 57, 575, DateTimeKind.Local).AddTicks(4054), "NhatDuy_Ly9@hotmail.com", "0956988855" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 53,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Ninh Thuận", "Thành Châu Tô", new DateTime(2024, 4, 7, 14, 42, 57, 575, DateTimeKind.Local).AddTicks(4200), "KhanhAn.Duong86@yahoo.com", "0984983809" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 54,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Vĩnh Long", "Thanh Huyền Phạm", new DateTime(2024, 4, 7, 14, 42, 57, 575, DateTimeKind.Local).AddTicks(4268), "DuyCan78@hotmail.com", "0973487115" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 55,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Quảng Nam", "Ðan Khanh Bùi", new DateTime(2024, 4, 7, 14, 42, 57, 575, DateTimeKind.Local).AddTicks(4337), "AnNhan43@yahoo.com", "0991065732" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 56,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Tiền Giang", "Lệ Hoa Phùng", new DateTime(2024, 4, 7, 14, 42, 57, 575, DateTimeKind.Local).AddTicks(4425), "PhiDiep93@gmail.com", "0951753881" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 57,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Hòa Bình", "Thiên Ân Đinh", new DateTime(2024, 4, 7, 14, 42, 57, 575, DateTimeKind.Local).AddTicks(4497), "HanhDung.Pham@yahoo.com", "0970983218" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 58,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Thái Nguyên", "Thùy Nhi Vương", new DateTime(2024, 4, 7, 14, 42, 57, 575, DateTimeKind.Local).AddTicks(4570), "KienVan39@hotmail.com", "0989796422" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 59,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Đồng Nai", "Ngọc Cầm Hồ", new DateTime(2024, 4, 7, 14, 42, 57, 575, DateTimeKind.Local).AddTicks(4688), "BaLong.Ngo68@hotmail.com", "0947385572" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 60,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Ninh Bình", "Hồ Bắc Trần", new DateTime(2024, 4, 7, 14, 42, 57, 575, DateTimeKind.Local).AddTicks(4773), "VietCuong_Lam@yahoo.com", "0973560658" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 61,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Thái Bình", "Diệu Ngà Đặng", new DateTime(2024, 4, 7, 14, 42, 57, 575, DateTimeKind.Local).AddTicks(4837), "UyenNghi_Dinh86@yahoo.com", "0998759104" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 62,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Bến Tre", "Phương Liên Lý", new DateTime(2024, 4, 7, 14, 42, 57, 575, DateTimeKind.Local).AddTicks(4913), "ThuLinh56@gmail.com", "0977405468" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 63,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Ninh Thuận", "Thục Ðình Ngô", new DateTime(2024, 4, 7, 14, 42, 57, 575, DateTimeKind.Local).AddTicks(4980), "MinhHung_Pham54@yahoo.com", "0992401429" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 64,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Bạc Liêu", "Thường Xuân Phan", new DateTime(2024, 4, 7, 14, 42, 57, 575, DateTimeKind.Local).AddTicks(5053), "VietPhuong.Dinh79@hotmail.com", "0969208677" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 65,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Phú Thọ", "Hiếu Khanh Trương", new DateTime(2024, 4, 7, 14, 42, 57, 575, DateTimeKind.Local).AddTicks(5124), "QuyetThang21@hotmail.com", "0993277605" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 66,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Đồng Tháp", "Hồng Thư Phạm", new DateTime(2024, 4, 7, 14, 42, 57, 575, DateTimeKind.Local).AddTicks(5197), "DucPhong_Ly58@gmail.com", "0992776018" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 67,
                columns: new[] { "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Bạch Mai Lâm", new DateTime(2024, 4, 7, 14, 42, 57, 575, DateTimeKind.Local).AddTicks(5268), "HongNhuan4@yahoo.com", "0936766169" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 68,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Bình Dương", "Đông Tuyền Nguyễn", new DateTime(2024, 4, 7, 14, 42, 57, 575, DateTimeKind.Local).AddTicks(5341), "VanDu.Truong@hotmail.com", "0902634963" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 69,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Bạc Liêu", "Minh Vũ Hồ", new DateTime(2024, 4, 7, 14, 42, 57, 575, DateTimeKind.Local).AddTicks(5410), "QuyVinh_Ngo@yahoo.com", "0956677004" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 70,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Tuyên Quang", "Hải Nhi Hà", new DateTime(2024, 4, 7, 14, 42, 57, 575, DateTimeKind.Local).AddTicks(5477), "BaoPhap_Vuong@gmail.com", "0975605627" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 71,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Khánh Hoà", "Trúc Quỳnh Hà", new DateTime(2024, 4, 7, 14, 42, 57, 575, DateTimeKind.Local).AddTicks(5560), "QuocVu75@gmail.com", "0987902738" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 72,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Bạc Liêu", "Thiên Tuyền Trịnh", new DateTime(2024, 4, 7, 14, 42, 57, 575, DateTimeKind.Local).AddTicks(5627), "ThienThu19@yahoo.com", "0930717591" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 73,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Quảng Nam", "Gia Phúc Đoàn", new DateTime(2024, 4, 7, 14, 42, 57, 575, DateTimeKind.Local).AddTicks(5697), "DongNghi.Doan@hotmail.com", "0908137176" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 74,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Quảng Ngãi", "Hương Chi Dương", new DateTime(2024, 4, 7, 14, 42, 57, 575, DateTimeKind.Local).AddTicks(5790), "TuUyen_Tran@gmail.com", "0972256860" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 75,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Bình Thuận", "Minh Triết Đặng", new DateTime(2024, 4, 7, 14, 42, 57, 575, DateTimeKind.Local).AddTicks(5867), "PhuongPhi.Phan@hotmail.com", "0983229258" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 76,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Ninh Thuận", "Thúy Vy Bùi", new DateTime(2024, 4, 7, 14, 42, 57, 575, DateTimeKind.Local).AddTicks(5942), "KhanhHa.Mai@hotmail.com", "0995911541" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 77,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Sơn La", "Khắc Minh Hà", new DateTime(2024, 4, 7, 14, 42, 57, 575, DateTimeKind.Local).AddTicks(6008), "DucThang.Phung95@gmail.com", "0969484744" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 78,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Đồng Tháp", "Ngọc Nữ Trương", new DateTime(2024, 4, 7, 14, 42, 57, 575, DateTimeKind.Local).AddTicks(6083), "NganTruc_Mai@gmail.com", "0912355870" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 79,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Vĩnh Long", "Việt Thông Hồ", new DateTime(2024, 4, 7, 14, 42, 57, 575, DateTimeKind.Local).AddTicks(6150), "ThuyVan.Do@gmail.com", "0937734142" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 80,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "TP. Hồ Chí Minh", "Hải Nam Hà", new DateTime(2024, 4, 7, 14, 42, 57, 575, DateTimeKind.Local).AddTicks(6221), "NhatNam.Doan51@yahoo.com", "0967873816" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 81,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Thừa Thiên-Huế", "Xuân Lạc Đoàn", new DateTime(2024, 4, 7, 14, 42, 57, 575, DateTimeKind.Local).AddTicks(6288), "NgocLam60@gmail.com", "0934520481" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 82,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Lai Châu", "Bảo Hân Phan", new DateTime(2024, 4, 7, 14, 42, 57, 575, DateTimeKind.Local).AddTicks(6354), "BaoHan.Duong52@gmail.com", "0970570195" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 83,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Bắc Ninh", "Phúc Ðiền Đào", new DateTime(2024, 4, 7, 14, 42, 57, 575, DateTimeKind.Local).AddTicks(6417), "GiaThinh_Tran11@hotmail.com", "0961837956" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 84,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Quảng Ninh", "Phi Hùng Vương", new DateTime(2024, 4, 7, 14, 42, 57, 575, DateTimeKind.Local).AddTicks(6487), "DuyenNuong_Hoang@yahoo.com", "0938993396" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 85,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Vĩnh Phúc", "Hiền Thục Lý", new DateTime(2024, 4, 7, 14, 42, 57, 575, DateTimeKind.Local).AddTicks(6556), "CongSinh_Nguyen34@yahoo.com", "0971049630" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 86,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Bạc Liêu", "Quỳnh Sa Hà", new DateTime(2024, 4, 7, 14, 42, 57, 575, DateTimeKind.Local).AddTicks(6631), "HamY_Ly@hotmail.com", "0938658788" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 87,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Vĩnh Long", "Ðức Hòa Phạm", new DateTime(2024, 4, 7, 14, 42, 57, 575, DateTimeKind.Local).AddTicks(6698), "PhuongAnh.Mai@gmail.com", "0917439448" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 88,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Bắc Kạn", "Minh Nghĩa Trương", new DateTime(2024, 4, 7, 14, 42, 57, 575, DateTimeKind.Local).AddTicks(6765), "TruongGiang.Dang5@hotmail.com", "0915641762" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 89,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Quảng Trị", "Trung Anh Tăng", new DateTime(2024, 4, 7, 14, 42, 57, 575, DateTimeKind.Local).AddTicks(6841), "VanSon_Vuong@hotmail.com", "0904950058" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 90,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "An Giang", "Mai Thanh Mai", new DateTime(2024, 4, 7, 14, 42, 57, 575, DateTimeKind.Local).AddTicks(6911), "CatTuong.Ngo27@hotmail.com", "0913585476" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 91,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Kiên Giang", "Thanh Quang Lê", new DateTime(2024, 4, 7, 14, 42, 57, 575, DateTimeKind.Local).AddTicks(6981), "KhanhHoang47@gmail.com", "0954502993" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 92,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Tiền Giang", "Hiếu Học Đặng", new DateTime(2024, 4, 7, 14, 42, 57, 575, DateTimeKind.Local).AddTicks(7070), "ThaiBinh_Tang@hotmail.com", "0924062330" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 93,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Vĩnh Long", "Thúy Nga Lý", new DateTime(2024, 4, 7, 14, 42, 57, 575, DateTimeKind.Local).AddTicks(7285), "MinhLoan_Doan@hotmail.com", "0975186244" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 94,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Gia Lai", "Mỹ Phượng Phan", new DateTime(2024, 4, 7, 14, 42, 57, 575, DateTimeKind.Local).AddTicks(7381), "LeQuan65@gmail.com", "0951856016" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 95,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Điện Biên", "Hồng Phúc Hồ", new DateTime(2024, 4, 7, 14, 42, 57, 575, DateTimeKind.Local).AddTicks(7459), "ThanhLam35@gmail.com", "0901683972" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 96,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Thanh Hoá", "Hữu Tài Lê", new DateTime(2024, 4, 7, 14, 42, 57, 575, DateTimeKind.Local).AddTicks(7601), "NhuAnh_Ly@yahoo.com", "0996471316" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 97,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Bình Dương", "Phương Yến Phùng", new DateTime(2024, 4, 7, 14, 42, 57, 575, DateTimeKind.Local).AddTicks(7662), "VietThuong.Dinh79@hotmail.com", "0992196980" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 98,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Kiên Giang", "Tùy Anh Lâm", new DateTime(2024, 4, 7, 14, 42, 57, 575, DateTimeKind.Local).AddTicks(7742), "QuocBao.Ha96@gmail.com", "0994124905" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 99,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Lào Cai", "Quỳnh Liên Tăng", new DateTime(2024, 4, 7, 14, 42, 57, 575, DateTimeKind.Local).AddTicks(7808), "LuongTuyen.Ly@yahoo.com", "0968288640" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 100,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Hải Dương", "Hồ Nam Đinh", new DateTime(2024, 4, 7, 14, 42, 57, 575, DateTimeKind.Local).AddTicks(7881), "KimAnh15@hotmail.com", "0979372154" });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 188, 34028.062875928040000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 2, 2 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 142, 33145.029583545040000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 3, 3 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 177, 21237.758596598240000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 4, 4 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 145, 15413.583081986560000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 5, 5 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 184, 44587.683365797000000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 6, 6 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 120, 21339.607738030880000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 7, 7 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 177, 41194.104116624600000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 8, 8 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 103, 41963.844305120000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 9, 9 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 123, 10182.69338589492960000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 10, 10 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 147, 40993.231403360640000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 11, 11 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 185, 30418.030834396040000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 12, 12 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 101, 40839.37041559560000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 13, 13 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 198, 11605.0449244226280000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 14, 14 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 111, 19039.37423309720000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 15, 15 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 196, 26453.347268653520000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 16, 16 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 194, 36461.846016154480000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 17, 17 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 184, 33436.479393159040000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 18, 18 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 188, 32035.217399955040000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 19, 19 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 156, 21628.875407851960000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 20, 20 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 132, 39626.617575051000000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 21, 21 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 190, 30173.550853617040000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 22, 22 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 132, 41476.913490699800000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 23, 23 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 190, 22881.245145849720000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 24, 24 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 149, 17074.040112648560000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 25, 25 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 103, 46261.17085645840000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 26, 26 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 183, 42510.883448983880000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 27, 27 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 114, 49765.14853248720000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 28, 28 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 200, 49888.090914309040000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 29, 29 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 185, 24026.539100013280000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 30, 30 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 141, 31829.083083299120000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 31, 31 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 147, 48442.984907730040000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 32, 32 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 104, 10189.09604148217960000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 33, 33 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 109, 22959.895673935880000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 34, 34 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 133, 20994.047152700080000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 35, 35 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 148, 13014.0131246967160000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 36, 36 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 182, 20506.755573790520000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 37, 37 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 164, 24213.918812506040000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 38, 38 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 179, 30503.359798382920000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 39, 39 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 176, 37298.675878515680000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 40, 40 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 163, 46803.944814447360000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 41, 41 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 180, 46029.405033370880000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 42, 42 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 144, 14941.354310407800000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 43, 43 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 104, 12124.2001422535880000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 44, 44 },
                column: "UnitPrice",
                value: 39549.820846229440000m);

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 45, 45 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 159, 14080.896412366600000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 46, 46 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 162, 16710.003529144960000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 47, 47 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 108, 36530.609966871760000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 48, 48 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 144, 13403.8026348768560000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 49, 49 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 166, 19052.308985951280000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 50, 50 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 126, 49998.477687834240000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 51, 51 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 113, 20603.279142302440000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 52, 52 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 189, 20150.269920008240000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 53, 53 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 197, 47268.862066266560000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 54, 54 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 126, 37680.564453561120000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 55, 55 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 131, 32107.205814168640000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 56, 56 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 162, 36456.971198760000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 57, 57 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 196, 10744.5684094060360000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 58, 58 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 143, 33109.189688681840000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 59, 59 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 105, 45619.637273992080000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 60, 60 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 200, 42469.640320698880000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 61, 61 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 118, 35547.86377189680000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 62, 62 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 197, 36381.46193689320000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 63, 63 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 157, 24820.277673715120000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 64, 64 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 183, 24824.020273588040000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 65, 65 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 181, 48359.996832682560000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 66, 66 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 190, 39753.701001303040000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 67, 67 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 113, 19455.17306390160000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 68, 68 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 176, 13116.6669598968880000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 69, 69 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 136, 13203.472605373920000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 70, 70 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 198, 44845.785415597400000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 71, 71 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 155, 23231.417287362920000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 72, 72 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 148, 21105.943248272880000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 73, 73 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 194, 17583.603482964280000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 74, 74 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 171, 30400.541607262960000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 75, 75 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 135, 22236.922555944480000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 76, 76 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 126, 42902.340804733280000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 77, 77 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 164, 40175.113570658640000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 78, 78 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 114, 34842.878247981960000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 79, 79 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 132, 31210.157495721640000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 80, 80 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 200, 49650.532033094720000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 81, 81 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 149, 11899.3931423407160000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 82, 82 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 187, 14701.424534761440000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 83, 83 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 165, 43756.429959882320000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 84, 84 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 139, 18984.48508412880000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 85, 85 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 196, 49932.643548161040000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 86, 86 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 101, 29856.102174616280000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 87, 87 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 184, 12693.0154158413440000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 88, 88 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 128, 42637.350704075520000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 89, 89 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 167, 32774.932028450560000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 90, 90 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 162, 20394.363311021880000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 91, 91 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 158, 36042.719468911080000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 92, 92 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 149, 41876.318181805760000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 93, 93 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 175, 43384.185549688240000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 94, 94 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 103, 16500.133487107520000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 95, 95 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 198, 40293.402178221040000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 96, 96 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 141, 21153.030637285880000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 97, 97 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 136, 30389.313463646560000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 98, 98 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 134, 26508.550315919880000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 99, 99 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 193, 26147.290276332240000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 100, 100 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 105, 45958.624701687160000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 54, 101530.2202076216700000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 2, 2 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 65, 178434.331864455700000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 3, 3 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 60, 153335.762097780300000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 4, 4 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 81, 126926.767367748900000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 5, 5 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 56, 146848.487319050200000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 6, 6 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 87, 167586.01146859200000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 7, 7 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 84, 105274.4838051835400000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 8, 8 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 85, 156961.045933969500000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 9, 9 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 73, 128054.61159034900000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 10, 10 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 68, 193679.590114825400000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 11, 11 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 77, 131192.559757588900000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 12, 12 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 60, 132902.149794841400000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 13, 13 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 85, 125803.354533515700000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 14, 14 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 83, 127086.133570619200000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 15, 15 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 51, 106634.6621572243400000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 16, 16 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 81, 112339.745329991700000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 17, 17 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 65, 177242.453296930800000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 18, 18 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 79, 106374.3122903649600000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 19, 19 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 82, 189186.504883651600000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 20, 20 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 85, 145461.145442553200000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 21, 21 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 86, 191607.010729156100000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 22, 22 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 56, 171604.700180002900000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 23, 23 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 82, 180120.118264376400000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 24, 24 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 57, 137543.614430517400000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 25, 25 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 54, 180844.195172663200000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 26, 26 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 68, 172067.34350443600000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 27, 27 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 90, 125422.177039773200000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 28, 28 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 80, 133835.608977859700000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 29, 29 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 90, 124517.566835540100000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 30, 30 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 59, 109653.6061479406500000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 31, 31 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 70, 109674.6891266913800000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 32, 32 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 51, 168356.714952406600000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 33, 33 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 56, 161204.981473006300000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 34, 34 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 50, 129373.044348408200000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 35, 35 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 67, 156489.564387812700000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 36, 36 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 83, 199630.444290654900000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 37, 37 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 51, 108607.3709767729400000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 38, 38 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 84, 100851.02904837364200000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 39, 39 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 68, 151088.91430548800000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 40, 40 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 88, 103326.0204139212900000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 41, 41 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 75, 123515.990638611400000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 42, 42 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 75, 175268.487602307700000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 43, 43 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 52, 108623.4939096070500000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 44, 44 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 87, 118358.972246723200000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 45, 45 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 87, 191139.53377650100000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 46, 46 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 81, 190186.010358972600000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 47, 47 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 83, 101915.8073130948300000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 48, 48 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 88, 162639.670889862100000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 49, 49 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 63, 128722.390414379800000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 50, 50 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 58, 105434.780339239700000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 51, 51 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 62, 120750.261902480100000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 52, 52 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 58, 134169.803609987400000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 53, 53 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 55, 163566.944923526100000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 54, 54 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 64, 142017.55820841300000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 55, 55 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 51, 117102.365037304800000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 56, 56 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 85, 128077.736838718900000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 57, 57 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 87, 106518.0268973451300000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 58, 58 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 59, 151155.759813259900000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 59, 59 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 56, 152984.383011448100000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 60, 60 },
                column: "UnitPrice",
                value: 114898.654369809700000m);

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 61, 61 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 74, 150271.213169557300000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 62, 62 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 56, 114292.684186438200000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 63, 63 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 61, 159126.515988763600000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 64, 64 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 51, 163785.401177453200000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 65, 65 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 50, 164967.766714218300000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 66, 66 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 89, 106244.0051166572800000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 67, 67 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 83, 113807.598562115200000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 68, 68 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 57, 118116.826982517700000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 69, 69 },
                column: "UnitPrice",
                value: 127803.482502701700000m);

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 70, 70 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 87, 148724.310845655800000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 71, 71 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 89, 159207.654810810100000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 72, 72 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 90, 109848.2011524816400000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 73, 73 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 53, 135329.605264971700000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 74, 74 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 64, 149747.230701352400000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 75, 75 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 59, 106505.409416239300000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 76, 76 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 58, 147885.638015838300000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 77, 77 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 50, 106464.4190987157100000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 78, 78 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 66, 192603.128928485400000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 79, 79 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 51, 187112.613278347600000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 80, 80 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 78, 112760.922152746500000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 81, 81 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 67, 119425.80690295200000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 82, 82 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 51, 126708.556742085500000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 83, 83 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 81, 194466.142382165700000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 84, 84 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 78, 167814.257722900800000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 85, 85 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 65, 151414.369643390700000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 86, 86 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 88, 143984.321784746100000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 87, 87 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 56, 171071.565746522100000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 88, 88 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 62, 111495.784991426400000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 89, 89 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 90, 188042.523082459700000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 90, 90 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 66, 173977.213766913900000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 91, 91 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 55, 119966.384243097600000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 92, 92 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 54, 117955.627816001200000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 93, 93 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 75, 116693.899687705400000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 94, 94 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 84, 107398.1134521937600000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 95, 95 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 81, 193988.858758638400000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 96, 96 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 69, 137398.660872740600000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 97, 97 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 66, 172484.658039158400000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 98, 98 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 84, 190700.115583862200000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 99, 99 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 87, 143578.393702635600000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 100, 100 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 77, 168474.131522572900000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 1,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Nam Định", new DateTime(2024, 4, 7, 14, 42, 57, 581, DateTimeKind.Local).AddTicks(4086), "QuangDanh.Do@yahoo.com", "Phương Anh Đỗ", "0912300814", 513068.3183242606000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 2,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Quảng Bình", new DateTime(2024, 4, 7, 14, 42, 57, 581, DateTimeKind.Local).AddTicks(6917), "AnhDuy49@yahoo.com", "Kim Hoàng Đinh", "0942551727", 971014.980852044500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 3,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Hải Phòng", new DateTime(2024, 4, 7, 14, 42, 57, 581, DateTimeKind.Local).AddTicks(7030), "MinhHuyen.Tran@hotmail.com", "Thụy Vân Trương", "0913684463", 851635.701131894000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 4,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Hà Nội", new DateTime(2024, 4, 7, 14, 42, 57, 581, DateTimeKind.Local).AddTicks(7087), "KimHuong54@yahoo.com", "Tiến Hiệp Phan", "0978958738", 841882.031393201000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 5,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Hòa Bình", new DateTime(2024, 4, 7, 14, 42, 57, 581, DateTimeKind.Local).AddTicks(7136), "NganAnh_Duong57@gmail.com", "Hoàng Minh Phạm", "0975858305", 930617.5200326000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 6,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Thái Bình", new DateTime(2024, 4, 7, 14, 42, 57, 581, DateTimeKind.Local).AddTicks(7183), "ThanhMan.Nguyen1@yahoo.com", "Quý Khánh Đỗ", "0931331606", 558825.134430365500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 7,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Quảng Ngãi", new DateTime(2024, 4, 7, 14, 42, 57, 581, DateTimeKind.Local).AddTicks(7224), "ThuyDuong.Dinh47@gmail.com", "Thuận Thành Dương", "0912631054", 905069.598814312000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 8,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Quảng Ngãi", new DateTime(2024, 4, 7, 14, 42, 57, 581, DateTimeKind.Local).AddTicks(7264), "LanKhue26@hotmail.com", "Nhã Thanh Đinh", "0980462686", 897809.847134207500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 9,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "An Giang", new DateTime(2024, 4, 7, 14, 42, 57, 581, DateTimeKind.Local).AddTicks(7309), "HuyenNgoc.Phan61@yahoo.com", "Nhật Hạ Phan", "0947681076", 722512.543954408000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 10,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Bắc Kạn", new DateTime(2024, 4, 7, 14, 42, 57, 581, DateTimeKind.Local).AddTicks(7347), "DucTuan7@gmail.com", "Hương Lâm Nguyễn", "0962095276", 803422.083248780500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 11,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Quảng Ngãi", new DateTime(2024, 4, 7, 14, 42, 57, 581, DateTimeKind.Local).AddTicks(7387), "VinhTho.Hoang@gmail.com", "Kim Thông Phùng", "0900957509", 992377.716334141000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 12,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Tiền Giang", new DateTime(2024, 4, 7, 14, 42, 57, 581, DateTimeKind.Local).AddTicks(7434), "DanLinh25@yahoo.com", "Quốc Thịnh Hồ", "0994200882", 526673.6704700677000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 13,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Lâm Đồng", new DateTime(2024, 4, 7, 14, 42, 57, 581, DateTimeKind.Local).AddTicks(7475), "DinhTrung.Do34@hotmail.com", "Xuân Thủy Lê", "0902913572", 575645.479387722500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 14,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Kiên Giang", new DateTime(2024, 4, 7, 14, 42, 57, 581, DateTimeKind.Local).AddTicks(7516), "DinhTuan_To65@gmail.com", "Bảo Huệ Trần", "0963388574", 818789.963420712000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 15,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Bến Tre", new DateTime(2024, 4, 7, 14, 42, 57, 581, DateTimeKind.Local).AddTicks(7560), "HongMinh50@gmail.com", "Thành Lợi Lê", "0922539084", 739223.572783646000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 16,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Đồng Tháp", new DateTime(2024, 4, 7, 14, 42, 57, 581, DateTimeKind.Local).AddTicks(7632), "KimDan_Vuong96@yahoo.com", "Ðại Dương Vũ", "0970550046", 641864.971531386000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 17,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Hải Dương", new DateTime(2024, 4, 7, 14, 42, 57, 581, DateTimeKind.Local).AddTicks(7683), "BaoTien_Dao@hotmail.com", "Anh Ðức Phùng", "0996616340", 582073.219355463000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 18,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Bình Thuận", new DateTime(2024, 4, 7, 14, 42, 57, 581, DateTimeKind.Local).AddTicks(7722), "MaiNhi_Phung94@gmail.com", "Bá Phước Phan", "0927297836", 746865.583071326500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 19,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Yên Bái", new DateTime(2024, 4, 7, 14, 42, 57, 581, DateTimeKind.Local).AddTicks(7766), "KieuLoan.To0@gmail.com", "Cao Kỳ Dương", "0920625451", 567007.000992196500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 20,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Sóc Trăng", new DateTime(2024, 4, 7, 14, 42, 57, 581, DateTimeKind.Local).AddTicks(7810), "TruongPhu.Dinh@gmail.com", "Hà Mi Vương", "0988739343", 894903.993696542000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 21,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Sơn La", new DateTime(2024, 4, 7, 14, 42, 57, 581, DateTimeKind.Local).AddTicks(7849), "ThanhPhuong.Phan43@hotmail.com", "Kim Quyên Bùi", "0945211518", 813901.787465987000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 22,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Yên Bái", new DateTime(2024, 4, 7, 14, 42, 57, 581, DateTimeKind.Local).AddTicks(7888), "HaiSon77@gmail.com", "Hoàng Thái Trịnh", "0926112153", 782882.133766947000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 23,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Quảng Ninh", new DateTime(2024, 4, 7, 14, 42, 57, 581, DateTimeKind.Local).AddTicks(7937), "ChiKhiem40@yahoo.com", "Thiên Phú Tăng", "0960980633", 577003.860730054500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 24,
                columns: new[] { "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { new DateTime(2024, 4, 7, 14, 42, 57, 581, DateTimeKind.Local).AddTicks(7974), "HanhDung_To@gmail.com", "Diệu Ngọc Đỗ", "0969117127", 589171.639592700500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 25,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Quảng Trị", new DateTime(2024, 4, 7, 14, 42, 57, 581, DateTimeKind.Local).AddTicks(8013), "HuuNghi_Hoang65@gmail.com", "Việt Trinh Nguyễn", "0942602300", 813855.67436127500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 26,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Cà Mau", new DateTime(2024, 4, 7, 14, 42, 57, 581, DateTimeKind.Local).AddTicks(8056), "BichNga.Phung49@yahoo.com", "Mạnh Tấn Phạm", "0938255533", 795567.8046489500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 27,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Bình Định", new DateTime(2024, 4, 7, 14, 42, 57, 581, DateTimeKind.Local).AddTicks(8103), "HungTuong7@hotmail.com", "Chiêu Quân Tăng", "0970628664", 927400.358170550500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 28,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Lai Châu", new DateTime(2024, 4, 7, 14, 42, 57, 581, DateTimeKind.Local).AddTicks(8151), "BaoHa_Lam@hotmail.com", "Bích Loan Đinh", "0903579362", 705627.68990518500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 29,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Lào Cai", new DateTime(2024, 4, 7, 14, 42, 57, 581, DateTimeKind.Local).AddTicks(8190), "ToQuyen.Vuong@hotmail.com", "Minh Xuân Lý", "0995807165", 814640.223220219000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 30,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Quảng Ninh", new DateTime(2024, 4, 7, 14, 42, 57, 581, DateTimeKind.Local).AddTicks(8234), "HuongTien.Vu@gmail.com", "Hương Trà Phùng", "0941531713", 614331.357941915500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 31,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Lạng Sơn", new DateTime(2024, 4, 7, 14, 42, 57, 581, DateTimeKind.Local).AddTicks(8279), "YenPhuong.Dang73@gmail.com", "Nhã Uyên Dương", "0951115727", 526605.5838362713000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 32,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Kon Tum", new DateTime(2024, 4, 7, 14, 42, 57, 581, DateTimeKind.Local).AddTicks(8318), "HongChau_Nguyen@yahoo.com", "Quỳnh Trang Tô", "0907330590", 671138.32933249000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 33,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Bình Thuận", new DateTime(2024, 4, 7, 14, 42, 57, 581, DateTimeKind.Local).AddTicks(8357), "HuyChieu_Ly@gmail.com", "Mỹ Nhân Trần", "0936020459", 951009.154138917000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 34,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Tuyên Quang", new DateTime(2024, 4, 7, 14, 42, 57, 581, DateTimeKind.Local).AddTicks(8400), "NhaMai_Phan@hotmail.com", "Ngọc Ðàn Đinh", "0922968708", 557574.420806953000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 35,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Hòa Bình", new DateTime(2024, 4, 7, 14, 42, 57, 581, DateTimeKind.Local).AddTicks(8439), "HoaLy0@yahoo.com", "Phúc Nguyên Phạm", "0978927794", 659937.481592040500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 36,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "TP. Hồ Chí Minh", new DateTime(2024, 4, 7, 14, 42, 57, 581, DateTimeKind.Local).AddTicks(8476), "QuocThien.Ha@gmail.com", "Ðăng An Mai", "0909903673", 720719.264798957500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 37,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Long An", new DateTime(2024, 4, 7, 14, 42, 57, 581, DateTimeKind.Local).AddTicks(8518), "HoaHiep31@gmail.com", "Hưng Ðạo Phan", "0921070558", 946524.131662838500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 38,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Tiền Giang", new DateTime(2024, 4, 7, 14, 42, 57, 581, DateTimeKind.Local).AddTicks(8557), "HuyThanh.Tang@hotmail.com", "Thường Kiệt Đoàn", "0962038434", 758346.021770462500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 39,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Gia Lai", new DateTime(2024, 4, 7, 14, 42, 57, 581, DateTimeKind.Local).AddTicks(8600), "BichNhu_To@hotmail.com", "Mộng Thi Tăng", "0966834892", 582755.482499921500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 40,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Quảng Nam", new DateTime(2024, 4, 7, 14, 42, 57, 581, DateTimeKind.Local).AddTicks(8639), "AiHong36@hotmail.com", "Hằng Anh Tô", "0977150509", 636170.832369296500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 41,
                columns: new[] { "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { new DateTime(2024, 4, 7, 14, 42, 57, 581, DateTimeKind.Local).AddTicks(8678), "NguyenLoc.Lam38@gmail.com", "Quang Dũng Phùng", "0965321365", 874278.412352325500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 42,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Hà Tĩnh", new DateTime(2024, 4, 7, 14, 42, 57, 581, DateTimeKind.Local).AddTicks(8721), "LongQuan68@yahoo.com", "Cao Nhân Đỗ", "0903697521", 841960.61969672500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 43,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Lâm Đồng", new DateTime(2024, 4, 7, 14, 42, 57, 581, DateTimeKind.Local).AddTicks(8758), "HongKhue.Ha@gmail.com", "Ðan Quỳnh Phùng", "0913660768", 626483.294726691000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 44,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Hà Tĩnh", new DateTime(2024, 4, 7, 14, 42, 57, 581, DateTimeKind.Local).AddTicks(8797), "SonDuong_Dao64@yahoo.com", "Liên Trân Tăng", "0982788918", 991829.001738981000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 45,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Bạc Liêu", new DateTime(2024, 4, 7, 14, 42, 57, 581, DateTimeKind.Local).AddTicks(8839), "HueAn.Do46@hotmail.com", "Bình Yên Hồ", "0951102284", 527255.3859426905500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 46,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Đắk Nông", new DateTime(2024, 4, 7, 14, 42, 57, 581, DateTimeKind.Local).AddTicks(8885), "ThaiNguyen.Vu75@yahoo.com", "Diệu Hằng Đào", "0914769320", 857297.76460572500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 47,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Hậu Giang", new DateTime(2024, 4, 7, 14, 42, 57, 581, DateTimeKind.Local).AddTicks(8924), "QuocHoai.Dao49@yahoo.com", "Đông Tuyền Tô", "0912112489", 670959.940600043500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 48,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Bạc Liêu", new DateTime(2024, 4, 7, 14, 42, 57, 581, DateTimeKind.Local).AddTicks(8968), "VanTrang.Nguyen@hotmail.com", "Hòa Bình Trương", "0956839446", 969422.526328234000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 49,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Cao Bằng", new DateTime(2024, 4, 7, 14, 42, 57, 581, DateTimeKind.Local).AddTicks(9018), "KietTrinh.Le13@yahoo.com", "Lương Tuyền Tô", "0920675946", 924560.724292511000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 50,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Hà Giang", new DateTime(2024, 4, 7, 14, 42, 57, 581, DateTimeKind.Local).AddTicks(9056), "ThongMinh.Dao18@yahoo.com", "Hiếu Dụng Ngô", "0997766498", 751344.107788495500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 51,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Hà Tĩnh", new DateTime(2024, 4, 7, 14, 42, 57, 581, DateTimeKind.Local).AddTicks(9100), "NhaLy58@yahoo.com", "Bảo Huynh Tăng", "0949227697", 874937.677908748000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 52,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Yên Bái", new DateTime(2024, 4, 7, 14, 42, 57, 581, DateTimeKind.Local).AddTicks(9138), "HoaiVy_Le@yahoo.com", "Thuận Thành Đinh", "0903042829", 783148.594241727500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 53,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Quảng Trị", new DateTime(2024, 4, 7, 14, 42, 57, 581, DateTimeKind.Local).AddTicks(9183), "LongGiang_Doan25@hotmail.com", "Yên Mai Tăng", "0944018349", 563507.752704057500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 54,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Lâm Đồng", new DateTime(2024, 4, 7, 14, 42, 57, 581, DateTimeKind.Local).AddTicks(9222), "ThyVan.Dang@yahoo.com", "Hoàng Giang Trần", "0977519228", 597562.548822861000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 55,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Long An", new DateTime(2024, 4, 7, 14, 42, 57, 581, DateTimeKind.Local).AddTicks(9263), "ThuNgan_Phan@yahoo.com", "Hữu Hiệp Hoàng", "0950079216", 636483.392451611000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 56,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Hà Giang", new DateTime(2024, 4, 7, 14, 42, 57, 581, DateTimeKind.Local).AddTicks(9307), "ThienTinh.Phung@yahoo.com", "Minh Kỳ Lê", "0921417384", 930518.301738913000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 57,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Hà Giang", new DateTime(2024, 4, 7, 14, 42, 57, 581, DateTimeKind.Local).AddTicks(9350), "HoaTien_Dinh@gmail.com", "Tâm Nguyên Mai", "0933439724", 717622.581944291000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 58,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Bà Rịa-Vũng Tàu", new DateTime(2024, 4, 7, 14, 42, 57, 581, DateTimeKind.Local).AddTicks(9387), "ThanhHao.Phung12@yahoo.com", "Bạch Yến Phạm", "0957660731", 534798.5300193857500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 59,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Đồng Nai", new DateTime(2024, 4, 7, 14, 42, 57, 581, DateTimeKind.Local).AddTicks(9434), "MinhHoang.Le3@hotmail.com", "Bảo Ðịnh Hồ", "0979337521", 864358.112201625500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 60,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Hà Giang", new DateTime(2024, 4, 7, 14, 42, 57, 581, DateTimeKind.Local).AddTicks(9473), "TruongSa_Tran77@hotmail.com", "Hoàng Khôi Đỗ", "0953354809", 549032.2299847894500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 61,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Hà Nội", new DateTime(2024, 4, 7, 14, 42, 57, 581, DateTimeKind.Local).AddTicks(9510), "ThanhGiang.Duong@gmail.com", "Hoàng Thư Trần", "0905306487", 586749.323644222500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 62,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Bình Thuận", new DateTime(2024, 4, 7, 14, 42, 57, 581, DateTimeKind.Local).AddTicks(9560), "ThucQuyen.Nguyen@yahoo.com", "Thảo My Lý", "0999245473", 627534.452062332500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 63,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Hải Dương", new DateTime(2024, 4, 7, 14, 42, 57, 581, DateTimeKind.Local).AddTicks(9597), "NhaYen39@yahoo.com", "Hải Vân Trịnh", "0993167568", 556110.146696083500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 64,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Bình Thuận", new DateTime(2024, 4, 7, 14, 42, 57, 581, DateTimeKind.Local).AddTicks(9645), "KimTuyen_Ly@hotmail.com", "Hồng Giang Mai", "0982923034", 852985.687020162500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 65,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Thanh Hoá", new DateTime(2024, 4, 7, 14, 42, 57, 581, DateTimeKind.Local).AddTicks(9682), "QuynhDao_Vu60@gmail.com", "Quyết Thắng Phùng", "0920292973", 593039.640825879500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 66,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Điện Biên", new DateTime(2024, 4, 7, 14, 42, 57, 581, DateTimeKind.Local).AddTicks(9719), "LinhDan30@gmail.com", "Ðắc Thành Hà", "0965534488", 771564.387257404500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 67,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Hải Dương", new DateTime(2024, 4, 7, 14, 42, 57, 581, DateTimeKind.Local).AddTicks(9763), "CaoTho.Pham87@hotmail.com", "Thu Giang Phan", "0966968927", 537056.9635675629500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 68,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Bạc Liêu", new DateTime(2024, 4, 7, 14, 42, 57, 581, DateTimeKind.Local).AddTicks(9800), "ThanhKhiem_Ly@yahoo.com", "Quốc Hoài Hoàng", "0951563200", 524474.111997490500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 69,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Cần Thơ", new DateTime(2024, 4, 7, 14, 42, 57, 581, DateTimeKind.Local).AddTicks(9838), "HieuNghia_Tran7@gmail.com", "Lan Vy Ngô", "0927721742", 691841.290343609000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 70,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Quảng Trị", new DateTime(2024, 4, 7, 14, 42, 57, 581, DateTimeKind.Local).AddTicks(9883), "DongTra_Trinh@yahoo.com", "Thuận Phong Đỗ", "0940910049", 624862.655656532000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 71,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Hải Dương", new DateTime(2024, 4, 7, 14, 42, 57, 581, DateTimeKind.Local).AddTicks(9921), "NhuNgoc57@hotmail.com", "Mai Tâm Phan", "0998386930", 783721.731212286500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 72,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Hà Giang", new DateTime(2024, 4, 7, 14, 42, 57, 581, DateTimeKind.Local).AddTicks(9959), "NhatPhuong.Truong@yahoo.com", "Vân Anh Bùi", "0913704637", 535901.2296247252000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 73,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Yên Bái", new DateTime(2024, 4, 7, 14, 42, 57, 582, DateTimeKind.Local).AddTicks(1), "ThuongLiet26@hotmail.com", "Thái Duy Hoàng", "0996305349", 922155.349419594000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 74,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Quảng Ninh", new DateTime(2024, 4, 7, 14, 42, 57, 582, DateTimeKind.Local).AddTicks(39), "ThanhHao_Duong79@yahoo.com", "Ngọc Hân Đặng", "0977591766", 626040.598720548000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 75,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Cao Bằng", new DateTime(2024, 4, 7, 14, 42, 57, 582, DateTimeKind.Local).AddTicks(84), "ThanhHoa.Ha@hotmail.com", "Nam Phương Dương", "0987466852", 856939.796896341000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 76,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Cần Thơ", new DateTime(2024, 4, 7, 14, 42, 57, 582, DateTimeKind.Local).AddTicks(121), "HaiBang.Phan24@yahoo.com", "Ðình Trung Vũ", "0943809326", 685420.964793277500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 77,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Nghệ An", new DateTime(2024, 4, 7, 14, 42, 57, 582, DateTimeKind.Local).AddTicks(157), "ManhTuong.Lam@gmail.com", "Trung Kiên Lê", "0941642930", 913468.696370468500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 78,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Thái Nguyên", new DateTime(2024, 4, 7, 14, 42, 57, 582, DateTimeKind.Local).AddTicks(201), "MyNuong.Ho@hotmail.com", "Quỳnh Hoa Nguyễn", "0930281566", 631923.932449246500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 79,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Ninh Bình", new DateTime(2024, 4, 7, 14, 42, 57, 582, DateTimeKind.Local).AddTicks(239), "NhatHa48@yahoo.com", "Hạnh Trang Trần", "0977544599", 995314.574337387000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 80,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Quảng Bình", new DateTime(2024, 4, 7, 14, 42, 57, 582, DateTimeKind.Local).AddTicks(426), "MongLan.Ngo@gmail.com", "Chiến Thắng Trần", "0921654205", 550175.087633869000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 81,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Hà Giang", new DateTime(2024, 4, 7, 14, 42, 57, 587, DateTimeKind.Local).AddTicks(1372), "MinhTri_Dang@yahoo.com", "Xuân Thuyết Đinh", "0962617863", 732735.458725615500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 82,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Long An", new DateTime(2024, 4, 7, 14, 42, 57, 587, DateTimeKind.Local).AddTicks(1499), "BichHai_Do@yahoo.com", "Ðông Quân Bùi", "0929655173", 646925.541937067000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 83,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Hà Giang", new DateTime(2024, 4, 7, 14, 42, 57, 587, DateTimeKind.Local).AddTicks(1592), "NhatTien_Doan@gmail.com", "Kim Thanh Bùi", "0983827428", 625956.345013592000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 84,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Thừa Thiên-Huế", new DateTime(2024, 4, 7, 14, 42, 57, 587, DateTimeKind.Local).AddTicks(1637), "MaiPhuong.Lam@yahoo.com", "Việt Quyết Đoàn", "0989340686", 798652.314599758500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 85,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Đắk Lắk", new DateTime(2024, 4, 7, 14, 42, 57, 587, DateTimeKind.Local).AddTicks(1679), "ThaiSang.Le85@hotmail.com", "Gia Phước Ngô", "0997313958", 964177.360297312500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 86,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Hà Nội", new DateTime(2024, 4, 7, 14, 42, 57, 587, DateTimeKind.Local).AddTicks(1730), "QuePhuong.Phung@yahoo.com", "Gia Kiên Lê", "0920959587", 953797.925571422500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 87,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Hà Nam", new DateTime(2024, 4, 7, 14, 42, 57, 587, DateTimeKind.Local).AddTicks(1770), "QuynhAnh_Ly78@hotmail.com", "Minh Ðan Vương", "0963686145", 862395.130109414000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 88,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Khánh Hoà", new DateTime(2024, 4, 7, 14, 42, 57, 587, DateTimeKind.Local).AddTicks(1809), "HaiLong.Le45@gmail.com", "Ngọc Trụ Tô", "0962094285", 795186.427337294000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 89,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Vĩnh Long", new DateTime(2024, 4, 7, 14, 42, 57, 587, DateTimeKind.Local).AddTicks(1863), "TuanKhanh29@hotmail.com", "Hoàng Phát Trịnh", "0922191843", 645068.551242266500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 90,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Đà Nẵng", new DateTime(2024, 4, 7, 14, 42, 57, 587, DateTimeKind.Local).AddTicks(1902), "ThucTam.Do@gmail.com", "Thiên Trí Tô", "0964546917", 904311.514329967000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 91,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Điện Biên", new DateTime(2024, 4, 7, 14, 42, 57, 587, DateTimeKind.Local).AddTicks(1940), "DiemLien.Tran38@gmail.com", "Nhân Nguyên Bùi", "0953251770", 900972.876850156000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 92,
                columns: new[] { "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { new DateTime(2024, 4, 7, 14, 42, 57, 587, DateTimeKind.Local).AddTicks(1984), "HuyThanh69@yahoo.com", "Yến Trâm Đỗ", "0996902771", 698720.779414406000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 93,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Bắc Kạn", new DateTime(2024, 4, 7, 14, 42, 57, 587, DateTimeKind.Local).AddTicks(2059), "HongXuan74@hotmail.com", "Tịnh Tâm Hoàng", "0928980127", 809770.534712381000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 94,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Sơn La", new DateTime(2024, 4, 7, 14, 42, 57, 587, DateTimeKind.Local).AddTicks(2104), "HueAn.Dinh31@hotmail.com", "Yến Loan Ngô", "0962428051", 648138.794719022000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 95,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Bình Dương", new DateTime(2024, 4, 7, 14, 42, 57, 587, DateTimeKind.Local).AddTicks(2143), "ThangCanh20@yahoo.com", "Thy Vân Trương", "0947873420", 728979.108307603500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 96,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Thái Nguyên", new DateTime(2024, 4, 7, 14, 42, 57, 587, DateTimeKind.Local).AddTicks(2184), "TuanLong.Pham18@yahoo.com", "Trung Anh Đặng", "0972837036", 645893.435678691000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 97,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Quảng Ngãi", new DateTime(2024, 4, 7, 14, 42, 57, 587, DateTimeKind.Local).AddTicks(2227), "DiemPhuong_Ly@gmail.com", "Duy Hoàng Hà", "0902291245", 706521.854231247500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 98,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Khánh Hoà", new DateTime(2024, 4, 7, 14, 42, 57, 587, DateTimeKind.Local).AddTicks(2272), "KhietTam.Vuong38@hotmail.com", "Thùy Uyên Tô", "0903638179", 536598.0623736253500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 99,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Quảng Ninh", new DateTime(2024, 4, 7, 14, 42, 57, 587, DateTimeKind.Local).AddTicks(2310), "ThuLinh.Ha35@hotmail.com", "Nam Nhật Lê", "0968251919", 983184.199116275500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 100,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Quảng Ngãi", new DateTime(2024, 4, 7, 14, 42, 57, 587, DateTimeKind.Local).AddTicks(2354), "TrieuThanh.Phung@hotmail.com", "Ðức Tường Nguyễn", "0973411178", 716865.224142921000000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 1,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 75, new DateTime(2024, 5, 24, 5, 19, 43, 807, DateTimeKind.Unspecified).AddTicks(3499), 67, 6397275.820674471520000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 2,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 75, new DateTime(2024, 5, 12, 8, 7, 44, 181, DateTimeKind.Unspecified).AddTicks(2060), 55, 4706594.200863395680000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 3,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 92, new DateTime(2024, 5, 10, 9, 6, 43, 832, DateTimeKind.Unspecified).AddTicks(6790), 49, 3759083.271597888480000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 4,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 53, new DateTime(2024, 5, 28, 12, 37, 18, 588, DateTimeKind.Unspecified).AddTicks(900), 80, 2234969.546888051200000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 5,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 40, new DateTime(2024, 5, 9, 20, 54, 2, 621, DateTimeKind.Unspecified).AddTicks(9575), 14, 8204133.739306648000000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 6,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 98, new DateTime(2024, 5, 15, 2, 47, 15, 450, DateTimeKind.Unspecified).AddTicks(3989), 43, 2560752.928563705600000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 7,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 38, new DateTime(2024, 5, 20, 16, 5, 31, 198, DateTimeKind.Unspecified).AddTicks(9669), 8, 7291356.428642554200000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 8,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 59, new DateTime(2024, 5, 20, 20, 22, 20, 867, DateTimeKind.Unspecified).AddTicks(71), 13, 4322275.963427360000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 9,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 66, new DateTime(2024, 5, 19, 2, 32, 23, 781, DateTimeKind.Unspecified).AddTicks(6202), 60, 1252471.28646507634080000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 10,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 49, new DateTime(2024, 5, 26, 14, 9, 55, 294, DateTimeKind.Unspecified).AddTicks(1560), 72, 6026005.016294014080000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 11,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 27, new DateTime(2024, 5, 25, 4, 26, 3, 411, DateTimeKind.Unspecified).AddTicks(7039), 52, 5627335.704363267400000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 12,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 78, new DateTime(2024, 5, 6, 5, 33, 33, 164, DateTimeKind.Unspecified).AddTicks(2097), 29, 4124776.41197515560000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 13,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 16, new DateTime(2024, 5, 25, 17, 19, 48, 474, DateTimeKind.Unspecified).AddTicks(1728), 49, 2297798.8950356803440000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 14,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 69, new DateTime(2024, 5, 27, 6, 6, 42, 675, DateTimeKind.Unspecified).AddTicks(8039), 49, 2113370.53987378920000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 15,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 46, new DateTime(2024, 5, 7, 6, 56, 50, 705, DateTimeKind.Unspecified).AddTicks(849), 45, 5184856.064656089920000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 16,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 64, new DateTime(2024, 5, 5, 20, 3, 9, 39, DateTimeKind.Unspecified).AddTicks(2949), 14, 7073598.127133969120000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 17,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 63, new DateTime(2024, 5, 22, 15, 48, 2, 735, DateTimeKind.Unspecified).AddTicks(9561), 59, 6152312.208341263360000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 18,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 85, new DateTime(2024, 5, 16, 14, 4, 42, 280, DateTimeKind.Unspecified).AddTicks(1769), 82, 6022620.871191547520000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 19,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 64, new DateTime(2024, 5, 24, 3, 3, 39, 248, DateTimeKind.Unspecified).AddTicks(8923), 60, 3374104.563624905760000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 20,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 84, new DateTime(2024, 5, 25, 13, 47, 12, 528, DateTimeKind.Unspecified).AddTicks(9119), 21, 5230713.519906732000000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 21,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 84, new DateTime(2024, 5, 4, 11, 37, 39, 624, DateTimeKind.Unspecified).AddTicks(7711), 58, 5732974.662187237600000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 22,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 69, new DateTime(2024, 5, 6, 20, 58, 44, 579, DateTimeKind.Unspecified).AddTicks(9484), 38, 5474952.580772373600000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 23,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 16, new DateTime(2024, 5, 19, 19, 45, 46, 393, DateTimeKind.Unspecified).AddTicks(1971), 32, 4347436.577711446800000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 24,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 100, new DateTime(2024, 5, 29, 12, 23, 50, 50, DateTimeKind.Unspecified).AddTicks(7821), 80, 2544031.976784635440000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 25,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 14, new DateTime(2024, 5, 7, 17, 42, 27, 571, DateTimeKind.Unspecified).AddTicks(2586), 2, 4764900.59821521520000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 26,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 78, new DateTime(2024, 5, 11, 22, 47, 2, 902, DateTimeKind.Unspecified).AddTicks(3063), 51, 7779491.671164050040000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 27,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 25, new DateTime(2024, 5, 19, 18, 36, 58, 231, DateTimeKind.Unspecified).AddTicks(8388), 43, 5673226.93270354080000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 28,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 11, new DateTime(2024, 5, 4, 21, 31, 48, 134, DateTimeKind.Unspecified).AddTicks(477), 52, 9977618.182861808000000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 29,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 34, new DateTime(2024, 5, 14, 5, 8, 11, 63, DateTimeKind.Unspecified).AddTicks(4272), 40, 4444909.733502456800000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 30,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 49, new DateTime(2024, 5, 20, 20, 7, 49, 318, DateTimeKind.Unspecified).AddTicks(6899), 69, 4487900.714745175920000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 31,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 43, new DateTime(2024, 5, 26, 15, 17, 12, 62, DateTimeKind.Unspecified).AddTicks(3825), 22, 7121118.781436315880000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 32,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 3, new DateTime(2024, 5, 18, 12, 45, 2, 441, DateTimeKind.Unspecified).AddTicks(577), 27, 1059665.98831414667840000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 33,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 2, new DateTime(2024, 5, 20, 13, 24, 21, 822, DateTimeKind.Unspecified).AddTicks(1660), 6, 2502628.628459010920000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 34,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 71, new DateTime(2024, 5, 1, 1, 43, 22, 856, DateTimeKind.Unspecified).AddTicks(5387), 97, 2792208.271309110640000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 35,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 29, new DateTime(2024, 5, 25, 6, 13, 38, 805, DateTimeKind.Unspecified).AddTicks(4453), 35, 1926073.9424551139680000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 36,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 56, new DateTime(2024, 5, 26, 16, 32, 15, 373, DateTimeKind.Unspecified).AddTicks(7768), 40, 3732229.514429874640000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 37,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 9, new DateTime(2024, 5, 19, 15, 12, 22, 323, DateTimeKind.Unspecified).AddTicks(438), 35, 3971082.685250990560000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 38,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 98, new DateTime(2024, 5, 1, 14, 12, 29, 839, DateTimeKind.Unspecified).AddTicks(5551), 87, 5460101.403910542680000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 39,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 23, new DateTime(2024, 5, 23, 18, 43, 28, 601, DateTimeKind.Unspecified).AddTicks(5328), 93, 6564566.954618759680000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 40,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 67, new DateTime(2024, 5, 7, 16, 47, 51, 33, DateTimeKind.Unspecified).AddTicks(9793), 18, 7629043.004754919680000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 41,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 34, new DateTime(2024, 5, 3, 18, 22, 42, 59, DateTimeKind.Unspecified).AddTicks(6372), 41, 8285292.906006758400000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 42,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 59, new DateTime(2024, 5, 25, 21, 20, 8, 513, DateTimeKind.Unspecified).AddTicks(4529), 7, 2151555.020698723200000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 43,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 72, new DateTime(2024, 5, 6, 2, 20, 4, 217, DateTimeKind.Unspecified).AddTicks(6752), 59, 1260916.8147943731520000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 44,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 48, new DateTime(2024, 5, 20, 0, 42, 42, 457, DateTimeKind.Unspecified).AddTicks(1645), 90, 6881668.827243922560000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 45,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 20, new DateTime(2024, 5, 11, 7, 9, 22, 874, DateTimeKind.Unspecified).AddTicks(6219), 31, 2238862.529566289400000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 46,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 18, new DateTime(2024, 5, 22, 12, 23, 22, 569, DateTimeKind.Unspecified).AddTicks(7128), 89, 2707020.571721483520000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 47,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 34, new DateTime(2024, 5, 15, 21, 34, 58, 311, DateTimeKind.Unspecified).AddTicks(1824), 91, 3945305.876422150080000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 48,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 63, new DateTime(2024, 5, 22, 7, 56, 26, 79, DateTimeKind.Unspecified).AddTicks(8635), 1, 1930147.5794222672640000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 49,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 30, new DateTime(2024, 5, 24, 23, 58, 44, 204, DateTimeKind.Unspecified).AddTicks(102), 54, 3162683.291667912480000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 50,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 93, new DateTime(2024, 5, 3, 18, 16, 48, 446, DateTimeKind.Unspecified).AddTicks(9945), 53, 6299808.188667114240000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 51,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 96, new DateTime(2024, 5, 16, 7, 44, 0, 363, DateTimeKind.Unspecified).AddTicks(7689), 30, 2328170.543080175720000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 52,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 80, new DateTime(2024, 5, 23, 17, 24, 59, 178, DateTimeKind.Unspecified).AddTicks(9792), 90, 3808401.014881557360000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 53,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 50, new DateTime(2024, 5, 10, 18, 32, 27, 618, DateTimeKind.Unspecified).AddTicks(5433), 67, 9311965.827054512320000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 54,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 57, new DateTime(2024, 5, 14, 22, 54, 37, 377, DateTimeKind.Unspecified).AddTicks(7284), 49, 4747751.121148701120000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 55,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 70, new DateTime(2024, 5, 23, 6, 8, 36, 56, DateTimeKind.Unspecified).AddTicks(1423), 5, 4206043.961656091840000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 56,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 85, new DateTime(2024, 5, 15, 22, 25, 2, 93, DateTimeKind.Unspecified).AddTicks(2293), 19, 5906029.334199120000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 57,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 96, new DateTime(2024, 5, 1, 8, 29, 56, 586, DateTimeKind.Unspecified).AddTicks(9326), 72, 2105935.4082435830560000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 58,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 11, new DateTime(2024, 5, 28, 1, 9, 17, 659, DateTimeKind.Unspecified).AddTicks(6913), 88, 4734614.125481503120000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 59,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 95, new DateTime(2024, 5, 27, 23, 39, 50, 51, DateTimeKind.Unspecified).AddTicks(3153), 96, 4790061.913769168400000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 60,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 65, new DateTime(2024, 5, 14, 2, 13, 50, 250, DateTimeKind.Unspecified).AddTicks(4174), 14, 8493928.064139776000000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 61,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 60, new DateTime(2024, 5, 20, 22, 34, 23, 771, DateTimeKind.Unspecified).AddTicks(1402), 55, 4194647.92508382240000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 62,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 77, new DateTime(2024, 5, 16, 18, 44, 52, 911, DateTimeKind.Unspecified).AddTicks(1805), 37, 7167148.00156796040000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 63,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 80, new DateTime(2024, 5, 14, 14, 52, 2, 256, DateTimeKind.Unspecified).AddTicks(769), 20, 3896783.594773273840000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 64,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 61, new DateTime(2024, 5, 4, 13, 5, 59, 62, DateTimeKind.Unspecified).AddTicks(5609), 1, 4542795.710066611320000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 65,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 37, new DateTime(2024, 5, 25, 23, 9, 31, 829, DateTimeKind.Unspecified).AddTicks(3704), 80, 8753159.426715543360000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 66,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 56, new DateTime(2024, 5, 19, 23, 27, 18, 791, DateTimeKind.Unspecified).AddTicks(8818), 60, 7553203.190247577600000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 67,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 18, new DateTime(2024, 5, 14, 4, 35, 24, 434, DateTimeKind.Unspecified).AddTicks(7958), 5, 2198434.55622088080000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 68,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 53, new DateTime(2024, 5, 10, 5, 36, 1, 240, DateTimeKind.Unspecified).AddTicks(1961), 28, 2308533.3849418522880000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 69,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 13, new DateTime(2024, 5, 24, 11, 58, 53, 699, DateTimeKind.Unspecified).AddTicks(2093), 55, 1795672.274330853120000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 70,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 76, new DateTime(2024, 5, 18, 8, 18, 14, 81, DateTimeKind.Unspecified).AddTicks(3796), 46, 8879465.512288285200000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 71,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 16, new DateTime(2024, 5, 5, 7, 37, 13, 998, DateTimeKind.Unspecified).AddTicks(5317), 70, 3600869.679541252600000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 72,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 53, new DateTime(2024, 5, 10, 17, 4, 49, 184, DateTimeKind.Unspecified).AddTicks(508), 64, 3123679.600744386240000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 73,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 83, new DateTime(2024, 5, 5, 11, 38, 19, 168, DateTimeKind.Unspecified).AddTicks(4208), 47, 3411219.075695070320000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 74,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 49, new DateTime(2024, 5, 4, 4, 20, 4, 374, DateTimeKind.Unspecified).AddTicks(1240), 93, 5198492.614841966160000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 75,
                columns: new[] { "EmployeeID", "OrderDate", "TotalPrice" },
                values: new object[] { 3, new DateTime(2024, 5, 3, 15, 59, 47, 257, DateTimeKind.Unspecified).AddTicks(7879), 3001984.545052504800000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 76,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 73, new DateTime(2024, 5, 13, 14, 46, 13, 550, DateTimeKind.Unspecified).AddTicks(6289), 66, 5405694.941396393280000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 77,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 87, new DateTime(2024, 5, 12, 5, 47, 55, 416, DateTimeKind.Unspecified).AddTicks(3323), 75, 6588718.625588016960000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 78,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 79, new DateTime(2024, 5, 22, 21, 2, 43, 462, DateTimeKind.Unspecified).AddTicks(3902), 89, 3972088.120269943440000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 79,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 19, new DateTime(2024, 5, 27, 11, 49, 53, 777, DateTimeKind.Unspecified).AddTicks(8717), 25, 4119740.789435256480000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 80,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 94, new DateTime(2024, 5, 29, 14, 51, 52, 158, DateTimeKind.Unspecified).AddTicks(4417), 34, 9930106.406618944000000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 81,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 23, new DateTime(2024, 5, 18, 0, 8, 46, 768, DateTimeKind.Unspecified).AddTicks(5067), 77, 1773009.5782087666840000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 82,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 10, new DateTime(2024, 5, 5, 9, 36, 27, 601, DateTimeKind.Unspecified).AddTicks(5186), 75, 2749166.388000389280000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 83,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 73, new DateTime(2024, 5, 17, 1, 22, 48, 789, DateTimeKind.Unspecified).AddTicks(9894), 84, 7219810.943380582800000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 84,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 89, new DateTime(2024, 5, 25, 16, 55, 30, 963, DateTimeKind.Unspecified).AddTicks(2939), 9, 2638843.42669390320000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 85,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 8, new DateTime(2024, 5, 22, 18, 56, 9, 210, DateTimeKind.Unspecified).AddTicks(1373), 13, 9786798.135439563840000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 86,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 54, new DateTime(2024, 5, 29, 13, 42, 59, 387, DateTimeKind.Unspecified).AddTicks(5611), 88, 3015466.319636244280000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 87,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 17, new DateTime(2024, 5, 23, 16, 20, 42, 726, DateTimeKind.Unspecified).AddTicks(9663), 8, 2335514.8365148072960000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 88,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 10, new DateTime(2024, 5, 26, 8, 30, 49, 258, DateTimeKind.Unspecified).AddTicks(3833), 93, 5457580.890121666560000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 89,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 8, new DateTime(2024, 5, 7, 3, 51, 29, 435, DateTimeKind.Unspecified).AddTicks(8219), 52, 5473413.648751243520000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 90,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 37, new DateTime(2024, 5, 28, 22, 58, 25, 434, DateTimeKind.Unspecified).AddTicks(6135), 79, 3303886.856385544560000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 91,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 44, new DateTime(2024, 5, 12, 15, 39, 22, 606, DateTimeKind.Unspecified).AddTicks(6460), 70, 5694749.676087950640000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 92,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 90, new DateTime(2024, 5, 22, 8, 22, 4, 108, DateTimeKind.Unspecified).AddTicks(8540), 5, 6239571.409089058240000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 93,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 55, new DateTime(2024, 5, 14, 0, 0, 16, 609, DateTimeKind.Unspecified).AddTicks(4568), 25, 7592232.471195442000000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 94,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 27, new DateTime(2024, 5, 17, 21, 47, 25, 908, DateTimeKind.Unspecified).AddTicks(3536), 34, 1699513.749172074560000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 95,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 18, new DateTime(2024, 5, 24, 9, 2, 34, 628, DateTimeKind.Unspecified).AddTicks(1959), 49, 7978093.631287765920000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 96,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 97, new DateTime(2024, 5, 16, 13, 47, 12, 680, DateTimeKind.Unspecified).AddTicks(3042), 65, 2982577.319857309080000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 97,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 42, new DateTime(2024, 5, 20, 13, 0, 23, 360, DateTimeKind.Unspecified).AddTicks(9544), 62, 4132946.631055932160000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 98,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 59, new DateTime(2024, 5, 28, 13, 1, 48, 500, DateTimeKind.Unspecified).AddTicks(44), 28, 3552145.742333263920000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 99,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 41, new DateTime(2024, 5, 15, 13, 3, 10, 614, DateTimeKind.Unspecified).AddTicks(3404), 71, 5046427.023332122320000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 100,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 12, new DateTime(2024, 5, 7, 5, 50, 8, 978, DateTimeKind.Unspecified).AddTicks(5091), 13, 4825655.593677151800000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 7, 14, 42, 57, 588, DateTimeKind.Local).AddTicks(9808), 34028.062875928040000m, 134, 101530.2202076216700000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 2,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 7, 14, 42, 57, 589, DateTimeKind.Local).AddTicks(2090), 33145.029583545040000m, 77, 178434.331864455700000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 3,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 7, 14, 42, 57, 589, DateTimeKind.Local).AddTicks(2116), 21237.758596598240000m, 117, 153335.762097780300000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 4,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 7, 14, 42, 57, 589, DateTimeKind.Local).AddTicks(2125), 15413.583081986560000m, 64, 126926.767367748900000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 5,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 7, 14, 42, 57, 589, DateTimeKind.Local).AddTicks(2134), 44587.683365797000000m, 128, 146848.487319050200000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 6,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 7, 14, 42, 57, 589, DateTimeKind.Local).AddTicks(2142), 21339.607738030880000m, 33, 167586.01146859200000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 7,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 7, 14, 42, 57, 589, DateTimeKind.Local).AddTicks(2150), 41194.104116624600000m, 93, 105274.4838051835400000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 8,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 7, 14, 42, 57, 589, DateTimeKind.Local).AddTicks(2158), 41963.844305120000m, 18, 156961.045933969500000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 9,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 7, 14, 42, 57, 589, DateTimeKind.Local).AddTicks(2166), 10182.69338589492960000m, 50, 128054.61159034900000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 10,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 7, 14, 42, 57, 589, DateTimeKind.Local).AddTicks(2174), 40993.231403360640000m, 79, 193679.590114825400000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 11,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 7, 14, 42, 57, 589, DateTimeKind.Local).AddTicks(2181), 30418.030834396040000m, 108, 131192.559757588900000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 12,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 7, 14, 42, 57, 589, DateTimeKind.Local).AddTicks(2189), 40839.37041559560000m, 41, 132902.149794841400000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 13,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 7, 14, 42, 57, 589, DateTimeKind.Local).AddTicks(2204), 11605.0449244226280000m, 113, 125803.354533515700000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 14,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 7, 14, 42, 57, 589, DateTimeKind.Local).AddTicks(2212), 19039.37423309720000m, 28, 127086.133570619200000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 15,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 7, 14, 42, 57, 589, DateTimeKind.Local).AddTicks(2220), 26453.347268653520000m, 145, 106634.6621572243400000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 16,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 7, 14, 42, 57, 589, DateTimeKind.Local).AddTicks(2228), 36461.846016154480000m, 113, 112339.745329991700000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 17,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 7, 14, 42, 57, 589, DateTimeKind.Local).AddTicks(2236), 33436.479393159040000m, 119, 177242.453296930800000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 18,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 7, 14, 42, 57, 589, DateTimeKind.Local).AddTicks(2244), 32035.217399955040000m, 109, 106374.3122903649600000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 19,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 7, 14, 42, 57, 589, DateTimeKind.Local).AddTicks(2251), 21628.875407851960000m, 74, 189186.504883651600000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 20,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 7, 14, 42, 57, 589, DateTimeKind.Local).AddTicks(2259), 39626.617575051000000m, 47, 145461.145442553200000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 21,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 7, 14, 42, 57, 589, DateTimeKind.Local).AddTicks(2266), 30173.550853617040000m, 104, 191607.010729156100000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 22,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 7, 14, 42, 57, 589, DateTimeKind.Local).AddTicks(2274), 41476.913490699800000m, 76, 171604.700180002900000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 23,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 7, 14, 42, 57, 589, DateTimeKind.Local).AddTicks(2281), 22881.245145849720000m, 108, 180120.118264376400000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 24,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 7, 14, 42, 57, 589, DateTimeKind.Local).AddTicks(2288), 17074.040112648560000m, 92, 137543.614430517400000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 25,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 7, 14, 42, 57, 589, DateTimeKind.Local).AddTicks(2296), 46261.17085645840000m, 49, 180844.195172663200000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 26,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 7, 14, 42, 57, 589, DateTimeKind.Local).AddTicks(2304), 42510.883448983880000m, 115, 172067.34350443600000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 27,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 7, 14, 42, 57, 589, DateTimeKind.Local).AddTicks(2311), 49765.14853248720000m, 24, 125422.177039773200000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 28,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 7, 14, 42, 57, 589, DateTimeKind.Local).AddTicks(2319), 49888.090914309040000m, 120, 133835.608977859700000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 29,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 7, 14, 42, 57, 589, DateTimeKind.Local).AddTicks(2326), 24026.539100013280000m, 95, 124517.566835540100000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 30,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 7, 14, 42, 57, 589, DateTimeKind.Local).AddTicks(2334), 31829.083083299120000m, 82, 109653.6061479406500000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 31,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 7, 14, 42, 57, 589, DateTimeKind.Local).AddTicks(2341), 48442.984907730040000m, 77, 109674.6891266913800000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 32,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 7, 14, 42, 57, 589, DateTimeKind.Local).AddTicks(2349), 10189.09604148217960000m, 53, 168356.714952406600000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 33,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 7, 14, 42, 57, 589, DateTimeKind.Local).AddTicks(2357), 22959.895673935880000m, 53, 161204.981473006300000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 34,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 7, 14, 42, 57, 589, DateTimeKind.Local).AddTicks(2364), 20994.047152700080000m, 83, 129373.044348408200000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 35,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 7, 14, 42, 57, 589, DateTimeKind.Local).AddTicks(2372), 13014.0131246967160000m, 81, 156489.564387812700000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 36,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 7, 14, 42, 57, 589, DateTimeKind.Local).AddTicks(2379), 20506.755573790520000m, 99, 199630.444290654900000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 37,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 7, 14, 42, 57, 589, DateTimeKind.Local).AddTicks(2386), 24213.918812506040000m, 113, 108607.3709767729400000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 38,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 7, 14, 42, 57, 589, DateTimeKind.Local).AddTicks(2394), 30503.359798382920000m, 95, 100851.02904837364200000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 39,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 7, 14, 42, 57, 589, DateTimeKind.Local).AddTicks(2401), 37298.675878515680000m, 108, 151088.91430548800000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 40,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 7, 14, 42, 57, 589, DateTimeKind.Local).AddTicks(2409), 46803.944814447360000m, 75, 103326.0204139212900000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 41,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 7, 14, 42, 57, 589, DateTimeKind.Local).AddTicks(2417), 46029.405033370880000m, 105, 123515.990638611400000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 42,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 7, 14, 42, 57, 589, DateTimeKind.Local).AddTicks(2429), 14941.354310407800000m, 69, 175268.487602307700000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 43,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 7, 14, 42, 57, 589, DateTimeKind.Local).AddTicks(2437), 12124.2001422535880000m, 52, 108623.4939096070500000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 44,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 7, 14, 42, 57, 589, DateTimeKind.Local).AddTicks(2444), 39549.820846229440000m, 87, 118358.972246723200000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 45,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 7, 14, 42, 57, 589, DateTimeKind.Local).AddTicks(2452), 14080.896412366600000m, 72, 191139.53377650100000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 46,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 7, 14, 42, 57, 589, DateTimeKind.Local).AddTicks(2459), 16710.003529144960000m, 81, 190186.010358972600000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 47,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 7, 14, 42, 57, 589, DateTimeKind.Local).AddTicks(2466), 36530.609966871760000m, 25, 101915.8073130948300000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 48,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 7, 14, 42, 57, 589, DateTimeKind.Local).AddTicks(2474), 13403.8026348768560000m, 56, 162639.670889862100000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 49,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 7, 14, 42, 57, 589, DateTimeKind.Local).AddTicks(2481), 19052.308985951280000m, 103, 128722.390414379800000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 50,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 7, 14, 42, 57, 589, DateTimeKind.Local).AddTicks(2489), 49998.477687834240000m, 68, 105434.780339239700000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 51,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 7, 14, 42, 57, 589, DateTimeKind.Local).AddTicks(2496), 20603.279142302440000m, 51, 120750.261902480100000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 52,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 7, 14, 42, 57, 589, DateTimeKind.Local).AddTicks(2504), 20150.269920008240000m, 131, 134169.803609987400000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 53,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 7, 14, 42, 57, 589, DateTimeKind.Local).AddTicks(2511), 47268.862066266560000m, 142, 163566.944923526100000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 54,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 7, 14, 42, 57, 589, DateTimeKind.Local).AddTicks(2519), 37680.564453561120000m, 62, 142017.55820841300000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 55,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 7, 14, 42, 57, 589, DateTimeKind.Local).AddTicks(2526), 32107.205814168640000m, 80, 117102.365037304800000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 56,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 7, 14, 42, 57, 589, DateTimeKind.Local).AddTicks(2533), 36456.971198760000m, 77, 128077.736838718900000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 57,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 7, 14, 42, 57, 589, DateTimeKind.Local).AddTicks(2541), 10744.5684094060360000m, 109, 106518.0268973451300000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 58,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 7, 14, 42, 57, 589, DateTimeKind.Local).AddTicks(2548), 33109.189688681840000m, 84, 151155.759813259900000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 59,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 7, 14, 42, 57, 589, DateTimeKind.Local).AddTicks(2556), 45619.637273992080000m, 49, 152984.383011448100000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 60,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 7, 14, 42, 57, 589, DateTimeKind.Local).AddTicks(2563), 42469.640320698880000m, 143, 114898.654369809700000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 61,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 7, 14, 42, 57, 589, DateTimeKind.Local).AddTicks(2570), 35547.86377189680000m, 44, 150271.213169557300000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 62,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 7, 14, 42, 57, 589, DateTimeKind.Local).AddTicks(2578), 36381.46193689320000m, 141, 114292.684186438200000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 63,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 7, 14, 42, 57, 589, DateTimeKind.Local).AddTicks(2585), 24820.277673715120000m, 96, 159126.515988763600000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 64,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 7, 14, 42, 57, 589, DateTimeKind.Local).AddTicks(2593), 24824.020273588040000m, 132, 163785.401177453200000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 65,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 7, 14, 42, 57, 589, DateTimeKind.Local).AddTicks(2601), 48359.996832682560000m, 131, 164967.766714218300000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 66,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 7, 14, 42, 57, 589, DateTimeKind.Local).AddTicks(2608), 39753.701001303040000m, 101, 106244.0051166572800000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 67,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 7, 14, 42, 57, 589, DateTimeKind.Local).AddTicks(2615), 19455.17306390160000m, 30, 113807.598562115200000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 68,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 7, 14, 42, 57, 589, DateTimeKind.Local).AddTicks(2623), 13116.6669598968880000m, 119, 118116.826982517700000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 69,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 7, 14, 42, 57, 589, DateTimeKind.Local).AddTicks(2630), 13203.472605373920000m, 46, 127803.482502701700000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 70,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 7, 14, 42, 57, 589, DateTimeKind.Local).AddTicks(2637), 44845.785415597400000m, 111, 148724.310845655800000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 71,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 7, 14, 42, 57, 589, DateTimeKind.Local).AddTicks(2652), 23231.417287362920000m, 66, 159207.654810810100000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 72,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 7, 14, 42, 57, 589, DateTimeKind.Local).AddTicks(2659), 21105.943248272880000m, 58, 109848.2011524816400000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 73,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 7, 14, 42, 57, 589, DateTimeKind.Local).AddTicks(2667), 17583.603482964280000m, 141, 135329.605264971700000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 74,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 7, 14, 42, 57, 589, DateTimeKind.Local).AddTicks(2674), 30400.541607262960000m, 107, 149747.230701352400000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 75,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 7, 14, 42, 57, 589, DateTimeKind.Local).AddTicks(2682), 22236.922555944480000m, 76, 106505.409416239300000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 76,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 7, 14, 42, 57, 589, DateTimeKind.Local).AddTicks(2689), 42902.340804733280000m, 68, 147885.638015838300000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 77,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 7, 14, 42, 57, 589, DateTimeKind.Local).AddTicks(2697), 40175.113570658640000m, 114, 106464.4190987157100000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 78,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 7, 14, 42, 57, 589, DateTimeKind.Local).AddTicks(2704), 34842.878247981960000m, 48, 192603.128928485400000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 79,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 7, 14, 42, 57, 589, DateTimeKind.Local).AddTicks(2712), 31210.157495721640000m, 81, 187112.613278347600000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 80,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 7, 14, 42, 57, 589, DateTimeKind.Local).AddTicks(2719), 49650.532033094720000m, 122, 112760.922152746500000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 81,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 7, 14, 42, 57, 589, DateTimeKind.Local).AddTicks(2727), 11899.3931423407160000m, 82, 119425.80690295200000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 82,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 7, 14, 42, 57, 589, DateTimeKind.Local).AddTicks(2734), 14701.424534761440000m, 136, 126708.556742085500000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 83,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 7, 14, 42, 57, 589, DateTimeKind.Local).AddTicks(2742), 43756.429959882320000m, 84, 194466.142382165700000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 84,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 7, 14, 42, 57, 589, DateTimeKind.Local).AddTicks(2749), 18984.48508412880000m, 61, 167814.257722900800000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 85,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 7, 14, 42, 57, 589, DateTimeKind.Local).AddTicks(2756), 49932.643548161040000m, 131, 151414.369643390700000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 86,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 7, 14, 42, 57, 589, DateTimeKind.Local).AddTicks(2764), 29856.102174616280000m, 13, 143984.321784746100000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 87,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 7, 14, 42, 57, 589, DateTimeKind.Local).AddTicks(2771), 12693.0154158413440000m, 128, 171071.565746522100000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 88,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 7, 14, 42, 57, 589, DateTimeKind.Local).AddTicks(2779), 42637.350704075520000m, 66, 111495.784991426400000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 89,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 7, 14, 42, 57, 589, DateTimeKind.Local).AddTicks(2786), 32774.932028450560000m, 77, 188042.523082459700000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 90,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 7, 14, 42, 57, 589, DateTimeKind.Local).AddTicks(2794), 20394.363311021880000m, 96, 173977.213766913900000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 91,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 7, 14, 42, 57, 589, DateTimeKind.Local).AddTicks(2801), 36042.719468911080000m, 103, 119966.384243097600000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 92,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 7, 14, 42, 57, 589, DateTimeKind.Local).AddTicks(2809), 41876.318181805760000m, 95, 117955.627816001200000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 93,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 7, 14, 42, 57, 589, DateTimeKind.Local).AddTicks(2816), 43384.185549688240000m, 100, 116693.899687705400000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 94,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 7, 14, 42, 57, 589, DateTimeKind.Local).AddTicks(2823), 16500.133487107520000m, 19, 107398.1134521937600000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 95,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 7, 14, 42, 57, 589, DateTimeKind.Local).AddTicks(2858), 40293.402178221040000m, 117, 193988.858758638400000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 96,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 7, 14, 42, 57, 589, DateTimeKind.Local).AddTicks(2867), 21153.030637285880000m, 72, 137398.660872740600000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 97,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 7, 14, 42, 57, 589, DateTimeKind.Local).AddTicks(2875), 30389.313463646560000m, 70, 172484.658039158400000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 98,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 7, 14, 42, 57, 589, DateTimeKind.Local).AddTicks(2883), 26508.550315919880000m, 50, 190700.115583862200000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 99,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 7, 14, 42, 57, 589, DateTimeKind.Local).AddTicks(2891), 26147.290276332240000m, 106, 143578.393702635600000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 100,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 7, 14, 42, 57, 589, DateTimeKind.Local).AddTicks(2901), 45958.624701687160000m, 28, 168474.131522572900000m });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 1,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Bạc Liêu", new DateTime(2024, 4, 7, 14, 42, 57, 577, DateTimeKind.Local).AddTicks(2362), "ThuyQuynh_Le@yahoo.com", "0977160141", "Thủy Quỳnh Vũ" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 2,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "TP. Hồ Chí Minh", new DateTime(2024, 4, 7, 14, 42, 57, 577, DateTimeKind.Local).AddTicks(4335), "ThanhLong.Truong@yahoo.com", "0975965654", "Xuân Dung Đặng" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 3,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Đắk Nông", new DateTime(2024, 4, 7, 14, 42, 57, 577, DateTimeKind.Local).AddTicks(4447), "QuocQuang.Tang79@hotmail.com", "0955389850", "Minh Quân Vũ" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 4,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Bến Tre", new DateTime(2024, 4, 7, 14, 42, 57, 577, DateTimeKind.Local).AddTicks(4544), "MinhChau18@yahoo.com", "0945280423", "Song Lam Lý" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 5,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Bình Dương", new DateTime(2024, 4, 7, 14, 42, 57, 577, DateTimeKind.Local).AddTicks(4623), "KhanhDuy87@yahoo.com", "0965283896", "Hoa Thiên Vương" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 6,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Quảng Nam", new DateTime(2024, 4, 7, 14, 42, 57, 577, DateTimeKind.Local).AddTicks(4703), "BaoNgoc_Phan30@gmail.com", "0996254054", "Diệu Linh Trần" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 7,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Hà Nội", new DateTime(2024, 4, 7, 14, 42, 57, 577, DateTimeKind.Local).AddTicks(4783), "DongNhi_Hoang61@hotmail.com", "0903374275", "Ngọc Tú Đào" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 8,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Nghệ An", new DateTime(2024, 4, 7, 14, 42, 57, 577, DateTimeKind.Local).AddTicks(4865), "DinhDieu.Phung34@hotmail.com", "0957573971", "Bình Yên Tăng" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 9,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Bắc Giang", new DateTime(2024, 4, 7, 14, 42, 57, 577, DateTimeKind.Local).AddTicks(4944), "DiemLien28@hotmail.com", "0902788453", "Như Mai Hà" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 10,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Đồng Tháp", new DateTime(2024, 4, 7, 14, 42, 57, 577, DateTimeKind.Local).AddTicks(5020), "PhuTho33@gmail.com", "0939243884", "Ðắc Lực Lâm" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 11,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Bắc Ninh", new DateTime(2024, 4, 7, 14, 42, 57, 577, DateTimeKind.Local).AddTicks(5093), "HoaiHuong.Le22@hotmail.com", "0991129074", "Phụng Yến Phan" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 12,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Lào Cai", new DateTime(2024, 4, 7, 14, 42, 57, 577, DateTimeKind.Local).AddTicks(5163), "QuangVinh25@hotmail.com", "0937293185", "Mậu Xuân Đỗ" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 13,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Bạc Liêu", new DateTime(2024, 4, 7, 14, 42, 57, 577, DateTimeKind.Local).AddTicks(5273), "HoaiTrang.Mai@hotmail.com", "0924968555", "Khắc Việt Dương" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 14,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Khánh Hoà", new DateTime(2024, 4, 7, 14, 42, 57, 577, DateTimeKind.Local).AddTicks(5345), "NgocTho81@yahoo.com", "0910943342", "Bá Phước Nguyễn" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 15,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Lào Cai", new DateTime(2024, 4, 7, 14, 42, 57, 577, DateTimeKind.Local).AddTicks(5415), "ThienDuyen.Ngo@gmail.com", "0938657560", "Cẩm Vân Lý" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 16,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Bình Định", new DateTime(2024, 4, 7, 14, 42, 57, 577, DateTimeKind.Local).AddTicks(5488), "NgocNhi.Doan@hotmail.com", "0931890650", "Thanh Nguyên Hà" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 17,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Ninh Bình", new DateTime(2024, 4, 7, 14, 42, 57, 577, DateTimeKind.Local).AddTicks(5554), "CongTuan_Duong73@yahoo.com", "0994241888", "An Khang Vương" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 18,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "TP. Hồ Chí Minh", new DateTime(2024, 4, 7, 14, 42, 57, 577, DateTimeKind.Local).AddTicks(5629), "ThanhTruc_Dao21@gmail.com", "0929637443", "Trường Liên Đỗ" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 19,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Bắc Kạn", new DateTime(2024, 4, 7, 14, 42, 57, 577, DateTimeKind.Local).AddTicks(5701), "DongTra_Ha29@gmail.com", "0952480698", "Minh Thủy Phạm" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 20,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Gia Lai", new DateTime(2024, 4, 7, 14, 42, 57, 577, DateTimeKind.Local).AddTicks(5794), "DuyNhuong.Truong14@gmail.com", "0993860697", "Nhật Hà Hà" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 21,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Quảng Ninh", new DateTime(2024, 4, 7, 14, 42, 57, 577, DateTimeKind.Local).AddTicks(5872), "ThaoMai_Truong12@yahoo.com", "0946366320", "Ðức Tâm Đỗ" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 22,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Bắc Kạn", new DateTime(2024, 4, 7, 14, 42, 57, 577, DateTimeKind.Local).AddTicks(5948), "NhaTruc77@gmail.com", "0929239337", "Uyên Phương Lâm" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 23,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Đà Nẵng", new DateTime(2024, 4, 7, 14, 42, 57, 577, DateTimeKind.Local).AddTicks(6018), "MinhTuyet_Vuong77@hotmail.com", "0935693486", "Bảo Lan Đào" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 24,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Hải Dương", new DateTime(2024, 4, 7, 14, 42, 57, 577, DateTimeKind.Local).AddTicks(6093), "DucTri52@gmail.com", "0956013130", "Cao Minh Phạm" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 25,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Trà Vinh", new DateTime(2024, 4, 7, 14, 42, 57, 577, DateTimeKind.Local).AddTicks(6165), "TuanChau.Vuong@yahoo.com", "0948102492", "Phượng Loan Ngô" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 26,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Quảng Bình", new DateTime(2024, 4, 7, 14, 42, 57, 577, DateTimeKind.Local).AddTicks(6235), "LinhGiang18@gmail.com", "0941052519", "Hiệp Hà Đào" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 27,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Quảng Ngãi", new DateTime(2024, 4, 7, 14, 42, 57, 577, DateTimeKind.Local).AddTicks(6312), "DinhChuong85@yahoo.com", "0944617353", "Hoài Trung Tô" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 28,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Thái Bình", new DateTime(2024, 4, 7, 14, 42, 57, 577, DateTimeKind.Local).AddTicks(6379), "HaiPhuong85@hotmail.com", "0928144547", "Ngọc Trụ Trần" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 29,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Ninh Thuận", new DateTime(2024, 4, 7, 14, 42, 57, 577, DateTimeKind.Local).AddTicks(6453), "MinhThien94@yahoo.com", "0973239628", "Hoàng Hiệp Đào" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 30,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Nam Định", new DateTime(2024, 4, 7, 14, 42, 57, 577, DateTimeKind.Local).AddTicks(6523), "QuangTai.Bui36@yahoo.com", "0936010652", "Thanh Vân Hà" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 31,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Long An", new DateTime(2024, 4, 7, 14, 42, 57, 577, DateTimeKind.Local).AddTicks(6601), "DucThanh8@hotmail.com", "0999922334", "Kiều Loan Đoàn" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 32,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Hà Nội", new DateTime(2024, 4, 7, 14, 42, 57, 577, DateTimeKind.Local).AddTicks(6674), "BaCuong.Ha@yahoo.com", "0995246495", "Quốc Tiến Hoàng" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 33,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Cà Mau", new DateTime(2024, 4, 7, 14, 42, 57, 577, DateTimeKind.Local).AddTicks(6739), "PhuongQuynh_Bui@hotmail.com", "0964851479", "Gia Huấn Nguyễn" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 34,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Hà Nam", new DateTime(2024, 4, 7, 14, 42, 57, 577, DateTimeKind.Local).AddTicks(6812), "CongThanh_Duong@gmail.com", "0997847192", "Minh Trang Lê" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 35,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Khánh Hoà", new DateTime(2024, 4, 7, 14, 42, 57, 577, DateTimeKind.Local).AddTicks(6880), "HaiSon_Vu19@hotmail.com", "0923953348", "Nam Ninh Phùng" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 36,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Điện Biên", new DateTime(2024, 4, 7, 14, 42, 57, 577, DateTimeKind.Local).AddTicks(6958), "SongOanh.Ngo93@gmail.com", "0975691362", "Trường Long Đỗ" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 37,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Bình Phước", new DateTime(2024, 4, 7, 14, 42, 57, 577, DateTimeKind.Local).AddTicks(7024), "UyenNghi.Truong@gmail.com", "0973710124", "Phương Loan Đào" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 38,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Cao Bằng", new DateTime(2024, 4, 7, 14, 42, 57, 577, DateTimeKind.Local).AddTicks(7099), "MinhKiet.Vuong@yahoo.com", "0946657335", "Duy Hải Đinh" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 39,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Hà Giang", new DateTime(2024, 4, 7, 14, 42, 57, 577, DateTimeKind.Local).AddTicks(7166), "AnhTho.Nguyen84@hotmail.com", "0919773709", "Ðình Ngân Vũ" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 40,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "An Giang", new DateTime(2024, 4, 7, 14, 42, 57, 577, DateTimeKind.Local).AddTicks(7247), "KienBinh.Ha@yahoo.com", "0987454602", "Công Luật Phùng" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 41,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Thanh Hoá", new DateTime(2024, 4, 7, 14, 42, 57, 577, DateTimeKind.Local).AddTicks(7328), "GiaKhiem.Hoang39@gmail.com", "0988936737", "Hoài Giang Đoàn" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 42,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Quảng Bình", new DateTime(2024, 4, 7, 14, 42, 57, 577, DateTimeKind.Local).AddTicks(7397), "TrungThuc.Vu@yahoo.com", "0902085600", "Ngọc Ánh Nguyễn" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 43,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Lai Châu", new DateTime(2024, 4, 7, 14, 42, 57, 577, DateTimeKind.Local).AddTicks(7469), "BachHoa.Tang@gmail.com", "0933079291", "Tuyết Trinh Hoàng" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 44,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Bến Tre", new DateTime(2024, 4, 7, 14, 42, 57, 577, DateTimeKind.Local).AddTicks(7539), "BinhMinh45@yahoo.com", "0918207269", "Ngọc Lâm Mai" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 45,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Thanh Hoá", new DateTime(2024, 4, 7, 14, 42, 57, 577, DateTimeKind.Local).AddTicks(7606), "TrucLam_Phan92@yahoo.com", "0966193525", "Trung Nhân Đoàn" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 46,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Quảng Ngãi", new DateTime(2024, 4, 7, 14, 42, 57, 577, DateTimeKind.Local).AddTicks(7673), "QuangDuc.Tang@hotmail.com", "0983413854", "Nguyệt Hồng Lê" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 47,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Hà Tĩnh", new DateTime(2024, 4, 7, 14, 42, 57, 577, DateTimeKind.Local).AddTicks(7746), "DieuThuy.Truong@hotmail.com", "0981664078", "Vân Quyên Nguyễn" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 48,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Thanh Hoá", new DateTime(2024, 4, 7, 14, 42, 57, 577, DateTimeKind.Local).AddTicks(7814), "HungSon.Ngo@yahoo.com", "0990528081", "Liên Hoa Tô" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 49,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Lâm Đồng", new DateTime(2024, 4, 7, 14, 42, 57, 577, DateTimeKind.Local).AddTicks(7882), "TienHiep.Doan53@yahoo.com", "0950321395", "Nhật Quốc Mai" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 50,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Vĩnh Long", new DateTime(2024, 4, 7, 14, 42, 57, 577, DateTimeKind.Local).AddTicks(7949), "UyenTram65@gmail.com", "0985251403", "Thanh Thu Nguyễn" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 51,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Bắc Giang", new DateTime(2024, 4, 7, 14, 42, 57, 577, DateTimeKind.Local).AddTicks(8023), "DacTrong_Tang38@yahoo.com", "0970599166", "Bảo Giang Đặng" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 52,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Bình Phước", new DateTime(2024, 4, 7, 14, 42, 57, 577, DateTimeKind.Local).AddTicks(8093), "HoaMi.Vuong37@hotmail.com", "0962255778", "Anh Tùng Trương" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 53,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Bến Tre", new DateTime(2024, 4, 7, 14, 42, 57, 577, DateTimeKind.Local).AddTicks(8177), "KimNgan_Nguyen48@hotmail.com", "0942803591", "Tâm Hằng Đặng" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 54,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Khánh Hoà", new DateTime(2024, 4, 7, 14, 42, 57, 577, DateTimeKind.Local).AddTicks(8254), "DieuLan.Ly41@yahoo.com", "0960496788", "Hương Tiên Đỗ" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 55,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Kiên Giang", new DateTime(2024, 4, 7, 14, 42, 57, 577, DateTimeKind.Local).AddTicks(8319), "AuLang.Truong@hotmail.com", "0931044544", "Nhật Hùng Hà" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 56,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Hà Giang", new DateTime(2024, 4, 7, 14, 42, 57, 577, DateTimeKind.Local).AddTicks(8394), "TuongAnh80@hotmail.com", "0926608699", "Ngân Thanh Lý" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 57,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Đà Nẵng", new DateTime(2024, 4, 7, 14, 42, 57, 577, DateTimeKind.Local).AddTicks(8623), "HaiSon.Trinh@hotmail.com", "0932985491", "Vân Nhi Nguyễn" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 58,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Hải Phòng", new DateTime(2024, 4, 7, 14, 42, 57, 577, DateTimeKind.Local).AddTicks(8703), "VietHung_Phung@hotmail.com", "0947700780", "Bảo Tín Đỗ" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 59,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Tiền Giang", new DateTime(2024, 4, 7, 14, 42, 57, 577, DateTimeKind.Local).AddTicks(8845), "ThuNga29@yahoo.com", "0971327323", "Sơn Quyền Bùi" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 60,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Lâm Đồng", new DateTime(2024, 4, 7, 14, 42, 57, 577, DateTimeKind.Local).AddTicks(8914), "KhaAi_To47@hotmail.com", "0917500935", "Thảo My Vũ" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 61,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "An Giang", new DateTime(2024, 4, 7, 14, 42, 57, 577, DateTimeKind.Local).AddTicks(8976), "DongNhi23@yahoo.com", "0985611501", "Xuân Nương Tô" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 62,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Bắc Giang", new DateTime(2024, 4, 7, 14, 42, 57, 577, DateTimeKind.Local).AddTicks(9046), "GiangLam71@yahoo.com", "0917107822", "Quỳnh Phương Trần" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 63,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Lạng Sơn", new DateTime(2024, 4, 7, 14, 42, 57, 577, DateTimeKind.Local).AddTicks(9136), "HienChung_Do@gmail.com", "0973026149", "Chiến Thắng Phạm" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 64,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Cao Bằng", new DateTime(2024, 4, 7, 14, 42, 57, 577, DateTimeKind.Local).AddTicks(9202), "MyUyen.Hoang@yahoo.com", "0912401106", "Diệp Anh Dương" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 65,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Hưng Yên", new DateTime(2024, 4, 7, 14, 42, 57, 577, DateTimeKind.Local).AddTicks(9280), "KhacNinh_Tang34@gmail.com", "0965880135", "Chế Phương Ngô" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 66,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Nam Định", new DateTime(2024, 4, 7, 14, 42, 57, 577, DateTimeKind.Local).AddTicks(9346), "DucThang74@yahoo.com", "0975397607", "Bá Trúc Hoàng" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 67,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Kiên Giang", new DateTime(2024, 4, 7, 14, 42, 57, 577, DateTimeKind.Local).AddTicks(9429), "TrieuThanh97@gmail.com", "0996395004", "Bảo Hoa Phùng" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 68,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Cao Bằng", new DateTime(2024, 4, 7, 14, 42, 57, 577, DateTimeKind.Local).AddTicks(9644), "TamNguyen.Doan@hotmail.com", "0984640687", "Tâm Khanh Phạm" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 69,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Bắc Kạn", new DateTime(2024, 4, 7, 14, 42, 57, 577, DateTimeKind.Local).AddTicks(9722), "NguyenHaiAn_Ha48@hotmail.com", "0908591864", "Trí Tịnh Vương" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 70,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Thừa Thiên-Huế", new DateTime(2024, 4, 7, 14, 42, 57, 577, DateTimeKind.Local).AddTicks(9799), "PhiNhan.Doan@gmail.com", "0973935655", "Quỳnh Giao Ngô" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 71,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Thái Bình", new DateTime(2024, 4, 7, 14, 42, 57, 577, DateTimeKind.Local).AddTicks(9878), "CongLuat.Do@gmail.com", "0982454084", "Quang Thuận Ngô" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 72,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Cao Bằng", new DateTime(2024, 4, 7, 14, 42, 57, 577, DateTimeKind.Local).AddTicks(9956), "PhuongQue_Phung@hotmail.com", "0904881264", "Quốc Khánh Đặng" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 73,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Lào Cai", new DateTime(2024, 4, 7, 14, 42, 57, 578, DateTimeKind.Local).AddTicks(31), "PhuongUyen_Do94@yahoo.com", "0975972523", "Xuân Hạnh Vũ" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 74,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Tiền Giang", new DateTime(2024, 4, 7, 14, 42, 57, 578, DateTimeKind.Local).AddTicks(107), "PhiPhuong72@hotmail.com", "0903025086", "An Di Phùng" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 75,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Kiên Giang", new DateTime(2024, 4, 7, 14, 42, 57, 578, DateTimeKind.Local).AddTicks(242), "MyNuong_Dao@yahoo.com", "0985370933", "Trường Nhân Đoàn" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 76,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Bình Dương", new DateTime(2024, 4, 7, 14, 42, 57, 578, DateTimeKind.Local).AddTicks(314), "DuyHien_Ly@yahoo.com", "0918013814", "Lan Hương Phan" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 77,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "TP. Hồ Chí Minh", new DateTime(2024, 4, 7, 14, 42, 57, 578, DateTimeKind.Local).AddTicks(376), "HuuChien52@yahoo.com", "0963168376", "Thiên Hà Tăng" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 78,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Tây Ninh", new DateTime(2024, 4, 7, 14, 42, 57, 578, DateTimeKind.Local).AddTicks(446), "NgocSon_Duong8@gmail.com", "0936776363", "Thụy Linh Bùi" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 79,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Bạc Liêu", new DateTime(2024, 4, 7, 14, 42, 57, 578, DateTimeKind.Local).AddTicks(674), "QuynhDung77@hotmail.com", "0918883859", "Nguyệt Ánh Phạm" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 80,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Bình Định", new DateTime(2024, 4, 7, 14, 42, 57, 578, DateTimeKind.Local).AddTicks(751), "NgocBich21@yahoo.com", "0926710632", "Gia Linh Phan" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 81,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Lâm Đồng", new DateTime(2024, 4, 7, 14, 42, 57, 578, DateTimeKind.Local).AddTicks(905), "ManhTruong.Nguyen@yahoo.com", "0931729061", "Thủy Trang Lý" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 82,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Hà Giang", new DateTime(2024, 4, 7, 14, 42, 57, 578, DateTimeKind.Local).AddTicks(981), "HoangYen34@hotmail.com", "0997916267", "Thiện Thanh Đặng" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 83,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Hà Tĩnh", new DateTime(2024, 4, 7, 14, 42, 57, 578, DateTimeKind.Local).AddTicks(1053), "QuocHien86@yahoo.com", "0977561990", "An Hằng Hà" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 84,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Bến Tre", new DateTime(2024, 4, 7, 14, 42, 57, 578, DateTimeKind.Local).AddTicks(1118), "ThanhDan_Tang@yahoo.com", "0993417976", "Quỳnh Thơ Lê" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 85,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Tây Ninh", new DateTime(2024, 4, 7, 14, 42, 57, 578, DateTimeKind.Local).AddTicks(1192), "NgocBich_Le@gmail.com", "0917303842", "Khôi Vĩ Dương" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 86,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Lào Cai", new DateTime(2024, 4, 7, 14, 42, 57, 578, DateTimeKind.Local).AddTicks(1275), "MinhThao.Mai8@gmail.com", "0975518263", "Bá Tùng Trịnh" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 87,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Điện Biên", new DateTime(2024, 4, 7, 14, 42, 57, 578, DateTimeKind.Local).AddTicks(1348), "MyLoi_Duong@gmail.com", "0906912596", "Duy Uyên Vũ" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 88,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Thái Bình", new DateTime(2024, 4, 7, 14, 42, 57, 578, DateTimeKind.Local).AddTicks(1411), "MinhKhang_Vu7@yahoo.com", "0928539309", "Hướng Dương Bùi" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 89,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Lâm Đồng", new DateTime(2024, 4, 7, 14, 42, 57, 578, DateTimeKind.Local).AddTicks(1485), "TrieuThanh.Pham52@hotmail.com", "0963784466", "Thúy Hiền Vương" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 90,
                columns: new[] { "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { new DateTime(2024, 4, 7, 14, 42, 57, 578, DateTimeKind.Local).AddTicks(1561), "HoaHop.Phan85@hotmail.com", "0905817162", "Phương Uyên Vương" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 91,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Thừa Thiên-Huế", new DateTime(2024, 4, 7, 14, 42, 57, 578, DateTimeKind.Local).AddTicks(1625), "VietNgoc.Do@gmail.com", "0972902436", "Hiếu Phong Tô" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 92,
                columns: new[] { "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { new DateTime(2024, 4, 7, 14, 42, 57, 578, DateTimeKind.Local).AddTicks(1701), "MyKhuyen_Truong25@hotmail.com", "0939517828", "Phương Triều Đào" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 93,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Bình Dương", new DateTime(2024, 4, 7, 14, 42, 57, 578, DateTimeKind.Local).AddTicks(1773), "DacThai.Tran@hotmail.com", "0943490293", "Cẩm Nhi Phan" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 94,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Hải Phòng", new DateTime(2024, 4, 7, 14, 42, 57, 578, DateTimeKind.Local).AddTicks(1845), "KimHoa_Tang61@gmail.com", "0948800612", "Trí Dũng Đoàn" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 95,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Sóc Trăng", new DateTime(2024, 4, 7, 14, 42, 57, 578, DateTimeKind.Local).AddTicks(1910), "BichHue43@gmail.com", "0901419940", "Trọng Chính Mai" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 96,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Kon Tum", new DateTime(2024, 4, 7, 14, 42, 57, 578, DateTimeKind.Local).AddTicks(1982), "ThanhDoanh_Truong86@gmail.com", "0954676890", "Tấn Thành Hà" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 97,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Bà Rịa-Vũng Tàu", new DateTime(2024, 4, 7, 14, 42, 57, 578, DateTimeKind.Local).AddTicks(2061), "DiepVy_Pham@hotmail.com", "0906707528", "Trọng Khánh Dương" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 98,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Vĩnh Long", new DateTime(2024, 4, 7, 14, 42, 57, 578, DateTimeKind.Local).AddTicks(2125), "HoangGiang_Lam15@hotmail.com", "0955759932", "Lam Giang Hoàng" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 99,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Bình Dương", new DateTime(2024, 4, 7, 14, 42, 57, 578, DateTimeKind.Local).AddTicks(2206), "HoaiViet76@yahoo.com", "0938723295", "Hùng Sơn Mai" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 100,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Bình Phước", new DateTime(2024, 4, 7, 14, 42, 57, 578, DateTimeKind.Local).AddTicks(2268), "DuyUyen_Ngo47@yahoo.com", "0920973478", "Kim Dung Đào" });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 1,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 70, 5, new DateTime(2024, 5, 17, 5, 29, 41, 18, DateTimeKind.Unspecified).AddTicks(7783), 5482631.8912115701800000m, 5482631.8912115701800000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 2,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 63, 37, new DateTime(2024, 5, 23, 17, 23, 21, 500, DateTimeKind.Unspecified).AddTicks(3037), 11598231.571189620500000m, 11598231.571189620500000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 3,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 1, 58, new DateTime(2024, 5, 8, 14, 14, 49, 263, DateTimeKind.Unspecified).AddTicks(5522), 9200145.725866818000000m, 9200145.725866818000000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 4,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 39, 85, new DateTime(2024, 5, 5, 16, 9, 32, 354, DateTimeKind.Unspecified).AddTicks(3122), 10281068.156787660900000m, 10281068.156787660900000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 5,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 72, 22, new DateTime(2024, 5, 13, 17, 57, 23, 407, DateTimeKind.Unspecified).AddTicks(3238), 8223515.289866811200000m, 8223515.289866811200000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 6,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 38, 16, new DateTime(2024, 5, 4, 20, 28, 29, 560, DateTimeKind.Unspecified).AddTicks(1957), 14579982.99776750400000m, 14579982.99776750400000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 7,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 80, 9, new DateTime(2024, 5, 17, 15, 4, 16, 388, DateTimeKind.Unspecified).AddTicks(9936), 8843056.6396354173600000m, 8843056.6396354173600000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 8,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 37, 13, new DateTime(2024, 5, 22, 6, 43, 8, 171, DateTimeKind.Unspecified).AddTicks(4988), 13341688.904387407500000m, 13341688.904387407500000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 9,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 10, 73, new DateTime(2024, 5, 9, 5, 17, 2, 145, DateTimeKind.Unspecified).AddTicks(692), 9347986.64609547700000m, 9347986.64609547700000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 10,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 81, 95, new DateTime(2024, 5, 23, 17, 35, 18, 775, DateTimeKind.Unspecified).AddTicks(8750), 13170212.127808127200000m, 13170212.127808127200000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 11,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 52, 77, new DateTime(2024, 5, 16, 2, 0, 36, 647, DateTimeKind.Unspecified).AddTicks(50), 10101827.101334345300000m, 10101827.101334345300000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 12,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 1, 100, new DateTime(2024, 5, 19, 5, 15, 17, 87, DateTimeKind.Unspecified).AddTicks(5921), 7974128.987690484000000m, 7974128.987690484000000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 13,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 43, 100, new DateTime(2024, 5, 4, 21, 57, 37, 992, DateTimeKind.Unspecified).AddTicks(4561), 10693285.135348834500000m, 10693285.135348834500000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 14,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 12, 83, new DateTime(2024, 5, 14, 8, 42, 42, 66, DateTimeKind.Unspecified).AddTicks(5159), 10548149.086361393600000m, 10548149.086361393600000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 15,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 39, 13, new DateTime(2024, 5, 17, 16, 4, 33, 82, DateTimeKind.Unspecified).AddTicks(2443), 5438367.7700184413400000m, 5438367.7700184413400000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 16,
                columns: new[] { "CustomerID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 47, new DateTime(2024, 5, 26, 5, 44, 40, 799, DateTimeKind.Unspecified).AddTicks(8790), 9099519.371729327700000m, 9099519.371729327700000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 17,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 90, 27, new DateTime(2024, 5, 17, 18, 6, 57, 547, DateTimeKind.Unspecified).AddTicks(817), 11520759.464300502000000m, 11520759.464300502000000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 18,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 91, 9, new DateTime(2024, 5, 19, 18, 39, 49, 694, DateTimeKind.Unspecified).AddTicks(2803), 8403570.6709388318400000m, 8403570.6709388318400000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 19,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 11, 53, new DateTime(2024, 5, 29, 12, 54, 26, 907, DateTimeKind.Unspecified).AddTicks(7870), 15513293.400459431200000m, 15513293.400459431200000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 20,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 63, 92, new DateTime(2024, 5, 14, 12, 27, 39, 122, DateTimeKind.Unspecified).AddTicks(6377), 12364197.362617022000000m, 12364197.362617022000000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 21,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 44, 32, new DateTime(2024, 5, 4, 15, 20, 57, 43, DateTimeKind.Unspecified).AddTicks(3682), 16478202.922707424600000m, 16478202.922707424600000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 22,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 99, 63, new DateTime(2024, 5, 27, 6, 17, 24, 318, DateTimeKind.Unspecified).AddTicks(5090), 9609863.210080162400000m, 9609863.210080162400000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 23,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 5, 31, new DateTime(2024, 5, 26, 22, 32, 0, 100, DateTimeKind.Unspecified).AddTicks(8241), 14769849.697678864800000m, 14769849.697678864800000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 24,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 58, 60, new DateTime(2024, 5, 22, 10, 13, 40, 519, DateTimeKind.Unspecified).AddTicks(9120), 7839986.022539491800000m, 7839986.022539491800000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 25,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 22, 5, new DateTime(2024, 5, 25, 15, 25, 41, 262, DateTimeKind.Unspecified).AddTicks(5711), 9765586.539323812800000m, 9765586.539323812800000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 26,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 27, 16, new DateTime(2024, 5, 23, 20, 36, 51, 71, DateTimeKind.Unspecified).AddTicks(5269), 11700579.35830164800000m, 11700579.35830164800000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 27,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 64, 49, new DateTime(2024, 5, 28, 18, 47, 15, 148, DateTimeKind.Unspecified).AddTicks(4612), 11287995.933579588000000m, 11287995.933579588000000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 28,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 50, 64, new DateTime(2024, 5, 23, 8, 10, 45, 162, DateTimeKind.Unspecified).AddTicks(5104), 10706848.718228776000000m, 10706848.718228776000000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 29,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 78, 57, new DateTime(2024, 5, 24, 10, 9, 41, 52, DateTimeKind.Unspecified).AddTicks(8837), 11206581.015198609000000m, 11206581.015198609000000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 30,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 31, 35, new DateTime(2024, 5, 6, 17, 38, 49, 251, DateTimeKind.Unspecified).AddTicks(6124), 6469562.7627284983500000m, 6469562.7627284983500000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 31,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 57, 14, new DateTime(2024, 5, 26, 8, 47, 8, 767, DateTimeKind.Unspecified).AddTicks(6559), 7677228.2388683966000000m, 7677228.2388683966000000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 32,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 77, 65, new DateTime(2024, 5, 11, 12, 20, 45, 572, DateTimeKind.Unspecified).AddTicks(1256), 8586192.462572736600000m, 8586192.462572736600000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 33,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 87, 93, new DateTime(2024, 5, 29, 23, 15, 17, 773, DateTimeKind.Unspecified).AddTicks(2776), 9027478.962488352800000m, 9027478.962488352800000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 34,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 17, 15, new DateTime(2024, 5, 13, 5, 29, 8, 424, DateTimeKind.Unspecified).AddTicks(3515), 6468652.217420410000000m, 6468652.217420410000000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 35,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 73, 7, new DateTime(2024, 5, 25, 10, 42, 6, 159, DateTimeKind.Unspecified).AddTicks(1103), 10484800.813983450900000m, 10484800.813983450900000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 36,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 18, 88, new DateTime(2024, 5, 17, 8, 47, 8, 581, DateTimeKind.Unspecified).AddTicks(465), 16569326.876124356700000m, 16569326.876124356700000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 37,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 58, 46, new DateTime(2024, 5, 7, 3, 17, 8, 702, DateTimeKind.Unspecified).AddTicks(1249), 5538975.9198154199400000m, 5538975.9198154199400000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 38,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 36, 10, new DateTime(2024, 5, 23, 3, 49, 56, 764, DateTimeKind.Unspecified).AddTicks(1304), 8471486.44006338592800000m, 8471486.44006338592800000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 39,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 10, 77, new DateTime(2024, 5, 9, 2, 59, 30, 12, DateTimeKind.Unspecified).AddTicks(331), 10274046.17277318400000m, 10274046.17277318400000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 40,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 98, 69, new DateTime(2024, 5, 29, 14, 15, 57, 259, DateTimeKind.Unspecified).AddTicks(7944), 9092689.7964250735200000m, 9092689.7964250735200000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 41,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 55, 9, new DateTime(2024, 5, 10, 4, 37, 21, 675, DateTimeKind.Unspecified).AddTicks(8792), 9263699.297895855000000m, 9263699.297895855000000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 42,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 50, 43, new DateTime(2024, 5, 20, 16, 5, 38, 964, DateTimeKind.Unspecified).AddTicks(4112), 13145136.570173077500000m, 13145136.570173077500000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 43,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 80, 15, new DateTime(2024, 5, 7, 21, 59, 12, 284, DateTimeKind.Unspecified).AddTicks(7743), 5648421.6832995666000000m, 5648421.6832995666000000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 44,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 6, 56, new DateTime(2024, 5, 20, 20, 29, 36, 700, DateTimeKind.Unspecified).AddTicks(3606), 10297230.585464918400000m, 10297230.585464918400000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 45,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 29, 62, new DateTime(2024, 5, 6, 0, 18, 11, 850, DateTimeKind.Unspecified).AddTicks(8641), 16629139.43855558700000m, 16629139.43855558700000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 46,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 32, 46, new DateTime(2024, 5, 2, 9, 23, 55, 948, DateTimeKind.Unspecified).AddTicks(2818), 15405066.839076780600000m, 15405066.839076780600000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 47,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 91, 57, new DateTime(2024, 5, 7, 10, 25, 54, 283, DateTimeKind.Unspecified).AddTicks(3353), 8459012.0069868708900000m, 8459012.0069868708900000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 48,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 7, 29, new DateTime(2024, 5, 21, 9, 54, 16, 826, DateTimeKind.Unspecified).AddTicks(2156), 14312291.038307864800000m, 14312291.038307864800000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 49,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 73, 24, new DateTime(2024, 5, 20, 19, 7, 50, 85, DateTimeKind.Unspecified).AddTicks(335), 8109510.596105927400000m, 8109510.596105927400000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 50,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 74, 46, new DateTime(2024, 5, 27, 1, 20, 42, 976, DateTimeKind.Unspecified).AddTicks(4279), 6115217.259675902600000m, 6115217.259675902600000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 51,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 75, 42, new DateTime(2024, 5, 27, 11, 50, 37, 606, DateTimeKind.Unspecified).AddTicks(1956), 7486516.237953766200000m, 7486516.237953766200000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 52,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 11, 18, new DateTime(2024, 5, 9, 9, 54, 45, 571, DateTimeKind.Unspecified).AddTicks(1030), 7781848.609379269200000m, 7781848.609379269200000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 53,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 65, 56, new DateTime(2024, 5, 7, 8, 52, 19, 531, DateTimeKind.Unspecified).AddTicks(6542), 8996181.970793935500000m, 8996181.970793935500000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 54,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 15, 90, new DateTime(2024, 5, 7, 15, 27, 21, 728, DateTimeKind.Unspecified).AddTicks(9645), 9089123.72533843200000m, 9089123.72533843200000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 55,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 64, 85, new DateTime(2024, 5, 13, 10, 55, 51, 836, DateTimeKind.Unspecified).AddTicks(953), 5972220.616902544800000m, 5972220.616902544800000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 56,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 83, 82, new DateTime(2024, 5, 25, 4, 4, 20, 965, DateTimeKind.Unspecified).AddTicks(6026), 10886607.631291106500000m, 10886607.631291106500000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 57,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 3, 59, new DateTime(2024, 5, 1, 12, 29, 10, 216, DateTimeKind.Unspecified).AddTicks(8537), 9267068.3400690263100000m, 9267068.3400690263100000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 58,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 6, 18, new DateTime(2024, 5, 19, 13, 53, 56, 69, DateTimeKind.Unspecified).AddTicks(7903), 8918189.828982334100000m, 8918189.828982334100000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 59,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 62, 72, new DateTime(2024, 5, 11, 18, 12, 55, 142, DateTimeKind.Unspecified).AddTicks(2707), 8567125.448641093600000m, 8567125.448641093600000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 60,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 43, 61, new DateTime(2024, 5, 13, 10, 22, 7, 23, DateTimeKind.Unspecified).AddTicks(9679), 6549223.299079152900000m, 6549223.299079152900000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 61,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 82, 65, new DateTime(2024, 5, 20, 21, 27, 34, 703, DateTimeKind.Unspecified).AddTicks(5671), 11120069.774547240200000m, 11120069.774547240200000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 62,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 85, 9, new DateTime(2024, 5, 3, 6, 16, 21, 364, DateTimeKind.Unspecified).AddTicks(3167), 6400390.314440539200000m, 6400390.314440539200000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 63,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 20, 64, new DateTime(2024, 5, 26, 6, 21, 21, 525, DateTimeKind.Unspecified).AddTicks(8670), 9706717.475314579600000m, 9706717.475314579600000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 64,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 2, 58, new DateTime(2024, 5, 7, 2, 59, 49, 631, DateTimeKind.Unspecified).AddTicks(6746), 8353055.460050113200000m, 8353055.460050113200000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 65,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 33, 98, new DateTime(2024, 5, 20, 8, 8, 30, 675, DateTimeKind.Unspecified).AddTicks(61), 8248388.335710915000000m, 8248388.335710915000000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 66,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 29, 96, new DateTime(2024, 5, 27, 17, 42, 19, 220, DateTimeKind.Unspecified).AddTicks(4213), 9455716.4553824979200000m, 9455716.4553824979200000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 67,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 43, 60, new DateTime(2024, 5, 24, 14, 24, 17, 821, DateTimeKind.Unspecified).AddTicks(7865), 9446030.680655561600000m, 9446030.680655561600000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 68,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 92, 5, new DateTime(2024, 5, 28, 14, 44, 22, 353, DateTimeKind.Unspecified).AddTicks(1829), 6732659.138003508900000m, 6732659.138003508900000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 69,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 25, 95, new DateTime(2024, 5, 28, 17, 41, 4, 321, DateTimeKind.Unspecified).AddTicks(8454), 11502313.425243153000000m, 11502313.425243153000000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 70,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 11, 46, new DateTime(2024, 5, 26, 2, 54, 55, 471, DateTimeKind.Unspecified).AddTicks(2630), 12939015.043572054600000m, 12939015.043572054600000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 71,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 51, 75, new DateTime(2024, 5, 20, 11, 17, 15, 112, DateTimeKind.Unspecified).AddTicks(786), 14169481.278162098900000m, 14169481.278162098900000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 72,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 88, 23, new DateTime(2024, 5, 22, 23, 18, 50, 202, DateTimeKind.Unspecified).AddTicks(4841), 9886338.1037233476000000m, 9886338.1037233476000000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 73,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 78, 51, new DateTime(2024, 5, 18, 6, 39, 56, 952, DateTimeKind.Unspecified).AddTicks(2101), 7172469.079043500100000m, 7172469.079043500100000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 74,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 9, 29, new DateTime(2024, 5, 28, 2, 9, 13, 828, DateTimeKind.Unspecified).AddTicks(9153), 9583822.764886553600000m, 9583822.764886553600000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 75,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 63, 81, new DateTime(2024, 5, 3, 15, 28, 7, 108, DateTimeKind.Unspecified).AddTicks(6177), 6283819.155558118700000m, 6283819.155558118700000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 76,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 28, 40, new DateTime(2024, 5, 9, 9, 51, 46, 669, DateTimeKind.Unspecified).AddTicks(6495), 8577367.004918621400000m, 8577367.004918621400000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 77,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 95, 31, new DateTime(2024, 5, 25, 22, 4, 32, 575, DateTimeKind.Unspecified).AddTicks(8086), 5323220.9549357855000000m, 5323220.9549357855000000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 78,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 95, 58, new DateTime(2024, 5, 7, 0, 55, 42, 441, DateTimeKind.Unspecified).AddTicks(5159), 12711806.509280036400000m, 12711806.509280036400000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 79,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 79, 4, new DateTime(2024, 5, 9, 22, 36, 42, 532, DateTimeKind.Unspecified).AddTicks(3187), 9542743.277195727600000m, 9542743.277195727600000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 80,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 95, 94, new DateTime(2024, 5, 6, 22, 53, 10, 495, DateTimeKind.Unspecified).AddTicks(8598), 8795351.927914227000000m, 8795351.927914227000000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 81,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 87, 90, new DateTime(2024, 5, 9, 22, 37, 58, 942, DateTimeKind.Unspecified).AddTicks(8220), 8001529.06249778400000m, 8001529.06249778400000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 82,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 16, 31, new DateTime(2024, 5, 6, 6, 11, 21, 520, DateTimeKind.Unspecified).AddTicks(983), 6462136.393846360500000m, 6462136.393846360500000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 83,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 90, 76, new DateTime(2024, 5, 23, 3, 39, 29, 917, DateTimeKind.Unspecified).AddTicks(6096), 15751757.532955421700000m, 15751757.532955421700000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 84,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 18, 1, new DateTime(2024, 5, 2, 1, 12, 52, 484, DateTimeKind.Unspecified).AddTicks(6358), 13089512.102386262400000m, 13089512.102386262400000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 85,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 22, 4, new DateTime(2024, 5, 27, 7, 43, 41, 391, DateTimeKind.Unspecified).AddTicks(5121), 9841934.026820395500000m, 9841934.026820395500000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 86,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 36, 40, new DateTime(2024, 5, 1, 15, 47, 10, 231, DateTimeKind.Unspecified).AddTicks(2301), 12670620.317057656800000m, 12670620.317057656800000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 87,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 33, 72, new DateTime(2024, 5, 8, 16, 7, 1, 809, DateTimeKind.Unspecified).AddTicks(1323), 9580007.681805237600000m, 9580007.681805237600000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 88,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 31, 45, new DateTime(2024, 5, 2, 7, 39, 12, 66, DateTimeKind.Unspecified).AddTicks(7729), 6912738.669468436800000m, 6912738.669468436800000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 89,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 68, 2, new DateTime(2024, 5, 2, 18, 25, 49, 491, DateTimeKind.Unspecified).AddTicks(6185), 16923827.077421373000000m, 16923827.077421373000000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 90,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 27, 47, new DateTime(2024, 5, 25, 17, 16, 26, 264, DateTimeKind.Unspecified).AddTicks(8959), 11482496.108616317400000m, 11482496.108616317400000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 91,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 41, 31, new DateTime(2024, 5, 15, 18, 4, 25, 102, DateTimeKind.Unspecified).AddTicks(1333), 6598151.133370368000000m, 6598151.133370368000000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 92,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 15, 64, new DateTime(2024, 5, 7, 12, 27, 55, 875, DateTimeKind.Unspecified).AddTicks(4429), 6369603.902064064800000m, 6369603.902064064800000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 93,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 91, 44, new DateTime(2024, 5, 19, 0, 25, 7, 547, DateTimeKind.Unspecified).AddTicks(1474), 8752042.476577905000000m, 8752042.476577905000000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 94,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 14, 19, new DateTime(2024, 5, 12, 4, 53, 6, 216, DateTimeKind.Unspecified).AddTicks(273), 9021441.5299842758400000m, 9021441.5299842758400000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 95,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 50, 72, new DateTime(2024, 5, 16, 19, 54, 27, 593, DateTimeKind.Unspecified).AddTicks(5910), 15713097.559449710400000m, 15713097.559449710400000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 96,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 10, 60, new DateTime(2024, 5, 6, 9, 11, 31, 619, DateTimeKind.Unspecified).AddTicks(5386), 9480507.600219101400000m, 9480507.600219101400000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 97,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 50, 27, new DateTime(2024, 5, 17, 13, 31, 47, 221, DateTimeKind.Unspecified).AddTicks(4805), 11383987.430584454400000m, 11383987.430584454400000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 98,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 71, 23, new DateTime(2024, 5, 20, 16, 1, 13, 804, DateTimeKind.Unspecified).AddTicks(6114), 16018809.709044424800000m, 16018809.709044424800000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 99,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 29, 92, new DateTime(2024, 5, 16, 0, 28, 20, 68, DateTimeKind.Unspecified).AddTicks(3095), 12491320.252129297200000m, 12491320.252129297200000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 100,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 49, 10, new DateTime(2024, 5, 24, 13, 6, 27, 636, DateTimeKind.Unspecified).AddTicks(6287), 12972508.127238113300000m, 12972508.127238113300000m });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 3, 1 },
                column: "Email",
                value: "MinhHuyen.Tran@hotmail.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 4, 1 },
                column: "Email",
                value: "KimHuong54@yahoo.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 9, 2 },
                column: "Email",
                value: "HuyenNgoc.Phan61@yahoo.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 10, 2 },
                column: "Email",
                value: "DucTuan7@gmail.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 11, 1 },
                column: "Email",
                value: "VinhTho.Hoang@gmail.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 12, 2 },
                column: "Email",
                value: "DanLinh25@yahoo.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 13, 2 },
                column: "Email",
                value: "DinhTrung.Do34@hotmail.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 15, 2 },
                column: "Email",
                value: "HongMinh50@gmail.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 18, 1 },
                column: "Email",
                value: "MaiNhi_Phung94@gmail.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 21, 1 },
                column: "Email",
                value: "ThanhPhuong.Phan43@hotmail.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 22, 1 },
                column: "Email",
                value: "HaiSon77@gmail.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 23, 2 },
                column: "Email",
                value: "ChiKhiem40@yahoo.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 24, 2 },
                column: "Email",
                value: "HanhDung_To@gmail.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 25, 2 },
                column: "Email",
                value: "HuuNghi_Hoang65@gmail.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 26, 2 },
                column: "Email",
                value: "BichNga.Phung49@yahoo.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 27, 2 },
                column: "Email",
                value: "HungTuong7@hotmail.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 28, 1 },
                column: "Email",
                value: "BaoHa_Lam@hotmail.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 29, 1 },
                column: "Email",
                value: "ToQuyen.Vuong@hotmail.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 32, 1 },
                column: "Email",
                value: "HongChau_Nguyen@yahoo.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 34, 1 },
                column: "Email",
                value: "NhaMai_Phan@hotmail.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 35, 2 },
                column: "Email",
                value: "HoaLy0@yahoo.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 36, 2 },
                column: "Email",
                value: "QuocThien.Ha@gmail.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 37, 2 },
                column: "Email",
                value: "HoaHiep31@gmail.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 38, 1 },
                column: "Email",
                value: "HuyThanh.Tang@hotmail.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 40, 2 },
                column: "Email",
                value: "AiHong36@hotmail.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 41, 2 },
                column: "Email",
                value: "NguyenLoc.Lam38@gmail.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 43, 1 },
                column: "Email",
                value: "HongKhue.Ha@gmail.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 44, 1 },
                column: "Email",
                value: "SonDuong_Dao64@yahoo.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 51, 2 },
                column: "Email",
                value: "NhaLy58@yahoo.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 52, 2 },
                column: "Email",
                value: "HoaiVy_Le@yahoo.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 53, 2 },
                column: "Email",
                value: "LongGiang_Doan25@hotmail.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 54, 1 },
                column: "Email",
                value: "ThyVan.Dang@yahoo.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 55, 1 },
                column: "Email",
                value: "ThuNgan_Phan@yahoo.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 60, 1 },
                column: "Email",
                value: "TruongSa_Tran77@hotmail.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 63, 1 },
                column: "Email",
                value: "NhaYen39@yahoo.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 65, 2 },
                column: "Email",
                value: "QuynhDao_Vu60@gmail.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 67, 2 },
                column: "Email",
                value: "CaoTho.Pham87@hotmail.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 68, 1 },
                column: "Email",
                value: "ThanhKhiem_Ly@yahoo.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 70, 1 },
                column: "Email",
                value: "DongTra_Trinh@yahoo.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 72, 2 },
                column: "Email",
                value: "NhatPhuong.Truong@yahoo.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 74, 1 },
                column: "Email",
                value: "ThanhHao_Duong79@yahoo.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 75, 1 },
                column: "Email",
                value: "ThanhHoa.Ha@hotmail.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 76, 1 },
                column: "Email",
                value: "HaiBang.Phan24@yahoo.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 77, 1 },
                column: "Email",
                value: "ManhTuong.Lam@gmail.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 79, 2 },
                column: "Email",
                value: "NhatHa48@yahoo.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 80, 2 },
                column: "Email",
                value: "MongLan.Ngo@gmail.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 83, 1 },
                column: "Email",
                value: "NhatTien_Doan@gmail.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 86, 1 },
                column: "Email",
                value: "QuePhuong.Phung@yahoo.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 87, 2 },
                column: "Email",
                value: "QuynhAnh_Ly78@hotmail.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 90, 1 },
                column: "Email",
                value: "ThucTam.Do@gmail.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 91, 1 },
                column: "Email",
                value: "DiemLien.Tran38@gmail.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 93, 1 },
                column: "Email",
                value: "HongXuan74@hotmail.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 94, 2 },
                column: "Email",
                value: "HueAn.Dinh31@hotmail.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 97, 2 },
                column: "Email",
                value: "DiemPhuong_Ly@gmail.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 100, 1 },
                column: "Email",
                value: "TrieuThanh.Phung@hotmail.com");

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "EmployeeID", "RoleID", "Email", "LastLogin", "Lock", "Password" },
                values: new object[,]
                {
                    { 1, 1, "QuangDanh.Do@yahoo.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 2, 2, "AnhDuy49@yahoo.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 5, 2, "NganAnh_Duong57@gmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 6, 2, "ThanhMan.Nguyen1@yahoo.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 7, 1, "ThuyDuong.Dinh47@gmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 8, 1, "LanKhue26@hotmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 14, 2, "DinhTuan_To65@gmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 16, 1, "KimDan_Vuong96@yahoo.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 17, 2, "BaoTien_Dao@hotmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 19, 2, "KieuLoan.To0@gmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 20, 1, "TruongPhu.Dinh@gmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 30, 1, "HuongTien.Vu@gmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 31, 2, "YenPhuong.Dang73@gmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 33, 1, "HuyChieu_Ly@gmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 39, 2, "BichNhu_To@hotmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 42, 2, "LongQuan68@yahoo.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 45, 1, "HueAn.Do46@hotmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 46, 2, "ThaiNguyen.Vu75@yahoo.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 47, 2, "QuocHoai.Dao49@yahoo.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 48, 2, "VanTrang.Nguyen@hotmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 49, 2, "KietTrinh.Le13@yahoo.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 50, 1, "ThongMinh.Dao18@yahoo.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 56, 2, "ThienTinh.Phung@yahoo.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 57, 1, "HoaTien_Dinh@gmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 58, 1, "ThanhHao.Phung12@yahoo.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 59, 1, "MinhHoang.Le3@hotmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 61, 2, "ThanhGiang.Duong@gmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 62, 2, "ThucQuyen.Nguyen@yahoo.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 64, 1, "KimTuyen_Ly@hotmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 66, 2, "LinhDan30@gmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 69, 2, "HieuNghia_Tran7@gmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 71, 1, "NhuNgoc57@hotmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 73, 2, "ThuongLiet26@hotmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 78, 1, "MyNuong.Ho@hotmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 81, 2, "MinhTri_Dang@yahoo.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 82, 1, "BichHai_Do@yahoo.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 84, 1, "MaiPhuong.Lam@yahoo.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 85, 2, "ThaiSang.Le85@hotmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 88, 1, "HaiLong.Le45@gmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 89, 2, "TuanKhanh29@hotmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 92, 1, "HuyThanh69@yahoo.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 95, 2, "ThangCanh20@yahoo.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 96, 2, "TuanLong.Pham18@yahoo.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 98, 1, "KhietTam.Vuong38@hotmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 99, 2, "ThuLinh.Ha35@hotmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" }
                });

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "RoleID",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2024, 4, 7, 14, 42, 57, 573, DateTimeKind.Local).AddTicks(639));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "RoleID",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2024, 4, 7, 14, 42, 57, 573, DateTimeKind.Local).AddTicks(651));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 5, 2 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 6, 2 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 7, 1 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 8, 1 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 14, 2 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 16, 1 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 17, 2 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 19, 2 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 20, 1 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 30, 1 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 31, 2 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 33, 1 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 39, 2 });

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
                keyValues: new object[] { 47, 2 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 48, 2 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 49, 2 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 50, 1 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 56, 2 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 57, 1 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 58, 1 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 59, 1 });

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
                keyValues: new object[] { 64, 1 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 66, 2 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 69, 2 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 71, 1 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 73, 2 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 78, 1 });

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
                keyValues: new object[] { 84, 1 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 85, 2 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 88, 1 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 89, 2 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 92, 1 });

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
                keyValues: new object[] { 99, 2 });

            migrationBuilder.AlterColumn<string>(
                name: "RoleName",
                table: "UserRole",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "UserRole",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                table: "UserRole",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "date");

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "User",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "Provider",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "Employee",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "Customer",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 1,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Phú Thọ", "Mộng Vân Hồ", new DateTime(2024, 3, 23, 16, 41, 6, 172, DateTimeKind.Local).AddTicks(5944), "NgocHa.Doan@gmail.com", "0932065978" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 2,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Lai Châu", "Hoàng Khôi Hoàng", new DateTime(2024, 3, 23, 16, 41, 6, 172, DateTimeKind.Local).AddTicks(8896), "ThuyMai15@gmail.com", "0901724444" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 3,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Hưng Yên", "Việt Thông Mai", new DateTime(2024, 3, 23, 16, 41, 6, 172, DateTimeKind.Local).AddTicks(9031), "NhuHong_Tran@gmail.com", "0946076418" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 4,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Vĩnh Phúc", "Trang Anh Đặng", new DateTime(2024, 3, 23, 16, 41, 6, 172, DateTimeKind.Local).AddTicks(9117), "NhuMai_Phan@yahoo.com", "0943875888" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 5,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Bắc Ninh", "Hữu Nghị Phan", new DateTime(2024, 3, 23, 16, 41, 6, 172, DateTimeKind.Local).AddTicks(9186), "HiepHao26@yahoo.com", "0936383028" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 6,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Cao Bằng", "Việt Cường Dương", new DateTime(2024, 3, 23, 16, 41, 6, 172, DateTimeKind.Local).AddTicks(9267), "BaLong_Truong37@hotmail.com", "0904838500" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 7,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Đắk Lắk", "Diệu Ngọc Bùi", new DateTime(2024, 3, 23, 16, 41, 6, 172, DateTimeKind.Local).AddTicks(9341), "HaTien_Mai29@gmail.com", "0954614639" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 8,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Ninh Bình", "Thu Yến Lâm", new DateTime(2024, 3, 23, 16, 41, 6, 172, DateTimeKind.Local).AddTicks(9415), "TatHieu67@hotmail.com", "0994621320" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 9,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Đồng Tháp", "Hồng Tâm Vương", new DateTime(2024, 3, 23, 16, 41, 6, 172, DateTimeKind.Local).AddTicks(9493), "TheVinh_Ly14@yahoo.com", "0986899442" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 10,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Quảng Ngãi", "Hùng Thịnh Dương", new DateTime(2024, 3, 23, 16, 41, 6, 172, DateTimeKind.Local).AddTicks(9567), "KhaiTam27@hotmail.com", "0969057283" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 11,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Hà Nam", "Huy Hoàng Đinh", new DateTime(2024, 3, 23, 16, 41, 6, 172, DateTimeKind.Local).AddTicks(9641), "HoanKiem3@gmail.com", "0947519795" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 12,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Hải Dương", "Nhã Hồng Trịnh", new DateTime(2024, 3, 23, 16, 41, 6, 172, DateTimeKind.Local).AddTicks(9715), "DucLong_Nguyen@yahoo.com", "0977157307" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 13,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Lạng Sơn", "Kiều Loan Lê", new DateTime(2024, 3, 23, 16, 41, 6, 172, DateTimeKind.Local).AddTicks(9796), "QuangDat.Vu16@yahoo.com", "0975524550" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 14,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Thừa Thiên-Huế", "Xuân Nhi Phan", new DateTime(2024, 3, 23, 16, 41, 6, 172, DateTimeKind.Local).AddTicks(9867), "ThyTruc.Pham3@hotmail.com", "0952994779" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 15,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Phú Yên", "Thiếu Anh Hoàng", new DateTime(2024, 3, 23, 16, 41, 6, 172, DateTimeKind.Local).AddTicks(9942), "NgocAn.Ha51@gmail.com", "0963347256" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 16,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Vĩnh Phúc", "Hồng Tâm Bùi", new DateTime(2024, 3, 23, 16, 41, 6, 173, DateTimeKind.Local).AddTicks(15), "HuuBao28@yahoo.com", "0947133545" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 17,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Kiên Giang", "Chí Hiếu Đoàn", new DateTime(2024, 3, 23, 16, 41, 6, 173, DateTimeKind.Local).AddTicks(81), "NhuHao15@yahoo.com", "0914547243" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 18,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Lai Châu", "Phúc Thịnh Đoàn", new DateTime(2024, 3, 23, 16, 41, 6, 173, DateTimeKind.Local).AddTicks(145), "VietNhi.Bui@yahoo.com", "0978568208" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 19,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Vĩnh Long", "Quốc Hạnh Phạm", new DateTime(2024, 3, 23, 16, 41, 6, 173, DateTimeKind.Local).AddTicks(217), "TuanChuong.Vuong22@hotmail.com", "0920744606" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 20,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Tiền Giang", "Minh Hào Hoàng", new DateTime(2024, 3, 23, 16, 41, 6, 173, DateTimeKind.Local).AddTicks(300), "VanThong_Truong16@hotmail.com", "0927676014" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 21,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Ninh Thuận", "Mộc Miên Trần", new DateTime(2024, 3, 23, 16, 41, 6, 173, DateTimeKind.Local).AddTicks(380), "KimNgoc82@yahoo.com", "0961270364" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 22,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Gia Lai", "Việt Sơn Vương", new DateTime(2024, 3, 23, 16, 41, 6, 173, DateTimeKind.Local).AddTicks(443), "GiaPhuoc94@yahoo.com", "0960951893" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 23,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Lạng Sơn", "Ðình Toàn Hà", new DateTime(2024, 3, 23, 16, 41, 6, 173, DateTimeKind.Local).AddTicks(514), "XuanVu88@gmail.com", "0936785225" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 24,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Ninh Thuận", "Dã Lâm Hoàng", new DateTime(2024, 3, 23, 16, 41, 6, 173, DateTimeKind.Local).AddTicks(581), "NgocHien39@hotmail.com", "0956681866" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 25,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Bến Tre", "Thanh Thuận Vương", new DateTime(2024, 3, 23, 16, 41, 6, 173, DateTimeKind.Local).AddTicks(648), "TanPhat.Hoang22@hotmail.com", "0999846127" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 26,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Thái Nguyên", "Thúy Huyền Tăng", new DateTime(2024, 3, 23, 16, 41, 6, 173, DateTimeKind.Local).AddTicks(719), "NhatHa.Phung86@yahoo.com", "0917540756" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 27,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Bình Dương", "Vân Trang Phan", new DateTime(2024, 3, 23, 16, 41, 6, 173, DateTimeKind.Local).AddTicks(783), "TrongDung_Nguyen@gmail.com", "0947186840" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 28,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Quảng Nam", "Hoa Thiên Lâm", new DateTime(2024, 3, 23, 16, 41, 6, 173, DateTimeKind.Local).AddTicks(855), "HaMi81@gmail.com", "0907316241" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 29,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Hà Giang", "Quang Nhật Mai", new DateTime(2024, 3, 23, 16, 41, 6, 173, DateTimeKind.Local).AddTicks(915), "QuyKhanh10@yahoo.com", "0912590816" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 30,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Hải Dương", "Phi Cường Trương", new DateTime(2024, 3, 23, 16, 41, 6, 173, DateTimeKind.Local).AddTicks(982), "VietKhang.Le85@hotmail.com", "0973625096" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 31,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Cao Bằng", "Việt Hùng Phan", new DateTime(2024, 3, 23, 16, 41, 6, 173, DateTimeKind.Local).AddTicks(1048), "AnhTuyet80@hotmail.com", "0916857222" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 32,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Lai Châu", "Minh Yến Trịnh", new DateTime(2024, 3, 23, 16, 41, 6, 173, DateTimeKind.Local).AddTicks(1117), "KimLien49@hotmail.com", "0947974621" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 33,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Lạng Sơn", "Bá Thịnh Tăng", new DateTime(2024, 3, 23, 16, 41, 6, 173, DateTimeKind.Local).AddTicks(1178), "TrungHai_Duong63@hotmail.com", "0929213291" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 34,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Thừa Thiên-Huế", "Ðức Chính Hà", new DateTime(2024, 3, 23, 16, 41, 6, 173, DateTimeKind.Local).AddTicks(1248), "VietLong48@hotmail.com", "0966096081" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 35,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Đồng Nai", "Gia Phước Đinh", new DateTime(2024, 3, 23, 16, 41, 6, 173, DateTimeKind.Local).AddTicks(1313), "HuuNghi97@hotmail.com", "0936986099" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 36,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Yên Bái", "Kim Hoàng Hồ", new DateTime(2024, 3, 23, 16, 41, 6, 173, DateTimeKind.Local).AddTicks(1371), "BichHai54@gmail.com", "0971490680" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 37,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Hà Nam", "Việt Hương Đoàn", new DateTime(2024, 3, 23, 16, 41, 6, 173, DateTimeKind.Local).AddTicks(1438), "ThuyLieu_Mai42@hotmail.com", "0924864920" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 38,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Đắk Lắk", "Bích Trâm Phan", new DateTime(2024, 3, 23, 16, 41, 6, 173, DateTimeKind.Local).AddTicks(1502), "NgocThuan.Tang@gmail.com", "0917704001" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 39,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Hải Phòng", "Huy Thông Mai", new DateTime(2024, 3, 23, 16, 41, 6, 173, DateTimeKind.Local).AddTicks(1571), "PhuongTrach_Ho@gmail.com", "0902838925" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 40,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Bình Định", "Phú Thọ Đỗ", new DateTime(2024, 3, 23, 16, 41, 6, 173, DateTimeKind.Local).AddTicks(1637), "TrungNhan.Dinh@gmail.com", "0923094897" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 41,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Bắc Ninh", "Hải Thụy Vũ", new DateTime(2024, 3, 23, 16, 41, 6, 173, DateTimeKind.Local).AddTicks(1705), "DanhThanh85@yahoo.com", "0932785253" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 42,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Đắk Lắk", "Ngọc Lân Hồ", new DateTime(2024, 3, 23, 16, 41, 6, 173, DateTimeKind.Local).AddTicks(1767), "VanThuy.Trinh93@yahoo.com", "0978148978" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 43,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Đồng Tháp", "Xuyến Chi Phùng", new DateTime(2024, 3, 23, 16, 41, 6, 173, DateTimeKind.Local).AddTicks(1834), "VietNhi_Trinh@yahoo.com", "0914980312" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 44,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Bình Định", "Hải Sinh Phan", new DateTime(2024, 3, 23, 16, 41, 6, 173, DateTimeKind.Local).AddTicks(1898), "ThuNgoc.Hoang@yahoo.com", "0979809532" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 45,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Vĩnh Phúc", "Thái Sơn Hoàng", new DateTime(2024, 3, 23, 16, 41, 6, 173, DateTimeKind.Local).AddTicks(1962), "VuongTrieu_Duong@hotmail.com", "0978348868" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 46,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Sơn La", "Tuyết Mai Vương", new DateTime(2024, 3, 23, 16, 41, 6, 173, DateTimeKind.Local).AddTicks(2030), "AnhThy.Duong@gmail.com", "0952731652" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 47,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Lâm Đồng", "Thúy Liễu Hoàng", new DateTime(2024, 3, 23, 16, 41, 6, 173, DateTimeKind.Local).AddTicks(2091), "KienDuc.Tran@yahoo.com", "0960500836" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 48,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Đắk Lắk", "Thanh Kiên Phùng", new DateTime(2024, 3, 23, 16, 41, 6, 173, DateTimeKind.Local).AddTicks(2157), "PhuBinh84@hotmail.com", "0954930459" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 49,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Quảng Bình", "Mỹ Hoàn Phùng", new DateTime(2024, 3, 23, 16, 41, 6, 173, DateTimeKind.Local).AddTicks(2217), "ThuongHuyen.Ho@gmail.com", "0973608140" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 50,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Bà Rịa-Vũng Tàu", "Minh Ðức Đinh", new DateTime(2024, 3, 23, 16, 41, 6, 173, DateTimeKind.Local).AddTicks(2291), "XuanQuan_Lam@gmail.com", "0943711848" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 51,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Quảng Bình", "Việt Thi Hoàng", new DateTime(2024, 3, 23, 16, 41, 6, 173, DateTimeKind.Local).AddTicks(2352), "ThuNga7@hotmail.com", "0921925951" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 52,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Lai Châu", "Trúc Phương Bùi", new DateTime(2024, 3, 23, 16, 41, 6, 173, DateTimeKind.Local).AddTicks(2412), "OanhTho.Tran@hotmail.com", "0946414347" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 53,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Hòa Bình", "Ngọc Ðoàn Đinh", new DateTime(2024, 3, 23, 16, 41, 6, 173, DateTimeKind.Local).AddTicks(2475), "NgocHien.Do86@hotmail.com", "0962681949" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 54,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Thừa Thiên-Huế", "Xuân Huy Trần", new DateTime(2024, 3, 23, 16, 41, 6, 173, DateTimeKind.Local).AddTicks(2540), "ThanhAn81@yahoo.com", "0920813404" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 55,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Lâm Đồng", "Nguyết Ánh Mai", new DateTime(2024, 3, 23, 16, 41, 6, 173, DateTimeKind.Local).AddTicks(2603), "HaiDuong3@yahoo.com", "0967766883" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 56,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Bình Thuận", "Trường Sinh Phùng", new DateTime(2024, 3, 23, 16, 41, 6, 173, DateTimeKind.Local).AddTicks(2677), "VanKhanh.Doan@hotmail.com", "0981046281" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 57,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Hậu Giang", "Bửu Diệp Trịnh", new DateTime(2024, 3, 23, 16, 41, 6, 173, DateTimeKind.Local).AddTicks(2742), "TungLam.Bui35@gmail.com", "0918133113" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 58,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Quảng Trị", "Liễu Oanh Vương", new DateTime(2024, 3, 23, 16, 41, 6, 173, DateTimeKind.Local).AddTicks(2803), "AnLai49@hotmail.com", "0923261487" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 59,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Điện Biên", "Hải Phương Lâm", new DateTime(2024, 3, 23, 16, 41, 6, 173, DateTimeKind.Local).AddTicks(2869), "MinhThuong.Duong@yahoo.com", "0936297204" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 60,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Bắc Kạn", "Yên Bằng Phạm", new DateTime(2024, 3, 23, 16, 41, 6, 173, DateTimeKind.Local).AddTicks(2930), "MongVan.Bui49@yahoo.com", "0941532169" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 61,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Hải Phòng", "Trọng Việt Tăng", new DateTime(2024, 3, 23, 16, 41, 6, 173, DateTimeKind.Local).AddTicks(2993), "DucHai.Pham63@hotmail.com", "0939950391" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 62,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Quảng Nam", "Quốc Mỹ Tăng", new DateTime(2024, 3, 23, 16, 41, 6, 173, DateTimeKind.Local).AddTicks(3053), "BaoHuynh.Doan75@gmail.com", "0962181642" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 63,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Bình Dương", "Thế An Vương", new DateTime(2024, 3, 23, 16, 41, 6, 173, DateTimeKind.Local).AddTicks(3124), "DinhSieu.Phung@yahoo.com", "0902619421" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 64,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Yên Bái", "Hồng Thụy Bùi", new DateTime(2024, 3, 23, 16, 41, 6, 173, DateTimeKind.Local).AddTicks(3188), "ThanhTruc_Vu@yahoo.com", "0995813151" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 65,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Lai Châu", "Diệu Vân Phùng", new DateTime(2024, 3, 23, 16, 41, 6, 173, DateTimeKind.Local).AddTicks(3255), "KhanhBinh.Dao@yahoo.com", "0922270406" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 66,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Ninh Thuận", "Hải Thụy Đỗ", new DateTime(2024, 3, 23, 16, 41, 6, 173, DateTimeKind.Local).AddTicks(3320), "DinhQuang_Ly@yahoo.com", "0966278586" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 67,
                columns: new[] { "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Lam Tuyền Trần", new DateTime(2024, 3, 23, 16, 41, 6, 173, DateTimeKind.Local).AddTicks(3386), "HueThuong_Tran93@yahoo.com", "0917831025" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 68,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Bắc Giang", "Nhật Lệ Phạm", new DateTime(2024, 3, 23, 16, 41, 6, 173, DateTimeKind.Local).AddTicks(3456), "BaoNgoc43@yahoo.com", "0968890013" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 69,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Vĩnh Long", "Ngọc Mai Phan", new DateTime(2024, 3, 23, 16, 41, 6, 173, DateTimeKind.Local).AddTicks(3514), "BuuToai.Duong0@gmail.com", "0930317478" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 70,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Tiền Giang", "Quốc Hùng Phùng", new DateTime(2024, 3, 23, 16, 41, 6, 173, DateTimeKind.Local).AddTicks(3588), "TuanLong_Mai@gmail.com", "0967536745" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 71,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Hà Giang", "Lan Anh Hoàng", new DateTime(2024, 3, 23, 16, 41, 6, 173, DateTimeKind.Local).AddTicks(3651), "BaoBinh_To@hotmail.com", "0955442734" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 72,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Hưng Yên", "Phương Trà Lê", new DateTime(2024, 3, 23, 16, 41, 6, 173, DateTimeKind.Local).AddTicks(3714), "QuocThien32@yahoo.com", "0922134965" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 73,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Hòa Bình", "Duy Cường Vương", new DateTime(2024, 3, 23, 16, 41, 6, 173, DateTimeKind.Local).AddTicks(3780), "ThuHa.Tran35@yahoo.com", "0912195846" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 74,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Hà Nam", "Lương Tuyền Đặng", new DateTime(2024, 3, 23, 16, 41, 6, 173, DateTimeKind.Local).AddTicks(3848), "DinhNgan39@hotmail.com", "0932879117" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 75,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Sóc Trăng", "Hữu Nghĩa Đặng", new DateTime(2024, 3, 23, 16, 41, 6, 173, DateTimeKind.Local).AddTicks(3907), "ThangLoi94@gmail.com", "0997161353" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 76,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Lào Cai", "Phượng Bích Dương", new DateTime(2024, 3, 23, 16, 41, 6, 173, DateTimeKind.Local).AddTicks(3972), "DangKhoa_Truong3@gmail.com", "0969746834" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 77,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Quảng Ngãi", "Mạnh Trường Lâm", new DateTime(2024, 3, 23, 16, 41, 6, 173, DateTimeKind.Local).AddTicks(4047), "TrungChuyen55@hotmail.com", "0906610986" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 78,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Trà Vinh", "Thúy Mai Nguyễn", new DateTime(2024, 3, 23, 16, 41, 6, 173, DateTimeKind.Local).AddTicks(4112), "BachKim.Trinh@yahoo.com", "0940733344" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 79,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Thái Nguyên", "Thiên Duyên Ngô", new DateTime(2024, 3, 23, 16, 41, 6, 173, DateTimeKind.Local).AddTicks(4180), "NhatKhuong77@yahoo.com", "0907281820" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 80,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Cần Thơ", "Tú Ly Mai", new DateTime(2024, 3, 23, 16, 41, 6, 173, DateTimeKind.Local).AddTicks(4247), "KhanhGiang.Dang@hotmail.com", "0932101258" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 81,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Bắc Ninh", "Ngọc Lan Nguyễn", new DateTime(2024, 3, 23, 16, 41, 6, 173, DateTimeKind.Local).AddTicks(4318), "NguyenNhan.Mai28@hotmail.com", "0975734737" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 82,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Hà Nội", "Trung Nguyên Dương", new DateTime(2024, 3, 23, 16, 41, 6, 173, DateTimeKind.Local).AddTicks(4383), "ThanhTrung.Trinh1@yahoo.com", "0935801087" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 83,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Tiền Giang", "Bạch Cúc Đặng", new DateTime(2024, 3, 23, 16, 41, 6, 173, DateTimeKind.Local).AddTicks(4460), "KienLam12@gmail.com", "0939813650" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 84,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Đồng Tháp", "Tuyết Nga Đỗ", new DateTime(2024, 3, 23, 16, 41, 6, 173, DateTimeKind.Local).AddTicks(4522), "HanhSan.Le@hotmail.com", "0958889846" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 85,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Yên Bái", "Vân Khanh Trịnh", new DateTime(2024, 3, 23, 16, 41, 6, 173, DateTimeKind.Local).AddTicks(4583), "QuynhChi12@gmail.com", "0901066500" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 86,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Quảng Ngãi", "Thương Thương Đỗ", new DateTime(2024, 3, 23, 16, 41, 6, 173, DateTimeKind.Local).AddTicks(4648), "KhaiCa5@gmail.com", "0914656059" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 87,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Lâm Đồng", "Hạnh Chi Phan", new DateTime(2024, 3, 23, 16, 41, 6, 173, DateTimeKind.Local).AddTicks(4708), "QuynhDung24@yahoo.com", "0928333137" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 88,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Hà Nam", "Diễm Khuê Tăng", new DateTime(2024, 3, 23, 16, 41, 6, 173, DateTimeKind.Local).AddTicks(4778), "QuynhNhi_Bui@yahoo.com", "0972038770" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 89,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Cao Bằng", "Long Vịnh Hà", new DateTime(2024, 3, 23, 16, 41, 6, 173, DateTimeKind.Local).AddTicks(4838), "PhuongChi_Mai62@gmail.com", "0943095878" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 90,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Phú Yên", "Bích Vân Lê", new DateTime(2024, 3, 23, 16, 41, 6, 173, DateTimeKind.Local).AddTicks(4907), "BaoHuynh_Dao29@hotmail.com", "0934739580" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 91,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Quảng Ngãi", "Quảng Thông Lê", new DateTime(2024, 3, 23, 16, 41, 6, 173, DateTimeKind.Local).AddTicks(4968), "AnhHoang.To@yahoo.com", "0950637487" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 92,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Yên Bái", "Thanh Kiều Hồ", new DateTime(2024, 3, 23, 16, 41, 6, 173, DateTimeKind.Local).AddTicks(5033), "XuyenChi1@gmail.com", "0930051290" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 93,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Quảng Ngãi", "Hải Phong Ngô", new DateTime(2024, 3, 23, 16, 41, 6, 173, DateTimeKind.Local).AddTicks(5091), "NgocKhang.Truong72@gmail.com", "0908279702" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 94,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Bắc Ninh", "Viết Tân Đinh", new DateTime(2024, 3, 23, 16, 41, 6, 173, DateTimeKind.Local).AddTicks(5162), "LinhPhuong_Dang15@hotmail.com", "0933365187" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 95,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Bắc Kạn", "Ánh Hồng Phan", new DateTime(2024, 3, 23, 16, 41, 6, 173, DateTimeKind.Local).AddTicks(5231), "ThaoNguyen_Doan73@gmail.com", "0986798776" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 96,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Nam Định", "Ngọc Thuận Đặng", new DateTime(2024, 3, 23, 16, 41, 6, 173, DateTimeKind.Local).AddTicks(5296), "HaMi_To@hotmail.com", "0966660034" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 97,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Nam Định", "Kiều Loan Đào", new DateTime(2024, 3, 23, 16, 41, 6, 173, DateTimeKind.Local).AddTicks(5355), "TamNhi75@gmail.com", "0995355983" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 98,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Bắc Ninh", "Nhật Huy Vương", new DateTime(2024, 3, 23, 16, 41, 6, 173, DateTimeKind.Local).AddTicks(5415), "VietCuong_Phan44@yahoo.com", "0957988252" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 99,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Đồng Tháp", "Thiện Tâm Đào", new DateTime(2024, 3, 23, 16, 41, 6, 173, DateTimeKind.Local).AddTicks(5485), "AiThi.Phan18@hotmail.com", "0954601702" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 100,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Lai Châu", "Hữu Khôi Ngô", new DateTime(2024, 3, 23, 16, 41, 6, 173, DateTimeKind.Local).AddTicks(5547), "NgocKhoi82@yahoo.com", "0900164448" });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 146, 42303.508097224280000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 2, 2 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 181, 28506.08768774480000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 3, 3 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 126, 15585.307901765960000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 4, 4 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 162, 12684.8064956345920000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 5, 5 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 131, 23804.30923441560000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 6, 6 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 198, 11296.3826401911120000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 7, 7 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 186, 27302.443521340640000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 8, 8 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 143, 20285.572075097560000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 9, 9 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 175, 48665.735361213360000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 10, 10 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 193, 31752.838311112880000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 11, 11 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 187, 38943.785612323000000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 12, 12 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 137, 42750.893066735480000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 13, 13 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 194, 31824.753924724360000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 14, 14 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 125, 25276.508527109760000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 15, 15 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 176, 28018.129339980120000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 16, 16 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 122, 18552.032634340040000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 17, 17 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 175, 21360.649041562600000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 18, 18 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 172, 28189.362452908600000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 19, 19 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 198, 18372.464710156640000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 20, 20 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 144, 35718.469760871160000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 21, 21 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 148, 47808.125608409760000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 22, 22 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 155, 44542.919863338040000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 23, 23 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 167, 39686.431843489000000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 24, 24 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 197, 32542.519173625480000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 25, 25 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 156, 39082.609434288720000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 26, 26 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 149, 29543.683841355280000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 27, 27 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 135, 19170.921973614240000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 28, 28 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 102, 29998.902836275840000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 29, 29 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 177, 27550.393883550960000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 30, 30 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 195, 15033.696819087400000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 31, 31 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 189, 30861.059226808160000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 32, 32 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 174, 13670.693656817360000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 33, 33 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 116, 29081.962589477880000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 34, 34 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 103, 35593.581840765920000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 35, 35 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 141, 30146.899699036040000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 36, 36 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 112, 28810.91560257840000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 37, 37 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 142, 44612.995857262440000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 38, 38 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 149, 41110.138520516200000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 39, 39 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 124, 45944.240390030720000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 40, 40 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 102, 15280.228264005080000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 41, 41 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 155, 42736.084506578600000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 42, 42 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 178, 11224.9692710084120000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 43, 43 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 185, 13967.5318787496480000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 44, 44 },
                column: "UnitPrice",
                value: 43102.653250016720000m);

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 45, 45 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 182, 39765.766498926760000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 46, 46 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 195, 38040.153073147240000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 47, 47 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 190, 14563.465449256480000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 48, 48 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 149, 28130.536104639800000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 49, 49 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 138, 39950.795521422960000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 50, 50 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 153, 47511.415950023120000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 51, 51 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 139, 18794.18336446120000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 52, 52 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 126, 30920.016559643560000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 53, 53 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 119, 30714.933973647920000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 54, 54 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 166, 40268.252010040360000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 55, 55 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 182, 47240.900747988520000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 56, 56 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 104, 30977.349056497120000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 57, 57 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 200, 40606.190754991680000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 58, 58 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 139, 33110.964290726640000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 59, 59 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 137, 41869.820744379800000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 60, 60 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 115, 22695.983309053360000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 61, 61 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 112, 13510.9934276242440000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 62, 62 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 149, 16227.755900152080000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 63, 63 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 185, 36046.977283089480000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 64, 64 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 175, 18157.038884331040000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 65, 65 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 130, 43157.517923264880000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 66, 66 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 155, 37848.578855221360000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 67, 67 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 188, 33300.693018767280000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 68, 68 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 147, 42033.943179997360000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 69, 69 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 111, 35786.128251549760000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 70, 70 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 106, 26198.339240486560000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 71, 71 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 127, 43280.932587487320000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 72, 72 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 164, 22002.32114695040000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 73, 73 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 119, 33468.376595290760000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 74, 74 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 135, 32414.397392546480000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 75, 75 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 180, 40839.584299049760000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 76, 76 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 157, 15489.067666794520000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 77, 77 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 168, 25762.650811910280000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 78, 78 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 159, 15915.704162417240000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 79, 79 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 164, 19125.977066221040000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 80, 80 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 100, 35447.163173625360000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 81, 81 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 196, 40754.446539440360000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 82, 82 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 165, 20606.099663694840000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 83, 83 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 173, 15536.504007771840000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 84, 84 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 108, 16726.331620277240000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 85, 85 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 145, 39854.951103270520000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 86, 86 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 163, 47827.904909382840000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 87, 87 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 128, 35104.34235122720000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 88, 88 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 186, 17850.143389083680000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 89, 89 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 125, 17323.149339340560000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 90, 90 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 177, 32085.246740067000000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 91, 91 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 146, 43059.357597739800000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 92, 92 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 114, 36579.499787619640000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 93, 93 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 168, 17041.48206354320000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 94, 94 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 192, 29912.637012999840000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 95, 95 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 109, 29695.105700114240000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 96, 96 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 194, 42666.524082324880000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 97, 97 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 141, 39304.901193565960000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 98, 98 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 172, 42895.128263524840000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 99, 99 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 114, 49613.31601647120000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 100, 100 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 178, 44940.726852377360000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 80, 132241.291606892800000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 2, 2 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 50, 125620.927848374800000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 3, 3 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 64, 150142.193069695800000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 4, 4 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 85, 179912.554751261900000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 5, 5 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 78, 166019.084048111500000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 6, 6 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 84, 199469.324196765500000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 7, 7 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 68, 115610.668338365200000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 8, 8 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 54, 158860.3053659800000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 9, 9 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 58, 147425.932511251700000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 10, 10 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 70, 188538.277211412400000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 11, 11 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 90, 124686.753509806200000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 12, 12 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 74, 180278.904198016200000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 13, 13 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 55, 191099.024859295900000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 14, 14 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 62, 185137.774391541300000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 15, 15 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 61, 147275.57829378500000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 16, 16 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 86, 124820.330617497400000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 17, 17 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 76, 158713.297436490900000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 18, 18 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 61, 148286.047275262900000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 19, 19 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 59, 143851.493234387100000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 20, 20 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 50, 167882.90179925600000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 21, 21 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 59, 174495.898930734200000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 22, 22 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 59, 131173.929496302700000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 23, 23 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 88, 192555.90196653500000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 24, 24 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 90, 109623.0514237024300000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 25, 25 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 60, 172999.875019364400000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 26, 26 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 58, 101837.4089297075500000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 27, 27 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 51, 170029.154675533700000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 28, 28 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 66, 198654.447087908300000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 29, 29 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 87, 144219.571439588700000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 30, 30 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 55, 197740.783542299700000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 31, 31 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 74, 134835.978950475200000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 32, 32 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 60, 168301.621024446100000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 33, 33 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 83, 150530.026395409600000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 34, 34 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 72, 189872.009261875400000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 35, 35 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 63, 186572.115828365900000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 36, 36 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 67, 109078.1205499377800000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 37, 37 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 71, 134211.797448801900000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 38, 38 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 56, 154483.606039970600000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 39, 39 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 52, 122615.329438975700000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 40, 40 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 85, 123848.489269415900000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 41, 41 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 81, 146237.019754227400000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 42, 42 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 69, 103169.5437202199900000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 43, 43 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 71, 122722.078485566400000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 44, 44 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 50, 158963.940912524100000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 45, 45 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 80, 109578.347014057900000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 46, 46 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 53, 147269.329446573700000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 47, 47 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 53, 161711.177942141400000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 48, 48 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 59, 130231.295132508400000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 49, 49 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 69, 104657.6951304751900000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 50, 50 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 60, 154221.433549164500000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 51, 51 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 74, 181782.875261194200000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 52, 52 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 57, 170626.351048038600000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 53, 53 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 61, 150118.051828948400000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 54, 54 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 61, 108833.7571192149400000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 55, 55 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 74, 121464.398511470900000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 56, 56 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 76, 147921.958197856200000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 57, 57 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 69, 173248.261475337300000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 58, 58 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 65, 122768.448668631500000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 59, 59 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 59, 144428.239932748200000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 60, 60 },
                column: "UnitPrice",
                value: 161003.907700527300000m);

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 61, 61 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 61, 199266.651657995700000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 62, 62 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 78, 137082.97686798400000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 63, 63 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 51, 139509.564986500600000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 64, 64 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 84, 159630.145633712900000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 65, 65 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 62, 187735.454067210400000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 66, 66 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 58, 139969.84904268800000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 67, 67 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 64, 115279.079548463700000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 68, 68 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 54, 153182.043208510800000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 69, 69 },
                column: "UnitPrice",
                value: 184939.730011353900000m);

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 70, 70 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 57, 153502.170520624800000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 71, 71 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 75, 196854.434315070800000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 72, 72 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 50, 186008.436874108300000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 73, 73 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 89, 159940.225627459300000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 74, 74 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 70, 107407.5535388442900000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 75, 75 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 76, 130604.184296018900000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 76, 76 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 74, 163825.26992157700000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 77, 77 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 75, 105175.0094337114400000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 78, 78 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 86, 182928.232122626500000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 79, 79 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 56, 162460.429861408500000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 80, 80 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 90, 138230.906844659300000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 81, 81 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 75, 129820.15314226100000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 82, 82 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 77, 115557.230466998800000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 83, 83 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 88, 192827.434270560800000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 84, 84 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 80, 102831.6031976655100000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 85, 85 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 83, 127227.14294376300000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 86, 86 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 68, 182123.518869835600000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 87, 87 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 69, 147504.783720697900000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 88, 88 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 66, 164326.198547623600000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 89, 89 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 72, 190557.562786955100000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 90, 90 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 88, 106422.3766075848100000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 91, 91 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 86, 194403.349583472500000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 92, 92 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 64, 105370.9294471350900000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 93, 93 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 66, 115113.242272370800000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 94, 94 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 86, 146462.484141249700000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 95, 95 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 57, 129324.950864853200000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 96, 96 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 53, 194451.732421982600000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 97, 97 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 69, 194560.586957744900000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 98, 98 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 73, 118564.779578957600000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 99, 99 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 56, 139125.403613556400000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 100, 100 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 68, 177936.7913005300000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 1,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Tuyên Quang", new DateTime(2024, 3, 23, 16, 41, 6, 178, DateTimeKind.Local).AddTicks(687), "NgocTram61@yahoo.com", "Tùng Quân Đinh", "0922424167", 522129.8298794139000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 2,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Hà Giang", new DateTime(2024, 3, 23, 16, 41, 6, 178, DateTimeKind.Local).AddTicks(3105), "VietNhan_Ly57@gmail.com", "Ðức Kiên Trần", "0965464010", 951139.314495916500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 3,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Phú Yên", new DateTime(2024, 3, 23, 16, 41, 6, 178, DateTimeKind.Local).AddTicks(3228), "TruongPhuc62@gmail.com", "Uyển Như Phạm", "0958656414", 618931.359025966000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 4,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Đắk Lắk", new DateTime(2024, 3, 23, 16, 41, 6, 178, DateTimeKind.Local).AddTicks(3281), "KimThao.Trinh78@yahoo.com", "Bá Trúc Trịnh", "0970104563", 622756.126916582000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 5,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Bà Rịa-Vũng Tàu", new DateTime(2024, 3, 23, 16, 41, 6, 178, DateTimeKind.Local).AddTicks(3324), "TuongLan_To@yahoo.com", "Trung Nguyên Ngô", "0977281836", 632586.909205773500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 6,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Trà Vinh", new DateTime(2024, 3, 23, 16, 41, 6, 178, DateTimeKind.Local).AddTicks(3373), "KimKhanh_Ngo37@yahoo.com", "Thúy Mai Bùi", "0931881066", 825949.652756656000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 7,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Đồng Tháp", new DateTime(2024, 3, 23, 16, 41, 6, 178, DateTimeKind.Local).AddTicks(3414), "ChePhuong.Ly25@yahoo.com", "Yên Bằng Đỗ", "0934912361", 525468.0787485942000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 8,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Phú Yên", new DateTime(2024, 3, 23, 16, 41, 6, 178, DateTimeKind.Local).AddTicks(3453), "DinhChieu52@hotmail.com", "Trọng Hiếu Trương", "0940651624", 536387.7938365107000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 9,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Long An", new DateTime(2024, 3, 23, 16, 41, 6, 178, DateTimeKind.Local).AddTicks(3497), "TuanHung.Tran5@hotmail.com", "Thanh Hường Trần", "0928573220", 583521.558204563500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 10,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Đà Nẵng", new DateTime(2024, 3, 23, 16, 41, 6, 178, DateTimeKind.Local).AddTicks(3536), "DuyAn88@gmail.com", "Quang Triều Đỗ", "0926756614", 987309.929792513000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 11,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Quảng Ninh", new DateTime(2024, 3, 23, 16, 41, 6, 178, DateTimeKind.Local).AddTicks(3576), "LanTruc_Duong68@yahoo.com", "Nguyệt Cát Hoàng", "0949482022", 527122.981198666500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 12,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Bình Thuận", new DateTime(2024, 3, 23, 16, 41, 6, 178, DateTimeKind.Local).AddTicks(3621), "KhanhAn.Ly@hotmail.com", "Ngọc Ẩn Nguyễn", "0940352119", 693864.611799587500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 13,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Cao Bằng", new DateTime(2024, 3, 23, 16, 41, 6, 178, DateTimeKind.Local).AddTicks(3660), "KhanhHoa.Phan@yahoo.com", "Huy Anh Trần", "0992163095", 756652.124732458000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 14,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Thừa Thiên-Huế", new DateTime(2024, 3, 23, 16, 41, 6, 178, DateTimeKind.Local).AddTicks(3699), "LienTran78@yahoo.com", "Khương Duy Nguyễn", "0956528960", 895168.330088361000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 15,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "An Giang", new DateTime(2024, 3, 23, 16, 41, 6, 178, DateTimeKind.Local).AddTicks(3744), "VuongTrieu.Tang28@yahoo.com", "Bá Thịnh Đinh", "0993813084", 958204.719068693500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 16,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Điện Biên", new DateTime(2024, 3, 23, 16, 41, 6, 178, DateTimeKind.Local).AddTicks(3782), "VinhDieu_Vuong76@gmail.com", "Kim Tuyến Ngô", "0927119674", 924157.973736528500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 17,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Hưng Yên", new DateTime(2024, 3, 23, 16, 41, 6, 178, DateTimeKind.Local).AddTicks(3826), "BaoLan_Tran@yahoo.com", "Hữu Hùng Đào", "0908846557", 815557.432146667000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 18,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Hải Phòng", new DateTime(2024, 3, 23, 16, 41, 6, 178, DateTimeKind.Local).AddTicks(3866), "ThienMai.Ngo@yahoo.com", "Mai Hà Tăng", "0974876217", 813942.315573827000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 19,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Sóc Trăng", new DateTime(2024, 3, 23, 16, 41, 6, 178, DateTimeKind.Local).AddTicks(3905), "BaoThach_Ngo47@gmail.com", "Anh Duy Đặng", "0999409202", 581635.745780176500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 20,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Quảng Bình", new DateTime(2024, 3, 23, 16, 41, 6, 178, DateTimeKind.Local).AddTicks(3948), "HongNhan_Duong55@yahoo.com", "Thanh Thư Lâm", "0958365578", 946821.975615407000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 21,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Đồng Tháp", new DateTime(2024, 3, 23, 16, 41, 6, 178, DateTimeKind.Local).AddTicks(3986), "ThienLan.Pham@hotmail.com", "Thu Việt Hồ", "0900950819", 573015.238095195500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 22,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Đồng Nai", new DateTime(2024, 3, 23, 16, 41, 6, 178, DateTimeKind.Local).AddTicks(4023), "DinhLoc.Dang85@hotmail.com", "Chi Mai Mai", "0981342479", 613470.960018409500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 23,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Bình Dương", new DateTime(2024, 3, 23, 16, 41, 6, 178, DateTimeKind.Local).AddTicks(4066), "AnhMinh64@hotmail.com", "Kim Ánh Đặng", "0952322360", 785045.72117330500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 24,
                columns: new[] { "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { new DateTime(2024, 3, 23, 16, 41, 6, 178, DateTimeKind.Local).AddTicks(4104), "MongThu90@gmail.com", "Quốc Thiện Trần", "0991364063", 639252.277826942500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 25,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Cao Bằng", new DateTime(2024, 3, 23, 16, 41, 6, 178, DateTimeKind.Local).AddTicks(4141), "ThuyLieu35@gmail.com", "Trọng Tường Hồ", "0972833787", 566515.604917802500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 26,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Gia Lai", new DateTime(2024, 3, 23, 16, 41, 6, 178, DateTimeKind.Local).AddTicks(4184), "ThanhTin_Do@yahoo.com", "Quốc Hải Lê", "0913858596", 862402.94321648500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 27,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Yên Bái", new DateTime(2024, 3, 23, 16, 41, 6, 178, DateTimeKind.Local).AddTicks(4222), "TienDung.Ho@hotmail.com", "Duyên My Đinh", "0945544967", 874977.644172297000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 28,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Bà Rịa-Vũng Tàu", new DateTime(2024, 3, 23, 16, 41, 6, 178, DateTimeKind.Local).AddTicks(4265), "HoaLy.Ly@hotmail.com", "Lục Bình Tăng", "0918468572", 933112.241478828000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 29,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Khánh Hoà", new DateTime(2024, 3, 23, 16, 41, 6, 178, DateTimeKind.Local).AddTicks(4304), "NhanHong.Truong@yahoo.com", "Minh Hưng Trịnh", "0946265271", 643857.884664063000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 30,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Đồng Tháp", new DateTime(2024, 3, 23, 16, 41, 6, 178, DateTimeKind.Local).AddTicks(4342), "LeQuyen_Tran54@gmail.com", "Sĩ Hoàng Tăng", "0953918799", 795257.866580097500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 31,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Bà Rịa-Vũng Tàu", new DateTime(2024, 3, 23, 16, 41, 6, 178, DateTimeKind.Local).AddTicks(4389), "UyenMy93@hotmail.com", "Thanh Huy Phạm", "0905810334", 888431.329740146000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 32,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Hà Tĩnh", new DateTime(2024, 3, 23, 16, 41, 6, 178, DateTimeKind.Local).AddTicks(4429), "TuanSi.Phung@yahoo.com", "Thăng Long Tăng", "0975522330", 532521.3001722811000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 33,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Kiên Giang", new DateTime(2024, 3, 23, 16, 41, 6, 178, DateTimeKind.Local).AddTicks(4469), "BaoPhuong35@gmail.com", "Sỹ Ðan Đinh", "0975988543", 972328.585468382000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 34,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Bến Tre", new DateTime(2024, 3, 23, 16, 41, 6, 178, DateTimeKind.Local).AddTicks(4512), "NhaMai83@hotmail.com", "Bình Dương Tô", "0966831746", 887430.734248277000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 35,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Lâm Đồng", new DateTime(2024, 3, 23, 16, 41, 6, 178, DateTimeKind.Local).AddTicks(4551), "KhaiCa_Ngo89@gmail.com", "Quang Ðạt Ngô", "0990550036", 899317.56484565500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 36,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Lạng Sơn", new DateTime(2024, 3, 23, 16, 41, 6, 178, DateTimeKind.Local).AddTicks(4589), "NgocTru_Mai67@yahoo.com", "Nguyên Thảo Tô", "0908617054", 530840.3822357092500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 37,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Nam Định", new DateTime(2024, 3, 23, 16, 41, 6, 178, DateTimeKind.Local).AddTicks(4632), "ChiThanh0@yahoo.com", "Cẩm Nhung Tăng", "0957258584", 659619.928587227500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 38,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Nghệ An", new DateTime(2024, 3, 23, 16, 41, 6, 178, DateTimeKind.Local).AddTicks(4670), "PhuongNgoc_Duong36@yahoo.com", "Hoàng Miên Phạm", "0916313558", 548840.2444493686000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 39,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Lai Châu", new DateTime(2024, 3, 23, 16, 41, 6, 178, DateTimeKind.Local).AddTicks(4713), "QuangTrieu.Tang@gmail.com", "Chí Anh Hồ", "0936161110", 609375.411193748500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 40,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Hòa Bình", new DateTime(2024, 3, 23, 16, 41, 6, 178, DateTimeKind.Local).AddTicks(4751), "KhietTam_Phung@hotmail.com", "Ðình Ngân Mai", "0902621726", 842724.14037595500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 41,
                columns: new[] { "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { new DateTime(2024, 3, 23, 16, 41, 6, 178, DateTimeKind.Local).AddTicks(4788), "TuongAnh18@gmail.com", "Ngân Trúc Phan", "0914529268", 584717.587249841500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 42,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Vĩnh Long", new DateTime(2024, 3, 23, 16, 41, 6, 178, DateTimeKind.Local).AddTicks(4833), "NgocQuang_Dao@gmail.com", "Thiện Lương Lý", "0946268974", 631039.709958061000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 43,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Bắc Kạn", new DateTime(2024, 3, 23, 16, 41, 6, 178, DateTimeKind.Local).AddTicks(4871), "HuuThong23@yahoo.com", "Huệ Thương Phạm", "0926696778", 677338.289430489000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 44,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Sóc Trăng", new DateTime(2024, 3, 23, 16, 41, 6, 178, DateTimeKind.Local).AddTicks(4909), "ThanhThu33@yahoo.com", "Thái Thảo Trần", "0963895082", 843012.874425347500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 45,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Cao Bằng", new DateTime(2024, 3, 23, 16, 41, 6, 178, DateTimeKind.Local).AddTicks(4956), "SuongSuong8@hotmail.com", "Phước Nhân Mai", "0969441876", 833764.670158187500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 46,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Nam Định", new DateTime(2024, 3, 23, 16, 41, 6, 178, DateTimeKind.Local).AddTicks(4993), "AnhThai.Ho@hotmail.com", "Thục Vân Hồ", "0988315044", 916593.10816453000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 47,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Quảng Nam", new DateTime(2024, 3, 23, 16, 41, 6, 178, DateTimeKind.Local).AddTicks(5033), "BanMai.Mai42@hotmail.com", "Lan Ngọc Hà", "0945827909", 603020.742867344500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 48,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Bình Thuận", new DateTime(2024, 3, 23, 16, 41, 6, 178, DateTimeKind.Local).AddTicks(5077), "CongBang15@gmail.com", "Khánh Hoàn Đào", "0944316277", 968263.199873512000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 49,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Kon Tum", new DateTime(2024, 3, 23, 16, 41, 6, 178, DateTimeKind.Local).AddTicks(5120), "HuuChien_Phan@gmail.com", "Dã Lan Lâm", "0970580651", 990285.439658347000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 50,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Kon Tum", new DateTime(2024, 3, 23, 16, 41, 6, 178, DateTimeKind.Local).AddTicks(5160), "BaThien_Bui40@yahoo.com", "Phương Dung Lý", "0994060088", 956137.559606269000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 51,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Sơn La", new DateTime(2024, 3, 23, 16, 41, 6, 178, DateTimeKind.Local).AddTicks(5208), "NhaHuong_Vu@gmail.com", "Việt Thanh Đoàn", "0912536133", 686378.887295363000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 52,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Khánh Hoà", new DateTime(2024, 3, 23, 16, 41, 6, 178, DateTimeKind.Local).AddTicks(5251), "LuongThien15@gmail.com", "Bửu Chưởng Lý", "0936412056", 985470.313951746000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 53,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Khánh Hoà", new DateTime(2024, 3, 23, 16, 41, 6, 178, DateTimeKind.Local).AddTicks(5293), "YenThanh56@hotmail.com", "Hồng Thảo Dương", "0951909888", 813447.003150247000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 54,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Hải Dương", new DateTime(2024, 3, 23, 16, 41, 6, 178, DateTimeKind.Local).AddTicks(5337), "MaiLien.Ly53@hotmail.com", "Hồng Châu Hà", "0925131783", 692817.240371614500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 55,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Kiên Giang", new DateTime(2024, 3, 23, 16, 41, 6, 178, DateTimeKind.Local).AddTicks(5375), "LinhLan43@hotmail.com", "Minh Kỳ Lê", "0941003651", 886333.363087630500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 56,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Tuyên Quang", new DateTime(2024, 3, 23, 16, 41, 6, 178, DateTimeKind.Local).AddTicks(5423), "MongLong.Vuong@yahoo.com", "Giang Nam Hoàng", "0999248001", 870341.985838324500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 57,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Điện Biên", new DateTime(2024, 3, 23, 16, 41, 6, 178, DateTimeKind.Local).AddTicks(5462), "TrungKien.Lam@yahoo.com", "Thanh Lâm Đinh", "0918946309", 694256.379664812000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 58,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Quảng Nam", new DateTime(2024, 3, 23, 16, 41, 6, 178, DateTimeKind.Local).AddTicks(5500), "NhaSuong_Dang65@yahoo.com", "Nam Thông Bùi", "0994250627", 773840.777308836500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 59,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Bắc Kạn", new DateTime(2024, 3, 23, 16, 41, 6, 178, DateTimeKind.Local).AddTicks(5545), "PhuongPhi34@hotmail.com", "Hải My Mai", "0973323850", 800337.579126811000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 60,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Ninh Bình", new DateTime(2024, 3, 23, 16, 41, 6, 178, DateTimeKind.Local).AddTicks(5583), "BichTram_Pham70@gmail.com", "Diệu Linh Bùi", "0929473671", 530326.4672513775500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 61,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Bình Định", new DateTime(2024, 3, 23, 16, 41, 6, 178, DateTimeKind.Local).AddTicks(5621), "MinhAnh79@hotmail.com", "Hữu Tâm Phùng", "0938282892", 524925.1632626561500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 62,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Long An", new DateTime(2024, 3, 23, 16, 41, 6, 178, DateTimeKind.Local).AddTicks(5668), "TinhTam_Duong@gmail.com", "Tuyết Mai Dương", "0947401152", 701623.483613500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 63,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Hưng Yên", new DateTime(2024, 3, 23, 16, 41, 6, 178, DateTimeKind.Local).AddTicks(5705), "BichHai85@gmail.com", "Giáng Ngọc Hà", "0924389400", 516831.217222504500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 64,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Hà Giang", new DateTime(2024, 3, 23, 16, 41, 6, 178, DateTimeKind.Local).AddTicks(5750), "NgocLinh_Phung52@gmail.com", "Thuận Phương Vũ", "0905254403", 712795.617973939500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 65,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Phú Thọ", new DateTime(2024, 3, 23, 16, 41, 6, 178, DateTimeKind.Local).AddTicks(5789), "XuanMinh77@yahoo.com", "Chính Trực Hoàng", "0903558068", 922177.682741488000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 66,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Thanh Hoá", new DateTime(2024, 3, 23, 16, 41, 6, 178, DateTimeKind.Local).AddTicks(5828), "QuangThach.Ngo71@yahoo.com", "Khang Kiện Mai", "0978806215", 628171.71215447000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 67,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Lâm Đồng", new DateTime(2024, 3, 23, 16, 41, 6, 178, DateTimeKind.Local).AddTicks(5899), "VuHong_Dao5@hotmail.com", "Tịnh Như Đinh", "0971419397", 923192.298368728000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 68,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Tây Ninh", new DateTime(2024, 3, 23, 16, 41, 6, 178, DateTimeKind.Local).AddTicks(5937), "ThaiDuc.Phan9@yahoo.com", "Quốc Hưng Đặng", "0965267231", 615539.688795974000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 69,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Quảng Ninh", new DateTime(2024, 3, 23, 16, 41, 6, 178, DateTimeKind.Local).AddTicks(5976), "MinhHai.Truong84@gmail.com", "Tấn Nam Lý", "0970901203", 997203.752940961000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 70,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Đắk Lắk", new DateTime(2024, 3, 23, 16, 41, 6, 178, DateTimeKind.Local).AddTicks(6021), "QuynhLam_Ly41@gmail.com", "Thúy Ngà Đặng", "0963749874", 994448.133568470500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 71,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Nam Định", new DateTime(2024, 3, 23, 16, 41, 6, 178, DateTimeKind.Local).AddTicks(6059), "KienDuc5@gmail.com", "Danh Văn Đoàn", "0911338691", 928959.601089233000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 72,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Bắc Ninh", new DateTime(2024, 3, 23, 16, 41, 6, 178, DateTimeKind.Local).AddTicks(6097), "BichTram46@gmail.com", "Tùng Lâm Trương", "0949059217", 801949.786568011000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 73,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "TP. Hồ Chí Minh", new DateTime(2024, 3, 23, 16, 41, 6, 178, DateTimeKind.Local).AddTicks(6137), "ThanhThien.Hoang71@gmail.com", "Minh Mẫn Phùng", "0914241936", 735726.5575657500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 74,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Hòa Bình", new DateTime(2024, 3, 23, 16, 41, 6, 178, DateTimeKind.Local).AddTicks(6176), "ThanhHoa5@hotmail.com", "Yên Nhi Mai", "0913454588", 881403.289388627500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 75,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Kiên Giang", new DateTime(2024, 3, 23, 16, 41, 6, 178, DateTimeKind.Local).AddTicks(6218), "UyenMinh.Ly14@yahoo.com", "Uyển Nghi Phạm", "0949141674", 910468.350006975500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 76,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Hà Tĩnh", new DateTime(2024, 3, 23, 16, 41, 6, 178, DateTimeKind.Local).AddTicks(6257), "HangNga.Phung@yahoo.com", "Phượng Tiên Lâm", "0958462007", 541545.3537438621000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 77,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Bắc Ninh", new DateTime(2024, 3, 23, 16, 41, 6, 178, DateTimeKind.Local).AddTicks(6295), "HuuNghi.Tang@gmail.com", "Lâm Nhi Hồ", "0993484914", 834008.385823627500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 78,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Bến Tre", new DateTime(2024, 3, 23, 16, 41, 6, 178, DateTimeKind.Local).AddTicks(6338), "BaoBinh17@hotmail.com", "Bá Long Trần", "0948330739", 572078.391519238000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 79,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Yên Bái", new DateTime(2024, 3, 23, 16, 41, 6, 178, DateTimeKind.Local).AddTicks(6374), "HuyViet.Ha72@hotmail.com", "Phúc Hưng Ngô", "0983580813", 571119.196985289000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 80,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Vĩnh Long", new DateTime(2024, 3, 23, 16, 41, 6, 178, DateTimeKind.Local).AddTicks(6411), "BaoThach.To68@hotmail.com", "Yến Trang Phan", "0915470988", 707153.745361339000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 81,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "An Giang", new DateTime(2024, 3, 23, 16, 41, 6, 178, DateTimeKind.Local).AddTicks(6455), "QuocViet_Ngo@gmail.com", "Hữu Vĩnh Đỗ", "0921761438", 700704.190303004500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 82,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Đà Nẵng", new DateTime(2024, 3, 23, 16, 41, 6, 178, DateTimeKind.Local).AddTicks(6494), "NguyenBao_Tran@yahoo.com", "Cương Quyết Trịnh", "0983868500", 540758.605771888000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 83,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Phú Yên", new DateTime(2024, 3, 23, 16, 41, 6, 178, DateTimeKind.Local).AddTicks(6532), "DucPhi.Dao6@gmail.com", "Phúc Hưng Tăng", "0934814515", 611008.70576779000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 84,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Gia Lai", new DateTime(2024, 3, 23, 16, 41, 6, 178, DateTimeKind.Local).AddTicks(6576), "MinhThu.Phung65@gmail.com", "Khánh Ngọc Mai", "0945707303", 897709.88251224500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 85,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Sóc Trăng", new DateTime(2024, 3, 23, 16, 41, 6, 178, DateTimeKind.Local).AddTicks(6614), "TrucLien_Ngo@hotmail.com", "Trường Nhân Phùng", "0902512261", 941943.988154028500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 86,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Long An", new DateTime(2024, 3, 23, 16, 41, 6, 178, DateTimeKind.Local).AddTicks(6650), "NhanTu_Ngo66@hotmail.com", "Bạch Kim Đỗ", "0906685430", 918101.811033595500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 87,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Bắc Ninh", new DateTime(2024, 3, 23, 16, 41, 6, 178, DateTimeKind.Local).AddTicks(6691), "HaiPhuong.Duong@hotmail.com", "Quốc Hoài Lê", "0972087623", 510921.6415678713000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 88,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Vĩnh Phúc", new DateTime(2024, 3, 23, 16, 41, 6, 178, DateTimeKind.Local).AddTicks(6735), "TuyetBang49@gmail.com", "Hướng Bình Lê", "0985661681", 835021.970329687000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 89,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Hòa Bình", new DateTime(2024, 3, 23, 16, 41, 6, 178, DateTimeKind.Local).AddTicks(6779), "YenTrang87@gmail.com", "Trúc Mai Lê", "0918569664", 840606.841612318500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 90,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Phú Thọ", new DateTime(2024, 3, 23, 16, 41, 6, 178, DateTimeKind.Local).AddTicks(6817), "VietHung.Tran95@yahoo.com", "Xuân Sơn Lê", "0915183935", 572476.277894590500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 91,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Thanh Hoá", new DateTime(2024, 3, 23, 16, 41, 6, 178, DateTimeKind.Local).AddTicks(6855), "TungAnh_Mai17@hotmail.com", "Xuân xanh Hà", "0977447740", 567668.755289750500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 92,
                columns: new[] { "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { new DateTime(2024, 3, 23, 16, 41, 6, 178, DateTimeKind.Local).AddTicks(6897), "XuanTam58@gmail.com", "Hữu Bào Vương", "0952079494", 754043.180475680500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 93,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Quảng Ninh", new DateTime(2024, 3, 23, 16, 41, 6, 178, DateTimeKind.Local).AddTicks(6935), "PhuongNhung_Phung@hotmail.com", "Thục Tâm Phùng", "0928419707", 739954.547425653000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 94,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "TP. Hồ Chí Minh", new DateTime(2024, 3, 23, 16, 41, 6, 178, DateTimeKind.Local).AddTicks(6984), "SuongSuong_Mai37@yahoo.com", "Hà Mi Dương", "0978004476", 883873.486918539500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 95,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Hải Phòng", new DateTime(2024, 3, 23, 16, 41, 6, 178, DateTimeKind.Local).AddTicks(7026), "ThieuLy_Dang65@gmail.com", "Kim Thy Vũ", "0943227999", 539921.2902128367000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 96,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Cần Thơ", new DateTime(2024, 3, 23, 16, 41, 6, 178, DateTimeKind.Local).AddTicks(7062), "NgocCam.Ly85@gmail.com", "Linh Châu Tô", "0942340425", 564789.155287614500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 97,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Bình Phước", new DateTime(2024, 3, 23, 16, 41, 6, 178, DateTimeKind.Local).AddTicks(7099), "ThuSinh72@gmail.com", "Việt Quyết Vương", "0993770518", 756902.871418302500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 98,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Vĩnh Long", new DateTime(2024, 3, 23, 16, 41, 6, 178, DateTimeKind.Local).AddTicks(7143), "TriHung.Vuong49@gmail.com", "Thục Quyên Đỗ", "0960337000", 990247.242083166000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 99,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Sóc Trăng", new DateTime(2024, 3, 23, 16, 41, 6, 178, DateTimeKind.Local).AddTicks(7182), "LamNgoc52@hotmail.com", "Nhất Tiến Hà", "0941442906", 590418.35360168000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 100,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Lạng Sơn", new DateTime(2024, 3, 23, 16, 41, 6, 178, DateTimeKind.Local).AddTicks(7225), "TamDoan.Vuong@gmail.com", "Thu Việt Trịnh", "0990894752", 643503.03501354500000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 1,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 21, new DateTime(2024, 5, 25, 7, 20, 20, 688, DateTimeKind.Unspecified).AddTicks(6573), 71, 6176312.182194744880000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 2,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 78, new DateTime(2024, 5, 6, 0, 23, 28, 914, DateTimeKind.Unspecified).AddTicks(2549), 2, 5159601.87148180880000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 3,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 76, new DateTime(2024, 5, 17, 20, 50, 19, 519, DateTimeKind.Unspecified).AddTicks(361), 50, 1963748.795622510960000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 4,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 16, new DateTime(2024, 5, 28, 1, 56, 9, 558, DateTimeKind.Unspecified).AddTicks(4139), 50, 2054938.6522928039040000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 5,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 92, new DateTime(2024, 5, 6, 15, 53, 38, 352, DateTimeKind.Unspecified).AddTicks(8677), 39, 3118364.50970844360000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 6,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 86, new DateTime(2024, 5, 5, 10, 56, 41, 942, DateTimeKind.Unspecified).AddTicks(2992), 82, 2236683.7627578401760000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 7,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 22, new DateTime(2024, 5, 18, 7, 20, 47, 705, DateTimeKind.Unspecified).AddTicks(2018), 95, 5078254.494969359040000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 8,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 9, new DateTime(2024, 5, 25, 21, 36, 27, 787, DateTimeKind.Unspecified).AddTicks(7267), 5, 2900836.806738951080000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 9,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 12, new DateTime(2024, 5, 23, 11, 3, 27, 309, DateTimeKind.Unspecified).AddTicks(3528), 90, 8516503.688212338000000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 10,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 66, new DateTime(2024, 5, 6, 22, 36, 9, 648, DateTimeKind.Unspecified).AddTicks(4425), 20, 6128297.794044785840000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 11,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 16, new DateTime(2024, 5, 17, 1, 44, 40, 93, DateTimeKind.Unspecified).AddTicks(1060), 13, 7282487.909504401000000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 12,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 81, new DateTime(2024, 5, 17, 16, 37, 57, 342, DateTimeKind.Unspecified).AddTicks(7511), 26, 5856872.350142760760000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 13,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 58, new DateTime(2024, 5, 8, 15, 37, 12, 307, DateTimeKind.Unspecified).AddTicks(4808), 51, 6174002.261396525840000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 14,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 57, new DateTime(2024, 5, 26, 20, 54, 23, 37, DateTimeKind.Unspecified).AddTicks(3671), 23, 3159563.565888720000000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 15,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 74, new DateTime(2024, 5, 16, 4, 35, 11, 430, DateTimeKind.Unspecified).AddTicks(7552), 70, 4931190.763836501120000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 16,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 8, new DateTime(2024, 5, 29, 16, 11, 7, 607, DateTimeKind.Unspecified).AddTicks(339), 69, 2263347.981389484880000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 17,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 7, new DateTime(2024, 5, 28, 14, 50, 53, 616, DateTimeKind.Unspecified).AddTicks(7544), 64, 3738113.582273455000000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 18,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 47, new DateTime(2024, 5, 4, 3, 49, 16, 464, DateTimeKind.Unspecified).AddTicks(2151), 17, 4848570.341900279200000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 19,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 13, new DateTime(2024, 5, 9, 18, 27, 53, 515, DateTimeKind.Unspecified).AddTicks(374), 4, 3637748.012611014720000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 20,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 39, new DateTime(2024, 5, 18, 12, 51, 32, 155, DateTimeKind.Unspecified).AddTicks(8794), 89, 5143459.645565447040000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 21,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 34, new DateTime(2024, 5, 27, 23, 40, 9, 102, DateTimeKind.Unspecified).AddTicks(1982), 42, 7075602.590044644480000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 22,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 12, new DateTime(2024, 5, 18, 18, 15, 19, 898, DateTimeKind.Unspecified).AddTicks(9805), 47, 6904152.578817396200000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 23,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 93, new DateTime(2024, 5, 6, 20, 37, 59, 109, DateTimeKind.Unspecified).AddTicks(9325), 39, 6627634.117862663000000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 24,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 88, new DateTime(2024, 5, 8, 0, 49, 2, 432, DateTimeKind.Unspecified).AddTicks(3700), 58, 6410876.277204219560000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 25,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 82, new DateTime(2024, 5, 8, 3, 8, 56, 617, DateTimeKind.Unspecified).AddTicks(2631), 19, 6096887.071749040320000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 26,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 47, new DateTime(2024, 5, 1, 10, 54, 19, 229, DateTimeKind.Unspecified).AddTicks(7153), 82, 4402008.892361936720000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 27,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 12, new DateTime(2024, 5, 15, 12, 13, 3, 793, DateTimeKind.Unspecified).AddTicks(3651), 74, 2588074.466437922400000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 28,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 77, new DateTime(2024, 5, 13, 3, 5, 38, 861, DateTimeKind.Unspecified).AddTicks(6963), 77, 3059888.089300135680000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 29,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 95, new DateTime(2024, 5, 10, 2, 43, 51, 112, DateTimeKind.Unspecified).AddTicks(4499), 46, 4876419.717388519920000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 30,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 21, new DateTime(2024, 5, 17, 14, 28, 21, 86, DateTimeKind.Unspecified).AddTicks(4732), 34, 2931570.879722043000000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 31,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 54, new DateTime(2024, 5, 26, 20, 5, 2, 263, DateTimeKind.Unspecified).AddTicks(7823), 58, 5832740.193866742240000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 32,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 85, new DateTime(2024, 5, 8, 11, 3, 52, 387, DateTimeKind.Unspecified).AddTicks(957), 66, 2378700.696286220640000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 33,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 13, new DateTime(2024, 5, 9, 18, 36, 22, 704, DateTimeKind.Unspecified).AddTicks(2177), 4, 3373507.660379434080000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 34,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 17, new DateTime(2024, 5, 20, 5, 3, 6, 382, DateTimeKind.Unspecified).AddTicks(4038), 81, 3666138.929598889760000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 35,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 43, new DateTime(2024, 5, 25, 7, 33, 13, 24, DateTimeKind.Unspecified).AddTicks(3341), 95, 4250712.857564081640000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 36,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 79, new DateTime(2024, 5, 13, 16, 17, 35, 465, DateTimeKind.Unspecified).AddTicks(409), 86, 3226822.54748878080000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 37,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 39, new DateTime(2024, 5, 29, 19, 15, 50, 958, DateTimeKind.Unspecified).AddTicks(4582), 39, 6335045.411731266480000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 38,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 53, new DateTime(2024, 5, 2, 4, 11, 28, 533, DateTimeKind.Unspecified).AddTicks(3477), 68, 6125410.639556913800000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 39,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 41, new DateTime(2024, 5, 24, 10, 1, 58, 301, DateTimeKind.Unspecified).AddTicks(7892), 16, 5697085.808363809280000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 40,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 69, new DateTime(2024, 5, 22, 13, 38, 17, 224, DateTimeKind.Unspecified).AddTicks(477), 23, 1558583.282928518160000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 41,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 56, new DateTime(2024, 5, 8, 6, 54, 40, 691, DateTimeKind.Unspecified).AddTicks(3558), 12, 6624093.098519683000000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 42,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 40, new DateTime(2024, 5, 23, 4, 27, 17, 784, DateTimeKind.Unspecified).AddTicks(4938), 100, 1998044.5302394973360000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 43,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 19, new DateTime(2024, 5, 7, 22, 41, 47, 910, DateTimeKind.Unspecified).AddTicks(4413), 39, 2583993.3975686848800000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 44,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 24, new DateTime(2024, 5, 5, 12, 31, 33, 983, DateTimeKind.Unspecified).AddTicks(1509), 68, 7499861.665502909280000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 45,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 37, new DateTime(2024, 5, 18, 6, 44, 9, 204, DateTimeKind.Unspecified).AddTicks(5097), 67, 7237369.502804670320000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 46,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 51, new DateTime(2024, 5, 23, 3, 50, 3, 996, DateTimeKind.Unspecified).AddTicks(366), 15, 7417829.849263711800000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 47,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 86, new DateTime(2024, 5, 19, 19, 46, 3, 300, DateTimeKind.Unspecified).AddTicks(5480), 15, 2767058.435358731200000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 48,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 11, new DateTime(2024, 5, 7, 9, 18, 46, 435, DateTimeKind.Unspecified).AddTicks(8686), 86, 4191449.879591330200000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 49,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 8, new DateTime(2024, 5, 16, 7, 41, 12, 500, DateTimeKind.Unspecified).AddTicks(2661), 95, 5513209.781956368480000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 50,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 92, new DateTime(2024, 5, 13, 0, 47, 41, 27, DateTimeKind.Unspecified).AddTicks(9308), 51, 7269246.640353537360000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 51,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 89, new DateTime(2024, 5, 9, 12, 39, 45, 210, DateTimeKind.Unspecified).AddTicks(4336), 84, 2612391.48766010680000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 52,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 76, new DateTime(2024, 5, 3, 22, 24, 15, 951, DateTimeKind.Unspecified).AddTicks(169), 55, 3895922.086515088560000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 53,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 74, new DateTime(2024, 5, 7, 0, 20, 52, 486, DateTimeKind.Unspecified).AddTicks(8832), 31, 3655077.142864102480000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 54,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 59, new DateTime(2024, 5, 25, 2, 25, 20, 48, DateTimeKind.Unspecified).AddTicks(7460), 67, 6684529.833666699760000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 55,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 72, new DateTime(2024, 5, 8, 23, 6, 51, 734, DateTimeKind.Unspecified).AddTicks(5915), 39, 8597843.936133910640000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 56,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 100, new DateTime(2024, 5, 15, 17, 41, 44, 533, DateTimeKind.Unspecified).AddTicks(1819), 49, 3221644.301875700480000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 57,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 86, new DateTime(2024, 5, 21, 21, 50, 9, 935, DateTimeKind.Unspecified).AddTicks(7635), 97, 8121238.150998336000000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 58,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 30, new DateTime(2024, 5, 22, 0, 6, 53, 32, DateTimeKind.Unspecified).AddTicks(1596), 95, 4602424.036411002960000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 59,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 98, new DateTime(2024, 5, 20, 17, 49, 24, 244, DateTimeKind.Unspecified).AddTicks(6473), 13, 5736165.441980032600000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 60,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 45, new DateTime(2024, 5, 8, 23, 40, 59, 765, DateTimeKind.Unspecified).AddTicks(4198), 44, 2610038.080541136400000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 61,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 99, new DateTime(2024, 5, 11, 23, 40, 39, 64, DateTimeKind.Unspecified).AddTicks(6675), 30, 1513231.2638939153280000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 62,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 33, new DateTime(2024, 5, 13, 13, 7, 48, 766, DateTimeKind.Unspecified).AddTicks(2102), 40, 2417935.629122659920000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 63,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 1, new DateTime(2024, 5, 18, 9, 23, 48, 198, DateTimeKind.Unspecified).AddTicks(135), 1, 6668690.797371553800000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 64,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 57, new DateTime(2024, 5, 16, 19, 56, 16, 76, DateTimeKind.Unspecified).AddTicks(6487), 57, 3177481.804757932000000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 65,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 8, new DateTime(2024, 5, 17, 18, 45, 49, 298, DateTimeKind.Unspecified).AddTicks(9399), 41, 5610477.330024434400000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 66,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 90, new DateTime(2024, 5, 20, 14, 45, 41, 723, DateTimeKind.Unspecified).AddTicks(3331), 30, 5866529.722559310800000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 67,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 76, new DateTime(2024, 5, 29, 21, 47, 28, 756, DateTimeKind.Unspecified).AddTicks(6952), 60, 6260530.287528248640000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 68,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 15, new DateTime(2024, 5, 19, 2, 22, 53, 52, DateTimeKind.Unspecified).AddTicks(1829), 31, 6178989.647459611920000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 69,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 44, new DateTime(2024, 5, 8, 12, 38, 5, 454, DateTimeKind.Unspecified).AddTicks(2825), 8, 3972260.235922023360000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 70,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 6, new DateTime(2024, 5, 19, 17, 41, 43, 11, DateTimeKind.Unspecified).AddTicks(8326), 34, 2777023.959491575360000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 71,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 77, new DateTime(2024, 5, 2, 3, 46, 11, 572, DateTimeKind.Unspecified).AddTicks(9779), 18, 5496678.438610889640000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 72,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 97, new DateTime(2024, 5, 15, 4, 15, 36, 296, DateTimeKind.Unspecified).AddTicks(2984), 28, 3608380.66809986560000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 73,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 35, new DateTime(2024, 5, 6, 2, 3, 32, 863, DateTimeKind.Unspecified).AddTicks(7804), 66, 3982736.814839600440000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 74,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 76, new DateTime(2024, 5, 17, 23, 57, 29, 699, DateTimeKind.Unspecified).AddTicks(3576), 25, 4375943.647993774800000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 75,
                columns: new[] { "EmployeeID", "OrderDate", "TotalPrice" },
                values: new object[] { 10, new DateTime(2024, 5, 5, 9, 27, 24, 425, DateTimeKind.Unspecified).AddTicks(7247), 7351125.173828956800000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 76,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 89, new DateTime(2024, 5, 6, 3, 30, 53, 307, DateTimeKind.Unspecified).AddTicks(8338), 46, 2431783.623686739640000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 77,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 48, new DateTime(2024, 5, 28, 6, 16, 33, 46, DateTimeKind.Unspecified).AddTicks(4821), 36, 4328125.336400927040000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 78,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 21, new DateTime(2024, 5, 9, 12, 27, 20, 375, DateTimeKind.Unspecified).AddTicks(2452), 10, 2530596.961824341160000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 79,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 77, new DateTime(2024, 5, 19, 20, 20, 14, 862, DateTimeKind.Unspecified).AddTicks(9762), 27, 3136660.238860250560000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 80,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 14, new DateTime(2024, 5, 29, 23, 53, 0, 210, DateTimeKind.Unspecified).AddTicks(715), 23, 3544716.317362536000000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 81,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 49, new DateTime(2024, 5, 22, 10, 9, 13, 729, DateTimeKind.Unspecified).AddTicks(6867), 92, 7987871.521730310560000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 82,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 20, new DateTime(2024, 5, 3, 11, 1, 53, 593, DateTimeKind.Unspecified).AddTicks(3441), 15, 3400006.444509648600000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 83,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 51, new DateTime(2024, 5, 7, 18, 49, 51, 913, DateTimeKind.Unspecified).AddTicks(9153), 14, 2687815.193344528320000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 84,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 3, new DateTime(2024, 5, 29, 20, 28, 3, 538, DateTimeKind.Unspecified).AddTicks(5947), 17, 1806443.814989941920000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 85,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 53, new DateTime(2024, 5, 18, 18, 33, 11, 537, DateTimeKind.Unspecified).AddTicks(3487), 71, 5778967.909974225400000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 86,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 84, new DateTime(2024, 5, 28, 18, 24, 25, 790, DateTimeKind.Unspecified).AddTicks(6626), 23, 7795948.500229402920000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 87,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 28, new DateTime(2024, 5, 24, 7, 23, 23, 225, DateTimeKind.Unspecified).AddTicks(1818), 92, 4493355.82095708160000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 88,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 27, new DateTime(2024, 5, 2, 2, 26, 58, 345, DateTimeKind.Unspecified).AddTicks(1674), 15, 3320126.670369564480000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 89,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 57, new DateTime(2024, 5, 7, 15, 0, 34, 331, DateTimeKind.Unspecified).AddTicks(8120), 19, 2165393.667417570000000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 90,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 91, new DateTime(2024, 5, 17, 12, 20, 20, 839, DateTimeKind.Unspecified).AddTicks(8096), 9, 5679088.672991859000000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 91,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 80, new DateTime(2024, 5, 29, 20, 30, 35, 200, DateTimeKind.Unspecified).AddTicks(1734), 46, 6286666.209270010800000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 92,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 45, new DateTime(2024, 5, 8, 0, 0, 16, 508, DateTimeKind.Unspecified).AddTicks(8015), 63, 4170062.975788638960000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 93,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 74, new DateTime(2024, 5, 20, 15, 36, 57, 606, DateTimeKind.Unspecified).AddTicks(2375), 7, 2862968.98667525760000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 94,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 3, new DateTime(2024, 5, 20, 10, 0, 22, 285, DateTimeKind.Unspecified).AddTicks(3376), 48, 5743226.306495969280000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 95,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 28, new DateTime(2024, 5, 10, 9, 56, 37, 444, DateTimeKind.Unspecified).AddTicks(3801), 1, 3236766.521312452160000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 96,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 53, new DateTime(2024, 5, 17, 6, 3, 42, 639, DateTimeKind.Unspecified).AddTicks(751), 45, 8277305.671971026720000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 97,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 25, new DateTime(2024, 5, 15, 6, 45, 43, 476, DateTimeKind.Unspecified).AddTicks(2223), 57, 5541991.068292800360000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 98,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 74, new DateTime(2024, 5, 18, 7, 49, 48, 298, DateTimeKind.Unspecified).AddTicks(8572), 77, 7377962.061326272480000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 99,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 53, new DateTime(2024, 5, 28, 23, 19, 59, 760, DateTimeKind.Unspecified).AddTicks(7862), 99, 5655918.02587771680000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 100,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 71, new DateTime(2024, 5, 2, 1, 41, 53, 919, DateTimeKind.Unspecified).AddTicks(6005), 75, 7999449.379723170080000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 3, 23, 16, 41, 6, 184, DateTimeKind.Local).AddTicks(2676), 42303.508097224280000m, 66, 132241.291606892800000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 2,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 3, 23, 16, 41, 6, 184, DateTimeKind.Local).AddTicks(5382), 28506.08768774480000m, 131, 125620.927848374800000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 3,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 3, 23, 16, 41, 6, 184, DateTimeKind.Local).AddTicks(5405), 15585.307901765960000m, 62, 150142.193069695800000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 4,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 3, 23, 16, 41, 6, 184, DateTimeKind.Local).AddTicks(5413), 12684.8064956345920000m, 77, 179912.554751261900000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 5,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 3, 23, 16, 41, 6, 184, DateTimeKind.Local).AddTicks(5422), 23804.30923441560000m, 53, 166019.084048111500000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 6,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 3, 23, 16, 41, 6, 184, DateTimeKind.Local).AddTicks(5430), 11296.3826401911120000m, 114, 199469.324196765500000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 7,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 3, 23, 16, 41, 6, 184, DateTimeKind.Local).AddTicks(5438), 27302.443521340640000m, 118, 115610.668338365200000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 8,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 3, 23, 16, 41, 6, 184, DateTimeKind.Local).AddTicks(5446), 20285.572075097560000m, 89, 158860.3053659800000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 9,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 3, 23, 16, 41, 6, 184, DateTimeKind.Local).AddTicks(5454), 48665.735361213360000m, 117, 147425.932511251700000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 10,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 3, 23, 16, 41, 6, 184, DateTimeKind.Local).AddTicks(5462), 31752.838311112880000m, 123, 188538.277211412400000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 11,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 3, 23, 16, 41, 6, 184, DateTimeKind.Local).AddTicks(5470), 38943.785612323000000m, 97, 124686.753509806200000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 12,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 3, 23, 16, 41, 6, 184, DateTimeKind.Local).AddTicks(5478), 42750.893066735480000m, 63, 180278.904198016200000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 13,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 3, 23, 16, 41, 6, 184, DateTimeKind.Local).AddTicks(5485), 31824.753924724360000m, 139, 191099.024859295900000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 14,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 3, 23, 16, 41, 6, 184, DateTimeKind.Local).AddTicks(5493), 25276.508527109760000m, 63, 185137.774391541300000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 15,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 3, 23, 16, 41, 6, 184, DateTimeKind.Local).AddTicks(5501), 28018.129339980120000m, 115, 147275.57829378500000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 16,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 3, 23, 16, 41, 6, 184, DateTimeKind.Local).AddTicks(5509), 18552.032634340040000m, 36, 124820.330617497400000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 17,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 3, 23, 16, 41, 6, 184, DateTimeKind.Local).AddTicks(5517), 21360.649041562600000m, 99, 158713.297436490900000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 18,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 3, 23, 16, 41, 6, 184, DateTimeKind.Local).AddTicks(5524), 28189.362452908600000m, 111, 148286.047275262900000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 19,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 3, 23, 16, 41, 6, 184, DateTimeKind.Local).AddTicks(5531), 18372.464710156640000m, 139, 143851.493234387100000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 20,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 3, 23, 16, 41, 6, 184, DateTimeKind.Local).AddTicks(5540), 35718.469760871160000m, 94, 167882.90179925600000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 21,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 3, 23, 16, 41, 6, 184, DateTimeKind.Local).AddTicks(5555), 47808.125608409760000m, 89, 174495.898930734200000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 22,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 3, 23, 16, 41, 6, 184, DateTimeKind.Local).AddTicks(5564), 44542.919863338040000m, 96, 131173.929496302700000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 23,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 3, 23, 16, 41, 6, 184, DateTimeKind.Local).AddTicks(5573), 39686.431843489000000m, 79, 192555.90196653500000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 24,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 3, 23, 16, 41, 6, 184, DateTimeKind.Local).AddTicks(5581), 32542.519173625480000m, 107, 109623.0514237024300000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 25,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 3, 23, 16, 41, 6, 184, DateTimeKind.Local).AddTicks(5588), 39082.609434288720000m, 96, 172999.875019364400000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 26,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 3, 23, 16, 41, 6, 184, DateTimeKind.Local).AddTicks(5597), 29543.683841355280000m, 91, 101837.4089297075500000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 27,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 3, 23, 16, 41, 6, 184, DateTimeKind.Local).AddTicks(5606), 19170.921973614240000m, 84, 170029.154675533700000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 28,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 3, 23, 16, 41, 6, 184, DateTimeKind.Local).AddTicks(5614), 29998.902836275840000m, 36, 198654.447087908300000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 29,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 3, 23, 16, 41, 6, 184, DateTimeKind.Local).AddTicks(5622), 27550.393883550960000m, 90, 144219.571439588700000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 30,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 3, 23, 16, 41, 6, 184, DateTimeKind.Local).AddTicks(5631), 15033.696819087400000m, 140, 197740.783542299700000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 31,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 3, 23, 16, 41, 6, 184, DateTimeKind.Local).AddTicks(5640), 30861.059226808160000m, 115, 134835.978950475200000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 32,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 3, 23, 16, 41, 6, 184, DateTimeKind.Local).AddTicks(5648), 13670.693656817360000m, 114, 168301.621024446100000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 33,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 3, 23, 16, 41, 6, 184, DateTimeKind.Local).AddTicks(5656), 29081.962589477880000m, 33, 150530.026395409600000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 34,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 3, 23, 16, 41, 6, 184, DateTimeKind.Local).AddTicks(5664), 35593.581840765920000m, 31, 189872.009261875400000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 35,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 3, 23, 16, 41, 6, 184, DateTimeKind.Local).AddTicks(5672), 30146.899699036040000m, 78, 186572.115828365900000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 36,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 3, 23, 16, 41, 6, 184, DateTimeKind.Local).AddTicks(5680), 28810.91560257840000m, 45, 109078.1205499377800000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 37,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 3, 23, 16, 41, 6, 184, DateTimeKind.Local).AddTicks(5689), 44612.995857262440000m, 71, 134211.797448801900000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 38,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 3, 23, 16, 41, 6, 184, DateTimeKind.Local).AddTicks(5697), 41110.138520516200000m, 93, 154483.606039970600000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 39,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 3, 23, 16, 41, 6, 184, DateTimeKind.Local).AddTicks(5705), 45944.240390030720000m, 72, 122615.329438975700000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 40,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 3, 23, 16, 41, 6, 184, DateTimeKind.Local).AddTicks(5713), 15280.228264005080000m, 17, 123848.489269415900000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 41,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 3, 23, 16, 41, 6, 184, DateTimeKind.Local).AddTicks(5721), 42736.084506578600000m, 74, 146237.019754227400000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 42,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 3, 23, 16, 41, 6, 184, DateTimeKind.Local).AddTicks(5729), 11224.9692710084120000m, 109, 103169.5437202199900000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 43,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 3, 23, 16, 41, 6, 184, DateTimeKind.Local).AddTicks(5737), 13967.5318787496480000m, 114, 122722.078485566400000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 44,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 3, 23, 16, 41, 6, 184, DateTimeKind.Local).AddTicks(5745), 43102.653250016720000m, 124, 158963.940912524100000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 45,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 3, 23, 16, 41, 6, 184, DateTimeKind.Local).AddTicks(5753), 39765.766498926760000m, 102, 109578.347014057900000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 46,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 3, 23, 16, 41, 6, 184, DateTimeKind.Local).AddTicks(5761), 38040.153073147240000m, 142, 147269.329446573700000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 47,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 3, 23, 16, 41, 6, 184, DateTimeKind.Local).AddTicks(5769), 14563.465449256480000m, 137, 161711.177942141400000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 48,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 3, 23, 16, 41, 6, 184, DateTimeKind.Local).AddTicks(5777), 28130.536104639800000m, 90, 130231.295132508400000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 49,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 3, 23, 16, 41, 6, 184, DateTimeKind.Local).AddTicks(5785), 39950.795521422960000m, 69, 104657.6951304751900000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 50,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 3, 23, 16, 41, 6, 184, DateTimeKind.Local).AddTicks(5798), 47511.415950023120000m, 93, 154221.433549164500000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 51,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 3, 23, 16, 41, 6, 184, DateTimeKind.Local).AddTicks(5806), 18794.18336446120000m, 65, 181782.875261194200000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 52,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 3, 23, 16, 41, 6, 184, DateTimeKind.Local).AddTicks(5816), 30920.016559643560000m, 69, 170626.351048038600000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 53,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 3, 23, 16, 41, 6, 184, DateTimeKind.Local).AddTicks(5823), 30714.933973647920000m, 58, 150118.051828948400000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 54,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 3, 23, 16, 41, 6, 184, DateTimeKind.Local).AddTicks(5836), 40268.252010040360000m, 105, 108833.7571192149400000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 55,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 3, 23, 16, 41, 6, 184, DateTimeKind.Local).AddTicks(5844), 47240.900747988520000m, 108, 121464.398511470900000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 56,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 3, 23, 16, 41, 6, 184, DateTimeKind.Local).AddTicks(5853), 30977.349056497120000m, 28, 147921.958197856200000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 57,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 3, 23, 16, 41, 6, 184, DateTimeKind.Local).AddTicks(5862), 40606.190754991680000m, 131, 173248.261475337300000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 58,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 3, 23, 16, 41, 6, 184, DateTimeKind.Local).AddTicks(5869), 33110.964290726640000m, 74, 122768.448668631500000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 59,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 3, 23, 16, 41, 6, 184, DateTimeKind.Local).AddTicks(5877), 41869.820744379800000m, 78, 144428.239932748200000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 60,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 3, 23, 16, 41, 6, 184, DateTimeKind.Local).AddTicks(5885), 22695.983309053360000m, 58, 161003.907700527300000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 61,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 3, 23, 16, 41, 6, 184, DateTimeKind.Local).AddTicks(5893), 13510.9934276242440000m, 51, 199266.651657995700000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 62,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 3, 23, 16, 41, 6, 184, DateTimeKind.Local).AddTicks(5901), 16227.755900152080000m, 71, 137082.97686798400000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 63,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 3, 23, 16, 41, 6, 184, DateTimeKind.Local).AddTicks(5909), 36046.977283089480000m, 134, 139509.564986500600000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 64,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 3, 23, 16, 41, 6, 184, DateTimeKind.Local).AddTicks(5917), 18157.038884331040000m, 91, 159630.145633712900000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 65,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 3, 23, 16, 41, 6, 184, DateTimeKind.Local).AddTicks(5924), 43157.517923264880000m, 68, 187735.454067210400000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 66,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 3, 23, 16, 41, 6, 184, DateTimeKind.Local).AddTicks(5932), 37848.578855221360000m, 97, 139969.84904268800000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 67,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 3, 23, 16, 41, 6, 184, DateTimeKind.Local).AddTicks(5941), 33300.693018767280000m, 124, 115279.079548463700000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 68,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 3, 23, 16, 41, 6, 184, DateTimeKind.Local).AddTicks(5949), 42033.943179997360000m, 93, 153182.043208510800000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 69,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 3, 23, 16, 41, 6, 184, DateTimeKind.Local).AddTicks(5957), 35786.128251549760000m, 21, 184939.730011353900000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 70,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 3, 23, 16, 41, 6, 184, DateTimeKind.Local).AddTicks(5965), 26198.339240486560000m, 49, 153502.170520624800000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 71,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 3, 23, 16, 41, 6, 184, DateTimeKind.Local).AddTicks(5973), 43280.932587487320000m, 52, 196854.434315070800000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 72,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 3, 23, 16, 41, 6, 184, DateTimeKind.Local).AddTicks(5981), 22002.32114695040000m, 114, 186008.436874108300000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 73,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 3, 23, 16, 41, 6, 184, DateTimeKind.Local).AddTicks(5989), 33468.376595290760000m, 30, 159940.225627459300000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 74,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 3, 23, 16, 41, 6, 184, DateTimeKind.Local).AddTicks(5998), 32414.397392546480000m, 65, 107407.5535388442900000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 75,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 3, 23, 16, 41, 6, 184, DateTimeKind.Local).AddTicks(6006), 40839.584299049760000m, 104, 130604.184296018900000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 76,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 3, 23, 16, 41, 6, 184, DateTimeKind.Local).AddTicks(6014), 15489.067666794520000m, 83, 163825.26992157700000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 77,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 3, 23, 16, 41, 6, 184, DateTimeKind.Local).AddTicks(6022), 25762.650811910280000m, 93, 105175.0094337114400000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 78,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 3, 23, 16, 41, 6, 184, DateTimeKind.Local).AddTicks(6029), 15915.704162417240000m, 73, 182928.232122626500000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 79,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 3, 23, 16, 41, 6, 184, DateTimeKind.Local).AddTicks(6042), 19125.977066221040000m, 108, 162460.429861408500000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 80,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 3, 23, 16, 41, 6, 184, DateTimeKind.Local).AddTicks(6050), 35447.163173625360000m, 10, 138230.906844659300000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 81,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 3, 23, 16, 41, 6, 184, DateTimeKind.Local).AddTicks(6058), 40754.446539440360000m, 121, 129820.15314226100000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 82,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 3, 23, 16, 41, 6, 184, DateTimeKind.Local).AddTicks(6066), 20606.099663694840000m, 88, 115557.230466998800000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 83,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 3, 23, 16, 41, 6, 184, DateTimeKind.Local).AddTicks(6073), 15536.504007771840000m, 85, 192827.434270560800000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 84,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 3, 23, 16, 41, 6, 184, DateTimeKind.Local).AddTicks(6080), 16726.331620277240000m, 28, 102831.6031976655100000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 85,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 3, 23, 16, 41, 6, 184, DateTimeKind.Local).AddTicks(6087), 39854.951103270520000m, 62, 127227.14294376300000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 86,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 3, 23, 16, 41, 6, 184, DateTimeKind.Local).AddTicks(6095), 47827.904909382840000m, 95, 182123.518869835600000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 87,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 3, 23, 16, 41, 6, 184, DateTimeKind.Local).AddTicks(6103), 35104.34235122720000m, 59, 147504.783720697900000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 88,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 3, 23, 16, 41, 6, 184, DateTimeKind.Local).AddTicks(6110), 17850.143389083680000m, 120, 164326.198547623600000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 89,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 3, 23, 16, 41, 6, 184, DateTimeKind.Local).AddTicks(6118), 17323.149339340560000m, 53, 190557.562786955100000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 90,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 3, 23, 16, 41, 6, 184, DateTimeKind.Local).AddTicks(6125), 32085.246740067000000m, 89, 106422.3766075848100000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 91,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 3, 23, 16, 41, 6, 184, DateTimeKind.Local).AddTicks(6133), 43059.357597739800000m, 60, 194403.349583472500000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 92,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 3, 23, 16, 41, 6, 184, DateTimeKind.Local).AddTicks(6140), 36579.499787619640000m, 50, 105370.9294471350900000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 93,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 3, 23, 16, 41, 6, 184, DateTimeKind.Local).AddTicks(6147), 17041.48206354320000m, 102, 115113.242272370800000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 94,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 3, 23, 16, 41, 6, 184, DateTimeKind.Local).AddTicks(6155), 29912.637012999840000m, 106, 146462.484141249700000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 95,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 3, 23, 16, 41, 6, 184, DateTimeKind.Local).AddTicks(6163), 29695.105700114240000m, 52, 129324.950864853200000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 96,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 3, 23, 16, 41, 6, 184, DateTimeKind.Local).AddTicks(6170), 42666.524082324880000m, 141, 194451.732421982600000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 97,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 3, 23, 16, 41, 6, 184, DateTimeKind.Local).AddTicks(6178), 39304.901193565960000m, 72, 194560.586957744900000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 98,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 3, 23, 16, 41, 6, 184, DateTimeKind.Local).AddTicks(6185), 42895.128263524840000m, 99, 118564.779578957600000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 99,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 3, 23, 16, 41, 6, 184, DateTimeKind.Local).AddTicks(6194), 49613.31601647120000m, 58, 139125.403613556400000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 100,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 3, 23, 16, 41, 6, 184, DateTimeKind.Local).AddTicks(6202), 44940.726852377360000m, 110, 177936.7913005300000m });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 1,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Kiên Giang", new DateTime(2024, 3, 23, 16, 41, 6, 174, DateTimeKind.Local).AddTicks(7531), "KhanhHa.Truong@hotmail.com", "0984831895", "Xuân Liễu Lê" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 2,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Lai Châu", new DateTime(2024, 3, 23, 16, 41, 6, 174, DateTimeKind.Local).AddTicks(9212), "DucBao50@gmail.com", "0970665509", "Thanh Ngọc Trần" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 3,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Sóc Trăng", new DateTime(2024, 3, 23, 16, 41, 6, 174, DateTimeKind.Local).AddTicks(9317), "TaiDuc47@yahoo.com", "0904270223", "Xuân Dung Đỗ" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 4,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Hưng Yên", new DateTime(2024, 3, 23, 16, 41, 6, 174, DateTimeKind.Local).AddTicks(9391), "DieuHuong.Pham35@gmail.com", "0988730620", "Kim Thịnh Hồ" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 5,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Hòa Bình", new DateTime(2024, 3, 23, 16, 41, 6, 174, DateTimeKind.Local).AddTicks(9479), "QuynhHuong77@gmail.com", "0938226724", "Ngân Trúc Hoàng" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 6,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Thừa Thiên-Huế", new DateTime(2024, 3, 23, 16, 41, 6, 174, DateTimeKind.Local).AddTicks(9557), "HaiQuan34@yahoo.com", "0986530001", "Công Giang Đào" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 7,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Thanh Hoá", new DateTime(2024, 3, 23, 16, 41, 6, 174, DateTimeKind.Local).AddTicks(9622), "AnhTung_Dao@yahoo.com", "0945693962", "Trà Giang Lâm" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 8,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Yên Bái", new DateTime(2024, 3, 23, 16, 41, 6, 174, DateTimeKind.Local).AddTicks(9694), "HaiDuyen.Mai@yahoo.com", "0939746884", "Lan Ngọc Vương" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 9,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Kon Tum", new DateTime(2024, 3, 23, 16, 41, 6, 174, DateTimeKind.Local).AddTicks(9758), "TuongChinh.Vu@gmail.com", "0949540232", "Ðức Huy Dương" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 10,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Vĩnh Phúc", new DateTime(2024, 3, 23, 16, 41, 6, 174, DateTimeKind.Local).AddTicks(9827), "VietNga40@yahoo.com", "0985267675", "Sao Băng Trương" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 11,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Hà Nam", new DateTime(2024, 3, 23, 16, 41, 6, 174, DateTimeKind.Local).AddTicks(9890), "NhuKhang_Truong@gmail.com", "0957817449", "Thùy Oanh Hoàng" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 12,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Hà Giang", new DateTime(2024, 3, 23, 16, 41, 6, 174, DateTimeKind.Local).AddTicks(9963), "NguyetHong_Hoang@hotmail.com", "0958097069", "Quang Huy Tô" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 13,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Sơn La", new DateTime(2024, 3, 23, 16, 41, 6, 175, DateTimeKind.Local).AddTicks(34), "NhatHuy_Ly80@hotmail.com", "0979203704", "Kiều Trinh Dương" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 14,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Nam Định", new DateTime(2024, 3, 23, 16, 41, 6, 175, DateTimeKind.Local).AddTicks(110), "NgocThuan.Truong22@hotmail.com", "0962652172", "Hiền Mai Phạm" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 15,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Trà Vinh", new DateTime(2024, 3, 23, 16, 41, 6, 175, DateTimeKind.Local).AddTicks(185), "NhatMai80@yahoo.com", "0915135658", "Quang Vũ Dương" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 16,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Đắk Nông", new DateTime(2024, 3, 23, 16, 41, 6, 175, DateTimeKind.Local).AddTicks(253), "MinhKhang.Ha@gmail.com", "0966385755", "Nghi Minh Mai" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 17,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Hà Giang", new DateTime(2024, 3, 23, 16, 41, 6, 175, DateTimeKind.Local).AddTicks(323), "MinhGiang.Le@yahoo.com", "0985027419", "Cao Minh Ngô" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 18,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Cao Bằng", new DateTime(2024, 3, 23, 16, 41, 6, 175, DateTimeKind.Local).AddTicks(385), "HoaiBac.Duong@yahoo.com", "0979365414", "Huy Khiêm Mai" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 19,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Tiền Giang", new DateTime(2024, 3, 23, 16, 41, 6, 175, DateTimeKind.Local).AddTicks(453), "LucBinh.Do91@hotmail.com", "0949803662", "Bạch Quỳnh Phan" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 20,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Bình Định", new DateTime(2024, 3, 23, 16, 41, 6, 175, DateTimeKind.Local).AddTicks(517), "HaoNhi_Trinh92@gmail.com", "0996801747", "Lâm Ðồng Vương" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 21,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Quảng Trị", new DateTime(2024, 3, 23, 16, 41, 6, 175, DateTimeKind.Local).AddTicks(585), "ThongMinh0@hotmail.com", "0973979051", "Hiệp Hòa Đinh" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 22,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Khánh Hoà", new DateTime(2024, 3, 23, 16, 41, 6, 175, DateTimeKind.Local).AddTicks(653), "AnhHoang.Vuong14@gmail.com", "0995195506", "Thái Sơn Ngô" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 23,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Trà Vinh", new DateTime(2024, 3, 23, 16, 41, 6, 175, DateTimeKind.Local).AddTicks(728), "NhuNgoc51@gmail.com", "0910799636", "Như Trân Phạm" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 24,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Trà Vinh", new DateTime(2024, 3, 23, 16, 41, 6, 175, DateTimeKind.Local).AddTicks(795), "HuuLuong_Ho7@gmail.com", "0905642553", "Hồ Nam Đặng" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 25,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Hải Phòng", new DateTime(2024, 3, 23, 16, 41, 6, 175, DateTimeKind.Local).AddTicks(862), "HiepHao.Ha@hotmail.com", "0910839817", "Như Thảo Phùng" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 26,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Hải Dương", new DateTime(2024, 3, 23, 16, 41, 6, 175, DateTimeKind.Local).AddTicks(924), "BaoHuynh22@hotmail.com", "0923204332", "Bích Nhã Tô" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 27,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Nam Định", new DateTime(2024, 3, 23, 16, 41, 6, 175, DateTimeKind.Local).AddTicks(993), "ThaiMinh_Mai92@gmail.com", "0942283579", "Nguyễn Hải An Trương" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 28,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Lai Châu", new DateTime(2024, 3, 23, 16, 41, 6, 175, DateTimeKind.Local).AddTicks(1056), "LinhHa.Doan@gmail.com", "0918355908", "Thái Minh Vũ" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 29,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Hà Nam", new DateTime(2024, 3, 23, 16, 41, 6, 175, DateTimeKind.Local).AddTicks(1122), "VietTien_Trinh@hotmail.com", "0944248777", "Hồng Nhuận Mai" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 30,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Tiền Giang", new DateTime(2024, 3, 23, 16, 41, 6, 175, DateTimeKind.Local).AddTicks(1194), "ThuLinh_Do5@hotmail.com", "0953596085", "Lâm Ðồng Vương" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 31,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Đà Nẵng", new DateTime(2024, 3, 23, 16, 41, 6, 175, DateTimeKind.Local).AddTicks(1256), "BaoVan6@yahoo.com", "0930461586", "Tiểu Quỳnh Hồ" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 32,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "TP. Hồ Chí Minh", new DateTime(2024, 3, 23, 16, 41, 6, 175, DateTimeKind.Local).AddTicks(1322), "HuongBinh.Nguyen75@yahoo.com", "0943713456", "Duyên Nương Đặng" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 33,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Thái Bình", new DateTime(2024, 3, 23, 16, 41, 6, 175, DateTimeKind.Local).AddTicks(1392), "YenNhi91@yahoo.com", "0923603923", "Huy Lĩnh Hồ" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 34,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Hải Dương", new DateTime(2024, 3, 23, 16, 41, 6, 175, DateTimeKind.Local).AddTicks(1458), "NhanSam_Ho13@yahoo.com", "0900461985", "Thanh Hương Đặng" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 35,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Đắk Nông", new DateTime(2024, 3, 23, 16, 41, 6, 175, DateTimeKind.Local).AddTicks(1522), "ThanhThao.Dinh@gmail.com", "0965772473", "Thượng Nghị Đoàn" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 36,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Hưng Yên", new DateTime(2024, 3, 23, 16, 41, 6, 175, DateTimeKind.Local).AddTicks(1594), "YenMai.To@gmail.com", "0940211894", "Cao Nguyên Hoàng" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 37,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Lai Châu", new DateTime(2024, 3, 23, 16, 41, 6, 175, DateTimeKind.Local).AddTicks(1652), "ThiNgon52@yahoo.com", "0977543402", "Thiều Ly Đào" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 38,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Hòa Bình", new DateTime(2024, 3, 23, 16, 41, 6, 175, DateTimeKind.Local).AddTicks(1721), "ThanhKien78@yahoo.com", "0970588909", "Thu Vân Hà" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 39,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Quảng Ngãi", new DateTime(2024, 3, 23, 16, 41, 6, 175, DateTimeKind.Local).AddTicks(1783), "QuocTru68@yahoo.com", "0963809635", "Việt Hùng Đoàn" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 40,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Quảng Trị", new DateTime(2024, 3, 23, 16, 41, 6, 175, DateTimeKind.Local).AddTicks(1851), "TuanDung41@gmail.com", "0939231003", "Hồng Xuân Trần" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 41,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Bắc Giang", new DateTime(2024, 3, 23, 16, 41, 6, 175, DateTimeKind.Local).AddTicks(1919), "QuangHuu_Ngo99@yahoo.com", "0901286203", "Ðắc Thành Đoàn" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 42,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Điện Biên", new DateTime(2024, 3, 23, 16, 41, 6, 175, DateTimeKind.Local).AddTicks(1981), "MaiLinh.Phan@hotmail.com", "0942457582", "Thúy Hà Bùi" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 43,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "TP. Hồ Chí Minh", new DateTime(2024, 3, 23, 16, 41, 6, 175, DateTimeKind.Local).AddTicks(2056), "NhatMai_Vuong33@hotmail.com", "0978585948", "Quốc Thông Nguyễn" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 44,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Hà Tĩnh", new DateTime(2024, 3, 23, 16, 41, 6, 175, DateTimeKind.Local).AddTicks(2121), "MongThu_Lam@yahoo.com", "0950028387", "Tâm Nhi Vũ" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 45,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Hà Nam", new DateTime(2024, 3, 23, 16, 41, 6, 175, DateTimeKind.Local).AddTicks(2187), "MinhHieu_Dang54@yahoo.com", "0959993570", "Thu Nga Vương" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 46,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Lạng Sơn", new DateTime(2024, 3, 23, 16, 41, 6, 175, DateTimeKind.Local).AddTicks(2252), "QuocTruong79@yahoo.com", "0996286923", "Quỳnh Trang Vương" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 47,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "TP. Hồ Chí Minh", new DateTime(2024, 3, 23, 16, 41, 6, 175, DateTimeKind.Local).AddTicks(2319), "DanhNhan.Nguyen@hotmail.com", "0971839686", "Mỹ Xuân Đặng" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 48,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Bắc Giang", new DateTime(2024, 3, 23, 16, 41, 6, 175, DateTimeKind.Local).AddTicks(2382), "BichThu33@hotmail.com", "0971999594", "Xuân Trung Hoàng" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 49,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Bà Rịa-Vũng Tàu", new DateTime(2024, 3, 23, 16, 41, 6, 175, DateTimeKind.Local).AddTicks(2453), "HuongThao66@gmail.com", "0909267447", "Thiên Khánh Hồ" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 50,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Bạc Liêu", new DateTime(2024, 3, 23, 16, 41, 6, 175, DateTimeKind.Local).AddTicks(2524), "ThanhThe80@gmail.com", "0960812246", "Vương Việt Trương" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 51,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Bình Thuận", new DateTime(2024, 3, 23, 16, 41, 6, 175, DateTimeKind.Local).AddTicks(2587), "ThePhuong_Dinh@gmail.com", "0981525123", "Mai Khanh Trương" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 52,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Khánh Hoà", new DateTime(2024, 3, 23, 16, 41, 6, 175, DateTimeKind.Local).AddTicks(2658), "QuangVu19@hotmail.com", "0904994163", "Giáng Uyên Lê" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 53,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Quảng Bình", new DateTime(2024, 3, 23, 16, 41, 6, 175, DateTimeKind.Local).AddTicks(2719), "BichHao.Duong98@yahoo.com", "0978824690", "Vy Lam Lê" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 54,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Bắc Ninh", new DateTime(2024, 3, 23, 16, 41, 6, 175, DateTimeKind.Local).AddTicks(2787), "ThuHuyen.Lam@gmail.com", "0952752355", "Minh Quang Trương" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 55,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Bắc Giang", new DateTime(2024, 3, 23, 16, 41, 6, 175, DateTimeKind.Local).AddTicks(2856), "GiaNhi.Duong76@hotmail.com", "0984995945", "Tường Lân Lê" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 56,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Hà Nội", new DateTime(2024, 3, 23, 16, 41, 6, 175, DateTimeKind.Local).AddTicks(2928), "ThienLan6@hotmail.com", "0973655170", "Uyên Nhi Bùi" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 57,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Vĩnh Phúc", new DateTime(2024, 3, 23, 16, 41, 6, 175, DateTimeKind.Local).AddTicks(2988), "PhuongBich67@yahoo.com", "0960446772", "Hồng Thảo Tăng" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 58,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Lạng Sơn", new DateTime(2024, 3, 23, 16, 41, 6, 175, DateTimeKind.Local).AddTicks(3060), "TueMan.Dang36@hotmail.com", "0942085593", "Mỹ Trang Hoàng" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 59,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Bắc Kạn", new DateTime(2024, 3, 23, 16, 41, 6, 175, DateTimeKind.Local).AddTicks(3122), "SaoBang_Vuong22@gmail.com", "0930426556", "Khánh My Tô" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 60,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Hà Nam", new DateTime(2024, 3, 23, 16, 41, 6, 175, DateTimeKind.Local).AddTicks(3189), "QueAnh.Ngo@yahoo.com", "0956609497", "Ðắc Thái Lê" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 61,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Bắc Giang", new DateTime(2024, 3, 23, 16, 41, 6, 175, DateTimeKind.Local).AddTicks(3259), "NhatHung.Mai@gmail.com", "0967210204", "Liên Phương Phan" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 62,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Cà Mau", new DateTime(2024, 3, 23, 16, 41, 6, 175, DateTimeKind.Local).AddTicks(3322), "QuynhSa_Dinh89@gmail.com", "0951254603", "Thế Quyền Hồ" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 63,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Nam Định", new DateTime(2024, 3, 23, 16, 41, 6, 175, DateTimeKind.Local).AddTicks(3387), "LeNga29@gmail.com", "0961876398", "Linh Nhi Mai" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 64,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Bến Tre", new DateTime(2024, 3, 23, 16, 41, 6, 175, DateTimeKind.Local).AddTicks(3445), "HungCuong.Mai@hotmail.com", "0978455978", "Trường Vinh Ngô" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 65,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Bình Dương", new DateTime(2024, 3, 23, 16, 41, 6, 175, DateTimeKind.Local).AddTicks(3512), "KieuGiang_Phung86@gmail.com", "0975860302", "Túy Loan Vương" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 66,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Tây Ninh", new DateTime(2024, 3, 23, 16, 41, 6, 175, DateTimeKind.Local).AddTicks(3582), "ThanhThuy_Pham15@yahoo.com", "0908433682", "Phương Thùy Ngô" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 67,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Quảng Bình", new DateTime(2024, 3, 23, 16, 41, 6, 175, DateTimeKind.Local).AddTicks(3651), "ThanhTung3@hotmail.com", "0996347763", "Tường Vinh Vũ" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 68,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Cà Mau", new DateTime(2024, 3, 23, 16, 41, 6, 175, DateTimeKind.Local).AddTicks(3713), "DucAn_Bui20@gmail.com", "0957629558", "Ðình Chiểu Đoàn" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 69,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Hà Tĩnh", new DateTime(2024, 3, 23, 16, 41, 6, 175, DateTimeKind.Local).AddTicks(3785), "KimKhanh26@hotmail.com", "0935884239", "Hữu Ðịnh Trương" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 70,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Đồng Nai", new DateTime(2024, 3, 23, 16, 41, 6, 175, DateTimeKind.Local).AddTicks(3855), "BaoHuynh_Duong@gmail.com", "0911914498", "Kim Phượng Ngô" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 71,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Hậu Giang", new DateTime(2024, 3, 23, 16, 41, 6, 175, DateTimeKind.Local).AddTicks(3917), "TuyLoan83@yahoo.com", "0948366518", "Huệ An Vũ" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 72,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Khánh Hoà", new DateTime(2024, 3, 23, 16, 41, 6, 175, DateTimeKind.Local).AddTicks(3986), "ThanhThuy.Ngo1@gmail.com", "0994851013", "Cát Ly Phùng" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 73,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Kon Tum", new DateTime(2024, 3, 23, 16, 41, 6, 175, DateTimeKind.Local).AddTicks(4051), "HoangThu_Lam7@yahoo.com", "0903281715", "Tố Nhi Đinh" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 74,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Hà Tĩnh", new DateTime(2024, 3, 23, 16, 41, 6, 175, DateTimeKind.Local).AddTicks(4120), "DinhNam.Ngo98@gmail.com", "0900780427", "Hồng Minh Trần" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 75,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Sóc Trăng", new DateTime(2024, 3, 23, 16, 41, 6, 175, DateTimeKind.Local).AddTicks(4182), "ThanhTam.Dang@yahoo.com", "0961783129", "Thu Giang Hồ" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 76,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Bắc Kạn", new DateTime(2024, 3, 23, 16, 41, 6, 175, DateTimeKind.Local).AddTicks(4248), "TheVinh.Lam@yahoo.com", "0978901368", "Mộng Vy Lâm" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 77,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Cà Mau", new DateTime(2024, 3, 23, 16, 41, 6, 175, DateTimeKind.Local).AddTicks(4321), "TuyetXuan.Bui@hotmail.com", "0964659135", "Phú Bình Lý" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 78,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Ninh Bình", new DateTime(2024, 3, 23, 16, 41, 6, 175, DateTimeKind.Local).AddTicks(4395), "HaiLong_Vuong8@yahoo.com", "0973473010", "Mộng Lan Hà" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 79,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Kiên Giang", new DateTime(2024, 3, 23, 16, 41, 6, 175, DateTimeKind.Local).AddTicks(4458), "HanhThao81@hotmail.com", "0999893814", "Thiện Phước Tăng" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 80,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Ninh Bình", new DateTime(2024, 3, 23, 16, 41, 6, 175, DateTimeKind.Local).AddTicks(4523), "BaTung_Duong32@gmail.com", "0975555809", "Mộng Vân Trần" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 81,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "An Giang", new DateTime(2024, 3, 23, 16, 41, 6, 175, DateTimeKind.Local).AddTicks(4589), "TrongTan77@gmail.com", "0979454175", "Trung Hải Phùng" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 82,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Bình Thuận", new DateTime(2024, 3, 23, 16, 41, 6, 175, DateTimeKind.Local).AddTicks(4654), "CongAn53@hotmail.com", "0981872581", "Vạn Thắng Lý" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 83,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Quảng Ninh", new DateTime(2024, 3, 23, 16, 41, 6, 175, DateTimeKind.Local).AddTicks(4719), "DinhChuong31@hotmail.com", "0948645968", "Giang Thiên Đặng" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 84,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Nam Định", new DateTime(2024, 3, 23, 16, 41, 6, 175, DateTimeKind.Local).AddTicks(4781), "KimThao0@gmail.com", "0972749914", "Nhật Quang Dương" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 85,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Sơn La", new DateTime(2024, 3, 23, 16, 41, 6, 175, DateTimeKind.Local).AddTicks(4846), "HoaiTin48@gmail.com", "0913677676", "Ngọc Bích Hoàng" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 86,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Lâm Đồng", new DateTime(2024, 3, 23, 16, 41, 6, 175, DateTimeKind.Local).AddTicks(4906), "ThuyTam0@gmail.com", "0910583931", "Ðông Phong Ngô" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 87,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Hậu Giang", new DateTime(2024, 3, 23, 16, 41, 6, 175, DateTimeKind.Local).AddTicks(4976), "QuangDanh.Phan23@gmail.com", "0905103524", "Hương Thu Bùi" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 88,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Tây Ninh", new DateTime(2024, 3, 23, 16, 41, 6, 175, DateTimeKind.Local).AddTicks(5041), "TrucCuong_Phan@gmail.com", "0980539433", "Dạ Nguyệt Đặng" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 89,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Phú Thọ", new DateTime(2024, 3, 23, 16, 41, 6, 175, DateTimeKind.Local).AddTicks(5122), "TheTuong_Bui39@gmail.com", "0935958408", "Mộc Miên Đặng" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 90,
                columns: new[] { "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { new DateTime(2024, 3, 23, 16, 41, 6, 175, DateTimeKind.Local).AddTicks(5183), "NhuHao_Phan@gmail.com", "0928058063", "Nhật Dũng Mai" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 91,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Thái Nguyên", new DateTime(2024, 3, 23, 16, 41, 6, 175, DateTimeKind.Local).AddTicks(5250), "PhiNhung11@hotmail.com", "0930513283", "Tiến Ðức Đào" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 92,
                columns: new[] { "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { new DateTime(2024, 3, 23, 16, 41, 6, 175, DateTimeKind.Local).AddTicks(5319), "KhaiHoa_Ha@yahoo.com", "0951700249", "Xuân Bảo Phùng" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 93,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Quảng Nam", new DateTime(2024, 3, 23, 16, 41, 6, 175, DateTimeKind.Local).AddTicks(5377), "KhanhMinh_Tang59@gmail.com", "0955090857", "Tuấn Châu Hoàng" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 94,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Bình Thuận", new DateTime(2024, 3, 23, 16, 41, 6, 175, DateTimeKind.Local).AddTicks(5447), "NhatMai.Dao54@gmail.com", "0925412216", "Khánh Chi Hà" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 95,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Sơn La", new DateTime(2024, 3, 23, 16, 41, 6, 175, DateTimeKind.Local).AddTicks(5506), "HongTam.Vuong31@gmail.com", "0943806707", "Thanh Quang Mai" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 96,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Sóc Trăng", new DateTime(2024, 3, 23, 16, 41, 6, 175, DateTimeKind.Local).AddTicks(5574), "QuynhNgan.Tran@hotmail.com", "0944354928", "Mỹ Huyền Đặng" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 97,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Bình Dương", new DateTime(2024, 3, 23, 16, 41, 6, 175, DateTimeKind.Local).AddTicks(5637), "MyYen62@yahoo.com", "0926151671", "Bích Hạnh Hồ" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 98,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Thái Bình", new DateTime(2024, 3, 23, 16, 41, 6, 175, DateTimeKind.Local).AddTicks(5705), "PhiNhan_Truong@gmail.com", "0946154581", "Bữu Toại Hà" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 99,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Đồng Tháp", new DateTime(2024, 3, 23, 16, 41, 6, 175, DateTimeKind.Local).AddTicks(5766), "DiemPhuoc_Vuong@yahoo.com", "0910148646", "Phúc Khang Lâm" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 100,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Nam Định", new DateTime(2024, 3, 23, 16, 41, 6, 175, DateTimeKind.Local).AddTicks(5835), "PhucSinh.Trinh59@yahoo.com", "0904683268", "Thúy Loan Trương" });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 1,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 100, 21, new DateTime(2024, 5, 11, 16, 26, 4, 656, DateTimeKind.Unspecified).AddTicks(2764), 10579303.328551424000000m, 10579303.328551424000000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 2,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 56, 1, new DateTime(2024, 5, 20, 15, 23, 36, 608, DateTimeKind.Unspecified).AddTicks(1126), 6281046.392418740000000m, 6281046.392418740000000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 3,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 22, 83, new DateTime(2024, 5, 18, 19, 43, 2, 150, DateTimeKind.Unspecified).AddTicks(8403), 9609100.356460531200000m, 9609100.356460531200000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 4,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 63, 33, new DateTime(2024, 5, 3, 18, 10, 23, 315, DateTimeKind.Unspecified).AddTicks(1352), 15292567.153857261500000m, 15292567.153857261500000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 5,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 40, 1, new DateTime(2024, 5, 21, 22, 56, 27, 262, DateTimeKind.Unspecified).AddTicks(1214), 12949488.555752697000000m, 12949488.555752697000000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 6,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 58, 79, new DateTime(2024, 5, 21, 15, 18, 54, 566, DateTimeKind.Unspecified).AddTicks(7689), 16755423.232528302000000m, 16755423.232528302000000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 7,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 42, 88, new DateTime(2024, 5, 11, 12, 42, 2, 958, DateTimeKind.Unspecified).AddTicks(1698), 7861525.447008833600000m, 7861525.447008833600000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 8,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 72, 66, new DateTime(2024, 5, 26, 17, 13, 51, 714, DateTimeKind.Unspecified).AddTicks(9563), 8578456.4897629200000m, 8578456.4897629200000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 9,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 43, 1, new DateTime(2024, 5, 25, 20, 56, 33, 489, DateTimeKind.Unspecified).AddTicks(1763), 8550704.085652598600000m, 8550704.085652598600000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 10,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 12, 63, new DateTime(2024, 5, 8, 2, 36, 7, 934, DateTimeKind.Unspecified).AddTicks(6176), 13197679.404798868000000m, 13197679.404798868000000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 11,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 58, 15, new DateTime(2024, 5, 13, 17, 36, 7, 409, DateTimeKind.Unspecified).AddTicks(7307), 11221807.815882558000000m, 11221807.815882558000000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 12,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 79, 15, new DateTime(2024, 5, 19, 6, 9, 29, 2, DateTimeKind.Unspecified).AddTicks(1128), 13340638.910653198800000m, 13340638.910653198800000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 13,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 12, 2, new DateTime(2024, 5, 11, 10, 29, 13, 562, DateTimeKind.Unspecified).AddTicks(7288), 10510446.367261274500000m, 10510446.367261274500000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 14,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 100, 63, new DateTime(2024, 5, 9, 0, 21, 0, 762, DateTimeKind.Unspecified).AddTicks(103), 11478542.012275560600000m, 11478542.012275560600000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 15,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 89, 94, new DateTime(2024, 5, 10, 7, 50, 1, 45, DateTimeKind.Unspecified).AddTicks(1480), 8983810.27592088500000m, 8983810.27592088500000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 16,
                columns: new[] { "CustomerID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 43, new DateTime(2024, 5, 5, 3, 27, 57, 189, DateTimeKind.Unspecified).AddTicks(9172), 10734548.433104776400000m, 10734548.433104776400000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 17,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 44, 70, new DateTime(2024, 5, 6, 16, 22, 8, 836, DateTimeKind.Unspecified).AddTicks(2727), 12062210.605173308400000m, 12062210.605173308400000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 18,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 16, 74, new DateTime(2024, 5, 15, 8, 34, 33, 194, DateTimeKind.Unspecified).AddTicks(3814), 9045448.883791036900000m, 9045448.883791036900000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 19,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 88, 76, new DateTime(2024, 5, 9, 15, 13, 22, 583, DateTimeKind.Unspecified).AddTicks(7495), 8487238.100828838900000m, 8487238.100828838900000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 20,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 57, 41, new DateTime(2024, 5, 3, 10, 57, 9, 204, DateTimeKind.Unspecified).AddTicks(7377), 8394145.08996280000000m, 8394145.08996280000000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 21,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 90, 3, new DateTime(2024, 5, 26, 17, 36, 6, 673, DateTimeKind.Unspecified).AddTicks(2782), 10295258.036913317800000m, 10295258.036913317800000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 22,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 84, 9, new DateTime(2024, 5, 15, 8, 47, 2, 839, DateTimeKind.Unspecified).AddTicks(2927), 7739261.840281859300000m, 7739261.840281859300000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 23,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 36, 9, new DateTime(2024, 5, 12, 0, 13, 54, 750, DateTimeKind.Unspecified).AddTicks(1635), 16944919.37305508000000m, 16944919.37305508000000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 24,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 20, 30, new DateTime(2024, 5, 5, 15, 35, 47, 548, DateTimeKind.Unspecified).AddTicks(1164), 9866074.6281332187000000m, 9866074.6281332187000000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 25,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 35, 25, new DateTime(2024, 5, 18, 22, 58, 45, 841, DateTimeKind.Unspecified).AddTicks(8802), 10379992.501161864000000m, 10379992.501161864000000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 26,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 14, 73, new DateTime(2024, 5, 15, 21, 53, 56, 934, DateTimeKind.Unspecified).AddTicks(6094), 5906569.7179230379000000m, 5906569.7179230379000000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 27,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 92, 51, new DateTime(2024, 5, 12, 22, 17, 39, 902, DateTimeKind.Unspecified).AddTicks(3081), 8671486.888452218700000m, 8671486.888452218700000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 28,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 9, 16, new DateTime(2024, 5, 12, 6, 9, 15, 841, DateTimeKind.Unspecified).AddTicks(368), 13111193.507801947800000m, 13111193.507801947800000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 29,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 20, 30, new DateTime(2024, 5, 12, 6, 46, 26, 966, DateTimeKind.Unspecified).AddTicks(1844), 12547102.715244216900000m, 12547102.715244216900000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 30,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 43, 80, new DateTime(2024, 5, 28, 14, 19, 16, 524, DateTimeKind.Unspecified).AddTicks(2151), 10875743.094826483500000m, 10875743.094826483500000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 31,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 14, 24, new DateTime(2024, 5, 21, 21, 57, 37, 875, DateTimeKind.Unspecified).AddTicks(7324), 9977862.442335164800000m, 9977862.442335164800000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 32,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 70, 3, new DateTime(2024, 5, 12, 10, 39, 27, 733, DateTimeKind.Unspecified).AddTicks(766), 10098097.261466766000000m, 10098097.261466766000000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 33,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 63, 87, new DateTime(2024, 5, 28, 1, 3, 41, 574, DateTimeKind.Unspecified).AddTicks(375), 12493992.190818996800000m, 12493992.190818996800000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 34,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 37, 99, new DateTime(2024, 5, 11, 13, 21, 55, 662, DateTimeKind.Unspecified).AddTicks(8271), 13670784.666855028800000m, 13670784.666855028800000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 35,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 10, 5, new DateTime(2024, 5, 18, 18, 41, 47, 212, DateTimeKind.Unspecified).AddTicks(1152), 11754043.297187051700000m, 11754043.297187051700000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 36,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 67, 99, new DateTime(2024, 5, 18, 8, 35, 55, 71, DateTimeKind.Unspecified).AddTicks(6395), 7308234.0768458312600000m, 7308234.0768458312600000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 37,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 55, 69, new DateTime(2024, 5, 4, 6, 21, 26, 707, DateTimeKind.Unspecified).AddTicks(291), 9529037.618864934900000m, 9529037.618864934900000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 38,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 72, 76, new DateTime(2024, 5, 1, 8, 53, 16, 917, DateTimeKind.Unspecified).AddTicks(2859), 8651081.938238353600000m, 8651081.938238353600000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 39,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 29, 82, new DateTime(2024, 5, 3, 5, 20, 56, 53, DateTimeKind.Unspecified).AddTicks(8737), 6375997.130826736400000m, 6375997.130826736400000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 40,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 32, 1, new DateTime(2024, 5, 27, 14, 8, 18, 906, DateTimeKind.Unspecified).AddTicks(3678), 10527121.587900351500000m, 10527121.587900351500000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 41,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 11, 40, new DateTime(2024, 5, 28, 17, 48, 4, 612, DateTimeKind.Unspecified).AddTicks(5928), 11845198.600092419400000m, 11845198.600092419400000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 42,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 63, 30, new DateTime(2024, 5, 25, 7, 46, 45, 424, DateTimeKind.Unspecified).AddTicks(6487), 7118698.5166951793100000m, 7118698.5166951793100000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 43,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 7, 16, new DateTime(2024, 5, 20, 8, 8, 19, 590, DateTimeKind.Unspecified).AddTicks(2392), 8713267.572475214400000m, 8713267.572475214400000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 44,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 54, 66, new DateTime(2024, 5, 9, 15, 54, 48, 458, DateTimeKind.Unspecified).AddTicks(5337), 7948197.045626205000000m, 7948197.045626205000000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 45,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 27, 36, new DateTime(2024, 5, 8, 18, 55, 54, 775, DateTimeKind.Unspecified).AddTicks(783), 8766267.761124632000000m, 8766267.761124632000000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 46,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 12, 75, new DateTime(2024, 5, 16, 14, 17, 43, 513, DateTimeKind.Unspecified).AddTicks(7042), 7805274.460668406100000m, 7805274.460668406100000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 47,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 26, 43, new DateTime(2024, 5, 5, 21, 36, 31, 763, DateTimeKind.Unspecified).AddTicks(5217), 8570692.430933494200000m, 8570692.430933494200000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 48,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 81, 3, new DateTime(2024, 5, 10, 17, 24, 50, 328, DateTimeKind.Unspecified).AddTicks(8545), 7683646.412817995600000m, 7683646.412817995600000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 49,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 80, 1, new DateTime(2024, 5, 27, 10, 7, 14, 689, DateTimeKind.Unspecified).AddTicks(8249), 7221380.9640027881100000m, 7221380.9640027881100000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 50,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 37, 17, new DateTime(2024, 5, 10, 8, 42, 39, 279, DateTimeKind.Unspecified).AddTicks(1779), 9253286.012949870000000m, 9253286.012949870000000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 51,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 66, 7, new DateTime(2024, 5, 13, 1, 49, 23, 954, DateTimeKind.Unspecified).AddTicks(6857), 13451932.769328370800000m, 13451932.769328370800000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 52,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 94, 41, new DateTime(2024, 5, 24, 10, 28, 20, 329, DateTimeKind.Unspecified).AddTicks(8403), 9725702.009738200200000m, 9725702.009738200200000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 53,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 42, 88, new DateTime(2024, 5, 12, 13, 41, 6, 775, DateTimeKind.Unspecified).AddTicks(9028), 9157201.161565852400000m, 9157201.161565852400000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 54,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 47, 8, new DateTime(2024, 5, 22, 17, 31, 50, 584, DateTimeKind.Unspecified).AddTicks(7753), 6638859.1842721113400000m, 6638859.1842721113400000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 55,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 80, 11, new DateTime(2024, 5, 14, 8, 53, 55, 452, DateTimeKind.Unspecified).AddTicks(9548), 8988365.489848846600000m, 8988365.489848846600000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 56,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 78, 77, new DateTime(2024, 5, 1, 17, 3, 29, 207, DateTimeKind.Unspecified).AddTicks(4022), 11242068.823037071200000m, 11242068.823037071200000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 57,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 75, 20, new DateTime(2024, 5, 26, 17, 23, 7, 335, DateTimeKind.Unspecified).AddTicks(4258), 11954130.041798273700000m, 11954130.041798273700000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 58,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 25, 31, new DateTime(2024, 5, 12, 15, 35, 59, 495, DateTimeKind.Unspecified).AddTicks(7516), 7979949.163461047500000m, 7979949.163461047500000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 59,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 19, 96, new DateTime(2024, 5, 4, 2, 33, 59, 838, DateTimeKind.Unspecified).AddTicks(8972), 8521266.156032143800000m, 8521266.156032143800000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 60,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 55, 73, new DateTime(2024, 5, 19, 15, 0, 21, 658, DateTimeKind.Unspecified).AddTicks(2780), 9177222.738930056100000m, 9177222.738930056100000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 61,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 51, 18, new DateTime(2024, 5, 10, 9, 47, 34, 727, DateTimeKind.Unspecified).AddTicks(9216), 12155265.751137737700000m, 12155265.751137737700000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 62,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 90, 75, new DateTime(2024, 5, 24, 17, 2, 6, 565, DateTimeKind.Unspecified).AddTicks(7217), 10692472.19570275200000m, 10692472.19570275200000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 63,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 90, 77, new DateTime(2024, 5, 1, 15, 6, 1, 436, DateTimeKind.Unspecified).AddTicks(205), 7114987.814311530600000m, 7114987.814311530600000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 64,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 52, 10, new DateTime(2024, 5, 3, 4, 18, 6, 849, DateTimeKind.Unspecified).AddTicks(4967), 13408932.233231883600000m, 13408932.233231883600000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 65,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 10, 34, new DateTime(2024, 5, 25, 11, 59, 37, 97, DateTimeKind.Unspecified).AddTicks(6018), 11639598.152167044800000m, 11639598.152167044800000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 66,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 3, 15, new DateTime(2024, 5, 5, 22, 9, 9, 882, DateTimeKind.Unspecified).AddTicks(1696), 8118251.24447590400000m, 8118251.24447590400000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 67,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 7, 71, new DateTime(2024, 5, 2, 13, 23, 35, 196, DateTimeKind.Unspecified).AddTicks(5544), 7377861.091101676800000m, 7377861.091101676800000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 68,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 64, 2, new DateTime(2024, 5, 24, 1, 30, 59, 65, DateTimeKind.Unspecified).AddTicks(8438), 8271830.333259583200000m, 8271830.333259583200000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 69,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 53, 20, new DateTime(2024, 5, 6, 6, 38, 6, 210, DateTimeKind.Unspecified).AddTicks(4390), 16644575.701021851000000m, 16644575.701021851000000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 70,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 67, 52, new DateTime(2024, 5, 15, 11, 55, 37, 966, DateTimeKind.Unspecified).AddTicks(6283), 8749623.719675613600000m, 8749623.719675613600000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 71,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 83, 84, new DateTime(2024, 5, 25, 19, 39, 0, 964, DateTimeKind.Unspecified).AddTicks(6291), 14764082.573630310000000m, 14764082.573630310000000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 72,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 81, 32, new DateTime(2024, 5, 5, 9, 22, 53, 24, DateTimeKind.Unspecified).AddTicks(6614), 9300421.843705415000000m, 9300421.843705415000000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 73,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 53, 28, new DateTime(2024, 5, 2, 7, 14, 7, 815, DateTimeKind.Unspecified).AddTicks(3158), 14234680.080843877700000m, 14234680.080843877700000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 74,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 13, 57, new DateTime(2024, 5, 17, 14, 28, 54, 483, DateTimeKind.Unspecified).AddTicks(4126), 7518528.7477191003000000m, 7518528.7477191003000000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 75,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 86, 46, new DateTime(2024, 5, 6, 14, 12, 7, 335, DateTimeKind.Unspecified).AddTicks(4426), 9925918.006497436400000m, 9925918.006497436400000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 76,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 12, 25, new DateTime(2024, 5, 3, 12, 3, 47, 634, DateTimeKind.Unspecified).AddTicks(1193), 12123069.97419669800000m, 12123069.97419669800000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 77,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 55, 65, new DateTime(2024, 5, 9, 22, 15, 26, 787, DateTimeKind.Unspecified).AddTicks(3490), 7888125.7075283580000000m, 7888125.7075283580000000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 78,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 45, 10, new DateTime(2024, 5, 13, 18, 43, 59, 93, DateTimeKind.Unspecified).AddTicks(3602), 15731827.962545879000000m, 15731827.962545879000000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 79,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 59, 57, new DateTime(2024, 5, 11, 4, 3, 49, 125, DateTimeKind.Unspecified).AddTicks(6624), 9097784.072238876000000m, 9097784.072238876000000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 80,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 83, 53, new DateTime(2024, 5, 16, 23, 4, 32, 338, DateTimeKind.Unspecified).AddTicks(1781), 12440781.616019337000000m, 12440781.616019337000000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 81,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 59, 45, new DateTime(2024, 5, 11, 17, 33, 23, 40, DateTimeKind.Unspecified).AddTicks(5474), 9736511.48566957500000m, 9736511.48566957500000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 82,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 81, 37, new DateTime(2024, 5, 28, 17, 23, 42, 126, DateTimeKind.Unspecified).AddTicks(4376), 8897906.745958907600000m, 8897906.745958907600000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 83,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 61, 67, new DateTime(2024, 5, 21, 15, 41, 40, 20, DateTimeKind.Unspecified).AddTicks(2836), 16968814.215809350400000m, 16968814.215809350400000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 84,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 84, 31, new DateTime(2024, 5, 3, 8, 35, 23, 750, DateTimeKind.Unspecified).AddTicks(7749), 8226528.2558132408000000m, 8226528.2558132408000000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 85,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 91, 17, new DateTime(2024, 5, 2, 13, 22, 51, 934, DateTimeKind.Unspecified).AddTicks(1353), 10559852.86433232900000m, 10559852.86433232900000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 86,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 85, 81, new DateTime(2024, 5, 16, 9, 44, 57, 282, DateTimeKind.Unspecified).AddTicks(9513), 12384399.283148820800000m, 12384399.283148820800000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 87,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 98, 25, new DateTime(2024, 5, 1, 20, 19, 50, 908, DateTimeKind.Unspecified).AddTicks(4644), 10177830.076728155100000m, 10177830.076728155100000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 88,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 77, 98, new DateTime(2024, 5, 19, 12, 41, 39, 422, DateTimeKind.Unspecified).AddTicks(40), 10845529.104143157600000m, 10845529.104143157600000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 89,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 100, 52, new DateTime(2024, 5, 5, 11, 22, 52, 435, DateTimeKind.Unspecified).AddTicks(1846), 13720144.520660767200000m, 13720144.520660767200000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 90,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 46, 30, new DateTime(2024, 5, 9, 19, 5, 29, 22, DateTimeKind.Unspecified).AddTicks(9149), 9365169.1414674632800000m, 9365169.1414674632800000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 91,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 35, 88, new DateTime(2024, 5, 23, 0, 47, 1, 986, DateTimeKind.Unspecified).AddTicks(1076), 16718688.064178635000000m, 16718688.064178635000000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 92,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 63, 63, new DateTime(2024, 5, 29, 14, 20, 31, 101, DateTimeKind.Unspecified).AddTicks(5046), 6743739.4846166457600000m, 6743739.4846166457600000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 93,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 19, 40, new DateTime(2024, 5, 8, 7, 28, 1, 103, DateTimeKind.Unspecified).AddTicks(6331), 7597473.989976472800000m, 7597473.989976472800000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 94,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 48, 59, new DateTime(2024, 5, 23, 2, 46, 39, 957, DateTimeKind.Unspecified).AddTicks(701), 12595773.636147474200000m, 12595773.636147474200000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 95,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 63, 54, new DateTime(2024, 5, 29, 5, 5, 19, 518, DateTimeKind.Unspecified).AddTicks(1943), 7371522.199296632400000m, 7371522.199296632400000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 96,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 96, 25, new DateTime(2024, 5, 19, 21, 32, 41, 815, DateTimeKind.Unspecified).AddTicks(968), 10305941.818365077800000m, 10305941.818365077800000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 97,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 91, 78, new DateTime(2024, 5, 24, 8, 45, 33, 430, DateTimeKind.Unspecified).AddTicks(4520), 13424680.500084398100000m, 13424680.500084398100000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 98,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 36, 63, new DateTime(2024, 5, 28, 20, 28, 40, 284, DateTimeKind.Unspecified).AddTicks(2480), 8655228.909263904800000m, 8655228.909263904800000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 99,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 2, 17, new DateTime(2024, 5, 6, 0, 41, 45, 292, DateTimeKind.Unspecified).AddTicks(4936), 7791022.602359158400000m, 7791022.602359158400000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 100,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 94, 55, new DateTime(2024, 5, 8, 14, 52, 48, 260, DateTimeKind.Unspecified).AddTicks(1145), 12099701.8084360400000m, 12099701.8084360400000m });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 3, 1 },
                column: "Email",
                value: "TruongPhuc62@gmail.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 4, 1 },
                column: "Email",
                value: "KimThao.Trinh78@yahoo.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 9, 2 },
                column: "Email",
                value: "TuanHung.Tran5@hotmail.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 10, 2 },
                column: "Email",
                value: "DuyAn88@gmail.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 11, 1 },
                column: "Email",
                value: "LanTruc_Duong68@yahoo.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 12, 2 },
                column: "Email",
                value: "KhanhAn.Ly@hotmail.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 13, 2 },
                column: "Email",
                value: "KhanhHoa.Phan@yahoo.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 15, 2 },
                column: "Email",
                value: "VuongTrieu.Tang28@yahoo.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 18, 1 },
                column: "Email",
                value: "ThienMai.Ngo@yahoo.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 21, 1 },
                column: "Email",
                value: "ThienLan.Pham@hotmail.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 22, 1 },
                column: "Email",
                value: "DinhLoc.Dang85@hotmail.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 23, 2 },
                column: "Email",
                value: "AnhMinh64@hotmail.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 24, 2 },
                column: "Email",
                value: "MongThu90@gmail.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 25, 2 },
                column: "Email",
                value: "ThuyLieu35@gmail.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 26, 2 },
                column: "Email",
                value: "ThanhTin_Do@yahoo.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 27, 2 },
                column: "Email",
                value: "TienDung.Ho@hotmail.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 28, 1 },
                column: "Email",
                value: "HoaLy.Ly@hotmail.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 29, 1 },
                column: "Email",
                value: "NhanHong.Truong@yahoo.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 32, 1 },
                column: "Email",
                value: "TuanSi.Phung@yahoo.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 34, 1 },
                column: "Email",
                value: "NhaMai83@hotmail.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 35, 2 },
                column: "Email",
                value: "KhaiCa_Ngo89@gmail.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 36, 2 },
                column: "Email",
                value: "NgocTru_Mai67@yahoo.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 37, 2 },
                column: "Email",
                value: "ChiThanh0@yahoo.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 38, 1 },
                column: "Email",
                value: "PhuongNgoc_Duong36@yahoo.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 40, 2 },
                column: "Email",
                value: "KhietTam_Phung@hotmail.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 41, 2 },
                column: "Email",
                value: "TuongAnh18@gmail.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 43, 1 },
                column: "Email",
                value: "HuuThong23@yahoo.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 44, 1 },
                column: "Email",
                value: "ThanhThu33@yahoo.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 51, 2 },
                column: "Email",
                value: "NhaHuong_Vu@gmail.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 52, 2 },
                column: "Email",
                value: "LuongThien15@gmail.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 53, 2 },
                column: "Email",
                value: "YenThanh56@hotmail.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 54, 1 },
                column: "Email",
                value: "MaiLien.Ly53@hotmail.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 55, 1 },
                column: "Email",
                value: "LinhLan43@hotmail.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 60, 1 },
                column: "Email",
                value: "BichTram_Pham70@gmail.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 63, 1 },
                column: "Email",
                value: "BichHai85@gmail.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 65, 2 },
                column: "Email",
                value: "XuanMinh77@yahoo.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 67, 2 },
                column: "Email",
                value: "VuHong_Dao5@hotmail.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 68, 1 },
                column: "Email",
                value: "ThaiDuc.Phan9@yahoo.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 70, 1 },
                column: "Email",
                value: "QuynhLam_Ly41@gmail.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 72, 2 },
                column: "Email",
                value: "BichTram46@gmail.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 74, 1 },
                column: "Email",
                value: "ThanhHoa5@hotmail.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 75, 1 },
                column: "Email",
                value: "UyenMinh.Ly14@yahoo.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 76, 1 },
                column: "Email",
                value: "HangNga.Phung@yahoo.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 77, 1 },
                column: "Email",
                value: "HuuNghi.Tang@gmail.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 79, 2 },
                column: "Email",
                value: "HuyViet.Ha72@hotmail.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 80, 2 },
                column: "Email",
                value: "BaoThach.To68@hotmail.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 83, 1 },
                column: "Email",
                value: "DucPhi.Dao6@gmail.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 86, 1 },
                column: "Email",
                value: "NhanTu_Ngo66@hotmail.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 87, 2 },
                column: "Email",
                value: "HaiPhuong.Duong@hotmail.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 90, 1 },
                column: "Email",
                value: "VietHung.Tran95@yahoo.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 91, 1 },
                column: "Email",
                value: "TungAnh_Mai17@hotmail.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 93, 1 },
                column: "Email",
                value: "PhuongNhung_Phung@hotmail.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 94, 2 },
                column: "Email",
                value: "SuongSuong_Mai37@yahoo.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 97, 2 },
                column: "Email",
                value: "ThuSinh72@gmail.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 100, 1 },
                column: "Email",
                value: "TamDoan.Vuong@gmail.com");

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "EmployeeID", "RoleID", "Email", "LastLogin", "Lock", "Password" },
                values: new object[,]
                {
                    { 1, 2, "NgocTram61@yahoo.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 2, 1, "VietNhan_Ly57@gmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 5, 1, "TuongLan_To@yahoo.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 6, 1, "KimKhanh_Ngo37@yahoo.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 7, 2, "ChePhuong.Ly25@yahoo.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 8, 2, "DinhChieu52@hotmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 14, 1, "LienTran78@yahoo.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 16, 2, "VinhDieu_Vuong76@gmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 17, 1, "BaoLan_Tran@yahoo.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 19, 1, "BaoThach_Ngo47@gmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 20, 2, "HongNhan_Duong55@yahoo.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 30, 2, "LeQuyen_Tran54@gmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 31, 1, "UyenMy93@hotmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 33, 2, "BaoPhuong35@gmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 39, 1, "QuangTrieu.Tang@gmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 42, 1, "NgocQuang_Dao@gmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 45, 2, "SuongSuong8@hotmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 46, 1, "AnhThai.Ho@hotmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 47, 1, "BanMai.Mai42@hotmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 48, 1, "CongBang15@gmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 49, 1, "HuuChien_Phan@gmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 50, 2, "BaThien_Bui40@yahoo.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 56, 1, "MongLong.Vuong@yahoo.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 57, 2, "TrungKien.Lam@yahoo.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 58, 2, "NhaSuong_Dang65@yahoo.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 59, 2, "PhuongPhi34@hotmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 61, 1, "MinhAnh79@hotmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 62, 1, "TinhTam_Duong@gmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 64, 2, "NgocLinh_Phung52@gmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 66, 1, "QuangThach.Ngo71@yahoo.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 69, 1, "MinhHai.Truong84@gmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 71, 2, "KienDuc5@gmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 73, 1, "ThanhThien.Hoang71@gmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 78, 2, "BaoBinh17@hotmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 81, 1, "QuocViet_Ngo@gmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 82, 2, "NguyenBao_Tran@yahoo.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 84, 2, "MinhThu.Phung65@gmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 85, 1, "TrucLien_Ngo@hotmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 88, 2, "TuyetBang49@gmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 89, 1, "YenTrang87@gmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 92, 2, "XuanTam58@gmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 95, 1, "ThieuLy_Dang65@gmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 96, 1, "NgocCam.Ly85@gmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 98, 2, "TriHung.Vuong49@gmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 99, 1, "LamNgoc52@hotmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" }
                });

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "RoleID",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2024, 3, 23, 16, 41, 6, 171, DateTimeKind.Local).AddTicks(1267));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "RoleID",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2024, 3, 23, 16, 41, 6, 171, DateTimeKind.Local).AddTicks(1280));
        }
    }
}
