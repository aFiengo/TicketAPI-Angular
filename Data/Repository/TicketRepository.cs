
using Microsoft.EntityFrameworkCore;
using Truextend.TicketDispenser.Data.Models;
using Truextend.TicketDispenser.Data.Repository.Base;
using Truextend.TicketDispenser.Data.Repository.Interfaces;

namespace Truextend.TicketDispenser.Data.Repository
{
    public class TicketRepository : Repository<Ticket>, ITicketRepository
    {
        //private readonly IUnitOfWork _uow;

        //public TicketRepository(TicketDbContext dbContext) : base(dbContext)
        //{
        //}

        public TicketRepository(TicketDbContext ticketDbContext) : base(ticketDbContext)
        {
            //_uow = unitOfWork;
        }

        public async Task<IEnumerable<Ticket>> CreateTicketAsync(int eventId, int zoneId, int quantity, int userId)
        {
            List<Ticket> tickets = new List<Ticket>();
            EventShow eventShow = dbContext.EventShow
                                            .Include(e => e.Category)
                                            .Include(e => e.Venue) 
                                            .Include(e => e.EventZones).ThenInclude(ez => ez.Zone) 
                                            .Where(e => e.Id == eventId).FirstOrDefault();


            Zone zone = await this.dbContext.Zone.FindAsync(zoneId);

            User user = await this.dbContext.User.FindAsync(userId);

            if (eventShow == null || zone == null || user == null)
            {
                return null;
            }

            for (int i = 0; i < quantity; i++)
            {
                Ticket ticket = new Ticket
                {
                    Id = Guid.NewGuid(),
                    EventShow = eventShow,
                    Quantity = 1,
                    ZoneId = zoneId,
                    User = user
                };
                Ticket createdTicket = await CreateAsync(ticket);
                tickets.Add(createdTicket);
            }

            return tickets;
        }


    }
}
