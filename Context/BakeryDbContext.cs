using Microsoft.EntityFrameworkCore;
using BakeryManagementSystem.Models;

namespace BakeryManagementSystem.Context
{
    public class BakeryDbContext : DbContext
    {
        public BakeryDbContext(DbContextOptions<BakeryDbContext> options) : base(options)
        {

        }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<Purchase> Purchaces { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Message> Messages { get; set; }       
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Sales> Saless { get;  set; }
        public DbSet<SalesItem> SalesItems { get;  set; }
        public DbSet<Stock> Stocks { get; internal set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           
            modelBuilder.Entity<User>().Property(u => u.PasswordHash).IsRequired();

            modelBuilder.Entity<User>().Property(u => u.HashSalt).IsRequired();

            modelBuilder.Entity<User>().HasIndex(u => u.Email).IsUnique();


            modelBuilder.Entity<User>().Property(u => u.Email)
                .IsRequired()
                .HasMaxLength(40);
            modelBuilder.Entity<User>().Property(u => u.Name).IsRequired();

            modelBuilder.Entity<User>().Property(u => u.PhoneNo).IsRequired();

            modelBuilder.Entity<User>().Property(u => u.Address).IsRequired();

            modelBuilder.Entity<User>().Property(u => u.CreatedBy).IsRequired();



            modelBuilder.Entity<Role>().Property(u => u.Name).IsRequired();
            modelBuilder.Entity<Role>().Property(u => u.CreatedBy).IsRequired();



            modelBuilder.Entity<Stock>().Property(u => u.Item).IsRequired();

            modelBuilder.Entity<Stock>().Property(u => u.CreatedBy).IsRequired();



            modelBuilder.Entity<Message>().Property(u => u.Title).IsRequired();

            modelBuilder.Entity<Message>().Property(u => u.Content).IsRequired();

            modelBuilder.Entity<Message>().Property(u => u.CreatedBy).IsRequired();

            modelBuilder.Entity<Sales>().Property(u => u.Item).IsRequired();

            modelBuilder.Entity<Sales>().Property(u => u.CreatedBy).IsRequired();




            modelBuilder.Entity<SalesItem>().Property(u => u.Item).IsRequired();

            modelBuilder.Entity<SalesItem>().Property(u => u.CreatedBy).IsRequired();



            modelBuilder.Entity<UserRole>().HasIndex(u => new { u.UserId, u.RoleId }).IsUnique();
            modelBuilder.Entity<UserRole>().Property(u => u.CreatedBy).IsRequired();



            modelBuilder.Entity<Product>().Property(u => u.CreatedBy).IsRequired();



            modelBuilder.Entity<Purchase>().Property(u => u.CreatedBy).IsRequired();
            modelBuilder.Entity<Category>().Property(u => u.CreatedBy).IsRequired();
           

            modelBuilder.Entity<Category>().Property(u => u.CreatedBy).IsRequired();

        }
    }
}
