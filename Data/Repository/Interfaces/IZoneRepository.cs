
using System.Security.Policy;
using Truextend.TicketDispenser.Data.Models;
using Truextend.TicketDispenser.Data.Repository.Base;
using Zone = Truextend.TicketDispenser.Data.Models.Zone;

namespace Truextend.TicketDispenser.Data.Repository.Interfaces
{
    public interface IZoneRepository : IRepository<Zone>
    {
        Task<Zone> GetZoneById(int id);
    }
}
