
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

        public async Task<Ticket> CreateTicketAsync(int eventId, int quantity, int userId)
        {
            EventShow eventShow = await this.dbContext.EventShow.FindAsync(eventId);
            EventZone zone = eventShow?.EventZones.FirstOrDefault();
            User user = await this.dbContext.User.FindAsync(userId);

            if (eventShow == null || zone == null || user == null)
            {
                return null;
            }

            Ticket ticket = new Ticket
            {
                EventShow = eventShow,
                Quantity = quantity,
                User = user
            };

            return await CreateAsync(ticket);
        }
    }
}
