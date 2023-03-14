
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
                                            .Where(e => e.Id == eventId).FirstOrDefault();


            //var eventShow = dbContext.EventShow.Include(e => e.EventZones)
            //                                        .ThenInclude(ez => ez.Zone)
            //                                        .SingleOrDefault(e => e.Id == eventId)
            //                                        ?.EventZones.Select(ez => ez.Zone);
            Zone zone = await this.dbContext.Zone.FindAsync(zoneId);
            //List<EventZone> eventZone = dbContext.EventZone.Where(ez => ez.ZoneId == zoneId && ez.EventId == eventId).ToList();
            //EventZone eventZone = await this.dbContext.EventZone.FirstOrDefaultAsync(ez => ez.EventId == eventId && ez.ZoneId == zoneId);

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
