using Microsoft.EntityFrameworkCore;
using Truextend.TicketDispenser.Data.Models;

namespace Truextend.TicketDispenserAPI.Data;

public class TicketDispenserDBContext : DbContext
{
    public TicketDispenserDBContext(DbContextOptions<TicketDispenserDBContext> options) : base(options)
    {

    }

    public DbSet<Zone> Zones { get; set; }
    public DbSet<EventShow> EventShows { get; set; }

    

}