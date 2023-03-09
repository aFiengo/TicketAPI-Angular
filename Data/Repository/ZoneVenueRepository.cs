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
    public class ZoneVenueRepository : Repository<ZoneVenue>, IZoneVenueRepository
    {
        public ZoneVenueRepository(TicketDbContext ticketDbContext) : base(ticketDbContext) { }
        public async Task<IEnumerable<ZoneVenue>> GetZonesByVenueId(int venueId)
        {
            IEnumerable<ZoneVenue> zones = await GetAllAsync(z => z.VenueId == venueId);
            return zones;
        }
    }
}
