using Microsoft.EntityFrameworkCore;

namespace StoreSharp
{
    public class StoreSharpContext : DbContext
    {
        public DbSet<Category> Categories { get; set; } = null!;
        public DbSet<Product> Products { get; set; } = null!;
        public DbSet<Role> Roles { get; set; } = null!;
        public DbSet<User> Users { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Server=v-10-001;Database=storesharp;User Id=storesharp;Password=storesharp;"
            );
        }
    }
}
