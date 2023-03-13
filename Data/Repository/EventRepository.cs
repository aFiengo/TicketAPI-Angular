using Microsoft.EntityFrameworkCore;
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
    public class EventRepository : Repository<EventShow>, IEventRepository
    {
        public EventRepository(TicketDbContext ticketDbContext) : base(ticketDbContext) { }

        public async Task<IEnumerable<EventShow>> GetAllEvents()
        {
            return await dbContext.EventShow
            .Include(e => e.Category)
            .Include(e => e.Venue)
            .Include(e => e.EventZones)
                .ThenInclude(ez => ez.Zone)
            .ToListAsync();
        }
        public async Task<EventShow> GetEventById(int id)
        {
            return await dbContext.EventShow
            .Include(e => e.Category)
            .Include(e => e.Venue)
            .Include(e => e.EventZones)
                .ThenInclude(ez => ez.Zone)
            .FirstOrDefaultAsync(e => e.Id == id);
        }
    }
}
