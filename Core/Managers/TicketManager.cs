using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Truextend.TicketDispenser.Core.Models;

namespace Truextend.TicketDispenser.Core.Managers
{
    public class TicketManager
    {
        private List<Ticket> _ticketList;
        public TicketManager() 
        {
            _ticketList = new List<Ticket>();
        }
    }
}
