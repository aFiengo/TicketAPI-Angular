
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Truextend.TicketDispenser.Data.Models.Base;

namespace Truextend.TicketDispenser.Data.Models
{
    public class EventShow : Entity
    {
        public Category Category { get; set; }
        public string Name { get; set; }
        public DateTime EventDate { get; set; }
        public Venue Location { get; set; }
        public List<Zone> Zones { get; set; }
    }
}
