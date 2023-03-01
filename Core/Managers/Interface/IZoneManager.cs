using Truextend.TicketDispenser.Core.Managers.Base;
using Truextend.TicketDispenser.Core.Models;
using Truextend.TicketDispenser.Core.Models.DTOs;

namespace Truextend.TicketDispenser.Core.Managers.Interface;
public interface IZoneManager : IGenericManager<ZoneDTO>
{
    ZoneDTO CreateByEvent(int eventId, ZoneDTO zone);
}