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
        public int EventShowId { get; set; }
        public EventShow EventShow { get; set; }
        public int ZoneId { get; set; }
        public Zone Zone { get; set; }
        public int Quantity { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }

    }
}
