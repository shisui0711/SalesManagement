using Bogus;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace QLCHBanHoaQuaWF.Models
{
    public sealed partial class MyAppContext : DbContext
    {
        private IConfiguration _configuration;
        public MyAppContext()
        {

        }
        public MyAppContext(DbContextOptions<MyAppContext> optionsBuilderOptions, IConfiguration configuration) : base(optionsBuilderOptions)
        {
            _configuration = configuration;
            Database.Migrate();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(
            "Data Source=.;Initial Catalog=QLCHBanHoaQua;Integrated Security=True;TrustServerCertificate=True");
            //optionsBuilder.UseSqlServer(_configuration.GetConnectionString("SqlServer"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasIndex(e => e.Email).IsUnique();
            });
            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => new { e.EmployeeID, e.RoleID });
                entity.HasIndex(e => e.Email).IsUnique();
            });
            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasIndex(e => e.Email).IsUnique();
            });
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
                        CanExportSalesOrder = true,
                        CanPrintSalesOrder = true,
                        CanReadProduct = true,
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
                        CanExportImportOrder = true,
                        CanPrintImportOrder = true,
                        CanReadProduct = true,
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
            //Customer
            Faker<Customer> fakerCustomer = new Faker<Customer>("vi");
            fakerCustomer.RuleFor(c => c.CustomerID, f => f.IndexFaker +1);
            fakerCustomer.RuleFor(c => c.CustomerName, f => f.Name.FullName());
            fakerCustomer.RuleFor(c => c.Email, f => f.Internet.Email());
            fakerCustomer.RuleFor(c => c.Address, f => f.Address.City());
            fakerCustomer.RuleFor(c => c.Phone, f => f.Phone.PhoneNumber("09########"));
            List<Customer> customers = fakerCustomer.Generate(100);
            modelBuilder.Entity<Customer>().HasData(customers);

            //Provider
            Faker<Provider> fakerProvider = new Faker<Provider>("vi");
            fakerProvider.RuleFor(p => p.ProviderID, f => f.IndexFaker + 1);
            fakerProvider.RuleFor(p => p.ProviderName, f => f.Name.FullName());
            fakerProvider.RuleFor(p => p.Address, f => f.Address.City());
            fakerProvider.RuleFor(p => p.Email, f => f.Internet.Email());
            fakerProvider.RuleFor(p => p.Phone, f => f.Phone.PhoneNumber("09########"));
            List<Provider> providers = fakerProvider.Generate(100);
            modelBuilder.Entity<Provider>().HasData(providers);

            //Faker<Employee> fakerEmployee = new Faker<Employee>("vi");
            //fakerEmployee.RuleFor(e => e.Email, f => f.Internet.Email());
            //fakerEmployee.RuleFor(e => e.Address, f => f.Address.City());
            //fakerEmployee.RuleFor(e => e.Phone, f => f.Phone.PhoneNumber("09########"));
            //fakerEmployee.RuleFor(e => e.EmployeeName, f => f.Name.FullName());
            //fakerEmployee.RuleFor(e => e.Salary, f => f.Random.Decimal(500000, 1000000));
            //List<Employee> employees = fakerEmployee.Generate(1000).DistinctBy(e => e.Email).ToList();
            //modelBuilder.Entity<Employee>().HasData(employees);

            //List<string> danhSachTraiCay = new List<string>
            //{
            //    "Dâu", "Mâm xôi", "Xoài", "Dừa", "Nho", "Cam", "Bưởi", "Táo", "Lựu", "Chuối",
            //    "Dưa hấu", "Dưa lưới", "Kiwi", "Lê", "Cà chua", "Dứa", "Hồng", "Quýt", "Ổi", "Chùm ngây",
            //    "Dâu tây", "Mận", "Cà phê", "Bạc hà", "Dừa xiêm", "Cóc", "Đu đủ", "Lựu đỏ", "Quýt đỏ", "Chanh xanh",
            //    "Cây xoài", "Mận đen", "Nho đen", "Kiwi vàng", "Chôm chôm", "Việt quất", "Bí ngô", "Ổi hột", "Cây dứa", "Nấm",
            //    "Củ cải", "Bí đỏ", "Hạt tiêu", "Hạt nêm", "Hạt dẻ cười", "Hạt nghệ", "Hạt mè", "Hạt bưởi", "Hạt cà phê", "Hạt đậu nành",
            //    "Hạt đậu đỏ", "Hạt đậu xanh", "Hạt đậu phộng", "Hạt hạnh nhân", "Hạt óc chó", "Hạt dưa hấu", "Hạt đậu nành nguyên", "Hạt lựu", "Hạt dẻo",
            //    "Hạt dưa lưới", "Hạt mâm xôi", "Hạt dừa", "Hạt lựu đỏ", "Hạt mâm", "Hạt mâm rừng", "Hạt nho", "Hạt dứa", "Hạt bưởi", "Hạt cam",
            //    "Hạt táo", "Hạt lê", "Hạt chuối", "Hạt dâu", "Hạt cherry", "Hạt mâm tây", "Hạt mâm xôi đỏ", "Hạt mâm xôi xanh", "Hạt dứa xiêm", "Hạt dứa nước",
            //    "Hạt dừa nước mặn", "Hạt dừa nước ngọt", "Hạt nho đỏ", "Hạt nho xanh", "Hạt nho đen", "Hạt nho trắng", "Hạt nho vàng", "Hạt nho hồng", "Hạt nho tím",
            //    "Hạt nho nâu", "Hạt nho xanh lá", "Hạt nho xanh non", "Hạt nho mỡ", "Hạt nho mập", "Hạt nho non", "Hạt nho xanh mạ", "Hạt nho đỏ mạ", "Hạt nho vàng mạ",
            //    "Hạt nho trắng mạ", "Hạt nho tím mạ", "Hạt nho đen mạ", "Hạt nho hồng mạ", "Hạt nho lựu mạ", "Hạt nho cam mạ", "Hạt nho chuối mạ", "Hạt nho mâm mạ", "Hạt nho cà phê mạ"
            //};

            //Faker<Product> fakerProduct = new Faker<Product>("vi");
            //fakerProduct.RuleFor(p => p.ProductName, f => danhSachTraiCay[f.IndexFaker]);
            //fakerProduct.RuleFor(p => p.ImportUnitPrice, f => f.Random.Decimal(10000, 50000));
            //fakerProduct.RuleFor(p => p.UnitPrice, f => f.Random.Decimal(60000, 100000));
            //fakerProduct.RuleFor(p=>p.)

        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Provider> Providers { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<Permission> Permissions { get; set; }
        public DbSet<ImportOrder> ImportOrders { get; set; }
        public DbSet<SalesOrder> SalesOrders { get; set; }
        public DbSet<DetailImportOrder> DetailImportOrders { get; set; }
        public DbSet<DetailSalesOrder> DetailSalesOrders { get; set; }
        public DbSet<AppInfo?> AppInfos { get; set; }
    }

}