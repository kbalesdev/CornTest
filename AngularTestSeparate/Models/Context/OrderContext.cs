using AngularTestSeparate.Models.Location;
using AngularTestSeparate.Models.Stop;
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
        public DbSet<StopType> StopTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<StopType>()
                .Property(s => s.Id)
                .ValueGeneratedNever();

            modelBuilder.Entity<StopType>()
                .HasData(
                    new {Id = Enums.StopTypes.Pick, Description = "Pick"},
                    new {Id = Enums.StopTypes.Drop, Description = "Drop"});
        }
    }
}