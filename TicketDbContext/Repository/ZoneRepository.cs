using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using Truextend.TicketDispenser.Core.Models;
using Truextend.TicketDispenser.Core.Services;
using Truextend.TicketDispenser.Data.Repository.Base;
using Truextend.TicketDispenser.Data.Repository.Interfaces;
using Zone = Truextend.TicketDispenser.Core.Models.Zone;

namespace Truextend.TicketDispenser.Data.Repository
{
    public class ZoneRepository : Repository<Zone>, IZoneRepository
    {
        public ZoneRepository(TicketDbContext ticketDbContext) : base(ticketDbContext) { }
        public async Task<IEnumerable<Zone>> GetZoneById(int id)
        {
            return await GetAllAsync(zone => zone.Id == id);
        }

        public Task<IEnumerable<Zone>> GetZonesById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
