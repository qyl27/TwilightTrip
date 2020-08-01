using System;
using Microsoft.EntityFrameworkCore;

namespace TwilightTrip.DbModels
{
    public class TwilightTripContext : DbContext
    {
        public static readonly Version DbVersion = new Version(1, 0, 0, 0);
        
        public TwilightTripContext(DbContextOptions<TwilightTripContext> options)
            : base(options)
        {
        }

        
        
        protected override void OnModelCreating(ModelBuilder builder)
        {
            
            
            base.OnModelCreating(builder);
        }
    }
}