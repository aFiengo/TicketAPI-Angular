using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Truextend.TicketDispenser.Data.Models.Base;

namespace Truextend.TicketDispenser.Data.Models
{
    public class EventZone : Entity
    {
        public int EventId { get; set; }
        public int ZoneId { get; set; }
    }
}
