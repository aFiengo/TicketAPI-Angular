using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Configuration;
using Truextend.TicketDispenser.Core.Models;

namespace Truextend.TicketDispenser.Core.Services
{

    public class TicketDbContext : DbContext
    {
        private readonly IConfiguration _config;
        public TicketDbContext(IConfiguration config)
        {
            _config = config;
        }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<EventShow> EventShows { get; set; }
        public DbSet<Venue> Locations { get; set; }
        public DbSet<Zone> Zones { get; set; }
        public DbSet<User> Users { get; set; }

       protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(_config["ConnectionStrings:TicketConnection"]);
        }
    }
}