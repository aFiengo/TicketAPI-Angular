
using System.Security.Policy;
using Truextend.TicketDispenser.Data.Repository.Base;
using Zone = Truextend.TicketDispenser.Core.Models.Zone;

namespace Truextend.TicketDispenser.Data.Repository.Interfaces
{
    public interface IZoneRepository : IRepository<Zone>
    {
    }
}
