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
    public class EventRepository : Repository<EventShow>, IEventRepository
    {
        public EventRepository(TicketDbContext ticketDbContext) : base(ticketDbContext) { }
    public async Task<EventShow> GetEventById(int id)
    {
        IEnumerable<EventShow> eventShow = await GetAllAsync(u => u.Id == id);
        return eventShow.Any() ? eventShow.First() : null;
        {

    }
}
