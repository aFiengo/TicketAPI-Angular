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
        public EventShow EventShowInfo { get; set; }
        //public Zone ZoneInfo { get; set; }
        public int Quantity { get; set; }
        public User UserInfo { get; set; }

    }
}
