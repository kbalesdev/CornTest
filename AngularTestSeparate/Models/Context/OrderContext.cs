using AngularTestSeparate.Models.Location;
using Microsoft.EntityFrameworkCore;

namespace AngularTestSeparate.Models.Context
{
    public class OrderContext : DbContext
    {
        public OrderContext(DbContextOptions<OrderContext> options) : base(options)
        {
            
        }

        public DbSet<Order.Order> Order { get; set; }
        public DbSet<Stop.Stop> Stop { get; set; }
        public DbSet<Location.Location> Location { get; set; }
        public DbSet<City> City { get; set; }
        public DbSet<Carrier.Carrier> Carrier { get; set; }
    }
}