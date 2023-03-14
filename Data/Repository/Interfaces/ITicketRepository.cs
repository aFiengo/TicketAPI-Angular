﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Truextend.TicketDispenser.Data.Models;
using Truextend.TicketDispenser.Data.Repository.Base;

namespace Truextend.TicketDispenser.Data.Repository.Interfaces
{
    public interface ITicketRepository : IRepository<Ticket>
    {
        Task<Ticket> CreateTicketAsync(int eventId, int quantity, int userId);
    }
}
