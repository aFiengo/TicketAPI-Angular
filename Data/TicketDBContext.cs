using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Configuration;
using Truextend.TicketDispenser.Data.Models;

namespace Truextend.TicketDispenser.Data
{

    public class TicketDbContext : DbContext
    {
        private readonly IConfiguration _config;
        public TicketDbContext(IConfiguration config)
        {
            _config = config;
        }
        //public DbSet<Ticket> Ticket { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<EventShow> EventShow { get; set; }
        public DbSet<EventZone> EventZone { get; set; }
        public DbSet<Venue> Venue { get; set; }
        public DbSet<Zone> Zone { get; set; }
        public DbSet<ZoneVenue> ZoneVenue { get; set; }
        public DbSet<User> User { get; set; }

       protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseMySQL(_config["ConnectionStrings:TicketConnection"]);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EventZone>()
                .HasKey(ez => new { ez.EventId, ez.ZoneId });

            modelBuilder.Entity<EventZone>()
                .HasOne(ez => ez.Event)
                .WithMany(b => b.EventZones)
                .HasForeignKey(ez => ez.EventId);

            modelBuilder.Entity<EventZone>()
                .HasOne(ez => ez.Zone)
                .WithMany(c => c.EventZones)
                .HasForeignKey(ez => ez.ZoneId);
        }
    }
}