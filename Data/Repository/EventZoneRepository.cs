using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Truextend.TicketDispenser.Data.Models;
using Truextend.TicketDispenser.Data.Repository.Base;
using Truextend.TicketDispenser.Data.Repository.Interfaces;

namespace Truextend.TicketDispenser.Data.Repository
{
    public class EventZoneRepository : Repository<EventZone>, IEventZoneRepository
    {
        public EventZoneRepository(TicketDbContext ticketDbContext) : base(ticketDbContext) { }
        public async Task<IEnumerable<EventZone>> GetZonesByEventId(int eventId)
        {
            IEnumerable<EventZone> zones = await GetAllAsync(z => z.EventId == eventId);
            return zones;
        }
    }
}
