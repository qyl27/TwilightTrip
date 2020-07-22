using Microsoft.EntityFrameworkCore;
using TwilightTrip.DbModels.Enumerates;
using TwilightTrip.DbModels.Missions;
using TwilightTrip.DbModels.Missions.Rewards;
using TwilightTrip.DbModels.Npcs;
using TwilightTrip.DbModels.Players;
using TwilightTrip.DbModels.Senses;

namespace TwilightTrip.DbModels
{
    public class TwilightTripContext : DbContext
    {
        public TwilightTripContext(DbContextOptions<TwilightTripContext> options) 
            : base(options)
        {
        }
        
        public DbSet<Item> Items { get; set; }
        
        public DbSet<Player> Players { get; set; }
        public DbSet<Home> Homes { get; set; }

        public DbSet<Sense> Senses { get; set; }
        public DbSet<SenseLink> SenseLinks { get; set; }
        
        public DbSet<Npc> Npcs { get; set; }
        public DbSet<Conversation> Conversations { get; set; }
        public DbSet<Option> Options { get; set; }
        
        public DbSet<Mission> Missions { get; set; }
        
        public DbSet<MissionRewardBase> Rewards { get; set; }
        public DbSet<ItemReward> ItemRewards { get; set; }
        public DbSet<ExperiencesReward> ExperiencesRewards { get; set; }
        public DbSet<MoneyReward> MoneyRewards { get; set; }
        public DbSet<PointsReward> PointsRewards { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Player>()
                .HasMany(p => p.Inventory)
                .WithOne();

            builder.Entity<Sense>()
                .HasMany(s => s.Links)
                .WithOne(l => l.Sense)
                .IsRequired();
            builder.Entity<Sense>()
                .HasMany(s => s.Npcs)
                .WithOne(n => n.AtSense)
                .IsRequired();
            
            builder.Entity<SenseLink>()
                .HasOne(l => l.ToSense)
                .WithOne()
                .IsRequired();

            builder.Entity<Npc>()
                .HasMany(n => n.Talks)
                .WithOne(c => c.Owner)
                .IsRequired();

            builder.Entity<Conversation>()
                .HasMany(c => c.Options)
                .WithOne(o => o.From)
                .IsRequired();
            builder.Entity<Conversation>()
                .HasOne(c => c.Mission)
                .WithOne(m => m.StartWith)
                .IsRequired();

            builder.Entity<Option>()
                .HasOne(o => o.Then)
                .WithOne(c => c.From)
                .IsRequired();

            builder.Entity<Mission>()
                .HasOne(m => m.Next)
                .WithOne(n => n.Prev)
                .IsRequired();
            builder.Entity<Mission>()
                .HasMany(m => m.Rewards)
                .WithOne(r => r.Mission)
                .IsRequired();

            builder.Entity<MissionRewardBase>()
                .HasDiscriminator(r => r.Type)
                .HasValue<ItemReward>(MissionRewardType.Item)
                .HasValue<ExperiencesReward>(MissionRewardType.Experience)
                .HasValue<MoneyReward>(MissionRewardType.Money)
                .HasValue<PointsReward>(MissionRewardType.Points);
            builder.Entity<MissionRewardBase>()
                .HasOne(r => r.Mission)
                .WithMany()
                .IsRequired();
            
            builder.Entity<ItemReward>()
                .HasOne(i => i.Item)
                .WithOne()
                .IsRequired();
        }
    }
}
