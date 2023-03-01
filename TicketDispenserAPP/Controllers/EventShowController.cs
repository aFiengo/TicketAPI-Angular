using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Truextend.TicketDispenser.Core.Managers;
using Truextend.TicketDispenser.Core.Models;
using Truextend.TicketDispenser.TicketDispenserAPI.Controllers.Base;

namespace Truextend.TicketDispenser.TicketDispenserAPI.Controllers;
[Route("api/event")]
[ApiController]
public class EventShowController : TicketBaseController<EventShowDTO>
{
    private readonly EventShowManager _eventManager;
    public EventShowController(EventShowManager eventManager) : base(eventManager)
    {
        _eventManager = eventManager;
    }

    [HttpPut("{id}/zone/{zoneId}")]
    public IActionResult UpdateById([FromRoute] int id, [FromRoute] int zoneId)
    {
        return Ok(_eventManager.UpdateZone(id, zoneId));
    }

}
