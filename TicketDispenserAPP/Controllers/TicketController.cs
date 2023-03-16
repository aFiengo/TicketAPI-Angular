using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Truextend.TicketDispenser.Core.Managers;
using Truextend.TicketDispenser.Core.Models;
using Truextend.TicketDispenser.Data.Models;
using static Truextend.TicketDispenser.Core.Managers.TicketManager;

namespace Truextend.TicketDispenser.TicketDispenserAPI.Controllers
{
    [Route("api/ticket")]
    [ApiController]
    public class TicketController : ControllerBase
    {
        private readonly TicketManager _ticketManager;
        private readonly IMapper _mapper;
        public TicketController(TicketManager ticketManager, IMapper mapper)
        {
            _ticketManager = ticketManager;
            _mapper = mapper;
        }
        [HttpPost]
        [Route("generate")]
        public async Task<IActionResult> GenerateTickets([FromBody] TicketRequest ticketRequest)
        {
            IEnumerable<Ticket> tickets = await _ticketManager.Create(ticketRequest);
            IEnumerable<TicketDTO> ticketDTOs = _mapper.Map<IEnumerable<TicketDTO>>(tickets);
            return Ok(ticketDTOs);
        }
        [HttpGet]
        public async Task<IActionResult> GetAllTickets()
        {
            IEnumerable<Ticket> tickets = await _ticketManager.GetAll();
            IEnumerable<TicketDTO> ticketDTOs = _mapper.Map<IEnumerable<TicketDTO>>(tickets);
            return Ok(ticketDTOs);
        }
    }
}
