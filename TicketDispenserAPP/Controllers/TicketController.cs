using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Truextend.TicketDispenser.Core.Managers;
using Truextend.TicketDispenser.Core.Models;
using Truextend.TicketDispenser.TicketDispenserAPI.Controllers.Base;

namespace Truextend.TicketDispenser.TicketDispenserAPI.Controllers
{
    [Route("api/ticket")]
    [ApiController]
    public class TicketController : TicketBaseController<Ticket>
    {
        private readonly TicketManager _ticketManager;
        public TicketController(TicketManager ticketManager) : base(ticketManager)
        {
            _ticketManager = ticketManager;
        }
    }
}
