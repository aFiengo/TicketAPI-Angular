
using Microsoft.AspNetCore.Mvc;
using Truextend.TicketDispenser.Core.Managers;
using Truextend.TicketDispenser.TicketDispenserAPI.Controllers.Base;
using Truextend.TicketDispenser.Core.Models;

namespace Truextend.TicketDispenser.TicketDispenserAPI.Controllers;

[Produces("application/json")]
[Route("api/zone")]
[ApiController]
public class ZoneController : TicketBaseController<ZoneDTO>
{
    private readonly ZoneManager _zoneManager;
    public ZoneController(ZoneManager zoneManager) : base(zoneManager)
    {
        _zoneManager = zoneManager;
    }
}