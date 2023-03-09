using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Truextend.TicketDispenser.Data.Repository.Interfaces;

namespace Truextend.TicketDispenser.Data
{
    public interface IUnitOfWork
    {
        ITicketRepository TicketRepository { get; }
        ICategoryRepository CategoryRepository { get; }
        IUserRepository UserRepository { get; }
        IZoneRepository ZoneRepository { get; }
        IVenueRepository VenueRepository { get; }
        IEventRepository EventRepository { get; }
        IEventZoneRepository EventZoneRepository { get; }
        void BeginTransaction();
        void CommitTransaction();
        void RollBackTransaction();
        void Save();
    }
}
