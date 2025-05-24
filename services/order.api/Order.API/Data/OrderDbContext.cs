using Microsoft.EntityFrameworkCore;
using Order.API.Entities;

namespace Order.API.Data
{
    public class OrderDbContext : DbContext
    {
        public OrderDbContext(DbContextOptions<OrderDbContext> options) : base(options) { }

        public DbSet<Order.API.Entities.Order> Orders { get; set; }
    }
}
