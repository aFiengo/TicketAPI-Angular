
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Truextend.TicketDispenser.Data.Models.Base;

namespace Truextend.TicketDispenser.Data.Models
{
    public class EventShow : Entity
    {
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public string Name { get; set; }
        public DateTime EventDate { get; set; }
        public List<EventZone> EventZones { get; set; }
        public List<Ticket> Tickets { get; set; }

        public List<EventVenue> EventVenues { get; set; }

    }
}
