using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Truextend.TicketDispenser.Core.Managers;
using Truextend.TicketDispenser.Data.Models;

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
        public async Task<ActionResult> GetZones()
        {
            IEnumerable<Zone> zones = await _zoneManager.GetAll();
            return Ok(zones);
        }
        [HttpGet]
        [Route("{id}")]
        public async Task<ActionResult> GetZoneById(int id)
        {
            Zone zone = await _zoneManager.GetById(id);
            return Ok(zone);
        }
        [HttpGet]
        [Route("venue")]
        public async Task<ActionResult> GetZoneByVenueId(int venueId)
        {
            Zone zone = await _zoneManager.GetById(venueId);
            return Ok(zone);
        }
        [HttpPost]
        public async Task<ActionResult> CreateZone(Zone zoneToAdd)
        {
            Zone createdZone = await _zoneManager.Create(zoneToAdd);
            return Ok(createdZone);
        }
        [HttpPut]
        [Route("{id}")]
        public async Task<ActionResult> UpdateZone([FromRoute] int id, [FromBody] Zone selectedZone)
        {
            Zone zoneToUpdate = await _zoneManager.Update(id, selectedZone);
            return Ok(zoneToUpdate);
        }

        [HttpDelete]
        [Route("{id}")]
        public async Task<ActionResult> DeleteZone([FromRoute] int id)
        {
            bool zoneToDelete = await _zoneManager.Delete(id);
            return Ok(zoneToDelete);
        }
    }
}
