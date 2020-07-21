using Microsoft.EntityFrameworkCore;
using TwilightTrip.DbModels.Npcs;
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
        
        public DbSet<Npc> Npcs { get; set; }
        public DbSet<Conversation> Conversations { get; set; }
        public DbSet<Option> Options { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Sense>()
                .HasMany(s => s.Links)
                .WithOne(l => l.Sense);
            builder.Entity<Sense>()
                .HasMany(s => s.Npcs)
                .WithOne(n => n.AtSense);
            
            builder.Entity<SenseLink>();

            builder.Entity<Npc>()
                .HasMany(n => n.Talks)
                .WithOne(c => c.Owner);

            builder.Entity<Conversation>()
                .HasMany(c => c.Options)
                .WithOne(o => o.Owner);

            builder.Entity<Option>();

        }
    }
}
