using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Truextend.TicketDispenser.Core.Models;
using Truextend.TicketDispenser.Core.Services;
using Truextend.TicketDispenser.Data.Repository.Base;
using Truextend.TicketDispenser.Data.Repository.Interfaces;

namespace Truextend.TicketDispenser.Data.Repository
{
    public class VenueRepository : Repository<Venue>, IVenueRepository
    {
        public VenueRepository(TicketDbContext ticketDbContext) : base(ticketDbContext) { }
        public async Task<IEnumerable<Venue>> GetVenueById(int id)
        {
            IEnumerable<Venue> venues = await GetAllAsync(v => v.Id == id);
            return venues;
        }
    }
}
