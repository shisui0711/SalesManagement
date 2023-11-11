using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using AppContext = QLCHBanHoaQuaWF.Models.AppContext;

namespace QLCHBanHoaQuaWF.Models
{
    public partial class AppContext: DbContext
    {
        public AppContext()
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }
        public AppContext(DbContextOptions<AppContext> optionsBuilderOptions) : base(optionsBuilderOptions)
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=QLCHBanHoaQua;Integrated Security=True;TrustServerCertificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Account>(entity =>
            {
                entity.HasKey(e => new { e.EmployeeID, e.Role });
            });
        }

        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Provider> Providers { get; set; }
        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<ImportOrder> ImportOrders { get; set; }
        public virtual DbSet<SalesOrder> SalesOrders { get; set; }
        public virtual DbSet<Shift> Shifts { get; set; }
        public virtual DbSet<DetailImportOrder> DetailImportOrders { get; set; }
        public virtual DbSet<DetailSalesOrder> DetailSalesOrders { get; set; }
    }
    
}