using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace QLCHBanHoaQuaWF.Migrations
{
    /// <inheritdoc />
    public partial class seed_database : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ImportOrders_Employee_EmployeeID",
                table: "ImportOrders");

            migrationBuilder.DropForeignKey(
                name: "FK_SalesOrders_Employee_EmployeeID",
                table: "SalesOrders");

            migrationBuilder.DropColumn(
                name: "TotalPrice",
                table: "DetailSalesOrders");

            migrationBuilder.DropColumn(
                name: "TotalPrice",
                table: "DetailImportOrders");

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "EmployeeID",
                table: "SalesOrders",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "Providers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Providers",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Providers",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<byte[]>(
                name: "ImageData",
                table: "Products",
                type: "varbinary(max)",
                nullable: true,
                oldClrType: typeof(byte[]),
                oldType: "varbinary(max)");

            migrationBuilder.AlterColumn<string>(
                name: "CalculationUnit",
                table: "Products",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<int>(
                name: "EmployeeID",
                table: "ImportOrders",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

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

            migrationBuilder.UpdateData(
                table: "AppInfos",
                keyColumn: "AppName",
                keyValue: "Cửa hàng của bạn",
                column: "Address",
                value: "Việt Nam");

            migrationBuilder.InsertData(
                table: "Customer",
                columns: new[] { "CustomerID", "Address", "CustomerName", "DateCreated", "Email", "Phone" },
                values: new object[,]
                {
                    { 1, "Nghệ An", "Tân Ðịnh Đoàn", new DateTime(2023, 12, 26, 20, 0, 51, 495, DateTimeKind.Local).AddTicks(5616), "ThaiHa_Dinh95@hotmail.com", "0925511672" },
                    { 2, "Bình Phước", "Ðình Hảo Trịnh", new DateTime(2023, 12, 26, 20, 0, 51, 495, DateTimeKind.Local).AddTicks(8958), "GiaBach60@yahoo.com", "0901944852" },
                    { 3, "Bình Định", "Bảo Giang Bùi", new DateTime(2023, 12, 26, 20, 0, 51, 495, DateTimeKind.Local).AddTicks(9096), "ThiNgon_Ngo@hotmail.com", "0930533420" },
                    { 4, "Hà Giang", "Hải Long Ngô", new DateTime(2023, 12, 26, 20, 0, 51, 495, DateTimeKind.Local).AddTicks(9191), "BichHai.Bui73@gmail.com", "0931646373" },
                    { 5, "Quảng Trị", "Khương Duy Lý", new DateTime(2023, 12, 26, 20, 0, 51, 495, DateTimeKind.Local).AddTicks(9278), "KimYen91@gmail.com", "0967643734" },
                    { 6, "Thái Nguyên", "Hữu Thiện Vũ", new DateTime(2023, 12, 26, 20, 0, 51, 495, DateTimeKind.Local).AddTicks(9368), "HongChau_Tran@yahoo.com", "0973678689" },
                    { 7, "Lai Châu", "Tịnh Như Phạm", new DateTime(2023, 12, 26, 20, 0, 51, 495, DateTimeKind.Local).AddTicks(9457), "XuanHoa.Lam@hotmail.com", "0927977768" },
                    { 8, "Ninh Bình", "Thụy Du Trịnh", new DateTime(2023, 12, 26, 20, 0, 51, 495, DateTimeKind.Local).AddTicks(9542), "ThienLan.Tang@yahoo.com", "0964592527" },
                    { 9, "Gia Lai", "Chí Công Lê", new DateTime(2023, 12, 26, 20, 0, 51, 495, DateTimeKind.Local).AddTicks(9621), "HungDung.Dang43@gmail.com", "0996378064" },
                    { 10, "Hà Tĩnh", "Thái Vân Đinh", new DateTime(2023, 12, 26, 20, 0, 51, 495, DateTimeKind.Local).AddTicks(9709), "TrongDuy_Le@yahoo.com", "0995137289" },
                    { 11, "Tuyên Quang", "Thanh Yến Đào", new DateTime(2023, 12, 26, 20, 0, 51, 495, DateTimeKind.Local).AddTicks(9791), "QuocThang90@hotmail.com", "0983674771" },
                    { 12, "Đồng Tháp", "Cường Thịnh Ngô", new DateTime(2023, 12, 26, 20, 0, 51, 495, DateTimeKind.Local).AddTicks(9880), "ManhThien_Tang3@hotmail.com", "0969494097" },
                    { 13, "Điện Biên", "Minh Thủy Hoàng", new DateTime(2023, 12, 26, 20, 0, 51, 495, DateTimeKind.Local).AddTicks(9968), "KhuongDuy.Bui@hotmail.com", "0986978252" },
                    { 14, "Lai Châu", "Ðức Bảo Vương", new DateTime(2023, 12, 26, 20, 0, 51, 496, DateTimeKind.Local).AddTicks(42), "DucPhong.Dao@yahoo.com", "0980828698" },
                    { 15, "Vĩnh Phúc", "Hiệp Hòa Nguyễn", new DateTime(2023, 12, 26, 20, 0, 51, 496, DateTimeKind.Local).AddTicks(123), "TuyetBang_Phung3@yahoo.com", "0922753311" },
                    { 16, "Hà Nội", "Hạc Cúc Ngô", new DateTime(2023, 12, 26, 20, 0, 51, 496, DateTimeKind.Local).AddTicks(201), "XuanLan_Tang@gmail.com", "0951096423" },
                    { 17, "Đồng Tháp", "Trúc Chi Trương", new DateTime(2023, 12, 26, 20, 0, 51, 496, DateTimeKind.Local).AddTicks(278), "CongLuan39@hotmail.com", "0904007868" },
                    { 18, "Bến Tre", "Bích Hợp Đặng", new DateTime(2023, 12, 26, 20, 0, 51, 496, DateTimeKind.Local).AddTicks(353), "HuuTrac_Truong@yahoo.com", "0907572191" },
                    { 19, "Tiền Giang", "Uy Vũ Đinh", new DateTime(2023, 12, 26, 20, 0, 51, 496, DateTimeKind.Local).AddTicks(435), "HungThinh.Mai43@gmail.com", "0913870752" },
                    { 20, "Cao Bằng", "Huy Khiêm Hà", new DateTime(2023, 12, 26, 20, 0, 51, 496, DateTimeKind.Local).AddTicks(534), "QuynhGiao19@gmail.com", "0950206406" },
                    { 21, "Bình Phước", "Phước Lộc Đoàn", new DateTime(2023, 12, 26, 20, 0, 51, 496, DateTimeKind.Local).AddTicks(656), "VienThong.Vu@gmail.com", "0900819207" },
                    { 22, "Ninh Bình", "Diễm Thư Phạm", new DateTime(2023, 12, 26, 20, 0, 51, 496, DateTimeKind.Local).AddTicks(784), "AnTam32@yahoo.com", "0988150988" },
                    { 23, "Nam Định", "Quang Ninh Vương", new DateTime(2023, 12, 26, 20, 0, 51, 496, DateTimeKind.Local).AddTicks(901), "HieuGiang.Duong@gmail.com", "0978528244" },
                    { 24, "Long An", "Thế Doanh Đỗ", new DateTime(2023, 12, 26, 20, 0, 51, 496, DateTimeKind.Local).AddTicks(1004), "NgocLy.Le68@hotmail.com", "0921791895" },
                    { 25, "Bình Thuận", "Thụy Linh Vũ", new DateTime(2023, 12, 26, 20, 0, 51, 496, DateTimeKind.Local).AddTicks(1080), "ThuThuan.Do@hotmail.com", "0955664151" },
                    { 26, "Vĩnh Long", "Chiến Thắng Phan", new DateTime(2023, 12, 26, 20, 0, 51, 496, DateTimeKind.Local).AddTicks(1159), "SonCa_Vu@yahoo.com", "0978919828" },
                    { 27, "Bình Phước", "Thanh Hương Dương", new DateTime(2023, 12, 26, 20, 0, 51, 496, DateTimeKind.Local).AddTicks(1228), "BachKim_Dao@hotmail.com", "0965028072" },
                    { 28, "Sóc Trăng", "Kiều Giang Hà", new DateTime(2023, 12, 26, 20, 0, 51, 496, DateTimeKind.Local).AddTicks(1306), "TrucLoan.Dao@hotmail.com", "0970995767" },
                    { 29, "Bắc Giang", "Xuân Hương Tăng", new DateTime(2023, 12, 26, 20, 0, 51, 496, DateTimeKind.Local).AddTicks(1378), "NghiQuyen_Vu@hotmail.com", "0927871501" },
                    { 30, "Cần Thơ", "Thục Trinh Phan", new DateTime(2023, 12, 26, 20, 0, 51, 496, DateTimeKind.Local).AddTicks(1454), "QuynhDao_Truong@gmail.com", "0992195070" },
                    { 31, "Đồng Tháp", "Thiên Khánh Đỗ", new DateTime(2023, 12, 26, 20, 0, 51, 496, DateTimeKind.Local).AddTicks(1530), "GiangLam94@hotmail.com", "0911288965" },
                    { 32, "Hưng Yên", "Thúy Vi Trần", new DateTime(2023, 12, 26, 20, 0, 51, 496, DateTimeKind.Local).AddTicks(1609), "DuyMy19@yahoo.com", "0951926501" },
                    { 33, "Cà Mau", "Hải Duyên Vương", new DateTime(2023, 12, 26, 20, 0, 51, 496, DateTimeKind.Local).AddTicks(1685), "ThuanPhong.Nguyen@hotmail.com", "0974575964" },
                    { 34, "Bắc Ninh", "Thế Vinh Lâm", new DateTime(2023, 12, 26, 20, 0, 51, 496, DateTimeKind.Local).AddTicks(1784), "MinhTrieu.Lam27@gmail.com", "0905667287" },
                    { 35, "Ninh Bình", "Chánh Việt Bùi", new DateTime(2023, 12, 26, 20, 0, 51, 496, DateTimeKind.Local).AddTicks(1864), "TuLy.Phung34@hotmail.com", "0959665985" },
                    { 36, "Hậu Giang", "Trọng Tường Bùi", new DateTime(2023, 12, 26, 20, 0, 51, 496, DateTimeKind.Local).AddTicks(1935), "PhuongThe_Dang30@yahoo.com", "0928981766" },
                    { 37, "Thừa Thiên-Huế", "Huyền Trâm Trương", new DateTime(2023, 12, 26, 20, 0, 51, 496, DateTimeKind.Local).AddTicks(2018), "ThanhNhan_Ly@yahoo.com", "0985616743" },
                    { 38, "Bắc Ninh", "Cát Ly Đoàn", new DateTime(2023, 12, 26, 20, 0, 51, 496, DateTimeKind.Local).AddTicks(2089), "LamNhi_Nguyen27@yahoo.com", "0912651231" },
                    { 39, "Hải Dương", "Uyên Trâm Trương", new DateTime(2023, 12, 26, 20, 0, 51, 496, DateTimeKind.Local).AddTicks(2164), "BichNgan85@hotmail.com", "0901468906" },
                    { 40, "Đồng Nai", "Thế Vinh Hoàng", new DateTime(2023, 12, 26, 20, 0, 51, 496, DateTimeKind.Local).AddTicks(2243), "MongLan22@hotmail.com", "0907772864" },
                    { 41, "Long An", "Lan Nhi Tô", new DateTime(2023, 12, 26, 20, 0, 51, 496, DateTimeKind.Local).AddTicks(2316), "ThuNguyet_Tang@gmail.com", "0975188366" },
                    { 42, "Bà Rịa-Vũng Tàu", "Lam Ngọc Nguyễn", new DateTime(2023, 12, 26, 20, 0, 51, 496, DateTimeKind.Local).AddTicks(2386), "MyPhung20@gmail.com", "0984275934" },
                    { 43, "Thừa Thiên-Huế", "Thanh Ðạo Lê", new DateTime(2023, 12, 26, 20, 0, 51, 496, DateTimeKind.Local).AddTicks(2464), "HoaiPhong_Dao@gmail.com", "0950252771" },
                    { 44, "Bắc Kạn", "Bảo Tiên Hồ", new DateTime(2023, 12, 26, 20, 0, 51, 496, DateTimeKind.Local).AddTicks(2542), "BichLoan_Ngo86@yahoo.com", "0922066050" },
                    { 45, "Lai Châu", "Thăng Long Mai", new DateTime(2023, 12, 26, 20, 0, 51, 496, DateTimeKind.Local).AddTicks(2615), "NhaKhanh_Do3@yahoo.com", "0906099131" },
                    { 46, "Bắc Ninh", "Lê Quỳnh Lý", new DateTime(2023, 12, 26, 20, 0, 51, 496, DateTimeKind.Local).AddTicks(2693), "XuanTrung47@yahoo.com", "0999768506" },
                    { 47, "Cao Bằng", "Thục Nhi Tô", new DateTime(2023, 12, 26, 20, 0, 51, 496, DateTimeKind.Local).AddTicks(2764), "ThuLam.Ngo36@yahoo.com", "0984825747" },
                    { 48, "Đồng Tháp", "Minh Hồng Vương", new DateTime(2023, 12, 26, 20, 0, 51, 496, DateTimeKind.Local).AddTicks(2842), "CatTuong53@yahoo.com", "0994910174" },
                    { 49, "Kon Tum", "Dũng Việt Trần", new DateTime(2023, 12, 26, 20, 0, 51, 496, DateTimeKind.Local).AddTicks(2914), "HuuVinh26@yahoo.com", "0996035276" },
                    { 50, "Phú Thọ", "Minh Thảo Trương", new DateTime(2023, 12, 26, 20, 0, 51, 496, DateTimeKind.Local).AddTicks(2989), "NhatThuong78@gmail.com", "0952595371" },
                    { 51, "Cần Thơ", "Thủy Tiên Đặng", new DateTime(2023, 12, 26, 20, 0, 51, 496, DateTimeKind.Local).AddTicks(3058), "TheAn_Ha47@hotmail.com", "0910209010" },
                    { 52, "Ninh Bình", "Hữu Khanh Trần", new DateTime(2023, 12, 26, 20, 0, 51, 496, DateTimeKind.Local).AddTicks(3130), "PhongLan_Lam87@hotmail.com", "0942153681" },
                    { 53, "Lào Cai", "Quốc Hòa Lê", new DateTime(2023, 12, 26, 20, 0, 51, 496, DateTimeKind.Local).AddTicks(3202), "SaoBang_Nguyen88@yahoo.com", "0951213757" },
                    { 54, "Hà Giang", "Khắc Tuấn Đinh", new DateTime(2023, 12, 26, 20, 0, 51, 496, DateTimeKind.Local).AddTicks(3283), "HoangMy.Do93@hotmail.com", "0979508940" },
                    { 55, "Quảng Nam", "Lâm Uyên Phạm", new DateTime(2023, 12, 26, 20, 0, 51, 496, DateTimeKind.Local).AddTicks(3352), "QuocHoang.To@hotmail.com", "0957918693" },
                    { 56, "Lai Châu", "Ngọc Trụ Mai", new DateTime(2023, 12, 26, 20, 0, 51, 496, DateTimeKind.Local).AddTicks(3427), "NghiLuc75@hotmail.com", "0943368066" },
                    { 57, "Hải Dương", "Quỳnh Giao Lý", new DateTime(2023, 12, 26, 20, 0, 51, 496, DateTimeKind.Local).AddTicks(3498), "MinhHang.Pham@gmail.com", "0961569628" },
                    { 58, "Hà Nội", "Hạ Tiên Hà", new DateTime(2023, 12, 26, 20, 0, 51, 496, DateTimeKind.Local).AddTicks(3568), "QuocTru_Dao@yahoo.com", "0991786573" },
                    { 59, "An Giang", "Kiều Mai Đào", new DateTime(2023, 12, 26, 20, 0, 51, 496, DateTimeKind.Local).AddTicks(3641), "TuyetLoan.To29@gmail.com", "0979499330" },
                    { 60, "Đắk Lắk", "Anh Thư Trần", new DateTime(2023, 12, 26, 20, 0, 51, 496, DateTimeKind.Local).AddTicks(3711), "PhuongLoan46@yahoo.com", "0915792107" },
                    { 61, "Bà Rịa-Vũng Tàu", "Mạnh Quỳnh Trương", new DateTime(2023, 12, 26, 20, 0, 51, 496, DateTimeKind.Local).AddTicks(3785), "ThongNhat_Doan@hotmail.com", "0943182553" },
                    { 62, "Nam Định", "Cát Tường Hà", new DateTime(2023, 12, 26, 20, 0, 51, 496, DateTimeKind.Local).AddTicks(3858), "TuanKhai_Truong0@gmail.com", "0953783383" },
                    { 63, "Hòa Bình", "Thanh Trung Phạm", new DateTime(2023, 12, 26, 20, 0, 51, 496, DateTimeKind.Local).AddTicks(3939), "AnTuong.Lam@hotmail.com", "0933626593" },
                    { 64, "Hà Giang", "Nguyên Hạnh Vương", new DateTime(2023, 12, 26, 20, 0, 51, 496, DateTimeKind.Local).AddTicks(4008), "DangDat_Nguyen13@hotmail.com", "0919884170" },
                    { 65, "Vĩnh Phúc", "Ðình Tuấn Phạm", new DateTime(2023, 12, 26, 20, 0, 51, 496, DateTimeKind.Local).AddTicks(4089), "VietKhoi56@gmail.com", "0928806680" },
                    { 66, "Hà Nam", "Sơn Hải Phùng", new DateTime(2023, 12, 26, 20, 0, 51, 496, DateTimeKind.Local).AddTicks(4167), "HuePhuong28@yahoo.com", "0974803969" },
                    { 67, "Bến Tre", "Thiện Mỹ Phùng", new DateTime(2023, 12, 26, 20, 0, 51, 496, DateTimeKind.Local).AddTicks(4240), "DongDao74@yahoo.com", "0994470406" },
                    { 68, "Tiền Giang", "Việt Hải Đặng", new DateTime(2023, 12, 26, 20, 0, 51, 496, DateTimeKind.Local).AddTicks(4313), "TuyetHan.Phan@hotmail.com", "0978663548" },
                    { 69, "Bình Dương", "Quang Hà Lê", new DateTime(2023, 12, 26, 20, 0, 51, 496, DateTimeKind.Local).AddTicks(4385), "ToLoan_Le31@hotmail.com", "0908088959" },
                    { 70, "TP. Hồ Chí Minh", "Minh Vương Dương", new DateTime(2023, 12, 26, 20, 0, 51, 496, DateTimeKind.Local).AddTicks(4459), "TrungChinh.Dinh40@yahoo.com", "0958856422" },
                    { 71, "Cà Mau", "Hoài Thanh Hồ", new DateTime(2023, 12, 26, 20, 0, 51, 496, DateTimeKind.Local).AddTicks(4536), "DanKhanh.Tang30@gmail.com", "0956426545" },
                    { 72, "TP. Hồ Chí Minh", "Cao Nguyên Nguyễn", new DateTime(2023, 12, 26, 20, 0, 51, 496, DateTimeKind.Local).AddTicks(4615), "CanhTuan50@yahoo.com", "0908488141" },
                    { 73, "Sóc Trăng", "Chí Dũng Nguyễn", new DateTime(2023, 12, 26, 20, 0, 51, 496, DateTimeKind.Local).AddTicks(4727), "TuanKhanh90@gmail.com", "0938109986" },
                    { 74, "Quảng Trị", "Quỳnh Giang Trương", new DateTime(2023, 12, 26, 20, 0, 51, 496, DateTimeKind.Local).AddTicks(4893), "HuuNghia89@yahoo.com", "0917083324" },
                    { 75, "Bình Dương", "Nhã Hồng Đặng", new DateTime(2023, 12, 26, 20, 0, 51, 496, DateTimeKind.Local).AddTicks(4967), "NgocLy_Trinh12@hotmail.com", "0962452309" },
                    { 76, "Hà Giang", "Khải Tâm Tăng", new DateTime(2023, 12, 26, 20, 0, 51, 496, DateTimeKind.Local).AddTicks(5043), "VanPhuong_Ho@hotmail.com", "0970489384" },
                    { 77, "TP. Hồ Chí Minh", "Minh Giang Ngô", new DateTime(2023, 12, 26, 20, 0, 51, 496, DateTimeKind.Local).AddTicks(5119), "ThuHau45@hotmail.com", "0947870029" },
                    { 78, "Vĩnh Long", "Thiếu Anh Đào", new DateTime(2023, 12, 26, 20, 0, 51, 496, DateTimeKind.Local).AddTicks(5193), "AnBinh98@yahoo.com", "0909336507" },
                    { 79, "Yên Bái", "Quang Thái Đặng", new DateTime(2023, 12, 26, 20, 0, 51, 496, DateTimeKind.Local).AddTicks(5269), "ThatTho_Vu@hotmail.com", "0918687906" },
                    { 80, "Bình Dương", "Thục Khuê Đỗ", new DateTime(2023, 12, 26, 20, 0, 51, 496, DateTimeKind.Local).AddTicks(5333), "HaThanh.Truong@hotmail.com", "0993105041" },
                    { 81, "Sóc Trăng", "Tố Quyên Mai", new DateTime(2023, 12, 26, 20, 0, 51, 496, DateTimeKind.Local).AddTicks(5413), "BaoPhuong5@gmail.com", "0958403087" },
                    { 82, "Thanh Hoá", "Chánh Việt Mai", new DateTime(2023, 12, 26, 20, 0, 51, 496, DateTimeKind.Local).AddTicks(5484), "MinhHung75@gmail.com", "0995842585" },
                    { 83, "Thái Nguyên", "Viết Nhân Hoàng", new DateTime(2023, 12, 26, 20, 0, 51, 496, DateTimeKind.Local).AddTicks(5559), "MinhTriet36@yahoo.com", "0990854862" },
                    { 84, "Quảng Trị", "Anh Mai Phùng", new DateTime(2023, 12, 26, 20, 0, 51, 496, DateTimeKind.Local).AddTicks(5629), "ThienThu58@yahoo.com", "0912434945" },
                    { 85, "Tiền Giang", "Quỳnh Trâm Trịnh", new DateTime(2023, 12, 26, 20, 0, 51, 496, DateTimeKind.Local).AddTicks(5703), "LongVinh_Phan22@hotmail.com", "0973076677" },
                    { 86, "Hải Phòng", "Hữu Khanh Trần", new DateTime(2023, 12, 26, 20, 0, 51, 496, DateTimeKind.Local).AddTicks(5779), "ThienDuyen60@gmail.com", "0907580879" },
                    { 87, "Kon Tum", "Bích Quân Hồ", new DateTime(2023, 12, 26, 20, 0, 51, 496, DateTimeKind.Local).AddTicks(5848), "HuongBinh_Trinh@yahoo.com", "0952642017" },
                    { 88, "Lâm Đồng", "Phương Quỳnh Đào", new DateTime(2023, 12, 26, 20, 0, 51, 496, DateTimeKind.Local).AddTicks(5923), "QuangHuu16@gmail.com", "0943032263" },
                    { 89, "Tây Ninh", "Mộng Hằng Trần", new DateTime(2023, 12, 26, 20, 0, 51, 496, DateTimeKind.Local).AddTicks(5989), "BinhYen_Le@gmail.com", "0947690496" },
                    { 90, "Tuyên Quang", "Thiên Thảo Phan", new DateTime(2023, 12, 26, 20, 0, 51, 496, DateTimeKind.Local).AddTicks(6061), "KimKhuyen_Ngo27@gmail.com", "0993807651" },
                    { 91, "Hải Phòng", "Mỹ Thuần Mai", new DateTime(2023, 12, 26, 20, 0, 51, 496, DateTimeKind.Local).AddTicks(6131), "HuuThang_Le@yahoo.com", "0991032126" },
                    { 92, "Hải Dương", "Minh Anh Trương", new DateTime(2023, 12, 26, 20, 0, 51, 496, DateTimeKind.Local).AddTicks(6203), "ThuyMi_Mai91@hotmail.com", "0964432828" },
                    { 93, "Ninh Thuận", "Thái Thanh Phạm", new DateTime(2023, 12, 26, 20, 0, 51, 496, DateTimeKind.Local).AddTicks(6270), "BachTra.Tang@hotmail.com", "0907046668" },
                    { 94, "Quảng Ninh", "Huyền Diệu Lê", new DateTime(2023, 12, 26, 20, 0, 51, 496, DateTimeKind.Local).AddTicks(6343), "QuocPhuong.Ha61@yahoo.com", "0998147470" },
                    { 95, "Hà Nội", "Hoàng Linh Lâm", new DateTime(2023, 12, 26, 20, 0, 51, 496, DateTimeKind.Local).AddTicks(6412), "NghiaHoa77@hotmail.com", "0963165499" },
                    { 96, "Điện Biên", "Ngọc Vân Mai", new DateTime(2023, 12, 26, 20, 0, 51, 496, DateTimeKind.Local).AddTicks(6486), "QuynhNgan.Ha18@yahoo.com", "0944996360" },
                    { 97, "Sơn La", "Hiền Mai Trịnh", new DateTime(2023, 12, 26, 20, 0, 51, 496, DateTimeKind.Local).AddTicks(6559), "QuynhDao.Pham@gmail.com", "0936263067" },
                    { 98, "Ninh Thuận", "Hùng Tường Trịnh", new DateTime(2023, 12, 26, 20, 0, 51, 496, DateTimeKind.Local).AddTicks(6627), "HuyKha.Tang@gmail.com", "0952347535" },
                    { 99, "Điện Biên", "Mai Linh Đỗ", new DateTime(2023, 12, 26, 20, 0, 51, 496, DateTimeKind.Local).AddTicks(6698), "DanTam78@yahoo.com", "0977692495" },
                    { 100, "Cao Bằng", "Tài Nguyên Vũ", new DateTime(2023, 12, 26, 20, 0, 51, 496, DateTimeKind.Local).AddTicks(6762), "HuyKhanh_Do48@gmail.com", "0963049191" }
                });

            migrationBuilder.InsertData(
                table: "Employee",
                columns: new[] { "EmployeeID", "Address", "DateCreated", "Email", "EmployeeName", "Phone", "Salary" },
                values: new object[,]
                {
                    { 1, "TP. Hồ Chí Minh", new DateTime(2023, 12, 26, 20, 0, 51, 502, DateTimeKind.Local).AddTicks(996), "HoangXuan_To@gmail.com", "Thanh Hiếu Lý", "0998593443", 562914.342002318000000m },
                    { 2, "Cao Bằng", new DateTime(2023, 12, 26, 20, 0, 51, 502, DateTimeKind.Local).AddTicks(4157), "KyDuyen68@hotmail.com", "Bảo Phương Trịnh", "0915225335", 705050.771387813500000m },
                    { 3, "Nghệ An", new DateTime(2023, 12, 26, 20, 0, 51, 502, DateTimeKind.Local).AddTicks(4304), "XuanLoan_Ly83@yahoo.com", "Kim Ánh Hồ", "0965176379", 981936.127189087000000m },
                    { 4, "Quảng Bình", new DateTime(2023, 12, 26, 20, 0, 51, 502, DateTimeKind.Local).AddTicks(4359), "BuuChuong.Truong43@yahoo.com", "Thái San Lê", "0900420033", 629590.809852700500000m },
                    { 5, "Đắk Nông", new DateTime(2023, 12, 26, 20, 0, 51, 502, DateTimeKind.Local).AddTicks(4408), "HienThuc.Do@gmail.com", "Hoàng Xuân Đinh", "0918125599", 877655.515273791000000m },
                    { 6, "Long An", new DateTime(2023, 12, 26, 20, 0, 51, 502, DateTimeKind.Local).AddTicks(4470), "BaoHa77@yahoo.com", "Hoàng Nam Dương", "0940891271", 941582.990014563000000m },
                    { 7, "Bà Rịa-Vũng Tàu", new DateTime(2023, 12, 26, 20, 0, 51, 502, DateTimeKind.Local).AddTicks(4515), "TrucLoan22@hotmail.com", "Ðình Lộc Hoàng", "0989630142", 575613.493195779500000m },
                    { 8, "Sơn La", new DateTime(2023, 12, 26, 20, 0, 51, 502, DateTimeKind.Local).AddTicks(4563), "MinhTam.Ho@hotmail.com", "Quỳnh Lâm Vũ", "0973414451", 878423.537069249000000m },
                    { 9, "Cần Thơ", new DateTime(2023, 12, 26, 20, 0, 51, 502, DateTimeKind.Local).AddTicks(4614), "TanPhat_Trinh90@hotmail.com", "Trường Hiệp Bùi", "0930226721", 941669.642592434500000m },
                    { 10, "Thái Nguyên", new DateTime(2023, 12, 26, 20, 0, 51, 502, DateTimeKind.Local).AddTicks(4659), "ThuyMai_Truong@yahoo.com", "Thu Hà Trần", "0931402569", 729853.012136187000000m },
                    { 11, "Đồng Nai", new DateTime(2023, 12, 26, 20, 0, 51, 502, DateTimeKind.Local).AddTicks(4708), "DucPhong.Dang67@gmail.com", "Thụy Miên Hoàng", "0964332174", 927800.478420049500000m },
                    { 12, "Bắc Ninh", new DateTime(2023, 12, 26, 20, 0, 51, 502, DateTimeKind.Local).AddTicks(4752), "PhiHung_Ly80@gmail.com", "Bình Quân Đào", "0922807027", 723885.845503717500000m },
                    { 13, "Lai Châu", new DateTime(2023, 12, 26, 20, 0, 51, 502, DateTimeKind.Local).AddTicks(4797), "ThanhAn_Dinh69@yahoo.com", "Đan Thu Lê", "0935825387", 660615.008220431500000m },
                    { 14, "Tiền Giang", new DateTime(2023, 12, 26, 20, 0, 51, 502, DateTimeKind.Local).AddTicks(4845), "XuanQuy_Phung@yahoo.com", "Thanh Tuyền Vũ", "0932154386", 573113.978180051500000m },
                    { 15, "Trà Vinh", new DateTime(2023, 12, 26, 20, 0, 51, 502, DateTimeKind.Local).AddTicks(4891), "NgocTuyet.Ngo@yahoo.com", "Phương Yến Phùng", "0938108887", 814969.201019142000000m },
                    { 16, "Tuyên Quang", new DateTime(2023, 12, 26, 20, 0, 51, 502, DateTimeKind.Local).AddTicks(4937), "PhuongHien17@gmail.com", "Thu Hằng Ngô", "0984822670", 717018.280844816500000m },
                    { 17, "Ninh Bình", new DateTime(2023, 12, 26, 20, 0, 51, 502, DateTimeKind.Local).AddTicks(4987), "NgocDan.Pham7@gmail.com", "Hải Nam Lý", "0938123712", 899769.299319129000000m },
                    { 18, "Cao Bằng", new DateTime(2023, 12, 26, 20, 0, 51, 502, DateTimeKind.Local).AddTicks(5031), "VietQuyet51@yahoo.com", "Hiền Hòa Phùng", "0964695067", 598227.401351540500000m },
                    { 19, "Thanh Hoá", new DateTime(2023, 12, 26, 20, 0, 51, 502, DateTimeKind.Local).AddTicks(5073), "KhanhHoan36@hotmail.com", "Xuân Ngọc Tô", "0982839624", 527305.9064872863500000m },
                    { 20, "Cao Bằng", new DateTime(2023, 12, 26, 20, 0, 51, 502, DateTimeKind.Local).AddTicks(5132), "NhatPhuong_Lam@yahoo.com", "Oanh Vũ Đặng", "0974374116", 599939.729662947000000m },
                    { 21, "Khánh Hoà", new DateTime(2023, 12, 26, 20, 0, 51, 502, DateTimeKind.Local).AddTicks(5175), "TamTrang.Phung@yahoo.com", "Hòa Hiệp Tăng", "0933223441", 524805.3488966866000000m },
                    { 22, "Cần Thơ", new DateTime(2023, 12, 26, 20, 0, 51, 502, DateTimeKind.Local).AddTicks(5220), "HuongTrang_Vuong@gmail.com", "Phương Thi Đặng", "0914758901", 898642.473261278000000m },
                    { 23, "Thanh Hoá", new DateTime(2023, 12, 26, 20, 0, 51, 502, DateTimeKind.Local).AddTicks(5268), "DuyKhang54@gmail.com", "Hoàng Dũng Phùng", "0925149107", 890573.239425956500000m },
                    { 24, "Yên Bái", new DateTime(2023, 12, 26, 20, 0, 51, 502, DateTimeKind.Local).AddTicks(5313), "HoangHai_Hoang18@yahoo.com", "Long Giang Nguyễn", "0973206036", 719992.53541667500000m },
                    { 25, "Lâm Đồng", new DateTime(2023, 12, 26, 20, 0, 51, 502, DateTimeKind.Local).AddTicks(5369), "KieuThu75@gmail.com", "Ðức Toàn Đào", "0908104746", 596931.843798005500000m },
                    { 26, "Nghệ An", new DateTime(2023, 12, 26, 20, 0, 51, 502, DateTimeKind.Local).AddTicks(5413), "KimToan.Ly45@gmail.com", "Thu Ngân Trần", "0934108539", 945620.431933794500000m },
                    { 27, "TP. Hồ Chí Minh", new DateTime(2023, 12, 26, 20, 0, 51, 502, DateTimeKind.Local).AddTicks(5454), "MyNuong_Bui82@gmail.com", "Nam Phương Bùi", "0954759466", 763862.911693118500000m },
                    { 28, "Đắk Nông", new DateTime(2023, 12, 26, 20, 0, 51, 502, DateTimeKind.Local).AddTicks(5505), "BaoSon.Ho@gmail.com", "Phong Ðộ Dương", "0968080392", 777364.314897793000000m },
                    { 29, "Quảng Nam", new DateTime(2023, 12, 26, 20, 0, 51, 502, DateTimeKind.Local).AddTicks(5550), "MinhHuong_Phung28@gmail.com", "Hồng Ðăng Lâm", "0925464550", 770381.978828797500000m },
                    { 30, "Bình Phước", new DateTime(2023, 12, 26, 20, 0, 51, 502, DateTimeKind.Local).AddTicks(5592), "ThyOanh94@hotmail.com", "Ngọc Quế Lâm", "0954804596", 702475.467034078000000m },
                    { 31, "Thái Nguyên", new DateTime(2023, 12, 26, 20, 0, 51, 502, DateTimeKind.Local).AddTicks(5644), "TrongKhanh_Ly@hotmail.com", "Tiểu Mi Vương", "0930979591", 541036.800634626500000m },
                    { 32, "Long An", new DateTime(2023, 12, 26, 20, 0, 51, 502, DateTimeKind.Local).AddTicks(5688), "DinhChuong.Vu75@yahoo.com", "Như Mai Hồ", "0927816263", 603763.074157958000000m },
                    { 33, "Quảng Ninh", new DateTime(2023, 12, 26, 20, 0, 51, 502, DateTimeKind.Local).AddTicks(5731), "AnKhang_Dang14@gmail.com", "Tuấn Ðức Ngô", "0950870712", 899975.065548458000000m },
                    { 34, "Hà Nội", new DateTime(2023, 12, 26, 20, 0, 51, 502, DateTimeKind.Local).AddTicks(5782), "DuyKinh_Lam@gmail.com", "Nguyệt Nga Đào", "0954694208", 563010.611623785500000m },
                    { 35, "Hà Nam", new DateTime(2023, 12, 26, 20, 0, 51, 502, DateTimeKind.Local).AddTicks(5826), "BichHong2@yahoo.com", "Thiện Tâm Hồ", "0964892277", 874833.666492301500000m },
                    { 36, "Bắc Giang", new DateTime(2023, 12, 26, 20, 0, 51, 502, DateTimeKind.Local).AddTicks(5879), "CaoPhong41@gmail.com", "Thanh Vân Đào", "0968838321", 569596.984246813000000m },
                    { 37, "Quảng Ngãi", new DateTime(2023, 12, 26, 20, 0, 51, 502, DateTimeKind.Local).AddTicks(5923), "SongThu.Trinh23@yahoo.com", "Quang Vũ Hồ", "0993933258", 769163.237636818500000m },
                    { 38, "Vĩnh Phúc", new DateTime(2023, 12, 26, 20, 0, 51, 502, DateTimeKind.Local).AddTicks(5967), "PhongDo_Vuong55@yahoo.com", "Nhật Hoàng Đỗ", "0987847398", 705098.847160138000000m },
                    { 39, "Đồng Tháp", new DateTime(2023, 12, 26, 20, 0, 51, 502, DateTimeKind.Local).AddTicks(6017), "VietVo_Vu@yahoo.com", "Yên Bằng Mai", "0986659374", 995412.849006603000000m },
                    { 40, "Điện Biên", new DateTime(2023, 12, 26, 20, 0, 51, 502, DateTimeKind.Local).AddTicks(6066), "ThucDao.Hoang@yahoo.com", "Tiền Giang Hoàng", "0971674176", 983512.628605296000000m },
                    { 41, "Hải Dương", new DateTime(2023, 12, 26, 20, 0, 51, 502, DateTimeKind.Local).AddTicks(6107), "CaoNhan46@hotmail.com", "Quế Anh Hà", "0997019562", 848281.406401429500000m },
                    { 42, "Quảng Trị", new DateTime(2023, 12, 26, 20, 0, 51, 502, DateTimeKind.Local).AddTicks(6157), "TuyetThanh61@yahoo.com", "Việt An Hồ", "0984007710", 729642.755161037000000m },
                    { 43, "Quảng Nam", new DateTime(2023, 12, 26, 20, 0, 51, 502, DateTimeKind.Local).AddTicks(6199), "ThuyGiang.Phan@yahoo.com", "Phương An Đỗ", "0934166514", 733246.58066548000000m },
                    { 44, "Hà Nội", new DateTime(2023, 12, 26, 20, 0, 51, 502, DateTimeKind.Local).AddTicks(6241), "DanThanh73@gmail.com", "Thông Tuệ Mai", "0958761592", 684346.50489042000000m },
                    { 45, "Hải Dương", new DateTime(2023, 12, 26, 20, 0, 51, 502, DateTimeKind.Local).AddTicks(6292), "BichDiep84@yahoo.com", "Song Kê Phùng", "0905271562", 868148.459778737500000m },
                    { 46, "Hưng Yên", new DateTime(2023, 12, 26, 20, 0, 51, 502, DateTimeKind.Local).AddTicks(6341), "NhuNga_Dinh@hotmail.com", "Ngọc Khuê Mai", "0907082480", 867836.464800028500000m },
                    { 47, "Kon Tum", new DateTime(2023, 12, 26, 20, 0, 51, 502, DateTimeKind.Local).AddTicks(6388), "BichHao.Pham2@yahoo.com", "Đức Hạnh Nguyễn", "0929035691", 940408.01841034500000m },
                    { 48, "Đà Nẵng", new DateTime(2023, 12, 26, 20, 0, 51, 502, DateTimeKind.Local).AddTicks(6430), "KimChi64@gmail.com", "Kim Ngân Ngô", "0980063144", 619221.826634092500000m },
                    { 49, "Cao Bằng", new DateTime(2023, 12, 26, 20, 0, 51, 502, DateTimeKind.Local).AddTicks(6473), "HoaLien30@hotmail.com", "Hải Dương Mai", "0903896476", 709328.773450978000000m },
                    { 50, "Quảng Nam", new DateTime(2023, 12, 26, 20, 0, 51, 502, DateTimeKind.Local).AddTicks(6523), "BaoDinh.Pham79@hotmail.com", "Hồng Quý Đào", "0929345650", 728830.284140628000000m },
                    { 51, "Lạng Sơn", new DateTime(2023, 12, 26, 20, 0, 51, 502, DateTimeKind.Local).AddTicks(6566), "NhatThinh.Dang24@yahoo.com", "Giao Kiều Nguyễn", "0942878291", 568627.278764258000000m },
                    { 52, "Cà Mau", new DateTime(2023, 12, 26, 20, 0, 51, 502, DateTimeKind.Local).AddTicks(6612), "NhatHa.Pham@yahoo.com", "Gia Cẩn Trịnh", "0960521545", 562236.438335475500000m },
                    { 53, "Quảng Trị", new DateTime(2023, 12, 26, 20, 0, 51, 502, DateTimeKind.Local).AddTicks(6663), "VanNhi69@hotmail.com", "Thế Duyệt Phạm", "0925417633", 628366.438792372000000m },
                    { 54, "Hà Nội", new DateTime(2023, 12, 26, 20, 0, 51, 502, DateTimeKind.Local).AddTicks(6706), "BaoDuy.Trinh@hotmail.com", "Hướng Thiện Hồ", "0940373341", 617198.074733518500000m },
                    { 55, "Hòa Bình", new DateTime(2023, 12, 26, 20, 0, 51, 502, DateTimeKind.Local).AddTicks(6750), "ChePhuong60@hotmail.com", "Xuân Sơn Đặng", "0995330565", 744728.178230566500000m },
                    { 56, "Bắc Giang", new DateTime(2023, 12, 26, 20, 0, 51, 502, DateTimeKind.Local).AddTicks(6799), "AnhHuong.Trinh@gmail.com", "Thu Vọng Tô", "0900928085", 905887.476607598000000m },
                    { 57, "Trà Vinh", new DateTime(2023, 12, 26, 20, 0, 51, 502, DateTimeKind.Local).AddTicks(6845), "PhucDien.Truong@gmail.com", "Bảo An Vương", "0940310073", 951310.756034269000000m },
                    { 58, "Kiên Giang", new DateTime(2023, 12, 26, 20, 0, 51, 502, DateTimeKind.Local).AddTicks(6897), "NgocHoan_To@hotmail.com", "Thu Trang Hà", "0973995399", 639077.489676138500000m },
                    { 59, "Hải Dương", new DateTime(2023, 12, 26, 20, 0, 51, 502, DateTimeKind.Local).AddTicks(6940), "KieuMy.Ha@yahoo.com", "Mai Loan Phùng", "0979181249", 585697.628987252500000m },
                    { 60, "Thừa Thiên-Huế", new DateTime(2023, 12, 26, 20, 0, 51, 502, DateTimeKind.Local).AddTicks(6983), "SonTuyen22@yahoo.com", "Ðức Toản Trịnh", "0963780227", 748506.470668221000000m },
                    { 61, "Đắk Lắk", new DateTime(2023, 12, 26, 20, 0, 51, 502, DateTimeKind.Local).AddTicks(7031), "BinhYen66@yahoo.com", "Minh Dũng Dương", "0973875226", 757464.084930011000000m },
                    { 62, "Đắk Lắk", new DateTime(2023, 12, 26, 20, 0, 51, 502, DateTimeKind.Local).AddTicks(7073), "AnhTho0@hotmail.com", "Gia Cảnh Hoàng", "0913444824", 881535.371928053000000m },
                    { 63, "Nam Định", new DateTime(2023, 12, 26, 20, 0, 51, 502, DateTimeKind.Local).AddTicks(7113), "GiaHoa6@gmail.com", "Mạnh Ðình Phan", "0982099185", 504337.79860374667000000m },
                    { 64, "Hà Nam", new DateTime(2023, 12, 26, 20, 0, 51, 502, DateTimeKind.Local).AddTicks(7162), "ThucUyen64@gmail.com", "Bảo Trâm Trương", "0955228617", 900248.194928016000000m },
                    { 65, "Nghệ An", new DateTime(2023, 12, 26, 20, 0, 51, 502, DateTimeKind.Local).AddTicks(7204), "AnhThy_Tang@gmail.com", "Hồng Đăng Lê", "0905486389", 633211.942878138000000m },
                    { 66, "Lai Châu", new DateTime(2023, 12, 26, 20, 0, 51, 502, DateTimeKind.Local).AddTicks(7245), "DiepVy24@gmail.com", "Tùng Linh Phạm", "0974079316", 797984.377562124000000m },
                    { 67, "Phú Yên", new DateTime(2023, 12, 26, 20, 0, 51, 502, DateTimeKind.Local).AddTicks(7295), "KhacTuan_Nguyen@yahoo.com", "Việt Anh Đinh", "0980973919", 706640.265921727500000m },
                    { 68, "Hưng Yên", new DateTime(2023, 12, 26, 20, 0, 51, 502, DateTimeKind.Local).AddTicks(7336), "VanTuyen77@yahoo.com", "Lệ Chi Đinh", "0973078054", 752133.234259699000000m },
                    { 69, "Quảng Nam", new DateTime(2023, 12, 26, 20, 0, 51, 502, DateTimeKind.Local).AddTicks(7379), "PhuongTram.Vuong69@yahoo.com", "Phúc Thịnh Tô", "0972428791", 767466.229463184500000m },
                    { 70, "Sóc Trăng", new DateTime(2023, 12, 26, 20, 0, 51, 502, DateTimeKind.Local).AddTicks(7429), "HuuThang88@gmail.com", "Hùng Phong Ngô", "0975939027", 809687.94071081500000m },
                    { 71, "Đắk Nông", new DateTime(2023, 12, 26, 20, 0, 51, 502, DateTimeKind.Local).AddTicks(7472), "MyHuong99@yahoo.com", "Thục Khuê Tăng", "0973432287", 648020.611310384000000m },
                    { 72, "TP. Hồ Chí Minh", new DateTime(2023, 12, 26, 20, 0, 51, 502, DateTimeKind.Local).AddTicks(7526), "MinhQuan_Trinh@hotmail.com", "Bích Nga Tô", "0954546012", 632048.011966028000000m },
                    { 73, "Yên Bái", new DateTime(2023, 12, 26, 20, 0, 51, 502, DateTimeKind.Local).AddTicks(7568), "ThanhViet88@gmail.com", "Tuệ Nhi Đặng", "0923925228", 533529.1407069080500000m },
                    { 74, "Phú Thọ", new DateTime(2023, 12, 26, 20, 0, 51, 502, DateTimeKind.Local).AddTicks(7609), "HongBachThao25@gmail.com", "Thất Cương Đinh", "0954275689", 535456.3753315701500000m },
                    { 75, "Bình Dương", new DateTime(2023, 12, 26, 20, 0, 51, 502, DateTimeKind.Local).AddTicks(7659), "XuanUyen_To86@yahoo.com", "Túy Loan Mai", "0950462801", 786341.664865761000000m },
                    { 76, "Nghệ An", new DateTime(2023, 12, 26, 20, 0, 51, 502, DateTimeKind.Local).AddTicks(7704), "ThuyLinh_Mai@gmail.com", "Trọng Duy Vương", "0998813546", 890723.442277209500000m },
                    { 77, "Lâm Đồng", new DateTime(2023, 12, 26, 20, 0, 51, 502, DateTimeKind.Local).AddTicks(7746), "NhaUyen52@hotmail.com", "Tuyết Loan Phạm", "0910145101", 705029.65103097500000m },
                    { 78, "Thừa Thiên-Huế", new DateTime(2023, 12, 26, 20, 0, 51, 502, DateTimeKind.Local).AddTicks(7821), "TanDung.Do37@yahoo.com", "Trung Nguyên Hồ", "0960376617", 545057.993079016500000m },
                    { 79, "Hà Nam", new DateTime(2023, 12, 26, 20, 0, 51, 502, DateTimeKind.Local).AddTicks(7871), "HoaHiep83@gmail.com", "Hải Lý Tăng", "0964237809", 922485.066472535500000m },
                    { 80, "Thừa Thiên-Huế", new DateTime(2023, 12, 26, 20, 0, 51, 502, DateTimeKind.Local).AddTicks(7912), "PhuThoi.Ho@yahoo.com", "Phúc Thịnh Trương", "0924540783", 694671.227688029000000m },
                    { 81, "Bình Định", new DateTime(2023, 12, 26, 20, 0, 51, 502, DateTimeKind.Local).AddTicks(7961), "LyChau.Dinh13@yahoo.com", "Liên Hoa Đặng", "0987052924", 646663.453857974500000m },
                    { 82, "Đắk Nông", new DateTime(2023, 12, 26, 20, 0, 51, 502, DateTimeKind.Local).AddTicks(8004), "NgocDoan69@hotmail.com", "Kim Xuyến Vương", "0934132660", 810856.830473715500000m },
                    { 83, "An Giang", new DateTime(2023, 12, 26, 20, 0, 51, 502, DateTimeKind.Local).AddTicks(8053), "ThanhThanh.Lam40@gmail.com", "Nhật Duy Đinh", "0951116923", 964881.602253613000000m },
                    { 84, "Hà Tĩnh", new DateTime(2023, 12, 26, 20, 0, 51, 502, DateTimeKind.Local).AddTicks(8096), "QuocTien_Truong12@yahoo.com", "Hồng Thảo Trương", "0928028041", 912127.888935571000000m },
                    { 85, "Hưng Yên", new DateTime(2023, 12, 26, 20, 0, 51, 502, DateTimeKind.Local).AddTicks(8145), "NgocTrinh.Lam84@yahoo.com", "Yến My Đào", "0985208194", 644198.43349182500000m },
                    { 86, "Vĩnh Long", new DateTime(2023, 12, 26, 20, 0, 51, 502, DateTimeKind.Local).AddTicks(8195), "DuyKhiem.Nguyen90@yahoo.com", "Thái Hòa Đinh", "0976205352", 872262.989511193500000m },
                    { 87, "Bạc Liêu", new DateTime(2023, 12, 26, 20, 0, 51, 502, DateTimeKind.Local).AddTicks(8239), "NgocHoa46@yahoo.com", "Bảo Bảo Mai", "0967598435", 831507.637297166000000m },
                    { 88, "Thanh Hoá", new DateTime(2023, 12, 26, 20, 0, 51, 502, DateTimeKind.Local).AddTicks(8282), "UyenThy.Dang@yahoo.com", "Trúc Sinh Tăng", "0994008479", 558867.699408933500000m },
                    { 89, "Hải Phòng", new DateTime(2023, 12, 26, 20, 0, 51, 502, DateTimeKind.Local).AddTicks(8334), "BaoLong.Vu51@yahoo.com", "Nguyên Bổng Vương", "0956392166", 633991.545546906000000m },
                    { 90, "Khánh Hoà", new DateTime(2023, 12, 26, 20, 0, 51, 502, DateTimeKind.Local).AddTicks(8379), "NgocOanh32@hotmail.com", "Thuận Anh Phan", "0923983419", 695409.357978586000000m },
                    { 91, "Đồng Nai", new DateTime(2023, 12, 26, 20, 0, 51, 502, DateTimeKind.Local).AddTicks(8422), "ThienTri2@yahoo.com", "Ánh Nguyệt Phạm", "0972644100", 589586.72204314000000m },
                    { 92, "Đà Nẵng", new DateTime(2023, 12, 26, 20, 0, 51, 502, DateTimeKind.Local).AddTicks(8475), "NgocHoa94@gmail.com", "Diệu Lan Dương", "0958999096", 852382.592820651500000m },
                    { 93, "Trà Vinh", new DateTime(2023, 12, 26, 20, 0, 51, 502, DateTimeKind.Local).AddTicks(8517), "HuuTrung.Dang@gmail.com", "Sỹ Thực Lê", "0958579785", 878001.59118210500000m },
                    { 94, "Cần Thơ", new DateTime(2023, 12, 26, 20, 0, 51, 502, DateTimeKind.Local).AddTicks(8567), "HaiSon_Tang90@yahoo.com", "Hải Nam Tô", "0938936290", 555676.634140596000000m },
                    { 95, "Trà Vinh", new DateTime(2023, 12, 26, 20, 0, 51, 502, DateTimeKind.Local).AddTicks(8608), "ThuyDao35@gmail.com", "Thanh Kiều Đào", "0930129485", 570474.941564500000m },
                    { 96, "Cà Mau", new DateTime(2023, 12, 26, 20, 0, 51, 502, DateTimeKind.Local).AddTicks(8652), "LapThanh0@hotmail.com", "Kỳ Anh Đặng", "0950323751", 953553.317344902500000m },
                    { 97, "Khánh Hoà", new DateTime(2023, 12, 26, 20, 0, 51, 502, DateTimeKind.Local).AddTicks(8702), "ThuyTien9@gmail.com", "Phước Nhân Tô", "0963182649", 833643.882535700500000m },
                    { 98, "Khánh Hoà", new DateTime(2023, 12, 26, 20, 0, 51, 502, DateTimeKind.Local).AddTicks(8741), "DanThanh_Phan18@yahoo.com", "Hằng Anh Đinh", "0977929624", 796569.598161973000000m },
                    { 99, "Hậu Giang", new DateTime(2023, 12, 26, 20, 0, 51, 502, DateTimeKind.Local).AddTicks(8784), "DuyThanh.Truong99@gmail.com", "Thu Vân Phùng", "0936783810", 718340.122684255500000m },
                    { 100, "Lào Cai", new DateTime(2023, 12, 26, 20, 0, 51, 502, DateTimeKind.Local).AddTicks(8830), "VanThuong.To@yahoo.com", "Ngọc Ðoàn Hà", "0965909531", 904453.664732861000000m }
                });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 1,
                columns: new[] { "CanExportSalesOrder", "CanPrintSalesOrder", "CanReadDetailImportOrder", "CanReadProduct", "CanReadSalesOrder" },
                values: new object[] { true, true, false, true, true });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "PermissionID", "CanCreateCustomer", "CanCreateEmployee", "CanCreateImportOrder", "CanCreateProduct", "CanCreateSalesOrder", "CanCreateUserRole", "CanCreatedProvider", "CanDeleteCustomer", "CanDeleteEmployee", "CanDeleteImportOrder", "CanDeleteProduct", "CanDeleteProvider", "CanDeleteSalesOrder", "CanDeleteUserRole", "CanExportImportOrder", "CanExportSalesOrder", "CanPrintImportOrder", "CanPrintSalesOrder", "CanReadCustomer", "CanReadDetailImportOrder", "CanReadDetailSalesOrder", "CanReadEmployee", "CanReadImportOrder", "CanReadOptions", "CanReadProduct", "CanReadProvider", "CanReadSalesOrder", "CanReadStatistics", "CanReadUser", "CanReadUserRole", "CanUpdateCustomer", "CanUpdateEmployee", "CanUpdateProduct", "CanUpdateProvider", "CanUpdateUserRole", "IsAdmin" },
                values: new object[] { 2, false, false, false, false, false, false, true, false, false, false, false, true, false, false, true, false, true, false, false, true, false, false, true, false, true, true, false, false, false, false, false, false, false, true, false, false });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductID", "CalculationUnit", "DateCreated", "Description", "ImageData", "ImportUnitPrice", "Inventory", "ProductName", "UnitPrice" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2023, 12, 26, 20, 0, 51, 506, DateTimeKind.Local).AddTicks(556), null, null, 25306.338751034640000m, 142, "Táo", 157468.210330612700000m },
                    { 2, null, new DateTime(2023, 12, 26, 20, 0, 51, 506, DateTimeKind.Local).AddTicks(4290), null, null, 25435.492773261920000m, 76, "Chuối", 145167.823255072800000m },
                    { 3, null, new DateTime(2023, 12, 26, 20, 0, 51, 506, DateTimeKind.Local).AddTicks(4326), null, null, 29988.224077461560000m, 41, "Dứa", 196511.334143407100000m },
                    { 4, null, new DateTime(2023, 12, 26, 20, 0, 51, 506, DateTimeKind.Local).AddTicks(4336), null, null, 37086.725253760640000m, 105, "Cam", 125614.149784445900000m },
                    { 5, null, new DateTime(2023, 12, 26, 20, 0, 51, 506, DateTimeKind.Local).AddTicks(4345), null, null, 30837.49263989080000m, 60, "Kiwi", 188973.585910544700000m },
                    { 6, null, new DateTime(2023, 12, 26, 20, 0, 51, 506, DateTimeKind.Local).AddTicks(4354), null, null, 48952.84188677480000m, 44, "Cherry", 191033.431603983200000m },
                    { 7, null, new DateTime(2023, 12, 26, 20, 0, 51, 506, DateTimeKind.Local).AddTicks(4363), null, null, 10213.19087619287040000m, 111, "Lựu", 133760.205748416600000m },
                    { 8, null, new DateTime(2023, 12, 26, 20, 0, 51, 506, DateTimeKind.Local).AddTicks(4388), null, null, 36136.24204980360000m, 37, "Dâu tây", 143812.790945978400000m },
                    { 9, null, new DateTime(2023, 12, 26, 20, 0, 51, 506, DateTimeKind.Local).AddTicks(4397), null, null, 46774.634374622280000m, 117, "Nho", 163729.680088777800000m },
                    { 10, null, new DateTime(2023, 12, 26, 20, 0, 51, 506, DateTimeKind.Local).AddTicks(4406), null, null, 24828.077660222160000m, 83, "Lê", 113815.236690938400000m },
                    { 11, null, new DateTime(2023, 12, 26, 20, 0, 51, 506, DateTimeKind.Local).AddTicks(4414), null, null, 18397.611312499400000m, 137, "Dừa", 177182.819334630600000m },
                    { 12, null, new DateTime(2023, 12, 26, 20, 0, 51, 506, DateTimeKind.Local).AddTicks(4423), null, null, 49942.609409502920000m, 79, "Bưởi", 150022.374231513800000m },
                    { 13, null, new DateTime(2023, 12, 26, 20, 0, 51, 506, DateTimeKind.Local).AddTicks(4433), null, null, 39853.738626437440000m, 127, "Dưa hấu", 191483.945227803800000m },
                    { 14, null, new DateTime(2023, 12, 26, 20, 0, 51, 506, DateTimeKind.Local).AddTicks(4444), null, null, 33168.047414647880000m, 14, "Mâm xôi", 102393.8256683873800000m },
                    { 15, null, new DateTime(2023, 12, 26, 20, 0, 51, 506, DateTimeKind.Local).AddTicks(4454), null, null, 36965.343391143280000m, 102, "Bơ", 123649.194966857400000m },
                    { 16, null, new DateTime(2023, 12, 26, 20, 0, 51, 506, DateTimeKind.Local).AddTicks(4463), null, null, 49604.246142339480000m, 104, "Xoài", 161288.250463714600000m },
                    { 17, null, new DateTime(2023, 12, 26, 20, 0, 51, 506, DateTimeKind.Local).AddTicks(4472), null, null, 22671.915822464240000m, 122, "Cà chua", 105497.9979960973100000m },
                    { 18, null, new DateTime(2023, 12, 26, 20, 0, 51, 506, DateTimeKind.Local).AddTicks(4480), null, null, 44024.672899206120000m, 138, "Dừa xiêm", 145738.307841191800000m },
                    { 19, null, new DateTime(2023, 12, 26, 20, 0, 51, 506, DateTimeKind.Local).AddTicks(4488), null, null, 18856.73235381400000m, 67, "Dưa lưới", 198306.182185476100000m },
                    { 20, null, new DateTime(2023, 12, 26, 20, 0, 51, 506, DateTimeKind.Local).AddTicks(4496), null, null, 45726.936561727360000m, 70, "Mận", 194056.506522158400000m },
                    { 21, null, new DateTime(2023, 12, 26, 20, 0, 51, 506, DateTimeKind.Local).AddTicks(4505), null, null, 23637.429246548840000m, 114, "Lý chua", 133387.344139994400000m },
                    { 22, null, new DateTime(2023, 12, 26, 20, 0, 51, 506, DateTimeKind.Local).AddTicks(4513), null, null, 47784.089644499480000m, 96, "Quýt", 139347.145423573700000m },
                    { 23, null, new DateTime(2023, 12, 26, 20, 0, 51, 506, DateTimeKind.Local).AddTicks(4522), null, null, 47575.964127391560000m, 102, "Cây lựu đỏ", 198324.729929332500000m },
                    { 24, null, new DateTime(2023, 12, 26, 20, 0, 51, 506, DateTimeKind.Local).AddTicks(4530), null, null, 42170.012817478720000m, 146, "Hồng", 198460.41924576500000m },
                    { 25, null, new DateTime(2023, 12, 26, 20, 0, 51, 506, DateTimeKind.Local).AddTicks(4539), null, null, 43885.750881699760000m, 78, "Đu đủ", 110768.590633306700000m },
                    { 26, null, new DateTime(2023, 12, 26, 20, 0, 51, 506, DateTimeKind.Local).AddTicks(4547), null, null, 13949.9707558611760000m, 72, "Ổi", 153803.492334887100000m },
                    { 27, null, new DateTime(2023, 12, 26, 20, 0, 51, 506, DateTimeKind.Local).AddTicks(4556), null, null, 20018.052255904920000m, 128, "Việt quất", 192307.759880283200000m },
                    { 28, null, new DateTime(2023, 12, 26, 20, 0, 51, 506, DateTimeKind.Local).AddTicks(4564), null, null, 36404.450991399800000m, 86, "Dứa hấu", 198910.605921124900000m },
                    { 29, null, new DateTime(2023, 12, 26, 20, 0, 51, 506, DateTimeKind.Local).AddTicks(4573), null, null, 19047.657203845720000m, 74, "Cây dừa sen", 102959.4340650452900000m },
                    { 30, null, new DateTime(2023, 12, 26, 20, 0, 51, 506, DateTimeKind.Local).AddTicks(4581), null, null, 37693.283805707040000m, 35, "Cherry đỏ", 133825.365573727700000m },
                    { 31, null, new DateTime(2023, 12, 26, 20, 0, 51, 506, DateTimeKind.Local).AddTicks(4589), null, null, 20771.952691598920000m, 145, "Cây dừa nước", 168544.033364688500000m },
                    { 32, null, new DateTime(2023, 12, 26, 20, 0, 51, 506, DateTimeKind.Local).AddTicks(4598), null, null, 37586.21646604920000m, 91, "Nho đen", 116190.167324288900000m },
                    { 33, null, new DateTime(2023, 12, 26, 20, 0, 51, 506, DateTimeKind.Local).AddTicks(4607), null, null, 43023.048855974720000m, 50, "Cây dừa cạn", 115398.44029342300000m },
                    { 34, null, new DateTime(2023, 12, 26, 20, 0, 51, 506, DateTimeKind.Local).AddTicks(4616), null, null, 41263.103692084760000m, 73, "Dừa xanh", 111463.830522810400000m },
                    { 35, null, new DateTime(2023, 12, 26, 20, 0, 51, 506, DateTimeKind.Local).AddTicks(4624), null, null, 44117.659678354160000m, 41, "Táo xanh", 103988.510135806200000m },
                    { 36, null, new DateTime(2023, 12, 26, 20, 0, 51, 506, DateTimeKind.Local).AddTicks(4634), null, null, 43180.300118326880000m, 22, "Lê Mỹ", 136907.98393245300000m },
                    { 37, null, new DateTime(2023, 12, 26, 20, 0, 51, 506, DateTimeKind.Local).AddTicks(4642), null, null, 26572.482175148080000m, 103, "Bưởi da xanh", 140511.312769061900000m },
                    { 38, null, new DateTime(2023, 12, 26, 20, 0, 51, 506, DateTimeKind.Local).AddTicks(4658), null, null, 35593.261341062080000m, 90, "Bưởi da đỏ", 136777.218734662800000m },
                    { 39, null, new DateTime(2023, 12, 26, 20, 0, 51, 506, DateTimeKind.Local).AddTicks(4667), null, null, 32579.448034849560000m, 114, "Xoài ruột đỏ", 172682.912477258600000m },
                    { 40, null, new DateTime(2023, 12, 26, 20, 0, 51, 506, DateTimeKind.Local).AddTicks(4675), null, null, 35406.389476384560000m, 109, "Bưởi vàng", 151889.934238648800000m },
                    { 41, null, new DateTime(2023, 12, 26, 20, 0, 51, 506, DateTimeKind.Local).AddTicks(4685), null, null, 25570.839495647840000m, 110, "Đào", 181658.210620762100000m },
                    { 42, null, new DateTime(2023, 12, 26, 20, 0, 51, 506, DateTimeKind.Local).AddTicks(4693), null, null, 20489.109738277360000m, 66, "Cây hồng đỏ", 183694.35282962800000m },
                    { 43, null, new DateTime(2023, 12, 26, 20, 0, 51, 506, DateTimeKind.Local).AddTicks(4703), null, null, 40018.147761437480000m, 109, "Đào mỹ", 135466.27108768900000m },
                    { 44, null, new DateTime(2023, 12, 26, 20, 0, 51, 506, DateTimeKind.Local).AddTicks(4712), null, null, 16672.526878718840000m, 43, "Kiwi vàng", 197870.605089763100000m },
                    { 45, null, new DateTime(2023, 12, 26, 20, 0, 51, 506, DateTimeKind.Local).AddTicks(4721), null, null, 46233.266116795960000m, 20, "Lựu năm cánh", 179077.109896116400000m },
                    { 46, null, new DateTime(2023, 12, 26, 20, 0, 51, 506, DateTimeKind.Local).AddTicks(4729), null, null, 28282.101353487000000m, 79, "Cây lê trái hình bầu dục", 135809.707281469800000m },
                    { 47, null, new DateTime(2023, 12, 26, 20, 0, 51, 506, DateTimeKind.Local).AddTicks(4738), null, null, 24969.563043584720000m, 118, "Bơ Fuerte", 120681.188526408900000m },
                    { 48, null, new DateTime(2023, 12, 26, 20, 0, 51, 506, DateTimeKind.Local).AddTicks(4746), null, null, 25187.285651376240000m, 94, "Bơ Hass", 187248.853826244500000m },
                    { 49, null, new DateTime(2023, 12, 26, 20, 0, 51, 506, DateTimeKind.Local).AddTicks(4756), null, null, 24526.553384066360000m, 65, "Bơ lụi", 168909.83203089800000m },
                    { 50, null, new DateTime(2023, 12, 26, 20, 0, 51, 506, DateTimeKind.Local).AddTicks(4765), null, null, 23419.818852462320000m, 116, "Dâu", 100854.20779961554700000m },
                    { 51, null, new DateTime(2023, 12, 26, 20, 0, 51, 506, DateTimeKind.Local).AddTicks(4773), null, null, 23199.954786792960000m, 111, "Dâu rừng", 169409.943955898600000m },
                    { 52, null, new DateTime(2023, 12, 26, 20, 0, 51, 506, DateTimeKind.Local).AddTicks(4782), null, null, 26313.85484842920000m, 41, "Dâu tây mỹ", 188154.544303872800000m },
                    { 53, null, new DateTime(2023, 12, 26, 20, 0, 51, 506, DateTimeKind.Local).AddTicks(4790), null, null, 11525.8803149498880000m, 90, "Cây cam vàng", 128272.421755477100000m },
                    { 54, null, new DateTime(2023, 12, 26, 20, 0, 51, 506, DateTimeKind.Local).AddTicks(4799), null, null, 37999.478060095120000m, 115, "Cây cam sành", 187217.62247505300000m },
                    { 55, null, new DateTime(2023, 12, 26, 20, 0, 51, 506, DateTimeKind.Local).AddTicks(4807), null, null, 15855.712314229480000m, 47, "Cam quýt", 142154.072293404500000m },
                    { 56, null, new DateTime(2023, 12, 26, 20, 0, 51, 506, DateTimeKind.Local).AddTicks(4815), null, null, 12453.0338194984440000m, 39, "Cam chanh", 126824.953831116200000m },
                    { 57, null, new DateTime(2023, 12, 26, 20, 0, 51, 506, DateTimeKind.Local).AddTicks(4824), null, null, 32570.084030836920000m, 62, "Cây dâu chứng", 146683.003253990800000m },
                    { 58, null, new DateTime(2023, 12, 26, 20, 0, 51, 506, DateTimeKind.Local).AddTicks(4832), null, null, 43897.897878232760000m, 57, "Dứa cayenne", 109853.8448098451200000m },
                    { 59, null, new DateTime(2023, 12, 26, 20, 0, 51, 506, DateTimeKind.Local).AddTicks(4840), null, null, 17570.923118369160000m, 65, "Dứa Victoria", 127417.10708822500000m },
                    { 60, null, new DateTime(2023, 12, 26, 20, 0, 51, 506, DateTimeKind.Local).AddTicks(4849), null, null, 18585.832834835080000m, 49, "Cây lựu Đài Loan", 177399.943705136900000m },
                    { 61, null, new DateTime(2023, 12, 26, 20, 0, 51, 506, DateTimeKind.Local).AddTicks(4866), null, null, 39776.839428365280000m, 98, "Lựu Thái", 138323.850867515300000m },
                    { 62, null, new DateTime(2023, 12, 26, 20, 0, 51, 506, DateTimeKind.Local).AddTicks(4881), null, null, 48392.719597701240000m, 115, "Dưa gang", 184381.418753667900000m },
                    { 63, null, new DateTime(2023, 12, 26, 20, 0, 51, 506, DateTimeKind.Local).AddTicks(4895), null, null, 49716.002702148240000m, 85, "Dưa chuột", 169525.267202530500000m },
                    { 64, null, new DateTime(2023, 12, 26, 20, 0, 51, 506, DateTimeKind.Local).AddTicks(4908), null, null, 17870.23614633440000m, 99, "Dưa hấu mật ong", 161765.629865926800000m },
                    { 65, null, new DateTime(2023, 12, 26, 20, 0, 51, 506, DateTimeKind.Local).AddTicks(4921), null, null, 36502.493433562760000m, 130, "Mâm xôi trái dẹt", 120571.187316720100000m },
                    { 66, null, new DateTime(2023, 12, 26, 20, 0, 51, 506, DateTimeKind.Local).AddTicks(4933), null, null, 34964.584254238320000m, 39, "Mâm xôi nước", 138674.515778798600000m },
                    { 67, null, new DateTime(2023, 12, 26, 20, 0, 51, 506, DateTimeKind.Local).AddTicks(4962), null, null, 24547.856540386840000m, 28, "Mâm xôi mỹ", 116956.609278328200000m },
                    { 68, null, new DateTime(2023, 12, 26, 20, 0, 51, 506, DateTimeKind.Local).AddTicks(4977), null, null, 11283.1936740267840000m, 74, "Bưởi mật", 111523.893519301800000m },
                    { 69, null, new DateTime(2023, 12, 26, 20, 0, 51, 506, DateTimeKind.Local).AddTicks(4992), null, null, 19619.889157696560000m, 47, "Xoài Cầu", 127894.51377062500000m },
                    { 70, null, new DateTime(2023, 12, 26, 20, 0, 51, 506, DateTimeKind.Local).AddTicks(5006), null, null, 44068.858203724040000m, 79, "Xoài Cát", 140775.736416820500000m },
                    { 71, null, new DateTime(2023, 12, 26, 20, 0, 51, 506, DateTimeKind.Local).AddTicks(5019), null, null, 14074.669406822760000m, 71, "Cà chua cherry", 124448.430936387400000m },
                    { 72, null, new DateTime(2023, 12, 26, 20, 0, 51, 506, DateTimeKind.Local).AddTicks(5029), null, null, 14934.595674850080000m, 121, "Cà chua bi", 111955.454306997700000m },
                    { 73, null, new DateTime(2023, 12, 26, 20, 0, 51, 506, DateTimeKind.Local).AddTicks(5038), null, null, 17307.687772819280000m, 101, "Cà chua Roma", 105620.0495159138500000m },
                    { 74, null, new DateTime(2023, 12, 26, 20, 0, 51, 506, DateTimeKind.Local).AddTicks(5047), null, null, 31637.781217724440000m, 126, "Cà chua đen", 169318.271114746400000m },
                    { 75, null, new DateTime(2023, 12, 26, 20, 0, 51, 506, DateTimeKind.Local).AddTicks(5055), null, null, 40331.128778126680000m, 45, "Dừa macapuno", 129221.534731102100000m },
                    { 76, null, new DateTime(2023, 12, 26, 20, 0, 51, 506, DateTimeKind.Local).AddTicks(5064), null, null, 39383.400694483840000m, 99, "Dừa xiêm hạt dẻ", 165637.964780073300000m },
                    { 77, null, new DateTime(2023, 12, 26, 20, 0, 51, 506, DateTimeKind.Local).AddTicks(5073), null, null, 38116.138151717840000m, 34, "Dừa xiêm trắng", 190047.935533389600000m },
                    { 78, null, new DateTime(2023, 12, 26, 20, 0, 51, 506, DateTimeKind.Local).AddTicks(5081), null, null, 48479.274375144240000m, 108, "Dừa xiêm xanh", 128826.61046053400000m },
                    { 79, null, new DateTime(2023, 12, 26, 20, 0, 51, 506, DateTimeKind.Local).AddTicks(5114), null, null, 25396.212552162840000m, 109, "Dưa lưới lạc đà", 133644.3923769100000m },
                    { 80, null, new DateTime(2023, 12, 26, 20, 0, 51, 506, DateTimeKind.Local).AddTicks(5131), null, null, 42852.39528786440000m, 27, "Mận dầm", 128858.682087753800000m },
                    { 81, null, new DateTime(2023, 12, 26, 20, 0, 51, 506, DateTimeKind.Local).AddTicks(5139), null, null, 25854.739346980360000m, 108, "Mận đỏ", 173215.157744532200000m },
                    { 82, null, new DateTime(2023, 12, 26, 20, 0, 51, 506, DateTimeKind.Local).AddTicks(5148), null, null, 38100.571203300840000m, 97, "Lý chua ngọt", 135415.852999570500000m },
                    { 83, null, new DateTime(2023, 12, 26, 20, 0, 51, 506, DateTimeKind.Local).AddTicks(5156), null, null, 36277.57217839640000m, 136, "Lý chua Thái", 147775.603087382100000m },
                    { 84, null, new DateTime(2023, 12, 26, 20, 0, 51, 506, DateTimeKind.Local).AddTicks(5164), null, null, 42879.00875934920000m, 52, "Quýt dẻo", 188410.404661845900000m },
                    { 85, null, new DateTime(2023, 12, 26, 20, 0, 51, 506, DateTimeKind.Local).AddTicks(5173), null, null, 45381.458821648560000m, 82, "Cây lựu Anh", 112623.321699278400000m },
                    { 86, null, new DateTime(2023, 12, 26, 20, 0, 51, 506, DateTimeKind.Local).AddTicks(5181), null, null, 19622.632671413160000m, 75, "Hồng xiêm", 135712.109717834200000m },
                    { 87, null, new DateTime(2023, 12, 26, 20, 0, 51, 506, DateTimeKind.Local).AddTicks(5189), null, null, 49466.075887476440000m, 102, "Đu đủ hồng", 172509.303387528600000m },
                    { 88, null, new DateTime(2023, 12, 26, 20, 0, 51, 506, DateTimeKind.Local).AddTicks(5197), null, null, 19672.634405414480000m, 98, "Ổi mận", 118497.8952653100000m },
                    { 89, null, new DateTime(2023, 12, 26, 20, 0, 51, 506, DateTimeKind.Local).AddTicks(5206), null, null, 49251.214139322160000m, 69, "Ổi hồng", 102225.5857101682700000m },
                    { 90, null, new DateTime(2023, 12, 26, 20, 0, 51, 506, DateTimeKind.Local).AddTicks(5214), null, null, 39633.565488765680000m, 81, "Việt quất chín", 119731.350081151800000m },
                    { 91, null, new DateTime(2023, 12, 26, 20, 0, 51, 506, DateTimeKind.Local).AddTicks(5222), null, null, 14948.100553053840000m, 69, "Dứa hấu Golden", 111385.75436586200000m },
                    { 92, null, new DateTime(2023, 12, 26, 20, 0, 51, 506, DateTimeKind.Local).AddTicks(5231), null, null, 12012.5487450875000000m, 72, "Cây dừa vòi voi", 142384.161116026200000m },
                    { 93, null, new DateTime(2023, 12, 26, 20, 0, 51, 506, DateTimeKind.Local).AddTicks(5239), null, null, 37595.859016223800000m, 77, "Dừa tươi", 199142.629041914200000m },
                    { 94, null, new DateTime(2023, 12, 26, 20, 0, 51, 506, DateTimeKind.Local).AddTicks(5247), null, null, 30193.171036592200000m, 113, "Táo Fuji", 125776.43869617300000m },
                    { 95, null, new DateTime(2023, 12, 26, 20, 0, 51, 506, DateTimeKind.Local).AddTicks(5255), null, null, 14144.636553413560000m, 32, "Táo Green Smith", 147229.944099034100000m },
                    { 96, null, new DateTime(2023, 12, 26, 20, 0, 51, 506, DateTimeKind.Local).AddTicks(5288), null, null, 29339.40033341920000m, 33, "Kiwi hayward", 191162.33623082700000m },
                    { 97, null, new DateTime(2023, 12, 26, 20, 0, 51, 506, DateTimeKind.Local).AddTicks(5298), null, null, 16070.311952545840000m, 30, "Cherry Rainier", 155316.276406438700000m },
                    { 98, null, new DateTime(2023, 12, 26, 20, 0, 51, 506, DateTimeKind.Local).AddTicks(5307), null, null, 40746.081281071840000m, 60, "Cây lựu đỏ khô", 116693.215264175200000m },
                    { 99, null, new DateTime(2023, 12, 26, 20, 0, 51, 506, DateTimeKind.Local).AddTicks(5316), null, null, 40611.248843408240000m, 80, "Cam Caravela", 177951.987427543400000m },
                    { 100, null, new DateTime(2023, 12, 26, 20, 0, 51, 506, DateTimeKind.Local).AddTicks(5325), null, null, 33548.287916467280000m, 75, "Sake", 121369.280905543500000m }
                });

            migrationBuilder.InsertData(
                table: "Providers",
                columns: new[] { "ProviderID", "Address", "Email", "Phone", "ProviderName" },
                values: new object[,]
                {
                    { 1, "Gia Lai", "HieuThong9@yahoo.com", "0915921221", "Nhật Lệ Ngô" },
                    { 2, "Điện Biên", "HoangMy.Duong@hotmail.com", "0983914014", "Ðông Hải Mai" },
                    { 3, "Bắc Giang", "VietDung_Duong@gmail.com", "0920037378", "Viễn Ðông Trương" },
                    { 4, "Đắk Nông", "HuongTien.To18@gmail.com", "0932105059", "Hùng Tường Trương" },
                    { 5, "Tuyên Quang", "UyenThi_Ha@yahoo.com", "0979985797", "Hướng Dương Vũ" },
                    { 6, "Hưng Yên", "DieuNga.Phan@yahoo.com", "0988798724", "Yến Ðan Vũ" },
                    { 7, "Đà Nẵng", "ThaiMinh.To@yahoo.com", "0997770397", "Ngọc Hải Đặng" },
                    { 8, "Bình Thuận", "HaiSan6@yahoo.com", "0972405752", "Trường Giang Đặng" },
                    { 9, "Thừa Thiên-Huế", "HongPhat_Pham53@gmail.com", "0933072466", "Vân Sơn Phạm" },
                    { 10, "Tây Ninh", "KhueTrung_Vu@gmail.com", "0933958555", "Khánh Giang Phạm" },
                    { 11, "Lai Châu", "DacThanh_Doan@hotmail.com", "0927105634", "Yến Nhi Trần" },
                    { 12, "Phú Thọ", "DucDuy22@gmail.com", "0923966179", "Trí Hùng Lý" },
                    { 13, "Thanh Hoá", "TuyetLoan.Pham13@yahoo.com", "0948780349", "Ðình Phúc Lâm" },
                    { 14, "Nam Định", "DinhPhu57@yahoo.com", "0913081556", "Xuân Lộc Lê" },
                    { 15, "Nam Định", "MinhCanh55@gmail.com", "0954467253", "Mai Vy Trịnh" },
                    { 16, "Cần Thơ", "HongPhat.Nguyen0@hotmail.com", "0945520444", "Hoàng Thái Đặng" },
                    { 17, "Ninh Thuận", "HuongChi55@gmail.com", "0957763469", "Diệu Vân Bùi" },
                    { 18, "Bình Thuận", "CamLinh_Ho54@gmail.com", "0993143912", "Mỹ Huệ Đoàn" },
                    { 19, "Bắc Ninh", "HuuChau.Tang88@yahoo.com", "0942657313", "Thy Oanh Đặng" },
                    { 20, "Khánh Hoà", "ThucAnh_Mai6@gmail.com", "0977396705", "Thái Minh Phùng" },
                    { 21, "Bà Rịa-Vũng Tàu", "QuangDat82@gmail.com", "0940626756", "Vạn Lý Đinh" },
                    { 22, "Nam Định", "LienChi.Do@gmail.com", "0903599236", "Gia Cảnh Hà" },
                    { 23, "Đắk Nông", "VietThang_Dang@gmail.com", "0998824028", "Tất Bình Lâm" },
                    { 24, "Quảng Bình", "QuangDai.Phung@yahoo.com", "0925133849", "Xuân Vũ Ngô" },
                    { 25, "Quảng Ngãi", "ThanhTu_Ha12@yahoo.com", "0921006566", "Nhật Mai Trần" },
                    { 26, "Hà Nam", "ManhCuong.Vuong84@hotmail.com", "0998199619", "Quốc Bảo Đoàn" },
                    { 27, "Bình Định", "AnhDung_Nguyen38@gmail.com", "0963283049", "Bích Hảo Lý" },
                    { 28, "Hưng Yên", "TuyetHuong.Truong62@hotmail.com", "0954321130", "An Tâm Phạm" },
                    { 29, "Phú Yên", "DucThang_Ha35@hotmail.com", "0913920672", "Nhật Dạ Hoàng" },
                    { 30, "Hưng Yên", "ThuyTram.Pham52@gmail.com", "0961408341", "Mộng Tuyền Phạm" },
                    { 31, "Đồng Tháp", "ChanhViet19@gmail.com", "0909825259", "Ngọc Linh Lê" },
                    { 32, "Bình Dương", "KhanhQuynh14@yahoo.com", "0990557241", "Bằng Sơn Nguyễn" },
                    { 33, "Sơn La", "TamNguyen.Dang@yahoo.com", "0953015558", "Xuân Hân Hồ" },
                    { 34, "Vĩnh Phúc", "BanMai_Hoang@gmail.com", "0928753897", "Yến Oanh Đào" },
                    { 35, "Quảng Trị", "TriMinh.Ho@hotmail.com", "0929224897", "Chí Bảo Tăng" },
                    { 36, "Hải Dương", "ChanHung42@yahoo.com", "0960018742", "Thanh Quang Phùng" },
                    { 37, "Kon Tum", "HaBang.Ly@gmail.com", "0901562082", "Mộng Vy Ngô" },
                    { 38, "Cà Mau", "KimThuy40@gmail.com", "0901954021", "Ðông Tuyền Vũ" },
                    { 39, "TP. Hồ Chí Minh", "HoanChau_Ngo81@hotmail.com", "0910449759", "Bích Vân Hoàng" },
                    { 40, "Thái Bình", "HaiBang5@yahoo.com", "0925111888", "Chiêu Phong Phạm" },
                    { 41, "Bến Tre", "TuyetLoan.Vu@gmail.com", "0921156196", "Thùy Uyên Mai" },
                    { 42, "Hòa Bình", "DinhNhan_Trinh44@gmail.com", "0931926375", "Thục Quyên Phạm" },
                    { 43, "Bắc Giang", "DiemHang46@hotmail.com", "0913267136", "Nhật Hùng Trịnh" },
                    { 44, "Hưng Yên", "TungQuan.Ngo@gmail.com", "0950050018", "Khánh Hoàn Tô" },
                    { 45, "Đắk Nông", "LanHuong51@yahoo.com", "0922452182", "Tấn Tài Lâm" },
                    { 46, "Lào Cai", "ThuyNgoc_Phan23@gmail.com", "0925658840", "Phương Hiền Phùng" },
                    { 47, "Lâm Đồng", "ThanhNga.Truong42@gmail.com", "0972573856", "Tuấn Chương Vũ" },
                    { 48, "Thanh Hoá", "LanKhue_Dao2@hotmail.com", "0914570482", "Ðức Ân Lê" },
                    { 49, "Quảng Ngãi", "QuangMinh.Vu35@hotmail.com", "0909766397", "Ðắc Thái Trần" },
                    { 50, "Yên Bái", "SongHuong75@yahoo.com", "0978346887", "Hoàng Hiệp Phùng" },
                    { 51, "Phú Thọ", "KimAnh_Phan@hotmail.com", "0904991343", "Gia Bình Đoàn" },
                    { 52, "Hà Tĩnh", "AnhQuoc80@gmail.com", "0925481786", "Thanh Đan Đinh" },
                    { 53, "Bến Tre", "NhaThanh73@gmail.com", "0925358826", "Thông Tuệ Đỗ" },
                    { 54, "Đà Nẵng", "ThaiHa72@hotmail.com", "0971769019", "Mỹ Diễm Phan" },
                    { 55, "Hà Tĩnh", "ThanhTrung58@gmail.com", "0982694367", "Việt Dũng Lê" },
                    { 56, "Sơn La", "DuyThanh_Nguyen@hotmail.com", "0951274344", "Lan Anh Lý" },
                    { 57, "Hậu Giang", "PhuongLan_Ly53@hotmail.com", "0927923510", "Hồng Lâm Phùng" },
                    { 58, "Bà Rịa-Vũng Tàu", "ChiMai.To@hotmail.com", "0986759629", "Hữu Minh Lý" },
                    { 59, "Quảng Ngãi", "NgocAn.Truong24@yahoo.com", "0980137433", "Phượng Vũ Hoàng" },
                    { 60, "Thanh Hoá", "AnhHoa.Duong80@gmail.com", "0958771803", "Chi Mai Hoàng" },
                    { 61, "Hà Giang", "ChanHung.Dinh56@hotmail.com", "0983283893", "Nhật Phương Đỗ" },
                    { 62, "Nam Định", "TuongMinh_Ly@gmail.com", "0921257787", "Tố Uyên Vương" },
                    { 63, "Lâm Đồng", "DiemQuynh_Tran12@yahoo.com", "0936841254", "Hiếu Liêm Bùi" },
                    { 64, "Bình Định", "ThanhHao10@hotmail.com", "0952614923", "Mộng Vy Dương" },
                    { 65, "Hòa Bình", "YenTrang12@gmail.com", "0956037705", "Chiêu Dương Dương" },
                    { 66, "Tiền Giang", "YenHong_Do@gmail.com", "0946512627", "Nhật Dạ Phạm" },
                    { 67, "Ninh Thuận", "ChinhThuan_Ho@hotmail.com", "0941862715", "Khắc Duy Tăng" },
                    { 68, "Bình Dương", "ThanhNgan.Phung@hotmail.com", "0929223979", "Tuấn Khoan Lê" },
                    { 69, "Vĩnh Phúc", "DucThanh48@yahoo.com", "0925007054", "Thất Cương Vũ" },
                    { 70, "Yên Bái", "AnhVu_Phan54@yahoo.com", "0935625105", "Nhật Hoàng Ngô" },
                    { 71, "Hải Dương", "YenDan53@yahoo.com", "0981698730", "Ðình Chiểu Vũ" },
                    { 72, "An Giang", "ThuyHang47@yahoo.com", "0929612381", "Lệ Băng Trịnh" },
                    { 73, "Bạc Liêu", "XuanCung19@hotmail.com", "0976542517", "Ngọc Tiển Trịnh" },
                    { 74, "Cần Thơ", "QuangThien.Ly@hotmail.com", "0910517949", "Thanh Mai Vũ" },
                    { 75, "Kon Tum", "ThucKhue.Ha30@hotmail.com", "0956718165", "Vương Triều Đinh" },
                    { 76, "Phú Thọ", "QuynhNgan99@hotmail.com", "0977707255", "Duy Hải Nguyễn" },
                    { 77, "Hà Nam", "NamLoc_Pham53@yahoo.com", "0988143606", "Thiện Giang Bùi" },
                    { 78, "Đắk Lắk", "BichHanh_Lam@gmail.com", "0930695318", "Bảo Hà Tô" },
                    { 79, "Kon Tum", "TanTruong.Truong@yahoo.com", "0943405671", "Thiệu Bảo Nguyễn" },
                    { 80, "Hải Phòng", "NhatQuan.Duong@gmail.com", "0914634570", "Thượng Năng Bùi" },
                    { 81, "Gia Lai", "HanhChi.Mai@yahoo.com", "0925937868", "Nguyên Khang Vương" },
                    { 82, "Lạng Sơn", "HuongThu_Mai@gmail.com", "0903313579", "Thanh Sơn Bùi" },
                    { 83, "Hà Nội", "CongHoan.Nguyen@gmail.com", "0970497206", "Mỹ Huệ Vũ" },
                    { 84, "Hòa Bình", "GiaHan_Pham@yahoo.com", "0956119211", "Trọng Tấn Đinh" },
                    { 85, "Trà Vinh", "DuyThang.Lam43@hotmail.com", "0971730075", "Ðinh Hương Hà" },
                    { 86, "Hải Dương", "ChiBao6@hotmail.com", "0928045138", "Long Quân Lê" },
                    { 87, "Tiền Giang", "AnhMai.Vuong@hotmail.com", "0965541381", "Trúc Ðào Trần" },
                    { 88, "Gia Lai", "XuanSon_Lam@hotmail.com", "0997362497", "Thụy Linh Đào" },
                    { 89, "Đồng Nai", "BichNhu_Tran@yahoo.com", "0964024354", "Xuân Quân Vũ" },
                    { 90, "Thừa Thiên-Huế", "DoanTrang_Tran12@gmail.com", "0926464163", "Hoàng Hải Đặng" },
                    { 91, "Bắc Kạn", "MinhNhan_Phan@yahoo.com", "0980425425", "Thúy Hương Vương" },
                    { 92, "Thái Bình", "DuongAnh.Vu62@hotmail.com", "0903351709", "Bảo Châu Trương" },
                    { 93, "Quảng Trị", "DinhThien13@yahoo.com", "0925903690", "Kim Khánh Hồ" },
                    { 94, "Đà Nẵng", "BichTram_Trinh@hotmail.com", "0937332451", "Mỹ Nhi Hồ" },
                    { 95, "Hà Giang", "HuuPhuoc.Doan@yahoo.com", "0985800936", "Phước Thiện Đặng" },
                    { 96, "Đắk Lắk", "BaoTram96@yahoo.com", "0973591367", "Tuyết Loan Trần" },
                    { 97, "Trà Vinh", "ThanhHao85@yahoo.com", "0986771785", "Nhã Ý Trịnh" },
                    { 98, "Bà Rịa-Vũng Tàu", "HongDiep.Tang66@gmail.com", "0989766262", "Ái Linh Vũ" },
                    { 99, "An Giang", "TanPhat80@yahoo.com", "0913540694", "Phương Diễm Phan" },
                    { 100, "Hà Giang", "MongHoa_Bui@yahoo.com", "0974725513", "Gia Nghị Trịnh" }
                });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "RoleID",
                keyValue: 1,
                columns: new[] { "DateCreated", "RoleName" },
                values: new object[] { new DateTime(2023, 12, 26, 20, 0, 51, 493, DateTimeKind.Local).AddTicks(8629), "Nhân viên bán hàng" });

            migrationBuilder.InsertData(
                table: "ImportOrders",
                columns: new[] { "OrderID", "EmployeeID", "OrderDate", "ProviderID", "TotalPrice" },
                values: new object[,]
                {
                    { 1, 10, new DateTime(2023, 11, 10, 21, 50, 53, 513, DateTimeKind.Unspecified).AddTicks(8825), 4, 4934736.056451754800000m },
                    { 2, 26, new DateTime(2023, 11, 16, 23, 35, 46, 694, DateTimeKind.Unspecified).AddTicks(8782), 9, 3357485.046070573440000m },
                    { 3, 86, new DateTime(2023, 11, 1, 0, 0, 5, 392, DateTimeKind.Unspecified).AddTicks(6676), 64, 3718539.785605233440000m },
                    { 4, 45, new DateTime(2023, 11, 2, 5, 33, 57, 83, DateTimeKind.Unspecified).AddTicks(5393), 91, 6823957.446691957760000m },
                    { 5, 46, new DateTime(2023, 11, 6, 15, 34, 34, 846, DateTimeKind.Unspecified).AddTicks(1599), 26, 4070549.02846558560000m },
                    { 6, 70, new DateTime(2023, 11, 27, 20, 57, 9, 518, DateTimeKind.Unspecified).AddTicks(29), 94, 5923293.86829975080000m },
                    { 7, 65, new DateTime(2023, 11, 19, 12, 53, 41, 281, DateTimeKind.Unspecified).AddTicks(4534), 47, 1787308.40333375232000000m },
                    { 8, 100, new DateTime(2023, 11, 28, 12, 25, 11, 764, DateTimeKind.Unspecified).AddTicks(8720), 20, 4155667.83572741400000m },
                    { 9, 32, new DateTime(2023, 11, 5, 23, 1, 35, 225, DateTimeKind.Unspecified).AddTicks(3516), 59, 9121053.703051344600000m },
                    { 10, 29, new DateTime(2023, 11, 5, 23, 13, 2, 234, DateTimeKind.Unspecified).AddTicks(371), 82, 3302134.328809547280000m },
                    { 11, 52, new DateTime(2023, 11, 16, 8, 17, 15, 376, DateTimeKind.Unspecified).AddTicks(1471), 27, 3550738.983312384200000m },
                    { 12, 50, new DateTime(2023, 11, 17, 7, 37, 33, 536, DateTimeKind.Unspecified).AddTicks(2329), 73, 7741104.458472952600000m },
                    { 13, 46, new DateTime(2023, 11, 3, 19, 38, 49, 144, DateTimeKind.Unspecified).AddTicks(6208), 64, 7771479.032155300800000m },
                    { 14, 66, new DateTime(2023, 11, 17, 11, 25, 45, 213, DateTimeKind.Unspecified).AddTicks(1717), 13, 3349972.788879435880000m },
                    { 15, 68, new DateTime(2023, 11, 5, 23, 24, 24, 917, DateTimeKind.Unspecified).AddTicks(2434), 46, 6062316.316147497920000m },
                    { 16, 78, new DateTime(2023, 11, 29, 15, 23, 58, 209, DateTimeKind.Unspecified).AddTicks(8976), 40, 9424806.767044501200000m },
                    { 17, 8, new DateTime(2023, 11, 21, 17, 51, 31, 606, DateTimeKind.Unspecified).AddTicks(6386), 55, 4194304.427155884400000m },
                    { 18, 22, new DateTime(2023, 11, 23, 3, 53, 6, 847, DateTimeKind.Unspecified).AddTicks(4063), 51, 8584811.215345193400000m },
                    { 19, 98, new DateTime(2023, 11, 29, 20, 35, 28, 561, DateTimeKind.Unspecified).AddTicks(1985), 87, 2696512.72659540200000m },
                    { 20, 25, new DateTime(2023, 11, 2, 5, 44, 26, 301, DateTimeKind.Unspecified).AddTicks(33), 50, 7179129.040191195520000m },
                    { 21, 49, new DateTime(2023, 11, 22, 15, 1, 55, 233, DateTimeKind.Unspecified).AddTicks(3774), 66, 4396561.839858084240000m },
                    { 22, 7, new DateTime(2023, 11, 28, 16, 24, 41, 723, DateTimeKind.Unspecified).AddTicks(4934), 50, 8266647.508498410040000m },
                    { 23, 90, new DateTime(2023, 11, 7, 23, 29, 13, 576, DateTimeKind.Unspecified).AddTicks(2096), 95, 8278217.758166131440000m },
                    { 24, 74, new DateTime(2023, 11, 15, 19, 25, 6, 949, DateTimeKind.Unspecified).AddTicks(7176), 22, 8391832.550678265280000m },
                    { 25, 95, new DateTime(2023, 11, 22, 23, 54, 50, 942, DateTimeKind.Unspecified).AddTicks(2391), 28, 7285034.646362160160000m },
                    { 26, 76, new DateTime(2023, 11, 23, 1, 8, 15, 780, DateTimeKind.Unspecified).AddTicks(3168), 54, 2148295.4964026211040000m },
                    { 27, 29, new DateTime(2023, 11, 3, 13, 8, 9, 22, DateTimeKind.Unspecified).AddTicks(653), 42, 3783411.876366029880000m },
                    { 28, 25, new DateTime(2023, 11, 15, 9, 43, 36, 320, DateTimeKind.Unspecified).AddTicks(2705), 13, 6152352.217546566200000m },
                    { 29, 35, new DateTime(2023, 11, 11, 21, 29, 58, 800, DateTimeKind.Unspecified).AddTicks(1970), 24, 3009529.838207623760000m },
                    { 30, 47, new DateTime(2023, 11, 17, 9, 55, 26, 142, DateTimeKind.Unspecified).AddTicks(1182), 19, 4070874.651016360320000m },
                    { 31, 98, new DateTime(2023, 11, 27, 3, 19, 57, 104, DateTimeKind.Unspecified).AddTicks(9160), 60, 4154390.538319784000000m },
                    { 32, 46, new DateTime(2023, 11, 12, 7, 39, 16, 974, DateTimeKind.Unspecified).AddTicks(5334), 98, 6389656.79922836400000m },
                    { 33, 58, new DateTime(2023, 11, 16, 23, 41, 4, 923, DateTimeKind.Unspecified).AddTicks(5952), 41, 5894157.693268536640000m },
                    { 34, 59, new DateTime(2023, 11, 19, 17, 49, 10, 422, DateTimeKind.Unspecified).AddTicks(8740), 7, 6106939.346428544480000m },
                    { 35, 18, new DateTime(2023, 11, 23, 4, 15, 59, 379, DateTimeKind.Unspecified).AddTicks(5833), 97, 5338236.821080853360000m },
                    { 36, 92, new DateTime(2023, 11, 9, 2, 45, 15, 369, DateTimeKind.Unspecified).AddTicks(5950), 100, 4447570.912187668640000m },
                    { 37, 73, new DateTime(2023, 11, 23, 19, 56, 46, 608, DateTimeKind.Unspecified).AddTicks(6886), 54, 4384459.558899433200000m },
                    { 38, 81, new DateTime(2023, 11, 4, 14, 49, 33, 568, DateTimeKind.Unspecified).AddTicks(1894), 18, 6406787.041391174400000m },
                    { 39, 85, new DateTime(2023, 11, 1, 14, 39, 42, 133, DateTimeKind.Unspecified).AddTicks(4649), 14, 6450730.710900212880000m },
                    { 40, 92, new DateTime(2023, 11, 3, 10, 10, 47, 449, DateTimeKind.Unspecified).AddTicks(7031), 89, 6125305.379414528880000m },
                    { 41, 47, new DateTime(2023, 11, 17, 18, 50, 46, 509, DateTimeKind.Unspecified).AddTicks(6679), 44, 4628321.948712259040000m },
                    { 42, 54, new DateTime(2023, 11, 10, 10, 32, 44, 183, DateTimeKind.Unspecified).AddTicks(2535), 9, 3155322.899694713440000m },
                    { 43, 41, new DateTime(2023, 11, 25, 14, 43, 18, 666, DateTimeKind.Unspecified).AddTicks(4724), 92, 7643466.222434558680000m },
                    { 44, 95, new DateTime(2023, 11, 17, 16, 48, 48, 185, DateTimeKind.Unspecified).AddTicks(1757), 42, 2017375.752324979640000m },
                    { 45, 1, new DateTime(2023, 11, 28, 23, 36, 24, 505, DateTimeKind.Unspecified).AddTicks(9193), 44, 4669559.877796391960000m },
                    { 46, 93, new DateTime(2023, 11, 3, 6, 20, 45, 870, DateTimeKind.Unspecified).AddTicks(7902), 83, 4100904.696255615000000m },
                    { 47, 49, new DateTime(2023, 11, 6, 20, 4, 57, 477, DateTimeKind.Unspecified).AddTicks(2749), 100, 4694277.852193927360000m },
                    { 48, 65, new DateTime(2023, 11, 24, 10, 19, 24, 62, DateTimeKind.Unspecified).AddTicks(744), 31, 3929216.561614693440000m },
                    { 49, 11, new DateTime(2023, 11, 26, 11, 24, 51, 427, DateTimeKind.Unspecified).AddTicks(5273), 63, 3384664.367001157680000m },
                    { 50, 74, new DateTime(2023, 11, 4, 9, 28, 3, 861, DateTimeKind.Unspecified).AddTicks(528), 83, 4379506.125410453840000m },
                    { 51, 75, new DateTime(2023, 11, 11, 7, 23, 34, 508, DateTimeKind.Unspecified).AddTicks(4120), 9, 4523991.183424627200000m },
                    { 52, 7, new DateTime(2023, 11, 27, 1, 18, 1, 461, DateTimeKind.Unspecified).AddTicks(413), 50, 3236604.14635679160000m },
                    { 53, 34, new DateTime(2023, 11, 11, 5, 0, 17, 669, DateTimeKind.Unspecified).AddTicks(69), 60, 2028554.9354311802880000m },
                    { 54, 83, new DateTime(2023, 11, 14, 11, 27, 3, 109, DateTimeKind.Unspecified).AddTicks(8148), 53, 6269913.879915694800000m },
                    { 55, 5, new DateTime(2023, 11, 14, 10, 16, 6, 480, DateTimeKind.Unspecified).AddTicks(9413), 41, 2124665.450106750320000m },
                    { 56, 33, new DateTime(2023, 11, 7, 19, 37, 2, 543, DateTimeKind.Unspecified).AddTicks(5387), 33, 1270209.4495888412880000m },
                    { 57, 67, new DateTime(2023, 11, 15, 12, 29, 40, 860, DateTimeKind.Unspecified).AddTicks(8180), 31, 3940980.167731267320000m },
                    { 58, 70, new DateTime(2023, 11, 6, 4, 43, 2, 986, DateTimeKind.Unspecified).AddTicks(4944), 33, 5794522.519926724320000m },
                    { 59, 62, new DateTime(2023, 11, 25, 1, 30, 45, 517, DateTimeKind.Unspecified).AddTicks(1613), 51, 2547783.852163528200000m },
                    { 60, 86, new DateTime(2023, 11, 16, 9, 57, 51, 582, DateTimeKind.Unspecified).AddTicks(5781), 22, 1877169.116318343080000m },
                    { 61, 55, new DateTime(2023, 11, 9, 10, 43, 15, 29, DateTimeKind.Unspecified).AddTicks(5255), 12, 7358715.294247576800000m },
                    { 62, 54, new DateTime(2023, 11, 16, 9, 56, 6, 234, DateTimeKind.Unspecified).AddTicks(6790), 86, 8904260.405977028160000m },
                    { 63, 18, new DateTime(2023, 11, 14, 8, 13, 27, 422, DateTimeKind.Unspecified).AddTicks(1170), 19, 8153424.443152311360000m },
                    { 64, 20, new DateTime(2023, 11, 20, 16, 40, 31, 488, DateTimeKind.Unspecified).AddTicks(5696), 47, 3091550.85331585120000m },
                    { 65, 30, new DateTime(2023, 11, 7, 3, 26, 57, 483, DateTimeKind.Unspecified).AddTicks(8491), 87, 6570448.818041296800000m },
                    { 66, 31, new DateTime(2023, 11, 14, 18, 0, 11, 392, DateTimeKind.Unspecified).AddTicks(5494), 59, 3706245.930949261920000m },
                    { 67, 10, new DateTime(2023, 11, 17, 4, 57, 48, 837, DateTimeKind.Unspecified).AddTicks(8162), 38, 2724812.075982939240000m },
                    { 68, 53, new DateTime(2023, 11, 27, 8, 19, 1, 685, DateTimeKind.Unspecified).AddTicks(1851), 43, 1410399.2092533480000000m },
                    { 69, 97, new DateTime(2023, 11, 2, 8, 1, 40, 652, DateTimeKind.Unspecified).AddTicks(9486), 88, 2001228.694085049120000m },
                    { 70, 52, new DateTime(2023, 11, 22, 13, 36, 50, 594, DateTimeKind.Unspecified).AddTicks(2606), 100, 5817089.282891573280000m },
                    { 71, 59, new DateTime(2023, 11, 13, 21, 19, 39, 249, DateTimeKind.Unspecified).AddTicks(2062), 28, 2251947.105091641600000m },
                    { 72, 68, new DateTime(2023, 11, 14, 23, 36, 54, 11, DateTimeKind.Unspecified).AddTicks(2763), 91, 2718096.412822714560000m },
                    { 73, 2, new DateTime(2023, 11, 5, 8, 54, 26, 754, DateTimeKind.Unspecified).AddTicks(7402), 63, 2976922.296924916160000m },
                    { 74, 17, new DateTime(2023, 11, 3, 23, 27, 0, 977, DateTimeKind.Unspecified).AddTicks(9261), 67, 5979540.650149919160000m },
                    { 75, 97, new DateTime(2023, 11, 13, 12, 29, 56, 254, DateTimeKind.Unspecified).AddTicks(1161), 96, 4880066.582153328280000m },
                    { 76, 13, new DateTime(2023, 11, 22, 11, 21, 44, 759, DateTimeKind.Unspecified).AddTicks(8028), 5, 6065043.706950511360000m },
                    { 77, 74, new DateTime(2023, 11, 24, 18, 56, 18, 807, DateTimeKind.Unspecified).AddTicks(2067), 97, 3925962.229626937520000m },
                    { 78, 90, new DateTime(2023, 11, 2, 23, 6, 45, 425, DateTimeKind.Unspecified).AddTicks(6491), 98, 9162582.856902261360000m },
                    { 79, 69, new DateTime(2023, 11, 24, 10, 53, 46, 667, DateTimeKind.Unspecified).AddTicks(8584), 19, 4825280.384910939600000m },
                    { 80, 74, new DateTime(2023, 11, 8, 3, 4, 25, 426, DateTimeKind.Unspecified).AddTicks(1508), 84, 4585206.29580149080000m },
                    { 81, 93, new DateTime(2023, 11, 19, 1, 24, 18, 411, DateTimeKind.Unspecified).AddTicks(5909), 8, 5015819.433314189840000m },
                    { 82, 31, new DateTime(2023, 11, 15, 19, 12, 42, 335, DateTimeKind.Unspecified).AddTicks(9203), 15, 6820002.245390850360000m },
                    { 83, 93, new DateTime(2023, 11, 20, 18, 23, 4, 528, DateTimeKind.Unspecified).AddTicks(1968), 47, 6856461.14171691960000m },
                    { 84, 94, new DateTime(2023, 11, 6, 11, 14, 59, 679, DateTimeKind.Unspecified).AddTicks(8866), 73, 5402755.10367799920000m },
                    { 85, 73, new DateTime(2023, 11, 10, 6, 29, 51, 725, DateTimeKind.Unspecified).AddTicks(4102), 5, 6035734.023279258480000m },
                    { 86, 72, new DateTime(2023, 11, 10, 13, 59, 42, 169, DateTimeKind.Unspecified).AddTicks(1513), 35, 2707923.308655016080000m },
                    { 87, 89, new DateTime(2023, 11, 14, 11, 7, 42, 491, DateTimeKind.Unspecified).AddTicks(4113), 82, 8112436.445546136160000m },
                    { 88, 64, new DateTime(2023, 11, 21, 4, 2, 37, 64, DateTimeKind.Unspecified).AddTicks(7981), 62, 3541074.192974606400000m },
                    { 89, 17, new DateTime(2023, 11, 24, 17, 46, 9, 679, DateTimeKind.Unspecified).AddTicks(9907), 18, 7584686.977455612640000m },
                    { 90, 9, new DateTime(2023, 11, 24, 1, 45, 55, 211, DateTimeKind.Unspecified).AddTicks(7097), 40, 5310897.775494601120000m },
                    { 91, 49, new DateTime(2023, 11, 16, 11, 5, 35, 869, DateTimeKind.Unspecified).AddTicks(9884), 13, 2212318.881851968320000m },
                    { 92, 55, new DateTime(2023, 11, 10, 15, 17, 41, 872, DateTimeKind.Unspecified).AddTicks(8553), 67, 1861945.0554885625000000m },
                    { 93, 33, new DateTime(2023, 11, 27, 22, 57, 26, 884, DateTimeKind.Unspecified).AddTicks(5150), 32, 4962653.390141541600000m },
                    { 94, 32, new DateTime(2023, 11, 3, 9, 28, 52, 82, DateTimeKind.Unspecified).AddTicks(8841), 66, 5253611.760367042800000m },
                    { 95, 88, new DateTime(2023, 11, 28, 21, 25, 43, 954, DateTimeKind.Unspecified).AddTicks(433), 50, 1598343.930535732280000m },
                    { 96, 61, new DateTime(2023, 11, 27, 10, 42, 56, 767, DateTimeKind.Unspecified).AddTicks(6618), 61, 3344691.63800978880000m },
                    { 97, 29, new DateTime(2023, 11, 29, 23, 13, 9, 204, DateTimeKind.Unspecified).AddTicks(7388), 28, 1639171.819159675680000m },
                    { 98, 65, new DateTime(2023, 11, 11, 16, 32, 42, 171, DateTimeKind.Unspecified).AddTicks(357), 70, 5174752.322696123680000m },
                    { 99, 68, new DateTime(2023, 11, 24, 13, 52, 28, 259, DateTimeKind.Unspecified).AddTicks(4230), 82, 6051076.077667827760000m },
                    { 100, 41, new DateTime(2023, 11, 2, 1, 7, 55, 256, DateTimeKind.Unspecified).AddTicks(7899), 62, 4394825.717057213680000m }
                });

            migrationBuilder.InsertData(
                table: "SalesOrders",
                columns: new[] { "OrderID", "ChangePrice", "CustomerID", "EmployeeID", "OrderDate", "PurchasePrice", "TotalPrice" },
                values: new object[,]
                {
                    { 1, 0m, 6, 60, new DateTime(2023, 12, 5, 22, 44, 45, 783, DateTimeKind.Unspecified).AddTicks(4269), 8345815.147522473100000m, 8345815.147522473100000m },
                    { 2, 0m, 25, 23, new DateTime(2023, 12, 2, 0, 16, 3, 587, DateTimeKind.Unspecified).AddTicks(6119), 8129398.102284076800000m, 8129398.102284076800000m },
                    { 3, 0m, 34, 21, new DateTime(2023, 12, 29, 22, 56, 31, 14, DateTimeKind.Unspecified).AddTicks(6642), 16310440.733902789300000m, 16310440.733902789300000m },
                    { 4, 0m, 33, 86, new DateTime(2023, 12, 4, 18, 37, 56, 495, DateTimeKind.Unspecified).AddTicks(4388), 9923517.832971226100000m, 9923517.832971226100000m },
                    { 5, 0m, 62, 45, new DateTime(2023, 12, 1, 8, 17, 51, 174, DateTimeKind.Unspecified).AddTicks(2347), 13606098.185559218400000m, 13606098.185559218400000m },
                    { 6, 0m, 26, 36, new DateTime(2023, 12, 18, 21, 10, 42, 289, DateTimeKind.Unspecified).AddTicks(7491), 14709574.233506706400000m, 14709574.233506706400000m },
                    { 7, 0m, 7, 84, new DateTime(2023, 12, 22, 17, 52, 45, 712, DateTimeKind.Unspecified).AddTicks(8867), 8560653.167898662400000m, 8560653.167898662400000m },
                    { 8, 0m, 99, 25, new DateTime(2023, 12, 8, 3, 8, 28, 432, DateTimeKind.Unspecified).AddTicks(351), 11217397.693786315200000m, 11217397.693786315200000m },
                    { 9, 0m, 35, 14, new DateTime(2023, 12, 29, 23, 3, 10, 334, DateTimeKind.Unspecified).AddTicks(2054), 12770915.046924668400000m, 12770915.046924668400000m },
                    { 10, 0m, 12, 87, new DateTime(2023, 12, 28, 11, 58, 27, 352, DateTimeKind.Unspecified).AddTicks(3094), 5690761.834546920000000m, 5690761.834546920000000m },
                    { 11, 0m, 61, 3, new DateTime(2023, 12, 18, 10, 2, 31, 995, DateTimeKind.Unspecified).AddTicks(9783), 9922237.882739313600000m, 9922237.882739313600000m },
                    { 12, 0m, 12, 34, new DateTime(2023, 12, 17, 9, 47, 9, 33, DateTimeKind.Unspecified).AddTicks(3005), 11401700.441595048800000m, 11401700.441595048800000m },
                    { 13, 0m, 99, 69, new DateTime(2023, 12, 14, 11, 3, 25, 552, DateTimeKind.Unspecified).AddTicks(2145), 13020908.275490658400000m, 13020908.275490658400000m },
                    { 14, 0m, 23, 56, new DateTime(2023, 12, 20, 2, 55, 17, 655, DateTimeKind.Unspecified).AddTicks(8268), 8908262.8331497020600000m, 8908262.8331497020600000m },
                    { 15, 0m, 66, 1, new DateTime(2023, 12, 3, 1, 0, 24, 861, DateTimeKind.Unspecified).AddTicks(2039), 7666250.087945158800000m, 7666250.087945158800000m },
                    { 16, 0m, 43, 92, new DateTime(2023, 12, 20, 19, 16, 15, 815, DateTimeKind.Unspecified).AddTicks(9865), 13870789.539879455600000m, 13870789.539879455600000m },
                    { 17, 0m, 53, 71, new DateTime(2023, 12, 18, 11, 26, 8, 301, DateTimeKind.Unspecified).AddTicks(4387), 6646373.8737541305300000m, 6646373.8737541305300000m },
                    { 18, 0m, 56, 57, new DateTime(2023, 12, 4, 0, 55, 20, 125, DateTimeKind.Unspecified).AddTicks(5109), 8307083.546947932600000m, 8307083.546947932600000m },
                    { 19, 0m, 41, 7, new DateTime(2023, 12, 3, 1, 29, 18, 426, DateTimeKind.Unspecified).AddTicks(5949), 15071269.846096183600000m, 15071269.846096183600000m },
                    { 20, 0m, 91, 82, new DateTime(2023, 12, 6, 18, 58, 55, 853, DateTimeKind.Unspecified).AddTicks(5738), 16882916.067427780800000m, 16882916.067427780800000m },
                    { 21, 0m, 13, 49, new DateTime(2023, 12, 3, 6, 31, 59, 617, DateTimeKind.Unspecified).AddTicks(3534), 9603888.778079596800000m, 9603888.778079596800000m },
                    { 22, 0m, 57, 76, new DateTime(2023, 12, 10, 16, 10, 4, 573, DateTimeKind.Unspecified).AddTicks(5929), 10729730.197615174900000m, 10729730.197615174900000m },
                    { 23, 0m, 28, 16, new DateTime(2023, 12, 30, 12, 27, 22, 550, DateTimeKind.Unspecified).AddTicks(5937), 14279380.554911940000000m, 14279380.554911940000000m },
                    { 24, 0m, 21, 2, new DateTime(2023, 12, 9, 10, 55, 32, 813, DateTimeKind.Unspecified).AddTicks(2344), 10518402.22002554500000m, 10518402.22002554500000m },
                    { 25, 0m, 65, 72, new DateTime(2023, 12, 28, 3, 9, 7, 223, DateTimeKind.Unspecified).AddTicks(4284), 9747635.975730989600000m, 9747635.975730989600000m },
                    { 26, 0m, 21, 100, new DateTime(2023, 12, 10, 18, 39, 59, 820, DateTimeKind.Unspecified).AddTicks(1739), 12611886.371460742200000m, 12611886.371460742200000m },
                    { 27, 0m, 98, 33, new DateTime(2023, 12, 3, 18, 17, 28, 554, DateTimeKind.Unspecified).AddTicks(6356), 11730773.352697275200000m, 11730773.352697275200000m },
                    { 28, 0m, 27, 90, new DateTime(2023, 12, 7, 21, 17, 13, 951, DateTimeKind.Unspecified).AddTicks(1753), 16509580.291453366700000m, 16509580.291453366700000m },
                    { 29, 0m, 57, 63, new DateTime(2023, 12, 13, 11, 6, 13, 265, DateTimeKind.Unspecified).AddTicks(3086), 8648592.4614638043600000m, 8648592.4614638043600000m },
                    { 30, 0m, 44, 37, new DateTime(2023, 12, 29, 13, 7, 22, 283, DateTimeKind.Unspecified).AddTicks(1283), 9769251.686882122100000m, 9769251.686882122100000m },
                    { 31, 0m, 26, 35, new DateTime(2023, 12, 20, 5, 17, 6, 297, DateTimeKind.Unspecified).AddTicks(1875), 9269921.835057867500000m, 9269921.835057867500000m },
                    { 32, 0m, 18, 42, new DateTime(2023, 12, 8, 3, 20, 39, 553, DateTimeKind.Unspecified).AddTicks(8838), 9179023.218618823100000m, 9179023.218618823100000m },
                    { 33, 0m, 69, 20, new DateTime(2023, 12, 29, 19, 12, 53, 407, DateTimeKind.Unspecified).AddTicks(3563), 10039664.30552780100000m, 10039664.30552780100000m },
                    { 34, 0m, 36, 68, new DateTime(2023, 12, 16, 6, 31, 38, 126, DateTimeKind.Unspecified).AddTicks(9199), 8359787.289210780000000m, 8359787.289210780000000m },
                    { 35, 0m, 14, 84, new DateTime(2023, 12, 27, 0, 13, 55, 542, DateTimeKind.Unspecified).AddTicks(6669), 8319080.810864496000000m, 8319080.810864496000000m },
                    { 36, 0m, 70, 97, new DateTime(2023, 12, 22, 15, 14, 7, 125, DateTimeKind.Unspecified).AddTicks(4536), 11089546.69852869300000m, 11089546.69852869300000m },
                    { 37, 0m, 3, 67, new DateTime(2023, 12, 24, 0, 37, 14, 810, DateTimeKind.Unspecified).AddTicks(8431), 8711701.391681837800000m, 8711701.391681837800000m },
                    { 38, 0m, 95, 25, new DateTime(2023, 12, 26, 5, 42, 29, 77, DateTimeKind.Unspecified).AddTicks(7494), 12309949.686119652000000m, 12309949.686119652000000m },
                    { 39, 0m, 39, 45, new DateTime(2023, 12, 13, 11, 13, 53, 492, DateTimeKind.Unspecified).AddTicks(599), 14505364.648089722400000m, 14505364.648089722400000m },
                    { 40, 0m, 61, 34, new DateTime(2023, 12, 11, 5, 32, 41, 704, DateTimeKind.Unspecified).AddTicks(4702), 9720955.791273523200000m, 9720955.791273523200000m },
                    { 41, 0m, 10, 52, new DateTime(2023, 12, 23, 4, 57, 26, 53, DateTimeKind.Unspecified).AddTicks(5782), 12897732.954074109100000m, 12897732.954074109100000m },
                    { 42, 0m, 86, 30, new DateTime(2023, 12, 20, 21, 24, 21, 189, DateTimeKind.Unspecified).AddTicks(65), 16165103.04900726400000m, 16165103.04900726400000m },
                    { 43, 0m, 54, 12, new DateTime(2023, 12, 8, 1, 44, 54, 714, DateTimeKind.Unspecified).AddTicks(3905), 11108234.22919049800000m, 11108234.22919049800000m },
                    { 44, 0m, 78, 25, new DateTime(2023, 12, 19, 18, 25, 48, 164, DateTimeKind.Unspecified).AddTicks(8608), 15433907.197001521800000m, 15433907.197001521800000m },
                    { 45, 0m, 42, 65, new DateTime(2023, 12, 29, 16, 1, 33, 270, DateTimeKind.Unspecified).AddTicks(8634), 14505245.901585428400000m, 14505245.901585428400000m },
                    { 46, 0m, 68, 63, new DateTime(2023, 12, 16, 12, 26, 12, 447, DateTimeKind.Unspecified).AddTicks(3765), 8963440.680577006800000m, 8963440.680577006800000m },
                    { 47, 0m, 38, 43, new DateTime(2023, 12, 22, 22, 20, 14, 919, DateTimeKind.Unspecified).AddTicks(6044), 8447683.196848623000000m, 8447683.196848623000000m },
                    { 48, 0m, 98, 100, new DateTime(2023, 12, 15, 10, 15, 11, 85, DateTimeKind.Unspecified).AddTicks(596), 11609428.937227159000000m, 11609428.937227159000000m },
                    { 49, 0m, 6, 54, new DateTime(2023, 12, 25, 2, 11, 26, 191, DateTimeKind.Unspecified).AddTicks(980), 12330417.73825555400000m, 12330417.73825555400000m },
                    { 50, 0m, 65, 65, new DateTime(2023, 12, 16, 10, 15, 22, 129, DateTimeKind.Unspecified).AddTicks(5756), 7160648.75377270383700000m, 7160648.75377270383700000m },
                    { 51, 0m, 65, 63, new DateTime(2023, 12, 13, 19, 13, 0, 689, DateTimeKind.Unspecified).AddTicks(9373), 14230435.292295482400000m, 14230435.292295482400000m },
                    { 52, 0m, 61, 74, new DateTime(2023, 12, 19, 18, 35, 9, 508, DateTimeKind.Unspecified).AddTicks(7200), 15428672.632917569600000m, 15428672.632917569600000m },
                    { 53, 0m, 12, 85, new DateTime(2023, 12, 24, 5, 31, 14, 920, DateTimeKind.Unspecified).AddTicks(6576), 11031428.270971030600000m, 11031428.270971030600000m },
                    { 54, 0m, 67, 87, new DateTime(2023, 12, 2, 17, 11, 3, 181, DateTimeKind.Unspecified).AddTicks(6003), 9360881.12375265000000m, 9360881.12375265000000m },
                    { 55, 0m, 39, 19, new DateTime(2023, 12, 5, 9, 19, 45, 108, DateTimeKind.Unspecified).AddTicks(2015), 12367404.289526191500000m, 12367404.289526191500000m },
                    { 56, 0m, 36, 84, new DateTime(2023, 12, 2, 9, 42, 13, 224, DateTimeKind.Unspecified).AddTicks(7843), 7989972.091360320600000m, 7989972.091360320600000m },
                    { 57, 0m, 34, 81, new DateTime(2023, 12, 9, 16, 20, 23, 739, DateTimeKind.Unspecified).AddTicks(8897), 8654297.191985457200000m, 8654297.191985457200000m },
                    { 58, 0m, 65, 33, new DateTime(2023, 12, 6, 20, 45, 4, 374, DateTimeKind.Unspecified).AddTicks(8387), 8239038.3607383840000000m, 8239038.3607383840000000m },
                    { 59, 0m, 33, 32, new DateTime(2023, 12, 24, 22, 40, 12, 301, DateTimeKind.Unspecified).AddTicks(7485), 10193368.56705800000000m, 10193368.56705800000000m },
                    { 60, 0m, 31, 77, new DateTime(2023, 12, 20, 5, 15, 56, 492, DateTimeKind.Unspecified).AddTicks(8439), 9224797.072667118800000m, 9224797.072667118800000m },
                    { 61, 0m, 66, 20, new DateTime(2023, 12, 22, 13, 28, 14, 150, DateTimeKind.Unspecified).AddTicks(1467), 12034175.025473831100000m, 12034175.025473831100000m },
                    { 62, 0m, 98, 7, new DateTime(2023, 12, 21, 1, 44, 25, 363, DateTimeKind.Unspecified).AddTicks(5317), 12722317.894003085100000m, 12722317.894003085100000m },
                    { 63, 0m, 14, 21, new DateTime(2023, 12, 19, 21, 21, 20, 668, DateTimeKind.Unspecified).AddTicks(7136), 13392496.108999909500000m, 13392496.108999909500000m },
                    { 64, 0m, 39, 48, new DateTime(2023, 12, 25, 12, 47, 48, 792, DateTimeKind.Unspecified).AddTicks(1730), 11970656.610078583200000m, 11970656.610078583200000m },
                    { 65, 0m, 77, 24, new DateTime(2023, 12, 4, 9, 16, 27, 765, DateTimeKind.Unspecified).AddTicks(249), 6028559.365836005000000m, 6028559.365836005000000m },
                    { 66, 0m, 81, 2, new DateTime(2023, 12, 28, 5, 31, 23, 876, DateTimeKind.Unspecified).AddTicks(9703), 9291192.557179506200000m, 9291192.557179506200000m },
                    { 67, 0m, 42, 35, new DateTime(2023, 12, 8, 17, 13, 34, 359, DateTimeKind.Unspecified).AddTicks(4306), 9707398.570101240600000m, 9707398.570101240600000m },
                    { 68, 0m, 83, 13, new DateTime(2023, 12, 3, 21, 45, 2, 298, DateTimeKind.Unspecified).AddTicks(7018), 5687718.569484391800000m, 5687718.569484391800000m },
                    { 69, 0m, 98, 98, new DateTime(2023, 12, 30, 8, 27, 48, 584, DateTimeKind.Unspecified).AddTicks(7119), 7034198.25738437500000m, 7034198.25738437500000m },
                    { 70, 0m, 82, 83, new DateTime(2023, 12, 7, 2, 51, 27, 877, DateTimeKind.Unspecified).AddTicks(510), 7461114.030091486500000m, 7461114.030091486500000m },
                    { 71, 0m, 68, 60, new DateTime(2023, 12, 1, 2, 32, 54, 597, DateTimeKind.Unspecified).AddTicks(3704), 11075910.353338478600000m, 11075910.353338478600000m },
                    { 72, 0m, 44, 85, new DateTime(2023, 12, 4, 15, 3, 27, 707, DateTimeKind.Unspecified).AddTicks(8408), 6829282.712726859700000m, 6829282.712726859700000m },
                    { 73, 0m, 33, 20, new DateTime(2023, 12, 6, 23, 41, 20, 807, DateTimeKind.Unspecified).AddTicks(50), 7499023.5156298833500000m, 7499023.5156298833500000m },
                    { 74, 0m, 99, 61, new DateTime(2023, 12, 19, 5, 16, 26, 915, DateTimeKind.Unspecified).AddTicks(8576), 10667051.080229023200000m, 10667051.080229023200000m },
                    { 75, 0m, 9, 62, new DateTime(2023, 12, 10, 12, 14, 32, 474, DateTimeKind.Unspecified).AddTicks(2150), 9820836.639563759600000m, 9820836.639563759600000m },
                    { 76, 0m, 35, 48, new DateTime(2023, 12, 7, 8, 50, 50, 488, DateTimeKind.Unspecified).AddTicks(6626), 9110088.062904031500000m, 9110088.062904031500000m },
                    { 77, 0m, 96, 10, new DateTime(2023, 12, 28, 6, 53, 51, 639, DateTimeKind.Unspecified).AddTicks(5234), 13113307.551803882400000m, 13113307.551803882400000m },
                    { 78, 0m, 59, 8, new DateTime(2023, 12, 2, 15, 57, 47, 437, DateTimeKind.Unspecified).AddTicks(986), 10434955.44730325400000m, 10434955.44730325400000m },
                    { 79, 0m, 60, 88, new DateTime(2023, 12, 3, 17, 57, 20, 745, DateTimeKind.Unspecified).AddTicks(8861), 10825195.7825297100000m, 10825195.7825297100000m },
                    { 80, 0m, 97, 21, new DateTime(2023, 12, 19, 5, 15, 49, 475, DateTimeKind.Unspecified).AddTicks(3751), 10308694.567020304000000m, 10308694.567020304000000m },
                    { 81, 0m, 67, 20, new DateTime(2023, 12, 15, 1, 48, 42, 556, DateTimeKind.Unspecified).AddTicks(2881), 14896503.566029769200000m, 14896503.566029769200000m },
                    { 82, 0m, 26, 100, new DateTime(2023, 12, 25, 4, 30, 12, 272, DateTimeKind.Unspecified).AddTicks(5278), 11104099.945964781000000m, 11104099.945964781000000m },
                    { 83, 0m, 60, 14, new DateTime(2023, 12, 25, 23, 19, 43, 897, DateTimeKind.Unspecified).AddTicks(3237), 7832106.963631251300000m, 7832106.963631251300000m },
                    { 84, 0m, 34, 14, new DateTime(2023, 12, 30, 22, 39, 18, 362, DateTimeKind.Unspecified).AddTicks(1316), 13942369.944976596600000m, 13942369.944976596600000m },
                    { 85, 0m, 39, 9, new DateTime(2023, 12, 26, 9, 21, 7, 662, DateTimeKind.Unspecified).AddTicks(4415), 5743789.406663198400000m, 5743789.406663198400000m },
                    { 86, 0m, 88, 23, new DateTime(2023, 12, 18, 12, 44, 49, 132, DateTimeKind.Unspecified).AddTicks(8415), 8549862.912223554600000m, 8549862.912223554600000m },
                    { 87, 0m, 19, 30, new DateTime(2023, 12, 4, 6, 43, 38, 225, DateTimeKind.Unspecified).AddTicks(5489), 10695576.810026773200000m, 10695576.810026773200000m },
                    { 88, 0m, 46, 51, new DateTime(2023, 12, 18, 20, 21, 38, 274, DateTimeKind.Unspecified).AddTicks(3768), 9716827.4117554200000m, 9716827.4117554200000m },
                    { 89, 0m, 60, 2, new DateTime(2023, 12, 28, 7, 48, 27, 78, DateTimeKind.Unspecified).AddTicks(6045), 8689174.7853643029500000m, 8689174.7853643029500000m },
                    { 90, 0m, 16, 100, new DateTime(2023, 12, 7, 3, 2, 12, 445, DateTimeKind.Unspecified).AddTicks(510), 6345761.554301045400000m, 6345761.554301045400000m },
                    { 91, 0m, 55, 35, new DateTime(2023, 12, 23, 8, 7, 10, 30, DateTimeKind.Unspecified).AddTicks(3980), 8799474.59490309800000m, 8799474.59490309800000m },
                    { 92, 0m, 99, 81, new DateTime(2023, 12, 13, 19, 51, 12, 868, DateTimeKind.Unspecified).AddTicks(9894), 11817885.372630174600000m, 11817885.372630174600000m },
                    { 93, 0m, 82, 9, new DateTime(2023, 12, 14, 2, 29, 48, 577, DateTimeKind.Unspecified).AddTicks(4156), 10952844.597305281000000m, 10952844.597305281000000m },
                    { 94, 0m, 18, 63, new DateTime(2023, 12, 22, 5, 48, 53, 604, DateTimeKind.Unspecified).AddTicks(4434), 7672362.76046655300000m, 7672362.76046655300000m },
                    { 95, 0m, 15, 100, new DateTime(2023, 12, 15, 2, 32, 5, 324, DateTimeKind.Unspecified).AddTicks(4445), 11925625.472021762100000m, 11925625.472021762100000m },
                    { 96, 0m, 56, 86, new DateTime(2023, 12, 15, 3, 20, 30, 389, DateTimeKind.Unspecified).AddTicks(1761), 15484149.23469698700000m, 15484149.23469698700000m },
                    { 97, 0m, 19, 37, new DateTime(2023, 12, 30, 10, 9, 18, 91, DateTimeKind.Unspecified).AddTicks(5407), 11182771.901263586400000m, 11182771.901263586400000m },
                    { 98, 0m, 89, 97, new DateTime(2023, 12, 27, 12, 34, 0, 971, DateTimeKind.Unspecified).AddTicks(1624), 7818445.422699738400000m, 7818445.422699738400000m },
                    { 99, 0m, 79, 28, new DateTime(2023, 12, 7, 6, 16, 5, 948, DateTimeKind.Unspecified).AddTicks(787), 12278687.132500494600000m, 12278687.132500494600000m },
                    { 100, 0m, 30, 50, new DateTime(2023, 12, 25, 13, 9, 59, 194, DateTimeKind.Unspecified).AddTicks(1273), 6796679.730710436000000m, 6796679.730710436000000m }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleID", "DateCreated", "Description", "PermissionID", "RoleName" },
                values: new object[] { 2, new DateTime(2023, 12, 26, 20, 0, 51, 493, DateTimeKind.Local).AddTicks(8646), null, 2, "Nhân viên nhập hàng" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "EmployeeID", "RoleID", "Email", "LastLogin", "Lock", "Password" },
                values: new object[,]
                {
                    { 2, 1, "KyDuyen68@hotmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 4, 1, "BuuChuong.Truong43@yahoo.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 5, 1, "HienThuc.Do@gmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 6, 1, "BaoHa77@yahoo.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 7, 1, "TrucLoan22@hotmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 8, 1, "MinhTam.Ho@hotmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 9, 1, "TanPhat_Trinh90@hotmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 10, 1, "ThuyMai_Truong@yahoo.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 11, 1, "DucPhong.Dang67@gmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 12, 1, "PhiHung_Ly80@gmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 13, 1, "ThanhAn_Dinh69@yahoo.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 15, 1, "NgocTuyet.Ngo@yahoo.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 17, 1, "NgocDan.Pham7@gmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 18, 1, "VietQuyet51@yahoo.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 19, 1, "KhanhHoan36@hotmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 22, 1, "HuongTrang_Vuong@gmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 23, 1, "DuyKhang54@gmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 25, 1, "KieuThu75@gmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 27, 1, "MyNuong_Bui82@gmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 31, 1, "TrongKhanh_Ly@hotmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 33, 1, "AnKhang_Dang14@gmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 37, 1, "SongThu.Trinh23@yahoo.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 38, 1, "PhongDo_Vuong55@yahoo.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 39, 1, "VietVo_Vu@yahoo.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 40, 1, "ThucDao.Hoang@yahoo.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 41, 1, "CaoNhan46@hotmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 42, 1, "TuyetThanh61@yahoo.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 43, 1, "ThuyGiang.Phan@yahoo.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 44, 1, "DanThanh73@gmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 46, 1, "NhuNga_Dinh@hotmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 47, 1, "BichHao.Pham2@yahoo.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 49, 1, "HoaLien30@hotmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 52, 1, "NhatHa.Pham@yahoo.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 53, 1, "VanNhi69@hotmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 56, 1, "AnhHuong.Trinh@gmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 57, 1, "PhucDien.Truong@gmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 58, 1, "NgocHoan_To@hotmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 59, 1, "KieuMy.Ha@yahoo.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 60, 1, "SonTuyen22@yahoo.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 62, 1, "AnhTho0@hotmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 64, 1, "ThucUyen64@gmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 65, 1, "AnhThy_Tang@gmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 67, 1, "KhacTuan_Nguyen@yahoo.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 68, 1, "VanTuyen77@yahoo.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 70, 1, "HuuThang88@gmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 72, 1, "MinhQuan_Trinh@hotmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 74, 1, "HongBachThao25@gmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 75, 1, "XuanUyen_To86@yahoo.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 77, 1, "NhaUyen52@hotmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 79, 1, "HoaHiep83@gmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 80, 1, "PhuThoi.Ho@yahoo.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 82, 1, "NgocDoan69@hotmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 84, 1, "QuocTien_Truong12@yahoo.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 86, 1, "DuyKhiem.Nguyen90@yahoo.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 87, 1, "NgocHoa46@yahoo.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 89, 1, "BaoLong.Vu51@yahoo.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 90, 1, "NgocOanh32@hotmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 92, 1, "NgocHoa94@gmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 93, 1, "HuuTrung.Dang@gmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 94, 1, "HaiSon_Tang90@yahoo.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 95, 1, "ThuyDao35@gmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 96, 1, "LapThanh0@hotmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 99, 1, "DuyThanh.Truong99@gmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" }
                });

            migrationBuilder.InsertData(
                table: "DetailImportOrders",
                columns: new[] { "DetailOrderID", "OrderID", "ProductID", "Quantity", "UnitPrice" },
                values: new object[,]
                {
                    { 1, 1, 1, 195, 25306.338751034640000m },
                    { 2, 2, 2, 132, 25435.492773261920000m },
                    { 3, 3, 3, 124, 29988.224077461560000m },
                    { 4, 4, 4, 184, 37086.725253760640000m },
                    { 5, 5, 5, 132, 30837.49263989080000m },
                    { 6, 6, 6, 121, 48952.84188677480000m },
                    { 7, 7, 7, 175, 10213.19087619287040000m },
                    { 8, 8, 8, 115, 36136.24204980360000m },
                    { 9, 9, 9, 195, 46774.634374622280000m },
                    { 10, 10, 10, 133, 24828.077660222160000m },
                    { 11, 11, 11, 193, 18397.611312499400000m },
                    { 12, 12, 12, 155, 49942.609409502920000m },
                    { 13, 13, 13, 195, 39853.738626437440000m },
                    { 14, 14, 14, 101, 33168.047414647880000m },
                    { 15, 15, 15, 164, 36965.343391143280000m },
                    { 16, 16, 16, 190, 49604.246142339480000m },
                    { 17, 17, 17, 185, 22671.915822464240000m },
                    { 18, 18, 18, 195, 44024.672899206120000m },
                    { 19, 19, 19, 143, 18856.73235381400000m },
                    { 20, 20, 20, 157, 45726.936561727360000m },
                    { 21, 21, 21, 186, 23637.429246548840000m },
                    { 22, 22, 22, 173, 47784.089644499480000m },
                    { 23, 23, 23, 174, 47575.964127391560000m },
                    { 24, 24, 24, 199, 42170.012817478720000m },
                    { 25, 25, 25, 166, 43885.750881699760000m },
                    { 26, 26, 26, 154, 13949.9707558611760000m },
                    { 27, 27, 27, 189, 20018.052255904920000m },
                    { 28, 28, 28, 169, 36404.450991399800000m },
                    { 29, 29, 29, 158, 19047.657203845720000m },
                    { 30, 30, 30, 108, 37693.283805707040000m },
                    { 31, 31, 31, 200, 20771.952691598920000m },
                    { 32, 32, 32, 170, 37586.21646604920000m },
                    { 33, 33, 33, 137, 43023.048855974720000m },
                    { 34, 34, 34, 148, 41263.103692084760000m },
                    { 35, 35, 35, 121, 44117.659678354160000m },
                    { 36, 36, 36, 103, 43180.300118326880000m },
                    { 37, 37, 37, 165, 26572.482175148080000m },
                    { 38, 38, 38, 180, 35593.261341062080000m },
                    { 39, 39, 39, 198, 32579.448034849560000m },
                    { 40, 40, 40, 173, 35406.389476384560000m },
                    { 41, 41, 41, 181, 25570.839495647840000m },
                    { 42, 42, 42, 154, 20489.109738277360000m },
                    { 43, 43, 43, 191, 40018.147761437480000m },
                    { 44, 44, 44, 121, 16672.526878718840000m },
                    { 45, 45, 45, 101, 46233.266116795960000m },
                    { 46, 46, 46, 145, 28282.101353487000000m },
                    { 47, 47, 47, 188, 24969.563043584720000m },
                    { 48, 48, 48, 156, 25187.285651376240000m },
                    { 49, 49, 49, 138, 24526.553384066360000m },
                    { 50, 50, 50, 187, 23419.818852462320000m },
                    { 51, 51, 51, 195, 23199.954786792960000m },
                    { 52, 52, 52, 123, 26313.85484842920000m },
                    { 53, 53, 53, 176, 11525.8803149498880000m },
                    { 54, 54, 54, 165, 37999.478060095120000m },
                    { 55, 55, 55, 134, 15855.712314229480000m },
                    { 56, 56, 56, 102, 12453.0338194984440000m },
                    { 57, 57, 57, 121, 32570.084030836920000m },
                    { 58, 58, 58, 132, 43897.897878232760000m },
                    { 59, 59, 59, 145, 17570.923118369160000m },
                    { 60, 60, 60, 101, 18585.832834835080000m },
                    { 61, 61, 61, 185, 39776.839428365280000m },
                    { 62, 62, 62, 184, 48392.719597701240000m },
                    { 63, 63, 63, 164, 49716.002702148240000m },
                    { 64, 64, 64, 173, 17870.23614633440000m },
                    { 65, 65, 65, 180, 36502.493433562760000m },
                    { 66, 66, 66, 106, 34964.584254238320000m },
                    { 67, 67, 67, 111, 24547.856540386840000m },
                    { 68, 68, 68, 125, 11283.1936740267840000m },
                    { 69, 69, 69, 102, 19619.889157696560000m },
                    { 70, 70, 70, 132, 44068.858203724040000m },
                    { 71, 71, 71, 160, 14074.669406822760000m },
                    { 72, 72, 72, 182, 14934.595674850080000m },
                    { 73, 73, 73, 172, 17307.687772819280000m },
                    { 74, 74, 74, 189, 31637.781217724440000m },
                    { 75, 75, 75, 121, 40331.128778126680000m },
                    { 76, 76, 76, 154, 39383.400694483840000m },
                    { 77, 77, 77, 103, 38116.138151717840000m },
                    { 78, 78, 78, 189, 48479.274375144240000m },
                    { 79, 79, 79, 190, 25396.212552162840000m },
                    { 80, 80, 80, 107, 42852.39528786440000m },
                    { 81, 81, 81, 194, 25854.739346980360000m },
                    { 82, 82, 82, 179, 38100.571203300840000m },
                    { 83, 83, 83, 189, 36277.57217839640000m },
                    { 84, 84, 84, 126, 42879.00875934920000m },
                    { 85, 85, 85, 133, 45381.458821648560000m },
                    { 86, 86, 86, 138, 19622.632671413160000m },
                    { 87, 87, 87, 164, 49466.075887476440000m },
                    { 88, 88, 88, 180, 19672.634405414480000m },
                    { 89, 89, 89, 154, 49251.214139322160000m },
                    { 90, 90, 90, 134, 39633.565488765680000m },
                    { 91, 91, 91, 148, 14948.100553053840000m },
                    { 92, 92, 92, 155, 12012.5487450875000000m },
                    { 93, 93, 93, 132, 37595.859016223800000m },
                    { 94, 94, 94, 174, 30193.171036592200000m },
                    { 95, 95, 95, 113, 14144.636553413560000m },
                    { 96, 96, 96, 114, 29339.40033341920000m },
                    { 97, 97, 97, 102, 16070.311952545840000m },
                    { 98, 98, 98, 127, 40746.081281071840000m },
                    { 99, 99, 99, 149, 40611.248843408240000m },
                    { 100, 100, 100, 131, 33548.287916467280000m }
                });

            migrationBuilder.InsertData(
                table: "DetailSalesOrders",
                columns: new[] { "DetailOrderID", "OrderID", "ProductID", "Quantity", "UnitPrice" },
                values: new object[,]
                {
                    { 1, 1, 1, 53, 157468.210330612700000m },
                    { 2, 2, 2, 56, 145167.823255072800000m },
                    { 3, 3, 3, 83, 196511.334143407100000m },
                    { 4, 4, 4, 79, 125614.149784445900000m },
                    { 5, 5, 5, 72, 188973.585910544700000m },
                    { 6, 6, 6, 77, 191033.431603983200000m },
                    { 7, 7, 7, 64, 133760.205748416600000m },
                    { 8, 8, 8, 78, 143812.790945978400000m },
                    { 9, 9, 9, 78, 163729.680088777800000m },
                    { 10, 10, 10, 50, 113815.236690938400000m },
                    { 11, 11, 11, 56, 177182.819334630600000m },
                    { 12, 12, 12, 76, 150022.374231513800000m },
                    { 13, 13, 13, 68, 191483.945227803800000m },
                    { 14, 14, 14, 87, 102393.8256683873800000m },
                    { 15, 15, 15, 62, 123649.194966857400000m },
                    { 16, 16, 16, 86, 161288.250463714600000m },
                    { 17, 17, 17, 63, 105497.9979960973100000m },
                    { 18, 18, 18, 57, 145738.307841191800000m },
                    { 19, 19, 19, 76, 198306.182185476100000m },
                    { 20, 20, 20, 87, 194056.506522158400000m },
                    { 21, 21, 21, 72, 133387.344139994400000m },
                    { 22, 22, 22, 77, 139347.145423573700000m },
                    { 23, 23, 23, 72, 198324.729929332500000m },
                    { 24, 24, 24, 53, 198460.41924576500000m },
                    { 25, 25, 25, 88, 110768.590633306700000m },
                    { 26, 26, 26, 82, 153803.492334887100000m },
                    { 27, 27, 27, 61, 192307.759880283200000m },
                    { 28, 28, 28, 83, 198910.605921124900000m },
                    { 29, 29, 29, 84, 102959.4340650452900000m },
                    { 30, 30, 30, 73, 133825.365573727700000m },
                    { 31, 31, 31, 55, 168544.033364688500000m },
                    { 32, 32, 32, 79, 116190.167324288900000m },
                    { 33, 33, 33, 87, 115398.44029342300000m },
                    { 34, 34, 34, 75, 111463.830522810400000m },
                    { 35, 35, 35, 80, 103988.510135806200000m },
                    { 36, 36, 36, 81, 136907.98393245300000m },
                    { 37, 37, 37, 62, 140511.312769061900000m },
                    { 38, 38, 38, 90, 136777.218734662800000m },
                    { 39, 39, 39, 84, 172682.912477258600000m },
                    { 40, 40, 40, 64, 151889.934238648800000m },
                    { 41, 41, 41, 71, 181658.210620762100000m },
                    { 42, 42, 42, 88, 183694.35282962800000m },
                    { 43, 43, 43, 82, 135466.27108768900000m },
                    { 44, 44, 44, 78, 197870.605089763100000m },
                    { 45, 45, 45, 81, 179077.109896116400000m },
                    { 46, 46, 46, 66, 135809.707281469800000m },
                    { 47, 47, 47, 70, 120681.188526408900000m },
                    { 48, 48, 48, 62, 187248.853826244500000m },
                    { 49, 49, 49, 73, 168909.83203089800000m },
                    { 50, 50, 50, 71, 100854.20779961554700000m },
                    { 51, 51, 51, 84, 169409.943955898600000m },
                    { 52, 52, 52, 82, 188154.544303872800000m },
                    { 53, 53, 53, 86, 128272.421755477100000m },
                    { 54, 54, 54, 50, 187217.62247505300000m },
                    { 55, 55, 55, 87, 142154.072293404500000m },
                    { 56, 56, 56, 63, 126824.953831116200000m },
                    { 57, 57, 57, 59, 146683.003253990800000m },
                    { 58, 58, 58, 75, 109853.8448098451200000m },
                    { 59, 59, 59, 80, 127417.10708822500000m },
                    { 60, 60, 60, 52, 177399.943705136900000m },
                    { 61, 61, 61, 87, 138323.850867515300000m },
                    { 62, 62, 62, 69, 184381.418753667900000m },
                    { 63, 63, 63, 79, 169525.267202530500000m },
                    { 64, 64, 64, 74, 161765.629865926800000m },
                    { 65, 65, 65, 50, 120571.187316720100000m },
                    { 66, 66, 66, 67, 138674.515778798600000m },
                    { 67, 67, 67, 83, 116956.609278328200000m },
                    { 68, 68, 68, 51, 111523.893519301800000m },
                    { 69, 69, 69, 55, 127894.51377062500000m },
                    { 70, 70, 70, 53, 140775.736416820500000m },
                    { 71, 71, 71, 89, 124448.430936387400000m },
                    { 72, 72, 72, 61, 111955.454306997700000m },
                    { 73, 73, 73, 71, 105620.0495159138500000m },
                    { 74, 74, 74, 63, 169318.271114746400000m },
                    { 75, 75, 75, 76, 129221.534731102100000m },
                    { 76, 76, 76, 55, 165637.964780073300000m },
                    { 77, 77, 77, 69, 190047.935533389600000m },
                    { 78, 78, 78, 81, 128826.61046053400000m },
                    { 79, 79, 79, 81, 133644.3923769100000m },
                    { 80, 80, 80, 80, 128858.682087753800000m },
                    { 81, 81, 81, 86, 173215.157744532200000m },
                    { 82, 82, 82, 82, 135415.852999570500000m },
                    { 83, 83, 83, 53, 147775.603087382100000m },
                    { 84, 84, 84, 74, 188410.404661845900000m },
                    { 85, 85, 85, 51, 112623.321699278400000m },
                    { 86, 86, 86, 63, 135712.109717834200000m },
                    { 87, 87, 87, 62, 172509.303387528600000m },
                    { 88, 88, 88, 82, 118497.8952653100000m },
                    { 89, 89, 89, 85, 102225.5857101682700000m },
                    { 90, 90, 90, 53, 119731.350081151800000m },
                    { 91, 91, 91, 79, 111385.75436586200000m },
                    { 92, 92, 92, 83, 142384.161116026200000m },
                    { 93, 93, 93, 55, 199142.629041914200000m },
                    { 94, 94, 94, 61, 125776.43869617300000m },
                    { 95, 95, 95, 81, 147229.944099034100000m },
                    { 96, 96, 96, 81, 191162.33623082700000m },
                    { 97, 97, 97, 72, 155316.276406438700000m },
                    { 98, 98, 98, 67, 116693.215264175200000m },
                    { 99, 99, 99, 69, 177951.987427543400000m },
                    { 100, 100, 100, 56, 121369.280905543500000m }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "EmployeeID", "RoleID", "Email", "LastLogin", "Lock", "Password" },
                values: new object[,]
                {
                    { 1, 2, "HoangXuan_To@gmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 3, 2, "XuanLoan_Ly83@yahoo.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 14, 2, "XuanQuy_Phung@yahoo.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 16, 2, "PhuongHien17@gmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 20, 2, "NhatPhuong_Lam@yahoo.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 21, 2, "TamTrang.Phung@yahoo.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 24, 2, "HoangHai_Hoang18@yahoo.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 26, 2, "KimToan.Ly45@gmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 28, 2, "BaoSon.Ho@gmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 29, 2, "MinhHuong_Phung28@gmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 30, 2, "ThyOanh94@hotmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 32, 2, "DinhChuong.Vu75@yahoo.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 34, 2, "DuyKinh_Lam@gmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 35, 2, "BichHong2@yahoo.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 36, 2, "CaoPhong41@gmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 45, 2, "BichDiep84@yahoo.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 48, 2, "KimChi64@gmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 50, 2, "BaoDinh.Pham79@hotmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 51, 2, "NhatThinh.Dang24@yahoo.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 54, 2, "BaoDuy.Trinh@hotmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 55, 2, "ChePhuong60@hotmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 61, 2, "BinhYen66@yahoo.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 63, 2, "GiaHoa6@gmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 66, 2, "DiepVy24@gmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 69, 2, "PhuongTram.Vuong69@yahoo.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 71, 2, "MyHuong99@yahoo.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 73, 2, "ThanhViet88@gmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 76, 2, "ThuyLinh_Mai@gmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 78, 2, "TanDung.Do37@yahoo.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 81, 2, "LyChau.Dinh13@yahoo.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 83, 2, "ThanhThanh.Lam40@gmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 85, 2, "NgocTrinh.Lam84@yahoo.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 88, 2, "UyenThy.Dang@yahoo.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 91, 2, "ThienTri2@yahoo.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 97, 2, "ThuyTien9@gmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 98, 2, "DanThanh_Phan18@yahoo.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" },
                    { 100, 2, "VanThuong.To@yahoo.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_ImportOrders_Employee_EmployeeID",
                table: "ImportOrders",
                column: "EmployeeID",
                principalTable: "Employee",
                principalColumn: "EmployeeID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SalesOrders_Employee_EmployeeID",
                table: "SalesOrders",
                column: "EmployeeID",
                principalTable: "Employee",
                principalColumn: "EmployeeID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ImportOrders_Employee_EmployeeID",
                table: "ImportOrders");

            migrationBuilder.DropForeignKey(
                name: "FK_SalesOrders_Employee_EmployeeID",
                table: "SalesOrders");

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 2);

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
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 17);

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
                keyValue: 24);

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
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 45);

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
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 50);

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
                keyValue: 58);

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
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 72);

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
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 80);

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
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "DetailImportOrders",
                keyColumn: "DetailOrderID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "DetailImportOrders",
                keyColumn: "DetailOrderID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "DetailImportOrders",
                keyColumn: "DetailOrderID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "DetailImportOrders",
                keyColumn: "DetailOrderID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "DetailImportOrders",
                keyColumn: "DetailOrderID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "DetailImportOrders",
                keyColumn: "DetailOrderID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "DetailImportOrders",
                keyColumn: "DetailOrderID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "DetailImportOrders",
                keyColumn: "DetailOrderID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "DetailImportOrders",
                keyColumn: "DetailOrderID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "DetailImportOrders",
                keyColumn: "DetailOrderID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "DetailImportOrders",
                keyColumn: "DetailOrderID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "DetailImportOrders",
                keyColumn: "DetailOrderID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "DetailImportOrders",
                keyColumn: "DetailOrderID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "DetailImportOrders",
                keyColumn: "DetailOrderID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "DetailImportOrders",
                keyColumn: "DetailOrderID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "DetailImportOrders",
                keyColumn: "DetailOrderID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "DetailImportOrders",
                keyColumn: "DetailOrderID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "DetailImportOrders",
                keyColumn: "DetailOrderID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "DetailImportOrders",
                keyColumn: "DetailOrderID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "DetailImportOrders",
                keyColumn: "DetailOrderID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "DetailImportOrders",
                keyColumn: "DetailOrderID",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "DetailImportOrders",
                keyColumn: "DetailOrderID",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "DetailImportOrders",
                keyColumn: "DetailOrderID",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "DetailImportOrders",
                keyColumn: "DetailOrderID",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "DetailImportOrders",
                keyColumn: "DetailOrderID",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "DetailImportOrders",
                keyColumn: "DetailOrderID",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "DetailImportOrders",
                keyColumn: "DetailOrderID",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "DetailImportOrders",
                keyColumn: "DetailOrderID",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "DetailImportOrders",
                keyColumn: "DetailOrderID",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "DetailImportOrders",
                keyColumn: "DetailOrderID",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "DetailImportOrders",
                keyColumn: "DetailOrderID",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "DetailImportOrders",
                keyColumn: "DetailOrderID",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "DetailImportOrders",
                keyColumn: "DetailOrderID",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "DetailImportOrders",
                keyColumn: "DetailOrderID",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "DetailImportOrders",
                keyColumn: "DetailOrderID",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "DetailImportOrders",
                keyColumn: "DetailOrderID",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "DetailImportOrders",
                keyColumn: "DetailOrderID",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "DetailImportOrders",
                keyColumn: "DetailOrderID",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "DetailImportOrders",
                keyColumn: "DetailOrderID",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "DetailImportOrders",
                keyColumn: "DetailOrderID",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "DetailImportOrders",
                keyColumn: "DetailOrderID",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "DetailImportOrders",
                keyColumn: "DetailOrderID",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "DetailImportOrders",
                keyColumn: "DetailOrderID",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "DetailImportOrders",
                keyColumn: "DetailOrderID",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "DetailImportOrders",
                keyColumn: "DetailOrderID",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "DetailImportOrders",
                keyColumn: "DetailOrderID",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "DetailImportOrders",
                keyColumn: "DetailOrderID",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "DetailImportOrders",
                keyColumn: "DetailOrderID",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "DetailImportOrders",
                keyColumn: "DetailOrderID",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "DetailImportOrders",
                keyColumn: "DetailOrderID",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "DetailImportOrders",
                keyColumn: "DetailOrderID",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "DetailImportOrders",
                keyColumn: "DetailOrderID",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "DetailImportOrders",
                keyColumn: "DetailOrderID",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "DetailImportOrders",
                keyColumn: "DetailOrderID",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "DetailImportOrders",
                keyColumn: "DetailOrderID",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "DetailImportOrders",
                keyColumn: "DetailOrderID",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "DetailImportOrders",
                keyColumn: "DetailOrderID",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "DetailImportOrders",
                keyColumn: "DetailOrderID",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "DetailImportOrders",
                keyColumn: "DetailOrderID",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "DetailImportOrders",
                keyColumn: "DetailOrderID",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "DetailImportOrders",
                keyColumn: "DetailOrderID",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "DetailImportOrders",
                keyColumn: "DetailOrderID",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "DetailImportOrders",
                keyColumn: "DetailOrderID",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "DetailImportOrders",
                keyColumn: "DetailOrderID",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "DetailImportOrders",
                keyColumn: "DetailOrderID",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "DetailImportOrders",
                keyColumn: "DetailOrderID",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "DetailImportOrders",
                keyColumn: "DetailOrderID",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "DetailImportOrders",
                keyColumn: "DetailOrderID",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "DetailImportOrders",
                keyColumn: "DetailOrderID",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "DetailImportOrders",
                keyColumn: "DetailOrderID",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "DetailImportOrders",
                keyColumn: "DetailOrderID",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "DetailImportOrders",
                keyColumn: "DetailOrderID",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "DetailImportOrders",
                keyColumn: "DetailOrderID",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "DetailImportOrders",
                keyColumn: "DetailOrderID",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "DetailImportOrders",
                keyColumn: "DetailOrderID",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "DetailImportOrders",
                keyColumn: "DetailOrderID",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "DetailImportOrders",
                keyColumn: "DetailOrderID",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "DetailImportOrders",
                keyColumn: "DetailOrderID",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "DetailImportOrders",
                keyColumn: "DetailOrderID",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "DetailImportOrders",
                keyColumn: "DetailOrderID",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "DetailImportOrders",
                keyColumn: "DetailOrderID",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "DetailImportOrders",
                keyColumn: "DetailOrderID",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "DetailImportOrders",
                keyColumn: "DetailOrderID",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "DetailImportOrders",
                keyColumn: "DetailOrderID",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "DetailImportOrders",
                keyColumn: "DetailOrderID",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "DetailImportOrders",
                keyColumn: "DetailOrderID",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "DetailImportOrders",
                keyColumn: "DetailOrderID",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "DetailImportOrders",
                keyColumn: "DetailOrderID",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "DetailImportOrders",
                keyColumn: "DetailOrderID",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "DetailImportOrders",
                keyColumn: "DetailOrderID",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "DetailImportOrders",
                keyColumn: "DetailOrderID",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "DetailImportOrders",
                keyColumn: "DetailOrderID",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "DetailImportOrders",
                keyColumn: "DetailOrderID",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "DetailImportOrders",
                keyColumn: "DetailOrderID",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "DetailImportOrders",
                keyColumn: "DetailOrderID",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "DetailImportOrders",
                keyColumn: "DetailOrderID",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "DetailImportOrders",
                keyColumn: "DetailOrderID",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "DetailImportOrders",
                keyColumn: "DetailOrderID",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "DetailImportOrders",
                keyColumn: "DetailOrderID",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "DetailImportOrders",
                keyColumn: "DetailOrderID",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "DetailSalesOrders",
                keyColumn: "DetailOrderID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "DetailSalesOrders",
                keyColumn: "DetailOrderID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "DetailSalesOrders",
                keyColumn: "DetailOrderID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "DetailSalesOrders",
                keyColumn: "DetailOrderID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "DetailSalesOrders",
                keyColumn: "DetailOrderID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "DetailSalesOrders",
                keyColumn: "DetailOrderID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "DetailSalesOrders",
                keyColumn: "DetailOrderID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "DetailSalesOrders",
                keyColumn: "DetailOrderID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "DetailSalesOrders",
                keyColumn: "DetailOrderID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "DetailSalesOrders",
                keyColumn: "DetailOrderID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "DetailSalesOrders",
                keyColumn: "DetailOrderID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "DetailSalesOrders",
                keyColumn: "DetailOrderID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "DetailSalesOrders",
                keyColumn: "DetailOrderID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "DetailSalesOrders",
                keyColumn: "DetailOrderID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "DetailSalesOrders",
                keyColumn: "DetailOrderID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "DetailSalesOrders",
                keyColumn: "DetailOrderID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "DetailSalesOrders",
                keyColumn: "DetailOrderID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "DetailSalesOrders",
                keyColumn: "DetailOrderID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "DetailSalesOrders",
                keyColumn: "DetailOrderID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "DetailSalesOrders",
                keyColumn: "DetailOrderID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "DetailSalesOrders",
                keyColumn: "DetailOrderID",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "DetailSalesOrders",
                keyColumn: "DetailOrderID",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "DetailSalesOrders",
                keyColumn: "DetailOrderID",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "DetailSalesOrders",
                keyColumn: "DetailOrderID",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "DetailSalesOrders",
                keyColumn: "DetailOrderID",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "DetailSalesOrders",
                keyColumn: "DetailOrderID",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "DetailSalesOrders",
                keyColumn: "DetailOrderID",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "DetailSalesOrders",
                keyColumn: "DetailOrderID",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "DetailSalesOrders",
                keyColumn: "DetailOrderID",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "DetailSalesOrders",
                keyColumn: "DetailOrderID",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "DetailSalesOrders",
                keyColumn: "DetailOrderID",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "DetailSalesOrders",
                keyColumn: "DetailOrderID",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "DetailSalesOrders",
                keyColumn: "DetailOrderID",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "DetailSalesOrders",
                keyColumn: "DetailOrderID",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "DetailSalesOrders",
                keyColumn: "DetailOrderID",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "DetailSalesOrders",
                keyColumn: "DetailOrderID",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "DetailSalesOrders",
                keyColumn: "DetailOrderID",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "DetailSalesOrders",
                keyColumn: "DetailOrderID",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "DetailSalesOrders",
                keyColumn: "DetailOrderID",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "DetailSalesOrders",
                keyColumn: "DetailOrderID",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "DetailSalesOrders",
                keyColumn: "DetailOrderID",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "DetailSalesOrders",
                keyColumn: "DetailOrderID",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "DetailSalesOrders",
                keyColumn: "DetailOrderID",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "DetailSalesOrders",
                keyColumn: "DetailOrderID",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "DetailSalesOrders",
                keyColumn: "DetailOrderID",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "DetailSalesOrders",
                keyColumn: "DetailOrderID",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "DetailSalesOrders",
                keyColumn: "DetailOrderID",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "DetailSalesOrders",
                keyColumn: "DetailOrderID",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "DetailSalesOrders",
                keyColumn: "DetailOrderID",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "DetailSalesOrders",
                keyColumn: "DetailOrderID",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "DetailSalesOrders",
                keyColumn: "DetailOrderID",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "DetailSalesOrders",
                keyColumn: "DetailOrderID",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "DetailSalesOrders",
                keyColumn: "DetailOrderID",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "DetailSalesOrders",
                keyColumn: "DetailOrderID",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "DetailSalesOrders",
                keyColumn: "DetailOrderID",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "DetailSalesOrders",
                keyColumn: "DetailOrderID",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "DetailSalesOrders",
                keyColumn: "DetailOrderID",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "DetailSalesOrders",
                keyColumn: "DetailOrderID",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "DetailSalesOrders",
                keyColumn: "DetailOrderID",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "DetailSalesOrders",
                keyColumn: "DetailOrderID",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "DetailSalesOrders",
                keyColumn: "DetailOrderID",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "DetailSalesOrders",
                keyColumn: "DetailOrderID",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "DetailSalesOrders",
                keyColumn: "DetailOrderID",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "DetailSalesOrders",
                keyColumn: "DetailOrderID",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "DetailSalesOrders",
                keyColumn: "DetailOrderID",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "DetailSalesOrders",
                keyColumn: "DetailOrderID",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "DetailSalesOrders",
                keyColumn: "DetailOrderID",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "DetailSalesOrders",
                keyColumn: "DetailOrderID",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "DetailSalesOrders",
                keyColumn: "DetailOrderID",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "DetailSalesOrders",
                keyColumn: "DetailOrderID",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "DetailSalesOrders",
                keyColumn: "DetailOrderID",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "DetailSalesOrders",
                keyColumn: "DetailOrderID",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "DetailSalesOrders",
                keyColumn: "DetailOrderID",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "DetailSalesOrders",
                keyColumn: "DetailOrderID",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "DetailSalesOrders",
                keyColumn: "DetailOrderID",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "DetailSalesOrders",
                keyColumn: "DetailOrderID",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "DetailSalesOrders",
                keyColumn: "DetailOrderID",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "DetailSalesOrders",
                keyColumn: "DetailOrderID",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "DetailSalesOrders",
                keyColumn: "DetailOrderID",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "DetailSalesOrders",
                keyColumn: "DetailOrderID",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "DetailSalesOrders",
                keyColumn: "DetailOrderID",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "DetailSalesOrders",
                keyColumn: "DetailOrderID",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "DetailSalesOrders",
                keyColumn: "DetailOrderID",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "DetailSalesOrders",
                keyColumn: "DetailOrderID",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "DetailSalesOrders",
                keyColumn: "DetailOrderID",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "DetailSalesOrders",
                keyColumn: "DetailOrderID",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "DetailSalesOrders",
                keyColumn: "DetailOrderID",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "DetailSalesOrders",
                keyColumn: "DetailOrderID",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "DetailSalesOrders",
                keyColumn: "DetailOrderID",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "DetailSalesOrders",
                keyColumn: "DetailOrderID",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "DetailSalesOrders",
                keyColumn: "DetailOrderID",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "DetailSalesOrders",
                keyColumn: "DetailOrderID",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "DetailSalesOrders",
                keyColumn: "DetailOrderID",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "DetailSalesOrders",
                keyColumn: "DetailOrderID",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "DetailSalesOrders",
                keyColumn: "DetailOrderID",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "DetailSalesOrders",
                keyColumn: "DetailOrderID",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "DetailSalesOrders",
                keyColumn: "DetailOrderID",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "DetailSalesOrders",
                keyColumn: "DetailOrderID",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "DetailSalesOrders",
                keyColumn: "DetailOrderID",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "DetailSalesOrders",
                keyColumn: "DetailOrderID",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 4, 1 });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 5, 1 });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 6, 1 });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 7, 1 });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 8, 1 });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 9, 1 });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 10, 1 });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 11, 1 });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 12, 1 });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 13, 1 });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 14, 2 });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 15, 1 });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 16, 2 });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 17, 1 });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 18, 1 });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 19, 1 });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 20, 2 });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 21, 2 });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 22, 1 });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 23, 1 });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 24, 2 });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 25, 1 });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 26, 2 });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 27, 1 });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 28, 2 });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 29, 2 });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 30, 2 });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 31, 1 });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 32, 2 });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 33, 1 });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 34, 2 });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 35, 2 });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 36, 2 });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 37, 1 });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 38, 1 });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 39, 1 });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 40, 1 });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 41, 1 });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 42, 1 });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 43, 1 });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 44, 1 });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 45, 2 });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 46, 1 });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 47, 1 });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 48, 2 });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 49, 1 });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 50, 2 });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 51, 2 });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 52, 1 });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 53, 1 });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 54, 2 });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 55, 2 });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 56, 1 });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 57, 1 });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 58, 1 });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 59, 1 });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 60, 1 });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 61, 2 });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 62, 1 });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 63, 2 });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 64, 1 });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 65, 1 });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 66, 2 });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 67, 1 });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 68, 1 });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 69, 2 });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 70, 1 });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 71, 2 });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 72, 1 });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 73, 2 });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 74, 1 });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 75, 1 });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 76, 2 });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 77, 1 });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 78, 2 });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 79, 1 });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 80, 1 });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 81, 2 });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 82, 1 });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 83, 2 });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 84, 1 });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 85, 2 });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 86, 1 });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 87, 1 });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 88, 2 });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 89, 1 });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 90, 1 });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 91, 2 });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 92, 1 });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 93, 1 });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 94, 1 });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 95, 1 });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 96, 1 });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 97, 2 });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 98, 2 });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 99, 1 });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumns: new[] { "EmployeeID", "RoleID" },
                keyValues: new object[] { 100, 2 });

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 38);

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
                keyValue: 44);

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
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "ImportOrders",
                keyColumn: "OrderID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ImportOrders",
                keyColumn: "OrderID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ImportOrders",
                keyColumn: "OrderID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ImportOrders",
                keyColumn: "OrderID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ImportOrders",
                keyColumn: "OrderID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ImportOrders",
                keyColumn: "OrderID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ImportOrders",
                keyColumn: "OrderID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ImportOrders",
                keyColumn: "OrderID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "ImportOrders",
                keyColumn: "OrderID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "ImportOrders",
                keyColumn: "OrderID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "ImportOrders",
                keyColumn: "OrderID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "ImportOrders",
                keyColumn: "OrderID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "ImportOrders",
                keyColumn: "OrderID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "ImportOrders",
                keyColumn: "OrderID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "ImportOrders",
                keyColumn: "OrderID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "ImportOrders",
                keyColumn: "OrderID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "ImportOrders",
                keyColumn: "OrderID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "ImportOrders",
                keyColumn: "OrderID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "ImportOrders",
                keyColumn: "OrderID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "ImportOrders",
                keyColumn: "OrderID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "ImportOrders",
                keyColumn: "OrderID",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "ImportOrders",
                keyColumn: "OrderID",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "ImportOrders",
                keyColumn: "OrderID",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "ImportOrders",
                keyColumn: "OrderID",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "ImportOrders",
                keyColumn: "OrderID",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "ImportOrders",
                keyColumn: "OrderID",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "ImportOrders",
                keyColumn: "OrderID",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "ImportOrders",
                keyColumn: "OrderID",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "ImportOrders",
                keyColumn: "OrderID",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "ImportOrders",
                keyColumn: "OrderID",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "ImportOrders",
                keyColumn: "OrderID",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "ImportOrders",
                keyColumn: "OrderID",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "ImportOrders",
                keyColumn: "OrderID",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "ImportOrders",
                keyColumn: "OrderID",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "ImportOrders",
                keyColumn: "OrderID",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "ImportOrders",
                keyColumn: "OrderID",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "ImportOrders",
                keyColumn: "OrderID",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "ImportOrders",
                keyColumn: "OrderID",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "ImportOrders",
                keyColumn: "OrderID",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "ImportOrders",
                keyColumn: "OrderID",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "ImportOrders",
                keyColumn: "OrderID",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "ImportOrders",
                keyColumn: "OrderID",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "ImportOrders",
                keyColumn: "OrderID",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "ImportOrders",
                keyColumn: "OrderID",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "ImportOrders",
                keyColumn: "OrderID",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "ImportOrders",
                keyColumn: "OrderID",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "ImportOrders",
                keyColumn: "OrderID",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "ImportOrders",
                keyColumn: "OrderID",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "ImportOrders",
                keyColumn: "OrderID",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "ImportOrders",
                keyColumn: "OrderID",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "ImportOrders",
                keyColumn: "OrderID",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "ImportOrders",
                keyColumn: "OrderID",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "ImportOrders",
                keyColumn: "OrderID",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "ImportOrders",
                keyColumn: "OrderID",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "ImportOrders",
                keyColumn: "OrderID",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "ImportOrders",
                keyColumn: "OrderID",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "ImportOrders",
                keyColumn: "OrderID",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "ImportOrders",
                keyColumn: "OrderID",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "ImportOrders",
                keyColumn: "OrderID",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "ImportOrders",
                keyColumn: "OrderID",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "ImportOrders",
                keyColumn: "OrderID",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "ImportOrders",
                keyColumn: "OrderID",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "ImportOrders",
                keyColumn: "OrderID",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "ImportOrders",
                keyColumn: "OrderID",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "ImportOrders",
                keyColumn: "OrderID",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "ImportOrders",
                keyColumn: "OrderID",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "ImportOrders",
                keyColumn: "OrderID",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "ImportOrders",
                keyColumn: "OrderID",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "ImportOrders",
                keyColumn: "OrderID",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "ImportOrders",
                keyColumn: "OrderID",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "ImportOrders",
                keyColumn: "OrderID",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "ImportOrders",
                keyColumn: "OrderID",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "ImportOrders",
                keyColumn: "OrderID",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "ImportOrders",
                keyColumn: "OrderID",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "ImportOrders",
                keyColumn: "OrderID",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "ImportOrders",
                keyColumn: "OrderID",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "ImportOrders",
                keyColumn: "OrderID",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "ImportOrders",
                keyColumn: "OrderID",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "ImportOrders",
                keyColumn: "OrderID",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "ImportOrders",
                keyColumn: "OrderID",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "ImportOrders",
                keyColumn: "OrderID",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "ImportOrders",
                keyColumn: "OrderID",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "ImportOrders",
                keyColumn: "OrderID",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "ImportOrders",
                keyColumn: "OrderID",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "ImportOrders",
                keyColumn: "OrderID",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "ImportOrders",
                keyColumn: "OrderID",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "ImportOrders",
                keyColumn: "OrderID",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "ImportOrders",
                keyColumn: "OrderID",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "ImportOrders",
                keyColumn: "OrderID",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "ImportOrders",
                keyColumn: "OrderID",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "ImportOrders",
                keyColumn: "OrderID",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "ImportOrders",
                keyColumn: "OrderID",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "ImportOrders",
                keyColumn: "OrderID",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "ImportOrders",
                keyColumn: "OrderID",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "ImportOrders",
                keyColumn: "OrderID",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "ImportOrders",
                keyColumn: "OrderID",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "ImportOrders",
                keyColumn: "OrderID",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "ImportOrders",
                keyColumn: "OrderID",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "ImportOrders",
                keyColumn: "OrderID",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "ImportOrders",
                keyColumn: "OrderID",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "SalesOrders",
                keyColumn: "OrderID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "SalesOrders",
                keyColumn: "OrderID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "SalesOrders",
                keyColumn: "OrderID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "SalesOrders",
                keyColumn: "OrderID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "SalesOrders",
                keyColumn: "OrderID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "SalesOrders",
                keyColumn: "OrderID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "SalesOrders",
                keyColumn: "OrderID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "SalesOrders",
                keyColumn: "OrderID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "SalesOrders",
                keyColumn: "OrderID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "SalesOrders",
                keyColumn: "OrderID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "SalesOrders",
                keyColumn: "OrderID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "SalesOrders",
                keyColumn: "OrderID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "SalesOrders",
                keyColumn: "OrderID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "SalesOrders",
                keyColumn: "OrderID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "SalesOrders",
                keyColumn: "OrderID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "SalesOrders",
                keyColumn: "OrderID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "SalesOrders",
                keyColumn: "OrderID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "SalesOrders",
                keyColumn: "OrderID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "SalesOrders",
                keyColumn: "OrderID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "SalesOrders",
                keyColumn: "OrderID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "SalesOrders",
                keyColumn: "OrderID",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "SalesOrders",
                keyColumn: "OrderID",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "SalesOrders",
                keyColumn: "OrderID",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "SalesOrders",
                keyColumn: "OrderID",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "SalesOrders",
                keyColumn: "OrderID",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "SalesOrders",
                keyColumn: "OrderID",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "SalesOrders",
                keyColumn: "OrderID",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "SalesOrders",
                keyColumn: "OrderID",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "SalesOrders",
                keyColumn: "OrderID",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "SalesOrders",
                keyColumn: "OrderID",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "SalesOrders",
                keyColumn: "OrderID",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "SalesOrders",
                keyColumn: "OrderID",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "SalesOrders",
                keyColumn: "OrderID",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "SalesOrders",
                keyColumn: "OrderID",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "SalesOrders",
                keyColumn: "OrderID",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "SalesOrders",
                keyColumn: "OrderID",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "SalesOrders",
                keyColumn: "OrderID",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "SalesOrders",
                keyColumn: "OrderID",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "SalesOrders",
                keyColumn: "OrderID",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "SalesOrders",
                keyColumn: "OrderID",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "SalesOrders",
                keyColumn: "OrderID",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "SalesOrders",
                keyColumn: "OrderID",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "SalesOrders",
                keyColumn: "OrderID",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "SalesOrders",
                keyColumn: "OrderID",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "SalesOrders",
                keyColumn: "OrderID",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "SalesOrders",
                keyColumn: "OrderID",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "SalesOrders",
                keyColumn: "OrderID",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "SalesOrders",
                keyColumn: "OrderID",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "SalesOrders",
                keyColumn: "OrderID",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "SalesOrders",
                keyColumn: "OrderID",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "SalesOrders",
                keyColumn: "OrderID",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "SalesOrders",
                keyColumn: "OrderID",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "SalesOrders",
                keyColumn: "OrderID",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "SalesOrders",
                keyColumn: "OrderID",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "SalesOrders",
                keyColumn: "OrderID",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "SalesOrders",
                keyColumn: "OrderID",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "SalesOrders",
                keyColumn: "OrderID",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "SalesOrders",
                keyColumn: "OrderID",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "SalesOrders",
                keyColumn: "OrderID",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "SalesOrders",
                keyColumn: "OrderID",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "SalesOrders",
                keyColumn: "OrderID",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "SalesOrders",
                keyColumn: "OrderID",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "SalesOrders",
                keyColumn: "OrderID",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "SalesOrders",
                keyColumn: "OrderID",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "SalesOrders",
                keyColumn: "OrderID",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "SalesOrders",
                keyColumn: "OrderID",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "SalesOrders",
                keyColumn: "OrderID",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "SalesOrders",
                keyColumn: "OrderID",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "SalesOrders",
                keyColumn: "OrderID",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "SalesOrders",
                keyColumn: "OrderID",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "SalesOrders",
                keyColumn: "OrderID",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "SalesOrders",
                keyColumn: "OrderID",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "SalesOrders",
                keyColumn: "OrderID",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "SalesOrders",
                keyColumn: "OrderID",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "SalesOrders",
                keyColumn: "OrderID",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "SalesOrders",
                keyColumn: "OrderID",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "SalesOrders",
                keyColumn: "OrderID",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "SalesOrders",
                keyColumn: "OrderID",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "SalesOrders",
                keyColumn: "OrderID",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "SalesOrders",
                keyColumn: "OrderID",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "SalesOrders",
                keyColumn: "OrderID",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "SalesOrders",
                keyColumn: "OrderID",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "SalesOrders",
                keyColumn: "OrderID",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "SalesOrders",
                keyColumn: "OrderID",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "SalesOrders",
                keyColumn: "OrderID",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "SalesOrders",
                keyColumn: "OrderID",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "SalesOrders",
                keyColumn: "OrderID",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "SalesOrders",
                keyColumn: "OrderID",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "SalesOrders",
                keyColumn: "OrderID",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "SalesOrders",
                keyColumn: "OrderID",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "SalesOrders",
                keyColumn: "OrderID",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "SalesOrders",
                keyColumn: "OrderID",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "SalesOrders",
                keyColumn: "OrderID",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "SalesOrders",
                keyColumn: "OrderID",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "SalesOrders",
                keyColumn: "OrderID",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "SalesOrders",
                keyColumn: "OrderID",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "SalesOrders",
                keyColumn: "OrderID",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "SalesOrders",
                keyColumn: "OrderID",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "SalesOrders",
                keyColumn: "OrderID",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "SalesOrders",
                keyColumn: "OrderID",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumn: "RoleID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 6);

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
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 19);

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
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 36);

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
                keyValue: 46);

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
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 61);

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
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 67);

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
                keyValue: 70);

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
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 83);

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
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 99);

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
                keyValue: 23);

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
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 29);

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
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 43);

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
                keyValue: 50);

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
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 64);

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
                keyValue: 68);

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
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 100);

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

            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "Employee",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "TotalPrice",
                table: "DetailSalesOrders",
                type: "decimal(10,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "TotalPrice",
                table: "DetailImportOrders",
                type: "decimal(10,2)",
                nullable: false,
                defaultValue: 0m);

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
                columns: new[] { "CanExportSalesOrder", "CanPrintSalesOrder", "CanReadDetailImportOrder", "CanReadProduct", "CanReadSalesOrder" },
                values: new object[] { false, false, true, false, false });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "RoleID",
                keyValue: 1,
                columns: new[] { "DateCreated", "RoleName" },
                values: new object[] { new DateTime(2023, 11, 24, 8, 37, 40, 618, DateTimeKind.Local).AddTicks(1611), "Nhân viên" });

            migrationBuilder.AddForeignKey(
                name: "FK_ImportOrders_Employee_EmployeeID",
                table: "ImportOrders",
                column: "EmployeeID",
                principalTable: "Employee",
                principalColumn: "EmployeeID");

            migrationBuilder.AddForeignKey(
                name: "FK_SalesOrders_Employee_EmployeeID",
                table: "SalesOrders",
                column: "EmployeeID",
                principalTable: "Employee",
                principalColumn: "EmployeeID");
        }
    }
}
