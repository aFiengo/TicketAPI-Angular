using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Truextend.TicketDispenser.Core.Managers;
using Truextend.TicketDispenser.Core.Models;
using Truextend.TicketDispenser.TicketDispenserAPI.Controllers.Base;

namespace Truextend.TicketDispenser.TicketDispenserAPI.Controllers
{
    [Route("api/zone")]
    [ApiController]
    public class ZoneController : TicketBaseController<Zone>
    {
        private readonly ZoneManager _zoneManager;
        public ZoneController(ZoneManager zoneManager) : base(zoneManager)
        {
            _zoneManager = zoneManager;
        }

        [HttpPost]
        [Route("vanue/{venueId}")]
        public IActionResult CreateZoneByVenue([FromBody] Zone zoneToAdd, [FromRoute] int venueId)
        {
            this._zoneManager.CreateByVenue(venueId, zoneToAdd);
            return Ok(zoneToAdd);
        }
    }
}
