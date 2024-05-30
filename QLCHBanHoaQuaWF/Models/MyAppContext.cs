using Bogus;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using QLCHWF.Presenters;
using System.Configuration;
using QLCHWF.Helpers;

namespace QLCHWF.Models
{
    public partial class MyAppContext : DbContext
    {
        private readonly IConfiguration _configuration;
        public MyAppContext()
        {
            //Database.Migrate();
        }
        public MyAppContext(DbContextOptions<MyAppContext> optionsBuilderOptions, IConfiguration configuration) : base(optionsBuilderOptions)
        {
            _configuration = configuration;
            Database.Migrate();
        }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Provider> Providers { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserRole> UserRoles { get; set; }
        public virtual DbSet<Permission> Permissions { get; set; }
        public virtual DbSet<ImportOrder> ImportOrders { get; set; }
        public virtual DbSet<SalesOrder> SalesOrders { get; set; }
        public virtual DbSet<DetailImportOrder> DetailImportOrders { get; set; }
        public virtual DbSet<DetailSalesOrder> DetailSalesOrders { get; set; }
        public virtual DbSet<AppInfo> AppInfos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(
                "Data Source=.;Initial Catalog=QLCHBanHoaQua;Integrated Security=True;TrustServerCertificate=True").UseLazyLoadingProxies();
            //optionsBuilder.UseSqlServer(_configuration.GetConnectionString("SqlServer"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Config Fluent Api
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasIndex(e => e.Email).IsUnique();
            });
            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => new { e.EmployeeID, e.Email });
                entity.HasIndex(e => e.Email).IsUnique();
            });
            modelBuilder.Entity<DetailSalesOrder>(entity =>
            {
                entity.HasKey(e => new { e.OrderID, e.ProductID });
            });
            modelBuilder.Entity<DetailImportOrder>(entity =>
            {
                entity.HasKey(e => new { e.OrderID, e.ProductID });
            });
            // Set default role
            modelBuilder.Entity<UserRole>(entity =>
            {
                entity.HasIndex(e => e.RoleName).IsUnique();
                entity.HasData(
                    new UserRole
                    {
                        RoleID = 1,
                        RoleName = "Nhân viên bán hàng",
                        PermissionID = 1

                    },
                    new UserRole
                    {
                        RoleID = 2,
                        RoleName = "Nhân viên nhập hàng",
                        PermissionID = 2
                    }
                );
            });
            modelBuilder.Entity<Permission>(entity =>
            {
                entity.HasOne(p => p.UserRole)
                    .WithOne(u => u.Permission)
                    .HasForeignKey<UserRole>(u => u.PermissionID)
                    .OnDelete(DeleteBehavior.Cascade);
                entity.HasData(
                    new Permission
                    {
                        PermissionID = 1,
                        CanCreateCustomer = true,
                        CanUpdateCustomer = true,
                        CanDeleteCustomer = true,
                        CanReadCustomer = true,
                        CanReadDetailSalesOrder = true,
                        CanReadSalesOrder = true,
                        CanCreateSalesOrder = true,
                        CanExportSalesOrder = true,
                        CanPrintSalesOrder = true,
                        CanReadProduct = true,
                        CanCreateProduct = true,
                        CanUpdateProduct = true,
                        CanDeleteProduct = true
                    },
                    new Permission
                    {
                        PermissionID = 2,
                        CanCreatedProvider = true,
                        CanUpdateProvider= true,
                        CanDeleteProvider = true,
                        CanReadProvider = true,
                        CanReadDetailImportOrder = true,
                        CanReadImportOrder = true,
                        CanCreateImportOrder = true,
                        CanExportImportOrder = true,
                        CanPrintImportOrder = true,
                        CanReadProduct = true,
                        CanCreateProduct = true,
                        CanUpdateProduct = true,
                        CanDeleteProduct = true
                    }
                );
            });
            modelBuilder.Entity<AppInfo>(entity =>
            {
                entity.HasData(
                    new AppInfo
                    {
                        AppName = "Cửa hàng của bạn",
                        Phone = "0987654321",
                        Address = "Việt Nam"
                    }
                );

            });
            //Seed Database
            List<Customer> customers = GetFakeCustomers(100);
            List<Provider> providers = GetFakeProviders(100);
            List<string> emails = GetEmailsDistinct(100);
            List<Employee> employees = GetFakeEmployees(100, emails);
            List<Product> products = GetFakeProducts(100);
            List<DetailImportOrder> detailImports = GetFakeDetailImports(100, products);
            List<DetailSalesOrder> detailSales = GetFakeDetailSales(100, products);
            for (int i = 0; i < products.Count; i++)
            {
                products[i].Inventory = detailImports[i].Quantity - detailSales[i].Quantity;
            }
            modelBuilder.Entity<Customer>().HasData(customers);
            modelBuilder.Entity<Provider>().HasData(providers);
            modelBuilder.Entity<Employee>().HasData(employees);
            modelBuilder.Entity<User>().HasData(GetFakeUsers(100, employees));
            modelBuilder.Entity<Product>().HasData(products);
            modelBuilder.Entity<ImportOrder>().HasData(GetFakeImportOrders(100, employees,providers,detailImports));
            modelBuilder.Entity<DetailImportOrder>().HasData(detailImports);
            modelBuilder.Entity<SalesOrder>().HasData(GetFakeSalesOrders(100, employees, customers, detailSales));
            modelBuilder.Entity<DetailSalesOrder>().HasData(detailSales);
        }

        private List<Customer> GetFakeCustomers(int count)
        {
            Faker<Customer> fakerCustomer = new Faker<Customer>("vi");
            fakerCustomer.RuleFor(c => c.CustomerID, f => f.IndexFaker + 1);
            fakerCustomer.RuleFor(c => c.CustomerName, f => f.Name.FullName());
            fakerCustomer.RuleFor(c => c.Email, f => f.Internet.Email());
            fakerCustomer.RuleFor(c => c.Address, f => f.Address.City());
            fakerCustomer.RuleFor(c => c.Phone, f => f.Phone.PhoneNumber("09########"));
            return fakerCustomer.Generate(count);
        }

        private List<Provider> GetFakeProviders(int count)
        {
            Faker<Provider> fakerProvider = new Faker<Provider>("vi");
            fakerProvider.RuleFor(p => p.ProviderID, f => f.IndexFaker + 1);
            fakerProvider.RuleFor(p => p.ProviderName, f => f.Name.FullName());
            fakerProvider.RuleFor(p => p.Address, f => f.Address.City());
            fakerProvider.RuleFor(p => p.Email, f => f.Internet.Email());
            fakerProvider.RuleFor(p => p.Phone, f => f.Phone.PhoneNumber("09########"));
            return fakerProvider.Generate(count);
        }

        private List<string> GetEmailsDistinct(int count)
        {
            Faker emailFaker = new Faker("vi");
            HashSet<string> emailSet = new HashSet<string>();
            while (emailSet.Count < count)
            {
                emailSet.Add(emailFaker.Internet.Email());
            }
            return emailSet.ToList();
        }

        private List<Employee> GetFakeEmployees(int count,List<string> emails)
        {
            Faker<Employee> fakerEmployee = new Faker<Employee>("vi");
            fakerEmployee.RuleFor(e => e.EmployeeID, f => f.IndexFaker + 1);
            fakerEmployee.RuleFor(e => e.Email, f => emails[f.IndexFaker]);
            fakerEmployee.RuleFor(e => e.Address, f => f.Address.City());
            fakerEmployee.RuleFor(e => e.Phone, f => f.Phone.PhoneNumber("09########"));
            fakerEmployee.RuleFor(e => e.EmployeeName, f => f.Name.FullName());
            fakerEmployee.RuleFor(e => e.Salary, f => f.Random.Decimal(500000, 1000000));
            return fakerEmployee.Generate(count);
        }

        private List<User> GetFakeUsers(int count, List<Employee> employees)
        {
            Faker<User> fakerUser = new Faker<User>("vi");
            fakerUser.RuleFor(u => u.Email, f => employees[f.IndexFaker].Email);
            fakerUser.RuleFor(u => u.EmployeeID, f => employees[f.IndexFaker].EmployeeID);
            fakerUser.RuleFor(u => u.RoleID, f => f.Random.Byte(1, 2));
            fakerUser.RuleFor(u => u.Password, f => SecurityHelper.GetSha256Hash("123456"));
            return fakerUser.Generate(count);
        }

        private List<Product> GetFakeProducts(int count)
        {
            List<string> fruits = new List<string>
            {
                "Tivi", "Máy giặt", "Tủ lạnh", "Máy sấy tóc", "Quạt điện", "Bình nóng lạnh", "Máy lọc không khí", "Bếp điện từ", "Lò vi sóng",
                "Lò nướng", "Máy xay cà phê", "Máy là", "Máy hút bụi", "Bàn ủi hơi nước", "Bàn ủi điện", "Máy sưởi dầu", "Máy sưởi hơi", 
                "Máy lọc nước", "Đèn sưởi", "Máy làm bánh", "Máy làm kem", "Máy làm mỳ", "Đèn trang trí", "Máy chiếu phim", "Điều hòa không khí",
                "Máy lạnh", "Quạt trần", "Máy tính xách tay", "Máy hút mùi", "Bếp điện đa năng", "Bàn phím điện tử", "Chuột máy tính",
                "Ổ điện thông minh", "Thiết bị kết nối Wifi", "Điện thoại di động", "Máy tính bảng", "Máy in", "Máy quét", "Máy fax",
                "Máy ảnh số", "Máy quay phim", "Máy nghe nhạc MP3", "Loa di động", "Tai nghe không dây", "Bộ sạc pin dự phòng", "Robot hút bụi", 
                "Robot lau nhà", "Bếp từ", "Máy pha trà", "Máy sấy quần áo", "Đèn chùm", "Đèn LED", "Bình siêu tốc", "Đèn bàn",
                "Đèn ngủ", "Máy rửa xe", "Nồi cơm điện", "Loa kéo", "Vòi hoa sen", "Đèn năng lượng mặt trời", "Quạt treo tường",
                "Dây điện", "Quạt đứng", "Cầu dao tự động", "Đèn sự cố chống cháy nổ", "Phích cắm 3 chân", "Công tắc Schneider", "Thiết bị điện Peha",
                "Ổ cắm Schuko", "Đèn pin", "Đèn tích điện", "Nồi áp suất điện", "Nồi nhôm Sunhouse", "Vợt muỗi", "Chảo chống dính",
                "Cửa ABS", "Cửa căn hộ", "Cửa công nghiệp", "Bình thủy điện", "Bộ nội Ceramic", "Máy phát điện", "Bình sạc",
                "Máy xay sinh tố", "Máy xay thịt", "Máy rửa chén", "Máy massage", "Máy rửa kính", "Máy tạo độ ẩm", "Máy khử mùi", "Máy đánh trứng",
                "Máy phun sương", "Máy xay đá", "Máy xay hạt cả phê", "Máy nén khí", "Máy làm mứt", "Máy ép nước mía", "Máy hút chân không",
                "Máy pha trà", "Máy đánh sữa","Máy cắt cỏ"
            };

            Faker<Product> fakerProduct = new Faker<Product>("vi");
            fakerProduct.RuleFor(p => p.ProductID, f => f.IndexFaker + 1);
            fakerProduct.RuleFor(p => p.ProductName, f => fruits[f.IndexFaker]);
            fakerProduct.RuleFor(p => p.ImportUnitPrice, f => f.Random.Decimal(10000, 50000));
            fakerProduct.RuleFor(p => p.UnitPrice, f => f.Random.Decimal(100000, 200000));
            return fakerProduct.Generate(count);
        }

        private List<ImportOrder> GetFakeImportOrders(int count, List<Employee> employees, List<Provider> providers, List<DetailImportOrder> detailImport)
        {
            Faker<ImportOrder> fakerImport = new Faker<ImportOrder>("vi");
            fakerImport.RuleFor(i => i.OrderID, f => f.IndexFaker + 1);
            fakerImport.RuleFor(i => i.EmployeeID, f => f.PickRandom(employees).EmployeeID);
            fakerImport.RuleFor(i => i.ProviderID, f => f.PickRandom(providers).ProviderID);
            fakerImport.RuleFor(i => i.TotalPrice, f => detailImport[f.IndexFaker].TotalPrice);
            fakerImport.RuleFor(i => i.OrderDate,
                f => f.Date.Between(new DateTime(2024,5 , 1), new DateTime(2024, 5, 30)));
            return fakerImport.Generate(count);
        }

        private List<DetailImportOrder> GetFakeDetailImports(int count,List<Product> products)
        {
            Faker<DetailImportOrder> fakerDetail = new Faker<DetailImportOrder>("vi");
            fakerDetail.RuleFor(d => d.OrderID, f => f.IndexFaker + 1);
            fakerDetail.RuleFor(d => d.Quantity, f => f.Random.Byte(100, 200));
            fakerDetail.RuleFor(d => d.ProductID, f => products[f.IndexFaker].ProductID);
            fakerDetail.RuleFor(d => d.UnitPrice, f => products[f.IndexFaker].ImportUnitPrice);
            return fakerDetail.Generate(count);
        }

        private List<SalesOrder> GetFakeSalesOrders(int count,List<Employee> employees,List<Customer> customers,List<DetailSalesOrder> detailSales)
        {
            Faker<SalesOrder> fakerSales = new Faker<SalesOrder>("vi");
            fakerSales.RuleFor(s => s.OrderID, f => f.IndexFaker + 1);
            fakerSales.RuleFor(s => s.EmployeeID, f => f.PickRandom(employees).EmployeeID);
            fakerSales.RuleFor(s => s.CustomerID, f => f.PickRandom(customers).CustomerID);
            fakerSales.RuleFor(s => s.TotalPrice, f => detailSales[f.IndexFaker].TotalPrice);
            fakerSales.RuleFor(s => s.PurchasePrice, f => detailSales[f.IndexFaker].TotalPrice);
            fakerSales.RuleFor(s => s.ChangePrice, f => 0);
            fakerSales.RuleFor(s => s.OrderDate,
                f => f.Date.Between(new DateTime(2024, 5, 1), new DateTime(2024, 5, 30)));
            return fakerSales.Generate(count);
        }

        private List<DetailSalesOrder> GetFakeDetailSales(int count, List<Product> products)
        {
            Faker<DetailSalesOrder> fakerDetail = new Faker<DetailSalesOrder>("vi");
            fakerDetail.RuleFor(d => d.OrderID, f => f.IndexFaker + 1);
            fakerDetail.RuleFor(d => d.Quantity,f=>f.Random.Byte(50,90));
            fakerDetail.RuleFor(d => d.ProductID, f => products[f.IndexFaker].ProductID);
            fakerDetail.RuleFor(d => d.UnitPrice, f => products[f.IndexFaker].UnitPrice);
            return fakerDetail.Generate(count);
        }
    }

}