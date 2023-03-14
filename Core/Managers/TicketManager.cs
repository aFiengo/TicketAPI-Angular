using Microsoft.EntityFrameworkCore;
using Org.BouncyCastle.Bcpg;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Truextend.TicketDispenser.Core.Managers.Base;
using Truextend.TicketDispenser.Data;
using Truextend.TicketDispenser.Data.Models;
using static Truextend.TicketDispenser.Core.Managers.TicketManager;

namespace Truextend.TicketDispenser.Core.Managers
{
    public class TicketManager : IGenericManager<Ticket>
    {

        private readonly IUnitOfWork _uow;

        public TicketManager(IUnitOfWork uow) 
        {
            _uow = uow;   

        }
        public class TicketRequest
        {
            public int EventId { get; set; }
            public int ZoneId { get; set; }
            public int Quantity { get; set; }
            public int UserId { get; set; }
        }
        public async Task<IEnumerable<Ticket>>Create(TicketRequest ticketRequest)
        {
            return await _uow.TicketRepository.CreateTicketAsync(ticketRequest.EventId, ticketRequest.ZoneId, ticketRequest.Quantity, ticketRequest.UserId);
        }
        public async Task<IEnumerable<Ticket>> GetAll()
        {
            return await _uow.TicketRepository.GetAllAsync();
        }

        public Task<Ticket> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Ticket> Create(Ticket item)
        {
            throw new NotImplementedException();
        }

        public Task<Ticket> Update(int id, Ticket item)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(int itemId)
        {
            throw new NotImplementedException();
        }
    }

}
