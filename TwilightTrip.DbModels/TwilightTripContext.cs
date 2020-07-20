using Microsoft.EntityFrameworkCore;
using TwilightTrip.DbModels.Senses;

namespace TwilightTrip.DbModels
{
    public class TwilightTripContext : DbContext
    {
        public TwilightTripContext(DbContextOptions<TwilightTripContext> options) 
            : base(options)
        {
        }

        public DbSet<Sense> Senses { get; set; }
        public DbSet<SenseLink> SenseLinks { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Sense>()
                .HasMany(l => l.Links)
                .WithOne(s => s.Sense);

            builder.Entity<SenseLink>();
        }
    }
}
