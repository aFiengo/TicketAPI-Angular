using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Truextend.TicketDispenser.Core.Managers;
using Truextend.TicketDispenser.Data.Models;
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
        [Route("generate")]
        public async Task<IActionResult> GenerateTickets([FromBody] TicketRequest ticketRequest)
        {
            IEnumerable<Ticket> tickets = await _ticketManager.Create(ticketRequest);
            return Ok(tickets);
        }
        [HttpGet]
        public async Task<IActionResult> GetAllTickets()
        {
            IEnumerable<Ticket> tickets = await _ticketManager.GetAll();
            return Ok(tickets);
        }
    }
}
