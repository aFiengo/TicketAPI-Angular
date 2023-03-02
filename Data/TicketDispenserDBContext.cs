using Microsoft.EntityFrameworkCore;
using Truextend.TicketDispenser.Data.Models;
using Truextend.TicketDispenserAPI.Configuration.Database;

namespace Truextend.TicketDispenserAPI.Data;

public class TicketDispenserDBContext : DbContext
{
    private readonly IApplicationConfiguration _applicationConfiguration;

    public TicketDispenserDBContext(IApplicationConfiguration applicationConfiguration)
    {
        _applicationConfiguration = applicationConfiguration;
    }

    public DbSet<Zone> Zones { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer(_applicationConfiguration.GetDatabaseConnectionString().DATABASE);
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        {
            modelBuilder.Entity<Zone>(entity =>
            {
                entity.Property(zone => zone.Id)
                    .IsRequired()
                    .HasColumnType("int")
                    .HasColumnName("id");

                entity.Property(zone => zone.Name)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("name");

                entity.Property(zone => zone.Capacity)
                    .HasColumnType("int")
                    .HasColumnName("capacity");

                entity.Property(zone => zone.TicketPrice)
                    .HasColumnType("float(53)")
                    .HasColumnName("ticket_price");

                entity.Property(zone => zone.Percentage)
                    .HasColumnType("float")
                    .HasColumnName("percentage");
            });
        }
    }
}