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
        public async Task<ActionResult> GetEvents()
        {
            IEnumerable<EventShow> eventShow = await _eventManager.GetAll();
            return Ok(eventShow);
        }
        [HttpGet]
        [Route("{id}")]
        public async Task<ActionResult> GetEventById(int id)
        {
            EventShow eventShow = await _eventManager.GetById(id);
            return Ok(eventShow);
        }
        [HttpPost]
        public async Task<ActionResult> CreateEventShow(EventShow eventToAdd)
        {
            EventShow createdEventShow = await _eventManager.Create(eventToAdd);
            return Ok(createdEventShow);
        }
        [HttpPut]
        [Route("{id}")]
        public async Task<ActionResult> UpdateEventShow([FromRoute] int id, [FromBody] EventShow selectedEvent)
        {
            EventShow eventToUpdate = await _eventManager.Update(id, selectedEvent);
            return Ok(eventToUpdate);
        }
        [HttpDelete]
        [Route("{id}")]
        public async Task<ActionResult> DeleteEventShow([FromRoute] int id)
        {
            bool eventToDelete = await _eventManager.Delete(id);
            return Ok(eventToDelete);
        }
    }
}
