using AutoMapper;
using Truextend.TicketDispenser.Core.Managers.Base;
using Truextend.TicketDispenser.Core.Models;
using Truextend.TicketDispenser.Data;
using Truextend.TicketDispenser.Data.Models;

namespace Truextend.TicketDispenser.Core.Managers
{
    public class TicketManager : IGenericManager<TicketDTO>
    {

        private readonly IUnitOfWork _uow;
        private readonly IMapper _mapper;

        public TicketManager(IUnitOfWork uow, IMapper mapper) 
        {
            _uow = uow;   
            _mapper = mapper;

        }
        public class TicketRequest
        {
            public int EventId { get; set; }
            public int ZoneId { get; set; }
            public int Quantity { get; set; }
            public int UserId { get; set; }
        }
        public async Task<IEnumerable<TicketDTO>>Create(TicketRequest ticketRequest)
        {
            IEnumerable<Ticket> tickets = await _uow.TicketRepository.CreateTicketAsync(ticketRequest.EventId, ticketRequest.ZoneId, ticketRequest.Quantity, ticketRequest.UserId);
            return _mapper.Map<IEnumerable<TicketDTO>>(tickets);
        }
        public async Task<IEnumerable<TicketDTO>> GetAll()
        { 
            IEnumerable<Ticket> tickets = await _uow.TicketRepository.GetAllTickets();
            return _mapper.Map<IEnumerable<TicketDTO>>(tickets);
        }

        public Task<TicketDTO> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<TicketDTO> Create(TicketDTO item)
        {
            throw new NotImplementedException();
        }

        public Task<TicketDTO> Update(int id, TicketDTO item)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(int itemId)
        {
            throw new NotImplementedException();
        }
    }

}
