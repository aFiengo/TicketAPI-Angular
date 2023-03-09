using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Truextend.TicketDispenser.Data.Models.Base;

namespace Truextend.TicketDispenser.Data.Models
{ 
    public class Ticket : Entity
    {
        public Guid Id { get; set; }
        public EventShow EventShowInfo { get; set; }
        //public Zone ZoneInfo { get; set; }
        public int Quantity { get; set; }
        public User UserInfo { get; set; }

    }
}
