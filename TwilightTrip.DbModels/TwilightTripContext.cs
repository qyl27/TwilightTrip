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

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Sense>()
                .HasMany(s => s.Links)
                .WithOne(l => l.Sense);
            builder.Entity<Sense>()
                .HasMany(s => s.Npcs)
                .WithOne(n => n.AtSense);
            
            builder.Entity<SenseLink>();

            builder.Entity<Npc>();

            builder.Entity<Conversation>();

            builder.Entity<NpcConversation>()
                .HasKey(nc => new { nc.NpcId, nc.ConversationId });
            builder.Entity<NpcConversation>()
                .HasOne(nc => nc.Npc)
                .WithMany(n => n.Talks)
                .HasForeignKey(nc => nc.NpcId);
            builder.Entity<NpcConversation>()
                .HasOne(nc => nc.Conversation)
                .WithMany(c => c.Owner)
                .HasForeignKey(nc => nc.ConversationId);
            
        }
    }
}
