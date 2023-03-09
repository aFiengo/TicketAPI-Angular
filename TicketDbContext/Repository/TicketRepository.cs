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
    public class TicketRepository : Repository<Ticket>, ITicketRepository
    {
        public TicketRepository(TicketDbContext ticketDbContext) : base(ticketDbContext) { }
        public async Task<IEnumerable<Ticket>> GetTicketsById(Guid id)
        {
            IEnumerable<Ticket> tickets = await GetAllAsync(t => t.Id == id);
            return tickets;
        }
}
