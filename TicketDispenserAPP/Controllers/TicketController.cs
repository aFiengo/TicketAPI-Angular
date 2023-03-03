using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Truextend.TicketDispenser.Core.Managers;
using Truextend.TicketDispenser.Core.Models;
using static Truextend.TicketDispenser.Core.Managers.TicketManager;

namespace Truextend.TicketDispenser.TicketDispenserAPI.Controllers
{
    [Route("api/ticket")]
    [ApiController]
    public class TicketController : ControllerBase
    {
        private readonly TicketManager _ticketManager;
        public TicketController(TicketManager ticketManager)
        {
            _ticketManager = ticketManager;
        }
        [HttpPost]
        [Route ("generate")]
        public IActionResult GenerateTickets([FromBody] TicketRequest ticketRequest)
        {
            var tickets = _ticketManager.GenerateTickets(ticketRequest);
            return Ok(tickets);
        }
        [HttpGet]
        public IActionResult GetAllTickets()
        {
            var tickets = _ticketManager.GetAllTickets();
            return Ok(tickets);
        }
    }
}
