using Truextend.TicketDispenser.Core.Managers.Base;
using Truextend.TicketDispenser.Core.Models;

namespace Truextend.TicketDispenser.Core.Managers.Interface;
public interface IEventShowManager : IGenericManager<EventShowDTO>
{
    EventShowDTO UpdateZone(int eventId, int zoneId);
}
