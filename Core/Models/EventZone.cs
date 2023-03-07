using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Truextend.TicketDispenser.Core.Models.Base;

namespace Truextend.TicketDispenser.Core.Models
{
    public class EventZone : Entity
    {
        public int EventId { get; set; }
        public int ZoneId { get; set; }
    }
}
