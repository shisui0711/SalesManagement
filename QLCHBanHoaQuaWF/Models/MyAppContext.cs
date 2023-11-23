using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace QLCHBanHoaQuaWF.Models
{
    public partial class MyAppContext : DbContext
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
                entity.HasOne(u => u.Permission)
                    .WithOne(p => p.UserRole)
                    .HasForeignKey<Permission>(c => c.UserRoleID)
                    .OnDelete(DeleteBehavior.Cascade);
                entity.HasData(
                    new UserRole
                    {
                        RoleID = 1,
                        RoleName = "Nhân viên"

                    }
                );
            });
            modelBuilder.Entity<Permission>().HasData(
                new Permission
                {
                    PermissionID = 1,
                    UserRoleID = 1,
                    CanCreateCustomer = true,
                    CanUpdateCustomer = true,
                    CanDeleteCustomer = true,
                    CanReadCustomer = true,
                    CanReadDetailImportOrder = true,
                    CanReadDetailSalesOrder = true
                }
                );
            modelBuilder.Entity<AppInfo>(entity =>
            {
                entity.HasData(
                    new AppInfo
                    {
                        AppName = "Cửa hàng của bạn",
                        Phone = "0987654321",
                        Address = "Hưng Yên"
                    }
                );

            });
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
        public virtual DbSet<AppInfo?> AppInfos { get; set; }
    }

}