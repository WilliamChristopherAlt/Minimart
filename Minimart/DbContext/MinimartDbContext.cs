using Microsoft.EntityFrameworkCore;
using Minimart.Entities;

namespace Minimart.DatabaseAccess
{
    public class MinimartDbContext : DbContext
    {
        // Define your DbSets here...
        public DbSet<Category> Categories { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<MeasurementUnit> MeasurementUnits { get; set; }
        public DbSet<ProductType> ProductTypes { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<EmployeeRole> EmployeeRoles { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<PaymentMethod> PaymentMethods { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<SaleDetail> SaleDetails { get; set; }
        public DbSet<AdminRole> AdminRoles { get; set; }  
        public DbSet<Admin> Admins { get; set; }

        // Parameterless constructor (for scenarios where no configuration is pas   sed in)
        public MinimartDbContext() { }

        // Constructor that accepts DbContextOptions to be passed from the DI container
        public MinimartDbContext(DbContextOptions<MinimartDbContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // You can remove the configuration here since it will be passed from DI
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=DESKTOP-0BQ9RBN\\SQLEXPRESS;Database=Minimart;Integrated Security=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Category
            modelBuilder.Entity<Category>()
                .Property(c => c.CategoryName)
                .IsRequired()
                .HasMaxLength(255);

            modelBuilder.Entity<Category>()
                .HasIndex(c => c.CategoryName)
                .IsUnique();

            // Supplier
            modelBuilder.Entity<Supplier>()
                .Property(s => s.SupplierName)
                .IsRequired()
                .HasMaxLength(255);

            modelBuilder.Entity<Supplier>()
                .HasIndex(s => s.SupplierName)
                .IsUnique();

            modelBuilder.Entity<Supplier>()
                .HasIndex(s => s.SupplierEmail)
                .IsUnique();

            // MeasurementUnit
            modelBuilder.Entity<MeasurementUnit>()
                .Property(mu => mu.UnitName)
                .IsRequired()
                .HasMaxLength(255);

            // ProductType
            modelBuilder.Entity<ProductType>()
                .Property(pt => pt.ProductName)
                .IsRequired()
                .HasMaxLength(255);

            modelBuilder.Entity<ProductType>()
                .Property(pt => pt.Price)
                .HasColumnType("decimal(18,2)");

            modelBuilder.Entity<ProductType>()
                .Property(pt => pt.StockAmount)
                .HasColumnType("decimal(18,2)");

            // EmployeeRole
            modelBuilder.Entity<EmployeeRole>()
                .Property(er => er.RoleName)
                .IsRequired()
                .HasMaxLength(255);

            // Employee
            modelBuilder.Entity<Employee>()
                .Property(e => e.FirstName)
                .IsRequired()
                .HasMaxLength(255);

            modelBuilder.Entity<Employee>()
                .Property(e => e.LastName)
                .IsRequired()
                .HasMaxLength(255);

            modelBuilder.Entity<Employee>()
                .Property(e => e.Email)
                .HasMaxLength(255);

            modelBuilder.Entity<Employee>()
                .Property(e => e.CitizenID)
                .HasMaxLength(20);

            modelBuilder.Entity<Employee>()
                .Property(e => e.Salary)
                .HasColumnType("decimal(18,2)");

            // PaymentMethod
            modelBuilder.Entity<PaymentMethod>()
                .Property(pm => pm.MethodName)
                .IsRequired()
                .HasMaxLength(255);

            // Sale
            modelBuilder.Entity<Sale>()
                .Property(s => s.SaleDate)
                .IsRequired();

            // SaleDetail
            modelBuilder.Entity<SaleDetail>()
                .Property(sd => sd.Quantity)
                .HasColumnType("decimal(18,2)");

            // AdminRole
            modelBuilder.Entity<AdminRole>()
                .Property(ar => ar.RoleName)
                .IsRequired()
                .HasMaxLength(255);

            // Admin
            modelBuilder.Entity<Admin>()
                .Property(a => a.Username)
                .IsRequired()
                .HasMaxLength(255);

            modelBuilder.Entity<Admin>()
                .Property(a => a.CreatedAt)
                .IsRequired();

            modelBuilder.Entity<Admin>()
                .HasIndex(a => a.Username)
                .IsUnique();
        }
    }
}
