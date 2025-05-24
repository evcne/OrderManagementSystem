using Microsoft.EntityFrameworkCore;
using Order.API.Entities;

namespace Order.API.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        //public DbSet<Order> Orders => Set<Order>();
        public DbSet<Order.API.Entities.Order> Orders => Set<Order.API.Entities.Order>();

    }
}
