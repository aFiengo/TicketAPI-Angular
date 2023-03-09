using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Truextend.TicketDispenser.Core.Managers;
using Truextend.TicketDispenser.Data.Models;

namespace Truextend.TicketDispenser.TicketDispenserAPI.Controllers
{
    [Route("api/event")]
    [ApiController]
    public class EventShowController : ControllerBase
    {
        private readonly EventShowManager _eventManager;
        public EventShowController(EventShowManager eventManager)
        {
            _eventManager = eventManager;
        }
        [HttpGet]
        public IActionResult GetEvents()
        {
            List<EventShow> events = _eventManager.GetEvents();
            return Ok(events);
        }
        [HttpPost]
        public IActionResult CreateEvent([FromBody] EventShow eventToAdd, int categoryId, int venueId)
        {
            this._eventManager.AddEvent(eventToAdd, categoryId, venueId);
            return Ok(eventToAdd);
        }
        [HttpPut]
        [Route("{id}")]
        public IActionResult UpdateEvent([FromRoute] int id, [FromBody] EventShow selectedEvent)
        {
            EventShow eventToUpdate = _eventManager.UpdateEventById(id, selectedEvent);
            return Ok(eventToUpdate);
        }
        [HttpDelete]
        [Route("{id}")]
        public IActionResult DeleteEvent([FromRoute] int Id) 
        {
            EventShow deletedEvent = _eventManager.DeleteEventById(Id);
            return Ok(deletedEvent);
        }
    }
}
