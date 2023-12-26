using Bogus;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using QLCHBanHoaQuaWF.Presenters;

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
            fakerUser.RuleFor(u => u.Password, f => AuthPresenter.GetSha256Hash("123456"));
            return fakerUser.Generate(count);
        }

        private List<Product> GetFakeProducts(int count)
        {
            List<string> fruits = new List<string>
            {
                "Táo", "Chuối", "Dứa", "Cam", "Kiwi", "Cherry", "Lựu", "Dâu tây", "Nho", "Lê", "Dừa", "Bưởi",
                "Dưa hấu", "Mâm xôi", "Bơ", "Xoài", "Cà chua", "Dừa xiêm", "Dưa lưới", "Mận", "Lý chua", "Quýt",
                "Cây lựu đỏ", "Hồng", "Đu đủ", "Ổi", "Việt quất", "Dứa hấu", "Cây dừa sen", "Cherry đỏ", "Cây dừa nước",
                "Nho đen", "Cây dừa cạn", "Dừa xanh", "Táo xanh", "Lê Mỹ", "Bưởi da xanh", "Bưởi da đỏ", "Xoài ruột đỏ",
                "Bưởi vàng", "Đào", "Cây hồng đỏ", "Đào mỹ", "Kiwi vàng", "Lựu năm cánh", "Cây lê trái hình bầu dục", 
                "Bơ Fuerte", "Bơ Hass", "Bơ lụi", "Dâu", "Dâu rừng", "Dâu tây mỹ", "Cây cam vàng", "Cây cam sành",
                "Cam quýt", "Cam chanh", "Cây dâu chứng", "Dứa cayenne", "Dứa Victoria", "Cây lựu Đài Loan", "Lựu Thái",
                "Dưa gang", "Dưa chuột", "Dưa hấu mật ong", "Mâm xôi trái dẹt", "Mâm xôi nước", "Mâm xôi mỹ", "Bưởi mật",
                "Xoài Cầu", "Xoài Cát", "Cà chua cherry", "Cà chua bi", "Cà chua Roma", "Cà chua đen", "Dừa macapuno",
                "Dừa xiêm hạt dẻ", "Dừa xiêm trắng", "Dừa xiêm xanh", "Dưa lưới lạc đà", "Mận dầm", "Mận đỏ", "Lý chua ngọt",
                "Lý chua Thái", "Quýt dẻo", "Cây lựu Anh", "Hồng xiêm", "Đu đủ hồng", "Ổi mận", "Ổi hồng", "Việt quất chín",
                "Dứa hấu Golden", "Cây dừa vòi voi", "Dừa tươi", "Táo Fuji", "Táo Green Smith", "Kiwi hayward", "Cherry Rainier",
                "Cây lựu đỏ khô", "Cam Caravela","Sake"
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
                f => f.Date.Between(new DateTime(2023, 11, 1), new DateTime(2023, 11, 30)));
            return fakerImport.Generate(count);
        }

        private List<DetailImportOrder> GetFakeDetailImports(int count,List<Product> products)
        {
            Faker<DetailImportOrder> fakerDetail = new Faker<DetailImportOrder>("vi");
            fakerDetail.RuleFor(d => d.DetailOrderID, f => f.IndexFaker + 1);
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
                f => f.Date.Between(new DateTime(2023, 12, 1), new DateTime(2023, 12, 31)));
            return fakerSales.Generate(count);
        }

        private List<DetailSalesOrder> GetFakeDetailSales(int count, List<Product> products)
        {
            Faker<DetailSalesOrder> fakerDetail = new Faker<DetailSalesOrder>("vi");
            fakerDetail.RuleFor(d => d.DetailOrderID, f => f.IndexFaker + 1);
            fakerDetail.RuleFor(d => d.OrderID, f => f.IndexFaker + 1);
            fakerDetail.RuleFor(d => d.Quantity,f=>f.Random.Byte(50,90));
            fakerDetail.RuleFor(d => d.ProductID, f => products[f.IndexFaker].ProductID);
            fakerDetail.RuleFor(d => d.UnitPrice, f => products[f.IndexFaker].UnitPrice);
            return fakerDetail.Generate(count);
        }
    }

}