
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Truextend.TicketDispenser.Core.Managers;
using Truextend.TicketDispenser.Data.Models;

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
        public async Task<ActionResult> GetVenues()
        {
            IEnumerable<Venue> venues = await _venueManager.GetAll();
            return Ok(venues);
        }
        [HttpGet]
        [Route("{id}")]
        public async Task<ActionResult> GetVenueById(int id)
        {
            Venue venue = await _venueManager.GetById(id);
            return Ok(venue);
        }
        [HttpPost]
        public async Task<ActionResult> CreateVenue(Venue venueToAdd)
        {
            Venue createdVenue = await _venueManager.Create(venueToAdd);
            return Ok(createdVenue);
        }
        [HttpPut]
        [Route("{id}")]
        public async Task<ActionResult> UpdateVenue([FromRoute] int id, [FromBody] Venue selectedVenue)
        {
            Venue venueToUpdate = await _venueManager.Update(id, selectedVenue);
            return Ok(venueToUpdate);
        }

        [HttpDelete]
        [Route("{id}")]
        public async Task<ActionResult> DeleteVenue([FromRoute] int id)
        {
            bool venueToDelete = await _venueManager.Delete(id);
            return Ok(venueToDelete);
        }
    }
    
}
