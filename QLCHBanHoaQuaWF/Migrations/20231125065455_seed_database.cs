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
            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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
                    { 1, "Đồng Tháp", "Duy Cường Nguyễn", new DateTime(2023, 11, 25, 13, 54, 55, 571, DateTimeKind.Local).AddTicks(708), "MaiVy53@hotmail.com", "0984804148" },
                    { 2, "Yên Bái", "Mai Thanh Hoàng", new DateTime(2023, 11, 25, 13, 54, 55, 571, DateTimeKind.Local).AddTicks(3319), "TrieuThanh.Doan85@hotmail.com", "0919328759" },
                    { 3, "Quảng Nam", "An Nhiên Phan", new DateTime(2023, 11, 25, 13, 54, 55, 571, DateTimeKind.Local).AddTicks(3461), "HamTho.Vu@yahoo.com", "0916356052" },
                    { 4, "Vĩnh Long", "Ngọc Ðoàn Mai", new DateTime(2023, 11, 25, 13, 54, 55, 571, DateTimeKind.Local).AddTicks(3542), "NhatTien_Do25@hotmail.com", "0996153007" },
                    { 5, "Thừa Thiên-Huế", "Ðức Trí Tăng", new DateTime(2023, 11, 25, 13, 54, 55, 571, DateTimeKind.Local).AddTicks(3620), "BaoThai_Nguyen@gmail.com", "0939449284" },
                    { 6, "Thái Nguyên", "Đông Tuyền Đinh", new DateTime(2023, 11, 25, 13, 54, 55, 571, DateTimeKind.Local).AddTicks(3704), "QuanDuong.Dao5@gmail.com", "0913993014" },
                    { 7, "Kon Tum", "Phương Chi Hoàng", new DateTime(2023, 11, 25, 13, 54, 55, 571, DateTimeKind.Local).AddTicks(3780), "HanhNga.Mai98@hotmail.com", "0964695170" },
                    { 8, "Bến Tre", "Mỹ Thuận Phan", new DateTime(2023, 11, 25, 13, 54, 55, 571, DateTimeKind.Local).AddTicks(3852), "HuuThong.Dang84@gmail.com", "0995061055" },
                    { 9, "Bắc Giang", "Vĩnh Luân Phạm", new DateTime(2023, 11, 25, 13, 54, 55, 571, DateTimeKind.Local).AddTicks(3931), "DangMinh_Nguyen66@yahoo.com", "0988909125" },
                    { 10, "Quảng Trị", "Ðồng Dao Hà", new DateTime(2023, 11, 25, 13, 54, 55, 571, DateTimeKind.Local).AddTicks(4007), "HieuLam_Trinh@hotmail.com", "0983432309" },
                    { 11, "Vĩnh Long", "Quỳnh Tiên Mai", new DateTime(2023, 11, 25, 13, 54, 55, 571, DateTimeKind.Local).AddTicks(4082), "XuanUyen85@hotmail.com", "0913248283" },
                    { 12, "Cần Thơ", "Hạnh Vi Trần", new DateTime(2023, 11, 25, 13, 54, 55, 571, DateTimeKind.Local).AddTicks(4152), "MinhHa_Ha65@gmail.com", "0984522047" },
                    { 13, "Yên Bái", "Liên Như Nguyễn", new DateTime(2023, 11, 25, 13, 54, 55, 571, DateTimeKind.Local).AddTicks(4218), "CaoSy.Tang@hotmail.com", "0926834404" },
                    { 14, "Ninh Bình", "Thủy Nguyệt Mai", new DateTime(2023, 11, 25, 13, 54, 55, 571, DateTimeKind.Local).AddTicks(4281), "QuocThanh_Vuong@gmail.com", "0925846252" },
                    { 15, "Kon Tum", "Duyên Nương Đỗ", new DateTime(2023, 11, 25, 13, 54, 55, 571, DateTimeKind.Local).AddTicks(4362), "NgocDao33@gmail.com", "0961179030" },
                    { 16, "Hải Phòng", "Kim Mai Phạm", new DateTime(2023, 11, 25, 13, 54, 55, 571, DateTimeKind.Local).AddTicks(4430), "DucTri_Bui@yahoo.com", "0907583006" },
                    { 17, "Lâm Đồng", "Ái Linh Đoàn", new DateTime(2023, 11, 25, 13, 54, 55, 571, DateTimeKind.Local).AddTicks(4492), "ThaiDuong.Mai14@hotmail.com", "0909848853" },
                    { 18, "Vĩnh Phúc", "Ngọc Ánh Bùi", new DateTime(2023, 11, 25, 13, 54, 55, 571, DateTimeKind.Local).AddTicks(4569), "HuuThuc77@hotmail.com", "0952878642" },
                    { 19, "Cần Thơ", "Quốc Hoài Đào", new DateTime(2023, 11, 25, 13, 54, 55, 571, DateTimeKind.Local).AddTicks(4636), "QuocQuan_Hoang10@hotmail.com", "0909423617" },
                    { 20, "Gia Lai", "Phương Lan Mai", new DateTime(2023, 11, 25, 13, 54, 55, 571, DateTimeKind.Local).AddTicks(4709), "QuynhHuong26@yahoo.com", "0969288097" },
                    { 21, "Bắc Ninh", "Quảng Ðại Trần", new DateTime(2023, 11, 25, 13, 54, 55, 571, DateTimeKind.Local).AddTicks(4774), "MaiLy_Ngo33@yahoo.com", "0930870539" },
                    { 22, "Lào Cai", "Minh Dũng Phùng", new DateTime(2023, 11, 25, 13, 54, 55, 571, DateTimeKind.Local).AddTicks(4840), "MinhNhu.Ngo97@hotmail.com", "0970250556" },
                    { 23, "Tuyên Quang", "Minh Hà Phùng", new DateTime(2023, 11, 25, 13, 54, 55, 571, DateTimeKind.Local).AddTicks(4909), "AnhHoa_To73@gmail.com", "0918700030" },
                    { 24, "Đồng Tháp", "Xuân Nghi Lê", new DateTime(2023, 11, 25, 13, 54, 55, 571, DateTimeKind.Local).AddTicks(4976), "HoaHop3@yahoo.com", "0932923578" },
                    { 25, "Bắc Ninh", "Bích Ngà Lâm", new DateTime(2023, 11, 25, 13, 54, 55, 571, DateTimeKind.Local).AddTicks(5043), "PhuongTien98@hotmail.com", "0922530367" },
                    { 26, "Lạng Sơn", "Công Lộc Phan", new DateTime(2023, 11, 25, 13, 54, 55, 571, DateTimeKind.Local).AddTicks(5113), "DiemKhue.Lam60@gmail.com", "0970759906" },
                    { 27, "Phú Yên", "Thường Kiệt Hoàng", new DateTime(2023, 11, 25, 13, 54, 55, 571, DateTimeKind.Local).AddTicks(5180), "YenDan_Tang@hotmail.com", "0927162548" },
                    { 28, "Cao Bằng", "Ngọc Huyền Trịnh", new DateTime(2023, 11, 25, 13, 54, 55, 571, DateTimeKind.Local).AddTicks(5251), "TuanAnh26@yahoo.com", "0933381785" },
                    { 29, "Khánh Hoà", "Ðan Quỳnh Lý", new DateTime(2023, 11, 25, 13, 54, 55, 571, DateTimeKind.Local).AddTicks(5321), "TriMinh_Trinh@yahoo.com", "0999501661" },
                    { 30, "Tuyên Quang", "Trung Kiên Phạm", new DateTime(2023, 11, 25, 13, 54, 55, 571, DateTimeKind.Local).AddTicks(5387), "ThienThanh67@gmail.com", "0963366816" },
                    { 31, "Gia Lai", "Huy Khiêm Hà", new DateTime(2023, 11, 25, 13, 54, 55, 571, DateTimeKind.Local).AddTicks(5457), "TuyetVy.Vuong@gmail.com", "0979076474" },
                    { 32, "Thái Nguyên", "Hồng Ngân Mai", new DateTime(2023, 11, 25, 13, 54, 55, 571, DateTimeKind.Local).AddTicks(5525), "DucPhong.Mai81@yahoo.com", "0953125875" },
                    { 33, "Cà Mau", "Nhật Quang Đỗ", new DateTime(2023, 11, 25, 13, 54, 55, 571, DateTimeKind.Local).AddTicks(5593), "PhiPhi_Lam@hotmail.com", "0944103773" },
                    { 34, "Bắc Giang", "Minh Sơn Đặng", new DateTime(2023, 11, 25, 13, 54, 55, 571, DateTimeKind.Local).AddTicks(5653), "ThuyLinh_Tran66@gmail.com", "0954939726" },
                    { 35, "Quảng Ninh", "Thu Sương Phan", new DateTime(2023, 11, 25, 13, 54, 55, 571, DateTimeKind.Local).AddTicks(5730), "ThuongKhang_Tran@hotmail.com", "0972356952" },
                    { 36, "Điện Biên", "Linh Giang Hoàng", new DateTime(2023, 11, 25, 13, 54, 55, 571, DateTimeKind.Local).AddTicks(5803), "HongLien56@hotmail.com", "0989374389" },
                    { 37, "Hà Nam", "Lan Khuê Trương", new DateTime(2023, 11, 25, 13, 54, 55, 571, DateTimeKind.Local).AddTicks(5879), "ThuyHa58@yahoo.com", "0974188791" },
                    { 38, "Lạng Sơn", "Anh Chi Đặng", new DateTime(2023, 11, 25, 13, 54, 55, 571, DateTimeKind.Local).AddTicks(5948), "GiangThien82@yahoo.com", "0991377287" },
                    { 39, "Tiền Giang", "Bích Ngọc Bùi", new DateTime(2023, 11, 25, 13, 54, 55, 571, DateTimeKind.Local).AddTicks(6011), "KhanhVi30@gmail.com", "0976854607" },
                    { 40, "Hải Phòng", "Tùng Châu Vũ", new DateTime(2023, 11, 25, 13, 54, 55, 571, DateTimeKind.Local).AddTicks(6077), "HoangKhai_Truong80@gmail.com", "0974932159" },
                    { 41, "Thái Bình", "Sơn Hải Hoàng", new DateTime(2023, 11, 25, 13, 54, 55, 571, DateTimeKind.Local).AddTicks(6147), "ThuVong31@yahoo.com", "0907073080" },
                    { 42, "TP. Hồ Chí Minh", "Chính Trực Vương", new DateTime(2023, 11, 25, 13, 54, 55, 571, DateTimeKind.Local).AddTicks(6222), "DangDat.Vu69@yahoo.com", "0933721606" },
                    { 43, "Bắc Kạn", "Diệu Thiện Trương", new DateTime(2023, 11, 25, 13, 54, 55, 571, DateTimeKind.Local).AddTicks(6286), "PhuongLien.Dinh@yahoo.com", "0912643330" },
                    { 44, "Đắk Nông", "Phương Trinh Hà", new DateTime(2023, 11, 25, 13, 54, 55, 571, DateTimeKind.Local).AddTicks(6360), "NhuThao_Doan58@gmail.com", "0959096820" },
                    { 45, "Cà Mau", "Xuân Nương Đào", new DateTime(2023, 11, 25, 13, 54, 55, 571, DateTimeKind.Local).AddTicks(6427), "MinhHuyen_Bui46@yahoo.com", "0921835115" },
                    { 46, "Đắk Lắk", "Vân Sơn Đặng", new DateTime(2023, 11, 25, 13, 54, 55, 571, DateTimeKind.Local).AddTicks(6496), "HungAnh82@yahoo.com", "0921104894" },
                    { 47, "Điện Biên", "Từ Ðông Lý", new DateTime(2023, 11, 25, 13, 54, 55, 571, DateTimeKind.Local).AddTicks(6562), "VietAnh_Ngo@hotmail.com", "0915603603" },
                    { 48, "Hà Tĩnh", "Hoài Nam Đào", new DateTime(2023, 11, 25, 13, 54, 55, 571, DateTimeKind.Local).AddTicks(6624), "ThanhThe_Lam67@hotmail.com", "0955200288" },
                    { 49, "Hà Giang", "Quyết Thắng Hoàng", new DateTime(2023, 11, 25, 13, 54, 55, 571, DateTimeKind.Local).AddTicks(6692), "TuongPhat67@yahoo.com", "0958556054" },
                    { 50, "Quảng Bình", "Xuân Hàm Trần", new DateTime(2023, 11, 25, 13, 54, 55, 571, DateTimeKind.Local).AddTicks(6755), "YenPhuong.Bui@gmail.com", "0971321788" },
                    { 51, "Đồng Tháp", "Phong Lan Trịnh", new DateTime(2023, 11, 25, 13, 54, 55, 571, DateTimeKind.Local).AddTicks(6823), "TinhYen.Pham@hotmail.com", "0965613053" },
                    { 52, "Đồng Nai", "Diệu Lan Dương", new DateTime(2023, 11, 25, 13, 54, 55, 571, DateTimeKind.Local).AddTicks(6885), "PhuongNam.Phung@hotmail.com", "0940204762" },
                    { 53, "Hậu Giang", "Thanh Vũ Trần", new DateTime(2023, 11, 25, 13, 54, 55, 571, DateTimeKind.Local).AddTicks(6955), "HoangXuan_Phan4@yahoo.com", "0902813563" },
                    { 54, "Hà Tĩnh", "Thường Kiệt Mai", new DateTime(2023, 11, 25, 13, 54, 55, 571, DateTimeKind.Local).AddTicks(7020), "CamHanh75@hotmail.com", "0989315852" },
                    { 55, "Lai Châu", "Khánh Quyên Trương", new DateTime(2023, 11, 25, 13, 54, 55, 571, DateTimeKind.Local).AddTicks(7085), "TrucLoan_Mai10@yahoo.com", "0976776174" },
                    { 56, "Hải Phòng", "Chính Tâm Dương", new DateTime(2023, 11, 25, 13, 54, 55, 571, DateTimeKind.Local).AddTicks(7177), "AnhTu95@hotmail.com", "0980615322" },
                    { 57, "Đắk Nông", "Thiên Ðức Tô", new DateTime(2023, 11, 25, 13, 54, 55, 571, DateTimeKind.Local).AddTicks(7291), "NgocDao98@yahoo.com", "0968462496" },
                    { 58, "Đồng Tháp", "Ðình Ðôn Trịnh", new DateTime(2023, 11, 25, 13, 54, 55, 571, DateTimeKind.Local).AddTicks(7386), "KimXuyen_Vu89@yahoo.com", "0906557509" },
                    { 59, "Hậu Giang", "Kiên Cường Đào", new DateTime(2023, 11, 25, 13, 54, 55, 571, DateTimeKind.Local).AddTicks(7450), "ThuyAnh23@hotmail.com", "0986573924" },
                    { 60, "Cần Thơ", "An Bình Vũ", new DateTime(2023, 11, 25, 13, 54, 55, 571, DateTimeKind.Local).AddTicks(7521), "DuyThanh54@yahoo.com", "0907730331" },
                    { 61, "Bình Dương", "Cẩm Thúy Đặng", new DateTime(2023, 11, 25, 13, 54, 55, 571, DateTimeKind.Local).AddTicks(7584), "ThuyTam_Ngo13@hotmail.com", "0971727597" },
                    { 62, "Hà Tĩnh", "Ðan Quế Lê", new DateTime(2023, 11, 25, 13, 54, 55, 571, DateTimeKind.Local).AddTicks(7649), "TienHiep.Bui@yahoo.com", "0946904433" },
                    { 63, "Nghệ An", "Cẩm Linh Ngô", new DateTime(2023, 11, 25, 13, 54, 55, 571, DateTimeKind.Local).AddTicks(7713), "HaoNhien.Phung76@yahoo.com", "0994681127" },
                    { 64, "Quảng Trị", "Thiên Ðức Vũ", new DateTime(2023, 11, 25, 13, 54, 55, 571, DateTimeKind.Local).AddTicks(7784), "NamAn73@hotmail.com", "0956158352" },
                    { 65, "Tây Ninh", "Nhật Quân Trịnh", new DateTime(2023, 11, 25, 13, 54, 55, 571, DateTimeKind.Local).AddTicks(7842), "DongSon_Ngo@yahoo.com", "0907353823" },
                    { 66, "Quảng Ngãi", "Thiện Luân Đoàn", new DateTime(2023, 11, 25, 13, 54, 55, 571, DateTimeKind.Local).AddTicks(7914), "KyDuyen29@yahoo.com", "0958684495" },
                    { 67, "Thanh Hoá", "Ðắc Trọng Hà", new DateTime(2023, 11, 25, 13, 54, 55, 571, DateTimeKind.Local).AddTicks(7976), "TrucQuynh_Dang92@yahoo.com", "0963824032" },
                    { 68, "Gia Lai", "Thiếu Mai Đoàn", new DateTime(2023, 11, 25, 13, 54, 55, 571, DateTimeKind.Local).AddTicks(8044), "NhuMai6@gmail.com", "0987143001" },
                    { 69, "Bắc Kạn", "Quốc Thiện Đinh", new DateTime(2023, 11, 25, 13, 54, 55, 571, DateTimeKind.Local).AddTicks(8108), "HuyKhiem.Phung7@hotmail.com", "0946712003" },
                    { 70, "Lạng Sơn", "Hồng Đăng Lý", new DateTime(2023, 11, 25, 13, 54, 55, 571, DateTimeKind.Local).AddTicks(8176), "TuyetVan_Phung@hotmail.com", "0919290687" },
                    { 71, "Quảng Bình", "Diệu Ái Hồ", new DateTime(2023, 11, 25, 13, 54, 55, 571, DateTimeKind.Local).AddTicks(8244), "CongHau.To87@yahoo.com", "0974102126" },
                    { 72, "Tiền Giang", "Minh Đan Tô", new DateTime(2023, 11, 25, 13, 54, 55, 571, DateTimeKind.Local).AddTicks(8309), "AnhTung_Vu73@gmail.com", "0960571061" },
                    { 73, "Sơn La", "Hiếu Minh Hồ", new DateTime(2023, 11, 25, 13, 54, 55, 571, DateTimeKind.Local).AddTicks(8377), "ThuyVan.Nguyen42@hotmail.com", "0907415925" },
                    { 74, "Thái Nguyên", "Quang Dũng Lê", new DateTime(2023, 11, 25, 13, 54, 55, 571, DateTimeKind.Local).AddTicks(8444), "BachTra_Hoang24@hotmail.com", "0907892818" },
                    { 75, "Tây Ninh", "Xuân Hiếu Lý", new DateTime(2023, 11, 25, 13, 54, 55, 571, DateTimeKind.Local).AddTicks(8518), "AnhXuan_Pham@yahoo.com", "0928072206" },
                    { 76, "Nam Định", "Thanh Lan Nguyễn", new DateTime(2023, 11, 25, 13, 54, 55, 571, DateTimeKind.Local).AddTicks(8581), "TrucPhuong84@hotmail.com", "0905645359" },
                    { 77, "Bà Rịa-Vũng Tàu", "Ngọc Nhi Lâm", new DateTime(2023, 11, 25, 13, 54, 55, 571, DateTimeKind.Local).AddTicks(8650), "ThieuMai_Dang@yahoo.com", "0907705207" },
                    { 78, "Cần Thơ", "Xuân Nương Lê", new DateTime(2023, 11, 25, 13, 54, 55, 571, DateTimeKind.Local).AddTicks(8715), "TuyetAnh24@hotmail.com", "0976477313" },
                    { 79, "Đắk Lắk", "Hương Thủy Đỗ", new DateTime(2023, 11, 25, 13, 54, 55, 571, DateTimeKind.Local).AddTicks(8783), "NgocCanh_Hoang71@gmail.com", "0915434632" },
                    { 80, "Bến Tre", "Lam Phương Lâm", new DateTime(2023, 11, 25, 13, 54, 55, 571, DateTimeKind.Local).AddTicks(8856), "ThienTrang16@hotmail.com", "0986527562" },
                    { 81, "Ninh Bình", "Quỳnh Ngân Phan", new DateTime(2023, 11, 25, 13, 54, 55, 571, DateTimeKind.Local).AddTicks(8923), "HaiAn_Nguyen95@hotmail.com", "0908412982" },
                    { 82, "Tây Ninh", "Quốc Quý Dương", new DateTime(2023, 11, 25, 13, 54, 55, 571, DateTimeKind.Local).AddTicks(8995), "DinhHuong.Ha11@hotmail.com", "0917194070" },
                    { 83, "Thái Nguyên", "Tố Uyên Phạm", new DateTime(2023, 11, 25, 13, 54, 55, 571, DateTimeKind.Local).AddTicks(9059), "HueAn_Ha93@yahoo.com", "0976717075" },
                    { 84, "Tây Ninh", "Hữu Canh Trần", new DateTime(2023, 11, 25, 13, 54, 55, 571, DateTimeKind.Local).AddTicks(9124), "VietChinh10@hotmail.com", "0912096966" },
                    { 85, "Đồng Nai", "Minh Thư Lê", new DateTime(2023, 11, 25, 13, 54, 55, 571, DateTimeKind.Local).AddTicks(9190), "ThienTrang.Dao@hotmail.com", "0972384954" },
                    { 86, "Long An", "Huy Hà Trần", new DateTime(2023, 11, 25, 13, 54, 55, 571, DateTimeKind.Local).AddTicks(9258), "ThongTue81@gmail.com", "0958390919" },
                    { 87, "TP. Hồ Chí Minh", "Yên Đan Phan", new DateTime(2023, 11, 25, 13, 54, 55, 571, DateTimeKind.Local).AddTicks(9324), "ThuNguyet.Nguyen37@yahoo.com", "0958311630" },
                    { 88, "Hải Dương", "Kim Thanh Đỗ", new DateTime(2023, 11, 25, 13, 54, 55, 571, DateTimeKind.Local).AddTicks(9400), "MinhThu.Phan34@gmail.com", "0920501921" },
                    { 89, "Điện Biên", "Tường Anh Tô", new DateTime(2023, 11, 25, 13, 54, 55, 571, DateTimeKind.Local).AddTicks(9468), "TrongHung69@yahoo.com", "0932342674" },
                    { 90, "Ninh Thuận", "Hồng Giang Trương", new DateTime(2023, 11, 25, 13, 54, 55, 571, DateTimeKind.Local).AddTicks(9529), "ThuyDao.Vu96@hotmail.com", "0940372258" },
                    { 91, "Đắk Lắk", "Duy Kính Ngô", new DateTime(2023, 11, 25, 13, 54, 55, 571, DateTimeKind.Local).AddTicks(9599), "HanhThao.Dinh@yahoo.com", "0980678775" },
                    { 92, "Bà Rịa-Vũng Tàu", "Thanh Thanh Phan", new DateTime(2023, 11, 25, 13, 54, 55, 571, DateTimeKind.Local).AddTicks(9666), "ThanhTung.Le@yahoo.com", "0912317834" },
                    { 93, "Bà Rịa-Vũng Tàu", "Quế Anh Đỗ", new DateTime(2023, 11, 25, 13, 54, 55, 571, DateTimeKind.Local).AddTicks(9735), "NgocTram_Phung82@hotmail.com", "0979645757" },
                    { 94, "Cao Bằng", "Sỹ Phú Trịnh", new DateTime(2023, 11, 25, 13, 54, 55, 571, DateTimeKind.Local).AddTicks(9803), "TichThien.Ho@hotmail.com", "0917826188" },
                    { 95, "Phú Yên", "Khoa Trưởng Nguyễn", new DateTime(2023, 11, 25, 13, 54, 55, 571, DateTimeKind.Local).AddTicks(9871), "KhaiTam_Ngo@hotmail.com", "0962910910" },
                    { 96, "Lai Châu", "Thanh Vinh Vũ", new DateTime(2023, 11, 25, 13, 54, 55, 571, DateTimeKind.Local).AddTicks(9932), "KhanhMinh_Dao12@hotmail.com", "0955466482" },
                    { 97, "Bình Dương", "Nhật Lan Trần", new DateTime(2023, 11, 25, 13, 54, 55, 572, DateTimeKind.Local).AddTicks(1), "AnhHong.Ngo95@yahoo.com", "0934257650" },
                    { 98, "Đà Nẵng", "Tuyết Nhung Vũ", new DateTime(2023, 11, 25, 13, 54, 55, 572, DateTimeKind.Local).AddTicks(63), "HongTam16@hotmail.com", "0924281808" },
                    { 99, "Hà Giang", "Uyên Phương Lê", new DateTime(2023, 11, 25, 13, 54, 55, 572, DateTimeKind.Local).AddTicks(126), "PhuongHanh.Nguyen72@hotmail.com", "0927797613" },
                    { 100, "Cà Mau", "Hương Thủy Trịnh", new DateTime(2023, 11, 25, 13, 54, 55, 572, DateTimeKind.Local).AddTicks(202), "QuangVu70@gmail.com", "0925993529" }
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
                table: "Providers",
                columns: new[] { "ProviderID", "Address", "Email", "Phone", "ProviderName" },
                values: new object[,]
                {
                    { 1, "Hải Phòng", "LinhDan_Duong43@gmail.com", "0999729115", "Thu Ngọc Đặng" },
                    { 2, "Bắc Kạn", "KimChi64@gmail.com", "0943534392", "Anh Mai Phan" },
                    { 3, "Sơn La", "SongLam.Vuong22@hotmail.com", "0954473627", "Nhất Tiến Phạm" },
                    { 4, "Lào Cai", "ChiDung48@yahoo.com", "0917526608", "Quang Huy Bùi" },
                    { 5, "Bình Thuận", "VienThong.Ngo@hotmail.com", "0971048631", "Quang Hưng Hồ" },
                    { 6, "Hà Nội", "ThaiNguyen26@gmail.com", "0938503345", "Hương Nhi Trịnh" },
                    { 7, "Bắc Ninh", "KimThong.Truong63@gmail.com", "0922767500", "Xuân Hàm Đoàn" },
                    { 8, "Cà Mau", "ThienTinh.Ha20@gmail.com", "0939805101", "Trà My Lâm" },
                    { 9, "Trà Vinh", "ThuyHanh_Ho74@gmail.com", "0985511338", "Xuân Hàm Tăng" },
                    { 10, "Nam Định", "NgocMai38@yahoo.com", "0998740103", "Quang Trọng Đặng" },
                    { 11, "Vĩnh Phúc", "XuanLieu81@gmail.com", "0988998304", "Xuân Trường Lê" },
                    { 12, "Tiền Giang", "ThuyMinh.Pham@yahoo.com", "0907011738", "Duy Hạnh Hà" },
                    { 13, "Lào Cai", "DongSon.Dinh79@hotmail.com", "0994144301", "Trâm Anh Hà" },
                    { 14, "Quảng Nam", "PhuongVu.Phung@yahoo.com", "0952088976", "Ân Thiện Lý" },
                    { 15, "Điện Biên", "BaoVy_Vu20@gmail.com", "0936011904", "Minh Huấn Lê" },
                    { 16, "Bắc Ninh", "HuuHoang46@yahoo.com", "0985536120", "Phượng Long Lâm" },
                    { 17, "Đồng Nai", "ThuNhien85@gmail.com", "0915973058", "Uyển Nhã Tô" },
                    { 18, "Cần Thơ", "NhaHuong.Vu44@yahoo.com", "0939900510", "Hải Ngân Lê" },
                    { 19, "Gia Lai", "XuanThuy_Dao@hotmail.com", "0931549444", "Vương Triệu Trần" },
                    { 20, "Bình Dương", "PhongChau.Ngo@hotmail.com", "0953800307", "Nhật Lan Tăng" },
                    { 21, "Quảng Ngãi", "TheNang_Dang57@gmail.com", "0941087067", "Ngọc Khuê Tăng" },
                    { 22, "Gia Lai", "PhuongMai.Dang72@yahoo.com", "0941175595", "Tuấn Hải Mai" },
                    { 23, "Yên Bái", "ThanhChau.Pham@yahoo.com", "0942519778", "Trường Sa Hoàng" },
                    { 24, "Đồng Nai", "DanhThanh23@hotmail.com", "0949706968", "Khánh Nam Hà" },
                    { 25, "Đồng Nai", "CongPhung_Trinh95@yahoo.com", "0955040785", "Quỳnh Như Vương" },
                    { 26, "Phú Yên", "CatUy_Phan@hotmail.com", "0950392881", "Bích Hồng Đào" },
                    { 27, "Tuyên Quang", "ChanPhong_Lam83@yahoo.com", "0951665287", "Diễm Trinh Trương" },
                    { 28, "Tiền Giang", "ChiSon5@gmail.com", "0977594595", "Thu Yến Dương" },
                    { 29, "Hòa Bình", "HanLam90@gmail.com", "0978424564", "Ái Nhân Lý" },
                    { 30, "Yên Bái", "NgocLan_Dao@yahoo.com", "0973722857", "Kim Thịnh Ngô" },
                    { 31, "Quảng Bình", "QuocThien_To@hotmail.com", "0918910236", "Thiện Ðức Trần" },
                    { 32, "Cao Bằng", "KyDuyen68@yahoo.com", "0941534077", "Tuấn Kiệt Trần" },
                    { 33, "Lai Châu", "CatLinh98@yahoo.com", "0935077099", "Hiền Thục Phạm" },
                    { 34, "Lai Châu", "MinhMan_Truong@gmail.com", "0935650194", "Phước Huệ Đỗ" },
                    { 35, "Bạc Liêu", "XuanHuong_Phan89@hotmail.com", "0929752847", "Trúc Lâm Trương" },
                    { 36, "Đồng Tháp", "ThaoHuong.Dang@yahoo.com", "0968825400", "Xuân Hòa Mai" },
                    { 37, "Bắc Giang", "PhucNguyen18@hotmail.com", "0930538036", "Thu Liên Hoàng" },
                    { 38, "Hưng Yên", "TruongSon.Pham1@gmail.com", "0982366602", "Mộng Thu Phùng" },
                    { 39, "Ninh Bình", "HaiSon_Pham15@gmail.com", "0986822009", "Tịnh Lâm Lê" },
                    { 40, "Lào Cai", "ThaoVy_Bui3@yahoo.com", "0930516724", "Việt Thông Phạm" },
                    { 41, "An Giang", "PhuongLien_Ha@yahoo.com", "0969128611", "Vũ Minh Đào" },
                    { 42, "Long An", "HoaiPhuong87@hotmail.com", "0965784594", "Tùng Châu Vương" },
                    { 43, "Gia Lai", "MinhUyen15@yahoo.com", "0932591913", "Minh Nguyệt Dương" },
                    { 44, "Lào Cai", "SongHuong_Duong58@yahoo.com", "0955444713", "Minh Khuê Trịnh" },
                    { 45, "Thái Bình", "NhatMai.Mai@gmail.com", "0956313006", "Tuấn Kiệt Phan" },
                    { 46, "Nghệ An", "DinhHao46@hotmail.com", "0943340126", "Ðức Trí Ngô" },
                    { 47, "Hòa Bình", "NghiLuc73@gmail.com", "0948681115", "Trúc Liên Lê" },
                    { 48, "Hải Dương", "MinhTrieu_Doan0@hotmail.com", "0964671391", "Xuân Thiện Hà" },
                    { 49, "Cà Mau", "HiepHien_Ha@gmail.com", "0949593713", "Minh Nguyệt Trần" },
                    { 50, "Hải Dương", "BachKim.Phan@hotmail.com", "0965551943", "Minh Trí Mai" },
                    { 51, "Cà Mau", "HienHoa13@hotmail.com", "0901891205", "Thùy My Bùi" },
                    { 52, "Yên Bái", "TuongPhat.Nguyen@yahoo.com", "0998951016", "Lam Phương Tô" },
                    { 53, "Đà Nẵng", "TrungNhan.Le61@yahoo.com", "0977196392", "Ngọc Ly Đinh" },
                    { 54, "Thái Nguyên", "NgocKhang93@hotmail.com", "0909747143", "Hoàng Quân Vương" },
                    { 55, "Nam Định", "ManhQuynh.To11@hotmail.com", "0961326272", "Trọng Tường Vũ" },
                    { 56, "Cà Mau", "VangAnh65@hotmail.com", "0999051721", "Sỹ Hoàng Trần" },
                    { 57, "Bà Rịa-Vũng Tàu", "HoaMi_Dinh@hotmail.com", "0942801605", "Lam Giang Tăng" },
                    { 58, "Hà Nam", "UyenNha_Ho@hotmail.com", "0916261633", "An Di Hoàng" },
                    { 59, "Hưng Yên", "BanMai_Le8@hotmail.com", "0947391512", "Kim Khuyên Phan" },
                    { 60, "Vĩnh Long", "LamGiang_Do73@hotmail.com", "0902915318", "Cát Tường Trịnh" },
                    { 61, "Trà Vinh", "NgocQuynh.Nguyen59@gmail.com", "0944933369", "Trung Chính Đào" },
                    { 62, "Thái Nguyên", "VinhLong11@gmail.com", "0924889539", "Tố Nga Đoàn" },
                    { 63, "Bắc Giang", "NgocYen_Truong@gmail.com", "0925054105", "Ðình Thiện Ngô" },
                    { 64, "Yên Bái", "CaoSon.Vuong33@hotmail.com", "0966938567", "Mỹ Huệ Phùng" },
                    { 65, "Điện Biên", "VanAnh.Truong21@hotmail.com", "0974451317", "Quang Linh Tô" },
                    { 66, "Lào Cai", "VietSon_Vuong47@yahoo.com", "0967174727", "Yên Đan Phạm" },
                    { 67, "Yên Bái", "TuanKiet.Do89@yahoo.com", "0942661682", "Hoài An Lâm" },
                    { 68, "Vĩnh Long", "NhatBaoLong42@yahoo.com", "0965457637", "Lâm Viên Vũ" },
                    { 69, "Gia Lai", "QuynhHoa_Phan12@gmail.com", "0904472911", "Ngọc Khuê Đào" },
                    { 70, "Phú Yên", "HoangHa.Vuong12@gmail.com", "0962346992", "Cẩm Ly Lý" },
                    { 71, "Bình Dương", "HoangCuc_Nguyen@yahoo.com", "0918453614", "Xuân Hương Mai" },
                    { 72, "Đồng Nai", "GiaNhi_Tang21@hotmail.com", "0973195074", "Hoạ Mi Lâm" },
                    { 73, "Ninh Thuận", "ThucAnh4@gmail.com", "0974745285", "Khánh Ly Vũ" },
                    { 74, "Quảng Trị", "TruongVinh_Vuong@yahoo.com", "0962342562", "Nguyên Bảo Vương" },
                    { 75, "Ninh Bình", "VanSon_Phung25@gmail.com", "0980951617", "Ðắc Thái Vũ" },
                    { 76, "Thừa Thiên-Huế", "MinhDan65@gmail.com", "0982091531", "Ngọc Cầm Vương" },
                    { 77, "Bến Tre", "NhuHong.Bui@gmail.com", "0944546907", "Giáng Uyên Hồ" },
                    { 78, "Ninh Thuận", "ThuPhuong3@yahoo.com", "0972288946", "Bảo Pháp Dương" },
                    { 79, "Lai Châu", "TinhTam_Tang91@hotmail.com", "0908749316", "Diệu Linh Ngô" },
                    { 80, "Tây Ninh", "ThaoLy79@yahoo.com", "0993887306", "Kim Sa Tô" },
                    { 81, "Hà Giang", "HueAn_Dang49@gmail.com", "0910412313", "Vân Thúy Đoàn" },
                    { 82, "Quảng Ngãi", "CamLien18@yahoo.com", "0957042888", "Phương Triều Phạm" },
                    { 83, "Trà Vinh", "TuyenLam.Truong24@hotmail.com", "0938644366", "Thảo Nhi Hà" },
                    { 84, "Bắc Ninh", "ThuyMy.Do76@hotmail.com", "0928034357", "Phương Uyên Lý" },
                    { 85, "Long An", "CongHoan8@yahoo.com", "0984913876", "Mỹ Lan Trịnh" },
                    { 86, "Khánh Hoà", "TuyetNhi77@gmail.com", "0942570839", "Phượng Bích Phan" },
                    { 87, "Thanh Hoá", "TuongVy68@hotmail.com", "0953832532", "Phương Thanh Đinh" },
                    { 88, "Quảng Ngãi", "LamVu.Vu@yahoo.com", "0984787322", "Đan Thư Vũ" },
                    { 89, "Đắk Lắk", "VietThanh13@gmail.com", "0947267770", "Anh Tùng Trịnh" },
                    { 90, "Cà Mau", "DongSon.Phan8@gmail.com", "0939418553", "Minh Ðạt Nguyễn" },
                    { 91, "Hà Tĩnh", "NhanTu12@gmail.com", "0982638330", "Anh Khoa Đào" },
                    { 92, "Lai Châu", "VyLan.Vuong@yahoo.com", "0917798494", "Hồng Khanh Phùng" },
                    { 93, "Khánh Hoà", "ThaoMai12@hotmail.com", "0926309070", "Thiện Giang Hồ" },
                    { 94, "Hà Nội", "TamLinh.Phung@yahoo.com", "0947760582", "Yến Hồng Lê" },
                    { 95, "Lào Cai", "BaoTin.Truong@gmail.com", "0961432801", "Thông Ðạt Mai" },
                    { 96, "Bắc Giang", "HanhMy_Dinh0@hotmail.com", "0916931069", "Phương Hoa Đinh" },
                    { 97, "Quảng Trị", "ThaiThao_Tang41@hotmail.com", "0931796722", "Anh Mai Trương" },
                    { 98, "Quảng Ninh", "DangMinh_Ho@yahoo.com", "0971955829", "Bảo Trâm Vũ" },
                    { 99, "Quảng Trị", "LienKiet_Phan85@yahoo.com", "0969502491", "Lệ Thu Tô" },
                    { 100, "Lâm Đồng", "TriHao.Truong@yahoo.com", "0932767332", "Minh Thắng Đặng" }
                });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "RoleID",
                keyValue: 1,
                columns: new[] { "DateCreated", "RoleName" },
                values: new object[] { new DateTime(2023, 11, 25, 13, 54, 55, 569, DateTimeKind.Local).AddTicks(5359), "Nhân viên bán hàng" });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleID", "DateCreated", "Description", "PermissionID", "RoleName" },
                values: new object[] { 2, new DateTime(2023, 11, 25, 13, 54, 55, 569, DateTimeKind.Local).AddTicks(5373), null, 2, "Nhân viên nhập hàng" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                keyValue: 3);

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
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 8);

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
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 16);

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
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 22);

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
                keyValue: 29);

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
                keyValue: 32);

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
                keyValue: 37);

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
                keyValue: 40);

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
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 64);

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
                keyValue: 82);

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
                keyValue: 87);

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
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 94);

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
                table: "Customer",
                keyColumn: "CustomerID",
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
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 6);

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
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 11);

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
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 17);

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
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 25);

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
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 30);

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
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 35);

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
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 39);

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
                keyValue: 45);

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
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 49);

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
                keyValue: 52);

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
                keyValue: 65);

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
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 70);

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
                keyValue: 73);

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
                keyValue: 85);

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
                keyValue: 90);

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
                keyValue: 93);

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
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumn: "RoleID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 2);

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

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
        }
    }
}
