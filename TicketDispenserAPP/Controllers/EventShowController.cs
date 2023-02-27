using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Truextend.TicketDispenser.Core.Managers;
using Truextend.TicketDispenser.Core.Models;

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
        public IActionResult CreateEvent(Guid id, string category, string name, DateTime date, string veneName, string city, string country, int capacity)
        {
            EventShow createdEvent = _eventManager.AddEvent(id, category, name, date, veneName, city, country, capacity);
            return Ok(createdEvent);
        }
        [HttpPut]
        [Route("{id}")]
        public IActionResult UpdateEvent([FromRoute] Guid id, [FromBody] EventShow selectedEvent)
        {
            EventShow eventToUpdate = _eventManager.UpdateEvent(id, selectedEvent);
            return Ok(eventToUpdate);
        }
        [HttpDelete]
        [Route("{Id}")]
        public IActionResult DeleteEvent([FromRoute] Guid Id) 
        {
            EventShow deletedEvent = _eventManager.DeleteEvent(Id);
            return Ok(deletedEvent);
        }
    }
}
