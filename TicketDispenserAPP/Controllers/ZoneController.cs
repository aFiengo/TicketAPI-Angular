using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Truextend.TicketDispenser.Core.Managers;
using Truextend.TicketDispenser.Core.Models;

namespace Truextend.TicketDispenser.TicketDispenserAPI.Controllers
{
    [Route("api/zone")]
    [ApiController]
    public class ZoneController : ControllerBase
    {
        private readonly ZoneManager _zoneManager;
        public ZoneController(ZoneManager zoneManager)
        {
            _zoneManager = zoneManager;
        }
        [HttpGet]
        public IActionResult GetZones()
        {
            List<Zone> zones = _zoneManager.GetZones();
            return Ok(zones);
        }

        [HttpPost]
        public IActionResult CreateZone([FromBody] Zone zoneToAdd, [FromHeader] int id)
        {
            this._zoneManager.AddZone(zoneToAdd, id);
            return Ok(zoneToAdd);
        }

        [HttpPut]
        [Route("{Id}")]
        public IActionResult UpdateZone([FromRoute] int Id, [FromBody] Zone zoneToUpdate) 
        {
            return Ok(this._zoneManager.UpdateZone(Id, zoneToUpdate));
            /*Zone selectedZone = _zoneManager.UpdateZone(Id, zoneToUpdate);
            return Ok(selectedZone);*/
        }

        [HttpDelete]
        [Route ("{id}")] 
        public IActionResult DeleteZone([FromRoute] int id)
        {
            Zone zoneToDelete = _zoneManager.DeleteZone(id);
            return Ok(zoneToDelete);
        }
    }
}
