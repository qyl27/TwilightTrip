using System;
using Microsoft.EntityFrameworkCore;
using TwilightTrip.DbModels.Senses;

namespace TwilightTrip.DbModels
{
    public class TwilightTripContext : DbContext
    {
        public static readonly Version DbVersion = new Version(1, 0, 0, 0);
        
        public TwilightTripContext(DbContextOptions<TwilightTripContext> options)
            : base(options)
        {
        }

        public DbSet<Sense> Senses { get; set; }
        public DbSet<SenseLink> SenseLinks { get; set; }
        
        protected override void OnModelCreating(ModelBuilder builder)
        {
            
            
            base.OnModelCreating(builder);
        }
    }
}