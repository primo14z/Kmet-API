using Kmet_API_Business.Models;
using Microsoft.EntityFrameworkCore;

namespace Kmet_API.Context
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options)
           : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<ItemOrder> Orders { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToTable("User");
            modelBuilder.Entity<Item>().ToTable("Item");
            modelBuilder.Entity<ItemOrder>().ToTable("ItemOrder");
        }
    }
}