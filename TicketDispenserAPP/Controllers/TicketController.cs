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
        public IActionResult GenerateTicket([FromBody] TicketRequest ticketRequest)
        {
            var tickets = _ticketManager.GenerateTicket(ticketRequest);
            return Ok(tickets);
        }
        [HttpGet]
        public IActionResult GetAllTickets()
        {
            Ticket tickets = _ticketManager.GetAllTickets()
        }
    }
}
