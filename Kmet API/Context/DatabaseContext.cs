using Kmet_API_Business.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Kmet_API.Context
{
    public class DatabaseContext : IdentityDbContext<User>
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options)
           : base(options)
        {
        }

        public DbSet<Item> Items { get; set; }
        public DbSet<ItemOrder> Orders { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new RoleConfiguration());


            modelBuilder.Entity<Item>().ToTable("Item");
            modelBuilder.Entity<ItemOrder>().ToTable("ItemOrder");
        }
    }
}