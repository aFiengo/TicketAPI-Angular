using Truextend.TicketDispenser.Core.Managers.Base;
using Truextend.TicketDispenser.Core.Models;

namespace Truextend.TicketDispenser.Core.Managers.Interface 
{
    public interface IZoneManager : IGenericManager<Zone>
    {
        Zone CreateByVenue(int id, Zone zone);
    }
}