using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace QLCHWF.Migrations
{
    /// <inheritdoc />
    public partial class updatePrimaryKeyForUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_User",
                table: "User");

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
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 4, 1 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 5, 2 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 6, 1 });

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
                keyValues: new object[] { 17, 2 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 18, 2 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 19, 2 });

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
                keyValues: new object[] { 22, 2 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 23, 1 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 24, 1 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 25, 1 });

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
                keyValues: new object[] { 30, 1 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 31, 2 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 32, 2 });

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
                keyValues: new object[] { 39, 2 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 40, 1 });

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
                keyValues: new object[] { 43, 2 });

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
                keyValues: new object[] { 50, 2 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 51, 1 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 52, 1 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 53, 2 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 54, 2 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 55, 2 });

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
                keyValues: new object[] { 59, 1 });

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
                keyValues: new object[] { 62, 2 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 63, 1 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 64, 1 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 65, 1 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 66, 2 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 67, 2 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 68, 2 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 69, 2 });

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
                keyValues: new object[] { 72, 1 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 73, 2 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 74, 2 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 75, 2 });

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
                keyValues: new object[] { 78, 1 });

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
                keyValues: new object[] { 82, 2 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 83, 1 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 84, 1 });

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
                keyValues: new object[] { 87, 1 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 88, 1 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 89, 1 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 90, 2 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 91, 2 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 92, 1 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 93, 2 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 94, 1 });

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
                keyValues: new object[] { 98, 1 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 99, 1 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 100, 2 });

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

            migrationBuilder.AddPrimaryKey(
                name: "PK_User",
                table: "User",
                columns: new[] { "EmployeeID", "Email" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 1,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Đồng Tháp", "Nhật Hạ Phạm", new DateTime(2024, 5, 29, 22, 26, 26, 178, DateTimeKind.Local).AddTicks(9411), "VietQuyet81@yahoo.com", "0927697246" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 2,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Quảng Ninh", "Tịnh Lâm Đào", new DateTime(2024, 5, 29, 22, 26, 26, 179, DateTimeKind.Local).AddTicks(4684), "LamUyen88@yahoo.com", "0986573295" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 3,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Quảng Ninh", "Thiên Thảo Trương", new DateTime(2024, 5, 29, 22, 26, 26, 179, DateTimeKind.Local).AddTicks(4893), "ThuongKhang20@hotmail.com", "0989089962" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 4,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Hà Nam", "Mỹ Nhi Vương", new DateTime(2024, 5, 29, 22, 26, 26, 179, DateTimeKind.Local).AddTicks(5035), "QuocHanh.Dao@gmail.com", "0955226493" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 5,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Đồng Tháp", "Tuấn Chương Vũ", new DateTime(2024, 5, 29, 22, 26, 26, 179, DateTimeKind.Local).AddTicks(5174), "PhucTam.Trinh@gmail.com", "0973552033" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 6,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Tây Ninh", "Mai Anh Tô", new DateTime(2024, 5, 29, 22, 26, 26, 179, DateTimeKind.Local).AddTicks(5309), "ThuyLinh11@yahoo.com", "0918572256" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 7,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Bạc Liêu", "Bình Thuận Dương", new DateTime(2024, 5, 29, 22, 26, 26, 179, DateTimeKind.Local).AddTicks(5433), "TheAn.Ly51@yahoo.com", "0942595433" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 8,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "An Giang", "Thu Huyền Hoàng", new DateTime(2024, 5, 29, 22, 26, 26, 179, DateTimeKind.Local).AddTicks(5536), "PhuongQue_Nguyen@yahoo.com", "0939737392" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 9,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Lào Cai", "Bảo Phương Đinh", new DateTime(2024, 5, 29, 22, 26, 26, 179, DateTimeKind.Local).AddTicks(5672), "ThaiLam.Phung64@gmail.com", "0906528732" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 10,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Lạng Sơn", "Huy Hà Đoàn", new DateTime(2024, 5, 29, 22, 26, 26, 179, DateTimeKind.Local).AddTicks(5778), "DucNhan_Nguyen70@hotmail.com", "0923026371" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 11,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Đắk Lắk", "Hồng Oanh Nguyễn", new DateTime(2024, 5, 29, 22, 26, 26, 179, DateTimeKind.Local).AddTicks(5956), "PhuHung.Do73@gmail.com", "0946018019" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 12,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Vĩnh Long", "Trung Nguyên Trương", new DateTime(2024, 5, 29, 22, 26, 26, 179, DateTimeKind.Local).AddTicks(6077), "TuanMinh78@hotmail.com", "0921886916" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 13,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Bắc Ninh", "Nhật Quốc Nguyễn", new DateTime(2024, 5, 29, 22, 26, 26, 179, DateTimeKind.Local).AddTicks(6228), "MinhHuy_Pham99@hotmail.com", "0918118490" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 14,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Lào Cai", "Kiệt Võ Tô", new DateTime(2024, 5, 29, 22, 26, 26, 179, DateTimeKind.Local).AddTicks(6337), "HaiDuyen_Mai71@yahoo.com", "0993229164" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 15,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Nghệ An", "Ðắc Cường Lý", new DateTime(2024, 5, 29, 22, 26, 26, 179, DateTimeKind.Local).AddTicks(6475), "MaiKhanh_Phan3@hotmail.com", "0999275056" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 16,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Bà Rịa-Vũng Tàu", "Nhã Thanh Nguyễn", new DateTime(2024, 5, 29, 22, 26, 26, 179, DateTimeKind.Local).AddTicks(6805), "QuynhSa.Nguyen90@yahoo.com", "0942158580" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 17,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Sóc Trăng", "Hải Ðường Phan", new DateTime(2024, 5, 29, 22, 26, 26, 179, DateTimeKind.Local).AddTicks(7002), "LienHuong_Dinh68@hotmail.com", "0982103042" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 18,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Đà Nẵng", "Nghi Dung Tăng", new DateTime(2024, 5, 29, 22, 26, 26, 179, DateTimeKind.Local).AddTicks(7214), "GiaVinh_Lam98@hotmail.com", "0922490380" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 19,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Quảng Ninh", "Nhật Minh Đỗ", new DateTime(2024, 5, 29, 22, 26, 26, 179, DateTimeKind.Local).AddTicks(7384), "NhuBao_Lam3@yahoo.com", "0982850688" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 20,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Đà Nẵng", "Quỳnh Nhung Mai", new DateTime(2024, 5, 29, 22, 26, 26, 179, DateTimeKind.Local).AddTicks(7539), "TamNguyen30@yahoo.com", "0965278041" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 21,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Hà Nội", "Quang Thịnh Lý", new DateTime(2024, 5, 29, 22, 26, 26, 179, DateTimeKind.Local).AddTicks(7654), "TienVo.Ngo49@yahoo.com", "0922679977" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 22,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Yên Bái", "Nguyên Nhân Đoàn", new DateTime(2024, 5, 29, 22, 26, 26, 179, DateTimeKind.Local).AddTicks(7749), "ThieuBao72@yahoo.com", "0971733776" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 23,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Trà Vinh", "Thụy Nương Vũ", new DateTime(2024, 5, 29, 22, 26, 26, 179, DateTimeKind.Local).AddTicks(7846), "VietMi_Dao21@yahoo.com", "0942011287" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 24,
                columns: new[] { "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Hữu Cương Đỗ", new DateTime(2024, 5, 29, 22, 26, 26, 179, DateTimeKind.Local).AddTicks(7937), "HoaiBac_Hoang61@yahoo.com", "0908332372" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 25,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Bắc Ninh", "Mộng Nhi Hoàng", new DateTime(2024, 5, 29, 22, 26, 26, 179, DateTimeKind.Local).AddTicks(8036), "CatTuong_Trinh99@hotmail.com", "0970495932" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 26,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Bắc Giang", "Duy Tuyền Đặng", new DateTime(2024, 5, 29, 22, 26, 26, 179, DateTimeKind.Local).AddTicks(8137), "DuyThong_Vuong@hotmail.com", "0935778598" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 27,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Quảng Trị", "Xuân Vân Đoàn", new DateTime(2024, 5, 29, 22, 26, 26, 179, DateTimeKind.Local).AddTicks(8245), "ThanhMinh_Tang39@gmail.com", "0904955485" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 28,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Quảng Ngãi", "Thường Kiệt Phùng", new DateTime(2024, 5, 29, 22, 26, 26, 179, DateTimeKind.Local).AddTicks(8343), "CamHuong67@yahoo.com", "0997733353" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 29,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Trà Vinh", "Thảo Mai Vũ", new DateTime(2024, 5, 29, 22, 26, 26, 179, DateTimeKind.Local).AddTicks(8437), "MinhTan.Duong51@hotmail.com", "0949353253" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 30,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Ninh Thuận", "Hán Lâm Phùng", new DateTime(2024, 5, 29, 22, 26, 26, 179, DateTimeKind.Local).AddTicks(8533), "HongTruc.Dang@gmail.com", "0957611247" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 31,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Trà Vinh", "Quang Triệu Đặng", new DateTime(2024, 5, 29, 22, 26, 26, 179, DateTimeKind.Local).AddTicks(8839), "YenOanh.Dinh@hotmail.com", "0906219157" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 32,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Lạng Sơn", "Minh Ân Dương", new DateTime(2024, 5, 29, 22, 26, 26, 179, DateTimeKind.Local).AddTicks(8940), "ThanhHang.Doan@yahoo.com", "0924540621" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 33,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "An Giang", "Hương Thủy Đỗ", new DateTime(2024, 5, 29, 22, 26, 26, 179, DateTimeKind.Local).AddTicks(9033), "DiemQuynh77@yahoo.com", "0909461927" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 34,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Quảng Ninh", "Gia Cần Lê", new DateTime(2024, 5, 29, 22, 26, 26, 179, DateTimeKind.Local).AddTicks(9133), "MongThi_Ha74@yahoo.com", "0962897505" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 35,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Quảng Ngãi", "Hàm Ý Ngô", new DateTime(2024, 5, 29, 22, 26, 26, 179, DateTimeKind.Local).AddTicks(9221), "MinhSon30@hotmail.com", "0955095906" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 36,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Thái Bình", "Ðăng Khoa Đinh", new DateTime(2024, 5, 29, 22, 26, 26, 179, DateTimeKind.Local).AddTicks(9315), "KimXuan_Dang9@hotmail.com", "0959825480" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 37,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Đồng Tháp", "Hữu Lương Hà", new DateTime(2024, 5, 29, 22, 26, 26, 179, DateTimeKind.Local).AddTicks(9405), "TuyetAnh.Tran@hotmail.com", "0954812757" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 38,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Bình Phước", "Tùng Minh Vũ", new DateTime(2024, 5, 29, 22, 26, 26, 179, DateTimeKind.Local).AddTicks(9504), "MinhTue_Lam7@yahoo.com", "0992145029" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 39,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Cần Thơ", "Trung Dũng Phan", new DateTime(2024, 5, 29, 22, 26, 26, 179, DateTimeKind.Local).AddTicks(9590), "NhatHong.Ho@hotmail.com", "0913448503" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 40,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Thanh Hoá", "Ái Khanh Trương", new DateTime(2024, 5, 29, 22, 26, 26, 179, DateTimeKind.Local).AddTicks(9683), "ThuNga.To@hotmail.com", "0930560817" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 41,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Nghệ An", "Xuân Phúc Phùng", new DateTime(2024, 5, 29, 22, 26, 26, 179, DateTimeKind.Local).AddTicks(9801), "HoanChau.Dao51@yahoo.com", "0969764803" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 42,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Hà Nam", "Ðông Nguyên Trịnh", new DateTime(2024, 5, 29, 22, 26, 26, 179, DateTimeKind.Local).AddTicks(9888), "KienDuc.Ho@gmail.com", "0926466858" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 43,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Bắc Giang", "Thu Minh Hồ", new DateTime(2024, 5, 29, 22, 26, 26, 179, DateTimeKind.Local).AddTicks(9979), "KietHong.Bui@yahoo.com", "0928379459" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 44,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Kiên Giang", "Minh Thu Hà", new DateTime(2024, 5, 29, 22, 26, 26, 180, DateTimeKind.Local).AddTicks(65), "SonHa55@gmail.com", "0915015926" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 45,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Ninh Thuận", "Phước Sơn Hồ", new DateTime(2024, 5, 29, 22, 26, 26, 180, DateTimeKind.Local).AddTicks(159), "ThanhLoan91@hotmail.com", "0997065390" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 46,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Hưng Yên", "Thái Vân Đặng", new DateTime(2024, 5, 29, 22, 26, 26, 180, DateTimeKind.Local).AddTicks(246), "NamSon15@hotmail.com", "0949086395" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 47,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Hà Nam", "Tùng Lâm Vương", new DateTime(2024, 5, 29, 22, 26, 26, 180, DateTimeKind.Local).AddTicks(337), "NhatHoang9@yahoo.com", "0980645286" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 48,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Bình Định", "Tuấn Hoàng Trần", new DateTime(2024, 5, 29, 22, 26, 26, 180, DateTimeKind.Local).AddTicks(425), "GiaPhuoc.Le@gmail.com", "0902256890" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 49,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Hải Phòng", "Hồ Diệp Đỗ", new DateTime(2024, 5, 29, 22, 26, 26, 180, DateTimeKind.Local).AddTicks(517), "TuyetNhung36@hotmail.com", "0965905342" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 50,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Bắc Kạn", "Tuyết Vân Phan", new DateTime(2024, 5, 29, 22, 26, 26, 180, DateTimeKind.Local).AddTicks(607), "QuocVu_Duong88@gmail.com", "0985089851" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 51,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Quảng Ninh", "Minh Hạnh Đặng", new DateTime(2024, 5, 29, 22, 26, 26, 180, DateTimeKind.Local).AddTicks(717), "NghiLuc_Mai4@hotmail.com", "0904481397" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 52,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Bắc Ninh", "Quế Linh Phùng", new DateTime(2024, 5, 29, 22, 26, 26, 180, DateTimeKind.Local).AddTicks(806), "HuongChi_Trinh83@yahoo.com", "0971578120" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 53,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Bắc Giang", "Khánh Ngân Phạm", new DateTime(2024, 5, 29, 22, 26, 26, 180, DateTimeKind.Local).AddTicks(902), "KhanhLinh27@hotmail.com", "0943044651" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 54,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Lâm Đồng", "Bảo Ngọc Mai", new DateTime(2024, 5, 29, 22, 26, 26, 180, DateTimeKind.Local).AddTicks(995), "UyenThi37@yahoo.com", "0964438794" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 55,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Bà Rịa-Vũng Tàu", "Thái Nguyên Lâm", new DateTime(2024, 5, 29, 22, 26, 26, 180, DateTimeKind.Local).AddTicks(1083), "DanKhanh67@gmail.com", "0960616444" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 56,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Hậu Giang", "Hoàng Việt Vương", new DateTime(2024, 5, 29, 22, 26, 26, 180, DateTimeKind.Local).AddTicks(1180), "VietVo.Bui20@gmail.com", "0912454869" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 57,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Sóc Trăng", "Mộng Tuyền Trương", new DateTime(2024, 5, 29, 22, 26, 26, 180, DateTimeKind.Local).AddTicks(1265), "DucTam_Nguyen@hotmail.com", "0983659874" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 58,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Bạc Liêu", "Thanh Đan Đinh", new DateTime(2024, 5, 29, 22, 26, 26, 180, DateTimeKind.Local).AddTicks(1359), "XuanPhuong.Ngo@gmail.com", "0965838094" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 59,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Bình Thuận", "Lương Thiện Đặng", new DateTime(2024, 5, 29, 22, 26, 26, 180, DateTimeKind.Local).AddTicks(1452), "NhaY.Dao73@gmail.com", "0977644825" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 60,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Đắk Lắk", "Huệ Linh Lê", new DateTime(2024, 5, 29, 22, 26, 26, 180, DateTimeKind.Local).AddTicks(1587), "CatTien_Ngo@gmail.com", "0957198830" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 61,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Cao Bằng", "Duy Thắng Vũ", new DateTime(2024, 5, 29, 22, 26, 26, 180, DateTimeKind.Local).AddTicks(1694), "VietYen_Trinh7@hotmail.com", "0976220710" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 62,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Bình Định", "Tuấn Chương Phùng", new DateTime(2024, 5, 29, 22, 26, 26, 180, DateTimeKind.Local).AddTicks(1786), "ThanhPhong_Ngo@yahoo.com", "0918931526" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 63,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Đồng Tháp", "Dũng Việt Nguyễn", new DateTime(2024, 5, 29, 22, 26, 26, 180, DateTimeKind.Local).AddTicks(1873), "VietMi.Ho@yahoo.com", "0946338423" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 64,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Đồng Nai", "Ái Hồng Hà", new DateTime(2024, 5, 29, 22, 26, 26, 180, DateTimeKind.Local).AddTicks(1959), "ThaiHoa68@gmail.com", "0978406646" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 65,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Bắc Giang", "Nhật Nam Hoàng", new DateTime(2024, 5, 29, 22, 26, 26, 180, DateTimeKind.Local).AddTicks(2040), "DieuNuong11@hotmail.com", "0991430851" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 66,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Phú Thọ", "Huy Việt Tô", new DateTime(2024, 5, 29, 22, 26, 26, 180, DateTimeKind.Local).AddTicks(2134), "MinhTien.Dao@yahoo.com", "0972711130" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 67,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Vĩnh Long", "Mai Thanh Nguyễn", new DateTime(2024, 5, 29, 22, 26, 26, 180, DateTimeKind.Local).AddTicks(2225), "CongHoan.Ho42@hotmail.com", "0936776902" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 68,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Thái Bình", "Thanh Quang Ngô", new DateTime(2024, 5, 29, 22, 26, 26, 180, DateTimeKind.Local).AddTicks(2311), "MinhAn_Tran@hotmail.com", "0947542756" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 69,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Đồng Nai", "Từ Dung Hoàng", new DateTime(2024, 5, 29, 22, 26, 26, 180, DateTimeKind.Local).AddTicks(2400), "HongChau40@hotmail.com", "0999915902" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 70,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Vĩnh Long", "Kim Hoàng Lý", new DateTime(2024, 5, 29, 22, 26, 26, 180, DateTimeKind.Local).AddTicks(2486), "DaThao29@hotmail.com", "0970936179" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 71,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Hà Tĩnh", "Ðức Hải Hồ", new DateTime(2024, 5, 29, 22, 26, 26, 180, DateTimeKind.Local).AddTicks(2574), "HoaiThanh56@gmail.com", "0976948092" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 72,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Tuyên Quang", "Minh Hoàng Mai", new DateTime(2024, 5, 29, 22, 26, 26, 180, DateTimeKind.Local).AddTicks(2662), "HongSon_Ly65@yahoo.com", "0965261147" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 73,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Hải Phòng", "Diễm Kiều Vũ", new DateTime(2024, 5, 29, 22, 26, 26, 180, DateTimeKind.Local).AddTicks(2755), "DatHoa85@hotmail.com", "0927232473" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 74,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Hải Phòng", "Hạ Uyên Tô", new DateTime(2024, 5, 29, 22, 26, 26, 180, DateTimeKind.Local).AddTicks(2838), "HongLam.Phung34@gmail.com", "0954409566" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 75,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Quảng Ninh", "Hạnh Dung Trần", new DateTime(2024, 5, 29, 22, 26, 26, 180, DateTimeKind.Local).AddTicks(2930), "NhuThao51@hotmail.com", "0942340052" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 76,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Đắk Lắk", "Nhã Sương Tăng", new DateTime(2024, 5, 29, 22, 26, 26, 180, DateTimeKind.Local).AddTicks(3013), "DanLinh_Vu@hotmail.com", "0932009450" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 77,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Phú Yên", "Phương An Ngô", new DateTime(2024, 5, 29, 22, 26, 26, 180, DateTimeKind.Local).AddTicks(3105), "BichLoan.Dinh20@gmail.com", "0947732781" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 78,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Lạng Sơn", "Kiên Lâm Lâm", new DateTime(2024, 5, 29, 22, 26, 26, 180, DateTimeKind.Local).AddTicks(3198), "DaYen39@gmail.com", "0962463180" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 79,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Vĩnh Long", "Nhật Phương Ngô", new DateTime(2024, 5, 29, 22, 26, 26, 180, DateTimeKind.Local).AddTicks(3279), "ThuongKiet_Vu@yahoo.com", "0901887161" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 80,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Bà Rịa-Vũng Tàu", "Hiếu Học Dương", new DateTime(2024, 5, 29, 22, 26, 26, 180, DateTimeKind.Local).AddTicks(3369), "NamTu_Dinh@yahoo.com", "0972041933" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 81,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Cao Bằng", "Diệu Vân Hà", new DateTime(2024, 5, 29, 22, 26, 26, 180, DateTimeKind.Local).AddTicks(3455), "VanNhi_Trinh@yahoo.com", "0979800832" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 82,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Bình Thuận", "Chi Lan Hoàng", new DateTime(2024, 5, 29, 22, 26, 26, 180, DateTimeKind.Local).AddTicks(3545), "QuynhNhung_Dinh@hotmail.com", "0910181665" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 83,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Lạng Sơn", "Ðắc Thành Lý", new DateTime(2024, 5, 29, 22, 26, 26, 180, DateTimeKind.Local).AddTicks(3632), "AnLai.Vu@yahoo.com", "0904483847" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 84,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Trà Vinh", "Khang Kiện Tăng", new DateTime(2024, 5, 29, 22, 26, 26, 180, DateTimeKind.Local).AddTicks(3721), "HaPhuong91@gmail.com", "0991762169" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 85,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Tiền Giang", "Phương Phương Ngô", new DateTime(2024, 5, 29, 22, 26, 26, 180, DateTimeKind.Local).AddTicks(3808), "KimLy.Ho93@gmail.com", "0909844385" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 86,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Bình Phước", "Nguyệt Ánh Hà", new DateTime(2024, 5, 29, 22, 26, 26, 180, DateTimeKind.Local).AddTicks(3920), "HaiYen_Lam@hotmail.com", "0952131610" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 87,
                columns: new[] { "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Quế Chi Tăng", new DateTime(2024, 5, 29, 22, 26, 26, 180, DateTimeKind.Local).AddTicks(4001), "BuuToai.Vu63@hotmail.com", "0921185879" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 88,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Lâm Đồng", "Nguyên Sử Tăng", new DateTime(2024, 5, 29, 22, 26, 26, 180, DateTimeKind.Local).AddTicks(4092), "ChanHung.Truong@hotmail.com", "0958759046" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 89,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Khánh Hoà", "Mộng Vy Lý", new DateTime(2024, 5, 29, 22, 26, 26, 180, DateTimeKind.Local).AddTicks(4179), "ThanhHanh44@yahoo.com", "0927316679" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 90,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Tây Ninh", "Trọng Việt Lâm", new DateTime(2024, 5, 29, 22, 26, 26, 180, DateTimeKind.Local).AddTicks(4271), "LanAnh_Mai@hotmail.com", "0918652904" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 91,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Hòa Bình", "An Nam Tô", new DateTime(2024, 5, 29, 22, 26, 26, 180, DateTimeKind.Local).AddTicks(4376), "GiaHuy38@gmail.com", "0963085240" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 92,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Cần Thơ", "Ngọc Dung Tô", new DateTime(2024, 5, 29, 22, 26, 26, 180, DateTimeKind.Local).AddTicks(4489), "TamHanh_Truong47@yahoo.com", "0994121263" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 93,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Đắk Nông", "Trâm Oanh Hoàng", new DateTime(2024, 5, 29, 22, 26, 26, 180, DateTimeKind.Local).AddTicks(4588), "TrongViet86@gmail.com", "0936169516" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 94,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Kiên Giang", "Ân Thiện Nguyễn", new DateTime(2024, 5, 29, 22, 26, 26, 180, DateTimeKind.Local).AddTicks(4675), "TuanHai.Dang@yahoo.com", "0970309569" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 95,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Kiên Giang", "Bảo Lễ Đặng", new DateTime(2024, 5, 29, 22, 26, 26, 180, DateTimeKind.Local).AddTicks(4765), "AnhTu50@hotmail.com", "0977763709" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 96,
                columns: new[] { "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Hướng Bình Vũ", new DateTime(2024, 5, 29, 22, 26, 26, 180, DateTimeKind.Local).AddTicks(4848), "HaHai90@hotmail.com", "0964283713" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 97,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Đồng Nai", "Tâm Nguyệt Đào", new DateTime(2024, 5, 29, 22, 26, 26, 180, DateTimeKind.Local).AddTicks(4934), "VuongViet_Tang@hotmail.com", "0906131837" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 98,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Bình Định", "Cẩm Thúy Tô", new DateTime(2024, 5, 29, 22, 26, 26, 180, DateTimeKind.Local).AddTicks(5052), "PhiPhuong.Pham67@yahoo.com", "0928243009" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 99,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Quảng Trị", "Gia Phước Ngô", new DateTime(2024, 5, 29, 22, 26, 26, 180, DateTimeKind.Local).AddTicks(5147), "SyThuc3@hotmail.com", "0925357085" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 100,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Cao Bằng", "Tuyết Nga Trịnh", new DateTime(2024, 5, 29, 22, 26, 26, 180, DateTimeKind.Local).AddTicks(5229), "PhuongThi.Trinh@hotmail.com", "0937110876" });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 155, 43462.286300412880000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 2, 2 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 144, 11983.2145662830480000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 3, 3 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 197, 32361.512995723440000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 4, 4 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 102, 43136.444535381680000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 5, 5 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 195, 41848.756048733040000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 6, 6 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 100, 17960.926957940240000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 7, 7 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 101, 36411.545085221680000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 8, 8 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 107, 45611.038011047720000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 9, 9 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 115, 35638.997953539360000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 10, 10 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 195, 24816.379453981560000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 11, 11 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 134, 34410.868944884280000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 12, 12 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 167, 14538.697775824960000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 13, 13 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 197, 26271.955869205120000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 14, 14 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 107, 45553.894774596360000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 15, 15 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 105, 42094.880025557160000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 16, 16 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 161, 31477.140783812520000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 17, 17 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 109, 32046.415946578360000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 18, 18 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 154, 23504.9377246280000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 19, 19 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 187, 10989.5579537794280000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 20, 20 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 196, 28636.356012359960000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 21, 21 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 186, 40230.596927891680000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 22, 22 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 195, 36238.556228477520000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 23, 23 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 100, 48067.740311065240000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 24, 24 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 162, 34996.935460873720000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 25, 25 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 149, 41269.298754553400000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 26, 26 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 191, 28221.961960707640000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 27, 27 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 140, 25441.674758769680000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 28, 28 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 177, 31247.493807352840000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 29, 29 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 124, 10288.90680918920440000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 30, 30 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 139, 35610.296123468680000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 31, 31 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 109, 22345.039553844240000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 32, 32 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 120, 49869.304201166840000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 33, 33 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 167, 38786.334119583040000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 34, 34 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 101, 27069.85998773760000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 35, 35 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 108, 23043.233844477520000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 36, 36 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 137, 33846.877166832360000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 37, 37 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 101, 41302.723045990880000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 38, 38 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 125, 22662.860402696960000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 39, 39 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 148, 35790.972898075000000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 40, 40 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 163, 46681.418646007360000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 41, 41 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 150, 45935.142468803440000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 42, 42 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 103, 13726.2986788607560000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 43, 43 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 196, 36285.450131370840000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 44, 44 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 145, 18672.326554513080000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 45, 45 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 148, 14574.238450702280000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 46, 46 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 141, 12349.5737252193360000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 47, 47 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 108, 15987.765067262600000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 48, 48 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 161, 35704.185495541400000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 49, 49 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 200, 46603.659578767520000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 50, 50 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 150, 38879.706347310320000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 51, 51 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 160, 16382.626804214920000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 52, 52 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 151, 10440.0749378388960000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 53, 53 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 106, 19844.315064772360000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 54, 54 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 155, 39192.89247602360000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 55, 55 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 175, 27040.994667586600000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 56, 56 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 127, 17713.975940136120000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 57, 57 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 154, 12260.5063220893440000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 58, 58 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 143, 43604.35040852040000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 59, 59 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 177, 31871.309790023280000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 60, 60 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 156, 15538.810993692520000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 61, 61 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 125, 35279.379910184240000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 62, 62 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 127, 12773.6913152939520000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 63, 63 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 133, 17977.777198909880000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 64, 64 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 159, 23403.533125233080000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 65, 65 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 135, 20772.518675298200000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 66, 66 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 121, 43256.057096961080000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 67, 67 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 112, 14848.584816362240000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 68, 68 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 124, 44344.078011491680000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 69, 69 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 197, 47500.138379374040000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 70, 70 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 181, 40877.320404139360000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 71, 71 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 143, 46875.179054660560000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 72, 72 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 178, 49825.051170568960000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 73, 73 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 186, 10869.7497629618840000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 74, 74 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 199, 47497.588979787120000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 75, 75 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 153, 23121.278901915320000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 76, 76 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 102, 43865.459531882320000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 77, 77 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 109, 12417.7016610564120000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 78, 78 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 130, 34986.602241050360000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 79, 79 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 113, 17025.156976773160000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 80, 80 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 141, 21648.585089249440000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 81, 81 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 149, 18359.876782058600000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 82, 82 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 167, 18634.094000049680000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 83, 83 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 107, 30904.080463424720000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 84, 84 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 133, 25715.692956643760000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 85, 85 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 142, 37216.738176631520000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 86, 86 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 182, 24106.792214823920000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 87, 87 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 125, 43064.496230620480000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 88, 88 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 176, 31258.145109520480000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 89, 89 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 199, 48013.823153134840000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 90, 90 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 143, 17112.413481158960000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 91, 91 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 147, 28029.600013694040000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 92, 92 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 146, 15570.016804755840000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 93, 93 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 175, 18915.984588006240000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 94, 94 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 198, 35051.492979820240000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 95, 95 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 173, 46183.077061132240000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 96, 96 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 176, 34110.948704094520000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 97, 97 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 181, 25265.057170450240000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 98, 98 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 110, 35458.502009388360000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 99, 99 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 136, 15487.348352499400000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 100, 100 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 138, 47546.125955484720000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 51, 161588.240121142200000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 2, 2 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 52, 194089.088269654700000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 3, 3 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 66, 116941.229927290300000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 4, 4 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 55, 111995.685407253500000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 5, 5 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 62, 134422.649380086900000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 6, 6 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 77, 161884.463272325400000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 7, 7 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 87, 148962.642578036400000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 8, 8 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 60, 144399.177435640100000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 9, 9 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 85, 155778.640370364600000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 10, 10 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 65, 136282.441871425800000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 11, 11 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 66, 180469.511430212800000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 12, 12 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 70, 121695.879551015500000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 13, 13 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 74, 178877.122947984400000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 14, 14 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 76, 150772.060305014600000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 15, 15 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 62, 170705.0038750600000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 16, 16 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 57, 120039.087693857100000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 17, 17 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 53, 150718.257580190700000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 18, 18 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 70, 147769.851877279500000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 19, 19 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 53, 162903.249476683700000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 20, 20 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 59, 195993.269633939300000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 21, 21 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 51, 108017.8752860454400000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 22, 22 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 89, 139640.671564858300000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 23, 23 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 63, 101618.8762459156800000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 24, 24 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 89, 123490.120595083300000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 25, 25 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 76, 186987.102136880200000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 26, 26 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 64, 178884.12437046400000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 27, 27 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 64, 105055.3539756414100000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 28, 28 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 80, 181875.08216978100000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 29, 29 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 65, 131214.083296317300000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 30, 30 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 80, 153755.631801531800000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 31, 31 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 59, 163506.969249270700000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 32, 32 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 73, 196161.780984312200000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 33, 33 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 56, 175182.708228136600000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 34, 34 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 76, 105690.4952209611100000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 35, 35 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 61, 180798.829385875900000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 36, 36 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 88, 149267.494651474900000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 37, 37 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 81, 142071.04114846700000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 38, 38 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 59, 124396.748734356700000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 39, 39 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 62, 160163.513004728900000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 40, 40 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 90, 136428.227116574900000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 41, 41 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 65, 162528.673447550500000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 42, 42 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 52, 127269.285458849100000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 43, 43 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 65, 183718.36533839100000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 44, 44 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 58, 186864.662416185200000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 45, 45 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 70, 140796.226878763700000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 46, 46 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 55, 130406.760801560300000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 47, 47 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 81, 114222.756188239400000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 48, 48 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 88, 163431.182363128500000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 49, 49 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 81, 170960.767771704600000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 50, 50 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 62, 116270.421995714100000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 51, 51 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 86, 151326.377555770600000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 52, 52 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 84, 135005.709881337700000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 53, 53 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 59, 120037.603887862400000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 54, 54 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 64, 196260.376459703700000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 55, 55 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 78, 147221.867456120900000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 56, 56 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 88, 184651.550651447500000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 57, 57 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 76, 195995.515103314500000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 58, 58 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 77, 183210.895849335100000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 59, 59 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 75, 139060.519990244500000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 60, 60 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 71, 149907.136246720300000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 61, 61 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 51, 149158.526673911900000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 62, 62 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 58, 162616.782466322200000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 63, 63 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 81, 197588.227492402300000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 64, 64 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 76, 140491.975261377700000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 65, 65 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 78, 101719.9170809939800000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 66, 66 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 87, 132937.662575626100000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 67, 67 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 65, 103636.2481003618800000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 68, 68 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 76, 166701.909310615700000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 69, 69 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 76, 178508.327550430800000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 70, 70 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 64, 124651.331708721500000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 71, 71 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 55, 191872.666507444700000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 72, 72 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 56, 138758.232902547800000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 73, 73 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 63, 175005.417589452200000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 74, 74 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 54, 174230.021162287200000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 75, 75 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 88, 171830.565622241800000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 76, 76 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 51, 170258.841739699300000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 77, 77 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 55, 122777.809338407800000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 78, 78 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 79, 102737.6803464275500000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 79, 79 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 59, 180506.590150090600000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 80, 80 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 63, 170446.248293487800000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 81, 81 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 62, 154267.519182082800000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 82, 82 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 88, 118586.978205301500000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 83, 83 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 74, 168052.679929369300000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 84, 84 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 67, 180021.728495061900000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 85, 85 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 50, 163266.466332591600000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 86, 86 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 83, 187102.614963477900000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 87, 87 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 78, 165085.096283144800000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 88, 88 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 63, 123972.939722807700000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 89, 89 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 81, 192101.986599603600000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 90, 90 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 87, 138209.253407610100000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 91, 91 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 74, 199851.194167441600000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 92, 92 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 90, 167808.362959457800000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 93, 93 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 83, 110432.553919600300000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 94, 94 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 66, 117095.216122574900000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 95, 95 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 90, 140675.374666652300000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 96, 96 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 57, 167770.393956824200000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 97, 97 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 71, 109954.8927479404400000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 98, 98 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 71, 146764.580637061400000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 99, 99 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 63, 196295.017017625600000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 100, 100 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 52, 160362.608833238900000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 1,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Quảng Ngãi", new DateTime(2024, 5, 29, 22, 26, 26, 190, DateTimeKind.Local).AddTicks(3925), "ThuanHau58@gmail.com", "Thuận Phong Đỗ", "0904712540", 588803.260982500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 2,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Đà Nẵng", new DateTime(2024, 5, 29, 22, 26, 26, 190, DateTimeKind.Local).AddTicks(7337), "MinhHy38@gmail.com", "Liên Kiệt Trần", "0966529163", 540844.9309323510500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 3,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Kiên Giang", new DateTime(2024, 5, 29, 22, 26, 26, 190, DateTimeKind.Local).AddTicks(7546), "MinhNghia12@yahoo.com", "Nhật Hùng Nguyễn", "0909845652", 817605.264546772000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 4,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Đồng Nai", new DateTime(2024, 5, 29, 22, 26, 26, 190, DateTimeKind.Local).AddTicks(7618), "MinhQuang.Phan@yahoo.com", "Quốc Trường Nguyễn", "0941689603", 564486.41712108000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 5,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Khánh Hoà", new DateTime(2024, 5, 29, 22, 26, 26, 190, DateTimeKind.Local).AddTicks(7676), "TrungNguyen_Duong23@hotmail.com", "Tịnh Như Phùng", "0988689837", 542698.3285435789500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 6,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Quảng Ngãi", new DateTime(2024, 5, 29, 22, 26, 26, 190, DateTimeKind.Local).AddTicks(7737), "NguyetAnh.Ly18@gmail.com", "Xuân Kiên Phan", "0956841334", 994868.867057696500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 7,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Lai Châu", new DateTime(2024, 5, 29, 22, 26, 26, 190, DateTimeKind.Local).AddTicks(7793), "QuynhPhuong.Duong@gmail.com", "Ánh Trang Trịnh", "0923407949", 549170.5522023545500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 8,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Đà Nẵng", new DateTime(2024, 5, 29, 22, 26, 26, 190, DateTimeKind.Local).AddTicks(7846), "NhatPhuong_Duong@yahoo.com", "Nhã Khanh Tô", "0924469446", 586484.60651238500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 9,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Phú Yên", new DateTime(2024, 5, 29, 22, 26, 26, 190, DateTimeKind.Local).AddTicks(7905), "NhatLinh_Doan@gmail.com", "Mai Anh Hồ", "0921168507", 542507.5443893816500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 10,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Long An", new DateTime(2024, 5, 29, 22, 26, 26, 190, DateTimeKind.Local).AddTicks(7957), "SonTrang.Vuong@gmail.com", "Diệu Anh Đinh", "0921309486", 834988.987949044500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 11,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "TP. Hồ Chí Minh", new DateTime(2024, 5, 29, 22, 26, 26, 190, DateTimeKind.Local).AddTicks(8009), "BichChieu.Truong76@hotmail.com", "Xuân Bình Ngô", "0938400723", 652346.104195728000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 12,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Lai Châu", new DateTime(2024, 5, 29, 22, 26, 26, 190, DateTimeKind.Local).AddTicks(8069), "KhaiTam82@hotmail.com", "Tâm Nguyệt Dương", "0990851537", 672421.935086387500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 13,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Quảng Trị", new DateTime(2024, 5, 29, 22, 26, 26, 190, DateTimeKind.Local).AddTicks(8120), "HoaBinh_Truong5@yahoo.com", "Cao Tiến Tô", "0916883582", 684083.784355083000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 14,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Vĩnh Phúc", new DateTime(2024, 5, 29, 22, 26, 26, 190, DateTimeKind.Local).AddTicks(8171), "PhuongThuy_Vu97@hotmail.com", "Thu Hiền Phùng", "0974748225", 887494.761473219000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 15,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Trà Vinh", new DateTime(2024, 5, 29, 22, 26, 26, 190, DateTimeKind.Local).AddTicks(8229), "ThuyQuynh_Doan@gmail.com", "Bảo Thái Đặng", "0984258591", 899302.067633503500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 16,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Lạng Sơn", new DateTime(2024, 5, 29, 22, 26, 26, 190, DateTimeKind.Local).AddTicks(8279), "HongThuy.Bui@yahoo.com", "Hữu Ðạt Trịnh", "0966545325", 878819.748954063000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 17,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Phú Yên", new DateTime(2024, 5, 29, 22, 26, 26, 190, DateTimeKind.Local).AddTicks(8330), "DieuHoa.Pham@hotmail.com", "Ấu Lăng Hồ", "0917337923", 689343.775310866000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 18,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Sóc Trăng", new DateTime(2024, 5, 29, 22, 26, 26, 190, DateTimeKind.Local).AddTicks(8386), "LongVinh_Hoang72@yahoo.com", "Tuấn Kiệt Bùi", "0916413925", 661470.450754078000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 19,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Tiền Giang", new DateTime(2024, 5, 29, 22, 26, 26, 190, DateTimeKind.Local).AddTicks(8438), "MinhAn33@gmail.com", "Việt An Trần", "0937027625", 972907.647165432500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 20,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Quảng Nam", new DateTime(2024, 5, 29, 22, 26, 26, 190, DateTimeKind.Local).AddTicks(8500), "YenBang93@gmail.com", "Diễm Quỳnh Đỗ", "0917745354", 953027.274605949000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 21,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Hải Dương", new DateTime(2024, 5, 29, 22, 26, 26, 190, DateTimeKind.Local).AddTicks(8551), "ThienMai.To@hotmail.com", "Ngọc Khang Đoàn", "0969426511", 737171.110911471000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 22,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Quảng Nam", new DateTime(2024, 5, 29, 22, 26, 26, 190, DateTimeKind.Local).AddTicks(8603), "ThaoVan_Mai@gmail.com", "Thu Phương Đào", "0990731873", 551989.984000618000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 23,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Bình Thuận", new DateTime(2024, 5, 29, 22, 26, 26, 190, DateTimeKind.Local).AddTicks(8659), "MinhKhang_Tang88@gmail.com", "Phúc Lâm Dương", "0972471576", 958628.295807526000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 24,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Bắc Ninh", new DateTime(2024, 5, 29, 22, 26, 26, 190, DateTimeKind.Local).AddTicks(8711), "MongDiep.Nguyen95@gmail.com", "Phi Nhạn Phan", "0984854181", 946526.942713723500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 25,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Ninh Thuận", new DateTime(2024, 5, 29, 22, 26, 26, 190, DateTimeKind.Local).AddTicks(8763), "ThanhVy29@gmail.com", "Ðức Giang Hồ", "0906927983", 972724.529852022500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 26,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Đà Nẵng", new DateTime(2024, 5, 29, 22, 26, 26, 190, DateTimeKind.Local).AddTicks(8821), "GiaHung_Do48@yahoo.com", "Quốc Trường Trần", "0990748836", 837850.403128841000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 27,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Hà Nam", new DateTime(2024, 5, 29, 22, 26, 26, 190, DateTimeKind.Local).AddTicks(8874), "NhatBaoLong.Ly@hotmail.com", "Hải Mỹ Tăng", "0973499567", 516043.3517018783500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 28,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Sóc Trăng", new DateTime(2024, 5, 29, 22, 26, 26, 190, DateTimeKind.Local).AddTicks(8922), "HaGiang14@gmail.com", "Huy Thành Lê", "0978126402", 848505.911270318000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 29,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Quảng Trị", new DateTime(2024, 5, 29, 22, 26, 26, 190, DateTimeKind.Local).AddTicks(8979), "MyNgoc.Bui@gmail.com", "Huy Tường Phùng", "0977557437", 749818.3492473000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 30,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Đắk Lắk", new DateTime(2024, 5, 29, 22, 26, 26, 190, DateTimeKind.Local).AddTicks(9031), "DanThu.Dinh64@hotmail.com", "Dạ Thi Phạm", "0903582468", 518349.3811596835500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 31,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Kon Tum", new DateTime(2024, 5, 29, 22, 26, 26, 190, DateTimeKind.Local).AddTicks(9108), "PhucDuy_Ho19@hotmail.com", "Minh Phượng Lê", "0955841264", 930638.679232658000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 32,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Trà Vinh", new DateTime(2024, 5, 29, 22, 26, 26, 190, DateTimeKind.Local).AddTicks(9165), "DiepAnh14@gmail.com", "Nguyên Phong Vũ", "0977073892", 564797.804944362000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 33,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Quảng Nam", new DateTime(2024, 5, 29, 22, 26, 26, 190, DateTimeKind.Local).AddTicks(9216), "ThanhNha_Tang95@gmail.com", "Tường Vân Tăng", "0914891129", 816677.816004594000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 34,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Phú Yên", new DateTime(2024, 5, 29, 22, 26, 26, 190, DateTimeKind.Local).AddTicks(9278), "DucHuy19@gmail.com", "Thanh Xuân Đào", "0936803060", 552819.27666185500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 35,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Nghệ An", new DateTime(2024, 5, 29, 22, 26, 26, 190, DateTimeKind.Local).AddTicks(9329), "TuyetTam.Mai93@yahoo.com", "Hồng Thủy Hà", "0999385630", 729780.41248146000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 36,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "TP. Hồ Chí Minh", new DateTime(2024, 5, 29, 22, 26, 26, 190, DateTimeKind.Local).AddTicks(9378), "XuanThao52@hotmail.com", "Khắc Tuấn Bùi", "0967725203", 679276.499691005500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 37,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Bắc Giang", new DateTime(2024, 5, 29, 22, 26, 26, 190, DateTimeKind.Local).AddTicks(9437), "BichHa25@hotmail.com", "Thủy Trang Lâm", "0957407577", 660241.140030391500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 38,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Hà Giang", new DateTime(2024, 5, 29, 22, 26, 26, 190, DateTimeKind.Local).AddTicks(9490), "UyenNhi.Le26@yahoo.com", "Phúc Cường Đinh", "0918298137", 648400.7646694000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 39,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Tuyên Quang", new DateTime(2024, 5, 29, 22, 26, 26, 190, DateTimeKind.Local).AddTicks(9540), "HanhVi33@yahoo.com", "Duy Hiền Bùi", "0934700977", 834573.663271232500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 40,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Vĩnh Phúc", new DateTime(2024, 5, 29, 22, 26, 26, 190, DateTimeKind.Local).AddTicks(9597), "MaiAnh_Hoang3@hotmail.com", "Thế Doanh Trịnh", "0908254706", 795686.334292735500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 41,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Kiên Giang", new DateTime(2024, 5, 29, 22, 26, 26, 190, DateTimeKind.Local).AddTicks(9649), "BanMai82@hotmail.com", "Quốc Mạnh Lâm", "0994282882", 674645.034182181000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 42,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Tuyên Quang", new DateTime(2024, 5, 29, 22, 26, 26, 190, DateTimeKind.Local).AddTicks(9707), "AnhTuan95@hotmail.com", "Hòa Hợp Phùng", "0949337377", 693426.625214486500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 43,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Điện Biên", new DateTime(2024, 5, 29, 22, 26, 26, 190, DateTimeKind.Local).AddTicks(9758), "NgocDiep95@gmail.com", "Tiểu My Ngô", "0952552250", 645418.816300677500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 44,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Đồng Tháp", new DateTime(2024, 5, 29, 22, 26, 26, 190, DateTimeKind.Local).AddTicks(9812), "NguyetLan_Lam@hotmail.com", "Hải My Ngô", "0954318224", 528079.8305216426000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 45,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Vĩnh Long", new DateTime(2024, 5, 29, 22, 26, 26, 190, DateTimeKind.Local).AddTicks(9865), "HanhTuong.Phung@yahoo.com", "Hữu Vượng Tăng", "0975405618", 551518.272331074500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 46,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "An Giang", new DateTime(2024, 5, 29, 22, 26, 26, 190, DateTimeKind.Local).AddTicks(9919), "ThaoLinh_Trinh@yahoo.com", "Minh Danh Đào", "0904393361", 850203.159509251000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 47,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Bình Dương", new DateTime(2024, 5, 29, 22, 26, 26, 190, DateTimeKind.Local).AddTicks(9971), "HongThao24@gmail.com", "Mạnh Dũng Vương", "0967281910", 863167.30460730500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 48,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "An Giang", new DateTime(2024, 5, 29, 22, 26, 26, 191, DateTimeKind.Local).AddTicks(26), "ChinhTruc68@hotmail.com", "Quỳnh Giang Trịnh", "0976866657", 997209.813832215500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 49,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Đắk Nông", new DateTime(2024, 5, 29, 22, 26, 26, 191, DateTimeKind.Local).AddTicks(77), "HaiGiang.Doan@hotmail.com", "Thục Nhi Trịnh", "0982083050", 622683.242449857500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 50,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Điện Biên", new DateTime(2024, 5, 29, 22, 26, 26, 191, DateTimeKind.Local).AddTicks(128), "ThuMai.Dao@hotmail.com", "Thúy Vy Ngô", "0980555710", 927986.413791780500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 51,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Lâm Đồng", new DateTime(2024, 5, 29, 22, 26, 26, 191, DateTimeKind.Local).AddTicks(184), "HongQue.Ngo54@gmail.com", "Phú Ân Đoàn", "0932106587", 912221.599678924000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 52,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Đà Nẵng", new DateTime(2024, 5, 29, 22, 26, 26, 191, DateTimeKind.Local).AddTicks(236), "NgocLe.Phung66@yahoo.com", "Ðức Chính Đoàn", "0910348386", 862895.640057892500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 53,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Thái Nguyên", new DateTime(2024, 5, 29, 22, 26, 26, 191, DateTimeKind.Local).AddTicks(295), "MinhThang_Lam@hotmail.com", "Thiên Kim Đặng", "0928922955", 563173.88398632000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 54,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Hải Phòng", new DateTime(2024, 5, 29, 22, 26, 26, 191, DateTimeKind.Local).AddTicks(347), "SonTuyen.Tang63@hotmail.com", "Gia Huy Trịnh", "0984352682", 950516.498354206000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 55,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Đà Nẵng", new DateTime(2024, 5, 29, 22, 26, 26, 191, DateTimeKind.Local).AddTicks(396), "DucTuong_Vuong6@yahoo.com", "Phương Dung Đỗ", "0939435270", 631985.316936207000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 56,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Bình Phước", new DateTime(2024, 5, 29, 22, 26, 26, 191, DateTimeKind.Local).AddTicks(449), "HuyQuang95@gmail.com", "Hồng Liêm Đào", "0989171807", 775412.641075518000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 57,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Ninh Bình", new DateTime(2024, 5, 29, 22, 26, 26, 191, DateTimeKind.Local).AddTicks(502), "PhuongDung.Vu@gmail.com", "Thống Nhất Dương", "0968719498", 838567.24075713000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 58,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Bình Định", new DateTime(2024, 5, 29, 22, 26, 26, 191, DateTimeKind.Local).AddTicks(554), "LanHuong_Ngo@hotmail.com", "Lâm Nhi Mai", "0926039857", 632964.164160043000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 59,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Lai Châu", new DateTime(2024, 5, 29, 22, 26, 26, 191, DateTimeKind.Local).AddTicks(614), "BaoAnh96@yahoo.com", "Quốc Hoàng Đỗ", "0967964916", 575069.473167259000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 60,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Lào Cai", new DateTime(2024, 5, 29, 22, 26, 26, 191, DateTimeKind.Local).AddTicks(664), "CongHieu_Doan21@hotmail.com", "Công Thành Đào", "0940769117", 871562.673544712000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 61,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Sơn La", new DateTime(2024, 5, 29, 22, 26, 26, 191, DateTimeKind.Local).AddTicks(713), "TruongSa_Bui@yahoo.com", "Đan Linh Trịnh", "0990228155", 886313.382869246000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 62,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Kiên Giang", new DateTime(2024, 5, 29, 22, 26, 26, 191, DateTimeKind.Local).AddTicks(770), "VietAn.Nguyen16@yahoo.com", "Thanh Thu Đinh", "0952135649", 648255.176693248000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 63,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Khánh Hoà", new DateTime(2024, 5, 29, 22, 26, 26, 191, DateTimeKind.Local).AddTicks(821), "XuanHanh.Nguyen@yahoo.com", "Ánh Linh Nguyễn", "0922206164", 908614.00817349500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 64,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Cần Thơ", new DateTime(2024, 5, 29, 22, 26, 26, 191, DateTimeKind.Local).AddTicks(876), "DacDi27@gmail.com", "Như Bảo Nguyễn", "0927894812", 762930.263840903000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 65,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Sơn La", new DateTime(2024, 5, 29, 22, 26, 26, 191, DateTimeKind.Local).AddTicks(939), "HuuThong.Bui@gmail.com", "Danh Thành Vương", "0950963482", 849055.321565310500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 66,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Bình Thuận", new DateTime(2024, 5, 29, 22, 26, 26, 191, DateTimeKind.Local).AddTicks(991), "TuyetNhung66@hotmail.com", "Tiến Hiệp Phạm", "0927504873", 835829.474952346500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 67,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Tây Ninh", new DateTime(2024, 5, 29, 22, 26, 26, 191, DateTimeKind.Local).AddTicks(1045), "NguyetHong_Phan@hotmail.com", "Thanh Bình Nguyễn", "0928271932", 787766.357473279000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 68,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Nam Định", new DateTime(2024, 5, 29, 22, 26, 26, 191, DateTimeKind.Local).AddTicks(1096), "KimLy24@gmail.com", "Nguyệt Cầm Đinh", "0977086977", 551918.413358219000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 69,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Đà Nẵng", new DateTime(2024, 5, 29, 22, 26, 26, 191, DateTimeKind.Local).AddTicks(1145), "QuangLoc.Truong@gmail.com", "Bảo Trúc Tăng", "0913717294", 940542.945204126500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 70,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Tuyên Quang", new DateTime(2024, 5, 29, 22, 26, 26, 191, DateTimeKind.Local).AddTicks(1200), "NhatNam38@hotmail.com", "Hương Trà Lý", "0961627336", 895793.913171055500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 71,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Kiên Giang", new DateTime(2024, 5, 29, 22, 26, 26, 191, DateTimeKind.Local).AddTicks(1251), "DucTuan_Dinh@hotmail.com", "Cát Tiên Ngô", "0969453925", 744154.70483425500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 72,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Cà Mau", new DateTime(2024, 5, 29, 22, 26, 26, 191, DateTimeKind.Local).AddTicks(1301), "CamVan_Ho98@hotmail.com", "Minh Hằng Tô", "0914176526", 729957.929690161000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 73,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Bình Phước", new DateTime(2024, 5, 29, 22, 26, 26, 191, DateTimeKind.Local).AddTicks(1357), "KhaiCa_Tang64@gmail.com", "Thu Phương Trương", "0930724626", 959766.576262514000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 74,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Thái Nguyên", new DateTime(2024, 5, 29, 22, 26, 26, 191, DateTimeKind.Local).AddTicks(1452), "HaoNhien_Ly@yahoo.com", "Anh Thảo Tăng", "0944858519", 926578.924324077000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 75,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Quảng Nam", new DateTime(2024, 5, 29, 22, 26, 26, 191, DateTimeKind.Local).AddTicks(1518), "PhuongUyen10@hotmail.com", "Gia Thiện Vương", "0969723201", 677516.808210260500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 76,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Bình Phước", new DateTime(2024, 5, 29, 22, 26, 26, 191, DateTimeKind.Local).AddTicks(1570), "LamDung22@gmail.com", "Đoan Trang Đào", "0997310923", 793506.693528211000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 77,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Quảng Trị", new DateTime(2024, 5, 29, 22, 26, 26, 191, DateTimeKind.Local).AddTicks(1630), "DuyHoang_Dinh5@gmail.com", "Huy Phong Bùi", "0971078650", 779245.576043807500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 78,
                columns: new[] { "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { new DateTime(2024, 5, 29, 22, 26, 26, 191, DateTimeKind.Local).AddTicks(1686), "QuePhuong35@hotmail.com", "Huy Hà Trịnh", "0920444514", 580125.118546380500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 79,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Lào Cai", new DateTime(2024, 5, 29, 22, 26, 26, 191, DateTimeKind.Local).AddTicks(1738), "XuanYen26@hotmail.com", "Mỹ Huệ Vương", "0910955216", 618611.252577512000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 80,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Bà Rịa-Vũng Tàu", new DateTime(2024, 5, 29, 22, 26, 26, 191, DateTimeKind.Local).AddTicks(1789), "TuyetTrinh.Trinh@hotmail.com", "Thiên Phú Ngô", "0988263466", 675369.684136431000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 81,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Gia Lai", new DateTime(2024, 5, 29, 22, 26, 26, 191, DateTimeKind.Local).AddTicks(1850), "ThaoLinh_Phan@hotmail.com", "Việt Thắng Tăng", "0982814872", 582968.311472842000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 82,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Quảng Ninh", new DateTime(2024, 5, 29, 22, 26, 26, 191, DateTimeKind.Local).AddTicks(1900), "KimSa.Vuong17@yahoo.com", "Ngọc Huy Phùng", "0920568114", 806019.487462576500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 83,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Bà Rịa-Vũng Tàu", new DateTime(2024, 5, 29, 22, 26, 26, 191, DateTimeKind.Local).AddTicks(1948), "ThuLam_Phan39@gmail.com", "Hải Long Nguyễn", "0972981803", 741228.11035948500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 84,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Bình Thuận", new DateTime(2024, 5, 29, 22, 26, 26, 191, DateTimeKind.Local).AddTicks(2005), "AnhTai_Dang@yahoo.com", "Hàm Duyên Dương", "0952551814", 723440.908844861500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 85,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Trà Vinh", new DateTime(2024, 5, 29, 22, 26, 26, 191, DateTimeKind.Local).AddTicks(2055), "ThaoHuong1@yahoo.com", "Quốc Hạnh Phạm", "0988303638", 810000.191433396000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 86,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Bắc Kạn", new DateTime(2024, 5, 29, 22, 26, 26, 191, DateTimeKind.Local).AddTicks(2111), "TrucQuan.Truong19@gmail.com", "Anh Dũng Lâm", "0906790113", 771067.466933237500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 87,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Trà Vinh", new DateTime(2024, 5, 29, 22, 26, 26, 191, DateTimeKind.Local).AddTicks(2176), "QuangKhanh9@yahoo.com", "Thu Hồng Hà", "0951908489", 949487.292887629500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 88,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Gia Lai", new DateTime(2024, 5, 29, 22, 26, 26, 191, DateTimeKind.Local).AddTicks(2240), "ThuyHien27@gmail.com", "Lương Thiện Đào", "0913496633", 866664.964184942000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 89,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Vĩnh Phúc", new DateTime(2024, 5, 29, 22, 26, 26, 191, DateTimeKind.Local).AddTicks(2297), "TungLam_To75@hotmail.com", "Uy Phong Ngô", "0951814779", 749489.679030174000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 90,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Tây Ninh", new DateTime(2024, 5, 29, 22, 26, 26, 191, DateTimeKind.Local).AddTicks(2358), "KimThu_Do@yahoo.com", "Hải My Hồ", "0976392544", 672126.50367369500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 91,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Kon Tum", new DateTime(2024, 5, 29, 22, 26, 26, 191, DateTimeKind.Local).AddTicks(2426), "ThuSinh.Tran97@yahoo.com", "Hương Trang Lê", "0994832913", 995820.217284176000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 92,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Hà Nam", new DateTime(2024, 5, 29, 22, 26, 26, 191, DateTimeKind.Local).AddTicks(2498), "TienGiang_Le70@yahoo.com", "Như Tâm Đinh", "0960316845", 887230.873173828000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 93,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Vĩnh Long", new DateTime(2024, 5, 29, 22, 26, 26, 191, DateTimeKind.Local).AddTicks(2550), "MinhKhanh_Tran@yahoo.com", "Tịnh Tâm Tăng", "0940874350", 540774.7802530254000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 94,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Tây Ninh", new DateTime(2024, 5, 29, 22, 26, 26, 191, DateTimeKind.Local).AddTicks(2600), "CamHien.Tran11@gmail.com", "Tâm Ðoan Đào", "0912861086", 820463.910588672500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 95,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Cần Thơ", new DateTime(2024, 5, 29, 22, 26, 26, 191, DateTimeKind.Local).AddTicks(2654), "HongDao_To32@yahoo.com", "Giao Hưởng Đinh", "0917292012", 523378.727326524500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 96,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Hà Tĩnh", new DateTime(2024, 5, 29, 22, 26, 26, 191, DateTimeKind.Local).AddTicks(2705), "HaiChau79@gmail.com", "Liên Phương Trương", "0987902905", 504592.88360248544000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 97,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Thái Bình", new DateTime(2024, 5, 29, 22, 26, 26, 191, DateTimeKind.Local).AddTicks(2756), "MyPhuong.Ho49@yahoo.com", "Ðông Trà Trịnh", "0910942887", 946540.805809294000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 98,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Hòa Bình", new DateTime(2024, 5, 29, 22, 26, 26, 191, DateTimeKind.Local).AddTicks(2813), "MinhDat.Do@hotmail.com", "Phi Phi Ngô", "0939752848", 647125.887580107500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 99,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Đắk Nông", new DateTime(2024, 5, 29, 22, 26, 26, 191, DateTimeKind.Local).AddTicks(2876), "HuuHoang_Vuong86@gmail.com", "Lạc Phúc Đỗ", "0934953257", 711252.283928306000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 100,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Yên Bái", new DateTime(2024, 5, 29, 22, 26, 26, 191, DateTimeKind.Local).AddTicks(2931), "ThaiTam_Dao46@hotmail.com", "Tùng Lâm Trương", "0901802591", 778988.509893593500000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 1,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 12, new DateTime(2024, 5, 11, 4, 54, 43, 246, DateTimeKind.Unspecified).AddTicks(5592), 67, 6736654.376563996400000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 2,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 15, new DateTime(2024, 5, 6, 3, 52, 21, 926, DateTimeKind.Unspecified).AddTicks(828), 49, 1725582.8975447589120000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 3,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 98, new DateTime(2024, 5, 15, 12, 56, 1, 717, DateTimeKind.Unspecified).AddTicks(270), 91, 6375218.060157517680000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 4,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 46, new DateTime(2024, 5, 22, 12, 13, 11, 642, DateTimeKind.Unspecified).AddTicks(2667), 19, 4399917.342608931360000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 5,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 40, new DateTime(2024, 5, 11, 23, 17, 0, 162, DateTimeKind.Unspecified).AddTicks(3967), 83, 8160507.429502942800000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 6,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 99, new DateTime(2024, 5, 16, 12, 41, 46, 57, DateTimeKind.Unspecified).AddTicks(9196), 1, 1796092.695794024000000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 7,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 19, new DateTime(2024, 5, 9, 1, 51, 50, 512, DateTimeKind.Unspecified).AddTicks(7506), 7, 3677566.053607389680000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 8,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 73, new DateTime(2024, 5, 21, 3, 4, 5, 40, DateTimeKind.Unspecified).AddTicks(923), 4, 4880381.067182106040000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 9,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 96, new DateTime(2024, 5, 8, 1, 53, 52, 557, DateTimeKind.Unspecified).AddTicks(3976), 66, 4098484.764657026400000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 10,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 22, new DateTime(2024, 5, 15, 21, 50, 20, 679, DateTimeKind.Unspecified).AddTicks(7938), 96, 4839193.993526404200000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 11,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 27, new DateTime(2024, 5, 4, 18, 39, 2, 365, DateTimeKind.Unspecified).AddTicks(3372), 7, 4611056.438614493520000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 12,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 32, new DateTime(2024, 5, 17, 3, 0, 35, 617, DateTimeKind.Unspecified).AddTicks(5252), 65, 2427962.528562768320000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 13,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 78, new DateTime(2024, 5, 11, 19, 3, 17, 963, DateTimeKind.Unspecified).AddTicks(1069), 83, 5175575.306233408640000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 14,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 93, new DateTime(2024, 5, 14, 13, 7, 3, 338, DateTimeKind.Unspecified).AddTicks(7177), 24, 4874266.740881810520000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 15,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 95, new DateTime(2024, 5, 1, 21, 9, 55, 48, DateTimeKind.Unspecified).AddTicks(6274), 83, 4419962.402683501800000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 16,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 54, new DateTime(2024, 5, 1, 8, 8, 8, 956, DateTimeKind.Unspecified).AddTicks(50), 6, 5067819.666193815720000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 17,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 94, new DateTime(2024, 5, 22, 7, 49, 28, 616, DateTimeKind.Unspecified).AddTicks(5332), 64, 3493059.338177041240000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 18,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 12, new DateTime(2024, 5, 11, 12, 6, 50, 434, DateTimeKind.Unspecified).AddTicks(9040), 40, 3619760.4095927120000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 19,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 3, new DateTime(2024, 5, 1, 18, 10, 38, 21, DateTimeKind.Unspecified).AddTicks(2712), 7, 2055047.3373567530360000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 20,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 30, new DateTime(2024, 5, 2, 18, 25, 1, 133, DateTimeKind.Unspecified).AddTicks(8907), 10, 5612725.778422552160000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 21,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 74, new DateTime(2024, 5, 1, 12, 35, 59, 453, DateTimeKind.Unspecified).AddTicks(2827), 64, 7482891.028587852480000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 22,
                columns: new[] { "EmployeeID", "OrderDate", "TotalPrice" },
                values: new object[] { 69, new DateTime(2024, 5, 18, 2, 54, 2, 868, DateTimeKind.Unspecified).AddTicks(1805), 7066518.464553116400000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 23,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 64, new DateTime(2024, 5, 20, 17, 41, 17, 409, DateTimeKind.Unspecified).AddTicks(1715), 35, 4806774.031106524000000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 24,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 8, new DateTime(2024, 5, 10, 3, 19, 50, 342, DateTimeKind.Unspecified).AddTicks(8421), 15, 5669503.544661542640000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 25,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 81, new DateTime(2024, 5, 26, 2, 42, 53, 563, DateTimeKind.Unspecified).AddTicks(3272), 74, 6149125.514428456600000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 26,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 80, new DateTime(2024, 5, 4, 21, 10, 18, 971, DateTimeKind.Unspecified).AddTicks(7553), 9, 5390394.734495159240000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 27,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 50, new DateTime(2024, 5, 27, 7, 49, 53, 362, DateTimeKind.Unspecified).AddTicks(1699), 94, 3561834.466227755200000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 28,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 73, new DateTime(2024, 5, 12, 9, 48, 32, 184, DateTimeKind.Unspecified).AddTicks(5514), 82, 5530806.403901452680000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 29,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 32, new DateTime(2024, 5, 16, 12, 58, 58, 346, DateTimeKind.Unspecified).AddTicks(8140), 42, 1275824.44433946134560000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 30,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 41, new DateTime(2024, 5, 22, 22, 46, 53, 885, DateTimeKind.Unspecified).AddTicks(1059), 36, 4949831.161162146520000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 31,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 80, new DateTime(2024, 5, 26, 6, 39, 12, 180, DateTimeKind.Unspecified).AddTicks(9084), 31, 2435609.311369022160000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 32,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 7, new DateTime(2024, 5, 20, 13, 19, 18, 497, DateTimeKind.Unspecified).AddTicks(883), 24, 5984316.504140020800000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 33,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 50, new DateTime(2024, 5, 25, 17, 39, 12, 591, DateTimeKind.Unspecified).AddTicks(2902), 72, 6477317.797970367680000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 34,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 45, new DateTime(2024, 5, 5, 17, 28, 45, 23, DateTimeKind.Unspecified).AddTicks(5415), 13, 2734055.85876149760000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 35,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 15, new DateTime(2024, 5, 28, 14, 22, 55, 78, DateTimeKind.Unspecified).AddTicks(4770), 31, 2488669.255203572160000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 36,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 81, new DateTime(2024, 5, 18, 1, 29, 20, 567, DateTimeKind.Unspecified).AddTicks(5653), 45, 4637022.171856033320000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 37,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 8, new DateTime(2024, 5, 17, 1, 20, 43, 493, DateTimeKind.Unspecified).AddTicks(2396), 59, 4171575.027645078880000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 38,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 95, new DateTime(2024, 5, 23, 1, 29, 5, 27, DateTimeKind.Unspecified).AddTicks(3314), 17, 2832857.550337120000000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 39,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 13, new DateTime(2024, 5, 29, 23, 28, 49, 295, DateTimeKind.Unspecified).AddTicks(705), 85, 5297063.988915100000000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 40,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 64, new DateTime(2024, 5, 10, 3, 28, 59, 559, DateTimeKind.Unspecified).AddTicks(7984), 57, 7609071.239299199680000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 41,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 23, new DateTime(2024, 5, 14, 17, 36, 37, 408, DateTimeKind.Unspecified).AddTicks(9694), 68, 6890271.370320516000000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 42,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 37, new DateTime(2024, 5, 26, 22, 21, 2, 710, DateTimeKind.Unspecified).AddTicks(8183), 32, 1413808.7639226578680000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 43,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 23, new DateTime(2024, 5, 15, 16, 18, 16, 824, DateTimeKind.Unspecified).AddTicks(8673), 8, 7111948.225748684640000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 44,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 88, new DateTime(2024, 5, 29, 10, 41, 49, 414, DateTimeKind.Unspecified).AddTicks(3426), 17, 2707487.350404396600000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 45,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 6, new DateTime(2024, 5, 11, 2, 30, 43, 148, DateTimeKind.Unspecified).AddTicks(5815), 11, 2156987.290703937440000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 46,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 4, new DateTime(2024, 5, 18, 13, 59, 14, 162, DateTimeKind.Unspecified).AddTicks(5411), 40, 1741289.8952559263760000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 47,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 69, new DateTime(2024, 5, 6, 4, 11, 8, 276, DateTimeKind.Unspecified).AddTicks(719), 57, 1726678.627264360800000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 48,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 72, new DateTime(2024, 5, 4, 9, 58, 32, 164, DateTimeKind.Unspecified).AddTicks(4913), 32, 5748373.864782165400000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 49,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 36, new DateTime(2024, 5, 29, 19, 29, 59, 621, DateTimeKind.Unspecified).AddTicks(9451), 21, 9320731.915753504000000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 50,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 41, new DateTime(2024, 5, 8, 4, 5, 12, 511, DateTimeKind.Unspecified).AddTicks(7242), 44, 5831955.952096548000000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 51,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 30, new DateTime(2024, 5, 22, 0, 31, 25, 718, DateTimeKind.Unspecified).AddTicks(9574), 76, 2621220.288674387200000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 52,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 6, new DateTime(2024, 5, 13, 9, 26, 28, 905, DateTimeKind.Unspecified).AddTicks(9529), 79, 1576451.3156136732960000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 53,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 58, new DateTime(2024, 5, 17, 22, 15, 13, 272, DateTimeKind.Unspecified).AddTicks(2693), 96, 2103497.396865870160000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 54,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 57, new DateTime(2024, 5, 10, 6, 58, 33, 885, DateTimeKind.Unspecified).AddTicks(4466), 62, 6074898.33378365800000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 55,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 41, new DateTime(2024, 5, 8, 4, 35, 40, 823, DateTimeKind.Unspecified).AddTicks(146), 95, 4732174.066827655000000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 56,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 83, new DateTime(2024, 5, 27, 16, 18, 55, 540, DateTimeKind.Unspecified).AddTicks(5240), 71, 2249674.944397287240000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 57,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 10, new DateTime(2024, 5, 7, 6, 27, 4, 77, DateTimeKind.Unspecified).AddTicks(7292), 30, 1888117.9736017589760000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 58,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 17, new DateTime(2024, 5, 1, 23, 11, 57, 389, DateTimeKind.Unspecified).AddTicks(541), 31, 6235422.10841841720000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 59,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 79, new DateTime(2024, 5, 5, 18, 3, 15, 883, DateTimeKind.Unspecified).AddTicks(4536), 32, 5641221.832834120560000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 60,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 24, new DateTime(2024, 5, 22, 19, 10, 33, 339, DateTimeKind.Unspecified).AddTicks(6238), 18, 2424054.515016033120000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 61,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 32, new DateTime(2024, 5, 26, 2, 39, 59, 736, DateTimeKind.Unspecified).AddTicks(1061), 33, 4409922.488773030000000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 62,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 39, new DateTime(2024, 5, 18, 0, 36, 51, 701, DateTimeKind.Unspecified).AddTicks(1468), 58, 1622258.7970423319040000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 63,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 5, new DateTime(2024, 5, 25, 2, 54, 26, 491, DateTimeKind.Unspecified).AddTicks(3959), 78, 2391044.367455014040000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 64,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 75, new DateTime(2024, 5, 9, 21, 26, 11, 547, DateTimeKind.Unspecified).AddTicks(2968), 16, 3721161.766912059720000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 65,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 77, new DateTime(2024, 5, 19, 9, 48, 51, 413, DateTimeKind.Unspecified).AddTicks(7307), 25, 2804290.021165257000000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 66,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 99, new DateTime(2024, 5, 20, 22, 39, 15, 661, DateTimeKind.Unspecified).AddTicks(9464), 67, 5233982.908732290680000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 67,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 74, new DateTime(2024, 5, 11, 16, 59, 43, 791, DateTimeKind.Unspecified).AddTicks(6427), 89, 1663041.499432570880000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 68,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 95, new DateTime(2024, 5, 8, 7, 35, 2, 417, DateTimeKind.Unspecified).AddTicks(9928), 75, 5498665.673424968320000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 69,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 79, new DateTime(2024, 5, 2, 21, 11, 32, 778, DateTimeKind.Unspecified).AddTicks(1557), 45, 9357527.260736685880000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 70,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 16, new DateTime(2024, 5, 5, 23, 58, 10, 232, DateTimeKind.Unspecified).AddTicks(758), 73, 7398794.993149224160000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 71,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 19, new DateTime(2024, 5, 7, 16, 47, 31, 847, DateTimeKind.Unspecified).AddTicks(4331), 59, 6703150.604816460080000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 72,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 40, new DateTime(2024, 5, 28, 5, 25, 2, 52, DateTimeKind.Unspecified).AddTicks(3568), 48, 8868859.108361274880000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 73,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 96, new DateTime(2024, 5, 3, 5, 47, 27, 949, DateTimeKind.Unspecified).AddTicks(6606), 54, 2021773.4559109104240000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 74,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 51, new DateTime(2024, 5, 18, 4, 50, 45, 768, DateTimeKind.Unspecified).AddTicks(2206), 29, 9452020.206977636880000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 75,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 6, new DateTime(2024, 5, 19, 3, 54, 45, 812, DateTimeKind.Unspecified).AddTicks(6812), 74, 3537555.671993043960000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 76,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 73, new DateTime(2024, 5, 25, 7, 40, 11, 251, DateTimeKind.Unspecified).AddTicks(7512), 20, 4474276.872251996640000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 77,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 9, new DateTime(2024, 5, 24, 9, 24, 2, 148, DateTimeKind.Unspecified).AddTicks(9647), 7, 1353529.4810551489080000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 78,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 94, new DateTime(2024, 5, 21, 15, 18, 4, 174, DateTimeKind.Unspecified).AddTicks(1602), 20, 4548258.291336546800000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 79,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 76, new DateTime(2024, 5, 17, 18, 29, 5, 408, DateTimeKind.Unspecified).AddTicks(2902), 17, 1923842.738375367080000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 80,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 99, new DateTime(2024, 5, 20, 23, 54, 18, 105, DateTimeKind.Unspecified).AddTicks(1447), 77, 3052450.497584171040000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 81,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 12, new DateTime(2024, 5, 19, 2, 3, 50, 271, DateTimeKind.Unspecified).AddTicks(8499), 94, 2735621.640526731400000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 82,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 46, new DateTime(2024, 5, 8, 2, 0, 48, 204, DateTimeKind.Unspecified).AddTicks(9716), 22, 3111893.698008296560000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 83,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 47, new DateTime(2024, 5, 8, 13, 6, 35, 439, DateTimeKind.Unspecified).AddTicks(313), 88, 3306736.609586445040000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 84,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 54, new DateTime(2024, 5, 23, 15, 36, 4, 2, DateTimeKind.Unspecified).AddTicks(7603), 4, 3420187.163233620080000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 85,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 100, new DateTime(2024, 5, 4, 13, 18, 36, 403, DateTimeKind.Unspecified).AddTicks(735), 3, 5284776.821081675840000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 86,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 28, new DateTime(2024, 5, 20, 12, 13, 11, 217, DateTimeKind.Unspecified).AddTicks(319), 26, 4387436.183097953440000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 87,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 10, new DateTime(2024, 5, 6, 18, 50, 9, 523, DateTimeKind.Unspecified).AddTicks(2974), 10, 5383062.028827560000000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 88,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 7, new DateTime(2024, 5, 28, 16, 5, 54, 168, DateTimeKind.Unspecified).AddTicks(508), 64, 5501433.539275604480000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 89,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 52, new DateTime(2024, 5, 24, 4, 11, 27, 969, DateTimeKind.Unspecified).AddTicks(7529), 38, 9554750.807473833160000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 90,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 93, new DateTime(2024, 5, 9, 9, 17, 56, 669, DateTimeKind.Unspecified).AddTicks(6395), 53, 2447075.127805731280000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 91,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 98, new DateTime(2024, 5, 7, 8, 52, 53, 484, DateTimeKind.Unspecified).AddTicks(4532), 69, 4120351.202013023880000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 92,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 69, new DateTime(2024, 5, 4, 12, 55, 4, 582, DateTimeKind.Unspecified).AddTicks(7622), 36, 2273222.453494352640000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 93,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 30, new DateTime(2024, 5, 23, 15, 12, 24, 835, DateTimeKind.Unspecified).AddTicks(4182), 73, 3310297.302901092000000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 94,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 25, new DateTime(2024, 5, 10, 14, 28, 30, 277, DateTimeKind.Unspecified).AddTicks(6607), 55, 6940195.610004407520000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 95,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 3, new DateTime(2024, 5, 10, 22, 45, 48, 912, DateTimeKind.Unspecified).AddTicks(2918), 10, 7989672.331575877520000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 96,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 77, new DateTime(2024, 5, 23, 4, 3, 16, 400, DateTimeKind.Unspecified).AddTicks(204), 99, 6003526.971920635520000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 97,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 13, new DateTime(2024, 5, 3, 2, 15, 50, 246, DateTimeKind.Unspecified).AddTicks(1408), 13, 4572975.347851493440000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 98,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 31, new DateTime(2024, 5, 28, 3, 7, 34, 834, DateTimeKind.Unspecified).AddTicks(7863), 27, 3900435.221032719600000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 99,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 52, new DateTime(2024, 5, 29, 23, 25, 2, 82, DateTimeKind.Unspecified).AddTicks(2416), 90, 2106279.375939918400000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 100,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 71, new DateTime(2024, 5, 14, 1, 11, 44, 436, DateTimeKind.Unspecified).AddTicks(9307), 14, 6561365.381856891360000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 29, 22, 26, 26, 204, DateTimeKind.Local).AddTicks(1812), 43462.286300412880000m, 104, 161588.240121142200000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 2,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 29, 22, 26, 26, 214, DateTimeKind.Local).AddTicks(8364), 11983.2145662830480000m, 92, 194089.088269654700000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 3,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 29, 22, 26, 26, 222, DateTimeKind.Local).AddTicks(9397), 32361.512995723440000m, 131, 116941.229927290300000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 4,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 29, 22, 26, 26, 232, DateTimeKind.Local).AddTicks(2751), 43136.444535381680000m, 47, 111995.685407253500000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 5,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 29, 22, 26, 26, 240, DateTimeKind.Local).AddTicks(5970), 41848.756048733040000m, 133, 134422.649380086900000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 6,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 29, 22, 26, 26, 248, DateTimeKind.Local).AddTicks(4378), 17960.926957940240000m, 23, 161884.463272325400000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 7,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 29, 22, 26, 26, 256, DateTimeKind.Local).AddTicks(1208), 36411.545085221680000m, 14, 148962.642578036400000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 8,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 29, 22, 26, 26, 264, DateTimeKind.Local).AddTicks(3135), 45611.038011047720000m, 47, 144399.177435640100000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 9,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 29, 22, 26, 26, 272, DateTimeKind.Local).AddTicks(4586), 35638.997953539360000m, 30, 155778.640370364600000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 10,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 29, 22, 26, 26, 280, DateTimeKind.Local).AddTicks(2723), 24816.379453981560000m, 130, 136282.441871425800000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 11,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 29, 22, 26, 26, 287, DateTimeKind.Local).AddTicks(9793), 34410.868944884280000m, 68, 180469.511430212800000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 12,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 29, 22, 26, 26, 296, DateTimeKind.Local).AddTicks(4439), 14538.697775824960000m, 97, 121695.879551015500000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 13,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 29, 22, 26, 26, 304, DateTimeKind.Local).AddTicks(1610), 26271.955869205120000m, 123, 178877.122947984400000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 14,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 29, 22, 26, 26, 312, DateTimeKind.Local).AddTicks(179), 45553.894774596360000m, 31, 150772.060305014600000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 15,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 29, 22, 26, 26, 319, DateTimeKind.Local).AddTicks(6549), 42094.880025557160000m, 43, 170705.0038750600000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 16,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 29, 22, 26, 26, 328, DateTimeKind.Local).AddTicks(8655), 31477.140783812520000m, 104, 120039.087693857100000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 17,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 29, 22, 26, 26, 337, DateTimeKind.Local).AddTicks(1044), 32046.415946578360000m, 56, 150718.257580190700000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 18,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 29, 22, 26, 26, 344, DateTimeKind.Local).AddTicks(2411), 23504.9377246280000m, 84, 147769.851877279500000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 19,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 29, 22, 26, 26, 351, DateTimeKind.Local).AddTicks(2476), 10989.5579537794280000m, 134, 162903.249476683700000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 20,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 29, 22, 26, 26, 358, DateTimeKind.Local).AddTicks(6870), 28636.356012359960000m, 137, 195993.269633939300000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 21,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 29, 22, 26, 26, 365, DateTimeKind.Local).AddTicks(8441), 40230.596927891680000m, 135, 108017.8752860454400000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 22,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 29, 22, 26, 26, 373, DateTimeKind.Local).AddTicks(2532), 36238.556228477520000m, 106, 139640.671564858300000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 23,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 29, 22, 26, 26, 380, DateTimeKind.Local).AddTicks(7147), 48067.740311065240000m, 37, 101618.8762459156800000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 24,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 29, 22, 26, 26, 388, DateTimeKind.Local).AddTicks(3227), 34996.935460873720000m, 73, 123490.120595083300000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 25,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 29, 22, 26, 26, 395, DateTimeKind.Local).AddTicks(5550), 41269.298754553400000m, 73, 186987.102136880200000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 26,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 29, 22, 26, 26, 402, DateTimeKind.Local).AddTicks(7615), 28221.961960707640000m, 127, 178884.12437046400000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 27,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 29, 22, 26, 26, 410, DateTimeKind.Local).AddTicks(3565), 25441.674758769680000m, 76, 105055.3539756414100000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 28,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 29, 22, 26, 26, 417, DateTimeKind.Local).AddTicks(7641), 31247.493807352840000m, 97, 181875.08216978100000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 29,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 29, 22, 26, 26, 425, DateTimeKind.Local).AddTicks(7870), 10288.90680918920440000m, 59, 131214.083296317300000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 30,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 29, 22, 26, 26, 433, DateTimeKind.Local).AddTicks(4564), 35610.296123468680000m, 59, 153755.631801531800000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 31,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 29, 22, 26, 26, 441, DateTimeKind.Local).AddTicks(3878), 22345.039553844240000m, 50, 163506.969249270700000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 32,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 29, 22, 26, 26, 452, DateTimeKind.Local).AddTicks(601), 49869.304201166840000m, 47, 196161.780984312200000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 33,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 29, 22, 26, 26, 464, DateTimeKind.Local).AddTicks(2011), 38786.334119583040000m, 111, 175182.708228136600000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 34,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 29, 22, 26, 26, 474, DateTimeKind.Local).AddTicks(6781), 27069.85998773760000m, 25, 105690.4952209611100000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 35,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 29, 22, 26, 26, 485, DateTimeKind.Local).AddTicks(4964), 23043.233844477520000m, 47, 180798.829385875900000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 36,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 29, 22, 26, 26, 497, DateTimeKind.Local).AddTicks(9963), 33846.877166832360000m, 49, 149267.494651474900000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 37,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 29, 22, 26, 26, 507, DateTimeKind.Local).AddTicks(2839), 41302.723045990880000m, 20, 142071.04114846700000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 38,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 29, 22, 26, 26, 516, DateTimeKind.Local).AddTicks(961), 22662.860402696960000m, 66, 124396.748734356700000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 39,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 29, 22, 26, 26, 523, DateTimeKind.Local).AddTicks(7509), 35790.972898075000000m, 86, 160163.513004728900000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 40,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 29, 22, 26, 26, 533, DateTimeKind.Local).AddTicks(2795), 46681.418646007360000m, 73, 136428.227116574900000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 41,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 29, 22, 26, 26, 545, DateTimeKind.Local).AddTicks(5609), 45935.142468803440000m, 85, 162528.673447550500000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 42,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 29, 22, 26, 26, 553, DateTimeKind.Local).AddTicks(6720), 13726.2986788607560000m, 51, 127269.285458849100000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 43,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 29, 22, 26, 26, 561, DateTimeKind.Local).AddTicks(7060), 36285.450131370840000m, 131, 183718.36533839100000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 44,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 29, 22, 26, 26, 569, DateTimeKind.Local).AddTicks(6886), 18672.326554513080000m, 87, 186864.662416185200000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 45,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 29, 22, 26, 26, 579, DateTimeKind.Local).AddTicks(4684), 14574.238450702280000m, 78, 140796.226878763700000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 46,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 29, 22, 26, 26, 589, DateTimeKind.Local).AddTicks(7627), 12349.5737252193360000m, 86, 130406.760801560300000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 47,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 29, 22, 26, 26, 597, DateTimeKind.Local).AddTicks(8798), 15987.765067262600000m, 27, 114222.756188239400000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 48,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 29, 22, 26, 26, 605, DateTimeKind.Local).AddTicks(9826), 35704.185495541400000m, 73, 163431.182363128500000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 49,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 29, 22, 26, 26, 614, DateTimeKind.Local).AddTicks(1257), 46603.659578767520000m, 119, 170960.767771704600000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 50,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 29, 22, 26, 26, 621, DateTimeKind.Local).AddTicks(9273), 38879.706347310320000m, 88, 116270.421995714100000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 51,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 29, 22, 26, 26, 633, DateTimeKind.Local).AddTicks(2445), 16382.626804214920000m, 74, 151326.377555770600000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 52,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 29, 22, 26, 26, 642, DateTimeKind.Local).AddTicks(7193), 10440.0749378388960000m, 67, 135005.709881337700000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 53,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 29, 22, 26, 26, 654, DateTimeKind.Local).AddTicks(5591), 19844.315064772360000m, 47, 120037.603887862400000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 54,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 29, 22, 26, 26, 662, DateTimeKind.Local).AddTicks(2843), 39192.89247602360000m, 91, 196260.376459703700000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 55,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 29, 22, 26, 26, 670, DateTimeKind.Local).AddTicks(4036), 27040.994667586600000m, 97, 147221.867456120900000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 56,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 29, 22, 26, 26, 682, DateTimeKind.Local).AddTicks(3669), 17713.975940136120000m, 39, 184651.550651447500000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 57,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 29, 22, 26, 26, 692, DateTimeKind.Local).AddTicks(3895), 12260.5063220893440000m, 78, 195995.515103314500000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 58,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 29, 22, 26, 26, 700, DateTimeKind.Local).AddTicks(1690), 43604.35040852040000m, 66, 183210.895849335100000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 59,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 29, 22, 26, 26, 707, DateTimeKind.Local).AddTicks(8508), 31871.309790023280000m, 102, 139060.519990244500000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 60,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 29, 22, 26, 26, 715, DateTimeKind.Local).AddTicks(6852), 15538.810993692520000m, 85, 149907.136246720300000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 61,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 29, 22, 26, 26, 723, DateTimeKind.Local).AddTicks(4188), 35279.379910184240000m, 74, 149158.526673911900000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 62,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 29, 22, 26, 26, 731, DateTimeKind.Local).AddTicks(2364), 12773.6913152939520000m, 69, 162616.782466322200000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 63,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 29, 22, 26, 26, 738, DateTimeKind.Local).AddTicks(9601), 17977.777198909880000m, 52, 197588.227492402300000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 64,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 29, 22, 26, 26, 747, DateTimeKind.Local).AddTicks(968), 23403.533125233080000m, 83, 140491.975261377700000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 65,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 29, 22, 26, 26, 755, DateTimeKind.Local).AddTicks(1816), 20772.518675298200000m, 57, 101719.9170809939800000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 66,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 29, 22, 26, 26, 764, DateTimeKind.Local).AddTicks(4106), 43256.057096961080000m, 34, 132937.662575626100000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 67,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 29, 22, 26, 26, 772, DateTimeKind.Local).AddTicks(3017), 14848.584816362240000m, 47, 103636.2481003618800000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 68,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 29, 22, 26, 26, 781, DateTimeKind.Local).AddTicks(9414), 44344.078011491680000m, 48, 166701.909310615700000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 69,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 29, 22, 26, 26, 794, DateTimeKind.Local).AddTicks(5707), 47500.138379374040000m, 121, 178508.327550430800000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 70,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 29, 22, 26, 26, 802, DateTimeKind.Local).AddTicks(4412), 40877.320404139360000m, 117, 124651.331708721500000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 71,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 29, 22, 26, 26, 810, DateTimeKind.Local).AddTicks(5615), 46875.179054660560000m, 88, 191872.666507444700000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 72,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 29, 22, 26, 26, 818, DateTimeKind.Local).AddTicks(4206), 49825.051170568960000m, 122, 138758.232902547800000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 73,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 29, 22, 26, 26, 826, DateTimeKind.Local).AddTicks(4311), 10869.7497629618840000m, 123, 175005.417589452200000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 74,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 29, 22, 26, 26, 834, DateTimeKind.Local).AddTicks(8045), 47497.588979787120000m, 145, 174230.021162287200000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 75,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 29, 22, 26, 26, 842, DateTimeKind.Local).AddTicks(8933), 23121.278901915320000m, 65, 171830.565622241800000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 76,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 29, 22, 26, 26, 850, DateTimeKind.Local).AddTicks(8070), 43865.459531882320000m, 51, 170258.841739699300000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 77,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 29, 22, 26, 26, 859, DateTimeKind.Local).AddTicks(9880), 12417.7016610564120000m, 54, 122777.809338407800000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 78,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 29, 22, 26, 26, 867, DateTimeKind.Local).AddTicks(8419), 34986.602241050360000m, 51, 102737.6803464275500000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 79,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 29, 22, 26, 26, 875, DateTimeKind.Local).AddTicks(8606), 17025.156976773160000m, 54, 180506.590150090600000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 80,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 29, 22, 26, 26, 883, DateTimeKind.Local).AddTicks(6985), 21648.585089249440000m, 78, 170446.248293487800000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 81,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 29, 22, 26, 26, 891, DateTimeKind.Local).AddTicks(6480), 18359.876782058600000m, 87, 154267.519182082800000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 82,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 29, 22, 26, 26, 899, DateTimeKind.Local).AddTicks(6895), 18634.094000049680000m, 79, 118586.978205301500000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 83,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 29, 22, 26, 26, 907, DateTimeKind.Local).AddTicks(8199), 30904.080463424720000m, 33, 168052.679929369300000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 84,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 29, 22, 26, 26, 915, DateTimeKind.Local).AddTicks(6255), 25715.692956643760000m, 66, 180021.728495061900000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 85,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 29, 22, 26, 26, 925, DateTimeKind.Local).AddTicks(9158), 37216.738176631520000m, 92, 163266.466332591600000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 86,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 29, 22, 26, 26, 933, DateTimeKind.Local).AddTicks(9217), 24106.792214823920000m, 99, 187102.614963477900000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 87,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 29, 22, 26, 26, 945, DateTimeKind.Local).AddTicks(3529), 43064.496230620480000m, 47, 165085.096283144800000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 88,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 29, 22, 26, 26, 957, DateTimeKind.Local).AddTicks(592), 31258.145109520480000m, 113, 123972.939722807700000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 89,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 29, 22, 26, 26, 968, DateTimeKind.Local).AddTicks(6553), 48013.823153134840000m, 118, 192101.986599603600000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 90,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 29, 22, 26, 26, 976, DateTimeKind.Local).AddTicks(2986), 17112.413481158960000m, 56, 138209.253407610100000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 91,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 29, 22, 26, 26, 986, DateTimeKind.Local).AddTicks(4512), 28029.600013694040000m, 73, 199851.194167441600000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 92,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 29, 22, 26, 26, 998, DateTimeKind.Local).AddTicks(2860), 15570.016804755840000m, 56, 167808.362959457800000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 93,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 29, 22, 26, 27, 6, DateTimeKind.Local).AddTicks(1121), 18915.984588006240000m, 92, 110432.553919600300000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 94,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 29, 22, 26, 27, 15, DateTimeKind.Local).AddTicks(1091), 35051.492979820240000m, 132, 117095.216122574900000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 95,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 29, 22, 26, 27, 24, DateTimeKind.Local).AddTicks(1964), 46183.077061132240000m, 83, 140675.374666652300000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 96,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 29, 22, 26, 27, 36, DateTimeKind.Local).AddTicks(537), 34110.948704094520000m, 119, 167770.393956824200000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 97,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 29, 22, 26, 27, 46, DateTimeKind.Local).AddTicks(3666), 25265.057170450240000m, 110, 109954.8927479404400000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 98,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 29, 22, 26, 27, 54, DateTimeKind.Local).AddTicks(4526), 35458.502009388360000m, 39, 146764.580637061400000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 99,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 29, 22, 26, 27, 68, DateTimeKind.Local).AddTicks(1626), 15487.348352499400000m, 73, 196295.017017625600000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 100,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 29, 22, 26, 27, 77, DateTimeKind.Local).AddTicks(3355), 47546.125955484720000m, 86, 160362.608833238900000m });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 1,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Hải Phòng", new DateTime(2024, 5, 29, 22, 26, 26, 182, DateTimeKind.Local).AddTicks(4855), "DangKhuong_Nguyen25@hotmail.com", "0998950903", "Thái Hà Tăng" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 2,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Lâm Đồng", new DateTime(2024, 5, 29, 22, 26, 26, 182, DateTimeKind.Local).AddTicks(7525), "HaiNguyen.Duong15@gmail.com", "0909172393", "Quang Ninh Lê" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 3,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Ninh Thuận", new DateTime(2024, 5, 29, 22, 26, 26, 182, DateTimeKind.Local).AddTicks(7718), "ThienKhanh91@yahoo.com", "0955960397", "Dã Lan Phan" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 4,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "TP. Hồ Chí Minh", new DateTime(2024, 5, 29, 22, 26, 26, 182, DateTimeKind.Local).AddTicks(7843), "CongLoc_Dao@hotmail.com", "0992779762", "Quang Ðức Phan" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 5,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Vĩnh Phúc", new DateTime(2024, 5, 29, 22, 26, 26, 182, DateTimeKind.Local).AddTicks(7971), "UyenMy_Bui12@yahoo.com", "0988898642", "Bảo Châu Tăng" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 6,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Hòa Bình", new DateTime(2024, 5, 29, 22, 26, 26, 182, DateTimeKind.Local).AddTicks(8084), "VyLam_Vu26@hotmail.com", "0972651997", "Quang Hưng Vương" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 7,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Quảng Ninh", new DateTime(2024, 5, 29, 22, 26, 26, 182, DateTimeKind.Local).AddTicks(8188), "PhuongPhuong.Lam@gmail.com", "0988772945", "Tấn Dũng Đoàn" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 8,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Trà Vinh", new DateTime(2024, 5, 29, 22, 26, 26, 182, DateTimeKind.Local).AddTicks(8295), "BachQuynh42@gmail.com", "0941568704", "Thu Hiền Đặng" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 9,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Kiên Giang", new DateTime(2024, 5, 29, 22, 26, 26, 182, DateTimeKind.Local).AddTicks(8395), "UyPhong83@gmail.com", "0918617282", "Phi Nhạn Phùng" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 10,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Đắk Lắk", new DateTime(2024, 5, 29, 22, 26, 26, 182, DateTimeKind.Local).AddTicks(8494), "ThanhChau.Truong@hotmail.com", "0926979383", "Hữu Toàn Hà" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 11,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Đắk Nông", new DateTime(2024, 5, 29, 22, 26, 26, 182, DateTimeKind.Local).AddTicks(8594), "ThuyLinh78@yahoo.com", "0907105568", "Huyền Diệu Bùi" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 12,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Gia Lai", new DateTime(2024, 5, 29, 22, 26, 26, 182, DateTimeKind.Local).AddTicks(8699), "PhuongTien.Phan53@yahoo.com", "0943565961", "Ngọc Huyền Phạm" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 13,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Vĩnh Phúc", new DateTime(2024, 5, 29, 22, 26, 26, 182, DateTimeKind.Local).AddTicks(8805), "QuangDanh31@yahoo.com", "0973688521", "Tịnh Nhi Trương" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 14,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Kiên Giang", new DateTime(2024, 5, 29, 22, 26, 26, 182, DateTimeKind.Local).AddTicks(8899), "NgocQuyen_Phung@gmail.com", "0927054772", "Hùng Thịnh Phạm" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 15,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Hà Giang", new DateTime(2024, 5, 29, 22, 26, 26, 182, DateTimeKind.Local).AddTicks(9000), "HaiUyen4@hotmail.com", "0935698104", "Nguyệt Cầm Phan" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 16,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Nghệ An", new DateTime(2024, 5, 29, 22, 26, 26, 182, DateTimeKind.Local).AddTicks(9090), "QuangAnh.Nguyen47@hotmail.com", "0975045439", "Ðức Bình Lâm" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 17,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Hà Nội", new DateTime(2024, 5, 29, 22, 26, 26, 182, DateTimeKind.Local).AddTicks(9228), "HongHoa_Ho@gmail.com", "0920170641", "Mai Khôi Trương" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 18,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Long An", new DateTime(2024, 5, 29, 22, 26, 26, 182, DateTimeKind.Local).AddTicks(9321), "CongSinh_Trinh@yahoo.com", "0939673121", "An Nguyên Phan" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 19,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Tuyên Quang", new DateTime(2024, 5, 29, 22, 26, 26, 182, DateTimeKind.Local).AddTicks(9435), "MinhNguyet_Doan@gmail.com", "0954468240", "Thúy Hiền Phạm" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 20,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Thừa Thiên-Huế", new DateTime(2024, 5, 29, 22, 26, 26, 182, DateTimeKind.Local).AddTicks(9542), "ChanPhong.Nguyen26@yahoo.com", "0914084178", "Phương Dung Phùng" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 21,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Nam Định", new DateTime(2024, 5, 29, 22, 26, 26, 182, DateTimeKind.Local).AddTicks(9640), "TruongPhat_Truong31@hotmail.com", "0987674644", "Kim Sa Ngô" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 22,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Sóc Trăng", new DateTime(2024, 5, 29, 22, 26, 26, 182, DateTimeKind.Local).AddTicks(9747), "QuocHoang_Tran@yahoo.com", "0915397968", "Ðình Nam Trần" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 23,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "An Giang", new DateTime(2024, 5, 29, 22, 26, 26, 182, DateTimeKind.Local).AddTicks(9843), "KimHoa58@gmail.com", "0917937019", "Thiên An Lâm" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 24,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Bến Tre", new DateTime(2024, 5, 29, 22, 26, 26, 182, DateTimeKind.Local).AddTicks(9937), "DongNguyen.Tang47@gmail.com", "0930639972", "Như Loan Lê" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 25,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Cần Thơ", new DateTime(2024, 5, 29, 22, 26, 26, 183, DateTimeKind.Local).AddTicks(42), "MinhQuan.Do12@yahoo.com", "0953730200", "Xuân Trang Đoàn" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 26,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Thừa Thiên-Huế", new DateTime(2024, 5, 29, 22, 26, 26, 183, DateTimeKind.Local).AddTicks(138), "BachYen_Ngo@yahoo.com", "0902703594", "Từ Dung Đinh" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 27,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Hà Tĩnh", new DateTime(2024, 5, 29, 22, 26, 26, 183, DateTimeKind.Local).AddTicks(225), "ManhNghiem_Dinh@hotmail.com", "0922533485", "Mỹ Ngọc Tăng" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 28,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Tiền Giang", new DateTime(2024, 5, 29, 22, 26, 26, 183, DateTimeKind.Local).AddTicks(329), "HaoNghiep_To@yahoo.com", "0992725456", "Liên Hương Vũ" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 29,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Thái Nguyên", new DateTime(2024, 5, 29, 22, 26, 26, 183, DateTimeKind.Local).AddTicks(425), "ThienTien37@gmail.com", "0901468189", "Tiến Hiệp Lê" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 30,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Bắc Giang", new DateTime(2024, 5, 29, 22, 26, 26, 183, DateTimeKind.Local).AddTicks(512), "QuangTrieu.Lam@hotmail.com", "0991933823", "Kim Thu Trần" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 31,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Hải Phòng", new DateTime(2024, 5, 29, 22, 26, 26, 183, DateTimeKind.Local).AddTicks(611), "BaTruc.Do@gmail.com", "0986592941", "Minh Thuận Dương" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 32,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Ninh Bình", new DateTime(2024, 5, 29, 22, 26, 26, 183, DateTimeKind.Local).AddTicks(695), "DuyQuang17@yahoo.com", "0925419932", "Uyên Thi Đặng" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 33,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Nam Định", new DateTime(2024, 5, 29, 22, 26, 26, 183, DateTimeKind.Local).AddTicks(787), "GiaAnh_Ho11@gmail.com", "0920568920", "Quốc Hoàng Đặng" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 34,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Bắc Ninh", new DateTime(2024, 5, 29, 22, 26, 26, 183, DateTimeKind.Local).AddTicks(872), "LanThuong0@yahoo.com", "0912178611", "Bảo Thạch Đoàn" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 35,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Bắc Giang", new DateTime(2024, 5, 29, 22, 26, 26, 183, DateTimeKind.Local).AddTicks(965), "AiKhanh.Ly@gmail.com", "0905217940", "Cát Cát Tăng" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 36,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Sơn La", new DateTime(2024, 5, 29, 22, 26, 26, 183, DateTimeKind.Local).AddTicks(1055), "DucTuong_Vuong@hotmail.com", "0968922594", "Hữu Tâm Trần" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 37,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "TP. Hồ Chí Minh", new DateTime(2024, 5, 29, 22, 26, 26, 183, DateTimeKind.Local).AddTicks(1154), "DongSon_Hoang@yahoo.com", "0933817695", "Thủy Hồng Dương" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 38,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Kiên Giang", new DateTime(2024, 5, 29, 22, 26, 26, 183, DateTimeKind.Local).AddTicks(1248), "SuongSuong.Lam44@yahoo.com", "0992593143", "Phụng Việt Hà" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 39,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Phú Thọ", new DateTime(2024, 5, 29, 22, 26, 26, 183, DateTimeKind.Local).AddTicks(1344), "ThanhY.Vu17@hotmail.com", "0944519946", "Hồng Anh Đỗ" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 40,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Hà Nam", new DateTime(2024, 5, 29, 22, 26, 26, 183, DateTimeKind.Local).AddTicks(1443), "ThuyHien16@gmail.com", "0928802420", "Ðức Phi Đỗ" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 41,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Gia Lai", new DateTime(2024, 5, 29, 22, 26, 26, 183, DateTimeKind.Local).AddTicks(1529), "NguyenVan.Tran@hotmail.com", "0945169545", "Gia Linh Đào" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 42,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Bình Phước", new DateTime(2024, 5, 29, 22, 26, 26, 183, DateTimeKind.Local).AddTicks(1639), "ThanhVinh.Duong42@hotmail.com", "0999624863", "Tài Ðức Tăng" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 43,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Kon Tum", new DateTime(2024, 5, 29, 22, 26, 26, 183, DateTimeKind.Local).AddTicks(1811), "DucTho_Lam@yahoo.com", "0996227177", "Kiều Nguyệt Dương" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 44,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Tuyên Quang", new DateTime(2024, 5, 29, 22, 26, 26, 183, DateTimeKind.Local).AddTicks(1956), "NhuAnh.Dang34@hotmail.com", "0956272389", "Phương Quân Vũ" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 45,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Trà Vinh", new DateTime(2024, 5, 29, 22, 26, 26, 183, DateTimeKind.Local).AddTicks(2081), "DucBang_Mai95@gmail.com", "0981540407", "Hữu Trí Trần" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 46,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Kon Tum", new DateTime(2024, 5, 29, 22, 26, 26, 183, DateTimeKind.Local).AddTicks(2334), "KhanhGiang_Vuong@yahoo.com", "0949780355", "Trung Nghĩa Đinh" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 47,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Tiền Giang", new DateTime(2024, 5, 29, 22, 26, 26, 183, DateTimeKind.Local).AddTicks(2474), "TriHuu.Doan93@hotmail.com", "0923934026", "Khắc Vũ Vũ" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 48,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Khánh Hoà", new DateTime(2024, 5, 29, 22, 26, 26, 183, DateTimeKind.Local).AddTicks(2634), "HuuKhoi96@gmail.com", "0983835489", "Việt Quốc Phùng" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 49,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Tây Ninh", new DateTime(2024, 5, 29, 22, 26, 26, 183, DateTimeKind.Local).AddTicks(4988), "CuongThinh67@gmail.com", "0953042278", "Bích Quyên Đặng" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 50,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Bạc Liêu", new DateTime(2024, 5, 29, 22, 26, 26, 183, DateTimeKind.Local).AddTicks(5316), "Xuanxanh.Ly98@gmail.com", "0987507184", "Hùng Cường Ngô" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 51,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Quảng Trị", new DateTime(2024, 5, 29, 22, 26, 26, 183, DateTimeKind.Local).AddTicks(5682), "VinhDieu57@hotmail.com", "0944490205", "Diệu Nga Dương" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 52,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Bắc Ninh", new DateTime(2024, 5, 29, 22, 26, 26, 183, DateTimeKind.Local).AddTicks(6217), "QuangVinh6@yahoo.com", "0902217674", "Minh Minh Lâm" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 53,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Bình Phước", new DateTime(2024, 5, 29, 22, 26, 26, 183, DateTimeKind.Local).AddTicks(6424), "QuangDai.Dinh22@gmail.com", "0994890946", "Quốc Hiển Đào" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 54,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Hà Nam", new DateTime(2024, 5, 29, 22, 26, 26, 183, DateTimeKind.Local).AddTicks(6537), "PhuocThien.Phan@yahoo.com", "0903284438", "Kiết Trinh Lâm" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 55,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Đồng Tháp", new DateTime(2024, 5, 29, 22, 26, 26, 183, DateTimeKind.Local).AddTicks(6690), "ThatTho81@gmail.com", "0948597118", "Hán Lâm Ngô" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 56,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Thanh Hoá", new DateTime(2024, 5, 29, 22, 26, 26, 183, DateTimeKind.Local).AddTicks(6877), "CatLy.Dang@gmail.com", "0928772414", "Thanh Hồng Ngô" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 57,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Bắc Giang", new DateTime(2024, 5, 29, 22, 26, 26, 183, DateTimeKind.Local).AddTicks(7002), "HoaiTin67@yahoo.com", "0946556655", "Kim Ngọc Lý" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 58,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "An Giang", new DateTime(2024, 5, 29, 22, 26, 26, 183, DateTimeKind.Local).AddTicks(7107), "MongDiep.Dao97@yahoo.com", "0901800253", "Quỳnh Ngân Lâm" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 59,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Lai Châu", new DateTime(2024, 5, 29, 22, 26, 26, 183, DateTimeKind.Local).AddTicks(7206), "ThucDoan.Dao@gmail.com", "0947296412", "Gia Lập Ngô" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 60,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Đà Nẵng", new DateTime(2024, 5, 29, 22, 26, 26, 183, DateTimeKind.Local).AddTicks(7325), "VanPhuong.Truong@gmail.com", "0951167349", "Trúc Vy Phạm" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 61,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Đồng Tháp", new DateTime(2024, 5, 29, 22, 26, 26, 183, DateTimeKind.Local).AddTicks(7434), "ThanhLong.Trinh26@hotmail.com", "0977334367", "Yên Sơn Phùng" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 62,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Đà Nẵng", new DateTime(2024, 5, 29, 22, 26, 26, 183, DateTimeKind.Local).AddTicks(7596), "ThanhVu61@hotmail.com", "0979390177", "Hương Trà Hồ" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 63,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Long An", new DateTime(2024, 5, 29, 22, 26, 26, 183, DateTimeKind.Local).AddTicks(7688), "ThaoTien.Do@yahoo.com", "0927713548", "Nhật Duy Ngô" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 64,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Bắc Kạn", new DateTime(2024, 5, 29, 22, 26, 26, 183, DateTimeKind.Local).AddTicks(7781), "NhaHong_Doan53@hotmail.com", "0907595477", "Ðắc Cường Tăng" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 65,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Tây Ninh", new DateTime(2024, 5, 29, 22, 26, 26, 183, DateTimeKind.Local).AddTicks(7913), "BaKy_Ha@yahoo.com", "0960884091", "Mạnh Thắng Ngô" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 66,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Lào Cai", new DateTime(2024, 5, 29, 22, 26, 26, 183, DateTimeKind.Local).AddTicks(8008), "NguyenBong.Tang@gmail.com", "0907386188", "Bích Nga Hà" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 67,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Cà Mau", new DateTime(2024, 5, 29, 22, 26, 26, 183, DateTimeKind.Local).AddTicks(8098), "VietLong.Duong67@gmail.com", "0973040450", "Công Luận Đoàn" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 68,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Hòa Bình", new DateTime(2024, 5, 29, 22, 26, 26, 183, DateTimeKind.Local).AddTicks(8200), "PhuongLoan32@gmail.com", "0971696852", "Yến Anh Hà" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 69,
                columns: new[] { "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { new DateTime(2024, 5, 29, 22, 26, 26, 183, DateTimeKind.Local).AddTicks(8305), "PhuBinh64@yahoo.com", "0916548802", "Gia Kiệt Đặng" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 70,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Sóc Trăng", new DateTime(2024, 5, 29, 22, 26, 26, 183, DateTimeKind.Local).AddTicks(8398), "YBinh_Dang69@yahoo.com", "0959760788", "Ðông Trà Phạm" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 71,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Bình Phước", new DateTime(2024, 5, 29, 22, 26, 26, 183, DateTimeKind.Local).AddTicks(8515), "TinhTam13@hotmail.com", "0944707318", "Minh Nguyệt Vương" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 72,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Thái Nguyên", new DateTime(2024, 5, 29, 22, 26, 26, 183, DateTimeKind.Local).AddTicks(8599), "BachQuynh80@hotmail.com", "0947827340", "Công Thành Vương" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 73,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Bắc Giang", new DateTime(2024, 5, 29, 22, 26, 26, 183, DateTimeKind.Local).AddTicks(8694), "KieuNga_Ho42@hotmail.com", "0919373756", "Thái Sang Trần" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 74,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Quảng Ninh", new DateTime(2024, 5, 29, 22, 26, 26, 183, DateTimeKind.Local).AddTicks(8787), "KimDung46@hotmail.com", "0943057838", "Hồ Bắc Lý" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 75,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Lào Cai", new DateTime(2024, 5, 29, 22, 26, 26, 183, DateTimeKind.Local).AddTicks(8881), "NhatLinh.Lam2@hotmail.com", "0917133635", "Hồng Vân Ngô" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 76,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Ninh Bình", new DateTime(2024, 5, 29, 22, 26, 26, 183, DateTimeKind.Local).AddTicks(8971), "BichNga.Duong@hotmail.com", "0906325100", "Ðức Tài Vũ" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 77,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Thanh Hoá", new DateTime(2024, 5, 29, 22, 26, 26, 183, DateTimeKind.Local).AddTicks(9079), "HuongDuong.Tran63@gmail.com", "0969162494", "Nhật Hà Mai" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 78,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Hà Nam", new DateTime(2024, 5, 29, 22, 26, 26, 183, DateTimeKind.Local).AddTicks(9190), "DucHai67@hotmail.com", "0939124358", "Nhã Khanh Đào" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 79,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Bắc Giang", new DateTime(2024, 5, 29, 22, 26, 26, 183, DateTimeKind.Local).AddTicks(9291), "TueNhi.Truong17@hotmail.com", "0988812291", "Quế Chi Dương" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 80,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Kiên Giang", new DateTime(2024, 5, 29, 22, 26, 26, 183, DateTimeKind.Local).AddTicks(9388), "DiemQuynh.Lam82@hotmail.com", "0915053248", "Hồng Mai Lê" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 81,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Hà Nam", new DateTime(2024, 5, 29, 22, 26, 26, 183, DateTimeKind.Local).AddTicks(9505), "VietKhang.Tran@hotmail.com", "0937130842", "Nghị Lực Trương" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 82,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Hưng Yên", new DateTime(2024, 5, 29, 22, 26, 26, 183, DateTimeKind.Local).AddTicks(9624), "UyenMy_Ngo@gmail.com", "0908191407", "Như Bảo Hoàng" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 83,
                columns: new[] { "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { new DateTime(2024, 5, 29, 22, 26, 26, 183, DateTimeKind.Local).AddTicks(9755), "NhatQuang.Pham50@hotmail.com", "0967714720", "Thế Dũng Đỗ" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 84,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Đắk Nông", new DateTime(2024, 5, 29, 22, 26, 26, 183, DateTimeKind.Local).AddTicks(9859), "MongLam41@gmail.com", "0927869931", "Phượng Loan Hồ" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 85,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Tiền Giang", new DateTime(2024, 5, 29, 22, 26, 26, 183, DateTimeKind.Local).AddTicks(9955), "MaiChi1@gmail.com", "0916926497", "Hán Lâm Hồ" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 86,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Lai Châu", new DateTime(2024, 5, 29, 22, 26, 26, 184, DateTimeKind.Local).AddTicks(72), "CuongNghi.To@gmail.com", "0986255248", "Xuân Phúc Trương" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 87,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Hà Tĩnh", new DateTime(2024, 5, 29, 22, 26, 26, 184, DateTimeKind.Local).AddTicks(161), "DuyKhiem.Tang13@yahoo.com", "0988723834", "Bích Duyên Đào" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 88,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Sơn La", new DateTime(2024, 5, 29, 22, 26, 26, 184, DateTimeKind.Local).AddTicks(288), "LacPhuc.To@gmail.com", "0978173361", "Phú Thịnh Trần" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 89,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Lạng Sơn", new DateTime(2024, 5, 29, 22, 26, 26, 184, DateTimeKind.Local).AddTicks(415), "NgocDao.Ngo28@yahoo.com", "0909196614", "Thiên Giang Vương" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 90,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Cà Mau", new DateTime(2024, 5, 29, 22, 26, 26, 184, DateTimeKind.Local).AddTicks(503), "NghiaDung_Hoang51@yahoo.com", "0948770438", "Phương Loan Đoàn" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 91,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Điện Biên", new DateTime(2024, 5, 29, 22, 26, 26, 184, DateTimeKind.Local).AddTicks(599), "PhuocBinh.Ha@gmail.com", "0938810895", "Kim Khuyên Lý" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 92,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Long An", new DateTime(2024, 5, 29, 22, 26, 26, 184, DateTimeKind.Local).AddTicks(685), "DucTrung.Bui35@hotmail.com", "0949033464", "Duy Minh Phùng" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 93,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Quảng Bình", new DateTime(2024, 5, 29, 22, 26, 26, 184, DateTimeKind.Local).AddTicks(812), "TuTam_Ha75@gmail.com", "0953586510", "Vĩnh Hưng Đào" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 94,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Kon Tum", new DateTime(2024, 5, 29, 22, 26, 26, 184, DateTimeKind.Local).AddTicks(907), "PhiNhan_Tran@hotmail.com", "0986530908", "Thi Yến Vương" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 95,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Lâm Đồng", new DateTime(2024, 5, 29, 22, 26, 26, 184, DateTimeKind.Local).AddTicks(997), "TuongLam_Duong31@yahoo.com", "0918774356", "Phước Lộc Hồ" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 96,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Cà Mau", new DateTime(2024, 5, 29, 22, 26, 26, 184, DateTimeKind.Local).AddTicks(1085), "XuanKien.Truong@gmail.com", "0942539559", "Hiếu Liêm Tăng" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 97,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Bình Thuận", new DateTime(2024, 5, 29, 22, 26, 26, 184, DateTimeKind.Local).AddTicks(1197), "ThuongCuong.Dao15@yahoo.com", "0932582314", "Thanh Lan Đào" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 98,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Gia Lai", new DateTime(2024, 5, 29, 22, 26, 26, 184, DateTimeKind.Local).AddTicks(1292), "VietQuoc_Ly43@gmail.com", "0988645847", "Ngọc Uyển Lâm" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 99,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Phú Thọ", new DateTime(2024, 5, 29, 22, 26, 26, 184, DateTimeKind.Local).AddTicks(1377), "MinhHuong.Mai@hotmail.com", "0908450841", "Tú Ly Đoàn" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 100,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Đồng Tháp", new DateTime(2024, 5, 29, 22, 26, 26, 184, DateTimeKind.Local).AddTicks(1470), "MinhNhi.Ha@yahoo.com", "0910039693", "Diệu Hương Lâm" });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 1,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 26, 15, new DateTime(2024, 5, 26, 15, 12, 39, 571, DateTimeKind.Unspecified).AddTicks(8020), 8241000.246178252200000m, 8241000.246178252200000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 2,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 46, 19, new DateTime(2024, 5, 26, 19, 35, 12, 691, DateTimeKind.Unspecified).AddTicks(7736), 10092632.590022044400000m, 10092632.590022044400000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 3,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 52, 20, new DateTime(2024, 5, 21, 11, 3, 47, 534, DateTimeKind.Unspecified).AddTicks(1999), 7718121.175201159800000m, 7718121.175201159800000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 4,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 19, 64, new DateTime(2024, 5, 17, 22, 26, 24, 353, DateTimeKind.Unspecified).AddTicks(9176), 6159762.697398942500000m, 6159762.697398942500000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 5,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 10, 16, new DateTime(2024, 5, 22, 20, 3, 13, 59, DateTimeKind.Unspecified).AddTicks(9342), 8334204.261565387800000m, 8334204.261565387800000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 6,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 55, 79, new DateTime(2024, 5, 27, 7, 1, 28, 252, DateTimeKind.Unspecified).AddTicks(5564), 12465103.671969055800000m, 12465103.671969055800000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 7,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 15, 77, new DateTime(2024, 5, 12, 4, 14, 32, 96, DateTimeKind.Unspecified).AddTicks(9529), 12959749.904289166800000m, 12959749.904289166800000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 8,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 40, 82, new DateTime(2024, 5, 13, 4, 23, 10, 647, DateTimeKind.Unspecified).AddTicks(4257), 8663950.646138406000000m, 8663950.646138406000000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 9,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 52, 12, new DateTime(2024, 5, 7, 10, 56, 26, 783, DateTimeKind.Unspecified).AddTicks(3111), 13241184.431480991000000m, 13241184.431480991000000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 10,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 47, 1, new DateTime(2024, 5, 8, 15, 0, 37, 90, DateTimeKind.Unspecified).AddTicks(3942), 8858358.721642677000000m, 8858358.721642677000000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 11,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 28, 66, new DateTime(2024, 5, 26, 2, 28, 30, 191, DateTimeKind.Unspecified).AddTicks(7376), 11910987.754394044800000m, 11910987.754394044800000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 12,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 65, 57, new DateTime(2024, 5, 18, 12, 53, 44, 564, DateTimeKind.Unspecified).AddTicks(2475), 8518711.568571085000000m, 8518711.568571085000000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 13,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 13, 28, new DateTime(2024, 5, 8, 3, 33, 45, 594, DateTimeKind.Unspecified).AddTicks(9818), 13236907.098150845600000m, 13236907.098150845600000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 14,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 99, 97, new DateTime(2024, 5, 25, 1, 59, 52, 749, DateTimeKind.Unspecified).AddTicks(2752), 11458676.583181109600000m, 11458676.583181109600000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 15,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 92, 93, new DateTime(2024, 5, 1, 21, 58, 44, 206, DateTimeKind.Unspecified).AddTicks(7079), 10583710.2402537200000m, 10583710.2402537200000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 16,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 33, 91, new DateTime(2024, 5, 19, 18, 0, 20, 608, DateTimeKind.Unspecified).AddTicks(72), 6842227.998549854700000m, 6842227.998549854700000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 17,
                columns: new[] { "CustomerID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 19, new DateTime(2024, 5, 20, 8, 22, 48, 820, DateTimeKind.Unspecified).AddTicks(10), 7988067.651750107100000m, 7988067.651750107100000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 18,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 63, 63, new DateTime(2024, 5, 15, 14, 12, 4, 153, DateTimeKind.Unspecified).AddTicks(5612), 10343889.631409565000000m, 10343889.631409565000000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 19,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 73, 85, new DateTime(2024, 5, 23, 8, 9, 9, 810, DateTimeKind.Unspecified).AddTicks(7274), 8633872.222264236100000m, 8633872.222264236100000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 20,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 60, 3, new DateTime(2024, 5, 10, 22, 15, 22, 108, DateTimeKind.Unspecified).AddTicks(2664), 11563602.908402418700000m, 11563602.908402418700000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 21,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 76, 94, new DateTime(2024, 5, 1, 3, 30, 13, 701, DateTimeKind.Unspecified).AddTicks(8590), 5508911.6395883174400000m, 5508911.6395883174400000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 22,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 56, 6, new DateTime(2024, 5, 10, 5, 22, 23, 637, DateTimeKind.Unspecified).AddTicks(2782), 12428019.769272388700000m, 12428019.769272388700000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 23,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 13, 84, new DateTime(2024, 5, 26, 12, 11, 43, 617, DateTimeKind.Unspecified).AddTicks(1869), 6401989.2034926878400000m, 6401989.2034926878400000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 24,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 46, 57, new DateTime(2024, 5, 8, 23, 48, 25, 127, DateTimeKind.Unspecified).AddTicks(7318), 10990620.732962413700000m, 10990620.732962413700000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 25,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 54, 97, new DateTime(2024, 5, 10, 3, 38, 19, 845, DateTimeKind.Unspecified).AddTicks(9497), 14211019.762402895200000m, 14211019.762402895200000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 26,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 3, 77, new DateTime(2024, 5, 13, 9, 30, 24, 23, DateTimeKind.Unspecified).AddTicks(4854), 11448583.95970969600000m, 11448583.95970969600000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 27,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 21, 44, new DateTime(2024, 5, 3, 19, 38, 14, 240, DateTimeKind.Unspecified).AddTicks(5161), 6723542.6544410502400000m, 6723542.6544410502400000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 28,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 14, 72, new DateTime(2024, 5, 22, 7, 49, 34, 60, DateTimeKind.Unspecified).AddTicks(7108), 14550006.57358248000000m, 14550006.57358248000000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 29,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 47, 3, new DateTime(2024, 5, 9, 4, 23, 22, 322, DateTimeKind.Unspecified).AddTicks(630), 8528915.414260624500000m, 8528915.414260624500000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 30,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 44, 45, new DateTime(2024, 5, 27, 19, 35, 46, 311, DateTimeKind.Unspecified).AddTicks(8522), 12300450.544122544000000m, 12300450.544122544000000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 31,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 65, 36, new DateTime(2024, 5, 17, 0, 48, 34, 662, DateTimeKind.Unspecified).AddTicks(9067), 9646911.185706971300000m, 9646911.185706971300000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 32,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 34, 24, new DateTime(2024, 5, 12, 13, 32, 37, 705, DateTimeKind.Unspecified).AddTicks(5108), 14319810.011854790600000m, 14319810.011854790600000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 33,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 63, 43, new DateTime(2024, 5, 21, 3, 45, 55, 751, DateTimeKind.Unspecified).AddTicks(6090), 9810231.660775649600000m, 9810231.660775649600000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 34,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 65, 63, new DateTime(2024, 5, 19, 13, 38, 8, 956, DateTimeKind.Unspecified).AddTicks(2526), 8032477.6367930443600000m, 8032477.6367930443600000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 35,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 70, 100, new DateTime(2024, 5, 26, 23, 57, 31, 351, DateTimeKind.Unspecified).AddTicks(986), 11028728.592538429900000m, 11028728.592538429900000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 36,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 23, 38, new DateTime(2024, 5, 8, 15, 36, 54, 880, DateTimeKind.Unspecified).AddTicks(5340), 13135539.529329791200000m, 13135539.529329791200000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 37,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 25, 17, new DateTime(2024, 5, 5, 22, 9, 38, 678, DateTimeKind.Unspecified).AddTicks(9706), 11507754.33302582700000m, 11507754.33302582700000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 38,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 7, 25, new DateTime(2024, 5, 4, 12, 1, 46, 155, DateTimeKind.Unspecified).AddTicks(565), 7339408.175327045300000m, 7339408.175327045300000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 39,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 18, 44, new DateTime(2024, 5, 2, 16, 10, 26, 607, DateTimeKind.Unspecified).AddTicks(6691), 9930137.806293191800000m, 9930137.806293191800000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 40,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 80, 61, new DateTime(2024, 5, 28, 5, 29, 13, 500, DateTimeKind.Unspecified).AddTicks(2058), 12278540.440491741000000m, 12278540.440491741000000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 41,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 37, 48, new DateTime(2024, 5, 3, 12, 38, 32, 676, DateTimeKind.Unspecified).AddTicks(5451), 10564363.774090782500000m, 10564363.774090782500000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 42,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 87, 49, new DateTime(2024, 5, 3, 2, 53, 49, 517, DateTimeKind.Unspecified).AddTicks(5601), 6618002.843860153200000m, 6618002.843860153200000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 43,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 44, 86, new DateTime(2024, 5, 25, 1, 21, 54, 474, DateTimeKind.Unspecified).AddTicks(3960), 11941693.74699541500000m, 11941693.74699541500000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 44,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 80, 73, new DateTime(2024, 5, 26, 10, 9, 7, 10, DateTimeKind.Unspecified).AddTicks(6511), 10838150.420138741600000m, 10838150.420138741600000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 45,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 42, 72, new DateTime(2024, 5, 3, 10, 9, 45, 230, DateTimeKind.Unspecified).AddTicks(6913), 9855735.881513459000000m, 9855735.881513459000000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 46,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 70, 62, new DateTime(2024, 5, 22, 16, 23, 19, 456, DateTimeKind.Unspecified).AddTicks(6236), 7172371.844085816500000m, 7172371.844085816500000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 47,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 89, 80, new DateTime(2024, 5, 14, 1, 57, 11, 289, DateTimeKind.Unspecified).AddTicks(6109), 9252043.251247391400000m, 9252043.251247391400000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 48,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 80, 8, new DateTime(2024, 5, 22, 2, 45, 24, 207, DateTimeKind.Unspecified).AddTicks(8465), 14381944.047955308000000m, 14381944.047955308000000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 49,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 25, 74, new DateTime(2024, 5, 17, 20, 0, 59, 722, DateTimeKind.Unspecified).AddTicks(2874), 13847822.189508072600000m, 13847822.189508072600000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 50,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 84, 89, new DateTime(2024, 5, 14, 15, 52, 51, 778, DateTimeKind.Unspecified).AddTicks(2189), 7208766.163734274200000m, 7208766.163734274200000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 51,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 8, 2, new DateTime(2024, 5, 9, 0, 8, 51, 8, DateTimeKind.Unspecified).AddTicks(2438), 13014068.469796271600000m, 13014068.469796271600000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 52,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 10, 52, new DateTime(2024, 5, 21, 21, 26, 30, 885, DateTimeKind.Unspecified).AddTicks(9203), 11340479.630032366800000m, 11340479.630032366800000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 53,
                columns: new[] { "CustomerID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 82, new DateTime(2024, 5, 4, 16, 56, 41, 571, DateTimeKind.Unspecified).AddTicks(3527), 7082218.629383881600000m, 7082218.629383881600000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 54,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 56, 39, new DateTime(2024, 5, 15, 12, 3, 12, 128, DateTimeKind.Unspecified).AddTicks(580), 12560664.093421036800000m, 12560664.093421036800000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 55,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 100, 22, new DateTime(2024, 5, 16, 23, 44, 55, 377, DateTimeKind.Unspecified).AddTicks(7435), 11483305.661577430200000m, 11483305.661577430200000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 56,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 15, 46, new DateTime(2024, 5, 24, 6, 44, 16, 544, DateTimeKind.Unspecified).AddTicks(1680), 16249336.457327380000000m, 16249336.457327380000000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 57,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 45, 79, new DateTime(2024, 5, 11, 17, 46, 5, 844, DateTimeKind.Unspecified).AddTicks(4842), 14895659.147851902000000m, 14895659.147851902000000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 58,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 58, 79, new DateTime(2024, 5, 21, 1, 51, 4, 553, DateTimeKind.Unspecified).AddTicks(558), 14107238.980398802700000m, 14107238.980398802700000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 59,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 11, 71, new DateTime(2024, 5, 5, 9, 49, 47, 953, DateTimeKind.Unspecified).AddTicks(1326), 10429538.999268337500000m, 10429538.999268337500000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 60,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 78, 38, new DateTime(2024, 5, 12, 9, 56, 11, 87, DateTimeKind.Unspecified).AddTicks(4432), 10643406.673517141300000m, 10643406.673517141300000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 61,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 49, 86, new DateTime(2024, 5, 29, 12, 22, 14, 735, DateTimeKind.Unspecified).AddTicks(9845), 7607084.860369506900000m, 7607084.860369506900000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 62,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 64, 64, new DateTime(2024, 5, 21, 2, 3, 59, 731, DateTimeKind.Unspecified).AddTicks(5276), 9431773.383046687600000m, 9431773.383046687600000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 63,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 81, 35, new DateTime(2024, 5, 16, 13, 3, 10, 799, DateTimeKind.Unspecified).AddTicks(7046), 16004646.426884586300000m, 16004646.426884586300000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 64,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 57, 65, new DateTime(2024, 5, 15, 18, 39, 46, 920, DateTimeKind.Unspecified).AddTicks(3426), 10677390.119864705200000m, 10677390.119864705200000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 65,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 44, 28, new DateTime(2024, 5, 19, 8, 45, 43, 889, DateTimeKind.Unspecified).AddTicks(4332), 7934153.5323175304400000m, 7934153.5323175304400000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 66,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 52, 98, new DateTime(2024, 5, 17, 8, 21, 6, 577, DateTimeKind.Unspecified).AddTicks(2664), 11565576.644079470700000m, 11565576.644079470700000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 67,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 42, 23, new DateTime(2024, 5, 12, 20, 37, 56, 504, DateTimeKind.Unspecified).AddTicks(3174), 6736356.1265235222000000m, 6736356.1265235222000000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 68,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 88, 33, new DateTime(2024, 5, 14, 4, 52, 2, 440, DateTimeKind.Unspecified).AddTicks(7549), 12669345.107606793200000m, 12669345.107606793200000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 69,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 15, 68, new DateTime(2024, 5, 19, 0, 36, 39, 327, DateTimeKind.Unspecified).AddTicks(9491), 13566632.893832740800000m, 13566632.893832740800000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 70,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 56, 36, new DateTime(2024, 5, 27, 4, 4, 3, 72, DateTimeKind.Unspecified).AddTicks(8151), 7977685.229358176000000m, 7977685.229358176000000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 71,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 20, 99, new DateTime(2024, 5, 9, 3, 46, 51, 160, DateTimeKind.Unspecified).AddTicks(3018), 10552996.657909458500000m, 10552996.657909458500000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 72,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 38, 87, new DateTime(2024, 5, 11, 16, 16, 56, 142, DateTimeKind.Unspecified).AddTicks(4277), 7770461.042542676800000m, 7770461.042542676800000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 73,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 12, 54, new DateTime(2024, 5, 10, 3, 26, 44, 831, DateTimeKind.Unspecified).AddTicks(9300), 11025341.308135488600000m, 11025341.308135488600000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 74,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 83, 12, new DateTime(2024, 5, 8, 5, 40, 49, 193, DateTimeKind.Unspecified).AddTicks(3450), 9408421.142763508800000m, 9408421.142763508800000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 75,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 66, 47, new DateTime(2024, 5, 8, 3, 24, 14, 436, DateTimeKind.Unspecified).AddTicks(5202), 15121089.774757278400000m, 15121089.774757278400000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 76,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 91, 66, new DateTime(2024, 5, 18, 0, 17, 17, 907, DateTimeKind.Unspecified).AddTicks(1141), 8683200.928724664300000m, 8683200.928724664300000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 77,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 86, 70, new DateTime(2024, 5, 28, 15, 1, 21, 929, DateTimeKind.Unspecified).AddTicks(1747), 6752779.513612429000000m, 6752779.513612429000000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 78,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 25, 85, new DateTime(2024, 5, 29, 17, 8, 38, 272, DateTimeKind.Unspecified).AddTicks(4793), 8116276.7473677764500000m, 8116276.7473677764500000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 79,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 41, 35, new DateTime(2024, 5, 6, 4, 5, 47, 92, DateTimeKind.Unspecified).AddTicks(924), 10649888.818855345400000m, 10649888.818855345400000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 80,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 81, 20, new DateTime(2024, 5, 17, 14, 23, 53, 235, DateTimeKind.Unspecified).AddTicks(1027), 10738113.642489731400000m, 10738113.642489731400000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 81,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 68, 28, new DateTime(2024, 5, 18, 9, 23, 38, 979, DateTimeKind.Unspecified).AddTicks(371), 9564586.189289133600000m, 9564586.189289133600000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 82,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 96, 85, new DateTime(2024, 5, 2, 6, 28, 54, 839, DateTimeKind.Unspecified).AddTicks(6459), 10435654.082066532000000m, 10435654.082066532000000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 83,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 28, 86, new DateTime(2024, 5, 12, 20, 44, 28, 874, DateTimeKind.Unspecified).AddTicks(602), 12435898.314773328200000m, 12435898.314773328200000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 84,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 91, 76, new DateTime(2024, 5, 16, 14, 6, 47, 470, DateTimeKind.Unspecified).AddTicks(5125), 12061455.809169147300000m, 12061455.809169147300000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 85,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 10, 8, new DateTime(2024, 5, 7, 22, 42, 6, 617, DateTimeKind.Unspecified).AddTicks(7821), 8163323.316629580000000m, 8163323.316629580000000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 86,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 2, 17, new DateTime(2024, 5, 18, 12, 8, 13, 273, DateTimeKind.Unspecified).AddTicks(7582), 15529517.041968665700000m, 15529517.041968665700000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 87,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 23, 32, new DateTime(2024, 5, 17, 20, 2, 59, 582, DateTimeKind.Unspecified).AddTicks(5026), 12876637.510085294400000m, 12876637.510085294400000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 88,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 91, 16, new DateTime(2024, 5, 19, 14, 25, 27, 956, DateTimeKind.Unspecified).AddTicks(4974), 7810295.202536885100000m, 7810295.202536885100000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 89,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 14, 10, new DateTime(2024, 5, 21, 10, 24, 29, 646, DateTimeKind.Unspecified).AddTicks(1069), 15560260.914567891600000m, 15560260.914567891600000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 90,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 8, 29, new DateTime(2024, 5, 13, 9, 16, 42, 337, DateTimeKind.Unspecified).AddTicks(6253), 12024205.046462078700000m, 12024205.046462078700000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 91,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 91, 10, new DateTime(2024, 5, 1, 17, 49, 41, 116, DateTimeKind.Unspecified).AddTicks(8097), 14788988.368390678400000m, 14788988.368390678400000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 92,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 25, 68, new DateTime(2024, 5, 23, 11, 41, 45, 530, DateTimeKind.Unspecified).AddTicks(2193), 15102752.666351202000000m, 15102752.666351202000000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 93,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 80, 51, new DateTime(2024, 5, 21, 19, 11, 41, 799, DateTimeKind.Unspecified).AddTicks(1229), 9165901.975326824900000m, 9165901.975326824900000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 94,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 86, 63, new DateTime(2024, 5, 12, 22, 20, 37, 40, DateTimeKind.Unspecified).AddTicks(6448), 7728284.264089943400000m, 7728284.264089943400000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 95,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 83, 44, new DateTime(2024, 5, 2, 14, 56, 50, 187, DateTimeKind.Unspecified).AddTicks(1288), 12660783.719998707000000m, 12660783.719998707000000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 96,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 27, 6, new DateTime(2024, 5, 3, 7, 23, 50, 617, DateTimeKind.Unspecified).AddTicks(7151), 9562912.455538979400000m, 9562912.455538979400000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 97,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 19, 78, new DateTime(2024, 5, 23, 16, 38, 22, 466, DateTimeKind.Unspecified).AddTicks(6058), 7806797.3851037712400000m, 7806797.3851037712400000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 98,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 61, 33, new DateTime(2024, 5, 2, 16, 29, 23, 198, DateTimeKind.Unspecified).AddTicks(5746), 10420285.225231359400000m, 10420285.225231359400000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 99,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 51, 86, new DateTime(2024, 5, 10, 11, 54, 16, 947, DateTimeKind.Unspecified).AddTicks(4639), 12366586.072110412800000m, 12366586.072110412800000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 100,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 80, 59, new DateTime(2024, 5, 15, 7, 24, 54, 255, DateTimeKind.Unspecified).AddTicks(9064), 8338855.659328422800000m, 8338855.659328422800000m });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Email", "EmployeeID", "LastLogin", "Lock", "Password", "RoleID" },
                values: new object[,]
                {
                    { "ThuanHau58@gmail.com", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92", 2 },
                    { "MinhHy38@gmail.com", 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92", 1 },
                    { "MinhNghia12@yahoo.com", 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92", 1 },
                    { "MinhQuang.Phan@yahoo.com", 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92", 2 },
                    { "TrungNguyen_Duong23@hotmail.com", 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92", 1 },
                    { "NguyetAnh.Ly18@gmail.com", 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92", 2 },
                    { "QuynhPhuong.Duong@gmail.com", 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92", 2 },
                    { "NhatPhuong_Duong@yahoo.com", 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92", 2 },
                    { "NhatLinh_Doan@gmail.com", 9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92", 2 },
                    { "SonTrang.Vuong@gmail.com", 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92", 2 },
                    { "BichChieu.Truong76@hotmail.com", 11, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92", 2 },
                    { "KhaiTam82@hotmail.com", 12, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92", 1 },
                    { "HoaBinh_Truong5@yahoo.com", 13, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92", 2 },
                    { "PhuongThuy_Vu97@hotmail.com", 14, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92", 1 },
                    { "ThuyQuynh_Doan@gmail.com", 15, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92", 1 },
                    { "HongThuy.Bui@yahoo.com", 16, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92", 2 },
                    { "DieuHoa.Pham@hotmail.com", 17, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92", 2 },
                    { "LongVinh_Hoang72@yahoo.com", 18, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92", 2 },
                    { "MinhAn33@gmail.com", 19, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92", 1 },
                    { "YenBang93@gmail.com", 20, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92", 1 },
                    { "ThienMai.To@hotmail.com", 21, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92", 1 },
                    { "ThaoVan_Mai@gmail.com", 22, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92", 1 },
                    { "MinhKhang_Tang88@gmail.com", 23, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92", 2 },
                    { "MongDiep.Nguyen95@gmail.com", 24, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92", 1 },
                    { "ThanhVy29@gmail.com", 25, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92", 2 },
                    { "GiaHung_Do48@yahoo.com", 26, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92", 2 },
                    { "NhatBaoLong.Ly@hotmail.com", 27, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92", 1 },
                    { "HaGiang14@gmail.com", 28, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92", 2 },
                    { "MyNgoc.Bui@gmail.com", 29, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92", 2 },
                    { "DanThu.Dinh64@hotmail.com", 30, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92", 2 },
                    { "PhucDuy_Ho19@hotmail.com", 31, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92", 1 },
                    { "DiepAnh14@gmail.com", 32, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92", 1 },
                    { "ThanhNha_Tang95@gmail.com", 33, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92", 1 },
                    { "DucHuy19@gmail.com", 34, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92", 1 },
                    { "TuyetTam.Mai93@yahoo.com", 35, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92", 2 },
                    { "XuanThao52@hotmail.com", 36, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92", 1 },
                    { "BichHa25@hotmail.com", 37, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92", 2 },
                    { "UyenNhi.Le26@yahoo.com", 38, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92", 2 },
                    { "HanhVi33@yahoo.com", 39, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92", 1 },
                    { "MaiAnh_Hoang3@hotmail.com", 40, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92", 2 },
                    { "BanMai82@hotmail.com", 41, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92", 2 },
                    { "AnhTuan95@hotmail.com", 42, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92", 1 },
                    { "NgocDiep95@gmail.com", 43, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92", 2 },
                    { "NguyetLan_Lam@hotmail.com", 44, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92", 1 },
                    { "HanhTuong.Phung@yahoo.com", 45, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92", 1 },
                    { "ThaoLinh_Trinh@yahoo.com", 46, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92", 1 },
                    { "HongThao24@gmail.com", 47, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92", 1 },
                    { "ChinhTruc68@hotmail.com", 48, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92", 1 },
                    { "HaiGiang.Doan@hotmail.com", 49, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92", 1 },
                    { "ThuMai.Dao@hotmail.com", 50, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92", 1 },
                    { "HongQue.Ngo54@gmail.com", 51, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92", 1 },
                    { "NgocLe.Phung66@yahoo.com", 52, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92", 2 },
                    { "MinhThang_Lam@hotmail.com", 53, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92", 1 },
                    { "SonTuyen.Tang63@hotmail.com", 54, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92", 1 },
                    { "DucTuong_Vuong6@yahoo.com", 55, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92", 2 },
                    { "HuyQuang95@gmail.com", 56, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92", 2 },
                    { "PhuongDung.Vu@gmail.com", 57, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92", 2 },
                    { "LanHuong_Ngo@hotmail.com", 58, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92", 2 },
                    { "BaoAnh96@yahoo.com", 59, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92", 2 },
                    { "CongHieu_Doan21@hotmail.com", 60, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92", 2 },
                    { "TruongSa_Bui@yahoo.com", 61, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92", 2 },
                    { "VietAn.Nguyen16@yahoo.com", 62, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92", 1 },
                    { "XuanHanh.Nguyen@yahoo.com", 63, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92", 2 },
                    { "DacDi27@gmail.com", 64, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92", 2 },
                    { "HuuThong.Bui@gmail.com", 65, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92", 1 },
                    { "TuyetNhung66@hotmail.com", 66, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92", 2 },
                    { "NguyetHong_Phan@hotmail.com", 67, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92", 2 },
                    { "KimLy24@gmail.com", 68, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92", 1 },
                    { "QuangLoc.Truong@gmail.com", 69, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92", 1 },
                    { "NhatNam38@hotmail.com", 70, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92", 1 },
                    { "DucTuan_Dinh@hotmail.com", 71, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92", 2 },
                    { "CamVan_Ho98@hotmail.com", 72, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92", 2 },
                    { "KhaiCa_Tang64@gmail.com", 73, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92", 1 },
                    { "HaoNhien_Ly@yahoo.com", 74, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92", 1 },
                    { "PhuongUyen10@hotmail.com", 75, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92", 2 },
                    { "LamDung22@gmail.com", 76, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92", 1 },
                    { "DuyHoang_Dinh5@gmail.com", 77, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92", 2 },
                    { "QuePhuong35@hotmail.com", 78, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92", 1 },
                    { "XuanYen26@hotmail.com", 79, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92", 1 },
                    { "TuyetTrinh.Trinh@hotmail.com", 80, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92", 2 },
                    { "ThaoLinh_Phan@hotmail.com", 81, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92", 1 },
                    { "KimSa.Vuong17@yahoo.com", 82, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92", 1 },
                    { "ThuLam_Phan39@gmail.com", 83, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92", 1 },
                    { "AnhTai_Dang@yahoo.com", 84, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92", 1 },
                    { "ThaoHuong1@yahoo.com", 85, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92", 1 },
                    { "TrucQuan.Truong19@gmail.com", 86, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92", 1 },
                    { "QuangKhanh9@yahoo.com", 87, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92", 1 },
                    { "ThuyHien27@gmail.com", 88, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92", 1 },
                    { "TungLam_To75@hotmail.com", 89, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92", 2 },
                    { "KimThu_Do@yahoo.com", 90, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92", 2 },
                    { "ThuSinh.Tran97@yahoo.com", 91, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92", 2 },
                    { "TienGiang_Le70@yahoo.com", 92, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92", 2 },
                    { "MinhKhanh_Tran@yahoo.com", 93, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92", 1 },
                    { "CamHien.Tran11@gmail.com", 94, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92", 1 },
                    { "HongDao_To32@yahoo.com", 95, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92", 2 },
                    { "HaiChau79@gmail.com", 96, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92", 2 },
                    { "MyPhuong.Ho49@yahoo.com", 97, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92", 1 },
                    { "MinhDat.Do@hotmail.com", 98, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92", 1 },
                    { "HuuHoang_Vuong86@gmail.com", 99, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92", 2 },
                    { "ThaiTam_Dao46@hotmail.com", 100, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92", 1 }
                });

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "RoleID",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2024, 5, 29, 22, 26, 26, 176, DateTimeKind.Local).AddTicks(9884));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "RoleID",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2024, 5, 29, 22, 26, 26, 176, DateTimeKind.Local).AddTicks(9890));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_User",
                table: "User");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "Email", "EmployeeID" },
                keyValues: new object[] { "ThuanHau58@gmail.com", 1 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "Email", "EmployeeID" },
                keyValues: new object[] { "MinhHy38@gmail.com", 2 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "Email", "EmployeeID" },
                keyValues: new object[] { "MinhNghia12@yahoo.com", 3 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "Email", "EmployeeID" },
                keyValues: new object[] { "MinhQuang.Phan@yahoo.com", 4 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "Email", "EmployeeID" },
                keyValues: new object[] { "TrungNguyen_Duong23@hotmail.com", 5 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "Email", "EmployeeID" },
                keyValues: new object[] { "NguyetAnh.Ly18@gmail.com", 6 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "Email", "EmployeeID" },
                keyValues: new object[] { "QuynhPhuong.Duong@gmail.com", 7 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "Email", "EmployeeID" },
                keyValues: new object[] { "NhatPhuong_Duong@yahoo.com", 8 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "Email", "EmployeeID" },
                keyValues: new object[] { "NhatLinh_Doan@gmail.com", 9 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "Email", "EmployeeID" },
                keyValues: new object[] { "SonTrang.Vuong@gmail.com", 10 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "Email", "EmployeeID" },
                keyValues: new object[] { "BichChieu.Truong76@hotmail.com", 11 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "Email", "EmployeeID" },
                keyValues: new object[] { "KhaiTam82@hotmail.com", 12 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "Email", "EmployeeID" },
                keyValues: new object[] { "HoaBinh_Truong5@yahoo.com", 13 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "Email", "EmployeeID" },
                keyValues: new object[] { "PhuongThuy_Vu97@hotmail.com", 14 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "Email", "EmployeeID" },
                keyValues: new object[] { "ThuyQuynh_Doan@gmail.com", 15 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "Email", "EmployeeID" },
                keyValues: new object[] { "HongThuy.Bui@yahoo.com", 16 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "Email", "EmployeeID" },
                keyValues: new object[] { "DieuHoa.Pham@hotmail.com", 17 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "Email", "EmployeeID" },
                keyValues: new object[] { "LongVinh_Hoang72@yahoo.com", 18 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "Email", "EmployeeID" },
                keyValues: new object[] { "MinhAn33@gmail.com", 19 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "Email", "EmployeeID" },
                keyValues: new object[] { "YenBang93@gmail.com", 20 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "Email", "EmployeeID" },
                keyValues: new object[] { "ThienMai.To@hotmail.com", 21 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "Email", "EmployeeID" },
                keyValues: new object[] { "ThaoVan_Mai@gmail.com", 22 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "Email", "EmployeeID" },
                keyValues: new object[] { "MinhKhang_Tang88@gmail.com", 23 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "Email", "EmployeeID" },
                keyValues: new object[] { "MongDiep.Nguyen95@gmail.com", 24 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "Email", "EmployeeID" },
                keyValues: new object[] { "ThanhVy29@gmail.com", 25 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "Email", "EmployeeID" },
                keyValues: new object[] { "GiaHung_Do48@yahoo.com", 26 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "Email", "EmployeeID" },
                keyValues: new object[] { "NhatBaoLong.Ly@hotmail.com", 27 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "Email", "EmployeeID" },
                keyValues: new object[] { "HaGiang14@gmail.com", 28 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "Email", "EmployeeID" },
                keyValues: new object[] { "MyNgoc.Bui@gmail.com", 29 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "Email", "EmployeeID" },
                keyValues: new object[] { "DanThu.Dinh64@hotmail.com", 30 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "Email", "EmployeeID" },
                keyValues: new object[] { "PhucDuy_Ho19@hotmail.com", 31 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "Email", "EmployeeID" },
                keyValues: new object[] { "DiepAnh14@gmail.com", 32 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "Email", "EmployeeID" },
                keyValues: new object[] { "ThanhNha_Tang95@gmail.com", 33 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "Email", "EmployeeID" },
                keyValues: new object[] { "DucHuy19@gmail.com", 34 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "Email", "EmployeeID" },
                keyValues: new object[] { "TuyetTam.Mai93@yahoo.com", 35 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "Email", "EmployeeID" },
                keyValues: new object[] { "XuanThao52@hotmail.com", 36 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "Email", "EmployeeID" },
                keyValues: new object[] { "BichHa25@hotmail.com", 37 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "Email", "EmployeeID" },
                keyValues: new object[] { "UyenNhi.Le26@yahoo.com", 38 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "Email", "EmployeeID" },
                keyValues: new object[] { "HanhVi33@yahoo.com", 39 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "Email", "EmployeeID" },
                keyValues: new object[] { "MaiAnh_Hoang3@hotmail.com", 40 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "Email", "EmployeeID" },
                keyValues: new object[] { "BanMai82@hotmail.com", 41 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "Email", "EmployeeID" },
                keyValues: new object[] { "AnhTuan95@hotmail.com", 42 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "Email", "EmployeeID" },
                keyValues: new object[] { "NgocDiep95@gmail.com", 43 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "Email", "EmployeeID" },
                keyValues: new object[] { "NguyetLan_Lam@hotmail.com", 44 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "Email", "EmployeeID" },
                keyValues: new object[] { "HanhTuong.Phung@yahoo.com", 45 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "Email", "EmployeeID" },
                keyValues: new object[] { "ThaoLinh_Trinh@yahoo.com", 46 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "Email", "EmployeeID" },
                keyValues: new object[] { "HongThao24@gmail.com", 47 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "Email", "EmployeeID" },
                keyValues: new object[] { "ChinhTruc68@hotmail.com", 48 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "Email", "EmployeeID" },
                keyValues: new object[] { "HaiGiang.Doan@hotmail.com", 49 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "Email", "EmployeeID" },
                keyValues: new object[] { "ThuMai.Dao@hotmail.com", 50 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "Email", "EmployeeID" },
                keyValues: new object[] { "HongQue.Ngo54@gmail.com", 51 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "Email", "EmployeeID" },
                keyValues: new object[] { "NgocLe.Phung66@yahoo.com", 52 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "Email", "EmployeeID" },
                keyValues: new object[] { "MinhThang_Lam@hotmail.com", 53 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "Email", "EmployeeID" },
                keyValues: new object[] { "SonTuyen.Tang63@hotmail.com", 54 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "Email", "EmployeeID" },
                keyValues: new object[] { "DucTuong_Vuong6@yahoo.com", 55 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "Email", "EmployeeID" },
                keyValues: new object[] { "HuyQuang95@gmail.com", 56 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "Email", "EmployeeID" },
                keyValues: new object[] { "PhuongDung.Vu@gmail.com", 57 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "Email", "EmployeeID" },
                keyValues: new object[] { "LanHuong_Ngo@hotmail.com", 58 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "Email", "EmployeeID" },
                keyValues: new object[] { "BaoAnh96@yahoo.com", 59 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "Email", "EmployeeID" },
                keyValues: new object[] { "CongHieu_Doan21@hotmail.com", 60 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "Email", "EmployeeID" },
                keyValues: new object[] { "TruongSa_Bui@yahoo.com", 61 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "Email", "EmployeeID" },
                keyValues: new object[] { "VietAn.Nguyen16@yahoo.com", 62 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "Email", "EmployeeID" },
                keyValues: new object[] { "XuanHanh.Nguyen@yahoo.com", 63 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "Email", "EmployeeID" },
                keyValues: new object[] { "DacDi27@gmail.com", 64 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "Email", "EmployeeID" },
                keyValues: new object[] { "HuuThong.Bui@gmail.com", 65 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "Email", "EmployeeID" },
                keyValues: new object[] { "TuyetNhung66@hotmail.com", 66 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "Email", "EmployeeID" },
                keyValues: new object[] { "NguyetHong_Phan@hotmail.com", 67 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "Email", "EmployeeID" },
                keyValues: new object[] { "KimLy24@gmail.com", 68 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "Email", "EmployeeID" },
                keyValues: new object[] { "QuangLoc.Truong@gmail.com", 69 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "Email", "EmployeeID" },
                keyValues: new object[] { "NhatNam38@hotmail.com", 70 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "Email", "EmployeeID" },
                keyValues: new object[] { "DucTuan_Dinh@hotmail.com", 71 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "Email", "EmployeeID" },
                keyValues: new object[] { "CamVan_Ho98@hotmail.com", 72 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "Email", "EmployeeID" },
                keyValues: new object[] { "KhaiCa_Tang64@gmail.com", 73 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "Email", "EmployeeID" },
                keyValues: new object[] { "HaoNhien_Ly@yahoo.com", 74 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "Email", "EmployeeID" },
                keyValues: new object[] { "PhuongUyen10@hotmail.com", 75 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "Email", "EmployeeID" },
                keyValues: new object[] { "LamDung22@gmail.com", 76 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "Email", "EmployeeID" },
                keyValues: new object[] { "DuyHoang_Dinh5@gmail.com", 77 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "Email", "EmployeeID" },
                keyValues: new object[] { "QuePhuong35@hotmail.com", 78 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "Email", "EmployeeID" },
                keyValues: new object[] { "XuanYen26@hotmail.com", 79 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "Email", "EmployeeID" },
                keyValues: new object[] { "TuyetTrinh.Trinh@hotmail.com", 80 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "Email", "EmployeeID" },
                keyValues: new object[] { "ThaoLinh_Phan@hotmail.com", 81 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "Email", "EmployeeID" },
                keyValues: new object[] { "KimSa.Vuong17@yahoo.com", 82 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "Email", "EmployeeID" },
                keyValues: new object[] { "ThuLam_Phan39@gmail.com", 83 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "Email", "EmployeeID" },
                keyValues: new object[] { "AnhTai_Dang@yahoo.com", 84 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "Email", "EmployeeID" },
                keyValues: new object[] { "ThaoHuong1@yahoo.com", 85 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "Email", "EmployeeID" },
                keyValues: new object[] { "TrucQuan.Truong19@gmail.com", 86 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "Email", "EmployeeID" },
                keyValues: new object[] { "QuangKhanh9@yahoo.com", 87 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "Email", "EmployeeID" },
                keyValues: new object[] { "ThuyHien27@gmail.com", 88 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "Email", "EmployeeID" },
                keyValues: new object[] { "TungLam_To75@hotmail.com", 89 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "Email", "EmployeeID" },
                keyValues: new object[] { "KimThu_Do@yahoo.com", 90 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "Email", "EmployeeID" },
                keyValues: new object[] { "ThuSinh.Tran97@yahoo.com", 91 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "Email", "EmployeeID" },
                keyValues: new object[] { "TienGiang_Le70@yahoo.com", 92 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "Email", "EmployeeID" },
                keyValues: new object[] { "MinhKhanh_Tran@yahoo.com", 93 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "Email", "EmployeeID" },
                keyValues: new object[] { "CamHien.Tran11@gmail.com", 94 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "Email", "EmployeeID" },
                keyValues: new object[] { "HongDao_To32@yahoo.com", 95 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "Email", "EmployeeID" },
                keyValues: new object[] { "HaiChau79@gmail.com", 96 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "Email", "EmployeeID" },
                keyValues: new object[] { "MyPhuong.Ho49@yahoo.com", 97 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "Email", "EmployeeID" },
                keyValues: new object[] { "MinhDat.Do@hotmail.com", 98 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "Email", "EmployeeID" },
                keyValues: new object[] { "HuuHoang_Vuong86@gmail.com", 99 });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "Email", "EmployeeID" },
                keyValues: new object[] { "ThaiTam_Dao46@hotmail.com", 100 });

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

            migrationBuilder.AddPrimaryKey(
                name: "PK_User",
                table: "User",
                columns: new[] { "EmployeeID", "RoleID" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 1,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Nam Định", "Trí Thắng Đoàn", new DateTime(2024, 5, 24, 22, 11, 34, 614, DateTimeKind.Local).AddTicks(3518), "DinhKim_Truong92@hotmail.com", "0933814297" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 2,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Bình Phước", "Minh Tuyết Đào", new DateTime(2024, 5, 24, 22, 11, 34, 614, DateTimeKind.Local).AddTicks(8314), "TrangTam76@yahoo.com", "0984615781" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 3,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Bà Rịa-Vũng Tàu", "Ðình Phúc Đào", new DateTime(2024, 5, 24, 22, 11, 34, 614, DateTimeKind.Local).AddTicks(8658), "MaiChau97@yahoo.com", "0983654975" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 4,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Lạng Sơn", "Hồng Giang Lâm", new DateTime(2024, 5, 24, 22, 11, 34, 614, DateTimeKind.Local).AddTicks(8867), "ToanThang_Mai13@yahoo.com", "0921687066" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 5,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Quảng Ninh", "Phượng Lệ Hà", new DateTime(2024, 5, 24, 22, 11, 34, 614, DateTimeKind.Local).AddTicks(9055), "KimNgoc_Phung18@hotmail.com", "0937470058" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 6,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Bà Rịa-Vũng Tàu", "Cường Dũng Đặng", new DateTime(2024, 5, 24, 22, 11, 34, 614, DateTimeKind.Local).AddTicks(9323), "HoaGiang.Le@gmail.com", "0941644536" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 7,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Tây Ninh", "Hồng Ngọc Đào", new DateTime(2024, 5, 24, 22, 11, 34, 614, DateTimeKind.Local).AddTicks(9505), "ThienNgon4@hotmail.com", "0983257815" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 8,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Nam Định", "Quốc Mạnh Hà", new DateTime(2024, 5, 24, 22, 11, 34, 614, DateTimeKind.Local).AddTicks(9684), "TrungChinh.Le@gmail.com", "0912210460" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 9,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Đắk Lắk", "Xuân Trung Mai", new DateTime(2024, 5, 24, 22, 11, 34, 614, DateTimeKind.Local).AddTicks(9852), "HoangLinh_To@yahoo.com", "0993965717" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 10,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Kon Tum", "Tài Ðức Trần", new DateTime(2024, 5, 24, 22, 11, 34, 615, DateTimeKind.Local).AddTicks(9), "KieuNga_Ly28@yahoo.com", "0977207525" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 11,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Lai Châu", "Thanh Kiên Ngô", new DateTime(2024, 5, 24, 22, 11, 34, 615, DateTimeKind.Local).AddTicks(264), "ThuyLinh49@yahoo.com", "0958835811" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 12,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Lai Châu", "Kim Phú Dương", new DateTime(2024, 5, 24, 22, 11, 34, 615, DateTimeKind.Local).AddTicks(423), "PhuocHue.Dinh64@yahoo.com", "0933755992" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 13,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Kiên Giang", "Thành Hòa Tăng", new DateTime(2024, 5, 24, 22, 11, 34, 615, DateTimeKind.Local).AddTicks(603), "HuyenTrang22@hotmail.com", "0993273211" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 14,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Nam Định", "Thảo Linh Tăng", new DateTime(2024, 5, 24, 22, 11, 34, 615, DateTimeKind.Local).AddTicks(771), "ThuongKiet65@yahoo.com", "0906684412" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 15,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Điện Biên", "Hiền Thục Hà", new DateTime(2024, 5, 24, 22, 11, 34, 615, DateTimeKind.Local).AddTicks(925), "GiaKhanh51@yahoo.com", "0957873797" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 16,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Lâm Đồng", "Ái Hồng Phạm", new DateTime(2024, 5, 24, 22, 11, 34, 615, DateTimeKind.Local).AddTicks(1202), "TuongChinh.Dao26@yahoo.com", "0980536444" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 17,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Thừa Thiên-Huế", "Thi Cầm Trịnh", new DateTime(2024, 5, 24, 22, 11, 34, 615, DateTimeKind.Local).AddTicks(1370), "ThaiMinh.Doan@gmail.com", "0960895586" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 18,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Cà Mau", "Hoàn Vũ Tăng", new DateTime(2024, 5, 24, 22, 11, 34, 615, DateTimeKind.Local).AddTicks(1523), "TuyetHuong_Ho77@gmail.com", "0943218263" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 19,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Hải Dương", "Thiên An Trịnh", new DateTime(2024, 5, 24, 22, 11, 34, 615, DateTimeKind.Local).AddTicks(1698), "MinhHien_Dang@yahoo.com", "0985301037" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 20,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Lào Cai", "Minh Hải Ngô", new DateTime(2024, 5, 24, 22, 11, 34, 615, DateTimeKind.Local).AddTicks(1853), "TuanLinh_Ly40@hotmail.com", "0922939814" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 21,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Vĩnh Phúc", "Hiền Hòa Đào", new DateTime(2024, 5, 24, 22, 11, 34, 615, DateTimeKind.Local).AddTicks(2003), "DuyenNuong.Duong22@hotmail.com", "0939079187" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 22,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Bắc Giang", "Tường Lân Trương", new DateTime(2024, 5, 24, 22, 11, 34, 615, DateTimeKind.Local).AddTicks(2184), "TanThanh29@yahoo.com", "0946052356" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 23,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Cao Bằng", "Huy Chiểu Bùi", new DateTime(2024, 5, 24, 22, 11, 34, 615, DateTimeKind.Local).AddTicks(2337), "NgocLam_Tran@gmail.com", "0923647719" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 24,
                columns: new[] { "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Ái Nhi Đoàn", new DateTime(2024, 5, 24, 22, 11, 34, 615, DateTimeKind.Local).AddTicks(2489), "HuongNhi.Ho24@gmail.com", "0986562792" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 25,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "TP. Hồ Chí Minh", "Thiên Bửu Phan", new DateTime(2024, 5, 24, 22, 11, 34, 615, DateTimeKind.Local).AddTicks(2642), "DaiNgoc_Lam46@gmail.com", "0943951539" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 26,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Hậu Giang", "Bách Nhân Tô", new DateTime(2024, 5, 24, 22, 11, 34, 615, DateTimeKind.Local).AddTicks(2816), "QuocThien18@yahoo.com", "0961853667" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 27,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Phú Thọ", "Thế Doanh Vương", new DateTime(2024, 5, 24, 22, 11, 34, 615, DateTimeKind.Local).AddTicks(2957), "QuynhGiang_Tang@yahoo.com", "0939365796" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 28,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Hậu Giang", "Thượng Năng Vương", new DateTime(2024, 5, 24, 22, 11, 34, 615, DateTimeKind.Local).AddTicks(3120), "UyenTram.Dinh66@hotmail.com", "0906816319" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 29,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Hà Nam", "Trúc Lan Lý", new DateTime(2024, 5, 24, 22, 11, 34, 615, DateTimeKind.Local).AddTicks(3282), "HuuNghi31@yahoo.com", "0973261855" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 30,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Đồng Nai", "Ðức Thành Phùng", new DateTime(2024, 5, 24, 22, 11, 34, 615, DateTimeKind.Local).AddTicks(3424), "XuanTruong.Tang@gmail.com", "0958105765" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 31,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Đồng Tháp", "Tuấn Tài Lý", new DateTime(2024, 5, 24, 22, 11, 34, 615, DateTimeKind.Local).AddTicks(3845), "DuyKhanh_Ho49@gmail.com", "0929050647" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 32,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Lào Cai", "Hữu Minh Đinh", new DateTime(2024, 5, 24, 22, 11, 34, 615, DateTimeKind.Local).AddTicks(3993), "DuyHieu67@yahoo.com", "0949399966" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 33,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Lâm Đồng", "Ái Nhân Phạm", new DateTime(2024, 5, 24, 22, 11, 34, 615, DateTimeKind.Local).AddTicks(4156), "AnHang_Tran@gmail.com", "0959560898" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 34,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Long An", "Ngọc Ðoàn Nguyễn", new DateTime(2024, 5, 24, 22, 11, 34, 615, DateTimeKind.Local).AddTicks(4295), "BaoDinh.Vuong@hotmail.com", "0977194053" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 35,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Quảng Trị", "Cao Tiến Hà", new DateTime(2024, 5, 24, 22, 11, 34, 615, DateTimeKind.Local).AddTicks(4455), "VietPhuong.Bui@gmail.com", "0985274217" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 36,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Gia Lai", "Quang Xuân Đào", new DateTime(2024, 5, 24, 22, 11, 34, 615, DateTimeKind.Local).AddTicks(4607), "MyLoi9@hotmail.com", "0911124183" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 37,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Thanh Hoá", "Mỹ Phương Phan", new DateTime(2024, 5, 24, 22, 11, 34, 615, DateTimeKind.Local).AddTicks(4776), "QuocVan.Do@gmail.com", "0908269081" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 38,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Bắc Giang", "Hữu Nghị Lê", new DateTime(2024, 5, 24, 22, 11, 34, 615, DateTimeKind.Local).AddTicks(4920), "VinhAn40@yahoo.com", "0944054748" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 39,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Đồng Nai", "Khánh Nam Phạm", new DateTime(2024, 5, 24, 22, 11, 34, 615, DateTimeKind.Local).AddTicks(5069), "HoangMinh_Dinh14@hotmail.com", "0955987219" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 40,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Quảng Nam", "Kim Loan Bùi", new DateTime(2024, 5, 24, 22, 11, 34, 615, DateTimeKind.Local).AddTicks(5231), "QuynhNhi_Tran92@hotmail.com", "0910059387" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 41,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Đồng Tháp", "Hiếu Nghĩa Đỗ", new DateTime(2024, 5, 24, 22, 11, 34, 615, DateTimeKind.Local).AddTicks(5381), "MinhTriet_Truong42@hotmail.com", "0953830190" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 42,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Phú Thọ", "Quốc Tiến Hoàng", new DateTime(2024, 5, 24, 22, 11, 34, 615, DateTimeKind.Local).AddTicks(5549), "QuocThang.Dang@hotmail.com", "0914895600" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 43,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Trà Vinh", "Vân Chi Lê", new DateTime(2024, 5, 24, 22, 11, 34, 615, DateTimeKind.Local).AddTicks(5700), "CongHai_Phan15@hotmail.com", "0957487744" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 44,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Tiền Giang", "Khánh Vi Phan", new DateTime(2024, 5, 24, 22, 11, 34, 615, DateTimeKind.Local).AddTicks(5877), "VietQuoc.Doan@gmail.com", "0983167369" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 45,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Yên Bái", "Minh Minh Ngô", new DateTime(2024, 5, 24, 22, 11, 34, 615, DateTimeKind.Local).AddTicks(6019), "XuanKhoa.Ha23@hotmail.com", "0932915015" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 46,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Cao Bằng", "Anh Tài Bùi", new DateTime(2024, 5, 24, 22, 11, 34, 615, DateTimeKind.Local).AddTicks(6170), "GiaKiet.Dang@hotmail.com", "0980411860" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 47,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Hải Dương", "Tâm Hạnh Lê", new DateTime(2024, 5, 24, 22, 11, 34, 615, DateTimeKind.Local).AddTicks(6311), "VanQuyen_Pham@gmail.com", "0928881161" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 48,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Yên Bái", "Mai Thu Dương", new DateTime(2024, 5, 24, 22, 11, 34, 615, DateTimeKind.Local).AddTicks(6475), "DongTra12@hotmail.com", "0938430459" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 49,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Nam Định", "Lệ Nhi Đỗ", new DateTime(2024, 5, 24, 22, 11, 34, 615, DateTimeKind.Local).AddTicks(6631), "ThienKhanh_Dao85@gmail.com", "0962607862" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 50,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Đồng Nai", "Xuân Hãn Vương", new DateTime(2024, 5, 24, 22, 11, 34, 615, DateTimeKind.Local).AddTicks(6782), "LamDung21@yahoo.com", "0987100876" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 51,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Quảng Nam", "Sỹ Thực Đỗ", new DateTime(2024, 5, 24, 22, 11, 34, 615, DateTimeKind.Local).AddTicks(6944), "NamHung.Hoang@yahoo.com", "0988903039" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 52,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Ninh Bình", "Tất Hòa Hoàng", new DateTime(2024, 5, 24, 22, 11, 34, 615, DateTimeKind.Local).AddTicks(7081), "MinhAn_Do@hotmail.com", "0905376467" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 53,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Tây Ninh", "Yến My Phùng", new DateTime(2024, 5, 24, 22, 11, 34, 615, DateTimeKind.Local).AddTicks(7224), "HuyThanh28@gmail.com", "0967796086" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 54,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Hà Nội", "Chí Bảo Hà", new DateTime(2024, 5, 24, 22, 11, 34, 615, DateTimeKind.Local).AddTicks(7366), "LinhChau_Do@yahoo.com", "0974035102" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 55,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Bắc Giang", "Diệu Ngà Ngô", new DateTime(2024, 5, 24, 22, 11, 34, 615, DateTimeKind.Local).AddTicks(7518), "DacLuc_Ho@hotmail.com", "0925957313" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 56,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Quảng Ngãi", "Kim Ðan Đinh", new DateTime(2024, 5, 24, 22, 11, 34, 615, DateTimeKind.Local).AddTicks(7654), "NhuNgoc30@hotmail.com", "0938575370" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 57,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Quảng Trị", "Duy Luận Đoàn", new DateTime(2024, 5, 24, 22, 11, 34, 615, DateTimeKind.Local).AddTicks(7810), "ThienAn1@yahoo.com", "0988598822" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 58,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Hà Nội", "Dạ Yến Tăng", new DateTime(2024, 5, 24, 22, 11, 34, 615, DateTimeKind.Local).AddTicks(7957), "NgocUyen.Phung47@gmail.com", "0953669949" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 59,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Quảng Bình", "Thái Lâm Trương", new DateTime(2024, 5, 24, 22, 11, 34, 615, DateTimeKind.Local).AddTicks(8116), "HuyKhiem_Bui@yahoo.com", "0920190765" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 60,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Ninh Bình", "Trường Nhân Đoàn", new DateTime(2024, 5, 24, 22, 11, 34, 615, DateTimeKind.Local).AddTicks(8256), "ThaiLan.Bui@gmail.com", "0926603478" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 61,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Cà Mau", "Gia Phong Nguyễn", new DateTime(2024, 5, 24, 22, 11, 34, 615, DateTimeKind.Local).AddTicks(8407), "NamPhuong.Dang@hotmail.com", "0921546860" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 62,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Đồng Nai", "An Hạ Đinh", new DateTime(2024, 5, 24, 22, 11, 34, 615, DateTimeKind.Local).AddTicks(8567), "ThuThuy.Ly@yahoo.com", "0969584004" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 63,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Hòa Bình", "Thu Oanh Phan", new DateTime(2024, 5, 24, 22, 11, 34, 615, DateTimeKind.Local).AddTicks(8705), "PhuHung.Pham43@yahoo.com", "0955547884" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 64,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Quảng Nam", "Hương Thảo Trịnh", new DateTime(2024, 5, 24, 22, 11, 34, 615, DateTimeKind.Local).AddTicks(8863), "VuongGia_Dao40@yahoo.com", "0957707798" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 65,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Kiên Giang", "Quỳnh Trang Dương", new DateTime(2024, 5, 24, 22, 11, 34, 615, DateTimeKind.Local).AddTicks(9015), "NhuLoan63@hotmail.com", "0955818604" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 66,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Lạng Sơn", "Tuyết Vy Phùng", new DateTime(2024, 5, 24, 22, 11, 34, 615, DateTimeKind.Local).AddTicks(9168), "ThuHau32@hotmail.com", "0931160893" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 67,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Thừa Thiên-Huế", "Lâm Tuyền Bùi", new DateTime(2024, 5, 24, 22, 11, 34, 615, DateTimeKind.Local).AddTicks(9300), "TrungNguyen_Tang42@hotmail.com", "0963541600" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 68,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Kon Tum", "Hạnh Vi Đỗ", new DateTime(2024, 5, 24, 22, 11, 34, 615, DateTimeKind.Local).AddTicks(9469), "AnhDao.Do75@hotmail.com", "0931851305" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 69,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Long An", "Phúc Thịnh Trịnh", new DateTime(2024, 5, 24, 22, 11, 34, 615, DateTimeKind.Local).AddTicks(9608), "BaoTran.Doan@hotmail.com", "0910100903" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 70,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Thái Nguyên", "Đăng Khương Nguyễn", new DateTime(2024, 5, 24, 22, 11, 34, 615, DateTimeKind.Local).AddTicks(9761), "GiaCan20@hotmail.com", "0986339631" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 71,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Hậu Giang", "Ðông Nguyên Đỗ", new DateTime(2024, 5, 24, 22, 11, 34, 615, DateTimeKind.Local).AddTicks(9901), "MaiKhoi_Phung@gmail.com", "0907603740" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 72,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Thái Bình", "Thái Thảo Trịnh", new DateTime(2024, 5, 24, 22, 11, 34, 616, DateTimeKind.Local).AddTicks(65), "NhanHong83@hotmail.com", "0998557377" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 73,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "An Giang", "Nhân Sâm Đỗ", new DateTime(2024, 5, 24, 22, 11, 34, 616, DateTimeKind.Local).AddTicks(210), "ChiAnh.Doan82@yahoo.com", "0987408005" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 74,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Thái Nguyên", "Như Hảo Lý", new DateTime(2024, 5, 24, 22, 11, 34, 616, DateTimeKind.Local).AddTicks(346), "HongLam84@gmail.com", "0938450868" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 75,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Trà Vinh", "Mỹ Khuyên Bùi", new DateTime(2024, 5, 24, 22, 11, 34, 616, DateTimeKind.Local).AddTicks(500), "HongNga_To72@yahoo.com", "0983914839" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 76,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Quảng Bình", "Ánh Trang Hồ", new DateTime(2024, 5, 24, 22, 11, 34, 616, DateTimeKind.Local).AddTicks(655), "BachYen44@yahoo.com", "0993021954" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 77,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Ninh Thuận", "Ngọc Hằng Đặng", new DateTime(2024, 5, 24, 22, 11, 34, 616, DateTimeKind.Local).AddTicks(852), "HanhNga_Vu1@yahoo.com", "0958402889" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 78,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Đồng Tháp", "Loan Châu Phạm", new DateTime(2024, 5, 24, 22, 11, 34, 616, DateTimeKind.Local).AddTicks(1001), "VietHuy.Bui89@yahoo.com", "0917504341" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 79,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Đà Nẵng", "Hữu Minh Vũ", new DateTime(2024, 5, 24, 22, 11, 34, 616, DateTimeKind.Local).AddTicks(1173), "PhuongUyen47@gmail.com", "0955601619" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 80,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Cao Bằng", "Minh Hiếu Vũ", new DateTime(2024, 5, 24, 22, 11, 34, 616, DateTimeKind.Local).AddTicks(1313), "ThanhXuan_Bui@hotmail.com", "0902919969" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 81,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Hà Giang", "Minh Khánh Hồ", new DateTime(2024, 5, 24, 22, 11, 34, 616, DateTimeKind.Local).AddTicks(1478), "UyenThy.Ngo@hotmail.com", "0915614307" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 82,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Tuyên Quang", "Hữu Tâm Lê", new DateTime(2024, 5, 24, 22, 11, 34, 616, DateTimeKind.Local).AddTicks(1625), "QuangNhan.Doan81@yahoo.com", "0901818222" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 83,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Bắc Kạn", "Sơn Quân Đoàn", new DateTime(2024, 5, 24, 22, 11, 34, 616, DateTimeKind.Local).AddTicks(1791), "DanQuynh.Lam96@gmail.com", "0982776782" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 84,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Lạng Sơn", "An Bình Vương", new DateTime(2024, 5, 24, 22, 11, 34, 616, DateTimeKind.Local).AddTicks(1938), "DucLong.Tran@yahoo.com", "0987777903" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 85,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Quảng Nam", "Bích San Đào", new DateTime(2024, 5, 24, 22, 11, 34, 616, DateTimeKind.Local).AddTicks(2099), "PhuongTien69@hotmail.com", "0919960119" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 86,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Hưng Yên", "Mạnh Trình Ngô", new DateTime(2024, 5, 24, 22, 11, 34, 616, DateTimeKind.Local).AddTicks(2278), "DuyThanh.Truong99@gmail.com", "0921115550" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 87,
                columns: new[] { "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Tố Loan Bùi", new DateTime(2024, 5, 24, 22, 11, 34, 616, DateTimeKind.Local).AddTicks(2430), "HoaiGiang_Trinh44@hotmail.com", "0944155470" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 88,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Tuyên Quang", "Viết Nhân Lâm", new DateTime(2024, 5, 24, 22, 11, 34, 616, DateTimeKind.Local).AddTicks(2605), "DucPhi50@hotmail.com", "0921392486" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 89,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Lào Cai", "Thiên Mai Đặng", new DateTime(2024, 5, 24, 22, 11, 34, 616, DateTimeKind.Local).AddTicks(2750), "LamDong.Vu@hotmail.com", "0928775690" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 90,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Nam Định", "Quang Vũ Mai", new DateTime(2024, 5, 24, 22, 11, 34, 616, DateTimeKind.Local).AddTicks(2904), "PhuocBinh.Hoang47@gmail.com", "0969435006" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 91,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Kon Tum", "Thanh Nhung Lâm", new DateTime(2024, 5, 24, 22, 11, 34, 616, DateTimeKind.Local).AddTicks(3056), "ThuyLinh.Mai@hotmail.com", "0934273343" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 92,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Khánh Hoà", "Hải Nhi Bùi", new DateTime(2024, 5, 24, 22, 11, 34, 616, DateTimeKind.Local).AddTicks(3223), "PhucHung.Truong36@hotmail.com", "0952746720" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 93,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Tuyên Quang", "Trí Minh Đào", new DateTime(2024, 5, 24, 22, 11, 34, 616, DateTimeKind.Local).AddTicks(3399), "BichQuyen_Vuong66@hotmail.com", "0914056015" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 94,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Tuyên Quang", "Hữu Chiến Bùi", new DateTime(2024, 5, 24, 22, 11, 34, 616, DateTimeKind.Local).AddTicks(3545), "KimLy85@gmail.com", "0915107490" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 95,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Vĩnh Long", "Ngọc Lân Đinh", new DateTime(2024, 5, 24, 22, 11, 34, 616, DateTimeKind.Local).AddTicks(3702), "BichNgoc_Truong@gmail.com", "0985946729" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 96,
                columns: new[] { "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Kim Ðan Đào", new DateTime(2024, 5, 24, 22, 11, 34, 616, DateTimeKind.Local).AddTicks(3853), "BichDao_Doan@hotmail.com", "0964565788" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 97,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Bắc Kạn", "Sỹ Phú Vũ", new DateTime(2024, 5, 24, 22, 11, 34, 616, DateTimeKind.Local).AddTicks(4005), "QuocDai.To@hotmail.com", "0906930614" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 98,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Kon Tum", "Tâm Như Phùng", new DateTime(2024, 5, 24, 22, 11, 34, 616, DateTimeKind.Local).AddTicks(4144), "KimThanh.Duong@hotmail.com", "0941747373" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 99,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Hà Nam", "Quỳnh Chi Trần", new DateTime(2024, 5, 24, 22, 11, 34, 616, DateTimeKind.Local).AddTicks(4319), "ChiLan_To10@gmail.com", "0924857029" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 100,
                columns: new[] { "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[] { "Kon Tum", "Ngọc Lâm Tô", new DateTime(2024, 5, 24, 22, 11, 34, 616, DateTimeKind.Local).AddTicks(4466), "ThuongXuan_Ngo9@hotmail.com", "0979204377" });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 132, 28328.186543784440000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 2, 2 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 189, 44893.698860416360000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 3, 3 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 124, 25107.04190911160000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 4, 4 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 172, 19240.518979822480000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 5, 5 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 106, 18035.402103435960000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 6, 6 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 172, 25515.093293423680000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 7, 7 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 173, 26614.355194975880000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 8, 8 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 143, 21945.787470759920000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 9, 9 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 162, 33618.207212190040000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 10, 10 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 145, 43702.444755315520000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 11, 11 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 111, 25737.339349827320000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 12, 12 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 139, 43310.382556663840000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 13, 13 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 161, 43332.836028926840000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 14, 14 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 147, 43364.079020305920000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 15, 15 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 146, 34551.892519206720000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 16, 16 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 109, 14185.643296989640000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 17, 17 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 199, 16483.58472233080000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 18, 18 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 170, 41378.222480170080000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 19, 19 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 174, 47537.324425955520000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 20, 20 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 124, 21130.58373238200000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 21, 21 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 143, 25105.462556470160000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 22, 22 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 121, 45836.98271512560000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 23, 23 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 168, 35543.755505170520000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 24, 24 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 131, 20953.992048154240000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 25, 25 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 137, 14129.766694647240000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 26, 26 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 135, 42061.825407433280000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 27, 27 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 119, 46236.212199777680000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 28, 28 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 146, 37258.673951091280000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 29, 29 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 188, 48496.254227801840000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 30, 30 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 177, 30126.092997585160000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 31, 31 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 118, 33677.722125252680000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 32, 32 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 168, 39119.802107512200000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 33, 33 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 130, 27327.789531948640000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 34, 34 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 185, 49183.197784451560000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 35, 35 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 173, 45917.752905047640000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 36, 36 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 200, 29956.923312704440000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 37, 37 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 116, 13752.9742661714240000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 38, 38 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 200, 25757.603083207280000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 39, 39 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 100, 10235.27394381490640000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 40, 40 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 192, 29930.543643887280000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 41, 41 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 100, 10147.04189522717560000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 42, 42 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 153, 35641.752535734520000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 43, 43 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 177, 22930.454236221760000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 44, 44 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 156, 22117.753180406280000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 45, 45 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 134, 24762.270106817440000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 46, 46 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 118, 13335.1175594798120000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 47, 47 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 155, 23550.189542709120000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 48, 48 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 124, 13228.6513662548040000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 49, 49 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 167, 37649.919445934240000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 50, 50 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 103, 39085.404429143040000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 51, 51 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 136, 21673.490233137640000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 52, 52 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 183, 25083.833951779920000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 53, 53 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 113, 31601.638940600600000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 54, 54 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 131, 12335.9849017970960000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 55, 55 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 155, 15175.774212125360000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 56, 56 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 153, 45341.942650090560000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 57, 57 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 192, 37140.16036717400000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 58, 58 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 122, 34853.716288309080000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 59, 59 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 185, 25663.741520213040000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 60, 60 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 133, 14873.005386991040000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 61, 61 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 155, 17276.542264402360000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 62, 62 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 198, 23596.350485880360000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 63, 63 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 125, 22699.172709929640000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 64, 64 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 104, 34405.469486424960000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 65, 65 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 168, 18334.982599119680000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 66, 66 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 133, 15125.923043081240000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 67, 67 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 161, 26595.804499539040000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 68, 68 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 163, 33442.857704555480000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 69, 69 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 178, 18498.966041599840000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 70, 70 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 102, 43604.529507479760000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 71, 71 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 191, 38390.162859258240000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 72, 72 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 123, 31583.536158804440000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 73, 73 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 151, 48836.76255182720000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 74, 74 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 146, 37086.164644823320000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 75, 75 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 169, 15295.77681782640000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 76, 76 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 103, 21904.929310224640000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 77, 77 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 126, 31317.652656002560000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 78, 78 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 180, 25774.924841286160000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 79, 79 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 197, 28131.640305991800000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 80, 80 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 137, 34353.616168887120000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 81, 81 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 171, 41113.08828943040000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 82, 82 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 153, 23312.349525397240000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 83, 83 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 136, 44612.907837331240000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 84, 84 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 167, 20789.55165731920000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 85, 85 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 164, 12328.898278241160000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 86, 86 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 127, 10831.82818390640000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 87, 87 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 105, 26577.186035737520000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 88, 88 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 143, 21829.999272394080000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 89, 89 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 107, 47553.074150048960000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 90, 90 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 106, 26564.788336882520000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 91, 91 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 122, 13899.034433074120000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 92, 92 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 143, 31380.721446261120000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 93, 93 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 161, 15231.241137678560000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 94, 94 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 172, 18175.249236545360000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 95, 95 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 196, 23701.909785761280000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 96, 96 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 178, 15360.788784479960000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 97, 97 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 150, 13312.6221392916440000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 98, 98 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 119, 14075.606915761000000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 99, 99 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 150, 12057.7310972274280000m });

            migrationBuilder.UpdateData(
                table: "DetailImportOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 100, 100 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 173, 17721.656013774040000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 68, 133097.32475970100000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 2, 2 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 55, 194848.311086153400000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 3, 3 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 78, 149549.829155052600000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 4, 4 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 74, 188388.360956424900000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 5, 5 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 72, 154079.447888605300000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 6, 6 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 78, 121042.44695696200000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 7, 7 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 60, 177577.118792848800000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 8, 8 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 52, 118973.342388621700000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 9, 9 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 74, 130186.036132288400000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 10, 10 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 89, 130810.555545931200000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 11, 11 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 50, 139395.650929282200000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 12, 12 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 72, 142844.495464783300000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 13, 13 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 67, 118129.390843544400000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 14, 14 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 82, 166465.575017999600000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 15, 15 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 81, 181386.396944395400000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 16, 16 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 68, 170901.613538069700000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 17, 17 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 50, 140886.233175170600000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 18, 18 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 64, 133806.273218142500000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 19, 19 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 80, 121195.011219889900000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 20, 20 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 64, 102761.7213242574300000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 21, 21 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 84, 163398.817450435100000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 22, 22 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 72, 181150.326391042100000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 23, 23 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 88, 119989.252857226100000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 24, 24 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 81, 118739.70049631300000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 25, 25 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 54, 102402.5171878582100000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 26, 26 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 88, 102529.9286382335200000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 27, 27 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 81, 174128.157803481900000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 28, 28 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 84, 102455.2580550116600000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 29, 29 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 88, 125775.524699103100000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 30, 30 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 74, 121844.726487367200000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 31, 31 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 69, 111814.584692170600000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 32, 32 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 69, 108569.1905168305700000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 33, 33 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 73, 174067.749982877400000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 34, 34 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 63, 124082.832326188900000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 35, 35 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 74, 105021.3565692139200000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 36, 36 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 51, 114432.792100339200000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 37, 37 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 63, 187293.593733905900000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 38, 38 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 88, 136097.6723922800000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 39, 39 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 76, 164220.160129826800000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 40, 40 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 60, 176976.628810418800000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 41, 41 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 53, 173445.748056130600000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 42, 42 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 86, 150972.504894427600000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 43, 43 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 80, 124006.845996609900000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 44, 44 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 78, 198265.485066557600000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 45, 45 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 53, 170531.414321895400000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 46, 46 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 82, 184075.787953276500000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 47, 47 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 87, 148309.826547143400000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 48, 48 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 71, 152580.563194401400000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 49, 49 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 82, 165000.482374804400000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 50, 50 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 85, 176592.248315502700000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 51, 51 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 64, 103854.1982301050600000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 52, 52 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 79, 152241.473919092600000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 53, 53 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 65, 194491.430882215700000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 54, 54 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 79, 176377.783521200600000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 55, 55 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 69, 197136.979972984900000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 56, 56 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 75, 149670.395303207200000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 57, 57 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 56, 158493.102140826700000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 58, 58 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 71, 162551.492645785400000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 59, 59 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 87, 177233.076081206500000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 60, 60 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 83, 196096.136831311600000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 61, 61 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 85, 105897.8925340955800000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 62, 62 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 88, 114932.539197352200000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 63, 63 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 50, 138293.031737673500000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 64, 64 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 79, 103057.4908424602400000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 65, 65 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 58, 184576.002587877400000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 66, 66 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 79, 158592.246182609700000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 67, 67 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 54, 151778.065425257100000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 68, 68 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 63, 168062.304605095700000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 69, 69 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 80, 119665.268342384600000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 70, 70 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 82, 149185.60806591700000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 71, 71 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 52, 149765.892484181900000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 72, 72 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 79, 168469.240939087200000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 73, 73 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 77, 137669.052666609200000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 74, 74 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 90, 131888.980103644100000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 75, 75 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 67, 179510.721053055200000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 76, 76 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 65, 128878.945178538500000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 77, 77 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 66, 132202.656868061800000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 78, 78 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 72, 112111.708055894600000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 79, 79 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 74, 165095.523961646900000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 80, 80 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 69, 171426.476356671200000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 81, 81 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 69, 126260.101927068400000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 82, 82 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 56, 107636.7707502311600000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 83, 83 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 51, 189584.023386307400000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 84, 84 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 80, 179295.407762446900000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 85, 85 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 56, 170682.683230291300000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 86, 86 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 60, 126834.975988206200000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 87, 87 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 84, 168180.662199521200000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 88, 88 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 52, 150937.265151798500000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 89, 89 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 78, 132584.46169818100000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 90, 90 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 51, 112315.030695966300000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 91, 91 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 84, 159056.829905260400000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 92, 92 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 64, 149842.789498377300000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 93, 93 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 59, 167983.945689264900000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 94, 94 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 68, 124818.707793841600000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 95, 95 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 72, 100137.26468682482300000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 96, 96 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 55, 108327.5259306495700000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 97, 97 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 69, 121831.235443074900000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 98, 98 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 64, 182914.550692701100000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 99, 99 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 66, 172322.955948080400000m });

            migrationBuilder.UpdateData(
                table: "DetailSalesOrder",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 100, 100 },
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 88, 147074.310989908300000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 1,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Hà Tĩnh", new DateTime(2024, 5, 24, 22, 11, 34, 626, DateTimeKind.Local).AddTicks(2673), "KhanhNgoc.Ha@yahoo.com", "Ðức Siêu Nguyễn", "0974854382", 924078.654278679000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 2,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Quảng Ngãi", new DateTime(2024, 5, 24, 22, 11, 34, 626, DateTimeKind.Local).AddTicks(6438), "NguyetMinh_Vuong93@yahoo.com", "Bảo Quỳnh Ngô", "0970379538", 713154.724020543500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 3,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Nghệ An", new DateTime(2024, 5, 24, 22, 11, 34, 626, DateTimeKind.Local).AddTicks(6717), "TamThien.Pham18@hotmail.com", "Ðức Tường Đinh", "0970359109", 617243.288909068000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 4,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "TP. Hồ Chí Minh", new DateTime(2024, 5, 24, 22, 11, 34, 626, DateTimeKind.Local).AddTicks(6817), "KhacTrieu86@gmail.com", "Thiên Giang Đặng", "0988144979", 978293.123375676500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 5,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Bình Dương", new DateTime(2024, 5, 24, 22, 11, 34, 626, DateTimeKind.Local).AddTicks(6908), "SonTung61@hotmail.com", "Minh Huyền Đặng", "0965052057", 695624.989167003000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 6,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Thái Nguyên", new DateTime(2024, 5, 24, 22, 11, 34, 626, DateTimeKind.Local).AddTicks(6996), "YenPhuong38@gmail.com", "Vân Phi Tô", "0913829559", 609508.575909669500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 7,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Ninh Bình", new DateTime(2024, 5, 24, 22, 11, 34, 626, DateTimeKind.Local).AddTicks(7055), "TheHuan15@yahoo.com", "Lâm Viên Dương", "0986099944", 661647.423072398500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 8,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Vĩnh Phúc", new DateTime(2024, 5, 24, 22, 11, 34, 626, DateTimeKind.Local).AddTicks(7110), "NghiXuan49@hotmail.com", "Tùy Anh Bùi", "0911534772", 666623.300959947000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 9,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Ninh Bình", new DateTime(2024, 5, 24, 22, 11, 34, 626, DateTimeKind.Local).AddTicks(7172), "PhuongTrieu.To68@gmail.com", "Thành Sang Đặng", "0937963216", 575775.897259802500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 10,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Bắc Giang", new DateTime(2024, 5, 24, 22, 11, 34, 626, DateTimeKind.Local).AddTicks(7227), "TuyetLoan92@hotmail.com", "Thùy Oanh Phan", "0970951217", 510254.610078261000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 11,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Đồng Tháp", new DateTime(2024, 5, 24, 22, 11, 34, 626, DateTimeKind.Local).AddTicks(7291), "DucTam_Dang67@gmail.com", "Duy Tuyền Lý", "0999627810", 595854.135620545500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 12,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Quảng Ngãi", new DateTime(2024, 5, 24, 22, 11, 34, 626, DateTimeKind.Local).AddTicks(7348), "ThuongNga_Duong27@yahoo.com", "An Nhàn Đoàn", "0958903135", 776285.678212991500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 13,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Yên Bái", new DateTime(2024, 5, 24, 22, 11, 34, 626, DateTimeKind.Local).AddTicks(7402), "ThieuBao.Tran@gmail.com", "Thống Nhất Ngô", "0901636644", 805323.979008199000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 14,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Đồng Tháp", new DateTime(2024, 5, 24, 22, 11, 34, 626, DateTimeKind.Local).AddTicks(7463), "DacLuc95@hotmail.com", "Ðạt Hòa Trịnh", "0934738088", 589455.815349200500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 15,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Gia Lai", new DateTime(2024, 5, 24, 22, 11, 34, 626, DateTimeKind.Local).AddTicks(7551), "MinhNguyet.Ho@yahoo.com", "Phương Chi Lê", "0902887573", 933289.681334011500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 16,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Phú Thọ", new DateTime(2024, 5, 24, 22, 11, 34, 626, DateTimeKind.Local).AddTicks(7637), "DanHiep83@gmail.com", "Phú Ân Tô", "0909254179", 521636.119834406500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 17,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Lâm Đồng", new DateTime(2024, 5, 24, 22, 11, 34, 626, DateTimeKind.Local).AddTicks(7728), "ChiThanh_Dinh@yahoo.com", "Ðan Quế Dương", "0953353208", 863948.178013593000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 18,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Nghệ An", new DateTime(2024, 5, 24, 22, 11, 34, 626, DateTimeKind.Local).AddTicks(7786), "VietTrinh.Dang87@hotmail.com", "Thúy Phượng Dương", "0966129751", 643500.792635840500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 19,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Hà Tĩnh", new DateTime(2024, 5, 24, 22, 11, 34, 626, DateTimeKind.Local).AddTicks(7841), "KhanhHoan_Mai99@hotmail.com", "Thiên Thảo Phùng", "0933466188", 997925.461591237000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 20,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Lâm Đồng", new DateTime(2024, 5, 24, 22, 11, 34, 626, DateTimeKind.Local).AddTicks(7902), "DacCuong.Duong41@yahoo.com", "Chính Tâm Trương", "0986888173", 942572.220182061000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 21,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Hậu Giang", new DateTime(2024, 5, 24, 22, 11, 34, 626, DateTimeKind.Local).AddTicks(7958), "DieuAi_Lam47@gmail.com", "Lam Giang Trần", "0963422766", 530584.5458487550500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 22,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Sơn La", new DateTime(2024, 5, 24, 22, 11, 34, 626, DateTimeKind.Local).AddTicks(8017), "HuuTan_Lam69@hotmail.com", "Chí Khang Phạm", "0920706037", 788663.849702333000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 23,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Tuyên Quang", new DateTime(2024, 5, 24, 22, 11, 34, 626, DateTimeKind.Local).AddTicks(8074), "PhuongTrang.Trinh44@hotmail.com", "Kim Thoa Đoàn", "0993862158", 663110.060940169500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 24,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Hà Tĩnh", new DateTime(2024, 5, 24, 22, 11, 34, 626, DateTimeKind.Local).AddTicks(8135), "ThanhThuan47@hotmail.com", "Quốc Hòa Phạm", "0929896256", 537473.0995452866000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 25,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Hà Nội", new DateTime(2024, 5, 24, 22, 11, 34, 626, DateTimeKind.Local).AddTicks(8195), "DuyHanh76@gmail.com", "Huy Kha Đặng", "0910187793", 895877.447653686000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 26,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Hà Nội", new DateTime(2024, 5, 24, 22, 11, 34, 626, DateTimeKind.Local).AddTicks(8249), "QuynhHoa10@yahoo.com", "Quốc Tiến Trần", "0972676126", 811385.188221733000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 27,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Thái Nguyên", new DateTime(2024, 5, 24, 22, 11, 34, 626, DateTimeKind.Local).AddTicks(8303), "ThuyMien.Vuong@hotmail.com", "Ngọc Thọ Hồ", "0968719156", 971381.772112768500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 28,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Hậu Giang", new DateTime(2024, 5, 24, 22, 11, 34, 626, DateTimeKind.Local).AddTicks(8369), "XuanNgoc.Dinh@yahoo.com", "Tâm Khanh Vũ", "0900885881", 753795.403269191500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 29,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Bến Tre", new DateTime(2024, 5, 24, 22, 11, 34, 626, DateTimeKind.Local).AddTicks(8424), "LamNgoc.Vu@hotmail.com", "Duy Tuyền Đặng", "0906084891", 606408.26488744000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 30,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Bắc Ninh", new DateTime(2024, 5, 24, 22, 11, 34, 626, DateTimeKind.Local).AddTicks(8476), "ManhDinh_Hoang@gmail.com", "Uyển Khanh Phạm", "0969412641", 503745.41401184430500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 31,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Đắk Nông", new DateTime(2024, 5, 24, 22, 11, 34, 626, DateTimeKind.Local).AddTicks(8537), "VanAnh98@gmail.com", "Duy Thạch Dương", "0956648940", 746325.970505692000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 32,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Phú Yên", new DateTime(2024, 5, 24, 22, 11, 34, 626, DateTimeKind.Local).AddTicks(8591), "DiemHang12@hotmail.com", "Phượng Tiên Đinh", "0918119002", 621101.740738408000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 33,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Phú Yên", new DateTime(2024, 5, 24, 22, 11, 34, 626, DateTimeKind.Local).AddTicks(8645), "ThienDuc.Hoang@yahoo.com", "Minh Tuyết Vũ", "0930244901", 704413.012437126000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 34,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Bình Dương", new DateTime(2024, 5, 24, 22, 11, 34, 626, DateTimeKind.Local).AddTicks(8703), "GiaCan.To66@hotmail.com", "Tú Anh Phùng", "0995126734", 504725.31060510539500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 35,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Quảng Trị", new DateTime(2024, 5, 24, 22, 11, 34, 626, DateTimeKind.Local).AddTicks(8758), "LeNga15@gmail.com", "Diệu Ái Ngô", "0996165463", 620348.386661763000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 36,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Phú Thọ", new DateTime(2024, 5, 24, 22, 11, 34, 626, DateTimeKind.Local).AddTicks(8817), "VanAnh.Le@yahoo.com", "Minh Yến Vũ", "0959130019", 826443.585030883500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 37,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Hà Nội", new DateTime(2024, 5, 24, 22, 11, 34, 626, DateTimeKind.Local).AddTicks(8870), "NgocCam_Tang@gmail.com", "Hữu Toàn Bùi", "0977151670", 646522.60429268500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 38,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Trà Vinh", new DateTime(2024, 5, 24, 22, 11, 34, 626, DateTimeKind.Local).AddTicks(8923), "ThaiMinh.Doan@yahoo.com", "Quang Trọng Tô", "0943307298", 683584.099386428500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 39,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Ninh Bình", new DateTime(2024, 5, 24, 22, 11, 34, 626, DateTimeKind.Local).AddTicks(8982), "QuynhThanh_Phan88@hotmail.com", "Thủy Hồng Lâm", "0913195912", 542911.6480203373000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 40,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Yên Bái", new DateTime(2024, 5, 24, 22, 11, 34, 626, DateTimeKind.Local).AddTicks(9036), "NguyenBao.Phung61@yahoo.com", "Phương Trà Hồ", "0988535955", 512678.7201548715500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 41,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Bình Phước", new DateTime(2024, 5, 24, 22, 11, 34, 626, DateTimeKind.Local).AddTicks(9091), "QuangThang34@hotmail.com", "Nguyên Bảo Đặng", "0913613832", 617977.416640987500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 42,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Tây Ninh", new DateTime(2024, 5, 24, 22, 11, 34, 626, DateTimeKind.Local).AddTicks(9150), "BaoThach.Doan93@gmail.com", "Khắc Ninh Mai", "0975895869", 799061.052195197000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 43,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Phú Thọ", new DateTime(2024, 5, 24, 22, 11, 34, 626, DateTimeKind.Local).AddTicks(9204), "BichDao.Ha@hotmail.com", "Huy Khánh Lâm", "0937329225", 584445.962994343000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 44,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Kiên Giang", new DateTime(2024, 5, 24, 22, 11, 34, 626, DateTimeKind.Local).AddTicks(9256), "CongHao_Dang@gmail.com", "Quang Nhân Ngô", "0952515823", 874703.104546682000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 45,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Vĩnh Phúc", new DateTime(2024, 5, 24, 22, 11, 34, 626, DateTimeKind.Local).AddTicks(9317), "ThachTung.Dao@gmail.com", "Xuân Hân Bùi", "0976906349", 688333.986179066000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 46,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Bắc Ninh", new DateTime(2024, 5, 24, 22, 11, 34, 626, DateTimeKind.Local).AddTicks(9371), "NhatPhuong98@hotmail.com", "Hoàng Xuân Phùng", "0953187740", 946059.651193453000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 47,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Bạc Liêu", new DateTime(2024, 5, 24, 22, 11, 34, 626, DateTimeKind.Local).AddTicks(9430), "KhanhQuynh.To@hotmail.com", "Nhật Lệ Lê", "0990930569", 544241.0556605571000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 48,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Phú Thọ", new DateTime(2024, 5, 24, 22, 11, 34, 626, DateTimeKind.Local).AddTicks(9487), "HaPhuong.Vuong@hotmail.com", "Kim Ánh Đỗ", "0901992550", 869294.640943503000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 49,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Bắc Ninh", new DateTime(2024, 5, 24, 22, 11, 34, 626, DateTimeKind.Local).AddTicks(9540), "HaiNguyen_Doan31@yahoo.com", "Huy Vũ Trần", "0957211269", 915156.271807406500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 50,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Lai Châu", new DateTime(2024, 5, 24, 22, 11, 34, 626, DateTimeKind.Local).AddTicks(9599), "LuongTuyen53@yahoo.com", "Xuân Thuyết Mai", "0936883113", 504262.41584198833000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 51,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Vĩnh Long", new DateTime(2024, 5, 24, 22, 11, 34, 626, DateTimeKind.Local).AddTicks(9654), "ThanhThanh.Duong53@yahoo.com", "Tuấn Long Phan", "0987889093", 897402.363551082000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 52,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "TP. Hồ Chí Minh", new DateTime(2024, 5, 24, 22, 11, 34, 626, DateTimeKind.Local).AddTicks(9707), "KimKhanh.Dao@hotmail.com", "An Hằng Lê", "0942287629", 725322.475265299000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 53,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Hà Tĩnh", new DateTime(2024, 5, 24, 22, 11, 34, 626, DateTimeKind.Local).AddTicks(9766), "AnhTung_Bui@hotmail.com", "Hồng Hoa Mai", "0996583916", 923175.938215956000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 54,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Sóc Trăng", new DateTime(2024, 5, 24, 22, 11, 34, 626, DateTimeKind.Local).AddTicks(9820), "TuanAnh90@gmail.com", "Tấn Trương Vương", "0996305063", 788859.420185914500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 55,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Sơn La", new DateTime(2024, 5, 24, 22, 11, 34, 626, DateTimeKind.Local).AddTicks(9872), "NgocTho.Mai@hotmail.com", "Ðăng Minh Lâm", "0921541054", 818349.52941923000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 56,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Vĩnh Long", new DateTime(2024, 5, 24, 22, 11, 34, 626, DateTimeKind.Local).AddTicks(9930), "HoaHiep.Phan@hotmail.com", "Thanh Tâm Lý", "0997173563", 846008.94741587000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 57,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Thái Nguyên", new DateTime(2024, 5, 24, 22, 11, 34, 626, DateTimeKind.Local).AddTicks(9983), "TueLam_Vu64@hotmail.com", "Trúc Lâm Ngô", "0946606038", 585119.136668513500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 58,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Phú Thọ", new DateTime(2024, 5, 24, 22, 11, 34, 627, DateTimeKind.Local).AddTicks(45), "PhuongNgoc54@hotmail.com", "Hoàng Dũng Bùi", "0941063815", 831727.099529628000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 59,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Hậu Giang", new DateTime(2024, 5, 24, 22, 11, 34, 627, DateTimeKind.Local).AddTicks(100), "ThuanHau_Vu87@yahoo.com", "Nguyệt Nga Phùng", "0919193024", 790136.837932514500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 60,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Nghệ An", new DateTime(2024, 5, 24, 22, 11, 34, 627, DateTimeKind.Local).AddTicks(155), "KhanhHai_Vu97@hotmail.com", "Tố Nhi Đào", "0959271635", 932381.538918976000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 61,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Thái Bình", new DateTime(2024, 5, 24, 22, 11, 34, 627, DateTimeKind.Local).AddTicks(217), "TuanSy44@yahoo.com", "Diệu Hương Trịnh", "0968980555", 978323.779410969000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 62,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Kon Tum", new DateTime(2024, 5, 24, 22, 11, 34, 627, DateTimeKind.Local).AddTicks(271), "HongTam10@yahoo.com", "Ngọc Thuận Lý", "0946280034", 558447.623218106000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 63,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Hải Dương", new DateTime(2024, 5, 24, 22, 11, 34, 627, DateTimeKind.Local).AddTicks(323), "HongQuang_Phan45@hotmail.com", "Mỹ Xuân Dương", "0977878052", 574300.746249745500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 64,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Kon Tum", new DateTime(2024, 5, 24, 22, 11, 34, 627, DateTimeKind.Local).AddTicks(386), "KimDan59@yahoo.com", "Bảo Ngọc Hoàng", "0912147452", 671207.741924070500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 65,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Đồng Nai", new DateTime(2024, 5, 24, 22, 11, 34, 627, DateTimeKind.Local).AddTicks(442), "KieuThu_Mai@hotmail.com", "Chính Trực Tô", "0992250060", 808180.228474667500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 66,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Hà Tĩnh", new DateTime(2024, 5, 24, 22, 11, 34, 627, DateTimeKind.Local).AddTicks(497), "DuyKinh31@hotmail.com", "Thùy My Đoàn", "0949899404", 719548.320942807000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 67,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Hà Nội", new DateTime(2024, 5, 24, 22, 11, 34, 627, DateTimeKind.Local).AddTicks(562), "HuuLuong_To59@yahoo.com", "Nhật Quân Lý", "0923927322", 927714.645171771000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 68,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Bắc Giang", new DateTime(2024, 5, 24, 22, 11, 34, 627, DateTimeKind.Local).AddTicks(617), "PhuongLan.Le@gmail.com", "Mỹ Phụng Vũ", "0957266898", 984473.964537092500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 69,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Kiên Giang", new DateTime(2024, 5, 24, 22, 11, 34, 627, DateTimeKind.Local).AddTicks(678), "ThuyLieu41@yahoo.com", "Trung Kiên Trương", "0917013741", 704287.106477135500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 70,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Bình Dương", new DateTime(2024, 5, 24, 22, 11, 34, 627, DateTimeKind.Local).AddTicks(738), "HieuHoc43@gmail.com", "Thuận Anh Phan", "0915635644", 954698.191261774000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 71,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Cần Thơ", new DateTime(2024, 5, 24, 22, 11, 34, 627, DateTimeKind.Local).AddTicks(792), "BichHien.Vuong@yahoo.com", "Thảo My Phan", "0959791030", 851607.034575232000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 72,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Đắk Lắk", new DateTime(2024, 5, 24, 22, 11, 34, 627, DateTimeKind.Local).AddTicks(852), "ThienTinh.Ha@yahoo.com", "Phong Lan Trần", "0943558063", 725705.326131485500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 73,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Thừa Thiên-Huế", new DateTime(2024, 5, 24, 22, 11, 34, 627, DateTimeKind.Local).AddTicks(906), "PhiHung_Bui69@yahoo.com", "Từ Ân Tô", "0911171066", 760305.860660995500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 74,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Bến Tre", new DateTime(2024, 5, 24, 22, 11, 34, 627, DateTimeKind.Local).AddTicks(960), "PhuongChi_To@gmail.com", "Mộng Nguyệt Hà", "0975636348", 900511.20081182500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 75,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Cà Mau", new DateTime(2024, 5, 24, 22, 11, 34, 627, DateTimeKind.Local).AddTicks(1018), "ThanhVinh.Phan5@hotmail.com", "Bảo Sơn Đinh", "0932396517", 910875.374463794000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 76,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Bắc Ninh", new DateTime(2024, 5, 24, 22, 11, 34, 627, DateTimeKind.Local).AddTicks(1074), "ThuyDu.Mai89@yahoo.com", "Tố Tâm Tăng", "0997082352", 901261.293935234500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 77,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Quảng Ngãi", new DateTime(2024, 5, 24, 22, 11, 34, 627, DateTimeKind.Local).AddTicks(1127), "HaiNhi.Dang@yahoo.com", "Lệ Khanh Trần", "0992297488", 858948.715291828000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 78,
                columns: new[] { "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { new DateTime(2024, 5, 24, 22, 11, 34, 627, DateTimeKind.Local).AddTicks(1190), "ThanhY.Truong29@hotmail.com", "Ðức Kiên Ngô", "0985083561", 928266.274705446000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 79,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Vĩnh Phúc", new DateTime(2024, 5, 24, 22, 11, 34, 627, DateTimeKind.Local).AddTicks(1245), "QuocTruong74@gmail.com", "Quang Hùng Phùng", "0989866146", 556448.902232829000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 80,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Thái Bình", new DateTime(2024, 5, 24, 22, 11, 34, 627, DateTimeKind.Local).AddTicks(1301), "HaiMien57@hotmail.com", "Minh Giang Đào", "0927383039", 818269.347682751000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 81,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Thái Bình", new DateTime(2024, 5, 24, 22, 11, 34, 627, DateTimeKind.Local).AddTicks(1361), "KienBinh_Ly@yahoo.com", "Gia Kiên Phùng", "0974416337", 874043.489450619000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 82,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Bắc Ninh", new DateTime(2024, 5, 24, 22, 11, 34, 627, DateTimeKind.Local).AddTicks(1416), "NgocKhanh91@hotmail.com", "Hoàng Minh Lâm", "0948284909", 683276.797667213500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 83,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Bình Thuận", new DateTime(2024, 5, 24, 22, 11, 34, 627, DateTimeKind.Local).AddTicks(1475), "QuangKhanh20@gmail.com", "Thanh Huyền Trịnh", "0961045688", 937123.046110898500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 84,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Thái Nguyên", new DateTime(2024, 5, 24, 22, 11, 34, 627, DateTimeKind.Local).AddTicks(1532), "MinhTan_Bui41@hotmail.com", "Trường Kỳ Lý", "0926676642", 795489.09926980500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 85,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Phú Thọ", new DateTime(2024, 5, 24, 22, 11, 34, 627, DateTimeKind.Local).AddTicks(1586), "TinhTu64@hotmail.com", "Minh Nhu Trịnh", "0952991321", 687102.724181221500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 86,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Tây Ninh", new DateTime(2024, 5, 24, 22, 11, 34, 627, DateTimeKind.Local).AddTicks(1644), "VietSon_Dinh43@hotmail.com", "Ðình Thắng Ngô", "0937336709", 717232.739927219500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 87,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Bình Định", new DateTime(2024, 5, 24, 22, 11, 34, 627, DateTimeKind.Local).AddTicks(1701), "CamHuong79@hotmail.com", "Yến Loan Lê", "0946870125", 751645.678701208000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 88,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Quảng Ngãi", new DateTime(2024, 5, 24, 22, 11, 34, 627, DateTimeKind.Local).AddTicks(1754), "DanThu_Ho@hotmail.com", "Bảo Duy Trần", "0927464824", 520549.1882446888000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 89,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Quảng Trị", new DateTime(2024, 5, 24, 22, 11, 34, 627, DateTimeKind.Local).AddTicks(1821), "VietKhoi.Mai24@gmail.com", "Trâm Oanh Đặng", "0987716903", 600061.780932377500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 90,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Kon Tum", new DateTime(2024, 5, 24, 22, 11, 34, 627, DateTimeKind.Local).AddTicks(1907), "KimThanh_Bui7@yahoo.com", "Diệu Hoa Vương", "0973381104", 824530.498796956500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 91,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Lai Châu", new DateTime(2024, 5, 24, 22, 11, 34, 627, DateTimeKind.Local).AddTicks(1992), "TruongLong85@hotmail.com", "Trí Hùng Nguyễn", "0985734679", 630644.656452470500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 92,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Lạng Sơn", new DateTime(2024, 5, 24, 22, 11, 34, 627, DateTimeKind.Local).AddTicks(2071), "KienBinh_Phung@hotmail.com", "Hiểu Lam Trương", "0953161302", 623609.153507351000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 93,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Sơn La", new DateTime(2024, 5, 24, 22, 11, 34, 627, DateTimeKind.Local).AddTicks(2124), "HoangNgon.Vuong@yahoo.com", "Huy Chiểu Đào", "0963384385", 539807.5098915934000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 94,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Đồng Nai", new DateTime(2024, 5, 24, 22, 11, 34, 627, DateTimeKind.Local).AddTicks(2184), "GiaoKieu_Dinh86@yahoo.com", "Kim Đan Đinh", "0989779485", 968968.771773994000000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 95,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Bạc Liêu", new DateTime(2024, 5, 24, 22, 11, 34, 627, DateTimeKind.Local).AddTicks(2237), "TruongNhan74@gmail.com", "Tuấn Châu Hà", "0935730825", 764534.148705478500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 96,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Quảng Ninh", new DateTime(2024, 5, 24, 22, 11, 34, 627, DateTimeKind.Local).AddTicks(2290), "SonQuyen_Phung@yahoo.com", "Nguyệt Hồng Phạm", "0924001840", 928085.207545710500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 97,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Hà Nội", new DateTime(2024, 5, 24, 22, 11, 34, 627, DateTimeKind.Local).AddTicks(2350), "HaGiang_Mai@gmail.com", "Ðức Toàn Đoàn", "0964248461", 979395.175698643500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 98,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Đồng Nai", new DateTime(2024, 5, 24, 22, 11, 34, 627, DateTimeKind.Local).AddTicks(2404), "DongVy64@hotmail.com", "Phương Thùy Dương", "0913581544", 969693.376831364500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 99,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Đồng Tháp", new DateTime(2024, 5, 24, 22, 11, 34, 627, DateTimeKind.Local).AddTicks(2455), "DuyCan_Duong@yahoo.com", "Nguyên Khôi Vương", "0950977965", 518466.1820319201500000m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 100,
                columns: new[] { "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[] { "Ninh Bình", new DateTime(2024, 5, 24, 22, 11, 34, 627, DateTimeKind.Local).AddTicks(2530), "XuanTrang_Tran@yahoo.com", "Minh Châu Tăng", "0961628003", 850433.686403567000000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 1,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 98, new DateTime(2024, 5, 25, 5, 51, 24, 725, DateTimeKind.Unspecified).AddTicks(5276), 26, 3739320.623779546080000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 2,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 22, new DateTime(2024, 5, 16, 10, 54, 29, 188, DateTimeKind.Unspecified).AddTicks(9072), 43, 8484909.084618692040000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 3,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 45, new DateTime(2024, 5, 1, 19, 25, 55, 837, DateTimeKind.Unspecified).AddTicks(2032), 57, 3113273.19672983840000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 4,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 75, new DateTime(2024, 5, 20, 6, 18, 34, 806, DateTimeKind.Unspecified).AddTicks(2101), 80, 3309369.264529466560000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 5,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 18, new DateTime(2024, 5, 8, 4, 0, 3, 289, DateTimeKind.Unspecified).AddTicks(6644), 57, 1911752.622964211760000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 6,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 44, new DateTime(2024, 5, 12, 18, 36, 13, 367, DateTimeKind.Unspecified).AddTicks(1742), 100, 4388596.046468872960000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 7,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 37, new DateTime(2024, 5, 10, 12, 32, 31, 229, DateTimeKind.Unspecified).AddTicks(9369), 95, 4604283.448730827240000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 8,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 39, new DateTime(2024, 5, 17, 18, 37, 24, 841, DateTimeKind.Unspecified).AddTicks(53), 24, 3138247.608318668560000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 9,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 41, new DateTime(2024, 5, 19, 18, 44, 5, 677, DateTimeKind.Unspecified).AddTicks(3518), 11, 5446149.568374786480000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 10,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 34, new DateTime(2024, 5, 21, 14, 12, 33, 457, DateTimeKind.Unspecified).AddTicks(3284), 37, 6336854.489520750400000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 11,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 75, new DateTime(2024, 5, 13, 10, 13, 37, 935, DateTimeKind.Unspecified).AddTicks(4383), 96, 2856844.667830832520000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 12,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 43, new DateTime(2024, 5, 3, 17, 52, 30, 254, DateTimeKind.Unspecified).AddTicks(406), 62, 6020143.175376273760000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 13,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 63, new DateTime(2024, 5, 17, 2, 0, 14, 602, DateTimeKind.Unspecified).AddTicks(8554), 8, 6976586.600657221240000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 14,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 8, new DateTime(2024, 5, 25, 4, 51, 18, 228, DateTimeKind.Unspecified).AddTicks(7566), 37, 6374519.615984970240000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 15,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 25, new DateTime(2024, 5, 2, 23, 15, 6, 545, DateTimeKind.Unspecified).AddTicks(8063), 24, 5044576.307804181120000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 16,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 56, new DateTime(2024, 5, 18, 4, 16, 1, 52, DateTimeKind.Unspecified).AddTicks(5924), 82, 1546235.119371870760000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 17,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 14, new DateTime(2024, 5, 4, 23, 0, 9, 381, DateTimeKind.Unspecified).AddTicks(128), 13, 3280233.35974382920000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 18,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 53, new DateTime(2024, 5, 2, 22, 51, 20, 591, DateTimeKind.Unspecified).AddTicks(3039), 10, 7034297.821628913600000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 19,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 13, new DateTime(2024, 5, 18, 9, 35, 9, 154, DateTimeKind.Unspecified).AddTicks(2379), 77, 8271494.450116260480000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 20,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 49, new DateTime(2024, 5, 14, 7, 54, 32, 297, DateTimeKind.Unspecified).AddTicks(7496), 100, 2620192.38281536800000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 21,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 4, new DateTime(2024, 5, 23, 18, 14, 20, 465, DateTimeKind.Unspecified).AddTicks(1019), 18, 3590081.145575232880000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 22,
                columns: new[] { "EmployeeID", "OrderDate", "TotalPrice" },
                values: new object[] { 68, new DateTime(2024, 5, 16, 11, 1, 49, 773, DateTimeKind.Unspecified).AddTicks(3972), 5546274.90853019760000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 23,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 9, new DateTime(2024, 5, 17, 3, 31, 48, 75, DateTimeKind.Unspecified).AddTicks(6974), 9, 5971350.924868647360000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 24,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 39, new DateTime(2024, 5, 14, 2, 11, 3, 860, DateTimeKind.Unspecified).AddTicks(2862), 92, 2744972.958308205440000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 25,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 9, new DateTime(2024, 5, 8, 16, 53, 51, 171, DateTimeKind.Unspecified).AddTicks(9985), 81, 1935778.037166671880000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 26,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 56, new DateTime(2024, 5, 26, 23, 8, 15, 684, DateTimeKind.Unspecified).AddTicks(3358), 37, 5678346.430003492800000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 27,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 32, new DateTime(2024, 5, 6, 20, 38, 32, 577, DateTimeKind.Unspecified).AddTicks(3302), 38, 5502109.251773543920000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 28,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 53, new DateTime(2024, 5, 25, 17, 26, 47, 836, DateTimeKind.Unspecified).AddTicks(8205), 76, 5439766.396859326880000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 29,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 88, new DateTime(2024, 5, 13, 20, 31, 52, 602, DateTimeKind.Unspecified).AddTicks(9009), 97, 9117295.794826745920000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 30,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 30, new DateTime(2024, 5, 8, 20, 36, 57, 546, DateTimeKind.Unspecified).AddTicks(2046), 24, 5332318.460572573320000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 31,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 68, new DateTime(2024, 5, 18, 6, 14, 46, 38, DateTimeKind.Unspecified).AddTicks(6975), 60, 3973971.210779816240000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 32,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 13, new DateTime(2024, 5, 4, 16, 43, 37, 300, DateTimeKind.Unspecified).AddTicks(7170), 73, 6572126.754062049600000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 33,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 32, new DateTime(2024, 5, 11, 8, 37, 22, 78, DateTimeKind.Unspecified).AddTicks(9069), 16, 3552612.639153323200000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 34,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 94, new DateTime(2024, 5, 8, 6, 34, 52, 359, DateTimeKind.Unspecified).AddTicks(2092), 99, 9098891.590123538600000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 35,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 52, new DateTime(2024, 5, 25, 12, 23, 38, 706, DateTimeKind.Unspecified).AddTicks(5376), 48, 7943771.252573241720000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 36,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 95, new DateTime(2024, 5, 10, 20, 16, 59, 827, DateTimeKind.Unspecified).AddTicks(2406), 39, 5991384.662540888000000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 37,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 40, new DateTime(2024, 5, 17, 9, 9, 16, 926, DateTimeKind.Unspecified).AddTicks(3944), 22, 1595345.0148758851840000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 38,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 6, new DateTime(2024, 5, 15, 22, 8, 11, 248, DateTimeKind.Unspecified).AddTicks(9830), 13, 5151520.616641456000000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 39,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 43, new DateTime(2024, 5, 11, 14, 14, 12, 609, DateTimeKind.Unspecified).AddTicks(5954), 14, 1023527.39438149064000000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 40,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 75, new DateTime(2024, 5, 12, 19, 45, 44, 253, DateTimeKind.Unspecified).AddTicks(1203), 21, 5746664.379626357760000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 41,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 40, new DateTime(2024, 5, 13, 8, 20, 17, 494, DateTimeKind.Unspecified).AddTicks(3308), 20, 1014704.18952271756000000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 42,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 89, new DateTime(2024, 5, 21, 21, 51, 51, 11, DateTimeKind.Unspecified).AddTicks(143), 90, 5453188.137967381560000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 43,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 17, new DateTime(2024, 5, 3, 12, 44, 5, 804, DateTimeKind.Unspecified).AddTicks(6012), 52, 4058690.399811251520000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 44,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 91, new DateTime(2024, 5, 20, 6, 27, 2, 157, DateTimeKind.Unspecified).AddTicks(1726), 98, 3450369.496143379680000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 45,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 24, new DateTime(2024, 5, 3, 7, 24, 9, 771, DateTimeKind.Unspecified).AddTicks(2720), 68, 3318144.194313536960000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 46,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 39, new DateTime(2024, 5, 4, 11, 9, 49, 376, DateTimeKind.Unspecified).AddTicks(2686), 20, 1573543.8720186178160000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 47,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 7, new DateTime(2024, 5, 10, 18, 39, 42, 403, DateTimeKind.Unspecified).AddTicks(8687), 49, 3650279.379119913600000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 48,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 51, new DateTime(2024, 5, 28, 15, 1, 31, 770, DateTimeKind.Unspecified).AddTicks(7683), 55, 1640352.7694155956960000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 49,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 10, new DateTime(2024, 5, 1, 19, 13, 28, 808, DateTimeKind.Unspecified).AddTicks(6842), 15, 6287536.547471018080000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 50,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 40, new DateTime(2024, 5, 29, 18, 24, 11, 794, DateTimeKind.Unspecified).AddTicks(1504), 19, 4025796.656201733120000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 51,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 82, new DateTime(2024, 5, 17, 18, 27, 2, 942, DateTimeKind.Unspecified).AddTicks(29), 44, 2947594.671706719040000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 52,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 52, new DateTime(2024, 5, 21, 20, 51, 2, 817, DateTimeKind.Unspecified).AddTicks(3681), 61, 4590341.613175725360000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 53,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 37, new DateTime(2024, 5, 18, 2, 55, 19, 27, DateTimeKind.Unspecified).AddTicks(5151), 58, 3570985.200287867800000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 54,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 39, new DateTime(2024, 5, 3, 23, 32, 5, 42, DateTimeKind.Unspecified).AddTicks(7783), 45, 1616014.0221354195760000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 55,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 58, new DateTime(2024, 5, 20, 8, 17, 24, 516, DateTimeKind.Unspecified).AddTicks(3032), 15, 2352245.002879430800000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 56,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 24, new DateTime(2024, 5, 17, 16, 12, 27, 572, DateTimeKind.Unspecified).AddTicks(9402), 41, 6937317.225463855680000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 57,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 34, new DateTime(2024, 5, 13, 22, 34, 52, 305, DateTimeKind.Unspecified).AddTicks(6704), 68, 7130910.79049740800000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 58,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 24, new DateTime(2024, 5, 2, 11, 18, 31, 993, DateTimeKind.Unspecified).AddTicks(454), 73, 4252153.387173707760000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 59,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 21, new DateTime(2024, 5, 3, 12, 5, 46, 807, DateTimeKind.Unspecified).AddTicks(1018), 93, 4747792.181239412400000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 60,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 76, new DateTime(2024, 5, 29, 13, 22, 50, 84, DateTimeKind.Unspecified).AddTicks(2949), 76, 1978109.716469808320000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 61,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 9, new DateTime(2024, 5, 19, 1, 48, 7, 254, DateTimeKind.Unspecified).AddTicks(7757), 15, 2677864.050982365800000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 62,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 24, new DateTime(2024, 5, 23, 3, 49, 18, 466, DateTimeKind.Unspecified).AddTicks(583), 61, 4672077.396204311280000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 63,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 43, new DateTime(2024, 5, 16, 2, 8, 34, 914, DateTimeKind.Unspecified).AddTicks(4033), 56, 2837396.588741205000000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 64,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 92, new DateTime(2024, 5, 10, 5, 34, 14, 881, DateTimeKind.Unspecified).AddTicks(5197), 2, 3578168.826588195840000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 65,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 76, new DateTime(2024, 5, 8, 15, 47, 13, 778, DateTimeKind.Unspecified).AddTicks(2504), 87, 3080277.076652106240000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 66,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 42, new DateTime(2024, 5, 25, 16, 56, 34, 946, DateTimeKind.Unspecified).AddTicks(2105), 21, 2011747.764729804920000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 67,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 93, new DateTime(2024, 5, 7, 21, 5, 35, 381, DateTimeKind.Unspecified).AddTicks(2778), 5, 4281924.524425785440000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 68,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 51, new DateTime(2024, 5, 3, 0, 30, 51, 966, DateTimeKind.Unspecified).AddTicks(9733), 100, 5451185.805842543240000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 69,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 34, new DateTime(2024, 5, 25, 12, 38, 20, 305, DateTimeKind.Unspecified).AddTicks(6427), 8, 3292815.955404771520000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 70,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 18, new DateTime(2024, 5, 15, 19, 38, 20, 409, DateTimeKind.Unspecified).AddTicks(8530), 75, 4447662.009762935520000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 71,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 6, new DateTime(2024, 5, 6, 23, 58, 48, 430, DateTimeKind.Unspecified).AddTicks(1713), 94, 7332521.106118323840000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 72,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 97, new DateTime(2024, 5, 26, 14, 36, 42, 800, DateTimeKind.Unspecified).AddTicks(7472), 72, 3884774.947532946120000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 73,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 25, new DateTime(2024, 5, 15, 6, 13, 17, 726, DateTimeKind.Unspecified).AddTicks(4645), 71, 7374351.14532590720000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 74,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 68, new DateTime(2024, 5, 23, 20, 43, 23, 537, DateTimeKind.Unspecified).AddTicks(1183), 35, 5414580.038144204720000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 75,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 29, new DateTime(2024, 5, 4, 18, 23, 58, 291, DateTimeKind.Unspecified).AddTicks(2892), 45, 2584986.28221266160000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 76,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 94, new DateTime(2024, 5, 7, 6, 54, 41, 94, DateTimeKind.Unspecified).AddTicks(7036), 49, 2256207.718953137920000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 77,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 32, new DateTime(2024, 5, 27, 16, 42, 9, 673, DateTimeKind.Unspecified).AddTicks(7379), 85, 3946024.234656322560000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 78,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 40, new DateTime(2024, 5, 1, 13, 25, 10, 752, DateTimeKind.Unspecified).AddTicks(793), 43, 4639486.471431508800000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 79,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 80, new DateTime(2024, 5, 19, 17, 51, 32, 300, DateTimeKind.Unspecified).AddTicks(6264), 2, 5541933.140280384600000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 80,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 85, new DateTime(2024, 5, 12, 23, 12, 47, 994, DateTimeKind.Unspecified).AddTicks(1190), 35, 4706445.415137535440000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 81,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 64, new DateTime(2024, 5, 4, 21, 11, 5, 528, DateTimeKind.Unspecified).AddTicks(3120), 75, 7030338.09749259840000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 82,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 88, new DateTime(2024, 5, 27, 0, 11, 30, 813, DateTimeKind.Unspecified).AddTicks(2407), 67, 3566789.477385777720000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 83,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 66, new DateTime(2024, 5, 13, 8, 50, 59, 939, DateTimeKind.Unspecified).AddTicks(5223), 34, 6067355.465877048640000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 84,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 5, new DateTime(2024, 5, 4, 8, 19, 36, 742, DateTimeKind.Unspecified).AddTicks(5336), 83, 3471855.12677230640000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 85,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 25, new DateTime(2024, 5, 5, 12, 56, 31, 867, DateTimeKind.Unspecified).AddTicks(8529), 100, 2021939.317631550240000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 86,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 26, new DateTime(2024, 5, 5, 17, 27, 22, 963, DateTimeKind.Unspecified).AddTicks(3837), 68, 1375642.17935611280000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 87,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 98, new DateTime(2024, 5, 2, 19, 59, 35, 87, DateTimeKind.Unspecified).AddTicks(7307), 53, 2790604.533752439600000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 88,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 86, new DateTime(2024, 5, 15, 20, 49, 37, 396, DateTimeKind.Unspecified).AddTicks(8885), 55, 3121689.895952353440000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 89,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 81, new DateTime(2024, 5, 20, 21, 35, 36, 804, DateTimeKind.Unspecified).AddTicks(8518), 49, 5088178.934055238720000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 90,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 92, new DateTime(2024, 5, 11, 0, 41, 58, 935, DateTimeKind.Unspecified).AddTicks(6478), 23, 2815867.563709547120000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 91,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 44, new DateTime(2024, 5, 1, 0, 9, 57, 350, DateTimeKind.Unspecified).AddTicks(7132), 5, 1695682.200835042640000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 92,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 38, new DateTime(2024, 5, 20, 11, 33, 56, 613, DateTimeKind.Unspecified).AddTicks(6228), 47, 4487443.166815340160000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 93,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 27, new DateTime(2024, 5, 24, 5, 39, 16, 791, DateTimeKind.Unspecified).AddTicks(9846), 14, 2452229.823166248160000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 94,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 82, new DateTime(2024, 5, 5, 2, 39, 3, 190, DateTimeKind.Unspecified).AddTicks(5875), 80, 3126142.868685801920000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 95,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 37, new DateTime(2024, 5, 11, 9, 38, 23, 948, DateTimeKind.Unspecified).AddTicks(4337), 11, 4645574.318009210880000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 96,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 67, new DateTime(2024, 5, 23, 6, 3, 56, 645, DateTimeKind.Unspecified).AddTicks(8185), 14, 2734220.403637432880000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 97,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 73, new DateTime(2024, 5, 24, 9, 21, 59, 36, DateTimeKind.Unspecified).AddTicks(568), 24, 1996893.3208937466000000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 98,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 48, new DateTime(2024, 5, 5, 14, 30, 41, 517, DateTimeKind.Unspecified).AddTicks(3769), 85, 1674997.222975559000000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 99,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 36, new DateTime(2024, 5, 26, 22, 33, 35, 499, DateTimeKind.Unspecified).AddTicks(5330), 42, 1808659.6645841142000000m });

            migrationBuilder.UpdateData(
                table: "ImportOrder",
                keyColumn: "OrderID",
                keyValue: 100,
                columns: new[] { "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[] { 79, new DateTime(2024, 5, 12, 1, 51, 20, 47, DateTimeKind.Unspecified).AddTicks(7175), 33, 3065846.490382908920000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 24, 22, 11, 34, 640, DateTimeKind.Local).AddTicks(4786), 28328.186543784440000m, 64, 133097.32475970100000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 2,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 24, 22, 11, 34, 653, DateTimeKind.Local).AddTicks(4976), 44893.698860416360000m, 134, 194848.311086153400000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 3,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 24, 22, 11, 34, 666, DateTimeKind.Local).AddTicks(2865), 25107.04190911160000m, 46, 149549.829155052600000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 4,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 24, 22, 11, 34, 678, DateTimeKind.Local).AddTicks(8331), 19240.518979822480000m, 98, 188388.360956424900000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 5,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 24, 22, 11, 34, 687, DateTimeKind.Local).AddTicks(9183), 18035.402103435960000m, 34, 154079.447888605300000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 6,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 24, 22, 11, 34, 696, DateTimeKind.Local).AddTicks(6465), 25515.093293423680000m, 94, 121042.44695696200000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 7,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 24, 22, 11, 34, 705, DateTimeKind.Local).AddTicks(3750), 26614.355194975880000m, 113, 177577.118792848800000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 8,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 24, 22, 11, 34, 715, DateTimeKind.Local).AddTicks(9090), 21945.787470759920000m, 91, 118973.342388621700000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 9,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 24, 22, 11, 34, 727, DateTimeKind.Local).AddTicks(724), 33618.207212190040000m, 88, 130186.036132288400000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 10,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 24, 22, 11, 34, 735, DateTimeKind.Local).AddTicks(1453), 43702.444755315520000m, 56, 130810.555545931200000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 11,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 24, 22, 11, 34, 743, DateTimeKind.Local).AddTicks(5299), 25737.339349827320000m, 61, 139395.650929282200000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 12,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 24, 22, 11, 34, 751, DateTimeKind.Local).AddTicks(8266), 43310.382556663840000m, 67, 142844.495464783300000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 13,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 24, 22, 11, 34, 760, DateTimeKind.Local).AddTicks(1137), 43332.836028926840000m, 94, 118129.390843544400000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 14,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 24, 22, 11, 34, 767, DateTimeKind.Local).AddTicks(4975), 43364.079020305920000m, 65, 166465.575017999600000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 15,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 24, 22, 11, 34, 774, DateTimeKind.Local).AddTicks(6153), 34551.892519206720000m, 65, 181386.396944395400000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 16,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 24, 22, 11, 34, 781, DateTimeKind.Local).AddTicks(4566), 14185.643296989640000m, 41, 170901.613538069700000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 17,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 24, 22, 11, 34, 788, DateTimeKind.Local).AddTicks(2972), 16483.58472233080000m, 149, 140886.233175170600000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 18,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 24, 22, 11, 34, 795, DateTimeKind.Local).AddTicks(1220), 41378.222480170080000m, 106, 133806.273218142500000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 19,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 24, 22, 11, 34, 801, DateTimeKind.Local).AddTicks(9736), 47537.324425955520000m, 94, 121195.011219889900000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 20,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 24, 22, 11, 34, 809, DateTimeKind.Local).AddTicks(6132), 21130.58373238200000m, 60, 102761.7213242574300000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 21,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 24, 22, 11, 34, 818, DateTimeKind.Local).AddTicks(8091), 25105.462556470160000m, 59, 163398.817450435100000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 22,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 24, 22, 11, 34, 833, DateTimeKind.Local).AddTicks(482), 45836.98271512560000m, 49, 181150.326391042100000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 23,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 24, 22, 11, 34, 842, DateTimeKind.Local).AddTicks(3143), 35543.755505170520000m, 80, 119989.252857226100000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 24,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 24, 22, 11, 34, 851, DateTimeKind.Local).AddTicks(6868), 20953.992048154240000m, 50, 118739.70049631300000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 25,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 24, 22, 11, 34, 859, DateTimeKind.Local).AddTicks(8144), 14129.766694647240000m, 83, 102402.5171878582100000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 26,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 24, 22, 11, 34, 867, DateTimeKind.Local).AddTicks(1275), 42061.825407433280000m, 47, 102529.9286382335200000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 27,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 24, 22, 11, 34, 873, DateTimeKind.Local).AddTicks(9815), 46236.212199777680000m, 38, 174128.157803481900000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 28,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 24, 22, 11, 34, 882, DateTimeKind.Local).AddTicks(6665), 37258.673951091280000m, 62, 102455.2580550116600000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 29,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 24, 22, 11, 34, 893, DateTimeKind.Local).AddTicks(8477), 48496.254227801840000m, 100, 125775.524699103100000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 30,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 24, 22, 11, 34, 906, DateTimeKind.Local).AddTicks(1873), 30126.092997585160000m, 103, 121844.726487367200000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 31,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 24, 22, 11, 34, 916, DateTimeKind.Local).AddTicks(3805), 33677.722125252680000m, 49, 111814.584692170600000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 32,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 24, 22, 11, 34, 925, DateTimeKind.Local).AddTicks(5671), 39119.802107512200000m, 99, 108569.1905168305700000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 33,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 24, 22, 11, 34, 935, DateTimeKind.Local).AddTicks(1779), 27327.789531948640000m, 57, 174067.749982877400000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 34,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 24, 22, 11, 34, 946, DateTimeKind.Local).AddTicks(4772), 49183.197784451560000m, 122, 124082.832326188900000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 35,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 24, 22, 11, 34, 957, DateTimeKind.Local).AddTicks(9616), 45917.752905047640000m, 99, 105021.3565692139200000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 36,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 24, 22, 11, 34, 971, DateTimeKind.Local).AddTicks(9986), 29956.923312704440000m, 149, 114432.792100339200000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 37,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 24, 22, 11, 34, 985, DateTimeKind.Local).AddTicks(7224), 13752.9742661714240000m, 53, 187293.593733905900000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 38,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 24, 22, 11, 34, 997, DateTimeKind.Local).AddTicks(7296), 25757.603083207280000m, 112, 136097.6723922800000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 39,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 24, 22, 11, 35, 9, DateTimeKind.Local).AddTicks(3580), 10235.27394381490640000m, 24, 164220.160129826800000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 40,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 24, 22, 11, 35, 19, DateTimeKind.Local).AddTicks(2949), 29930.543643887280000m, 132, 176976.628810418800000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 41,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 24, 22, 11, 35, 29, DateTimeKind.Local).AddTicks(4473), 10147.04189522717560000m, 47, 173445.748056130600000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 42,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 24, 22, 11, 35, 41, DateTimeKind.Local).AddTicks(1507), 35641.752535734520000m, 67, 150972.504894427600000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 43,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 24, 22, 11, 35, 53, DateTimeKind.Local).AddTicks(6853), 22930.454236221760000m, 97, 124006.845996609900000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 44,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 24, 22, 11, 35, 63, DateTimeKind.Local).AddTicks(422), 22117.753180406280000m, 78, 198265.485066557600000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 45,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 24, 22, 11, 35, 72, DateTimeKind.Local).AddTicks(4554), 24762.270106817440000m, 81, 170531.414321895400000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 46,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 24, 22, 11, 35, 82, DateTimeKind.Local).AddTicks(932), 13335.1175594798120000m, 36, 184075.787953276500000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 47,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 24, 22, 11, 35, 91, DateTimeKind.Local).AddTicks(5025), 23550.189542709120000m, 68, 148309.826547143400000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 48,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 24, 22, 11, 35, 99, DateTimeKind.Local).AddTicks(4285), 13228.6513662548040000m, 53, 152580.563194401400000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 49,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 24, 22, 11, 35, 106, DateTimeKind.Local).AddTicks(4774), 37649.919445934240000m, 85, 165000.482374804400000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 50,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 24, 22, 11, 35, 113, DateTimeKind.Local).AddTicks(6170), 39085.404429143040000m, 18, 176592.248315502700000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 51,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 24, 22, 11, 35, 120, DateTimeKind.Local).AddTicks(7778), 21673.490233137640000m, 72, 103854.1982301050600000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 52,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 24, 22, 11, 35, 128, DateTimeKind.Local).AddTicks(2118), 25083.833951779920000m, 104, 152241.473919092600000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 53,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 24, 22, 11, 35, 135, DateTimeKind.Local).AddTicks(8644), 31601.638940600600000m, 48, 194491.430882215700000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 54,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 24, 22, 11, 35, 144, DateTimeKind.Local).AddTicks(1540), 12335.9849017970960000m, 52, 176377.783521200600000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 55,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 24, 22, 11, 35, 152, DateTimeKind.Local).AddTicks(5822), 15175.774212125360000m, 86, 197136.979972984900000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 56,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 24, 22, 11, 35, 160, DateTimeKind.Local).AddTicks(9780), 45341.942650090560000m, 78, 149670.395303207200000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 57,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 24, 22, 11, 35, 170, DateTimeKind.Local).AddTicks(3037), 37140.16036717400000m, 136, 158493.102140826700000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 58,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 24, 22, 11, 35, 178, DateTimeKind.Local).AddTicks(5330), 34853.716288309080000m, 51, 162551.492645785400000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 59,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 24, 22, 11, 35, 187, DateTimeKind.Local).AddTicks(979), 25663.741520213040000m, 98, 177233.076081206500000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 60,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 24, 22, 11, 35, 195, DateTimeKind.Local).AddTicks(9546), 14873.005386991040000m, 50, 196096.136831311600000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 61,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 24, 22, 11, 35, 204, DateTimeKind.Local).AddTicks(7788), 17276.542264402360000m, 70, 105897.8925340955800000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 62,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 24, 22, 11, 35, 217, DateTimeKind.Local).AddTicks(3074), 23596.350485880360000m, 110, 114932.539197352200000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 63,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 24, 22, 11, 35, 227, DateTimeKind.Local).AddTicks(600), 22699.172709929640000m, 75, 138293.031737673500000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 64,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 24, 22, 11, 35, 234, DateTimeKind.Local).AddTicks(6557), 34405.469486424960000m, 25, 103057.4908424602400000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 65,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 24, 22, 11, 35, 242, DateTimeKind.Local).AddTicks(2265), 18334.982599119680000m, 110, 184576.002587877400000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 66,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 24, 22, 11, 35, 249, DateTimeKind.Local).AddTicks(4486), 15125.923043081240000m, 54, 158592.246182609700000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 67,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 24, 22, 11, 35, 256, DateTimeKind.Local).AddTicks(7557), 26595.804499539040000m, 107, 151778.065425257100000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 68,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 24, 22, 11, 35, 263, DateTimeKind.Local).AddTicks(9169), 33442.857704555480000m, 100, 168062.304605095700000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 69,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 24, 22, 11, 35, 271, DateTimeKind.Local).AddTicks(560), 18498.966041599840000m, 98, 119665.268342384600000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 70,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 24, 22, 11, 35, 278, DateTimeKind.Local).AddTicks(4018), 43604.529507479760000m, 20, 149185.60806591700000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 71,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 24, 22, 11, 35, 287, DateTimeKind.Local).AddTicks(6290), 38390.162859258240000m, 139, 149765.892484181900000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 72,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 24, 22, 11, 35, 298, DateTimeKind.Local).AddTicks(3633), 31583.536158804440000m, 44, 168469.240939087200000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 73,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 24, 22, 11, 35, 311, DateTimeKind.Local).AddTicks(6599), 48836.76255182720000m, 74, 137669.052666609200000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 74,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 24, 22, 11, 35, 321, DateTimeKind.Local).AddTicks(5508), 37086.164644823320000m, 56, 131888.980103644100000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 75,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 24, 22, 11, 35, 330, DateTimeKind.Local).AddTicks(2992), 15295.77681782640000m, 102, 179510.721053055200000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 76,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 24, 22, 11, 35, 342, DateTimeKind.Local).AddTicks(9900), 21904.929310224640000m, 38, 128878.945178538500000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 77,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 24, 22, 11, 35, 352, DateTimeKind.Local).AddTicks(2197), 31317.652656002560000m, 60, 132202.656868061800000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 78,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 24, 22, 11, 35, 361, DateTimeKind.Local).AddTicks(4722), 25774.924841286160000m, 108, 112111.708055894600000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 79,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 24, 22, 11, 35, 374, DateTimeKind.Local).AddTicks(9830), 28131.640305991800000m, 123, 165095.523961646900000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 80,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 24, 22, 11, 35, 387, DateTimeKind.Local).AddTicks(7132), 34353.616168887120000m, 68, 171426.476356671200000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 81,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 24, 22, 11, 35, 397, DateTimeKind.Local).AddTicks(9307), 41113.08828943040000m, 102, 126260.101927068400000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 82,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 24, 22, 11, 35, 407, DateTimeKind.Local).AddTicks(3824), 23312.349525397240000m, 97, 107636.7707502311600000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 83,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 24, 22, 11, 35, 416, DateTimeKind.Local).AddTicks(5218), 44612.907837331240000m, 85, 189584.023386307400000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 84,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 24, 22, 11, 35, 425, DateTimeKind.Local).AddTicks(5673), 20789.55165731920000m, 87, 179295.407762446900000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 85,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 24, 22, 11, 35, 434, DateTimeKind.Local).AddTicks(4062), 12328.898278241160000m, 108, 170682.683230291300000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 86,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 24, 22, 11, 35, 443, DateTimeKind.Local).AddTicks(4128), 10831.82818390640000m, 67, 126834.975988206200000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 87,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 24, 22, 11, 35, 452, DateTimeKind.Local).AddTicks(7030), 26577.186035737520000m, 21, 168180.662199521200000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 88,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 24, 22, 11, 35, 465, DateTimeKind.Local).AddTicks(6642), 21829.999272394080000m, 91, 150937.265151798500000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 89,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 24, 22, 11, 35, 478, DateTimeKind.Local).AddTicks(9785), 47553.074150048960000m, 29, 132584.46169818100000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 90,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 24, 22, 11, 35, 492, DateTimeKind.Local).AddTicks(4031), 26564.788336882520000m, 55, 112315.030695966300000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 91,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 24, 22, 11, 35, 505, DateTimeKind.Local).AddTicks(4491), 13899.034433074120000m, 38, 159056.829905260400000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 92,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 24, 22, 11, 35, 515, DateTimeKind.Local).AddTicks(2689), 31380.721446261120000m, 79, 149842.789498377300000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 93,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 24, 22, 11, 35, 523, DateTimeKind.Local).AddTicks(9268), 15231.241137678560000m, 102, 167983.945689264900000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 94,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 24, 22, 11, 35, 532, DateTimeKind.Local).AddTicks(3718), 18175.249236545360000m, 104, 124818.707793841600000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 95,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 24, 22, 11, 35, 540, DateTimeKind.Local).AddTicks(5040), 23701.909785761280000m, 124, 100137.26468682482300000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 96,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 24, 22, 11, 35, 548, DateTimeKind.Local).AddTicks(5336), 15360.788784479960000m, 123, 108327.5259306495700000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 97,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 24, 22, 11, 35, 556, DateTimeKind.Local).AddTicks(3598), 13312.6221392916440000m, 81, 121831.235443074900000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 98,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 24, 22, 11, 35, 564, DateTimeKind.Local).AddTicks(6155), 14075.606915761000000m, 55, 182914.550692701100000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 99,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 24, 22, 11, 35, 581, DateTimeKind.Local).AddTicks(3585), 12057.7310972274280000m, 84, 172322.955948080400000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 100,
                columns: new[] { "DateCreated", "ImportUnitPrice", "Inventory", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 24, 22, 11, 35, 595, DateTimeKind.Local).AddTicks(2207), 17721.656013774040000m, 85, 147074.310989908300000m });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 1,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Hà Nội", new DateTime(2024, 5, 24, 22, 11, 34, 618, DateTimeKind.Local).AddTicks(8238), "PhuongTram_Le@gmail.com", "0929636710", "Lan Hương Phan" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 2,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Tây Ninh", new DateTime(2024, 5, 24, 22, 11, 34, 619, DateTimeKind.Local).AddTicks(715), "TrangAnh.Le8@gmail.com", "0977856095", "Dũng Việt Lâm" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 3,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Thái Bình", new DateTime(2024, 5, 24, 22, 11, 34, 619, DateTimeKind.Local).AddTicks(910), "PhuongQuyen_Pham57@gmail.com", "0930130276", "Thùy Như Phạm" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 4,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Trà Vinh", new DateTime(2024, 5, 24, 22, 11, 34, 619, DateTimeKind.Local).AddTicks(1031), "DuyCuong59@gmail.com", "0925852115", "Trọng Hùng Đỗ" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 5,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Yên Bái", new DateTime(2024, 5, 24, 22, 11, 34, 619, DateTimeKind.Local).AddTicks(1140), "ThucTam46@yahoo.com", "0933581495", "Phi Hùng Phùng" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 6,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Cần Thơ", new DateTime(2024, 5, 24, 22, 11, 34, 619, DateTimeKind.Local).AddTicks(1251), "UyPhong_To@gmail.com", "0931583620", "Hằng Anh Hồ" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 7,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Thái Bình", new DateTime(2024, 5, 24, 22, 11, 34, 619, DateTimeKind.Local).AddTicks(1367), "HieuLiem21@yahoo.com", "0921964197", "Thanh Mẫn Đặng" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 8,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Đắk Lắk", new DateTime(2024, 5, 24, 22, 11, 34, 619, DateTimeKind.Local).AddTicks(1531), "HoangXuan89@hotmail.com", "0915677385", "Danh Văn Phan" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 9,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Quảng Ngãi", new DateTime(2024, 5, 24, 22, 11, 34, 619, DateTimeKind.Local).AddTicks(1640), "MinhTien_To19@yahoo.com", "0989227427", "Lâm Nhi Dương" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 10,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Quảng Bình", new DateTime(2024, 5, 24, 22, 11, 34, 619, DateTimeKind.Local).AddTicks(1744), "NguyenBong_Hoang@gmail.com", "0926223021", "Minh Triệu Đỗ" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 11,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Hà Nam", new DateTime(2024, 5, 24, 22, 11, 34, 619, DateTimeKind.Local).AddTicks(1844), "TuanHung73@yahoo.com", "0977731304", "Việt Long Đặng" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 12,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Nghệ An", new DateTime(2024, 5, 24, 22, 11, 34, 619, DateTimeKind.Local).AddTicks(1944), "DuyKhang22@hotmail.com", "0976836340", "Quỳnh Trâm Lê" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 13,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Nghệ An", new DateTime(2024, 5, 24, 22, 11, 34, 619, DateTimeKind.Local).AddTicks(2041), "ThuyHuong.Truong68@gmail.com", "0967831308", "Đan Quỳnh Nguyễn" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 14,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Phú Yên", new DateTime(2024, 5, 24, 22, 11, 34, 619, DateTimeKind.Local).AddTicks(2177), "DanThu36@hotmail.com", "0908045098", "Phong Ðộ Đặng" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 15,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Hà Tĩnh", new DateTime(2024, 5, 24, 22, 11, 34, 619, DateTimeKind.Local).AddTicks(2318), "DongNghi_Ha@yahoo.com", "0985257763", "Tấn Trình Đặng" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 16,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Phú Thọ", new DateTime(2024, 5, 24, 22, 11, 34, 619, DateTimeKind.Local).AddTicks(2419), "MinhSon_Do23@hotmail.com", "0976175726", "Chiêu Phong Bùi" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 17,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Quảng Nam", new DateTime(2024, 5, 24, 22, 11, 34, 619, DateTimeKind.Local).AddTicks(2518), "PhuTho.Dang@gmail.com", "0945173895", "Trung Dũng Vũ" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 18,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Hà Nội", new DateTime(2024, 5, 24, 22, 11, 34, 619, DateTimeKind.Local).AddTicks(2611), "DacThanh63@hotmail.com", "0980479427", "Vĩnh Toàn Đinh" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 19,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Gia Lai", new DateTime(2024, 5, 24, 22, 11, 34, 619, DateTimeKind.Local).AddTicks(2709), "NgocLien_Tran@gmail.com", "0937476479", "Tuyền Lâm Vũ" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 20,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Hậu Giang", new DateTime(2024, 5, 24, 22, 11, 34, 619, DateTimeKind.Local).AddTicks(2803), "NhatHoang_Tran@gmail.com", "0916418236", "Vân Trang Nguyễn" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 21,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Quảng Ninh", new DateTime(2024, 5, 24, 22, 11, 34, 619, DateTimeKind.Local).AddTicks(2901), "DucQuang_Nguyen@hotmail.com", "0995102608", "Thụy Du Phạm" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 22,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Hà Tĩnh", new DateTime(2024, 5, 24, 22, 11, 34, 619, DateTimeKind.Local).AddTicks(3018), "QuynhAnh_Tran@gmail.com", "0904710899", "Cát Linh Đoàn" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 23,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Tiền Giang", new DateTime(2024, 5, 24, 22, 11, 34, 619, DateTimeKind.Local).AddTicks(3181), "XuanThao_Vuong@gmail.com", "0991102459", "Hương Tiên Lý" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 24,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Quảng Bình", new DateTime(2024, 5, 24, 22, 11, 34, 619, DateTimeKind.Local).AddTicks(3300), "HuuPhuoc88@yahoo.com", "0924448485", "Nguyệt Lan Phan" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 25,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Phú Yên", new DateTime(2024, 5, 24, 22, 11, 34, 619, DateTimeKind.Local).AddTicks(3406), "TanLong55@yahoo.com", "0968657509", "Minh Như Vũ" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 26,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Hà Tĩnh", new DateTime(2024, 5, 24, 22, 11, 34, 619, DateTimeKind.Local).AddTicks(3505), "DieuHong60@hotmail.com", "0942753165", "Vĩnh Hải Đinh" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 27,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Điện Biên", new DateTime(2024, 5, 24, 22, 11, 34, 619, DateTimeKind.Local).AddTicks(3625), "MyTam48@gmail.com", "0906844494", "Tú Quỳnh Tăng" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 28,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Phú Thọ", new DateTime(2024, 5, 24, 22, 11, 34, 619, DateTimeKind.Local).AddTicks(3791), "HuyLinh.Vuong43@hotmail.com", "0932096838", "Mộng Thu Bùi" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 29,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Tiền Giang", new DateTime(2024, 5, 24, 22, 11, 34, 619, DateTimeKind.Local).AddTicks(3961), "TrangDai_Dang@yahoo.com", "0919043317", "Yến Phượng Phạm" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 30,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Lâm Đồng", new DateTime(2024, 5, 24, 22, 11, 34, 619, DateTimeKind.Local).AddTicks(4099), "KimKhanh37@hotmail.com", "0933756906", "Hồng Ngọc Đỗ" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 31,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Trà Vinh", new DateTime(2024, 5, 24, 22, 11, 34, 619, DateTimeKind.Local).AddTicks(4196), "VanTien_Nguyen@yahoo.com", "0955524894", "Mai Khanh Tăng" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 32,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Kiên Giang", new DateTime(2024, 5, 24, 22, 11, 34, 619, DateTimeKind.Local).AddTicks(4296), "GiaDao_Ly@hotmail.com", "0949556122", "Vương Việt Nguyễn" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 33,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Hải Dương", new DateTime(2024, 5, 24, 22, 11, 34, 619, DateTimeKind.Local).AddTicks(4386), "DoanTrang96@gmail.com", "0907735888", "Anh Phương Mai" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 34,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Gia Lai", new DateTime(2024, 5, 24, 22, 11, 34, 619, DateTimeKind.Local).AddTicks(4493), "PhuongUyen_Phan@hotmail.com", "0912915733", "Thiên Hưng Đào" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 35,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Trà Vinh", new DateTime(2024, 5, 24, 22, 11, 34, 619, DateTimeKind.Local).AddTicks(4593), "TamDan53@yahoo.com", "0945117600", "Ngọc Thi Mai" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 36,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Tiền Giang", new DateTime(2024, 5, 24, 22, 11, 34, 619, DateTimeKind.Local).AddTicks(4699), "XuanTrung5@yahoo.com", "0989817877", "Lan Phương Hà" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 37,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Đắk Lắk", new DateTime(2024, 5, 24, 22, 11, 34, 619, DateTimeKind.Local).AddTicks(4862), "NgocThien_Vuong@gmail.com", "0965634155", "Xuân Bảo Lý" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 38,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Long An", new DateTime(2024, 5, 24, 22, 11, 34, 619, DateTimeKind.Local).AddTicks(4966), "AnhDuong.Truong89@gmail.com", "0946063013", "Xuân Hoa Trương" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 39,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Sơn La", new DateTime(2024, 5, 24, 22, 11, 34, 619, DateTimeKind.Local).AddTicks(5079), "MaiLinh_Pham@gmail.com", "0988141041", "Yến Ðan Đặng" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 40,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Tiền Giang", new DateTime(2024, 5, 24, 22, 11, 34, 619, DateTimeKind.Local).AddTicks(5175), "PhucNguyen.Pham@yahoo.com", "0936726766", "Xuân Quân Trịnh" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 41,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Kiên Giang", new DateTime(2024, 5, 24, 22, 11, 34, 619, DateTimeKind.Local).AddTicks(5279), "SyDan_Ngo@hotmail.com", "0990659564", "Thảo Linh Tô" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 42,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Yên Bái", new DateTime(2024, 5, 24, 22, 11, 34, 619, DateTimeKind.Local).AddTicks(5369), "CongAn_Do32@yahoo.com", "0964106478", "Mai Chi Lê" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 43,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Cao Bằng", new DateTime(2024, 5, 24, 22, 11, 34, 619, DateTimeKind.Local).AddTicks(5465), "NgocKhoi72@hotmail.com", "0910344324", "Tuấn Anh Vương" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 44,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Quảng Nam", new DateTime(2024, 5, 24, 22, 11, 34, 619, DateTimeKind.Local).AddTicks(5585), "CongTuan51@yahoo.com", "0947352504", "Tâm Như Lê" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 45,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Hà Nội", new DateTime(2024, 5, 24, 22, 11, 34, 619, DateTimeKind.Local).AddTicks(5737), "ThanhDoanh_Phung@yahoo.com", "0967860739", "Việt Khoa Ngô" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 46,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Đắk Nông", new DateTime(2024, 5, 24, 22, 11, 34, 619, DateTimeKind.Local).AddTicks(5844), "MinhNghia_Tran@yahoo.com", "0927219947", "Lương Tuyền Lý" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 47,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Bạc Liêu", new DateTime(2024, 5, 24, 22, 11, 34, 619, DateTimeKind.Local).AddTicks(5940), "SyHoang.Phan@hotmail.com", "0956468868", "Việt Thắng Mai" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 48,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Hòa Bình", new DateTime(2024, 5, 24, 22, 11, 34, 619, DateTimeKind.Local).AddTicks(6034), "QuocPhuong_Le@hotmail.com", "0921890790", "Quốc Việt Trần" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 49,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Thái Nguyên", new DateTime(2024, 5, 24, 22, 11, 34, 619, DateTimeKind.Local).AddTicks(6126), "YBinh.Phan5@yahoo.com", "0968484582", "Thụ Nhân Lâm" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 50,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Nghệ An", new DateTime(2024, 5, 24, 22, 11, 34, 619, DateTimeKind.Local).AddTicks(6224), "ThanhNha21@gmail.com", "0919341646", "Lan Nhi Đỗ" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 51,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Bình Thuận", new DateTime(2024, 5, 24, 22, 11, 34, 619, DateTimeKind.Local).AddTicks(6318), "ThaoVan2@hotmail.com", "0977268703", "Hiếu Phong Ngô" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 52,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Hải Phòng", new DateTime(2024, 5, 24, 22, 11, 34, 619, DateTimeKind.Local).AddTicks(6431), "BinhDinh86@yahoo.com", "0992414796", "Dũng Việt Hoàng" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 53,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Nam Định", new DateTime(2024, 5, 24, 22, 11, 34, 619, DateTimeKind.Local).AddTicks(6574), "BaCuong88@yahoo.com", "0904000312", "Ánh Dương Lâm" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 54,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Nam Định", new DateTime(2024, 5, 24, 22, 11, 34, 619, DateTimeKind.Local).AddTicks(6696), "AnhHoang93@yahoo.com", "0945916359", "Anh Thi Tô" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 55,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Đắk Lắk", new DateTime(2024, 5, 24, 22, 11, 34, 619, DateTimeKind.Local).AddTicks(6789), "PhuongUyen.Vu@gmail.com", "0996698955", "Thảo Ly Trương" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 56,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Hà Nội", new DateTime(2024, 5, 24, 22, 11, 34, 619, DateTimeKind.Local).AddTicks(6886), "VanhKhuyen.Phan0@hotmail.com", "0938511795", "Tuấn Hoàng Tăng" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 57,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Bến Tre", new DateTime(2024, 5, 24, 22, 11, 34, 619, DateTimeKind.Local).AddTicks(7007), "TrangTam.Hoang@gmail.com", "0982893249", "Huyền Trân Hoàng" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 58,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Cao Bằng", new DateTime(2024, 5, 24, 22, 11, 34, 619, DateTimeKind.Local).AddTicks(7168), "MinhTan.Phung76@gmail.com", "0911548486", "Minh Nhi Đỗ" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 59,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Hòa Bình", new DateTime(2024, 5, 24, 22, 11, 34, 619, DateTimeKind.Local).AddTicks(7349), "NhuY_Tran@gmail.com", "0921643806", "Bằng Sơn Phạm" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 60,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Thừa Thiên-Huế", new DateTime(2024, 5, 24, 22, 11, 34, 619, DateTimeKind.Local).AddTicks(7471), "NhanSam.Tang82@yahoo.com", "0914506068", "Trung Anh Tô" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 61,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Bắc Giang", new DateTime(2024, 5, 24, 22, 11, 34, 619, DateTimeKind.Local).AddTicks(7581), "DacThanh17@hotmail.com", "0976752541", "Hương Thu Đặng" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 62,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Vĩnh Long", new DateTime(2024, 5, 24, 22, 11, 34, 619, DateTimeKind.Local).AddTicks(7675), "CatTien5@yahoo.com", "0939399539", "Linh Trang Phan" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 63,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Đắk Lắk", new DateTime(2024, 5, 24, 22, 11, 34, 619, DateTimeKind.Local).AddTicks(7774), "ThienPhuong.Vu6@gmail.com", "0968176911", "Xuân Hương Tăng" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 64,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Sơn La", new DateTime(2024, 5, 24, 22, 11, 34, 619, DateTimeKind.Local).AddTicks(7869), "QuocDien12@yahoo.com", "0958606702", "Hòa Giang Lý" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 65,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Kiên Giang", new DateTime(2024, 5, 24, 22, 11, 34, 619, DateTimeKind.Local).AddTicks(7968), "HoaLac_Truong@yahoo.com", "0901366027", "Bá Trúc Phan" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 66,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Hà Tĩnh", new DateTime(2024, 5, 24, 22, 11, 34, 619, DateTimeKind.Local).AddTicks(8071), "ThienLan_Tang94@yahoo.com", "0954370328", "Nguyên Hồng Hoàng" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 67,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Đắk Nông", new DateTime(2024, 5, 24, 22, 11, 34, 619, DateTimeKind.Local).AddTicks(8221), "LuuLy_Bui@gmail.com", "0959489949", "Kim Ánh Hồ" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 68,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Tuyên Quang", new DateTime(2024, 5, 24, 22, 11, 34, 619, DateTimeKind.Local).AddTicks(8341), "CamLien94@gmail.com", "0937504736", "Minh Hạnh Tăng" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 69,
                columns: new[] { "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { new DateTime(2024, 5, 24, 22, 11, 34, 619, DateTimeKind.Local).AddTicks(8430), "MaiTam93@gmail.com", "0933025898", "Đài Trang Vũ" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 70,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Quảng Nam", new DateTime(2024, 5, 24, 22, 11, 34, 619, DateTimeKind.Local).AddTicks(8523), "TuUyen.Dinh@gmail.com", "0954026558", "Gia Hùng Lý" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 71,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Lâm Đồng", new DateTime(2024, 5, 24, 22, 11, 34, 619, DateTimeKind.Local).AddTicks(8612), "AiVan97@gmail.com", "0904386245", "Vân Tiên Hà" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 72,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Quảng Ninh", new DateTime(2024, 5, 24, 22, 11, 34, 619, DateTimeKind.Local).AddTicks(8703), "VanChi48@hotmail.com", "0962259665", "Trọng Nghĩa Trương" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 73,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Thái Bình", new DateTime(2024, 5, 24, 22, 11, 34, 619, DateTimeKind.Local).AddTicks(8790), "HuongThien_Bui48@hotmail.com", "0988351736", "Bích Hồng Dương" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 74,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Đắk Lắk", new DateTime(2024, 5, 24, 22, 11, 34, 619, DateTimeKind.Local).AddTicks(8900), "NgocLoan.Vu64@yahoo.com", "0975775442", "Bá Tùng Lê" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 75,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Tuyên Quang", new DateTime(2024, 5, 24, 22, 11, 34, 619, DateTimeKind.Local).AddTicks(9046), "HuongTien26@gmail.com", "0983209199", "Viết Tân Lý" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 76,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Bình Thuận", new DateTime(2024, 5, 24, 22, 11, 34, 619, DateTimeKind.Local).AddTicks(9161), "NguyenKhoi_Nguyen76@yahoo.com", "0956624259", "Vân Thanh Đoàn" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 77,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Lâm Đồng", new DateTime(2024, 5, 24, 22, 11, 34, 619, DateTimeKind.Local).AddTicks(9267), "NhatDa_Do@hotmail.com", "0900930430", "Kiều Giang Trịnh" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 78,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Gia Lai", new DateTime(2024, 5, 24, 22, 11, 34, 619, DateTimeKind.Local).AddTicks(9355), "ThuLoan_Do@gmail.com", "0993953570", "Thiên Tuyền Phạm" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 79,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Hải Dương", new DateTime(2024, 5, 24, 22, 11, 34, 619, DateTimeKind.Local).AddTicks(9455), "QuangTrong_Truong21@hotmail.com", "0944419954", "Ðắc Thái Hoàng" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 80,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Vĩnh Phúc", new DateTime(2024, 5, 24, 22, 11, 34, 619, DateTimeKind.Local).AddTicks(9557), "TamNhu.Dao84@gmail.com", "0936806794", "Mộng Thu Phan" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 81,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Hà Giang", new DateTime(2024, 5, 24, 22, 11, 34, 619, DateTimeKind.Local).AddTicks(9650), "LanThuong24@hotmail.com", "0900965690", "Quỳnh Hoa Hoàng" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 82,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Hải Phòng", new DateTime(2024, 5, 24, 22, 11, 34, 619, DateTimeKind.Local).AddTicks(9776), "ThienTam28@yahoo.com", "0955052286", "Chuẩn Khoa Tô" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 83,
                columns: new[] { "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { new DateTime(2024, 5, 24, 22, 11, 34, 619, DateTimeKind.Local).AddTicks(9924), "HoaiTrung31@gmail.com", "0918051707", "Thanh Lan Dương" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 84,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Bà Rịa-Vũng Tàu", new DateTime(2024, 5, 24, 22, 11, 34, 620, DateTimeKind.Local).AddTicks(23), "DucThanh71@gmail.com", "0954106709", "Diệu Hương Tô" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 85,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "An Giang", new DateTime(2024, 5, 24, 22, 11, 34, 620, DateTimeKind.Local).AddTicks(123), "PhuongTrinh_Ly@yahoo.com", "0934967501", "Thiên Mai Đào" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 86,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Thừa Thiên-Huế", new DateTime(2024, 5, 24, 22, 11, 34, 620, DateTimeKind.Local).AddTicks(216), "HuuHung_Bui@hotmail.com", "0974043536", "Ðông Nghi Phan" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 87,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Đồng Tháp", new DateTime(2024, 5, 24, 22, 11, 34, 620, DateTimeKind.Local).AddTicks(315), "KienCuong_Ly9@hotmail.com", "0979249070", "Minh Hà Bùi" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 88,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Phú Thọ", new DateTime(2024, 5, 24, 22, 11, 34, 620, DateTimeKind.Local).AddTicks(412), "BaThuc_Phan@gmail.com", "0967874913", "Kim Yến Vũ" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 89,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Hà Nội", new DateTime(2024, 5, 24, 22, 11, 34, 620, DateTimeKind.Local).AddTicks(505), "PhuongTra_Ha46@gmail.com", "0999897075", "Vinh Diệu Vũ" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 90,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Vĩnh Phúc", new DateTime(2024, 5, 24, 22, 11, 34, 620, DateTimeKind.Local).AddTicks(633), "HuyenLinh59@gmail.com", "0953557002", "Tuyết Loan Tô" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 91,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Hưng Yên", new DateTime(2024, 5, 24, 22, 11, 34, 620, DateTimeKind.Local).AddTicks(778), "HoNam.Ly@gmail.com", "0905006335", "Ngọc Vy Đào" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 92,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Bắc Kạn", new DateTime(2024, 5, 24, 22, 11, 34, 620, DateTimeKind.Local).AddTicks(880), "QuynhHoa6@gmail.com", "0983976446", "Diễm Liên Đào" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 93,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Phú Yên", new DateTime(2024, 5, 24, 22, 11, 34, 620, DateTimeKind.Local).AddTicks(974), "BaoBinh92@gmail.com", "0915874581", "Xuân Thuyết Lê" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 94,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Hòa Bình", new DateTime(2024, 5, 24, 22, 11, 34, 620, DateTimeKind.Local).AddTicks(1069), "NgocLy64@yahoo.com", "0993661023", "Phương Dung Đặng" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 95,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Sóc Trăng", new DateTime(2024, 5, 24, 22, 11, 34, 620, DateTimeKind.Local).AddTicks(1154), "LienNhu94@hotmail.com", "0978834521", "Họa Mi Dương" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 96,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Bắc Kạn", new DateTime(2024, 5, 24, 22, 11, 34, 620, DateTimeKind.Local).AddTicks(1256), "NgocSuong65@yahoo.com", "0976922194", "Thanh Huyền Phan" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 97,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Đồng Tháp", new DateTime(2024, 5, 24, 22, 11, 34, 620, DateTimeKind.Local).AddTicks(1346), "TuanKiet.Mai7@gmail.com", "0985147230", "Hạnh Vi Lê" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 98,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Hà Nam", new DateTime(2024, 5, 24, 22, 11, 34, 620, DateTimeKind.Local).AddTicks(1462), "TrungChinh_Vuong16@yahoo.com", "0929917507", "Hoàng Oanh Tô" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 99,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Tiền Giang", new DateTime(2024, 5, 24, 22, 11, 34, 620, DateTimeKind.Local).AddTicks(1632), "NguyetLan99@hotmail.com", "0939605087", "Lâm Vũ Đoàn" });

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "ProviderID",
                keyValue: 100,
                columns: new[] { "Address", "DateCreated", "Email", "Phone", "ProviderName" },
                values: new object[] { "Cà Mau", new DateTime(2024, 5, 24, 22, 11, 34, 620, DateTimeKind.Local).AddTicks(1735), "HaLien0@gmail.com", "0960839686", "Thanh Nhung Phạm" });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 1,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 70, 30, new DateTime(2024, 5, 1, 8, 1, 17, 684, DateTimeKind.Unspecified).AddTicks(1214), 9050618.08365966800000m, 9050618.08365966800000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 2,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 41, 90, new DateTime(2024, 5, 17, 10, 55, 5, 73, DateTimeKind.Unspecified).AddTicks(958), 10716657.109738437000000m, 10716657.109738437000000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 3,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 95, 39, new DateTime(2024, 5, 21, 21, 6, 14, 748, DateTimeKind.Unspecified).AddTicks(5253), 11664886.674094102800000m, 11664886.674094102800000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 4,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 31, 31, new DateTime(2024, 5, 13, 17, 1, 48, 361, DateTimeKind.Unspecified).AddTicks(3286), 13940738.710775442600000m, 13940738.710775442600000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 5,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 4, 34, new DateTime(2024, 5, 9, 15, 50, 52, 417, DateTimeKind.Unspecified).AddTicks(6195), 11093720.247979581600000m, 11093720.247979581600000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 6,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 75, 97, new DateTime(2024, 5, 14, 1, 54, 24, 12, DateTimeKind.Unspecified).AddTicks(7439), 9441310.86264303600000m, 9441310.86264303600000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 7,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 32, 56, new DateTime(2024, 5, 3, 17, 0, 20, 403, DateTimeKind.Unspecified).AddTicks(5660), 10654627.127570928000000m, 10654627.127570928000000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 8,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 97, 47, new DateTime(2024, 5, 4, 16, 41, 47, 924, DateTimeKind.Unspecified).AddTicks(6337), 6186613.804208328400000m, 6186613.804208328400000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 9,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 45, 68, new DateTime(2024, 5, 6, 15, 46, 47, 678, DateTimeKind.Unspecified).AddTicks(6827), 9633766.673789341600000m, 9633766.673789341600000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 10,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 43, 100, new DateTime(2024, 5, 10, 22, 26, 59, 994, DateTimeKind.Unspecified).AddTicks(7049), 11642139.443587876800000m, 11642139.443587876800000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 11,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 19, 40, new DateTime(2024, 5, 6, 4, 19, 58, 146, DateTimeKind.Unspecified).AddTicks(2202), 6969782.546464110000000m, 6969782.546464110000000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 12,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 39, 26, new DateTime(2024, 5, 6, 17, 16, 36, 463, DateTimeKind.Unspecified).AddTicks(3132), 10284803.673464397600000m, 10284803.673464397600000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 13,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 38, 7, new DateTime(2024, 5, 22, 19, 42, 52, 650, DateTimeKind.Unspecified).AddTicks(8545), 7914669.186517474800000m, 7914669.186517474800000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 14,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 16, 98, new DateTime(2024, 5, 13, 18, 23, 28, 146, DateTimeKind.Unspecified).AddTicks(8327), 13650177.151475967200000m, 13650177.151475967200000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 15,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 84, 60, new DateTime(2024, 5, 13, 10, 39, 44, 28, DateTimeKind.Unspecified).AddTicks(9166), 14692298.152496027400000m, 14692298.152496027400000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 16,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 22, 66, new DateTime(2024, 5, 17, 12, 37, 11, 293, DateTimeKind.Unspecified).AddTicks(9750), 11621309.720588739600000m, 11621309.720588739600000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 17,
                columns: new[] { "CustomerID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 44, new DateTime(2024, 5, 26, 12, 49, 29, 695, DateTimeKind.Unspecified).AddTicks(369), 7044311.658758530000000m, 7044311.658758530000000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 18,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 28, 32, new DateTime(2024, 5, 20, 9, 44, 14, 820, DateTimeKind.Unspecified).AddTicks(7463), 8563601.485961120000000m, 8563601.485961120000000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 19,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 53, 55, new DateTime(2024, 5, 14, 23, 29, 0, 151, DateTimeKind.Unspecified).AddTicks(2066), 9695600.897591192000000m, 9695600.897591192000000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 20,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 73, 40, new DateTime(2024, 5, 29, 3, 17, 57, 884, DateTimeKind.Unspecified).AddTicks(532), 6576750.1647524755200000m, 6576750.1647524755200000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 21,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 5, 69, new DateTime(2024, 5, 19, 0, 46, 40, 696, DateTimeKind.Unspecified).AddTicks(2487), 13725500.665836548400000m, 13725500.665836548400000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 22,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 5, 3, new DateTime(2024, 5, 28, 18, 54, 57, 424, DateTimeKind.Unspecified).AddTicks(5947), 13042823.500155031200000m, 13042823.500155031200000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 23,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 6, 79, new DateTime(2024, 5, 23, 5, 30, 15, 24, DateTimeKind.Unspecified).AddTicks(7092), 10559054.251435896800000m, 10559054.251435896800000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 24,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 39, 80, new DateTime(2024, 5, 1, 7, 47, 31, 573, DateTimeKind.Unspecified).AddTicks(2371), 9617915.74020135300000m, 9617915.74020135300000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 25,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 5, 64, new DateTime(2024, 5, 4, 14, 37, 15, 643, DateTimeKind.Unspecified).AddTicks(8036), 5529735.9281443433400000m, 5529735.9281443433400000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 26,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 83, 42, new DateTime(2024, 5, 18, 4, 14, 46, 787, DateTimeKind.Unspecified).AddTicks(2058), 9022633.7201645497600000m, 9022633.7201645497600000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 27,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 75, 14, new DateTime(2024, 5, 10, 11, 47, 55, 326, DateTimeKind.Unspecified).AddTicks(5584), 14104380.782082033900000m, 14104380.782082033900000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 28,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 20, 76, new DateTime(2024, 5, 27, 8, 57, 28, 138, DateTimeKind.Unspecified).AddTicks(9981), 8606241.6766209794400000m, 8606241.6766209794400000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 29,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 29, 7, new DateTime(2024, 5, 14, 20, 20, 27, 213, DateTimeKind.Unspecified).AddTicks(1965), 11068246.173521072800000m, 11068246.173521072800000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 30,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 93, 98, new DateTime(2024, 5, 16, 22, 49, 57, 658, DateTimeKind.Unspecified).AddTicks(545), 9016509.760065172800000m, 9016509.760065172800000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 31,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 47, 40, new DateTime(2024, 5, 8, 12, 8, 42, 424, DateTimeKind.Unspecified).AddTicks(7717), 7715206.343759771400000m, 7715206.343759771400000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 32,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 30, 81, new DateTime(2024, 5, 3, 22, 10, 2, 152, DateTimeKind.Unspecified).AddTicks(6704), 7491274.1456613093300000m, 7491274.1456613093300000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 33,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 34, 90, new DateTime(2024, 5, 4, 20, 12, 8, 301, DateTimeKind.Unspecified).AddTicks(4542), 12706945.748750050200000m, 12706945.748750050200000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 34,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 93, 14, new DateTime(2024, 5, 7, 13, 48, 16, 948, DateTimeKind.Unspecified).AddTicks(4606), 7817218.436549900700000m, 7817218.436549900700000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 35,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 8, 72, new DateTime(2024, 5, 22, 4, 13, 3, 611, DateTimeKind.Unspecified).AddTicks(7069), 7771580.3861218300800000m, 7771580.3861218300800000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 36,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 15, 63, new DateTime(2024, 5, 14, 8, 44, 47, 262, DateTimeKind.Unspecified).AddTicks(9674), 5836072.397117299200000m, 5836072.397117299200000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 37,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 15, 99, new DateTime(2024, 5, 10, 7, 38, 54, 899, DateTimeKind.Unspecified).AddTicks(3458), 11799496.405236071700000m, 11799496.405236071700000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 38,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 8, 81, new DateTime(2024, 5, 3, 5, 37, 37, 121, DateTimeKind.Unspecified).AddTicks(9414), 11976595.1705206400000m, 11976595.1705206400000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 39,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 85, 87, new DateTime(2024, 5, 1, 10, 36, 3, 273, DateTimeKind.Unspecified).AddTicks(6186), 12480732.169866836800000m, 12480732.169866836800000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 40,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 38, 87, new DateTime(2024, 5, 10, 11, 1, 19, 570, DateTimeKind.Unspecified).AddTicks(2997), 10618597.728625128000000m, 10618597.728625128000000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 41,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 29, 96, new DateTime(2024, 5, 11, 17, 42, 12, 361, DateTimeKind.Unspecified).AddTicks(2781), 9192624.646974921800000m, 9192624.646974921800000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 42,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 2, 74, new DateTime(2024, 5, 19, 20, 11, 30, 164, DateTimeKind.Unspecified).AddTicks(5038), 12983635.420920773600000m, 12983635.420920773600000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 43,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 9, 41, new DateTime(2024, 5, 21, 23, 31, 14, 728, DateTimeKind.Unspecified).AddTicks(9864), 9920547.679728792000000m, 9920547.679728792000000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 44,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 100, 93, new DateTime(2024, 5, 23, 2, 58, 29, 255, DateTimeKind.Unspecified).AddTicks(743), 15464707.835191492800000m, 15464707.835191492800000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 45,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 48, 45, new DateTime(2024, 5, 13, 1, 7, 45, 888, DateTimeKind.Unspecified).AddTicks(1490), 9038164.959060456200000m, 9038164.959060456200000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 46,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 90, 68, new DateTime(2024, 5, 10, 6, 51, 4, 989, DateTimeKind.Unspecified).AddTicks(8163), 15094214.612168673000000m, 15094214.612168673000000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 47,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 7, 21, new DateTime(2024, 5, 20, 13, 28, 22, 181, DateTimeKind.Unspecified).AddTicks(9866), 12902954.909601475800000m, 12902954.909601475800000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 48,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 88, 47, new DateTime(2024, 5, 27, 7, 38, 31, 467, DateTimeKind.Unspecified).AddTicks(5556), 10833219.986802499400000m, 10833219.986802499400000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 49,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 89, 2, new DateTime(2024, 5, 23, 10, 7, 39, 553, DateTimeKind.Unspecified).AddTicks(549), 13530039.554733960800000m, 13530039.554733960800000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 50,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 89, 57, new DateTime(2024, 5, 6, 6, 41, 49, 34, DateTimeKind.Unspecified).AddTicks(2944), 15010341.106817729500000m, 15010341.106817729500000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 51,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 63, 56, new DateTime(2024, 5, 14, 17, 37, 31, 933, DateTimeKind.Unspecified).AddTicks(9205), 6646668.6867267238400000m, 6646668.6867267238400000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 52,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 28, 90, new DateTime(2024, 5, 13, 4, 54, 12, 407, DateTimeKind.Unspecified).AddTicks(7139), 12027076.439608315400000m, 12027076.439608315400000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 53,
                columns: new[] { "CustomerID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 40, new DateTime(2024, 5, 27, 21, 58, 11, 376, DateTimeKind.Unspecified).AddTicks(5897), 12641943.007344020500000m, 12641943.007344020500000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 54,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 44, 31, new DateTime(2024, 5, 20, 16, 57, 11, 295, DateTimeKind.Unspecified).AddTicks(1686), 13933844.898174847400000m, 13933844.898174847400000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 55,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 60, 6, new DateTime(2024, 5, 25, 5, 36, 52, 155, DateTimeKind.Unspecified).AddTicks(7893), 13602451.618135958100000m, 13602451.618135958100000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 56,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 5, 57, new DateTime(2024, 5, 6, 18, 52, 5, 573, DateTimeKind.Unspecified).AddTicks(4352), 11225279.647740540000000m, 11225279.647740540000000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 57,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 57, 53, new DateTime(2024, 5, 8, 23, 19, 27, 190, DateTimeKind.Unspecified).AddTicks(274), 8875613.719886295200000m, 8875613.719886295200000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 58,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 14, 47, new DateTime(2024, 5, 16, 16, 59, 38, 833, DateTimeKind.Unspecified).AddTicks(9642), 11541155.977850763400000m, 11541155.977850763400000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 59,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 59, 41, new DateTime(2024, 5, 7, 13, 45, 51, 361, DateTimeKind.Unspecified).AddTicks(8074), 15419277.619064965500000m, 15419277.619064965500000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 60,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 14, 92, new DateTime(2024, 5, 12, 20, 18, 58, 606, DateTimeKind.Unspecified).AddTicks(3109), 16275979.356998862800000m, 16275979.356998862800000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 61,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 58, 39, new DateTime(2024, 5, 18, 12, 20, 52, 867, DateTimeKind.Unspecified).AddTicks(2917), 9001320.8653981243000000m, 9001320.8653981243000000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 62,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 41, 30, new DateTime(2024, 5, 15, 6, 10, 33, 880, DateTimeKind.Unspecified).AddTicks(6324), 10114063.449366993600000m, 10114063.449366993600000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 63,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 38, 25, new DateTime(2024, 5, 20, 18, 56, 4, 636, DateTimeKind.Unspecified).AddTicks(7235), 6914651.586883675000000m, 6914651.586883675000000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 64,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 91, 80, new DateTime(2024, 5, 16, 4, 18, 32, 921, DateTimeKind.Unspecified).AddTicks(1652), 8141541.7765543589600000m, 8141541.7765543589600000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 65,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 51, 3, new DateTime(2024, 5, 12, 0, 14, 43, 909, DateTimeKind.Unspecified).AddTicks(1120), 10705408.150096889200000m, 10705408.150096889200000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 66,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 65, 9, new DateTime(2024, 5, 9, 18, 42, 5, 743, DateTimeKind.Unspecified).AddTicks(9134), 12528787.448426166300000m, 12528787.448426166300000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 67,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 22, 52, new DateTime(2024, 5, 25, 16, 41, 1, 840, DateTimeKind.Unspecified).AddTicks(6077), 8196015.532963883400000m, 8196015.532963883400000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 68,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 64, 50, new DateTime(2024, 5, 7, 15, 40, 0, 697, DateTimeKind.Unspecified).AddTicks(3089), 10587925.190121029100000m, 10587925.190121029100000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 69,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 66, 79, new DateTime(2024, 5, 2, 1, 3, 53, 865, DateTimeKind.Unspecified).AddTicks(7763), 9573221.467390768000000m, 9573221.467390768000000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 70,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 42, 63, new DateTime(2024, 5, 18, 6, 39, 56, 494, DateTimeKind.Unspecified).AddTicks(1920), 12233219.86140519400000m, 12233219.86140519400000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 71,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 94, 45, new DateTime(2024, 5, 22, 2, 6, 50, 776, DateTimeKind.Unspecified).AddTicks(8134), 7787826.409177458800000m, 7787826.409177458800000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 72,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 75, 64, new DateTime(2024, 5, 1, 17, 25, 20, 600, DateTimeKind.Unspecified).AddTicks(9214), 13309070.034187888800000m, 13309070.034187888800000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 73,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 24, 66, new DateTime(2024, 5, 24, 7, 36, 7, 480, DateTimeKind.Unspecified).AddTicks(1106), 10600517.055328908400000m, 10600517.055328908400000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 74,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 87, 70, new DateTime(2024, 5, 13, 19, 41, 19, 998, DateTimeKind.Unspecified).AddTicks(6784), 11870008.209327969000000m, 11870008.209327969000000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 75,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 76, 59, new DateTime(2024, 5, 29, 23, 42, 20, 661, DateTimeKind.Unspecified).AddTicks(2558), 12027218.310554698400000m, 12027218.310554698400000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 76,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 92, 41, new DateTime(2024, 5, 17, 16, 3, 25, 311, DateTimeKind.Unspecified).AddTicks(4278), 8377131.436605002500000m, 8377131.436605002500000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 77,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 10, 41, new DateTime(2024, 5, 6, 4, 15, 2, 994, DateTimeKind.Unspecified).AddTicks(2644), 8725375.353292078800000m, 8725375.353292078800000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 78,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 77, 12, new DateTime(2024, 5, 1, 19, 45, 49, 926, DateTimeKind.Unspecified).AddTicks(2085), 8072042.980024411200000m, 8072042.980024411200000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 79,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 45, 61, new DateTime(2024, 5, 8, 7, 37, 21, 109, DateTimeKind.Unspecified).AddTicks(1332), 12217068.773161870600000m, 12217068.773161870600000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 80,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 71, 13, new DateTime(2024, 5, 28, 17, 45, 6, 699, DateTimeKind.Unspecified).AddTicks(7432), 11828426.868610312800000m, 11828426.868610312800000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 81,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 58, 87, new DateTime(2024, 5, 25, 11, 38, 11, 665, DateTimeKind.Unspecified).AddTicks(4240), 8711947.032967719600000m, 8711947.032967719600000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 82,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 76, 16, new DateTime(2024, 5, 8, 0, 6, 6, 746, DateTimeKind.Unspecified).AddTicks(8861), 6027659.1620129449600000m, 6027659.1620129449600000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 83,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 75, 82, new DateTime(2024, 5, 21, 0, 1, 26, 537, DateTimeKind.Unspecified).AddTicks(4408), 9668785.192701677400000m, 9668785.192701677400000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 84,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 60, 7, new DateTime(2024, 5, 26, 23, 44, 24, 23, DateTimeKind.Unspecified).AddTicks(6917), 14343632.620995752000000m, 14343632.620995752000000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 85,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 61, 84, new DateTime(2024, 5, 19, 9, 41, 0, 708, DateTimeKind.Unspecified).AddTicks(7212), 9558230.260896312800000m, 9558230.260896312800000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 86,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 44, 80, new DateTime(2024, 5, 29, 10, 39, 44, 187, DateTimeKind.Unspecified).AddTicks(5864), 7610098.559292372000000m, 7610098.559292372000000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 87,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 77, 9, new DateTime(2024, 5, 15, 23, 10, 55, 995, DateTimeKind.Unspecified).AddTicks(3114), 14127175.624759780800000m, 14127175.624759780800000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 88,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 42, 69, new DateTime(2024, 5, 4, 23, 52, 14, 238, DateTimeKind.Unspecified).AddTicks(4159), 7848737.787893522000000m, 7848737.787893522000000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 89,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 55, 15, new DateTime(2024, 5, 19, 16, 29, 35, 38, DateTimeKind.Unspecified).AddTicks(9001), 10341588.01245811800000m, 10341588.01245811800000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 90,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 65, 33, new DateTime(2024, 5, 5, 11, 11, 25, 359, DateTimeKind.Unspecified).AddTicks(8173), 5728066.565494281300000m, 5728066.565494281300000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 91,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 86, 89, new DateTime(2024, 5, 11, 13, 48, 7, 257, DateTimeKind.Unspecified).AddTicks(5653), 13360773.712041873600000m, 13360773.712041873600000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 92,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 5, 93, new DateTime(2024, 5, 9, 15, 38, 37, 125, DateTimeKind.Unspecified).AddTicks(2777), 9589938.527896147200000m, 9589938.527896147200000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 93,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 57, 75, new DateTime(2024, 5, 29, 16, 20, 29, 584, DateTimeKind.Unspecified).AddTicks(3362), 9911052.795666629100000m, 9911052.795666629100000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 94,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 71, 92, new DateTime(2024, 5, 20, 14, 38, 19, 229, DateTimeKind.Unspecified).AddTicks(726), 8487672.129981228800000m, 8487672.129981228800000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 95,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 44, 24, new DateTime(2024, 5, 2, 23, 44, 25, 409, DateTimeKind.Unspecified).AddTicks(202), 7209883.05745138725600000m, 7209883.05745138725600000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 96,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 96, 21, new DateTime(2024, 5, 7, 22, 18, 23, 399, DateTimeKind.Unspecified).AddTicks(8215), 5958013.9261857263500000m, 5958013.9261857263500000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 97,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 66, 59, new DateTime(2024, 5, 25, 8, 25, 26, 448, DateTimeKind.Unspecified).AddTicks(7313), 8406355.245572168100000m, 8406355.245572168100000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 98,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 67, 70, new DateTime(2024, 5, 6, 2, 11, 50, 363, DateTimeKind.Unspecified).AddTicks(8604), 11706531.244332870400000m, 11706531.244332870400000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 99,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 13, 33, new DateTime(2024, 5, 1, 18, 43, 50, 999, DateTimeKind.Unspecified).AddTicks(5114), 11373315.092573306400000m, 11373315.092573306400000m });

            migrationBuilder.UpdateData(
                table: "SalesOrder",
                keyColumn: "OrderID",
                keyValue: 100,
                columns: new[] { "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[] { 8, 99, new DateTime(2024, 5, 9, 19, 5, 57, 299, DateTimeKind.Unspecified).AddTicks(6047), 12942539.367111930400000m, 12942539.367111930400000m });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "EmployeeID", "RoleID", "Email", "LastLogin", "Lock", "Password" },
                values: new object[,]
                {
                    { 1, 1, "KhanhNgoc.Ha@yahoo.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 2, 2, "NguyetMinh_Vuong93@yahoo.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 3, 2, "TamThien.Pham18@hotmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 4, 1, "KhacTrieu86@gmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 5, 2, "SonTung61@hotmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 6, 1, "YenPhuong38@gmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 7, 1, "TheHuan15@yahoo.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 8, 2, "NghiXuan49@hotmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 9, 1, "PhuongTrieu.To68@gmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 10, 2, "TuyetLoan92@hotmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 11, 1, "DucTam_Dang67@gmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 12, 2, "ThuongNga_Duong27@yahoo.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 13, 2, "ThieuBao.Tran@gmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 14, 1, "DacLuc95@hotmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 15, 2, "MinhNguyet.Ho@yahoo.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 16, 2, "DanHiep83@gmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 17, 2, "ChiThanh_Dinh@yahoo.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 18, 2, "VietTrinh.Dang87@hotmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 19, 2, "KhanhHoan_Mai99@hotmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 20, 2, "DacCuong.Duong41@yahoo.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 21, 1, "DieuAi_Lam47@gmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 22, 2, "HuuTan_Lam69@hotmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 23, 1, "PhuongTrang.Trinh44@hotmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 24, 1, "ThanhThuan47@hotmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 25, 1, "DuyHanh76@gmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 26, 2, "QuynhHoa10@yahoo.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 27, 2, "ThuyMien.Vuong@hotmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 28, 1, "XuanNgoc.Dinh@yahoo.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 29, 1, "LamNgoc.Vu@hotmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 30, 1, "ManhDinh_Hoang@gmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 31, 2, "VanAnh98@gmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 32, 2, "DiemHang12@hotmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 33, 2, "ThienDuc.Hoang@yahoo.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 34, 1, "GiaCan.To66@hotmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 35, 2, "LeNga15@gmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 36, 2, "VanAnh.Le@yahoo.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 37, 2, "NgocCam_Tang@gmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 38, 1, "ThaiMinh.Doan@yahoo.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 39, 2, "QuynhThanh_Phan88@hotmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 40, 1, "NguyenBao.Phung61@yahoo.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 41, 2, "QuangThang34@hotmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 42, 2, "BaoThach.Doan93@gmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 43, 2, "BichDao.Ha@hotmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 44, 1, "CongHao_Dang@gmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 45, 2, "ThachTung.Dao@gmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 46, 2, "NhatPhuong98@hotmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 47, 2, "KhanhQuynh.To@hotmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 48, 2, "HaPhuong.Vuong@hotmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 49, 2, "HaiNguyen_Doan31@yahoo.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 50, 2, "LuongTuyen53@yahoo.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 51, 1, "ThanhThanh.Duong53@yahoo.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 52, 1, "KimKhanh.Dao@hotmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 53, 2, "AnhTung_Bui@hotmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 54, 2, "TuanAnh90@gmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 55, 2, "NgocTho.Mai@hotmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 56, 1, "HoaHiep.Phan@hotmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 57, 2, "TueLam_Vu64@hotmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 58, 2, "PhuongNgoc54@hotmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 59, 1, "ThuanHau_Vu87@yahoo.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 60, 2, "KhanhHai_Vu97@hotmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 61, 1, "TuanSy44@yahoo.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 62, 2, "HongTam10@yahoo.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 63, 1, "HongQuang_Phan45@hotmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 64, 1, "KimDan59@yahoo.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 65, 1, "KieuThu_Mai@hotmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 66, 2, "DuyKinh31@hotmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 67, 2, "HuuLuong_To59@yahoo.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 68, 2, "PhuongLan.Le@gmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 69, 2, "ThuyLieu41@yahoo.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 70, 1, "HieuHoc43@gmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 71, 2, "BichHien.Vuong@yahoo.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 72, 1, "ThienTinh.Ha@yahoo.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 73, 2, "PhiHung_Bui69@yahoo.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 74, 2, "PhuongChi_To@gmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 75, 2, "ThanhVinh.Phan5@hotmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 76, 1, "ThuyDu.Mai89@yahoo.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 77, 1, "HaiNhi.Dang@yahoo.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 78, 1, "ThanhY.Truong29@hotmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 79, 2, "QuocTruong74@gmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 80, 1, "HaiMien57@hotmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 81, 2, "KienBinh_Ly@yahoo.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 82, 2, "NgocKhanh91@hotmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 83, 1, "QuangKhanh20@gmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 84, 1, "MinhTan_Bui41@hotmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 85, 1, "TinhTu64@hotmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 86, 1, "VietSon_Dinh43@hotmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 87, 1, "CamHuong79@hotmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 88, 1, "DanThu_Ho@hotmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 89, 1, "VietKhoi.Mai24@gmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 90, 2, "KimThanh_Bui7@yahoo.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 91, 2, "TruongLong85@hotmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 92, 1, "KienBinh_Phung@hotmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 93, 2, "HoangNgon.Vuong@yahoo.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 94, 1, "GiaoKieu_Dinh86@yahoo.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 95, 1, "TruongNhan74@gmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 96, 1, "SonQuyen_Phung@yahoo.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 97, 2, "HaGiang_Mai@gmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 98, 1, "DongVy64@hotmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 99, 1, "DuyCan_Duong@yahoo.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 100, 2, "XuanTrang_Tran@yahoo.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" }
                });

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "RoleID",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2024, 5, 24, 22, 11, 34, 611, DateTimeKind.Local).AddTicks(5811));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "RoleID",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2024, 5, 24, 22, 11, 34, 611, DateTimeKind.Local).AddTicks(5820));
        }
    }
}
