using Microsoft.EntityFrameworkCore;
using Minimart.Entities;

namespace Minimart.DatabaseAccess
{
    public class MinimartDbContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Replace with your actual connection string
            optionsBuilder.UseSqlServer("Server=DESKTOP-0BQ9RBN\\SQLEXPRESS;Database=Minimart;Integrated Security=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>()
                .Property(c => c.Name)
                .IsRequired()
                .HasMaxLength(255);

            modelBuilder.Entity<Category>()
                .HasIndex(c => c.Name)
                .IsUnique();

            modelBuilder.Entity<Supplier>()
                .Property(s => s.Name)
                .IsRequired()
                .HasMaxLength(255);

            modelBuilder.Entity<Supplier>()
                .HasIndex(s => s.Name)
                .IsUnique();

            modelBuilder.Entity<Supplier>()
                .HasIndex(s => s.Email)
                .IsUnique();
        }
    }
}
