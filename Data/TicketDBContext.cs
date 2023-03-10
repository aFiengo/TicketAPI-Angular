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
        public DbSet<Ticket> Ticket { get; set; }
        public DbSet<EventShow> EventShow { get; set; }
        public DbSet<Venue> Venue { get; set; }
        public DbSet<Zone> Zone { get; set; }
        public DbSet<User> User { get; set; }

       protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseMySQL(_config["ConnectionStrings:TicketConnection"]);
        }
    }
}