using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Truextend.TicketDispenser.Core.Models
{ 
    public class Ticket
    {
        public Guid Id { get; set; }
        public EventShow EventShowName { get; set; }
        public Zone Zone { get; set; }
        public int Quantity { get; set; }
        public User User { get; set; }

    }
}
