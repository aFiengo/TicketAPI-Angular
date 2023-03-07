using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Truextend.TicketDispenser.Core.Models;
using Truextend.TicketDispenser.Data.Repository.Base;

namespace Truextend.TicketDispenser.Data.Repository.Interfaces
{
    public interface IZoneVenueRepository : IRepository<ZoneVenue>
    {
        Task<IEnumerable<ZoneVenue>> GetZoneVenueById(int id);
    }
}
