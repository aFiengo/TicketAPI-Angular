using Truextend.TicketDispenser.Data.Models;
using Truextend.TicketDispenser.Data.Repository.Base;
using Truextend.TicketDispenser.Data.Repository.Interfaces;
using Truextend.TicketDispenserAPI.Data;

namespace Truextend.TicketDispenser.Data.Repository;
public class ZoneRepository : Repository<Zone>, IZoneRepository
{
    public ZoneRepository(TicketDispenserDBContext ticketDBContext) : base(ticketDBContext) { }

}