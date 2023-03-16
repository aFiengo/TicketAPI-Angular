using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Truextend.TicketDispenser.Core.Managers;
using Truextend.TicketDispenser.Core.Models;
using Truextend.TicketDispenser.Data.Models;
using AutoMapper;

namespace Truextend.TicketDispenser.TicketDispenserAPI.Controllers
{
    [Route("api/event")]
    [ApiController]
    public class EventShowController : ControllerBase
    {
        private readonly EventShowManager _eventManager;
        private readonly IMapper _mapper;
        public EventShowController(EventShowManager eventManager, IMapper mapper)
        {
            _eventManager = eventManager;
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<ActionResult> GetEvents()
        {
            IEnumerable<EventShow> eventShows = await _eventManager.GetAll();
            IEnumerable<EventShowDTO> eventShowDTOs = _mapper.Map<IEnumerable<EventShowDTO>>(eventShows);
            return Ok(eventShowDTOs);
        }
        [HttpGet]
        [Route("{id}")]
        public async Task<ActionResult> GetEventById(int id)
        {
            EventShow eventShow = await _eventManager.GetById(id);
            EventShowDTO eventShowDTO =  _mapper.Map<EventShowDTO>(eventShow);
            return Ok(eventShowDTO);
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
