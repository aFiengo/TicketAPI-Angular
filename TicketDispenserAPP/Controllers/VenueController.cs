
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Truextend.TicketDispenser.Core.Managers;
using Truextend.TicketDispenser.Core.Models;

namespace Truextend.TicketDispenser.TicketDispenserAPI.Controllers
{
    [Route("api/venue")]
    [ApiController]
    public class VenueController : ControllerBase
    {
        private readonly VenueManager _venueManager;
        public VenueController(VenueManager venueManager)
        {
            _venueManager = venueManager;
        }

        [HttpGet]
        public IActionResult GetVenues()
        {
            List<Venue> venues = _venueManager.GetVenues();
            return Ok(venues);
        }

        [HttpPost]
        public IActionResult CreateVenue([FromBody] Venue venueToAdd)
        {
            this._venueManager.AddVenue(venueToAdd);
            return Ok(venueToAdd);
        }

        [HttpPut]
        [Route("{id}")]
        public IActionResult UpdateVenue([FromRoute] int Id, [FromBody] Venue venueToUpdate)
        {
            return Ok(this._venueManager.UpdateVenueById(Id, venueToUpdate));
        }

        [HttpDelete]
        [Route("{id}")]
        public IActionResult DeleteVenue([FromRoute] int id)
        {
            Venue venueToDelete = _venueManager.DeleteVenueById(id);
            return Ok(venueToDelete);
        }
    }
}
